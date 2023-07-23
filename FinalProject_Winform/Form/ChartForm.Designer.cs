using System.Windows.Forms;

namespace FinalProject_Winform
{
    partial class ChartForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea5 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend5 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea6 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend6 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            panel2 = new Panel();
            label1 = new Label();
            panel1 = new Panel();
            btn_ChartForm = new Button();
            btn_OrderForm = new Button();
            btn_StockForm = new Button();
            btn_TestForm = new Button();
            btn_ProcessForm = new Button();
            btn_LOTForm = new Button();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            tabPage2 = new TabPage();
            panel3 = new Panel();
            button2 = new Button();
            label2 = new Label();
            dateTimePicker1 = new DateTimePicker();
            chart3 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            tabPage3 = new TabPage();
            comboBox1 = new ComboBox();
            textBox1 = new TextBox();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chart2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)chart1).BeginInit();
            tabPage2.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chart3).BeginInit();
            tabPage3.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(52, 152, 219);
            panel2.Controls.Add(label1);
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1264, 88);
            panel2.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("맑은 고딕", 27.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(550, 18);
            label1.Name = "label1";
            label1.Size = new Size(170, 50);
            label1.TabIndex = 0;
            label1.Text = "아무거나";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(180, 210, 230);
            panel1.Controls.Add(btn_ChartForm);
            panel1.Controls.Add(btn_OrderForm);
            panel1.Controls.Add(btn_StockForm);
            panel1.Controls.Add(btn_TestForm);
            panel1.Controls.Add(btn_ProcessForm);
            panel1.Controls.Add(btn_LOTForm);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(160, 761);
            panel1.TabIndex = 4;
            // 
            // btn_ChartForm
            // 
            btn_ChartForm.FlatAppearance.BorderColor = Color.Gray;
            btn_ChartForm.FlatAppearance.BorderSize = 2;
            btn_ChartForm.FlatStyle = FlatStyle.Flat;
            btn_ChartForm.Font = new Font("맑은 고딕", 24F, FontStyle.Bold, GraphicsUnit.Point);
            btn_ChartForm.Location = new Point(-4, 580);
            btn_ChartForm.Name = "btn_ChartForm";
            btn_ChartForm.Size = new Size(168, 104);
            btn_ChartForm.TabIndex = 24;
            btn_ChartForm.Text = "현황판";
            btn_ChartForm.TextAlign = ContentAlignment.MiddleLeft;
            btn_ChartForm.UseVisualStyleBackColor = true;
            btn_ChartForm.Click += Button_Click;
            // 
            // btn_OrderForm
            // 
            btn_OrderForm.FlatAppearance.BorderColor = Color.Gray;
            btn_OrderForm.FlatAppearance.BorderSize = 2;
            btn_OrderForm.FlatStyle = FlatStyle.Flat;
            btn_OrderForm.Font = new Font("맑은 고딕", 24F, FontStyle.Bold, GraphicsUnit.Point);
            btn_OrderForm.Location = new Point(-4, 480);
            btn_OrderForm.Name = "btn_OrderForm";
            btn_OrderForm.Size = new Size(168, 104);
            btn_OrderForm.TabIndex = 25;
            btn_OrderForm.Text = "주문";
            btn_OrderForm.TextAlign = ContentAlignment.MiddleLeft;
            btn_OrderForm.UseVisualStyleBackColor = true;
            btn_OrderForm.Click += Button_Click;
            // 
            // btn_StockForm
            // 
            btn_StockForm.FlatAppearance.BorderColor = Color.Gray;
            btn_StockForm.FlatAppearance.BorderSize = 2;
            btn_StockForm.FlatStyle = FlatStyle.Flat;
            btn_StockForm.Font = new Font("맑은 고딕", 24F, FontStyle.Bold, GraphicsUnit.Point);
            btn_StockForm.Location = new Point(-4, 380);
            btn_StockForm.Name = "btn_StockForm";
            btn_StockForm.Size = new Size(168, 104);
            btn_StockForm.TabIndex = 26;
            btn_StockForm.Text = "재고관리";
            btn_StockForm.TextAlign = ContentAlignment.MiddleLeft;
            btn_StockForm.UseVisualStyleBackColor = true;
            btn_StockForm.Click += Button_Click;
            // 
            // btn_TestForm
            // 
            btn_TestForm.FlatAppearance.BorderColor = Color.Gray;
            btn_TestForm.FlatAppearance.BorderSize = 2;
            btn_TestForm.FlatStyle = FlatStyle.Flat;
            btn_TestForm.Font = new Font("맑은 고딕", 24F, FontStyle.Bold, GraphicsUnit.Point);
            btn_TestForm.Location = new Point(-4, 279);
            btn_TestForm.Name = "btn_TestForm";
            btn_TestForm.Size = new Size(168, 104);
            btn_TestForm.TabIndex = 27;
            btn_TestForm.Text = "검사";
            btn_TestForm.TextAlign = ContentAlignment.MiddleLeft;
            btn_TestForm.UseVisualStyleBackColor = true;
            btn_TestForm.Click += Button_Click;
            // 
            // btn_ProcessForm
            // 
            btn_ProcessForm.FlatAppearance.BorderColor = Color.Gray;
            btn_ProcessForm.FlatAppearance.BorderSize = 2;
            btn_ProcessForm.FlatStyle = FlatStyle.Flat;
            btn_ProcessForm.Font = new Font("맑은 고딕", 24F, FontStyle.Bold, GraphicsUnit.Point);
            btn_ProcessForm.Location = new Point(-4, 178);
            btn_ProcessForm.Name = "btn_ProcessForm";
            btn_ProcessForm.Size = new Size(168, 104);
            btn_ProcessForm.TabIndex = 23;
            btn_ProcessForm.Text = "공정";
            btn_ProcessForm.TextAlign = ContentAlignment.MiddleLeft;
            btn_ProcessForm.UseVisualStyleBackColor = true;
            btn_ProcessForm.Click += Button_Click;
            // 
            // btn_LOTForm
            // 
            btn_LOTForm.FlatAppearance.BorderColor = Color.Gray;
            btn_LOTForm.FlatAppearance.BorderSize = 2;
            btn_LOTForm.FlatStyle = FlatStyle.Flat;
            btn_LOTForm.Font = new Font("맑은 고딕", 24F, FontStyle.Bold, GraphicsUnit.Point);
            btn_LOTForm.Location = new Point(-4, 77);
            btn_LOTForm.Name = "btn_LOTForm";
            btn_LOTForm.Size = new Size(168, 104);
            btn_LOTForm.TabIndex = 22;
            btn_LOTForm.Text = "LOT";
            btn_LOTForm.TextAlign = ContentAlignment.MiddleLeft;
            btn_LOTForm.UseVisualStyleBackColor = true;
            btn_LOTForm.Click += Button_Click;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Dock = DockStyle.Bottom;
            tabControl1.ItemSize = new Size(200, 40);
            tabControl1.Location = new Point(160, 90);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1104, 671);
            tabControl1.TabIndex = 6;
            tabControl1.Selected += tabControl1_Selected;
            // 
            // tabPage1
            // 
            tabPage1.BackColor = Color.Gray;
            tabPage1.Controls.Add(chart2);
            tabPage1.Controls.Add(chart1);
            tabPage1.Location = new Point(4, 44);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(1096, 623);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "재고 차트";
            // 
            // chart2
            // 
            chartArea4.Name = "ChartArea1";
            chart2.ChartAreas.Add(chartArea4);
            chart2.Dock = DockStyle.Bottom;
            legend4.Name = "Legend1";
            chart2.Legends.Add(legend4);
            chart2.Location = new Point(3, 313);
            chart2.Name = "chart2";
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.StackedColumn;
            series4.Legend = "Legend1";
            series4.Name = "Series1";
            chart2.Series.Add(series4);
            chart2.Size = new Size(1090, 307);
            chart2.TabIndex = 1;
            chart2.Text = "chart4";
            // 
            // chart1
            // 
            chartArea5.Name = "ChartArea1";
            chart1.ChartAreas.Add(chartArea5);
            chart1.Dock = DockStyle.Top;
            legend5.Name = "Legend1";
            chart1.Legends.Add(legend5);
            chart1.Location = new Point(3, 3);
            chart1.Name = "chart1";
            series5.ChartArea = "ChartArea1";
            series5.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.StackedColumn;
            series5.Legend = "Legend1";
            series5.Name = "Series1";
            chart1.Series.Add(series5);
            chart1.Size = new Size(1090, 304);
            chart1.TabIndex = 0;
            chart1.Text = "chart1";
            // 
            // tabPage2
            // 
            tabPage2.BackColor = Color.Gray;
            tabPage2.Controls.Add(panel3);
            tabPage2.Controls.Add(chart3);
            tabPage2.Location = new Point(4, 44);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(1096, 623);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "출하 차트";
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.Controls.Add(button2);
            panel3.Controls.Add(label2);
            panel3.Controls.Add(dateTimePicker1);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(3, 3);
            panel3.Name = "panel3";
            panel3.Size = new Size(1090, 118);
            panel3.TabIndex = 1;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(52, 152, 219);
            button2.FlatAppearance.BorderColor = Color.White;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("맑은 고딕", 18F, FontStyle.Bold, GraphicsUnit.Point);
            button2.Location = new Point(622, 26);
            button2.Name = "button2";
            button2.Size = new Size(132, 46);
            button2.TabIndex = 6;
            button2.Text = "검색";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("맑은 고딕", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(274, 35);
            label2.Name = "label2";
            label2.Size = new Size(125, 37);
            label2.TabIndex = 1;
            label2.Text = "시작날짜";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(405, 41);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(200, 23);
            dateTimePicker1.TabIndex = 0;
            // 
            // chart3
            // 
            chartArea6.Name = "ChartArea1";
            chart3.ChartAreas.Add(chartArea6);
            chart3.Dock = DockStyle.Bottom;
            legend6.Name = "Legend1";
            chart3.Legends.Add(legend6);
            chart3.Location = new Point(3, 114);
            chart3.Name = "chart3";
            series6.ChartArea = "ChartArea1";
            series6.Legend = "Legend1";
            series6.Name = "Series1";
            chart3.Series.Add(series6);
            chart3.Size = new Size(1090, 506);
            chart3.TabIndex = 0;
            chart3.Text = "chart3";
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(comboBox1);
            tabPage3.Controls.Add(textBox1);
            tabPage3.Location = new Point(4, 44);
            tabPage3.Name = "ChartView3";
            tabPage3.Size = new Size(1096, 623);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "검사 차트";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "용량 검사", "온도 검사", "수량 검사 입고", "수량 검사 출고" });
            comboBox1.Location = new Point(612, 65);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 2;
            comboBox1.Text = "검사 선택";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(77, 65);
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(656, 23);
            textBox1.TabIndex = 1;
            textBox1.Text = "공정 차트 조회";
            // 
            // ChartForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1264, 761);
            Controls.Add(tabControl1);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "ChartForm";
            Text = "ChartForm";
            FormClosed += ChartForm_FormClosed;
            Load += Form5_Load;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)chart2).EndInit();
            ((System.ComponentModel.ISupportInitialize)chart1).EndInit();
            tabPage2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)chart3).EndInit();
            tabPage3.ResumeLayout(false);
            tabPage3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel2;
        private Label label1;
        private Panel panel1;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private Button btn_ChartForm;
        private Button btn_OrderForm;
        private Button btn_StockForm;
        private Button btn_TestForm;
        private Button btn_ProcessForm;
        private Button btn_LOTForm;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart2;
        private Panel panel3;
        private Label label2;
        private DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart3;
        private Button button2;
        private TextBox textBox1;
        private ComboBox comboBox1;
    }
}