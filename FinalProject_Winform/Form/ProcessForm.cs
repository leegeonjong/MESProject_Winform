using FinalProject_Winform.Models.domain;
using FinalProject_Winform.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProject_Winform
{
    public partial class ProcessForm : Form
    {
        private IProcessRepository processRepository;
        public ProcessForm()
        {
            InitializeComponent();
            processRepository = new ProcessRepository();
        }
        DataGridView dgvImport;
        private void ProcessForm_Load(object sender, EventArgs e)
        {
            dgvImport = dataGridView1;
            //LoadProcessAsync();
        }
        private void Button_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;
            if (button != null)
            {
                string formName = button.Name.Replace("btn_", "");
                FormUtility.OpenForm(formName, this);
            }
        }
        //메인폼으로 돌아가기
        private void ProcessForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            var MainForm = Application.OpenForms["MainForm"] as MainForm;

            if (MainForm != null)
            {
                MainForm = new MainForm();
                MainForm.Show();
            }
            this.Hide();
        }

        private void tabControl1_Selected(object sender, TabControlEventArgs e)
        {
            switch (e.TabPageIndex)
            {
                case 0:  // 공정 조회
                    LoadProcessAsync();
                    break;
                case 1:  // 설비 설정
                    SetProcess();
                    break;

            }
        }

        //----------------------------------------------------------------------------
        //첫번째 탭
        //----------------------------------------------------------------------------
        private async void LoadProcessAsync()
        {
            //var processes = await processRepository.GetAllAsync();

            //// DataGridView 전체 clear
            //dgvImport.Rows.Clear();
            //dgvImport.Refresh();

            //int i = 0;
            //foreach (var process in processes)
            //{
            //    dgvImport.Rows.Add();  // 새로운 row 추가
            //    dgvImport.Rows[i].Cells["lot_barcode"].Value = process.lot.Lot_barcode;
            //    dgvImport.Rows[i].Cells["lot_status"].Value = process.lot.Lot_status;
            //    dgvImport.Rows[i].Cells["lothistory_datetime_Start"].Value = "+" + process.lotHistory.LotHistory_startDate;
            //    dgvImport.Rows[i].Cells["lothistory_datetime_End"].Value = process.lotHistory.LotHistory_endDate;

            //    i++;
            //}
        }

        //----------------------------------------------------------------------------
        //두번째 탭
        //----------------------------------------------------------------------------

        private async void SetProcess()
        {
            //var processes = await processRepository.GetAllAsync();


        }

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
                label6.Text = "꺼짐";
            }
        }

        private async Task ProcessOnOffAsync(bool State)
        {
            // combo_process에서 선택한 값 가져오기
            string selectedProcess = combo_process.SelectedItem.ToString();

            //전원이 켜진 상태이면
            if (State == true)
            {
                await processRepository.IsRunningAsync(State,selectedProcess);
                label6.Text = "작동중";
            }
            //전원이 꺼진 상태이면
            else
            {
                await processRepository.IsRunningAsync(State,selectedProcess);
                label6.Text = "꺼짐";
            }
        }

        //설비 전원 켜기
        private void btnOn_Click(object sender, EventArgs e)
        {
            ProcessOnOffAsync(true);
        }
        //설비 전원 끄기
        private void btnOff_Click(object sender, EventArgs e)
        {
            ProcessOnOffAsync(false);
        }
    }
}
