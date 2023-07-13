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
        private MainForm mainForm;
        public OrderForm(MainForm mainForm)
        {
            InitializeComponent();
            this.mainForm = mainForm;
            orderRepositroy = new OrderRepository();
        }
        DateTimePicker startdate;
        DateTimePicker enddate;
        DateTimePicker startdate1;
        DateTimePicker enddate1;
        DataGridView dgv;

        private void OrderForm_Load(object sender, EventArgs e)
        {
            startdate1 = dateTimePicker1;
            enddate1 = dateTimePicker2;
            startdate = dateTimePicker3;
            enddate = dateTimePicker4;
        
         
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
                this.Close();
            }
        }

        //메인폼으로 돌아가기
        private void OrderForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            //mainForm.Show();
            //this.Hide();
        }

        private async void button3_Click(object sender, EventArgs e)
        {
            using (FinalDbContext db = new())
            {
                var srt = startdate.Value.Date;
                var orders = await db.Orders
                    .Include(x=>x.Item)
                    .Where(x => x.Order_startDate == srt)
                    .ToListAsync();
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
                var edt = enddate.Value.Date;
                var orders = await db.Orders
                    .Include(x=>x.Item)
                    .Where(x => x.Order_endDate == edt)
                    .ToListAsync();
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

            DateTime startDate = startdate1.Value.Date;
            DateTime endDate = enddate1.Value.Date;

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
