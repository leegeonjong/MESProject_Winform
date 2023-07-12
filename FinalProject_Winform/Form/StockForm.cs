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
        public StockForm()
        {
            InitializeComponent();
            stockRepository = new StockRepository();
            itemRepository = new ItemRepository();
            dgv = dataGridView1;
        }
        DataGridView dgv;
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
            using FinalDbContext db = new FinalDbContext();
            var stocks = await db.Stocks.ToListAsync();
            dgv.Rows.Clear();
            dgv.Refresh();

            int i = 0;
            foreach (var stock in stocks)
            {
                //dgv.Rows.Add();  // 새로운 행을 추가
                //dgv.Rows[i].Cells["stock_item"].Value = stock.Id;
                //dgv.Rows[i].Cells["stock_status"].Value = ;
                //dgv.Rows[i].Cells["stock_count"].Value = ;
                //dgv.Rows[i].Cells["stock_time"].Value = ;
                //dgv.Rows[i].Cells["stock_amount"].Value = ;
                
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
                //MessageBox.Show("성공");
                LoadImport();
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
