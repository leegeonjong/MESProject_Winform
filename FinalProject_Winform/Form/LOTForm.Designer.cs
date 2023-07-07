﻿namespace FinalProject_Winform
{
    partial class LOTForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_chart = new System.Windows.Forms.Button();
            this.btn_order = new System.Windows.Forms.Button();
            this.btn_stock = new System.Windows.Forms.Button();
            this.btn_check = new System.Windows.Forms.Button();
            this.btn_process = new System.Windows.Forms.Button();
            this.btn_LOT = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label9 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.panel7 = new System.Windows.Forms.Panel();
            this.lbl_text_count = new System.Windows.Forms.Label();
            this.lbl_count = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.lbl_barcode = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.lbl_text_item = new System.Windows.Forms.Label();
            this.lbl_count1 = new System.Windows.Forms.Label();
            this.lbl_item = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.picture_Barcode = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.lbl_stockname = new System.Windows.Forms.Label();
            this.textBox_count = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox_item = new System.Windows.Forms.ComboBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picture_Barcode)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
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
            panel1.TabIndex = 0;
            // 
            // btn_ChartForm
            // 
            btn_ChartForm.FlatAppearance.BorderColor = Color.Gray;
            btn_ChartForm.FlatAppearance.BorderSize = 2;
            btn_ChartForm.FlatStyle = FlatStyle.Flat;
            btn_ChartForm.Font = new Font("맑은 고딕", 24F, FontStyle.Bold, GraphicsUnit.Point);
            btn_ChartForm.Location = new Point(-3, 586);
            btn_ChartForm.Name = "btn_ChartForm";
            btn_ChartForm.Size = new Size(168, 104);
            btn_ChartForm.TabIndex = 3;
            btn_ChartForm.Text = "현황판";
            btn_ChartForm.TextAlign = ContentAlignment.MiddleLeft;
            btn_ChartForm.UseVisualStyleBackColor = true;
            // 
            // btn_OrderForm
            // 
            btn_OrderForm.FlatAppearance.BorderColor = Color.Gray;
            btn_OrderForm.FlatAppearance.BorderSize = 2;
            btn_OrderForm.FlatStyle = FlatStyle.Flat;
            btn_OrderForm.Font = new Font("맑은 고딕", 24F, FontStyle.Bold, GraphicsUnit.Point);
            btn_OrderForm.Location = new Point(-3, 486);
            btn_OrderForm.Name = "btn_OrderForm";
            btn_OrderForm.Size = new Size(168, 104);
            btn_OrderForm.TabIndex = 3;
            btn_OrderForm.Text = "주문";
            btn_OrderForm.TextAlign = ContentAlignment.MiddleLeft;
            btn_OrderForm.UseVisualStyleBackColor = true;
            // 
            // btn_StockForm
            // 
            btn_StockForm.FlatAppearance.BorderColor = Color.Gray;
            btn_StockForm.FlatAppearance.BorderSize = 2;
            btn_StockForm.FlatStyle = FlatStyle.Flat;
            btn_StockForm.Font = new Font("맑은 고딕", 24F, FontStyle.Bold, GraphicsUnit.Point);
            btn_StockForm.Location = new Point(-3, 386);
            btn_StockForm.Name = "btn_StockForm";
            btn_StockForm.Size = new Size(168, 104);
            btn_StockForm.TabIndex = 3;
            btn_StockForm.Text = "재고관리";
            btn_StockForm.TextAlign = ContentAlignment.MiddleLeft;
            btn_StockForm.UseVisualStyleBackColor = true;
            // 
            // btn_TestForm
            // 
            btn_TestForm.FlatAppearance.BorderColor = Color.Gray;
            btn_TestForm.FlatAppearance.BorderSize = 2;
            btn_TestForm.FlatStyle = FlatStyle.Flat;
            btn_TestForm.Font = new Font("맑은 고딕", 24F, FontStyle.Bold, GraphicsUnit.Point);
            btn_TestForm.Location = new Point(-3, 285);
            btn_TestForm.Name = "btn_TestForm";
            btn_TestForm.Size = new Size(168, 104);
            btn_TestForm.TabIndex = 3;
            btn_TestForm.Text = "검사";
            btn_TestForm.TextAlign = ContentAlignment.MiddleLeft;
            btn_TestForm.UseVisualStyleBackColor = true;
            // 
            // btn_ProcessForm
            // 
            btn_ProcessForm.FlatAppearance.BorderColor = Color.Gray;
            btn_ProcessForm.FlatAppearance.BorderSize = 2;
            btn_ProcessForm.FlatStyle = FlatStyle.Flat;
            btn_ProcessForm.Font = new Font("맑은 고딕", 24F, FontStyle.Bold, GraphicsUnit.Point);
            btn_ProcessForm.Location = new Point(-3, 184);
            btn_ProcessForm.Name = "btn_ProcessForm";
            btn_ProcessForm.Size = new Size(168, 104);
            btn_ProcessForm.TabIndex = 2;
            btn_ProcessForm.Text = "공정";
            btn_ProcessForm.TextAlign = ContentAlignment.MiddleLeft;
            btn_ProcessForm.UseVisualStyleBackColor = true;
            // 
            // btn_LOTForm
            // 
            btn_LOTForm.FlatAppearance.BorderColor = Color.Gray;
            btn_LOTForm.FlatAppearance.BorderSize = 2;
            btn_LOTForm.FlatStyle = FlatStyle.Flat;
            btn_LOTForm.Font = new Font("맑은 고딕", 24F, FontStyle.Bold, GraphicsUnit.Point);
            btn_LOTForm.Location = new Point(-3, 83);
            btn_LOTForm.Name = "btn_LOTForm";
            btn_LOTForm.Size = new Size(168, 104);
            btn_LOTForm.TabIndex = 1;
            btn_LOTForm.Text = "LOT";
            btn_LOTForm.TextAlign = ContentAlignment.MiddleLeft;
            btn_LOTForm.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(52, 152, 219);
            panel2.Controls.Add(label1);
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1264, 88);
            panel2.TabIndex = 1;
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
            tabControl1.TabIndex = 5;
            // 
            // tabPage1
            // 
            tabPage1.BackColor = Color.Gainsboro;
            tabPage1.Controls.Add(label9);
            tabPage1.Controls.Add(button2);
            tabPage1.Controls.Add(panel7);
            tabPage1.Controls.Add(panel6);
            tabPage1.Controls.Add(panel5);
            tabPage1.Controls.Add(panel4);
            tabPage1.Controls.Add(panel3);
            tabPage1.Location = new Point(4, 44);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3, 3, 3, 3);
            tabPage1.Size = new Size(1096, 623);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "tabPage1asdfadfasdfafa";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("맑은 고딕", 28.2F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(42, 18);
            label9.Margin = new Padding(2, 0, 2, 0);
            label9.Name = "label9";
            label9.Size = new Size(225, 51);
            label9.TabIndex = 5;
            label9.Text = "바코드 생성";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.button2.FlatAppearance.BorderSize = 2;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("맑은 고딕", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button2.Location = new System.Drawing.Point(1145, 694);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(207, 62);
            this.button2.TabIndex = 5;
            this.button2.Text = "LOT 생성";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.White;
            this.panel7.Controls.Add(this.lbl_text_count);
            this.panel7.Controls.Add(this.lbl_count);
            this.panel7.Controls.Add(this.label8);
            this.panel7.Location = new System.Drawing.Point(738, 538);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(614, 98);
            this.panel7.TabIndex = 8;
            // 
            // lbl_text_count
            // 
            this.lbl_text_count.AutoSize = true;
            this.lbl_text_count.Font = new System.Drawing.Font("맑은 고딕", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_text_count.Location = new System.Drawing.Point(197, 25);
            this.lbl_text_count.Name = "lbl_text_count";
            this.lbl_text_count.Size = new System.Drawing.Size(154, 50);
            this.lbl_text_count.TabIndex = 8;
            this.lbl_text_count.Text = "제품명: ";
            // 
            // lbl_count
            // 
            lbl_count.AutoSize = true;
            lbl_count.Font = new Font("맑은 고딕", 22.2F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_count.Location = new Point(153, 19);
            lbl_count.Margin = new Padding(2, 0, 2, 0);
            lbl_count.Name = "lbl_count";
            lbl_count.Size = new Size(0, 41);
            lbl_count.TabIndex = 7;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("맑은 고딕", 22.2F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(18, 19);
            label8.Margin = new Padding(2, 0, 2, 0);
            label8.Name = "label8";
            label8.Size = new Size(85, 41);
            label8.TabIndex = 5;
            label8.Text = "수량:";
            // 
            // panel6
            // 
            panel6.BackColor = Color.White;
            panel6.Controls.Add(lbl_barcode);
            panel6.Controls.Add(label4);
            panel6.Location = new Point(574, 310);
            panel6.Margin = new Padding(2, 2, 2, 2);
            panel6.Name = "panel6";
            panel6.Size = new Size(478, 74);
            panel6.TabIndex = 7;
            // 
            // lbl_barcode
            // 
            lbl_barcode.AutoSize = true;
            lbl_barcode.Font = new Font("맑은 고딕", 22.2F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_barcode.Location = new Point(153, 20);
            lbl_barcode.Margin = new Padding(2, 0, 2, 0);
            lbl_barcode.Name = "lbl_barcode";
            lbl_barcode.Size = new Size(0, 41);
            lbl_barcode.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("맑은 고딕", 22.2F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(18, 20);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(149, 41);
            label4.TabIndex = 5;
            label4.Text = "LOT번호: ";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.White;
            this.panel5.Controls.Add(this.lbl_text_item);
            this.panel5.Controls.Add(this.lbl_count1);
            this.panel5.Controls.Add(this.lbl_item);
            this.panel5.Controls.Add(this.label3);
            this.panel5.Location = new System.Drawing.Point(738, 295);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(614, 98);
            this.panel5.TabIndex = 6;
            // 
            // lbl_text_item
            // 
            this.lbl_text_item.AutoSize = true;
            this.lbl_text_item.Font = new System.Drawing.Font("맑은 고딕", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_text_item.Location = new System.Drawing.Point(173, 21);
            this.lbl_text_item.Name = "lbl_text_item";
            this.lbl_text_item.Size = new System.Drawing.Size(154, 50);
            this.lbl_text_item.TabIndex = 9;
            this.lbl_text_item.Text = "제품명: ";
            // 
            // lbl_count1
            // 
            this.lbl_count1.AutoSize = true;
            this.lbl_count1.Font = new System.Drawing.Font("맑은 고딕", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_count1.Location = new System.Drawing.Point(173, 21);
            this.lbl_count1.Name = "lbl_count1";
            this.lbl_count1.Size = new System.Drawing.Size(0, 50);
            this.lbl_count1.TabIndex = 7;
            // 
            // lbl_item
            // 
            lbl_item.AutoSize = true;
            lbl_item.Font = new Font("맑은 고딕", 22.2F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_item.Location = new Point(153, 16);
            lbl_item.Margin = new Padding(2, 0, 2, 0);
            lbl_item.Name = "lbl_item";
            lbl_item.Size = new Size(0, 41);
            lbl_item.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("맑은 고딕", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(23, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(154, 50);
            this.label3.TabIndex = 5;
            this.label3.Text = "제품명: ";
            // 
            // panel4
            // 
            panel4.BackColor = Color.White;
            panel4.Controls.Add(picture_Barcode);
            panel4.Location = new Point(31, 221);
            panel4.Margin = new Padding(2, 2, 2, 2);
            panel4.Name = "panel4";
            panel4.Size = new Size(518, 354);
            panel4.TabIndex = 4;
            // 
            // picture_Barcode
            // 
            picture_Barcode.Location = new Point(19, 16);
            picture_Barcode.Margin = new Padding(2, 2, 2, 2);
            picture_Barcode.Name = "picture_Barcode";
            picture_Barcode.Size = new Size(479, 319);
            picture_Barcode.TabIndex = 3;
            picture_Barcode.TabStop = false;
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.Controls.Add(button1);
            panel3.Controls.Add(lbl_stockname);
            panel3.Controls.Add(textBox_count);
            panel3.Controls.Add(label2);
            panel3.Controls.Add(comboBox_item);
            panel3.Location = new Point(31, 96);
            panel3.Margin = new Padding(2, 2, 2, 2);
            panel3.Name = "panel3";
            panel3.Size = new Size(1020, 94);
            panel3.TabIndex = 2;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(52, 152, 219);
            button1.FlatAppearance.BorderColor = Color.FromArgb(52, 152, 219);
            button1.FlatAppearance.BorderSize = 2;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("맑은 고딕", 22.2F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(859, 22);
            button1.Margin = new Padding(2, 2, 2, 2);
            button1.Name = "button1";
            button1.Size = new Size(138, 46);
            button1.TabIndex = 4;
            button1.Text = "생성";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // lbl_stockname
            // 
            lbl_stockname.AutoSize = true;
            lbl_stockname.Font = new Font("맑은 고딕", 28.2F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_stockname.Location = new Point(11, 22);
            lbl_stockname.Margin = new Padding(2, 0, 2, 0);
            lbl_stockname.Name = "lbl_stockname";
            lbl_stockname.Size = new Size(157, 51);
            lbl_stockname.TabIndex = 0;
            lbl_stockname.Text = "제품명: ";
            // 
            // textBox_count
            // 
            textBox_count.Font = new Font("맑은 고딕", 28.2F, FontStyle.Regular, GraphicsUnit.Point);
            textBox_count.Location = new Point(561, 20);
            textBox_count.Margin = new Padding(2, 2, 2, 2);
            textBox_count.Name = "textBox_count";
            textBox_count.Size = new Size(282, 58);
            textBox_count.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("맑은 고딕", 28.2F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(381, 22);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(182, 51);
            label2.TabIndex = 3;
            label2.Text = "수량입력:";
            // 
            // comboBox_item
            // 
            comboBox_item.Font = new Font("맑은 고딕", 28.2F, FontStyle.Regular, GraphicsUnit.Point);
            comboBox_item.FormattingEnabled = true;
            comboBox_item.ItemHeight = 51;
            comboBox_item.Items.AddRange(new object[] { "밀가루" });
            comboBox_item.Location = new Point(167, 20);
            comboBox_item.Margin = new Padding(2, 2, 2, 2);
            comboBox_item.Name = "comboBox_item";
            comboBox_item.Size = new Size(210, 59);
            comboBox_item.TabIndex = 1;
            comboBox_item.Text = "제품선택";
            // 
            // tabPage2
            // 
            tabPage2.Location = new Point(4, 44);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3, 3, 3, 3);
            tabPage2.Size = new Size(1096, 623);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "tabPage2";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // LOTForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1264, 761);
            Controls.Add(tabControl1);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "LOTForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "LOTForm";
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picture_Barcode).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btn_LOTForm;
        private Panel panel2;
        private Button btn_ProcessForm;
        private Button btn_ChartForm;
        private Button btn_OrderForm;
        private Button btn_StockForm;
        private Button btn_TestForm;
        private Label label1;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private ComboBox comboBox_item;
        private Label lbl_stockname;
        private Panel panel3;
        private TextBox textBox_count;
        private Label label2;
        private Button button1;
        private Panel panel5;
        private Label label3;
        private Panel panel4;
        private PictureBox picture_Barcode;
        private Button button2;
        private Panel panel7;
        private Label lbl_count;
        private Label label8;
        private Panel panel6;
        private Label lbl_barcode;
        private Label label4;
        private Label lbl_item;
        private Label label9;
        private Label lbl_count1;
        private Label lbl_text_count;
        private Label lbl_text_item;
    }
}