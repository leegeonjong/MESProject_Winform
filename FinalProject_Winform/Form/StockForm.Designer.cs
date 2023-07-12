namespace FinalProject_Winform
{
    partial class StockForm
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
            tabControl1 = new TabControl();
            tabImport = new TabPage();
            dataGridView1 = new DataGridView();
            item_name = new DataGridViewTextBoxColumn();
            item_count = new DataGridViewTextBoxColumn();
            item_warehousing = new DataGridViewTextBoxColumn();
            item_regdate = new DataGridViewTextBoxColumn();
            item_amount = new DataGridViewTextBoxColumn();
            panel3 = new Panel();
            button1 = new Button();
            txtAmount = new TextBox();
            label3 = new Label();
            comboBox1 = new ComboBox();
            label2 = new Label();
            tabExport = new TabPage();
            dataGridView2 = new DataGridView();
            item_name2 = new DataGridViewTextBoxColumn();
            item_warehousing2 = new DataGridViewTextBoxColumn();
            item_count2 = new DataGridViewTextBoxColumn();
            item_regdate2 = new DataGridViewTextBoxColumn();
            item_amount2 = new DataGridViewTextBoxColumn();
            panel4 = new Panel();
            btn_Export = new Button();
            txtOrder = new TextBox();
            label5 = new Label();
            tabStock = new TabPage();
            dataGridView3 = new DataGridView();
            item_name3 = new DataGridViewTextBoxColumn();
            item_warehousing3 = new DataGridViewTextBoxColumn();
            item_count3 = new DataGridViewTextBoxColumn();
            item_regdate3 = new DataGridViewTextBoxColumn();
            item_amount3 = new DataGridViewTextBoxColumn();
            panel5 = new Panel();
            button3 = new Button();
            comboBox2 = new ComboBox();
            label6 = new Label();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            tabControl1.SuspendLayout();
            tabImport.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel3.SuspendLayout();
            tabExport.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            panel4.SuspendLayout();
            tabStock.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView3).BeginInit();
            panel5.SuspendLayout();
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
            btn_ChartForm.Location = new Point(0, 0);
            btn_ChartForm.Name = "btn_ChartForm";
            btn_ChartForm.Size = new Size(75, 23);
            btn_ChartForm.TabIndex = 0;
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
            btn_OrderForm.TabIndex = 19;
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
            btn_StockForm.Location = new Point(-4, 380);
            btn_StockForm.Name = "btn_StockForm";
            btn_StockForm.Size = new Size(168, 104);
            btn_StockForm.TabIndex = 20;
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
            btn_TestForm.Location = new Point(-4, 279);
            btn_TestForm.Name = "btn_TestForm";
            btn_TestForm.Size = new Size(168, 104);
            btn_TestForm.TabIndex = 21;
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
            btn_ProcessForm.Location = new Point(-4, 178);
            btn_ProcessForm.Name = "btn_ProcessForm";
            btn_ProcessForm.Size = new Size(168, 104);
            btn_ProcessForm.TabIndex = 17;
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
            btn_LOTForm.Location = new Point(-4, 77);
            btn_LOTForm.Name = "btn_LOTForm";
            btn_LOTForm.Size = new Size(168, 104);
            btn_LOTForm.TabIndex = 16;
            btn_LOTForm.Text = "LOT";
            btn_LOTForm.TextAlign = ContentAlignment.MiddleLeft;
            btn_LOTForm.UseVisualStyleBackColor = true;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabImport);
            tabControl1.Controls.Add(tabExport);
            tabControl1.Controls.Add(tabStock);
            tabControl1.Dock = DockStyle.Bottom;
            tabControl1.ItemSize = new Size(200, 40);
            tabControl1.Location = new Point(160, 90);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1104, 671);
            tabControl1.TabIndex = 6;
            tabControl1.Selected += tabControl1_Selected;
            // 
            // tabImport
            // 
            tabImport.BackColor = Color.Gray;
            tabImport.Controls.Add(dataGridView1);
            tabImport.Controls.Add(panel3);
            tabImport.Location = new Point(4, 44);
            tabImport.Name = "tabImport";
            tabImport.Padding = new Padding(3);
            tabImport.Size = new Size(1096, 623);
            tabImport.TabIndex = 0;
            tabImport.Text = "입고";
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { item_name, item_count, item_warehousing, item_regdate, item_amount });
            dataGridView1.Location = new Point(7, 145);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(1086, 453);
            dataGridView1.TabIndex = 1;
            // 
            // item_name
            // 
            item_name.HeaderText = "종류";
            item_name.Name = "item_name";
            item_name.ReadOnly = true;
            item_name.Width = 150;
            // 
            // item_count
            // 
            item_count.HeaderText = "수량변화";
            item_count.Name = "item_count";
            item_count.ReadOnly = true;
            item_count.Width = 150;
            // 
            // item_warehousing
            // 
            item_warehousing.HeaderText = "입/출고";
            item_warehousing.Name = "item_warehousing";
            item_warehousing.ReadOnly = true;
            item_warehousing.Width = 150;
            // 
            // item_regdate
            // 
            item_regdate.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            item_regdate.HeaderText = "날짜";
            item_regdate.Name = "item_regdate";
            item_regdate.ReadOnly = true;
            // 
            // item_amount
            // 
            item_amount.HeaderText = "총 수량";
            item_amount.Name = "item_amount";
            item_amount.ReadOnly = true;
            item_amount.Width = 180;
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.Controls.Add(button1);
            panel3.Controls.Add(txtAmount);
            panel3.Controls.Add(label3);
            panel3.Controls.Add(comboBox1);
            panel3.Controls.Add(label2);
            panel3.Location = new Point(4, 31);
            panel3.Name = "panel3";
            panel3.Size = new Size(1086, 91);
            panel3.TabIndex = 0;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(52, 152, 219);
            button1.FlatAppearance.BorderColor = Color.White;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("맑은 고딕", 18F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(922, 22);
            button1.Name = "button1";
            button1.Size = new Size(132, 46);
            button1.TabIndex = 5;
            button1.Text = "입고";
            button1.UseVisualStyleBackColor = false;
            button1.Click += btn_Import;
            // 
            // txtAmount
            // 
            txtAmount.Font = new Font("맑은 고딕", 18F, FontStyle.Bold, GraphicsUnit.Point);
            txtAmount.Location = new Point(618, 26);
            txtAmount.Name = "txtAmount";
            txtAmount.Size = new Size(206, 39);
            txtAmount.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("맑은 고딕", 26.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(494, 19);
            label3.Name = "label3";
            label3.Size = new Size(90, 47);
            label3.TabIndex = 2;
            label3.Text = "수량";
            // 
            // comboBox1
            // 
            comboBox1.Font = new Font("맑은 고딕", 18F, FontStyle.Bold, GraphicsUnit.Point);
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "밀가루", "물", "반죽", "면", "팜유", "찐 면", "튀긴 면 ", "냉동 면", "후레이크 ", "스프", "포장지", "라면" });
            comboBox1.Location = new Point(122, 22);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(197, 40);
            comboBox1.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("맑은 고딕", 26.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(3, 19);
            label2.Name = "label2";
            label2.Size = new Size(90, 47);
            label2.TabIndex = 0;
            label2.Text = "물품";
            // 
            // tabExport
            // 
            tabExport.BackColor = Color.Gray;
            tabExport.Controls.Add(dataGridView2);
            tabExport.Controls.Add(panel4);
            tabExport.Location = new Point(4, 44);
            tabExport.Name = "tabExport";
            tabExport.Padding = new Padding(3);
            tabExport.Size = new Size(1096, 623);
            tabExport.TabIndex = 1;
            tabExport.Text = "출고";
            // 
            // dataGridView2
            // 
            dataGridView2.AllowUserToAddRows = false;
            dataGridView2.BackgroundColor = Color.White;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Columns.AddRange(new DataGridViewColumn[] { item_name2, item_warehousing2, item_count2, item_regdate2, item_amount2 });
            dataGridView2.Location = new Point(7, 145);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowTemplate.Height = 25;
            dataGridView2.Size = new Size(1086, 453);
            dataGridView2.TabIndex = 2;
            // 
            // item_name2
            // 
            item_name2.HeaderText = "종류";
            item_name2.Name = "item_name2";
            item_name2.ReadOnly = true;
            item_name2.Width = 150;
            // 
            // item_warehousing2
            // 
            item_warehousing2.HeaderText = "입/출고";
            item_warehousing2.Name = "item_warehousing2";
            item_warehousing2.ReadOnly = true;
            item_warehousing2.Width = 150;
            // 
            // item_count2
            // 
            item_count2.HeaderText = "수량변화";
            item_count2.Name = "item_count2";
            item_count2.ReadOnly = true;
            item_count2.Width = 150;
            // 
            // item_regdate2
            // 
            item_regdate2.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            item_regdate2.HeaderText = "날짜";
            item_regdate2.Name = "item_regdate2";
            item_regdate2.ReadOnly = true;
            // 
            // item_amount2
            // 
            item_amount2.HeaderText = "총 수량";
            item_amount2.Name = "item_amount2";
            item_amount2.ReadOnly = true;
            item_amount2.Width = 180;
            // 
            // panel4
            // 
            panel4.BackColor = Color.White;
            panel4.Controls.Add(btn_Export);
            panel4.Controls.Add(txtOrder);
            panel4.Controls.Add(label5);
            panel4.Location = new Point(4, 31);
            panel4.Name = "panel4";
            panel4.Size = new Size(1086, 91);
            panel4.TabIndex = 1;
            // 
            // btn_Export
            // 
            btn_Export.BackColor = Color.FromArgb(52, 152, 219);
            btn_Export.FlatAppearance.BorderColor = Color.White;
            btn_Export.FlatStyle = FlatStyle.Flat;
            btn_Export.Font = new Font("맑은 고딕", 18F, FontStyle.Bold, GraphicsUnit.Point);
            btn_Export.Location = new Point(922, 22);
            btn_Export.Name = "btn_Export";
            btn_Export.Size = new Size(132, 46);
            btn_Export.TabIndex = 4;
            btn_Export.Text = "출고";
            btn_Export.UseVisualStyleBackColor = false;
            btn_Export.Click += btn_Export_Click;
            // 
            // txtOrder
            // 
            txtOrder.Font = new Font("맑은 고딕", 18F, FontStyle.Bold, GraphicsUnit.Point);
            txtOrder.Location = new Point(216, 26);
            txtOrder.Name = "txtOrder";
            txtOrder.Size = new Size(617, 39);
            txtOrder.TabIndex = 3;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("맑은 고딕", 26.25F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(3, 19);
            label5.Name = "label5";
            label5.Size = new Size(160, 47);
            label5.TabIndex = 0;
            label5.Text = "주문번호";
            // 
            // tabStock
            // 
            tabStock.BackColor = Color.Gray;
            tabStock.Controls.Add(dataGridView3);
            tabStock.Controls.Add(panel5);
            tabStock.Location = new Point(4, 44);
            tabStock.Name = "tabStock";
            tabStock.Padding = new Padding(3);
            tabStock.Size = new Size(1096, 623);
            tabStock.TabIndex = 2;
            tabStock.Text = "이력조회";
            // 
            // dataGridView3
            // 
            dataGridView3.AllowUserToAddRows = false;
            dataGridView3.BackgroundColor = Color.White;
            dataGridView3.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView3.Columns.AddRange(new DataGridViewColumn[] { item_name3, item_warehousing3, item_count3, item_regdate3, item_amount3 });
            dataGridView3.Location = new Point(7, 145);
            dataGridView3.Name = "dataGridView3";
            dataGridView3.RowTemplate.Height = 25;
            dataGridView3.Size = new Size(1086, 453);
            dataGridView3.TabIndex = 2;
            // 
            // item_name3
            // 
            item_name3.HeaderText = "종류";
            item_name3.Name = "item_name3";
            item_name3.ReadOnly = true;
            item_name3.Width = 150;
            // 
            // item_warehousing3
            // 
            item_warehousing3.HeaderText = "입/출고";
            item_warehousing3.Name = "item_warehousing3";
            item_warehousing3.ReadOnly = true;
            item_warehousing3.Width = 150;
            // 
            // item_count3
            // 
            item_count3.HeaderText = "수량변화";
            item_count3.Name = "item_count3";
            item_count3.ReadOnly = true;
            item_count3.Width = 150;
            // 
            // item_regdate3
            // 
            item_regdate3.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            item_regdate3.HeaderText = "날짜";
            item_regdate3.Name = "item_regdate3";
            item_regdate3.ReadOnly = true;
            // 
            // item_amount3
            // 
            item_amount3.HeaderText = "총 수량";
            item_amount3.Name = "item_amount3";
            item_amount3.ReadOnly = true;
            item_amount3.Width = 180;
            // 
            // panel5
            // 
            panel5.BackColor = Color.White;
            panel5.Controls.Add(button3);
            panel5.Controls.Add(comboBox2);
            panel5.Controls.Add(label6);
            panel5.Location = new Point(4, 31);
            panel5.Name = "panel5";
            panel5.Size = new Size(1086, 91);
            panel5.TabIndex = 1;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(52, 152, 219);
            button3.FlatAppearance.BorderColor = Color.White;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("맑은 고딕", 18F, FontStyle.Bold, GraphicsUnit.Point);
            button3.Location = new Point(922, 22);
            button3.Name = "button3";
            button3.Size = new Size(132, 46);
            button3.TabIndex = 5;
            button3.Text = "이력조회";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // comboBox2
            // 
            comboBox2.Font = new Font("맑은 고딕", 18F, FontStyle.Bold, GraphicsUnit.Point);
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "밀가루", "물", "반죽", "면", "팜유", "찐 면", "튀긴 면", "냉동 면", "후레이크", "스프", "포장지", "라면" });
            comboBox2.Location = new Point(151, 25);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(244, 40);
            comboBox2.TabIndex = 1;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("맑은 고딕", 26.25F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(3, 19);
            label6.Name = "label6";
            label6.Size = new Size(90, 47);
            label6.TabIndex = 0;
            label6.Text = "물품";
            // 
            // StockForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1264, 761);
            Controls.Add(tabControl1);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "StockForm";
            Text = "StockForm";
            Load += StockForm_Load;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            tabControl1.ResumeLayout(false);
            tabImport.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            tabExport.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            tabStock.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView3).EndInit();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel2;
        private Label label1;
        private Panel panel1;
        private TabControl tabControl1;
        private TabPage tabImport;
        private TabPage tabExport;
        private TabPage tabStock;
        private Panel panel3;
        private Label label2;
        private ComboBox comboBox1;
        private TextBox txtAmount;
        private Label label3;
        private Panel panel4;
        private Button btn_Export;
        private TextBox txtOrder;
        private Label label5;
        private Panel panel5;
        private ComboBox comboBox2;
        private Label label6;
        private Button button1;
        private Button button3;

        private Button btn_ChartForm;
        private Button btn_OrderForm;
        private Button btn_StockForm;
        private Button btn_TestForm;
        private Button btn_ProcessForm;
        private Button btn_LOTForm;
        private DataGridView dataGridView1;
        private DataGridView dataGridView2;
        private DataGridViewTextBoxColumn item_name;
        private DataGridViewTextBoxColumn item_count;
        private DataGridViewTextBoxColumn item_warehousing;
        private DataGridViewTextBoxColumn item_regdate;
        private DataGridViewTextBoxColumn item_amount;
        private DataGridViewTextBoxColumn item_name2;
        private DataGridViewTextBoxColumn item_warehousing2;
        private DataGridViewTextBoxColumn item_count2;
        private DataGridViewTextBoxColumn item_regdate2;
        private DataGridViewTextBoxColumn item_amount2;
        private DataGridView dataGridView3;
        private DataGridViewTextBoxColumn item_name3;
        private DataGridViewTextBoxColumn item_warehousing3;
        private DataGridViewTextBoxColumn item_count3;
        private DataGridViewTextBoxColumn item_regdate3;
        private DataGridViewTextBoxColumn item_amount3;
    }
}