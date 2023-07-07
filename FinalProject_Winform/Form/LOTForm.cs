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
    public partial class LOTForm : Form
    {
        public LOTForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_process_Click(object sender, EventArgs e)
        {
            var ProcessForm = Application.OpenForms["ProcessForm"] as ProcessForm;

            if (ProcessForm == null)
            {
                ProcessForm = new ProcessForm();
                ProcessForm.Show();
            }
            this.Close();
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
        //닫으면 모든 폼 닫기 
        private void LOTForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            foreach (Form form in Application.OpenForms)
            {
                if (form != this)
                {
                    form.Close();
                }
            }
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
    }
}
