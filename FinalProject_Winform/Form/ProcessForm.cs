using FinalProject_Winform.Data;
using FinalProject_Winform.Models.domain;
using FinalProject_Winform.Repositories;
using Microsoft.VisualBasic.Logging;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProject_Winform
{
    public partial class ProcessForm : Form
    {
        private IProcessRepository processRepository;
        private ILothistoryRepository lothistoryRepository;
        private ILotRepository lotRepository;
        private MainForm mainForm;
        public ProcessForm(MainForm mainForm)
        {
            InitializeComponent();
            this.mainForm = mainForm;
            processRepository = new ProcessRepository();
            lothistoryRepository = new LothistoryRepository();
            lotRepository = new LotRepository();
        }
        DataGridView dgvImport;
        private void ProcessForm_Load(object sender, EventArgs e)
        {
            dgvImport = dataGridView1;
        }
        private void Button_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;
            if (button != null)
            {
                string formName = button.Name.Replace("btn_", "");
                this.Close();
                FormUtility.OpenForm(formName, mainForm);
            }
        }
        //메인폼으로 돌아가기
        private void ProcessForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            //mainForm.Show();
            //this.Hide();
        }

        private void tabControl1_Selected(object sender, TabControlEventArgs e)
        {
            switch (e.TabPageIndex)
            {
                case 0:  // 공정 조회

                    break;
            }
        }

        //----------------------------------------------------------------------------
        //첫번째 탭
        //----------------------------------------------------------------------------
        private async void LoadProcessAsync()
        {
            // 검색 공정을 지났던 LOTID로 가져오기
            string processSearch = ProcessSearch.Text;

            List<LotHistory> lotHistories = await lothistoryRepository.GetLotId(processSearch);

            dgvImport.Rows.Clear();
            dgvImport.Refresh();

            foreach (LotHistory lotHistory in lotHistories)
            {
                int rowIndex = dgvImport.Rows.Add();
                dgvImport.Rows[rowIndex].Cells["LOT_ID"].Value = lotHistory.LotId;
                //dgvImport.Rows[rowIndex].Cells["LOT_NAME"].Value = lotHistory.Lot.Item.Item_name;
                dgvImport.Rows[rowIndex].Cells["LOT_StartDate"].Value = "+" + lotHistory.LotHistory_Date;
                dgvImport.Rows[rowIndex].Cells["LOT_STATUS"].Value = lotHistory.LotHistory_status;
            }
        }
        private async void btnSearchProcess_Click(object sender, EventArgs e)
        {
            LoadProcessAsync();
        }
        //----------------------------------------------------------------------------
        //두번째 탭
        //----------------------------------------------------------------------------
        private async void combo_process_SelectedIndexChanged(object sender, EventArgs e)
        {
            // combo_process에서 선택한 값 가져오기
            string selectedProcess = combo_process.SelectedItem.ToString();
            var processesStatus = await processRepository.GetSelectedProcessStatus(selectedProcess);
            if (processesStatus == "True")
            {
                label6.Text = "작동중";
            }
            else
            {
                label6.Text = "정지";
            }
        }

        //DB status 값 변경하기
        private async Task ProcessOnOffAsync(bool processesStatus)
        {
            // combo_process에서 선택한 값 가져오기
            string selectedProcess = combo_process.SelectedItem.ToString();

            //전원이 켜진 상태이면 꺼짐으로 바꿈
            if (processesStatus == true)
            {
                await processRepository.IsRunningAsync(processesStatus, selectedProcess);
                label6.Text = "꺼짐";
            }
            //전원이 꺼진 상태이면 작동중으로 바꿈
            else
            {
                await processRepository.IsRunningAsync(processesStatus, selectedProcess);
                label6.Text = "작동중";
            }
        }

        //설비 전원 켜기
        private async void btnOn_Click(object sender, EventArgs e)
        {
            string selectedProcess = combo_process.SelectedItem.ToString();
            var processesStatus = await processRepository.GetSelectedProcessStatus(selectedProcess);
            bool state = true;
            if (processesStatus == "True")
            {
                state = true;
            }
            else
            {
                state = false;
            }
            //아두이노에 전원 켜라고 시리얼 통신보내기
            SendSerialOnOff(state);
            //DB status 값 true로 변경하기
            ProcessOnOffAsync(state);
        }
        //설비 전원 끄기
        private async void btnOff_Click(object sender, EventArgs e)
        {
            string selectedProcess = combo_process.SelectedItem.ToString();
            var processesStatus = await processRepository.GetSelectedProcessStatus(selectedProcess);
            bool state = true;
            if (processesStatus == "True")
            {
                state = true;
            }
            else
            {
                state = false;
            }
            //아두이노에 전원 끄라고 시리얼 통신보내기
            SendSerialOnOff(state);
            //DB status 값 false로 변경하기
            ProcessOnOffAsync(state);
        }

        //----------------------------------------------------------------------------
        //시리얼 통신
        //----------------------------------------------------------------------------

        //아두이노에게 통신 보낼때 
        public async void SendSerialOnOff(bool status)
        {
            // combo_process에서 선택한 값 가져오기
            string selectedProcess = combo_process.SelectedItem.ToString();
            long ProcessId =  processRepository.GetProcessId(selectedProcess);
            long RecentLotId = await lothistoryRepository.GetRecentLotAsync(ProcessId);

            //현재 상태에 따라 다른 메시지 작성
            string message = "";
            if (status == true)
            {
                message = $"$Off,{selectedProcess},{RecentLotId}";
            }
            else
            {
                message = $"$On,{selectedProcess},{RecentLotId}";
            }

            //아두이노에게 시리얼 통신 보내기
            mainForm.serialPort.WriteLine(message);
        }


    }// end class 
}
