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
            panel2 = new Panel();
            label1 = new Label();
            panel1 = new Panel();
            btn_chart = new Button();
            btn_order = new Button();
            btn_stock = new Button();
            btn_check = new Button();
            btn_process = new Button();
            btn_LOT = new Button();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            tabPage2 = new TabPage();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            tabControl1.SuspendLayout();
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
            panel1.Controls.Add(btn_chart);
            panel1.Controls.Add(btn_order);
            panel1.Controls.Add(btn_stock);
            panel1.Controls.Add(btn_check);
            panel1.Controls.Add(btn_process);
            panel1.Controls.Add(btn_LOT);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(160, 761);
            panel1.TabIndex = 4;
            // 
            // btn_chart
            // 
            btn_chart.FlatAppearance.BorderColor = Color.Gray;
            btn_chart.FlatAppearance.BorderSize = 2;
            btn_chart.FlatStyle = FlatStyle.Flat;
            btn_chart.Font = new Font("맑은 고딕", 24F, FontStyle.Bold, GraphicsUnit.Point);
            btn_chart.Location = new Point(-3, 586);
            btn_chart.Name = "btn_chart";
            btn_chart.Size = new Size(168, 104);
            btn_chart.TabIndex = 3;
            btn_chart.Text = "현황판";
            btn_chart.TextAlign = ContentAlignment.MiddleLeft;
            btn_chart.UseVisualStyleBackColor = true;
            // 
            // btn_order
            // 
            btn_order.FlatAppearance.BorderColor = Color.Gray;
            btn_order.FlatAppearance.BorderSize = 2;
            btn_order.FlatStyle = FlatStyle.Flat;
            btn_order.Font = new Font("맑은 고딕", 24F, FontStyle.Bold, GraphicsUnit.Point);
            btn_order.Location = new Point(-3, 486);
            btn_order.Name = "btn_order";
            btn_order.Size = new Size(168, 104);
            btn_order.TabIndex = 3;
            btn_order.Text = "주문";
            btn_order.TextAlign = ContentAlignment.MiddleLeft;
            btn_order.UseVisualStyleBackColor = true;
            // 
            // btn_stock
            // 
            btn_stock.FlatAppearance.BorderColor = Color.Gray;
            btn_stock.FlatAppearance.BorderSize = 2;
            btn_stock.FlatStyle = FlatStyle.Flat;
            btn_stock.Font = new Font("맑은 고딕", 24F, FontStyle.Bold, GraphicsUnit.Point);
            btn_stock.Location = new Point(-3, 386);
            btn_stock.Name = "btn_stock";
            btn_stock.Size = new Size(168, 104);
            btn_stock.TabIndex = 3;
            btn_stock.Text = "재고관리";
            btn_stock.TextAlign = ContentAlignment.MiddleLeft;
            btn_stock.UseVisualStyleBackColor = true;
            // 
            // btn_check
            // 
            btn_check.FlatAppearance.BorderColor = Color.Gray;
            btn_check.FlatAppearance.BorderSize = 2;
            btn_check.FlatStyle = FlatStyle.Flat;
            btn_check.Font = new Font("맑은 고딕", 24F, FontStyle.Bold, GraphicsUnit.Point);
            btn_check.Location = new Point(-3, 285);
            btn_check.Name = "btn_check";
            btn_check.Size = new Size(168, 104);
            btn_check.TabIndex = 3;
            btn_check.Text = "검사";
            btn_check.TextAlign = ContentAlignment.MiddleLeft;
            btn_check.UseVisualStyleBackColor = true;
            // 
            // btn_process
            // 
            btn_process.FlatAppearance.BorderColor = Color.Gray;
            btn_process.FlatAppearance.BorderSize = 2;
            btn_process.FlatStyle = FlatStyle.Flat;
            btn_process.Font = new Font("맑은 고딕", 24F, FontStyle.Bold, GraphicsUnit.Point);
            btn_process.Location = new Point(-3, 184);
            btn_process.Name = "btn_process";
            btn_process.Size = new Size(168, 104);
            btn_process.TabIndex = 2;
            btn_process.Text = "공정";
            btn_process.TextAlign = ContentAlignment.MiddleLeft;
            btn_process.UseVisualStyleBackColor = true;
            // 
            // btn_LOT
            // 
            btn_LOT.FlatAppearance.BorderColor = Color.Gray;
            btn_LOT.FlatAppearance.BorderSize = 2;
            btn_LOT.FlatStyle = FlatStyle.Flat;
            btn_LOT.Font = new Font("맑은 고딕", 24F, FontStyle.Bold, GraphicsUnit.Point);
            btn_LOT.Location = new Point(-3, 83);
            btn_LOT.Name = "btn_LOT";
            btn_LOT.Size = new Size(168, 104);
            btn_LOT.TabIndex = 1;
            btn_LOT.Text = "LOT";
            btn_LOT.TextAlign = ContentAlignment.MiddleLeft;
            btn_LOT.UseVisualStyleBackColor = true;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Dock = DockStyle.Bottom;
            tabControl1.ItemSize = new Size(200, 40);
            tabControl1.Location = new Point(160, 90);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1104, 671);
            tabControl1.TabIndex = 6;
            // 
            // tabPage1
            // 
            tabPage1.Location = new Point(4, 44);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(1096, 623);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "tabPage1asdfadfasdfafa";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            tabPage2.Location = new Point(4, 44);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(1096, 623);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "tabPage2";
            tabPage2.UseVisualStyleBackColor = true;
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
            Load += Form5_Load;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            tabControl1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel2;
        private Label label1;
        private Panel panel1;
        private Button btn_chart;
        private Button btn_order;
        private Button btn_stock;
        private Button btn_check;
        private Button btn_process;
        private Button btn_LOT;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
    }
}