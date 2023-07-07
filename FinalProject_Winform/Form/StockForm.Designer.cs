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
            btn_chart = new Button();
            btn_order = new Button();
            btn_stock = new Button();
            btn_check = new Button();
            btn_process = new Button();
            btn_LOT = new Button();
            tabControl1 = new TabControl();
            tabImport = new TabPage();
            dataGridView1 = new DataGridView();
            panel3 = new Panel();
            button1 = new Button();
            txtAmount = new TextBox();
            label3 = new Label();
            comboBox1 = new ComboBox();
            label2 = new Label();
            tabExport = new TabPage();
            dataGridView2 = new DataGridView();
            panel4 = new Panel();
            button2 = new Button();
            textBox2 = new TextBox();
            label5 = new Label();
            tabStock = new TabPage();
            panel5 = new Panel();
            button3 = new Button();
            comboBox2 = new ComboBox();
            label6 = new Label();
            item_name = new DataGridViewTextBoxColumn();
            item_warehousing = new DataGridViewTextBoxColumn();
            item_count = new DataGridViewTextBoxColumn();
            item_regdate = new DataGridViewTextBoxColumn();
            item_amount = new DataGridViewTextBoxColumn();
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
            btn_chart.Click += Button_Click;
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
            btn_order.Click += Button_Click;
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
            btn_stock.Click += Button_Click;
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
            btn_check.Click += Button_Click;
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
            btn_process.Click += Button_Click;
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
            btn_LOT.Click += Button_Click;
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
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { item_name, item_warehousing, item_count, item_regdate, item_amount });
            dataGridView1.Location = new Point(7, 139);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(1081, 464);
            dataGridView1.TabIndex = 1;
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
            dataGridView2.BackgroundColor = Color.White;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(7, 139);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowTemplate.Height = 25;
            dataGridView2.Size = new Size(1081, 476);
            dataGridView2.TabIndex = 2;
            // 
            // panel4
            // 
            panel4.BackColor = Color.White;
            panel4.Controls.Add(button2);
            panel4.Controls.Add(textBox2);
            panel4.Controls.Add(label5);
            panel4.Location = new Point(4, 31);
            panel4.Name = "panel4";
            panel4.Size = new Size(1086, 91);
            panel4.TabIndex = 1;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(52, 152, 219);
            button2.FlatAppearance.BorderColor = Color.White;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("맑은 고딕", 18F, FontStyle.Bold, GraphicsUnit.Point);
            button2.Location = new Point(922, 22);
            button2.Name = "button2";
            button2.Size = new Size(132, 46);
            button2.TabIndex = 4;
            button2.Text = "출고";
            button2.UseVisualStyleBackColor = false;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("맑은 고딕", 18F, FontStyle.Bold, GraphicsUnit.Point);
            textBox2.Location = new Point(216, 26);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(617, 39);
            textBox2.TabIndex = 3;
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
            tabStock.Controls.Add(panel5);
            tabStock.Location = new Point(4, 44);
            tabStock.Name = "tabStock";
            tabStock.Padding = new Padding(3);
            tabStock.Size = new Size(1096, 623);
            tabStock.TabIndex = 2;
            tabStock.Text = "이력조회";
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
            // 
            // comboBox2
            // 
            comboBox2.Font = new Font("맑은 고딕", 18F, FontStyle.Bold, GraphicsUnit.Point);
            comboBox2.FormattingEnabled = true;
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
            // item_name
            // 
            item_name.HeaderText = "종류";
            item_name.Name = "item_name";
            item_name.ReadOnly = true;
            item_name.Width = 150;
            // 
            // item_warehousing
            // 
            item_warehousing.HeaderText = "입/출고";
            item_warehousing.Name = "item_warehousing";
            item_warehousing.ReadOnly = true;
            item_warehousing.Width = 150;
            // 
            // item_count
            // 
            item_count.HeaderText = "수량변화";
            item_count.Name = "item_count";
            item_count.ReadOnly = true;
            item_count.Width = 150;
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
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
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
        private TabPage tabImport;
        private TabPage tabExport;
        private TabPage tabStock;
        private Panel panel3;
        private Label label2;
        private ComboBox comboBox1;
        private DataGridView dataGridView1;
        private TextBox txtAmount;
        private Label label3;
        private Panel panel4;
        private Button button2;
        private TextBox textBox2;
        private Label label5;
        private DataGridView dataGridView2;
        private Panel panel5;
        private ComboBox comboBox2;
        private Label label6;
        private Button button1;
        private Button button3;
        private DataGridViewTextBoxColumn item_name;
        private DataGridViewTextBoxColumn item_warehousing;
        private DataGridViewTextBoxColumn item_count;
        private DataGridViewTextBoxColumn item_regdate;
        private DataGridViewTextBoxColumn item_amount;
    }
}