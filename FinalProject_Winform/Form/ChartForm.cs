using FinalProject_Winform.Data;
using FinalProject_Winform.Models.domain;
using FinalProject_Winform.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
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
            ChartView1();
        }
        private void tabControl1_Selected(object sender, TabControlEventArgs e)
        {
            switch (e.TabPageIndex)
            {
                case 0:
                    ChartView1();
                    break;
            }
        }

        private async void ChartView3()
        {
            InitializeChart();
            //사용자가 선택한 콤보박스 검사값 가져오기
            string selectedTestName = cmbTestName.Text.ToString();

            //사용자가 선택한 검사를 지나간 LOT ID 가져오기
            using FinalDbContext db = new FinalDbContext();

            //검사 기준값 가져오기
            var checkValue = db.Checks
           .Where(x => x.Check_item == selectedTestName)
           .Select(x => x.Check_value)
           .FirstOrDefault();

            //검사 오차 가져오기
            var checkTolerance = db.Checks
           .Where(x => x.Check_item == selectedTestName)
           .Select(x => x.Check_Tolerance)
           .FirstOrDefault();

            double limit = (double)checkValue * (double)checkTolerance / 100;
            var Upper_limit = checkValue + limit;
            var Lower_limit = checkValue - limit;

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

            // 데이터 바인딩
            foreach (var item in result)
            {
                TestChart.Series["LotID"].Points.AddXY(item.LotId, item.CheckResult);
                TestChart.Series["기준값"].Points.AddXY(item.LotId, checkValue);
                TestChart.Series["상한허용값"].Points.AddXY(item.LotId, Upper_limit);
                TestChart.Series["하한허용값"].Points.AddXY(item.LotId, Lower_limit);
            }

            // 점 크기 설정
            TestChart.Series["LotID"].MarkerSize = 10;

            // 라인 두께 설정
            TestChart.Series["기준값"].BorderWidth = 2; // 기준값 라인 두께 
            TestChart.Series["상한허용값"].BorderWidth = 2; // 상한 허용 범위 라인 두께 
            TestChart.Series["하한허용값"].BorderWidth = 2; // 하한 허용 범위 라인 두께 

            //색상 설정
            TestChart.Series["기준값"].Color = Color.Red; // 기준값 라인 색상
            TestChart.Series["상한허용값"].Color = Color.Orange;
            TestChart.Series["하한허용값"].Color = Color.Orange;
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
                if (i == 9) { break; }
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
        private void InitializeChart()
        {
            TestChart.Series.Clear();
            TestChart.ChartAreas.Clear();

            // Add ChartArea and configure it
            ChartArea chartArea = new ChartArea("ChartArea");
            TestChart.ChartAreas.Add(chartArea);

            // Other chart settings and configurations
            // ...

            // Add Series for the chart
            TestChart.Series.Add(new Series("LotID"));
            TestChart.Series["LotID"].ChartArea = "ChartArea";
            TestChart.Series["LotID"].ChartType = SeriesChartType.Point;
            TestChart.Series["LotID"].MarkerSize = 10;

            TestChart.Series.Add(new Series("기준값"));
            TestChart.Series["기준값"].ChartArea = "ChartArea";
            TestChart.Series["기준값"].ChartType = SeriesChartType.Line;
            TestChart.Series["기준값"].BorderWidth = 2;
            TestChart.Series["기준값"].Color = Color.Red;

            TestChart.Series.Add(new Series("상한허용값"));
            TestChart.Series["상한허용값"].ChartArea = "ChartArea";
            TestChart.Series["상한허용값"].ChartType = SeriesChartType.Line;
            TestChart.Series["상한허용값"].BorderWidth = 2;
            TestChart.Series["상한허용값"].Color = Color.Orange;

            TestChart.Series.Add(new Series("하한허용값"));
            TestChart.Series["하한허용값"].ChartArea = "ChartArea";
            TestChart.Series["하한허용값"].ChartType = SeriesChartType.Line;
            TestChart.Series["하한허용값"].BorderWidth = 2;
            TestChart.Series["하한허용값"].Color = Color.Orange;
        }

    }
}
