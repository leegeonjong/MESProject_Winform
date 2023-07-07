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
    public partial class TestForm : Form
    {
        public TestForm()
        {
            InitializeComponent();
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
        private void Form6_Load(object sender, EventArgs e)
        {

        }
        
        //메인폼으로 돌아가기
        private void TestForm_FormClosed(object sender, FormClosedEventArgs e)
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
