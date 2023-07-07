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
    public partial class ChartForm : Form
    {
        public ChartForm()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {

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

        //메인폼으로 돌아가기
        private void ChartForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            var MainForm = Application.OpenForms["MainForm"] as MainForm;

            if (MainForm == null)
            {
                MainForm = new MainForm();
                MainForm.Show();
            }
            this.Hide();
        }
    }
}
