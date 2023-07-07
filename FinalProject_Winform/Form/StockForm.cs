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

            // 콤보박스에서 선택된 항목을 가져옴
            Item selectedItem = await itemRepository.GetByNameAsync(comboBox1.SelectedItem.ToString());

            stockRepository.AddAsync(selectedItem,amount);
        }
    }
}
