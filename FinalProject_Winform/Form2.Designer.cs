namespace FinalProject_Winform
{
    partial class Form2
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
            this.panel1 = new Panel();
            this.btn_chart = new Button();
            this.btn_order = new Button();
            this.btn_stock = new Button();
            this.btn_check = new Button();
            this.btn_process = new Button();
            this.btn_LOT = new Button();
            this.panel2 = new Panel();
            this.label1 = new Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = Color.FromArgb(180, 210, 230);
            this.panel1.Controls.Add(this.btn_chart);
            this.panel1.Controls.Add(this.btn_order);
            this.panel1.Controls.Add(this.btn_stock);
            this.panel1.Controls.Add(this.btn_check);
            this.panel1.Controls.Add(this.btn_process);
            this.panel1.Controls.Add(this.btn_LOT);
            this.panel1.Dock = DockStyle.Left;
            this.panel1.Location = new Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new Size(160, 761);
            this.panel1.TabIndex = 0;
            // 
            // btn_chart
            // 
            this.btn_chart.FlatAppearance.BorderColor = Color.Gray;
            this.btn_chart.FlatAppearance.BorderSize = 2;
            this.btn_chart.FlatStyle = FlatStyle.Flat;
            this.btn_chart.Font = new Font("맑은 고딕", 24F, FontStyle.Bold, GraphicsUnit.Point);
            this.btn_chart.Location = new Point(-3, 586);
            this.btn_chart.Name = "btn_chart";
            this.btn_chart.Size = new Size(168, 104);
            this.btn_chart.TabIndex = 3;
            this.btn_chart.Text = "현황판";
            this.btn_chart.TextAlign = ContentAlignment.MiddleLeft;
            this.btn_chart.UseVisualStyleBackColor = true;
            // 
            // btn_order
            // 
            this.btn_order.FlatAppearance.BorderColor = Color.Gray;
            this.btn_order.FlatAppearance.BorderSize = 2;
            this.btn_order.FlatStyle = FlatStyle.Flat;
            this.btn_order.Font = new Font("맑은 고딕", 24F, FontStyle.Bold, GraphicsUnit.Point);
            this.btn_order.Location = new Point(-3, 486);
            this.btn_order.Name = "btn_order";
            this.btn_order.Size = new Size(168, 104);
            this.btn_order.TabIndex = 3;
            this.btn_order.Text = "주문";
            this.btn_order.TextAlign = ContentAlignment.MiddleLeft;
            this.btn_order.UseVisualStyleBackColor = true;
            // 
            // btn_stock
            // 
            this.btn_stock.FlatAppearance.BorderColor = Color.Gray;
            this.btn_stock.FlatAppearance.BorderSize = 2;
            this.btn_stock.FlatStyle = FlatStyle.Flat;
            this.btn_stock.Font = new Font("맑은 고딕", 24F, FontStyle.Bold, GraphicsUnit.Point);
            this.btn_stock.Location = new Point(-3, 386);
            this.btn_stock.Name = "btn_stock";
            this.btn_stock.Size = new Size(168, 104);
            this.btn_stock.TabIndex = 3;
            this.btn_stock.Text = "재고관리";
            this.btn_stock.TextAlign = ContentAlignment.MiddleLeft;
            this.btn_stock.UseVisualStyleBackColor = true;
            // 
            // btn_check
            // 
            this.btn_check.FlatAppearance.BorderColor = Color.Gray;
            this.btn_check.FlatAppearance.BorderSize = 2;
            this.btn_check.FlatStyle = FlatStyle.Flat;
            this.btn_check.Font = new Font("맑은 고딕", 24F, FontStyle.Bold, GraphicsUnit.Point);
            this.btn_check.Location = new Point(-3, 285);
            this.btn_check.Name = "btn_check";
            this.btn_check.Size = new Size(168, 104);
            this.btn_check.TabIndex = 3;
            this.btn_check.Text = "검사";
            this.btn_check.TextAlign = ContentAlignment.MiddleLeft;
            this.btn_check.UseVisualStyleBackColor = true;
            // 
            // btn_process
            // 
            this.btn_process.FlatAppearance.BorderColor = Color.Gray;
            this.btn_process.FlatAppearance.BorderSize = 2;
            this.btn_process.FlatStyle = FlatStyle.Flat;
            this.btn_process.Font = new Font("맑은 고딕", 24F, FontStyle.Bold, GraphicsUnit.Point);
            this.btn_process.Location = new Point(-3, 184);
            this.btn_process.Name = "btn_process";
            this.btn_process.Size = new Size(168, 104);
            this.btn_process.TabIndex = 2;
            this.btn_process.Text = "공정";
            this.btn_process.TextAlign = ContentAlignment.MiddleLeft;
            this.btn_process.UseVisualStyleBackColor = true;
            // 
            // btn_LOT
            // 
            this.btn_LOT.FlatAppearance.BorderColor = Color.Gray;
            this.btn_LOT.FlatAppearance.BorderSize = 2;
            this.btn_LOT.FlatStyle = FlatStyle.Flat;
            this.btn_LOT.Font = new Font("맑은 고딕", 24F, FontStyle.Bold, GraphicsUnit.Point);
            this.btn_LOT.Location = new Point(-3, 83);
            this.btn_LOT.Name = "btn_LOT";
            this.btn_LOT.Size = new Size(168, 104);
            this.btn_LOT.TabIndex = 1;
            this.btn_LOT.Text = "LOT";
            this.btn_LOT.TextAlign = ContentAlignment.MiddleLeft;
            this.btn_LOT.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.BackColor = Color.FromArgb(52, 152, 219);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new Size(1264, 88);
            this.panel2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new Font("맑은 고딕", 27.75F, FontStyle.Bold, GraphicsUnit.Point);
            this.label1.Location = new Point(550, 18);
            this.label1.Name = "label1";
            this.label1.Size = new Size(170, 50);
            this.label1.TabIndex = 0;
            this.label1.Text = "아무거나";
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1264, 761);
            Controls.Add(this.panel2);
            Controls.Add(this.panel1);
            Name = "Form2";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Form2";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btn_LOT;
        private Panel panel2;
        private Button btn_process;
        private Button btn_chart;
        private Button btn_order;
        private Button btn_stock;
        private Button btn_check;
        private Label label1;
    }
}