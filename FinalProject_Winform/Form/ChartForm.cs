using FinalProject_Winform.Data;
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
using System.Windows.Forms.DataVisualization.Charting;

namespace FinalProject_Winform
{
    public partial class ChartForm : Form
    {
        private readonly FinalDbContext db;
        private readonly IItemRepository itemRepository;
        public ChartForm()
        {
            InitializeComponent();
            db = new FinalDbContext();
            itemRepository = new ItemRepository();
        }
        Chart chartStock;
        private void Form5_Load(object sender, EventArgs e)
        {
            chartStock = chart1;
            chartStock.Titles.Add("현재 수량");
            chartStock.ChartAreas["ChartArea1"].AxisX.Title = "물품명";
            chartStock.ChartAreas["ChartArea1"].AxisY.Title = "수량";
            chartStock.Series["Series1"].LegendText = "수량";
            ChartView();
        }
        private void tabControl1_Selected(object sender, TabControlEventArgs e)
        {
            switch (e.TabPageIndex)
            {
                case 0:
                    ChartView();
                    break;
                case 1:

                    break;
                case 2:

                    break;
            }
        }
        private async void ChartView()
        {
            var items = await db.Items.ToListAsync();
            chartStock.Series["Series1"].Points.Clear();
            foreach (var item in items)
            {
                chartStock.Series["Series1"].Points.AddXY(item.Item_name, item.Item_amount);
            }
        }

        //버튼 클릭 이벤트 하나로 묶어둔 함수
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
        private void ChartForm_FormClosed(object sender, FormClosedEventArgs e)
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
