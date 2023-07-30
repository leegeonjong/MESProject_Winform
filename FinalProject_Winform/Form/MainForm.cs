using FinalProject_Winform.Models.domain;
using FinalProject_Winform.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProject_Winform
{
    public partial class MainForm : Form
    {
        private ILotRepository lotRepository;
        private ILothistoryRepository lothistoryRepository;
        private IProcessRepository processRepository;

        private LOTForm lotForm;

        public MainForm()
        {
            InitializeComponent();

            // 시리얼 포트 생성
            serialPort = new();
            serialPort.BaudRate = 9600;
            serialPort.DataReceived += serialPort_DataReceived;

            serialPort.ReadTimeout = 0;
            lotRepository = new LotRepository();
            lothistoryRepository = new LothistoryRepository();
            processRepository = new ProcessRepository();

            // MainForm이 로드될 때 수행할 작업
            //string port = $"COM8";  // 이건종
            string port = $"COM4";

            serialPort.PortName = port;   //시리얼 포트 설정

            // 시리얼 통신 시작
            if (serialPort.IsOpen)
            {
                // 이미 COM 포트 오픈 되어 있으면. 아무것도 안함.
                MessageBox.Show($"이미 {port}는 열려 있습니다");
            }
            else
            {
                // 연결이 안되어 있으면 연결한다.
                serialPort.Open();
            }
        }
        public SerialPort serialPort;
        private void serialPort_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            if (serialPort.IsOpen)
            {
                try
                {
                    while (true)
                    {
                        string input = "";
                        string recvData = serialPort.ReadLine().Trim();   // Trim() 꼭 해야 한다 
                        input = $"← {recvData}";
                        ShowMessage(input); // ListBox 에 출력
                        ExecCommand(recvData);
                    }
                }
                catch (TimeoutException) { }  // ReadTimeout = 0;  // 읽기 timeout (ms) 을 0 으로 하자.
            }
        }

        public void ShowMessage(string message)
        {
            string[] dataParts = message.Split(',');

            if (dataParts.Length >= 2)
            {
                string status = dataParts[0].Replace("← $", "").Trim();
                string process = dataParts[1].Trim();
                string lotid = dataParts[2].Trim();


                switch (process)
                {
                    case "Mix":
                        SetLabelBackColor(panel5, MixStatus, status, lotid);
                        AddToListBox(listBox1, message);
                        break;
                    case "Shape":
                        SetLabelBackColor(panel7, ShapeStatus, status, lotid);
                        AddToListBox(listBox2, message);
                        break;
                    case "Steam":
                        SetLabelBackColor(panel9, SteamStatus, status, lotid);
                        AddToListBox(listBox3, message);
                        break;
                    case "Fry":
                        SetLabelBackColor(panel11, FryStatus, status, lotid);
                        AddToListBox(listBox4, message);
                        break;
                    case "Freeze":
                        SetLabelBackColor(panel13, FreezeStatus, status, lotid);
                        AddToListBox(listBox5, message);
                        break;
                    case "Pack":
                        SetLabelBackColor(panel15, PackStatus, status, lotid);
                        AddToListBox(listBox6, message);
                        break;
                }
            }
        }

        private void SetLabelBackColor(Panel panel, Label label, string status, string lotid)
        {


            if (panel.InvokeRequired)
            {
                // 다른 스레드에서 호출한 경우, 메인 UI 스레드로 인보크하여 작업을 수행합니다.
                panel.Invoke(new Action(() => SetLabelBackColor(panel, label, status, lotid)));
            }
            else
            {
                switch (status)
                {
                    case "Start":
                        panel.BackColor = Color.Green;
                        label.Text = "상태 : 가동중 /" + " LOT번호 : " + lotid;
                        break;
                    case "End":
                        panel.BackColor = Color.Red;
                        label.Text = "상태 : 종료 / " + " LOT번호 : " + lotid;
                        break;
                    case "Stop":
                        panel.BackColor = Color.Yellow;
                        label.Text = "상태 : 정지 / " + " LOT번호 : " + lotid;
                        break;
                    default:
                        panel.BackColor = SystemColors.Control;
                        break;
                }


                panel.Refresh();
                label.Refresh();
            }
        }


        private void AddToListBox(ListBox listBox, string message)
        {
            if (listBox.InvokeRequired)
            {
                listBox.Invoke(() =>
                {
                    listBox.Items.Add(message);
                    listBox.TopIndex = listBox.Items.Count - 1;  // scroll to end
                });
            }
            else
            {
                listBox.Items.Add(message);
                listBox.TopIndex = listBox.Items.Count - 1;  // scroll to end
            }
        }

        //---------------------------------------
        // Command 에 따른 분기
        private async void ExecCommand(string recvData)
        {
            if (recvData.Length == 0 || recvData[0] != '$') return;

            string[] arrMessage = recvData[1..].Split(",", StringSplitOptions.RemoveEmptyEntries);
            long lotpk = long.Parse(arrMessage[2]);
            long data = 0;

            if (arrMessage.Length >= 4)
            {
                data = long.Parse(arrMessage[3]);
            }
         

            switch (arrMessage[0]) // arrMessage[0] = 공정행동, arrMessage[1] = 공정명, arrmessage[2] = lotid
            {
                case "Recieve": //명령 받음
                                //ProcessReady(arrMessage[1], lotpk);
                    break;
                case "Start": //공정 시작
                    ProcessStart(arrMessage[1], lotpk);
                    break;
                case "End": //공정 종료
                    ProcessEnd(arrMessage[1], lotpk);
                    break;
                case "Stop": //전원 껐을때 (일시정지)
                    ProcessOff(arrMessage[1], lotpk);
                    break;
                case "Continue": //전원 켰을때 
                    ProcessOn(arrMessage[1], lotpk);
                    break;
                case "Data": //검사값 받았을때
                    await ProcessTest(arrMessage[1], lotpk, data); //lotpk에는 검사값이 들어감
                    break;
            } // end switch

        } // end ExecCommand()

        private async Task ProcessTest(string process, long lotpk, long data)
        {
            if (data == 0)
            {
                return;
            }
            //공정 id 가져오기
            long processid = processRepository.GetProcessId(process);


            //검사 기준값 가져오기 
            long? checkValue = await processRepository.GetTestCheckValue(processid, data);

            //만약 검사 기준값이 설정 되어있지 않으면 기준값은 0
            if (!checkValue.HasValue)
            {
                checkValue = 0;
                //메시지 표시
                MessageBox.Show("검사 기준값이 없습니다.");
            }

            //-------------------검사 기준값과 data 비교하기--------------------------
            // 오차 계산
            double errorPercentage = Math.Abs((double)(checkValue - data)) / (double)data * 100;

            //오차 허용범위값 가져오기
            long? tolerance = await processRepository.GetTestToleranceValue(processid, data);

            //검사결과 checkresult 저장
            await lothistoryRepository.SaveTestData(lotpk, processid, data);

            //만약 허용범위값이 설정 되어있지 않으면 5%
            if (!tolerance.HasValue)
            {
                tolerance = 5;
                //메시지 표시
                MessageBox.Show("검사 기준값이 없습니다.");
            }
            bool pass = true;
            if (errorPercentage <= tolerance)
            {
                // 오차가 5% 내외인 경우
                lotRepository.UpdateLotbreak(lotpk, pass);
            }
            else
            {
                // 오차가 5% 이상인 경우
                pass = false;
                lotRepository.UpdateLotbreak(lotpk, pass);
            }

            //공정 id 로 해당 검사에 검사 data 입력하기
            await processRepository.SaveTestData(processid, data);
            //lotHistory에 저장
            await lothistoryRepository.SaveTestData(lotpk, processid, data);
        }


        private void ProcessOn(string process, long lotpk)
        {
            long processid = processRepository.GetProcessId(process);
            lothistoryRepository.AddLotAsync(lotpk, processid, $"{process}On");
            lotRepository.Updateasync($"{process}On", lotpk);
        }

        private void ProcessOff(string process, long lotpk)
        {
            long processid = processRepository.GetProcessId(process);
            lothistoryRepository.AddLotAsync(lotpk, processid, $"{process}Off");
            lotRepository.Updateasync($"{process}Off", lotpk);
        }

        private void ProcessEnd(string process, long lotpk)
        {
            //lotForm.loadLot(); //여기서 오류발생
            long processid = processRepository.GetProcessId(process);
            lothistoryRepository.AddLotAsync(lotpk, processid, $"{process}End");
            lotRepository.Updateasync($"{process}End", lotpk);
            lotRepository.ItemUpdateAsync(lotpk);
        }

        private void ProcessStart(string process, long lotpk)
        {
            long processid = processRepository.GetProcessId(process);
            lothistoryRepository.AddLotAsync(lotpk, processid, $"{process}ing");
            lotRepository.Updateasync($"{process}ing", lotpk);
        }

        //버튼 클릭 이벤트 하나로 묶어둔 함수
        private void Button_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;
            if (button != null)
            {
                //버튼의 이름에서 Form 이름 가져오기
                string formName = button.Name.Replace("btn_", "");
                FormUtility.OpenForm(formName, this);
            }
        }

        //닫으면 모든 폼 닫기 
        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            // 숨겨진 폼을 담을 복사본 컬렉션 생성
            var hiddenForms = new List<Form>();

            // 숨겨진 모든 폼을 복사본 컬렉션에 추가
            foreach (Form form in Application.OpenForms)
            {
                if (form != this && !form.IsDisposed && !form.Visible)
                {
                    hiddenForms.Add(form);
                }
            }

            // 복사본 컬렉션의 폼 닫기
            foreach (Form form in hiddenForms)
            {
                form.Close();
            }
        }
    }
}
