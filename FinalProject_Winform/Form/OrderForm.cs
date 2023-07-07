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
    public partial class OrderForm : Form
    {
        public OrderForm()
        {
            InitializeComponent();
        }

        private void btn_LOT_Click(object sender, EventArgs e)
        {
            var LOTForm = Application.OpenForms["LOTForm"] as LOTForm;

            if (LOTForm == null)
            {
                LOTForm = new LOTForm();
                LOTForm.Show();
            }
            this.Hide();
        }

        private void btn_process_Click(object sender, EventArgs e)
        {
            var ProcessForm = Application.OpenForms["ProcessForm"] as ProcessForm;

            if (ProcessForm == null)
            {
                ProcessForm = new ProcessForm();
                ProcessForm.Show();
            }
            this.Hide();
        }

        private void btn_check_Click(object sender, EventArgs e)
        {
            var TestForm = Application.OpenForms["TestForm"] as TestForm;

            if (TestForm == null)
            {
                TestForm = new TestForm();
                TestForm.Show();
            }
            this.Hide();
        }

        private void btn_stock_Click(object sender, EventArgs e)
        {
            var StockForm = Application.OpenForms["StockForm"] as StockForm;

            if (StockForm == null)
            {
                StockForm = new StockForm();
                StockForm.Show();
            }
            this.Hide();
        }

        private void btn_chart_Click(object sender, EventArgs e)
        {
            var ChartForm = Application.OpenForms["ChartForm"] as ChartForm;

            if (ChartForm == null)
            {
                ChartForm = new ChartForm();
                ChartForm.Show();
            }
            this.Hide();
        }

        //메인폼으로 돌아가기
        private void OrderForm_FormClosed(object sender, FormClosedEventArgs e)
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
