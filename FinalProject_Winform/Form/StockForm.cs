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

namespace FinalProject_Winform
{
    public partial class StockForm : Form
    {
        private IStockRepository stockRepository;
        private IItemRepository itemRepository;
        private IOrderRepository orederRepository;
        public StockForm()
        {
            InitializeComponent();
            stockRepository = new StockRepository();
            itemRepository = new ItemRepository();
            orederRepository = new OrderRepository();

        }
        DataGridView dgvImport;
        DataGridView dgvExport;

        private void StockForm_Load(object sender, EventArgs e)
        {
            dgvImport = dataGridView1;
            dgvExport = dataGridView2;
        }
        private void tabControl1_Selected(object sender, TabControlEventArgs e)
        {
            switch (e.TabPageIndex)
            {
                case 0:  // 입고
                    LoadImport();
                    break;
                case 1:  // 출고
                    LoadExport();
                    break;
                case 2:  // 내역
                    LoadStock();
                    break;

            }
        }
        private async void LoadImport()
        {
            var stocks = await stockRepository.GetAllAsync();
            FinalDbContext db = new();

            int i = 0;
            foreach (var stock in stocks)
            {
                if (stock.Stock_status == "입고")
                {
                    dgvImport.Rows.Add();  // 새로운 row 추가
                    dgvImport.Rows[i].Cells["item_name"].Value = stock.Item.Item_name;
                    dgvImport.Rows[i].Cells["item_warehousing"].Value = stock.Stock_status;
                    dgvImport.Rows[i].Cells["item_count"].Value = "+" + stock.Stock_amount + stock.Item.Item_unit;
                    dgvImport.Rows[i].Cells["item_regdate"].Value = stock.Stock_regDate;
                    dgvImport.Rows[i].Cells["item_amount"].Value = stock.Stock_regAmount + stock.Item.Item_unit;
                    i++;
                }
            }
        }

        private async void LoadExport()
        {
            var stocks = await stockRepository.GetAllAsync();
            FinalDbContext db = new();

            // DataGridView 전체 clear
            dgvExport.Rows.Clear();
            dgvExport.Refresh();

            int i = 0;
            foreach (var stock in stocks)
            {
                if (stock.Stock_status == "출고")
                {
                    dgvExport.Rows.Add();  // 새로운 row 추가
                    dgvExport.Rows[i].Cells["item_name"].Value = stock.Item.Item_name;
                    dgvExport.Rows[i].Cells["item_warehousing"].Value = stock.Stock_status;
                    dgvExport.Rows[i].Cells["item_count"].Value = "+" + stock.Stock_amount + stock.Item.Item_unit;
                    dgvExport.Rows[i].Cells["item_regdate"].Value = stock.Stock_regDate;
                    dgvExport.Rows[i].Cells["item_amount"].Value = stock.Stock_regAmount + stock.Item.Item_unit;
                    i++;
                }
            }
        }

        private void LoadStock()
        {

        }

        private async void btn_Import(object sender, EventArgs e)
        {
            long amount = long.Parse(txtAmount.Text);
            string item = comboBox1.SelectedItem.ToString();

            // 콤보박스에서 선택된 항목을 가져옴
            var stock = await stockRepository.AddAsync(item, amount);
            if (stock != null)
            {
                await itemRepository.ImportUpdateAsync(item, amount);
                MessageBox.Show("성공");
            }
        }

        private async void btn_Export_Click(object sender, EventArgs e)
        {
            long orderId = long.Parse(txtOrder.Text);
            var count = await orederRepository.GetByIdAsync(orderId);

            var stock = await stockRepository.MinusAsync(orderId);
            if (stock != null)
            {
                await itemRepository.ExportUpdateAsync(orderId, count);
                MessageBox.Show("성공");
            }
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
        private void StockForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            var MainForm = Application.OpenForms["MainForm"] as MainForm;

            if (MainForm != null)
            {
                MainForm = new MainForm();
                MainForm.Show();
            }
            this.Hide();
        }


    }
}
