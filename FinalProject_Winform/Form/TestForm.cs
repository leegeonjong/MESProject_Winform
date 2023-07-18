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
using static System.Windows.Forms.AxHost;

namespace FinalProject_Winform
{
    public partial class TestForm : Form
    {
        private MainForm mainForm;
        public TestForm(MainForm mainForm)
        {
            InitializeComponent();
            this.mainForm = mainForm;
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

        }

        //메인폼으로 돌아가기
        private void TestForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            //mainForm.Show();
            //this.Hide();
        }

        private void SetThreshold_Click(object sender, EventArgs e)
        {
            // combo_process에서 선택한 값 가져오기
            string selectedProcess = cmbProcess1.SelectedItem.ToString();
            string selectedTest =  cmbTest.SelectedItem.ToString();

            //전원이 켜진 상태이면
            if (State == true)
            {
                await processRepository.IsRunningAsync(State, selectedProcess);
                label6.Text = "작동중";
            }
            //전원이 꺼진 상태이면
            else
            {
                await processRepository.IsRunningAsync(State, selectedProcess);
                label6.Text = "꺼짐";
            }
        }
    }
}
