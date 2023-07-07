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

        private void btn_order_Click(object sender, EventArgs e)
        {
            var OrderForm = Application.OpenForms["OrderForm"] as OrderForm;

            if (OrderForm == null)
            {
                OrderForm = new OrderForm();
                OrderForm.Show();
            }
            this.Hide();
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
