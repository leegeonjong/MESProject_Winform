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
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace FinalProject_Winform
{
    public partial class ChartForm : Form
    {

        private readonly IItemRepository itemRepository;
        private MainForm mainForm;
        public ChartForm(MainForm mainForm)
        {
            InitializeComponent();
            this.mainForm = mainForm;
            itemRepository = new ItemRepository();
        }
        Chart chartStock1;
        Chart chartStock2;
        Chart chartStock3;
        DateTimePicker dtp;
        private void Form5_Load(object sender, EventArgs e)
        {

            chartStock1 = chart1;
            chartStock1.Titles.Add("현재 수량");
            chartStock1.ChartAreas["ChartArea1"].AxisX.Title = "물품명";
            chartStock1.ChartAreas["ChartArea1"].AxisY.Title = "수량";
            chartStock1.Series["Series1"].LegendText = "수량";

            chartStock2 = chart2;
            chartStock2.Titles.Add("현재 수량");
            chartStock2.ChartAreas["ChartArea1"].AxisX.Title = "물품명";
            chartStock2.ChartAreas["ChartArea1"].AxisY.Title = "수량";
            chartStock2.Series["Series1"].LegendText = "수량";

            chartStock3 = chart3;
            chartStock3.Titles.Add("출고 수량");
            chartStock3.ChartAreas["ChartArea1"].AxisX.Title = "날짜";
            chartStock3.ChartAreas["ChartArea1"].AxisY.Title = "수량";
            chartStock3.Series["Series1"].LegendText = "수량";

            dtp = dateTimePicker1;

            ChartView1();
        }
        private void tabControl1_Selected(object sender, TabControlEventArgs e)
        {
            switch (e.TabPageIndex)
            {
                case 0:
                    ChartView1();
                    break;
                case 1:
                    ChartView2();
                    break;
                case 2:
                    ChartView3();
                    break;
            }
        }

        private void ChartView3()
        {
            throw new NotImplementedException();
        }

        private async void ChartView2()
        {
            // 6개만 가져와서 표시한다
            // 오늘날짜 - 6일치 가져와서 표시 (db에 데이터 주입)
            // amount를 가져오는데 한개만 가져오는건가? 다 가져와서 날짜에따라 다 더하는건가?
            // 검색 기능 구현
            // order에서 senddate 업데이트
            // lot 이력조회 lothistory 조회해서 구현
            using FinalDbContext db = new FinalDbContext();
            var list = await db.Stocks.Where(x => x.Stock_status == "출고").ToListAsync();
            chartStock3.Series["Series1"].Points.Clear();
            int i = 0;
            foreach (var item in list)
            {
                if (i < 7)
                {
                    chartStock3.Series["Series1"].Points.AddXY(item.Stock_regDate.ToString("yyyy-MM-dd"), Math.Abs(item.Stock_amount));
                    i++;
                }
            }


        }

        private async void ChartView1()
        {
            using FinalDbContext db = new FinalDbContext();
            var items = await db.Items.ToListAsync();
            chartStock1.Series["Series1"].Points.Clear();

            int i = 0;
            foreach (var item in items)
            {
                if (i < 7)
                {
                    chartStock1.Series["Series1"].Points.AddXY(item.Item_name, item.Item_amount);
                    i++;
                }
                else
                {
                    chartStock2.Series["Series1"].Points.AddXY(item.Item_name, item.Item_amount);
                }
            }
        }

        //버튼 클릭 이벤트 하나로 묶어둔 함수
        private void Button_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;
            if (button != null)
            {
                string formName = button.Name.Replace("btn_", "");
                this.Close();
                FormUtility.OpenForm(formName, mainForm);
            }
        }

        //메인폼으로 돌아가기
        private void ChartForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            //mainForm.Show();
            //this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var dateTime = dtp.Value.Date;
            // 입력받은 날짜로 stock 에서 6개 가져와서 표시
        }
    }
}
