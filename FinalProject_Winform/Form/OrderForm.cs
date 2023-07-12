using FinalProject_Winform.Data;
using FinalProject_Winform.Models.domain;
using FinalProject_Winform.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Button = System.Windows.Forms.Button;

namespace FinalProject_Winform
{
    public partial class OrderForm : Form
    {
        private IOrderRepository orderRepositroy;
        public OrderForm()
        {
            InitializeComponent();
            orderRepositroy = new OrderRepository();
        }
        DateTimePicker startdate;
        DateTimePicker enddate;
        DataGridView dgv;

        private void OrderForm_Load(object sender, EventArgs e)
        {
            startdate = dateTimePicker1;
            enddate = dateTimePicker2;
            startdate.Value = DateTime.Now;
            enddate.Value = DateTime.Now;
            dgv = dataGridView1;
            GridViewLoad();
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
        private void OrderForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            var MainForm = Application.OpenForms["MainForm"] as MainForm;

            if (MainForm != null)
            {
                MainForm = new MainForm();
                MainForm.Show();
            }
            this.Hide();
        }

        private async void button3_Click(object sender, EventArgs e)
        {
            using (FinalDbContext db = new())
            {
                var srt = startdate.Value;
                var orders = await db.Orders.Where(x => x.Order_startDate == srt).ToListAsync();
                dgv.Rows.Clear();
                dgv.Refresh();
                int i = 0;
                foreach (var order in orders)
                {
                    dgv.Rows.Add();
                    dgv.Rows[i].Cells["order_item"].Value = order.Item.Item_name;
                    dgv.Rows[i].Cells["order_count"].Value = order.Order_count;
                    dgv.Rows[i].Cells["order_start"].Value = order.Order_startDate;
                    dgv.Rows[i].Cells["order_end"].Value = order.Order_endDate;
                    dgv.Rows[i].Cells["order_account"].Value = order.Order_account;
                    i++;
                }
            }
        }

        private async void button4_Click(object sender, EventArgs e)
        {
            using (FinalDbContext db = new())
            {
                var edt = enddate.Value;
                var orders = await db.Orders.Where(x => x.Order_endDate == edt).ToListAsync();
                dgv.Rows.Clear();
                dgv.Refresh();
                int i = 0;
                foreach (var order in orders)
                {
                    dgv.Rows.Add();
                    dgv.Rows[i].Cells["order_item"].Value = order.Item.Item_name;
                    dgv.Rows[i].Cells["order_count"].Value = order.Order_count;
                    dgv.Rows[i].Cells["order_start"].Value = order.Order_startDate;
                    dgv.Rows[i].Cells["order_end"].Value = order.Order_endDate;
                    dgv.Rows[i].Cells["order_account"].Value = order.Order_account;
                    i++;
                }
            }
        }

        private async void GridViewLoad()
        {
            using (FinalDbContext db = new())
            {
                var orders = await db.Orders.Include(x => x.Item).ToListAsync();
                dgv.Rows.Clear();
                dgv.Refresh();
                int i = 0;
                foreach (var order in orders)
                {
                    dgv.Rows.Add();
                    dgv.Rows[i].Cells["order_item"].Value = order.Item.Item_name;
                    dgv.Rows[i].Cells["order_count"].Value = order.Order_count;
                    dgv.Rows[i].Cells["order_start"].Value = order.Order_startDate;
                    dgv.Rows[i].Cells["order_end"].Value = order.Order_endDate;
                    dgv.Rows[i].Cells["order_account"].Value = order.Order_account;
                    i++;
                }
            }

        }

        private async void button2_Click(object sender, EventArgs e)
        {
            string account = txtAccount.Text;
            string ordername = textBox1.Text;

            DateTime startDate = dateTimePicker1.Value;
            DateTime endDate = dateTimePicker2.Value;

            string item = comboBox1.SelectedItem.ToString();
            long ordercount = long.Parse(txtOrderCount.Text);

            var order = await orderRepositroy.AddAsync(startDate, endDate, ordername, ordercount, account, item);
            if (order != null)
            {
                MessageBox.Show("성공");
            }
        }
    }
}
