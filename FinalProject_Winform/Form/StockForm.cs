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

namespace FinalProject_Winform
{
    public partial class StockForm : Form
    {
        private IStockRepository stockRepository;
        private IItemRepository itemRepository;
        public StockForm()
        {
            InitializeComponent();
            stockRepository = new StockRepository();
            itemRepository = new ItemRepository();

        }
        DataGridView dgvImport;

        private void StockForm_Load(object sender, EventArgs e)
        {
            dgvImport = dataGridView1;
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

            // DataGridView 전체 clear
            dgvImport.Rows.Clear();
            dgvImport.Refresh();

            int i = 0;
            foreach (var stock in stocks)
            {
                dgvImport.Rows.Add();  // 새로운 row 추가
                dgvImport.Rows[i].Cells["item_name"].Value = stock.Item.Item_name;
                dgvImport.Rows[i].Cells["item_warehousing"].Value = stock.Stock_status;
                dgvImport.Rows[i].Cells["item_count"].Value = "+" + stock.Stock_amount+stock.Item.Item_unit;
                dgvImport.Rows[i].Cells["item_regdate"].Value = stock.Stock_regDate;
                dgvImport.Rows[i].Cells["item_amount"].Value = stock.Item.Item_amount;
                
                i++;
            }
        }

        private void LoadExport()
        {

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
                await itemRepository.UpdateAsync(item, amount);
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

    }
}
