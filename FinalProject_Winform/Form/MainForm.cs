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
    public partial class MainForm : Form
    {

        private LOTForm lotForm;

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            // MainForm이 로드될 때 수행할 작업
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
            foreach (Form form in Application.OpenForms)
            {
                if (form != this)
                {
                    form.Close();
                }
            }
        }
    }
}
