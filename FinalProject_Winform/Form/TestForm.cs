using FinalProject_Winform.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.AccessControl;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.AxHost;

namespace FinalProject_Winform
{
    public partial class TestForm : Form
    {
        private MainForm mainForm;
        private IProcessRepository processRepository;
        public TestForm(MainForm mainForm)
        {
            InitializeComponent();
            this.mainForm = mainForm;
            processRepository = new ProcessRepository();
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
        private void Form6_Load(object sender, EventArgs e)
        {
            //공정 선택 콤보박스 안보이게 하기
            txtHiding.Visible = true;
            cmbProcess1.Visible = false;
            cmbProcess2.Visible = false;
            cmbProcess3.Visible = false;
        }

        //메인폼으로 돌아가기
        private void TestForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            //mainForm.Show();
            //this.Hide();
        }

        //사용자가 선택한 검사 현재 기준값 가져오기
        private async void cmbProcess_SelectedIndexChagned(int num)
        {
            //사용자가 선택한 공정 가져오기
            string selectedProcessName = "";
            //사용자가 선택한 검사 가져오기
            string selectedTestName = cmbTest.SelectedItem.ToString();
            switch (num)
            {
                case 1:
                    selectedProcessName = cmbProcess1.SelectedItem?.ToString();
                    break;
                case 2:
                    selectedProcessName = cmbProcess2.SelectedItem?.ToString();
                    break;
                case 3:
                    selectedProcessName = cmbProcess3.SelectedItem?.ToString();
                    break;
            }

            //현재 검사 설정값 가져오기
            long checkValue = await processRepository.NowThreshold(selectedProcessName, selectedTestName);
            txtNowValue.Text = checkValue.ToString();
        }


        //오류메시지 함수
        private bool ShowError()
        {
            string selectedTestName = cmbTest.SelectedItem?.ToString();
            string selectedProcessName1 = cmbProcess1.SelectedItem?.ToString();
            string selectedProcessName2 = cmbProcess2.SelectedItem?.ToString();
            string selectedProcessName3 = cmbProcess3.SelectedItem?.ToString();

            if (txtSetValue.Text == "")
            {
                MessageBox.Show("기준값을 입력하세요");
                return true;
            }
            if (string.IsNullOrEmpty(selectedTestName))
            {
                MessageBox.Show("검사를 선택하세요");
                return true;
            }
            if (string.IsNullOrEmpty(selectedProcessName1) && string.IsNullOrEmpty(selectedProcessName2) && string.IsNullOrEmpty(selectedProcessName3))
            {
                MessageBox.Show("공정을 선택하세요");
                return true;
            }
            return false;
        }

        //사용자가 입력한 검사 기준값 DB 에 입력하기
        private async void SetThreshold_Click(object sender, EventArgs e)
        {
            //입력 안한 값이 있으면 메시지 띄우기
            if (ShowError())
            {
                return;
            }

            // combo_process에서 선택한 값 가져오기
            string selectedProcessName = cmbProcess1.SelectedItem.ToString();
            string selectedTestName = cmbTest.SelectedItem.ToString();
            // 사용자가 입력한 기준값 가져오기
            long SetValue = long.Parse(txtSetValue.Text);

            await processRepository.SetThreshold(selectedProcessName, selectedTestName, SetValue);

            //기준값 입력 성공 메시지 박스 띄우기
            MessageBox.Show("설정 완료");

            //바뀐 검사값으로 다시 가져오기
            long checkValue = await processRepository.NowThreshold(selectedProcessName, selectedTestName);
            txtNowValue.Text = checkValue.ToString();
        }

        //선택한 검사에 따라 다른 콤보박스를 보이게 함
        private void cmbTest_SelectedIndexChanged(object sender, EventArgs e)
        {
            //사용자가 선택한 검사
            string selectedTest = cmbTest.SelectedItem.ToString();

            txtHiding.Visible = false;
            //cmbProcess1 : 수량검사(입출고 개수 확인)
            //cmbProcess2 : 온도검사(찌는거 온도)
            //cmbProcess3 : 용량검사(팜유 용량)

            // 수량 검사 선택 시
            if (selectedTest == "수량 검사")
            {
                cmbProcess1.Visible = true;
                cmbProcess2.Visible = false;
                cmbProcess3.Visible = false;
            }
            // 온도 검사 선택 시
            else if (selectedTest == "온도 검사")
            {
                cmbProcess1.Visible = false;
                cmbProcess2.Visible = true;
                cmbProcess3.Visible = false;
            }
            // 용량 검사 선택 시
            else if (selectedTest == "용량 검사")
            {
                cmbProcess1.Visible = false;
                cmbProcess2.Visible = false;
                cmbProcess3.Visible = true;
            }

        }


        private void cmbProcess1_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbProcess_SelectedIndexChagned(1);
        }

        private void cmbProcess2_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbProcess_SelectedIndexChagned(2);
        }

        private void cmbProcess3_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbProcess_SelectedIndexChagned(3);
        }
    }
}
