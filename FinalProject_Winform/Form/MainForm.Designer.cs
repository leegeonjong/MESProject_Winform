namespace FinalProject_Winform
{
    partial class MainForm
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
            btn_ChartForm = new Button();
            btn_OrderForm = new Button();
            btn_StockForm = new Button();
            btn_TestForm = new Button();
            btn_ProcessForm = new Button();
            btn_LOTForm = new Button();
            panel3 = new Panel();
            panel14 = new Panel();
            panel15 = new Panel();
            PackStatus = new Label();
            listBox6 = new ListBox();
            label13 = new Label();
            panel12 = new Panel();
            panel13 = new Panel();
            FreezeStatus = new Label();
            listBox5 = new ListBox();
            label11 = new Label();
            panel10 = new Panel();
            panel11 = new Panel();
            FryStatus = new Label();
            listBox4 = new ListBox();
            label9 = new Label();
            panel8 = new Panel();
            panel9 = new Panel();
            SteamStatus = new Label();
            listBox3 = new ListBox();
            label7 = new Label();
            panel6 = new Panel();
            panel7 = new Panel();
            ShapeStatus = new Label();
            listBox2 = new ListBox();
            label5 = new Label();
            panel4 = new Panel();
            panel5 = new Panel();
            MixStatus = new Label();
            listBox1 = new ListBox();
            label3 = new Label();
            label2 = new Label();
            panel16 = new Panel();
            panel17 = new Panel();
            panel18 = new Panel();
            panel19 = new Panel();
            panel20 = new Panel();
            panel21 = new Panel();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            panel14.SuspendLayout();
            panel12.SuspendLayout();
            panel10.SuspendLayout();
            panel8.SuspendLayout();
            panel6.SuspendLayout();
            panel4.SuspendLayout();
            panel16.SuspendLayout();
            panel17.SuspendLayout();
            panel18.SuspendLayout();
            panel19.SuspendLayout();
            panel20.SuspendLayout();
            panel21.SuspendLayout();
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
            label1.Size = new Size(220, 50);
            label1.TabIndex = 0;
            label1.Text = "메인 페이지";
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
            btn_ChartForm.TabIndex = 12;
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
            btn_OrderForm.TabIndex = 13;
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
            btn_StockForm.TabIndex = 14;
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
            btn_TestForm.TabIndex = 15;
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
            btn_ProcessForm.TabIndex = 11;
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
            btn_LOTForm.TabIndex = 10;
            btn_LOTForm.Text = "LOT";
            btn_LOTForm.TextAlign = ContentAlignment.MiddleLeft;
            btn_LOTForm.UseVisualStyleBackColor = true;
            btn_LOTForm.Click += Button_Click;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Gainsboro;
            panel3.Controls.Add(panel20);
            panel3.Controls.Add(panel18);
            panel3.Controls.Add(panel17);
            panel3.Controls.Add(panel14);
            panel3.Controls.Add(panel12);
            panel3.Controls.Add(panel10);
            panel3.Controls.Add(panel8);
            panel3.Controls.Add(panel6);
            panel3.Controls.Add(panel4);
            panel3.Controls.Add(label2);
            panel3.Location = new Point(160, 90);
            panel3.Name = "panel3";
            panel3.Size = new Size(1104, 671);
            panel3.TabIndex = 6;
            // 
            // panel14
            // 
            panel14.BackColor = Color.White;
            panel14.Controls.Add(panel21);
            panel14.Controls.Add(PackStatus);
            panel14.Controls.Add(listBox6);
            panel14.Location = new Point(790, 404);
            panel14.Name = "panel14";
            panel14.Size = new Size(282, 255);
            panel14.TabIndex = 9;
            // 
            // panel15
            // 
            panel15.Location = new Point(237, 8);
            panel15.Name = "panel15";
            panel15.Size = new Size(25, 25);
            panel15.TabIndex = 8;
            // 
            // PackStatus
            // 
            PackStatus.AutoSize = true;
            PackStatus.Location = new Point(15, 46);
            PackStatus.Name = "PackStatus";
            PackStatus.Size = new Size(0, 15);
            PackStatus.TabIndex = 7;
            // 
            // listBox6
            // 
            listBox6.FormattingEnabled = true;
            listBox6.ItemHeight = 15;
            listBox6.Location = new Point(16, 82);
            listBox6.Name = "listBox6";
            listBox6.Size = new Size(246, 154);
            listBox6.TabIndex = 6;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("맑은 고딕", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label13.Location = new Point(16, 8);
            label13.Name = "label13";
            label13.Size = new Size(46, 21);
            label13.TabIndex = 0;
            label13.Text = "Pack";
            // 
            // panel12
            // 
            panel12.BackColor = Color.White;
            panel12.Controls.Add(FreezeStatus);
            panel12.Controls.Add(listBox5);
            panel12.Location = new Point(404, 404);
            panel12.Name = "panel12";
            panel12.Size = new Size(282, 255);
            panel12.TabIndex = 9;
            // 
            // panel13
            // 
            panel13.Location = new Point(237, 8);
            panel13.Name = "panel13";
            panel13.Size = new Size(25, 25);
            panel13.TabIndex = 8;
            // 
            // FreezeStatus
            // 
            FreezeStatus.AutoSize = true;
            FreezeStatus.Location = new Point(16, 46);
            FreezeStatus.Name = "FreezeStatus";
            FreezeStatus.Size = new Size(0, 15);
            FreezeStatus.TabIndex = 7;
            // 
            // listBox5
            // 
            listBox5.FormattingEnabled = true;
            listBox5.ItemHeight = 15;
            listBox5.Location = new Point(16, 82);
            listBox5.Name = "listBox5";
            listBox5.Size = new Size(246, 154);
            listBox5.TabIndex = 6;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("맑은 고딕", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label11.Location = new Point(14, 9);
            label11.Name = "label11";
            label11.Size = new Size(59, 21);
            label11.TabIndex = 0;
            label11.Text = "Freeze";
            // 
            // panel10
            // 
            panel10.BackColor = Color.White;
            panel10.Controls.Add(panel19);
            panel10.Controls.Add(FryStatus);
            panel10.Controls.Add(listBox4);
            panel10.Location = new Point(23, 404);
            panel10.Name = "panel10";
            panel10.Size = new Size(282, 255);
            panel10.TabIndex = 9;
            // 
            // panel11
            // 
            panel11.Location = new Point(237, 9);
            panel11.Name = "panel11";
            panel11.Size = new Size(25, 25);
            panel11.TabIndex = 8;
            // 
            // FryStatus
            // 
            FryStatus.AutoSize = true;
            FryStatus.Location = new Point(15, 46);
            FryStatus.Name = "FryStatus";
            FryStatus.Size = new Size(0, 15);
            FryStatus.TabIndex = 7;
            // 
            // listBox4
            // 
            listBox4.FormattingEnabled = true;
            listBox4.ItemHeight = 15;
            listBox4.Location = new Point(16, 82);
            listBox4.Name = "listBox4";
            listBox4.Size = new Size(246, 154);
            listBox4.TabIndex = 6;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("맑은 고딕", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(15, 9);
            label9.Name = "label9";
            label9.Size = new Size(33, 21);
            label9.TabIndex = 0;
            label9.Text = "Fry";
            // 
            // panel8
            // 
            panel8.BackColor = Color.White;
            panel8.Controls.Add(SteamStatus);
            panel8.Controls.Add(listBox3);
            panel8.Location = new Point(790, 88);
            panel8.Name = "panel8";
            panel8.Size = new Size(282, 255);
            panel8.TabIndex = 9;
            // 
            // panel9
            // 
            panel9.Location = new Point(237, 9);
            panel9.Name = "panel9";
            panel9.Size = new Size(25, 25);
            panel9.TabIndex = 8;
            // 
            // SteamStatus
            // 
            SteamStatus.AutoSize = true;
            SteamStatus.Location = new Point(15, 46);
            SteamStatus.Name = "SteamStatus";
            SteamStatus.Size = new Size(0, 15);
            SteamStatus.TabIndex = 7;
            // 
            // listBox3
            // 
            listBox3.FormattingEnabled = true;
            listBox3.ItemHeight = 15;
            listBox3.Location = new Point(16, 82);
            listBox3.Name = "listBox3";
            listBox3.Size = new Size(246, 154);
            listBox3.TabIndex = 6;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("맑은 고딕", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(16, 9);
            label7.Name = "label7";
            label7.Size = new Size(58, 21);
            label7.TabIndex = 0;
            label7.Text = "Steam";
            // 
            // panel6
            // 
            panel6.BackColor = Color.White;
            panel6.Controls.Add(ShapeStatus);
            panel6.Controls.Add(listBox2);
            panel6.Location = new Point(404, 88);
            panel6.Name = "panel6";
            panel6.Size = new Size(282, 255);
            panel6.TabIndex = 3;
            // 
            // panel7
            // 
            panel7.Location = new Point(237, 6);
            panel7.Name = "panel7";
            panel7.Size = new Size(25, 25);
            panel7.TabIndex = 8;
            // 
            // ShapeStatus
            // 
            ShapeStatus.AutoSize = true;
            ShapeStatus.Location = new Point(15, 46);
            ShapeStatus.Name = "ShapeStatus";
            ShapeStatus.Size = new Size(0, 15);
            ShapeStatus.TabIndex = 7;
            // 
            // listBox2
            // 
            listBox2.FormattingEnabled = true;
            listBox2.ItemHeight = 15;
            listBox2.Location = new Point(16, 82);
            listBox2.Name = "listBox2";
            listBox2.Size = new Size(246, 154);
            listBox2.TabIndex = 6;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("맑은 고딕", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(16, 10);
            label5.Name = "label5";
            label5.Size = new Size(57, 21);
            label5.TabIndex = 0;
            label5.Text = "Shape";
            // 
            // panel4
            // 
            panel4.BackColor = Color.White;
            panel4.Controls.Add(panel16);
            panel4.Controls.Add(MixStatus);
            panel4.Controls.Add(listBox1);
            panel4.Location = new Point(23, 88);
            panel4.Name = "panel4";
            panel4.Size = new Size(282, 255);
            panel4.TabIndex = 2;
            // 
            // panel5
            // 
            panel5.Location = new Point(237, 6);
            panel5.Name = "panel5";
            panel5.Size = new Size(25, 25);
            panel5.TabIndex = 8;
            // 
            // MixStatus
            // 
            MixStatus.AutoSize = true;
            MixStatus.Location = new Point(15, 46);
            MixStatus.Name = "MixStatus";
            MixStatus.Size = new Size(0, 15);
            MixStatus.TabIndex = 7;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(16, 82);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(246, 154);
            listBox1.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("맑은 고딕", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(11, 10);
            label3.Name = "label3";
            label3.Size = new Size(38, 21);
            label3.TabIndex = 0;
            label3.Text = "Mix";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("맑은 고딕", 27.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(23, 13);
            label2.Name = "label2";
            label2.Size = new Size(399, 50);
            label2.TabIndex = 1;
            label2.Text = "아두이노 <-> PC 통신";
            // 
            // panel16
            // 
            panel16.BackColor = Color.FromArgb(52, 152, 219);
            panel16.Controls.Add(panel5);
            panel16.Controls.Add(label3);
            panel16.Location = new Point(0, 0);
            panel16.Name = "panel16";
            panel16.Size = new Size(282, 39);
            panel16.TabIndex = 10;
            // 
            // panel17
            // 
            panel17.BackColor = Color.FromArgb(52, 152, 219);
            panel17.Controls.Add(panel7);
            panel17.Controls.Add(label5);
            panel17.Location = new Point(404, 88);
            panel17.Name = "panel17";
            panel17.Size = new Size(282, 39);
            panel17.TabIndex = 11;
            // 
            // panel18
            // 
            panel18.BackColor = Color.FromArgb(52, 152, 219);
            panel18.Controls.Add(label7);
            panel18.Controls.Add(panel9);
            panel18.Location = new Point(790, 88);
            panel18.Name = "panel18";
            panel18.Size = new Size(282, 39);
            panel18.TabIndex = 12;
            // 
            // panel19
            // 
            panel19.BackColor = Color.FromArgb(52, 152, 219);
            panel19.Controls.Add(label9);
            panel19.Controls.Add(panel11);
            panel19.Location = new Point(0, 0);
            panel19.Name = "panel19";
            panel19.Size = new Size(282, 39);
            panel19.TabIndex = 12;
            // 
            // panel20
            // 
            panel20.BackColor = Color.FromArgb(52, 152, 219);
            panel20.Controls.Add(panel13);
            panel20.Controls.Add(label11);
            panel20.Location = new Point(404, 404);
            panel20.Name = "panel20";
            panel20.Size = new Size(282, 39);
            panel20.TabIndex = 13;
            // 
            // panel21
            // 
            panel21.BackColor = Color.FromArgb(52, 152, 219);
            panel21.Controls.Add(label13);
            panel21.Controls.Add(panel15);
            panel21.Location = new Point(0, 0);
            panel21.Name = "panel21";
            panel21.Size = new Size(282, 39);
            panel21.TabIndex = 14;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1264, 761);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MainForm";
            FormClosed += MainForm_FormClosed;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel14.ResumeLayout(false);
            panel14.PerformLayout();
            panel12.ResumeLayout(false);
            panel12.PerformLayout();
            panel10.ResumeLayout(false);
            panel10.PerformLayout();
            panel8.ResumeLayout(false);
            panel8.PerformLayout();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel16.ResumeLayout(false);
            panel16.PerformLayout();
            panel17.ResumeLayout(false);
            panel17.PerformLayout();
            panel18.ResumeLayout(false);
            panel18.PerformLayout();
            panel19.ResumeLayout(false);
            panel19.PerformLayout();
            panel20.ResumeLayout(false);
            panel20.PerformLayout();
            panel21.ResumeLayout(false);
            panel21.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel2;
        private Label label1;
        private Panel panel1;
        private Button btn_ChartForm;
        private Button btn_OrderForm;
        private Button btn_StockForm;
        private Button btn_TestForm;
        private Button btn_ProcessForm;
        private Button btn_LOTForm;
        private Panel panel3;
        private Label label2;
        private Panel panel4;
        private Label label3;
        private Panel panel14;
        private Panel panel15;
        private Label PackStatus;
        private ListBox listBox6;
        private Label label13;
        private Panel panel12;
        private Panel panel13;
        private Label FreezeStatus;
        private ListBox listBox5;
        private Label label11;
        private Panel panel10;
        private Panel panel11;
        private Label FryStatus;
        private ListBox listBox4;
        private Label label9;
        private Panel panel8;
        private Panel panel9;
        private Label SteamStatus;
        private ListBox listBox3;
        private Label label7;
        private Panel panel6;
        private Panel panel7;
        private Label ShapeStatus;
        private ListBox listBox2;
        private Label label5;
        private Panel panel5;
        private Label MixStatus;
        private ListBox listBox1;
        private Panel panel20;
        private Panel panel18;
        private Panel panel17;
        private Panel panel21;
        private Panel panel19;
        private Panel panel16;
    }
}