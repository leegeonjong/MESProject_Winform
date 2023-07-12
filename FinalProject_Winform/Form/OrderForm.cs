using FinalProject_Winform.Models.domain;
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

        private async void button2_Click(object sender, EventArgs e)
        {
            string account = txtAccount.Text;
            string ordername = txtOrderName.Text;

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
