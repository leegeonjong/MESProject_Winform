namespace FinalProject_Winform
{
    partial class TestForm
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
            cmbTest = new ComboBox();
            cmbProcess1 = new ComboBox();
            txtNowValue = new TextBox();
            txtSetValue = new TextBox();
            textBox3 = new TextBox();
            cmbProcess2 = new ComboBox();
            cmbProcess3 = new ComboBox();
            label2 = new Label();
            label3 = new Label();
            txtHiding = new TextBox();
            label4 = new Label();
            txtSetTolerance = new TextBox();
            label5 = new Label();
            txtNowTolerance = new TextBox();
            button4 = new Button();
            panel3 = new Panel();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
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
            label1.Size = new Size(109, 50);
            label1.TabIndex = 0;
            label1.Text = "검 사";
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
            // cmbTest
            // 
            cmbTest.Font = new Font("맑은 고딕", 18F, FontStyle.Regular, GraphicsUnit.Point);
            cmbTest.FormattingEnabled = true;
            cmbTest.Items.AddRange(new object[] { "수량 검사", "온도 검사", "용량 검사" });
            cmbTest.Location = new Point(58, 80);
            cmbTest.Name = "cmbTest";
            cmbTest.Size = new Size(267, 40);
            cmbTest.TabIndex = 6;
            cmbTest.Text = "검사 선택";
            cmbTest.SelectedIndexChanged += cmbTest_SelectedIndexChanged;
            // 
            // cmbProcess1
            // 
            cmbProcess1.Font = new Font("맑은 고딕", 18F, FontStyle.Regular, GraphicsUnit.Point);
            cmbProcess1.FormattingEnabled = true;
            cmbProcess1.Items.AddRange(new object[] { "Mix", "Pack" });
            cmbProcess1.Location = new Point(364, 81);
            cmbProcess1.Name = "cmbProcess1";
            cmbProcess1.Size = new Size(240, 40);
            cmbProcess1.TabIndex = 7;
            cmbProcess1.Text = "공정 선택";
            cmbProcess1.SelectedIndexChanged += cmbProcess1_SelectedIndexChanged;
            // 
            // txtNowValue
            // 
            txtNowValue.Font = new Font("맑은 고딕", 18F, FontStyle.Regular, GraphicsUnit.Point);
            txtNowValue.Location = new Point(337, 169);
            txtNowValue.Name = "txtNowValue";
            txtNowValue.ReadOnly = true;
            txtNowValue.Size = new Size(267, 39);
            txtNowValue.TabIndex = 8;
            // 
            // txtSetValue
            // 
            txtSetValue.BackColor = SystemColors.Control;
            txtSetValue.Font = new Font("맑은 고딕", 18F, FontStyle.Regular, GraphicsUnit.Point);
            txtSetValue.Location = new Point(337, 304);
            txtSetValue.Name = "txtSetValue";
            txtSetValue.Size = new Size(267, 39);
            txtSetValue.TabIndex = 9;
            // 
            // textBox3
            // 
            textBox3.Font = new Font("맑은 고딕", 24F, FontStyle.Regular, GraphicsUnit.Point);
            textBox3.Location = new Point(58, 15);
            textBox3.Name = "textBox3";
            textBox3.ReadOnly = true;
            textBox3.Size = new Size(267, 50);
            textBox3.TabIndex = 10;
            textBox3.Text = "검사 기준값 설정";
            // 
            // cmbProcess2
            // 
            cmbProcess2.Font = new Font("맑은 고딕", 18F, FontStyle.Regular, GraphicsUnit.Point);
            cmbProcess2.FormattingEnabled = true;
            cmbProcess2.Items.AddRange(new object[] { "Steam" });
            cmbProcess2.Location = new Point(364, 81);
            cmbProcess2.Name = "cmbProcess2";
            cmbProcess2.Size = new Size(240, 40);
            cmbProcess2.TabIndex = 11;
            cmbProcess2.Text = "공정 선택";
            cmbProcess2.SelectedIndexChanged += cmbProcess2_SelectedIndexChanged;
            // 
            // cmbProcess3
            // 
            cmbProcess3.Font = new Font("맑은 고딕", 18F, FontStyle.Regular, GraphicsUnit.Point);
            cmbProcess3.FormattingEnabled = true;
            cmbProcess3.Items.AddRange(new object[] { "Fry" });
            cmbProcess3.Location = new Point(364, 81);
            cmbProcess3.Name = "cmbProcess3";
            cmbProcess3.Size = new Size(240, 40);
            cmbProcess3.TabIndex = 12;
            cmbProcess3.Text = "공정 선택";
            cmbProcess3.SelectedIndexChanged += cmbProcess3_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.LightGray;
            label2.Font = new Font("맑은 고딕", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(104, 172);
            label2.Name = "label2";
            label2.Size = new Size(142, 32);
            label2.TabIndex = 14;
            label2.Text = "현재 기준값";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.LightGray;
            label3.Font = new Font("맑은 고딕", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(104, 304);
            label3.Name = "label3";
            label3.Size = new Size(142, 32);
            label3.TabIndex = 15;
            label3.Text = "기준값 입력";
            // 
            // txtHiding
            // 
            txtHiding.Font = new Font("맑은 고딕", 18F, FontStyle.Regular, GraphicsUnit.Point);
            txtHiding.Location = new Point(364, 81);
            txtHiding.Name = "txtHiding";
            txtHiding.ReadOnly = true;
            txtHiding.Size = new Size(240, 39);
            txtHiding.TabIndex = 16;
            txtHiding.Text = "검사를 선택해 주세요";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.LightGray;
            label4.Font = new Font("맑은 고딕", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(80, 369);
            label4.Name = "label4";
            label4.Size = new Size(166, 32);
            label4.TabIndex = 17;
            label4.Text = "허용범위 입력";
            // 
            // txtSetTolerance
            // 
            txtSetTolerance.BackColor = SystemColors.Control;
            txtSetTolerance.Font = new Font("맑은 고딕", 18F, FontStyle.Regular, GraphicsUnit.Point);
            txtSetTolerance.Location = new Point(337, 366);
            txtSetTolerance.Name = "txtSetTolerance";
            txtSetTolerance.Size = new Size(267, 39);
            txtSetTolerance.TabIndex = 18;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.LightGray;
            label5.Font = new Font("맑은 고딕", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(80, 230);
            label5.Name = "label5";
            label5.Size = new Size(166, 32);
            label5.TabIndex = 20;
            label5.Text = "현재 허용범위";
            // 
            // txtNowTolerance
            // 
            txtNowTolerance.Font = new Font("맑은 고딕", 18F, FontStyle.Regular, GraphicsUnit.Point);
            txtNowTolerance.Location = new Point(337, 227);
            txtNowTolerance.Name = "txtNowTolerance";
            txtNowTolerance.ReadOnly = true;
            txtNowTolerance.Size = new Size(267, 39);
            txtNowTolerance.TabIndex = 19;
            // 
            // button4
            // 
            button4.BackColor = Color.FromArgb(52, 152, 219);
            button4.FlatAppearance.BorderColor = Color.White;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("맑은 고딕", 18F, FontStyle.Bold, GraphicsUnit.Point);
            button4.Location = new Point(420, 456);
            button4.Name = "button4";
            button4.Size = new Size(184, 46);
            button4.TabIndex = 21;
            button4.Text = "설정 완료";
            button4.UseVisualStyleBackColor = false;
            button4.Click += SetThreshold_Click;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Gainsboro;
            panel3.Controls.Add(label3);
            panel3.Controls.Add(label5);
            panel3.Controls.Add(button4);
            panel3.Controls.Add(label4);
            panel3.Controls.Add(txtNowTolerance);
            panel3.Controls.Add(textBox3);
            panel3.Controls.Add(txtNowValue);
            panel3.Controls.Add(txtSetTolerance);
            panel3.Controls.Add(cmbTest);
            panel3.Controls.Add(txtHiding);
            panel3.Controls.Add(cmbProcess3);
            panel3.Controls.Add(txtSetValue);
            panel3.Controls.Add(cmbProcess2);
            panel3.Controls.Add(label2);
            panel3.Controls.Add(cmbProcess1);
            panel3.Location = new Point(174, 104);
            panel3.Name = "panel3";
            panel3.Size = new Size(1074, 635);
            panel3.TabIndex = 22;
            // 
            // TestForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1260, 761);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(panel3);
            Name = "TestForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "TestForm";
            FormClosed += TestForm_FormClosed;
            Load += Form6_Load;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
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
        private ComboBox cmbTest;
        private ComboBox cmbProcess1;
        private TextBox txtNowValue;
        private TextBox txtSetValue;
        private TextBox textBox3;
        private ComboBox cmbProcess2;
        private ComboBox cmbProcess3;
        private Label label2;
        private Label label3;
        private TextBox txtHiding;
        private Label label4;
        private TextBox txtSetTolerance;
        private Label label5;
        private TextBox txtNowTolerance;
        private Button button4;
        private Panel panel3;
    }
}