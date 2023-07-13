using FinalProject_Winform.Models.domain;
using FinalProject_Winform.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
                        ExecCommand(recvData);
                    }
                }
                catch (TimeoutException) { }  // ReadTimeout = 0;  // 읽기 timeout (ms) 을 0 으로 하자.
            }
        }  
        
        //---------------------------------------
        // Command 에 따른 분기
        private void ExecCommand(string recvData)
        {
            if (recvData.Length == 0 || recvData[0] != '$') return;

            string[] arrMessage = recvData[1..].Split(",", StringSplitOptions.RemoveEmptyEntries);
            int lotpk = int.Parse(arrMessage[2]);
            switch (arrMessage[0]) // Command
            {
                case "Recieve": //명령 받음
                    ProcessReady(arrMessage[1], lotpk);
                    break;
                case "Start": //공정 시작
                    //ProcessReject(arrMessage[1]);
                    break;
                case "End": //공정 종료
                    //ProcessProcess(arrMessage[1]);
                    break;
                case "Off": //전원 껐을때 (일시정지)
                    //ProcessAccept(arrMessage[1]);
                    break;
                case "On": //전원 켰을때 

                    break;
            } // end switch

        } // end ExecCommand()

        private void ProcessReady(string message, int b)
        {
           lotRepository.Updateasync($"{message}start",b);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            // MainForm이 로드될 때 수행할 작업
            string port = $"COM4";  // 여기 바꾸셈

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

        //버튼 클릭 이벤트 하나로 묶어둔 함수
        private void Button_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;
            if (button != null)
            {
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
