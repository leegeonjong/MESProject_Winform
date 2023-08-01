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
using System.Windows.Forms.DataVisualization.Charting;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace FinalProject_Winform
{
    public partial class ChartForm : Form
    {

        private readonly IItemRepository itemRepository;
        private readonly IProcessRepository processRepository;
        private readonly ILothistoryRepository lothistoryRepository;
        private MainForm mainForm;
        public ChartForm(MainForm mainForm)
        {
            InitializeComponent();
            this.mainForm = mainForm;
            processRepository = new ProcessRepository();
            itemRepository = new ItemRepository();
            lothistoryRepository = new LothistoryRepository();
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

            chartStock3 = exportchart;
            chartStock3.Titles.Add("출고 수량");
            chartStock3.ChartAreas["ChartArea1"].AxisX.Title = "날짜";
            chartStock3.ChartAreas["ChartArea1"].AxisY.Title = "수량";
            chartStock3.Series["Series1"].LegendText = "수량";

            TestChart.Titles.Add("검사 결과");
            TestChart.ChartAreas["ChartArea1"].AxisX.Title = "Lot Id";
            TestChart.ChartAreas["ChartArea1"].AxisY.Title = "결과값";
            TestChart.Series["Series1"].LegendText = "결과";

            TestChart.ChartAreas[0].BackColor = Color.Transparent;

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
                    TestChart.Visible = false;
                    break;
            }
        }

        private async void ChartView3()
        {
            TestChart.Visible = true;
            //사용자가 선택한 검사를 가져오기
            //검사 결과를 데이터 그리드뷰로 가져오는건가?
            //차트로도 가져오는건가?
            //둘다 가져오나?

            //사용자가 선택한 콤보박스 검사값 가져오기
            string selectedTestName = cmbTestName.Text.ToString();

            //사용자가 선택한 검사를 지나간 LOT ID 가져오기
            using FinalDbContext db = new FinalDbContext();

            //사용자가 선택한 공정에서 CheckResult 값 가져오기
            var lotList = await db.LotHistorys
            .Where(x => x.Process.Check.Check_item == selectedTestName && !string.IsNullOrEmpty(x.CheckResult)).ToListAsync();

            //검사값이 존재하는 데이터들에서 최근 데이터 10개만 가져오기
            var result = lotList
            .Where(x => !string.IsNullOrEmpty(x.CheckResult))
            .Select(x => (LotId: x.LotId, CheckResult: long.Parse(x.CheckResult), LotHistory_Date: x.LotHistory_Date))
            .OrderByDescending(x => x.LotHistory_Date)
            .Take(10)
            .ToList();


            // X축 설정
            TestChart.ChartAreas.Add(new ChartArea("ChartArea"));
            TestChart.Series.Add(new Series("LotIdSeries"));
            TestChart.Series["LotIdSeries"].ChartArea = "ChartArea";

            // Y축 설정
            TestChart.ChartAreas["ChartArea"].AxisY.Title = "CheckResult";
            TestChart.Series["LotIdSeries"].YAxisType = AxisType.Primary;

            // 차트 유형을 포인트로 설정
            TestChart.Series["LotIdSeries"].ChartType = SeriesChartType.Point;

            // 데이터 바인딩
            foreach (var item in result)
            {
                TestChart.Series["LotIdSeries"].Points.AddXY(item.LotId, item.CheckResult);
            }

            //데이터그리드뷰에 보여주기?

            //검사 오차율 구하기/ 불량 구하기

            //차트로 표시하기 
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
            var a = dtp.Value.Date;
            // 입력받은 날짜로 stock 에서 6개 가져와서 표시
            string b = a.ToString("yy:MM:dd");
            DateTime start = DateTime.ParseExact(b, "yy:MM:dd", null);
            DateTime end;
            int c = (int)start.DayOfWeek;
            if (c == 1)
            {
                end = start.AddDays(6);
            }
            else
            {
                int d = 7 - c;
                end = start.AddDays(d);
                start = start.AddDays(-(7 - c - 1));
            }
  
        }

        private void cmbTestName_SelectedIndexChanged(object sender, EventArgs e)
        {
            ChartView3();
        }
    }
}
