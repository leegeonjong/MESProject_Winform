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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            panel2 = new Panel();
            label1 = new Label();
            panel1 = new Panel();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            tabPage2 = new TabPage();
            chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            tabPage3 = new TabPage();
            chart3 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chart1).BeginInit();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chart2).BeginInit();
            tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chart3).BeginInit();
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
            tabPage1.Controls.Add(chart1);
            tabPage1.Location = new Point(4, 44);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(1096, 623);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "재고 차트";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            chart1.Legends.Add(legend1);
            chart1.Location = new Point(94, 50);
            chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            chart1.Series.Add(series1);
            chart1.Size = new Size(943, 485);
            chart1.TabIndex = 0;
            chart1.Text = "chart1";
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(chart2);
            tabPage2.Location = new Point(4, 44);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(1096, 623);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "공정 차트";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // chart2
            // 
            chartArea2.Name = "ChartArea1";
            chart2.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            chart2.Legends.Add(legend2);
            chart2.Location = new Point(94, 50);
            chart2.Name = "chart2";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            chart2.Series.Add(series2);
            chart2.Size = new Size(943, 485);
            chart2.TabIndex = 0;
            chart2.Text = "chart2";
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(chart3);
            tabPage3.Location = new Point(4, 44);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(1096, 623);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "검사 차트";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // chart3
            // 
            chartArea3.Name = "ChartArea1";
            chart3.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            chart3.Legends.Add(legend3);
            chart3.Location = new Point(94, 50);
            chart3.Name = "chart3";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            chart3.Series.Add(series3);
            chart3.Size = new Size(943, 485);
            chart3.TabIndex = 0;
            chart3.Text = "chart3";
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
            ((System.ComponentModel.ISupportInitialize)chart1).EndInit();
            tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)chart2).EndInit();
            tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)chart3).EndInit();
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
        private System.Windows.Forms.DataVisualization.Charting.Chart chart2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart3;
    }
}