namespace FinalProject_Winform
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
            panel1 = new Panel();
            btn_ChartForm = new Button();
            btn_OrderForm = new Button();
            btn_StockForm = new Button();
            btn_TestForm = new Button();
            btn_ProcessForm = new Button();
            btn_LOTForm = new Button();
            panel2 = new Panel();
            label1 = new Label();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            label9 = new Label();
            button2 = new Button();
            panel7 = new Panel();
            lbl_text_count = new Label();
            lbl_count = new Label();
            label8 = new Label();
            panel6 = new Panel();
            lbl_barcode = new Label();
            label4 = new Label();
            panel5 = new Panel();
            lbl_text_item = new Label();
            lbl_count1 = new Label();
            lbl_item = new Label();
            label3 = new Label();
            panel4 = new Panel();
            picture_Barcode = new PictureBox();
            panel3 = new Panel();
            button1 = new Button();
            lbl_stockname = new Label();
            textBox_count = new TextBox();
            label2 = new Label();
            comboBox_item = new ComboBox();
            tabPage2 = new TabPage();
            ComboSearch = new ComboBox();
            button3 = new Button();
            txt_text = new TextBox();
            Dgv_Lot = new DataGridView();
            Lot_Id = new DataGridViewTextBoxColumn();
            Lot_Barcode = new DataGridViewTextBoxColumn();
            Lot_Itemid = new DataGridViewTextBoxColumn();
            Lot_amount = new DataGridViewTextBoxColumn();
            Lot_status = new DataGridViewTextBoxColumn();
            Lot_break = new DataGridViewTextBoxColumn();
            Lot_regdata = new DataGridViewTextBoxColumn();
            tabPage3 = new TabPage();
            panel10 = new Panel();
            lbl_start_check = new Label();
            lbl_start_status = new Label();
            panel17 = new Panel();
            panel15 = new Panel();
            label16 = new Label();
            label15 = new Label();
            btn_Start = new Button();
            comboBox1 = new ComboBox();
            panel16 = new Panel();
            panel18 = new Panel();
            label21 = new Label();
            panel9 = new Panel();
            lbl_start_amount = new Label();
            lbl_start_lotnum = new Label();
            panel14 = new Panel();
            panel13 = new Panel();
            label11 = new Label();
            label10 = new Label();
            label7 = new Label();
            panel12 = new Panel();
            panel11 = new Panel();
            label6 = new Label();
            panel8 = new Panel();
            tbox_start_lotnum = new TextBox();
            btn_start_search = new Button();
            lbl_lot = new Label();
            lbl_start_item = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            panel7.SuspendLayout();
            panel6.SuspendLayout();
            panel5.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picture_Barcode).BeginInit();
            panel3.SuspendLayout();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Dgv_Lot).BeginInit();
            tabPage3.SuspendLayout();
            panel10.SuspendLayout();
            panel9.SuspendLayout();
            panel8.SuspendLayout();
            SuspendLayout();
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
            panel1.Margin = new Padding(2);
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
            btn_ChartForm.Location = new Point(-4, 576);
            btn_ChartForm.Name = "btn_ChartForm";
            btn_ChartForm.Size = new Size(168, 104);
            btn_ChartForm.TabIndex = 13;
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
            btn_OrderForm.Margin = new Padding(2);
            btn_OrderForm.Name = "btn_OrderForm";
            btn_OrderForm.Size = new Size(168, 104);
            btn_OrderForm.TabIndex = 3;
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
            btn_StockForm.Margin = new Padding(2);
            btn_StockForm.Name = "btn_StockForm";
            btn_StockForm.Size = new Size(168, 104);
            btn_StockForm.TabIndex = 3;
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
            btn_TestForm.Margin = new Padding(2);
            btn_TestForm.Name = "btn_TestForm";
            btn_TestForm.Size = new Size(168, 104);
            btn_TestForm.TabIndex = 3;
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
            btn_ProcessForm.Margin = new Padding(2);
            btn_ProcessForm.Name = "btn_ProcessForm";
            btn_ProcessForm.Size = new Size(168, 104);
            btn_ProcessForm.TabIndex = 2;
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
            btn_LOTForm.Margin = new Padding(2);
            btn_LOTForm.Name = "btn_LOTForm";
            btn_LOTForm.Size = new Size(168, 104);
            btn_LOTForm.TabIndex = 1;
            btn_LOTForm.Text = "LOT";
            btn_LOTForm.TextAlign = ContentAlignment.MiddleLeft;
            btn_LOTForm.UseVisualStyleBackColor = true;
            btn_LOTForm.Click += Button_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(52, 152, 219);
            panel2.Controls.Add(label1);
            panel2.Location = new Point(0, 0);
            panel2.Margin = new Padding(2);
            panel2.Name = "panel2";
            panel2.Size = new Size(1270, 80);
            panel2.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("맑은 고딕", 27.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(629, 18);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(92, 50);
            label1.TabIndex = 0;
            label1.Text = "LOT";
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.ItemSize = new Size(200, 40);
            tabControl1.Location = new Point(160, 87);
            tabControl1.Margin = new Padding(2);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1104, 674);
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
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(1096, 626);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Lot 생성";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("맑은 고딕", 28.2F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(24, 3);
            label9.Margin = new Padding(2, 0, 2, 0);
            label9.Name = "label9";
            label9.Size = new Size(225, 51);
            label9.TabIndex = 5;
            label9.Text = "바코드 생성";
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(52, 152, 219);
            button2.FlatAppearance.BorderColor = Color.FromArgb(52, 152, 219);
            button2.FlatAppearance.BorderSize = 2;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("맑은 고딕", 22.2F, FontStyle.Regular, GraphicsUnit.Point);
            button2.Location = new Point(880, 484);
            button2.Margin = new Padding(2);
            button2.Name = "button2";
            button2.Size = new Size(172, 65);
            button2.TabIndex = 5;
            button2.Text = "LOT 생성";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // panel7
            // 
            panel7.BackColor = Color.White;
            panel7.Controls.Add(lbl_text_count);
            panel7.Controls.Add(lbl_count);
            panel7.Controls.Add(label8);
            panel7.Location = new Point(574, 385);
            panel7.Margin = new Padding(2);
            panel7.Name = "panel7";
            panel7.Size = new Size(478, 74);
            panel7.TabIndex = 8;
            // 
            // lbl_text_count
            // 
            lbl_text_count.AutoSize = true;
            lbl_text_count.Font = new Font("맑은 고딕", 22.2F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_text_count.Location = new Point(153, 19);
            lbl_text_count.Margin = new Padding(2, 0, 2, 0);
            lbl_text_count.Name = "lbl_text_count";
            lbl_text_count.Size = new Size(126, 41);
            lbl_text_count.TabIndex = 8;
            lbl_text_count.Text = "제품명: ";
            // 
            // lbl_count
            // 
            lbl_count.AutoSize = true;
            lbl_count.Font = new Font("맑은 고딕", 22.2F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_count.Location = new Point(119, 14);
            lbl_count.Margin = new Padding(2, 0, 2, 0);
            lbl_count.Name = "lbl_count";
            lbl_count.Size = new Size(0, 41);
            lbl_count.TabIndex = 7;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("맑은 고딕", 22.2F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(14, 14);
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
            panel6.Location = new Point(574, 277);
            panel6.Margin = new Padding(2);
            panel6.Name = "panel6";
            panel6.Size = new Size(478, 76);
            panel6.TabIndex = 7;
            // 
            // lbl_barcode
            // 
            lbl_barcode.AutoSize = true;
            lbl_barcode.Font = new Font("맑은 고딕", 22.2F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_barcode.Location = new Point(153, 15);
            lbl_barcode.Margin = new Padding(2, 0, 2, 0);
            lbl_barcode.Name = "lbl_barcode";
            lbl_barcode.Size = new Size(0, 41);
            lbl_barcode.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("맑은 고딕", 22.2F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(4, 15);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(149, 41);
            label4.TabIndex = 5;
            label4.Text = "LOT번호: ";
            // 
            // panel5
            // 
            panel5.BackColor = Color.White;
            panel5.Controls.Add(lbl_text_item);
            panel5.Controls.Add(lbl_count1);
            panel5.Controls.Add(lbl_item);
            panel5.Controls.Add(label3);
            panel5.Location = new Point(574, 166);
            panel5.Margin = new Padding(2);
            panel5.Name = "panel5";
            panel5.Size = new Size(478, 74);
            panel5.TabIndex = 6;
            // 
            // lbl_text_item
            // 
            lbl_text_item.AutoSize = true;
            lbl_text_item.Font = new Font("맑은 고딕", 22.2F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_text_item.Location = new Point(135, 16);
            lbl_text_item.Margin = new Padding(2, 0, 2, 0);
            lbl_text_item.Name = "lbl_text_item";
            lbl_text_item.Size = new Size(126, 41);
            lbl_text_item.TabIndex = 9;
            lbl_text_item.Text = "제품명: ";
            // 
            // lbl_count1
            // 
            lbl_count1.AutoSize = true;
            lbl_count1.Font = new Font("맑은 고딕", 22.2F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_count1.Location = new Point(135, 16);
            lbl_count1.Margin = new Padding(2, 0, 2, 0);
            lbl_count1.Name = "lbl_count1";
            lbl_count1.Size = new Size(0, 41);
            lbl_count1.TabIndex = 7;
            // 
            // lbl_item
            // 
            lbl_item.AutoSize = true;
            lbl_item.Font = new Font("맑은 고딕", 22.2F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_item.Location = new Point(119, 12);
            lbl_item.Margin = new Padding(2, 0, 2, 0);
            lbl_item.Name = "lbl_item";
            lbl_item.Size = new Size(0, 41);
            lbl_item.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("맑은 고딕", 22.2F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(18, 16);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(126, 41);
            label3.TabIndex = 5;
            label3.Text = "제품명: ";
            // 
            // panel4
            // 
            panel4.BackColor = Color.White;
            panel4.Controls.Add(picture_Barcode);
            panel4.Location = new Point(24, 166);
            panel4.Margin = new Padding(2);
            panel4.Name = "panel4";
            panel4.Size = new Size(513, 373);
            panel4.TabIndex = 4;
            // 
            // picture_Barcode
            // 
            picture_Barcode.Location = new Point(12, 12);
            picture_Barcode.Margin = new Padding(2);
            picture_Barcode.Name = "picture_Barcode";
            picture_Barcode.Size = new Size(488, 349);
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
            panel3.Location = new Point(24, 56);
            panel3.Margin = new Padding(2);
            panel3.Name = "panel3";
            panel3.Size = new Size(1028, 84);
            panel3.TabIndex = 2;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(52, 152, 219);
            button1.FlatAppearance.BorderColor = Color.FromArgb(52, 152, 219);
            button1.FlatAppearance.BorderSize = 2;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("맑은 고딕", 22.2F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(856, 16);
            button1.Margin = new Padding(2);
            button1.Name = "button1";
            button1.Size = new Size(121, 52);
            button1.TabIndex = 4;
            button1.Text = "생성";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // lbl_stockname
            // 
            lbl_stockname.AutoSize = true;
            lbl_stockname.Font = new Font("맑은 고딕", 28.2F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_stockname.Location = new Point(28, 17);
            lbl_stockname.Margin = new Padding(2, 0, 2, 0);
            lbl_stockname.Name = "lbl_stockname";
            lbl_stockname.Size = new Size(157, 51);
            lbl_stockname.TabIndex = 0;
            lbl_stockname.Text = "제품명: ";
            // 
            // textBox_count
            // 
            textBox_count.Font = new Font("맑은 고딕", 28.2F, FontStyle.Regular, GraphicsUnit.Point);
            textBox_count.Location = new Point(609, 14);
            textBox_count.Margin = new Padding(2);
            textBox_count.Name = "textBox_count";
            textBox_count.Size = new Size(220, 58);
            textBox_count.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("맑은 고딕", 28.2F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(415, 17);
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
            comboBox_item.Location = new Point(189, 14);
            comboBox_item.Margin = new Padding(2);
            comboBox_item.Name = "comboBox_item";
            comboBox_item.Size = new Size(193, 59);
            comboBox_item.TabIndex = 1;
            comboBox_item.Text = "제품선택";
            // 
            // tabPage2
            // 
            tabPage2.BackColor = Color.LightGray;
            tabPage2.Controls.Add(ComboSearch);
            tabPage2.Controls.Add(button3);
            tabPage2.Controls.Add(txt_text);
            tabPage2.Controls.Add(Dgv_Lot);
            tabPage2.Location = new Point(4, 44);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(1096, 626);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "LOT 검색";
            // 
            // ComboSearch
            // 
            ComboSearch.Font = new Font("맑은 고딕", 24F, FontStyle.Regular, GraphicsUnit.Point);
            ComboSearch.FormattingEnabled = true;
            ComboSearch.Items.AddRange(new object[] { "LOT 바코드", "품명", "전체검색" });
            ComboSearch.Location = new Point(20, 28);
            ComboSearch.Name = "ComboSearch";
            ComboSearch.Size = new Size(198, 53);
            ComboSearch.TabIndex = 13;
            // 
            // button3
            // 
            button3.Location = new Point(921, 87);
            button3.Name = "button3";
            button3.Size = new Size(128, 44);
            button3.TabIndex = 12;
            button3.Text = "검색";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // txt_text
            // 
            txt_text.Font = new Font("맑은 고딕", 24F, FontStyle.Regular, GraphicsUnit.Point);
            txt_text.Location = new Point(224, 31);
            txt_text.Name = "txt_text";
            txt_text.Size = new Size(825, 50);
            txt_text.TabIndex = 8;
            // 
            // Dgv_Lot
            // 
            Dgv_Lot.AllowUserToAddRows = false;
            Dgv_Lot.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            Dgv_Lot.Columns.AddRange(new DataGridViewColumn[] { Lot_Id, Lot_Barcode, Lot_Itemid, Lot_amount, Lot_status, Lot_break, Lot_regdata });
            Dgv_Lot.Location = new Point(20, 148);
            Dgv_Lot.Margin = new Padding(2);
            Dgv_Lot.Name = "Dgv_Lot";
            Dgv_Lot.RowHeadersWidth = 51;
            Dgv_Lot.RowTemplate.Height = 29;
            Dgv_Lot.Size = new Size(1029, 401);
            Dgv_Lot.TabIndex = 0;
            // 
            // Lot_Id
            // 
            Lot_Id.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Lot_Id.HeaderText = "LOT번호";
            Lot_Id.Name = "Lot_Id";
            // 
            // Lot_Barcode
            // 
            Lot_Barcode.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Lot_Barcode.HeaderText = "LOT바코드";
            Lot_Barcode.Name = "Lot_Barcode";
            // 
            // Lot_Itemid
            // 
            Lot_Itemid.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Lot_Itemid.HeaderText = "품명";
            Lot_Itemid.Name = "Lot_Itemid";
            // 
            // Lot_amount
            // 
            Lot_amount.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Lot_amount.HeaderText = "수량";
            Lot_amount.Name = "Lot_amount";
            // 
            // Lot_status
            // 
            Lot_status.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Lot_status.HeaderText = "Lot상태";
            Lot_status.Name = "Lot_status";
            // 
            // Lot_break
            // 
            Lot_break.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Lot_break.HeaderText = "불량";
            Lot_break.Name = "Lot_break";
            // 
            // Lot_regdata
            // 
            Lot_regdata.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Lot_regdata.HeaderText = "생성일자";
            Lot_regdata.Name = "Lot_regdata";
            // 
            // tabPage3
            // 
            tabPage3.AllowDrop = true;
            tabPage3.BackColor = Color.Gainsboro;
            tabPage3.Controls.Add(panel10);
            tabPage3.Controls.Add(panel9);
            tabPage3.Controls.Add(panel8);
            tabPage3.Location = new Point(4, 44);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(1096, 626);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "LOT실행";
            // 
            // panel10
            // 
            panel10.BackColor = Color.White;
            panel10.Controls.Add(lbl_start_check);
            panel10.Controls.Add(lbl_start_status);
            panel10.Controls.Add(panel17);
            panel10.Controls.Add(panel15);
            panel10.Controls.Add(label16);
            panel10.Controls.Add(label15);
            panel10.Controls.Add(btn_Start);
            panel10.Controls.Add(comboBox1);
            panel10.Controls.Add(panel16);
            panel10.Controls.Add(panel18);
            panel10.Controls.Add(label21);
            panel10.Location = new Point(567, 111);
            panel10.Name = "panel10";
            panel10.Size = new Size(488, 379);
            panel10.TabIndex = 11;
            // 
            // lbl_start_check
            // 
            lbl_start_check.AutoSize = true;
            lbl_start_check.Font = new Font("맑은 고딕", 24F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_start_check.Location = new Point(261, 187);
            lbl_start_check.Name = "lbl_start_check";
            lbl_start_check.Size = new Size(91, 45);
            lbl_start_check.TabIndex = 14;
            lbl_start_check.Text = "품명:";
            // 
            // lbl_start_status
            // 
            lbl_start_status.AutoSize = true;
            lbl_start_status.Font = new Font("맑은 고딕", 24F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_start_status.Location = new Point(189, 108);
            lbl_start_status.Name = "lbl_start_status";
            lbl_start_status.Size = new Size(91, 45);
            lbl_start_status.TabIndex = 11;
            lbl_start_status.Text = "품명:";
            // 
            // panel17
            // 
            panel17.BackColor = Color.Black;
            panel17.Location = new Point(15, 245);
            panel17.Name = "panel17";
            panel17.Size = new Size(449, 1);
            panel17.TabIndex = 7;
            // 
            // panel15
            // 
            panel15.BackColor = Color.Black;
            panel15.Location = new Point(15, 334);
            panel15.Name = "panel15";
            panel15.Size = new Size(449, 2);
            panel15.TabIndex = 5;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("맑은 고딕", 24F, FontStyle.Regular, GraphicsUnit.Point);
            label16.Location = new Point(15, 108);
            label16.Name = "label16";
            label16.Size = new Size(177, 45);
            label16.TabIndex = 13;
            label16.Text = "현재 공정 :";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("맑은 고딕", 24F, FontStyle.Regular, GraphicsUnit.Point);
            label15.Location = new Point(15, 187);
            label15.Name = "label15";
            label15.Size = new Size(252, 45);
            label15.TabIndex = 12;
            label15.Text = "공정 실행 가능 :";
            // 
            // btn_Start
            // 
            btn_Start.Location = new Point(388, 289);
            btn_Start.Name = "btn_Start";
            btn_Start.Size = new Size(75, 23);
            btn_Start.TabIndex = 4;
            btn_Start.Text = "실행";
            btn_Start.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            comboBox1.Font = new Font("맑은 고딕", 21.75F, FontStyle.Regular, GraphicsUnit.Point);
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(112, 29);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(352, 48);
            comboBox1.TabIndex = 11;
            // 
            // panel16
            // 
            panel16.BackColor = Color.Black;
            panel16.Location = new Point(15, 169);
            panel16.Name = "panel16";
            panel16.Size = new Size(449, 1);
            panel16.TabIndex = 6;
            // 
            // panel18
            // 
            panel18.BackColor = Color.Black;
            panel18.Location = new Point(15, 91);
            panel18.Name = "panel18";
            panel18.Size = new Size(449, 2);
            panel18.TabIndex = 4;
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Font = new Font("맑은 고딕", 24F, FontStyle.Regular, GraphicsUnit.Point);
            label21.Location = new Point(15, 29);
            label21.Name = "label21";
            label21.Size = new Size(91, 45);
            label21.TabIndex = 3;
            label21.Text = "공정:";
            // 
            // panel9
            // 
            panel9.BackColor = Color.White;
            panel9.Controls.Add(lbl_start_item);
            panel9.Controls.Add(lbl_start_amount);
            panel9.Controls.Add(lbl_start_lotnum);
            panel9.Controls.Add(panel14);
            panel9.Controls.Add(panel13);
            panel9.Controls.Add(label11);
            panel9.Controls.Add(label10);
            panel9.Controls.Add(label7);
            panel9.Controls.Add(panel12);
            panel9.Controls.Add(panel11);
            panel9.Controls.Add(label6);
            panel9.Location = new Point(17, 111);
            panel9.Name = "panel9";
            panel9.Size = new Size(488, 379);
            panel9.TabIndex = 3;
            // 
            // lbl_start_amount
            // 
            lbl_start_amount.AutoSize = true;
            lbl_start_amount.Font = new Font("맑은 고딕", 24F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_start_amount.Location = new Point(112, 277);
            lbl_start_amount.Name = "lbl_start_amount";
            lbl_start_amount.Size = new Size(91, 45);
            lbl_start_amount.TabIndex = 10;
            lbl_start_amount.Text = "품명:";
            // 
            // lbl_start_lotnum
            // 
            lbl_start_lotnum.AutoSize = true;
            lbl_start_lotnum.Font = new Font("맑은 고딕", 24F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_start_lotnum.Location = new Point(180, 108);
            lbl_start_lotnum.Name = "lbl_start_lotnum";
            lbl_start_lotnum.Size = new Size(91, 45);
            lbl_start_lotnum.TabIndex = 8;
            lbl_start_lotnum.Text = "품명:";
            // 
            // panel14
            // 
            panel14.BackColor = Color.Black;
            panel14.Location = new Point(15, 245);
            panel14.Name = "panel14";
            panel14.Size = new Size(449, 1);
            panel14.TabIndex = 7;
            // 
            // panel13
            // 
            panel13.BackColor = Color.Black;
            panel13.Location = new Point(15, 334);
            panel13.Name = "panel13";
            panel13.Size = new Size(449, 1);
            panel13.TabIndex = 6;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("맑은 고딕", 24F, FontStyle.Regular, GraphicsUnit.Point);
            label11.Location = new Point(15, 277);
            label11.Name = "label11";
            label11.Size = new Size(91, 45);
            label11.TabIndex = 7;
            label11.Text = "수량:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("맑은 고딕", 24F, FontStyle.Regular, GraphicsUnit.Point);
            label10.Location = new Point(15, 187);
            label10.Name = "label10";
            label10.Size = new Size(91, 45);
            label10.TabIndex = 6;
            label10.Text = "품명:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("맑은 고딕", 24F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(15, 108);
            label7.Name = "label7";
            label7.Size = new Size(159, 45);
            label7.TabIndex = 3;
            label7.Text = "LOT번호 :";
            // 
            // panel12
            // 
            panel12.BackColor = Color.Black;
            panel12.Location = new Point(15, 169);
            panel12.Name = "panel12";
            panel12.Size = new Size(449, 1);
            panel12.TabIndex = 5;
            // 
            // panel11
            // 
            panel11.BackColor = Color.Black;
            panel11.Location = new Point(15, 91);
            panel11.Name = "panel11";
            panel11.Size = new Size(449, 2);
            panel11.TabIndex = 4;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("맑은 고딕", 36F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(15, 12);
            label6.Name = "label6";
            label6.Size = new Size(227, 65);
            label6.TabIndex = 3;
            label6.Text = "LOT 정보";
            // 
            // panel8
            // 
            panel8.BackColor = Color.White;
            panel8.Controls.Add(tbox_start_lotnum);
            panel8.Controls.Add(btn_start_search);
            panel8.Controls.Add(lbl_lot);
            panel8.Location = new Point(17, 15);
            panel8.Name = "panel8";
            panel8.Size = new Size(1038, 76);
            panel8.TabIndex = 0;
            // 
            // tbox_start_lotnum
            // 
            tbox_start_lotnum.Location = new Point(180, 32);
            tbox_start_lotnum.Name = "tbox_start_lotnum";
            tbox_start_lotnum.Size = new Size(531, 23);
            tbox_start_lotnum.TabIndex = 4;
            // 
            // btn_start_search
            // 
            btn_start_search.Location = new Point(938, 33);
            btn_start_search.Name = "btn_start_search";
            btn_start_search.Size = new Size(75, 23);
            btn_start_search.TabIndex = 3;
            btn_start_search.Text = "button4";
            btn_start_search.UseVisualStyleBackColor = true;
            btn_start_search.Click += btn_start_search_Click;
            // 
            // lbl_lot
            // 
            lbl_lot.AutoSize = true;
            lbl_lot.Font = new Font("맑은 고딕", 24F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_lot.Location = new Point(15, 15);
            lbl_lot.Name = "lbl_lot";
            lbl_lot.Size = new Size(159, 45);
            lbl_lot.TabIndex = 1;
            lbl_lot.Text = "LOT번호 :";
            // 
            // lbl_start_item
            // 
            lbl_start_item.AutoSize = true;
            lbl_start_item.Font = new Font("맑은 고딕", 24F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_start_item.Location = new Point(112, 187);
            lbl_start_item.Name = "lbl_start_item";
            lbl_start_item.Size = new Size(91, 45);
            lbl_start_item.TabIndex = 11;
            lbl_start_item.Text = "품명:";
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
            FormClosed += LOTForm_FormClosed;
            Load += LOTForm_Load;
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
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)Dgv_Lot).EndInit();
            tabPage3.ResumeLayout(false);
            panel10.ResumeLayout(false);
            panel10.PerformLayout();
            panel9.ResumeLayout(false);
            panel9.PerformLayout();
            panel8.ResumeLayout(false);
            panel8.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btn_LOTForm;
        private Panel panel2;
        private Button btn_ProcessForm;
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
        private DataGridView Dgv_Lot;
        private Button btn_Start;
        private Button button6;
        private Button button7;
        private Button button8;
        private Button btn_ChartForm;
        private TextBox txt_text;
        private Button button3;
        private DataGridViewTextBoxColumn Lot_Id;
        private DataGridViewTextBoxColumn Lot_Barcode;
        private DataGridViewTextBoxColumn Lot_Itemid;
        private DataGridViewTextBoxColumn Lot_amount;
        private DataGridViewTextBoxColumn Lot_status;
        private DataGridViewTextBoxColumn Lot_break;
        private DataGridViewTextBoxColumn Lot_regdata;
        private ComboBox ComboSearch;
        private TabPage tabPage3;
        private Panel panel8;
        private Panel panel9;
        private Label lbl_lot;
        private Label label6;
        private Panel panel12;
        private Panel panel11;
        private Label label11;
        private Label label10;
        private Label label7;
        private Panel panel14;
        private Panel panel13;
        private Panel panel10;
        private ComboBox comboBox1;
        private Panel panel16;
        private Label label19;
        private Label label20;
        private Panel panel18;
        private Label label21;
        private Label lbl_start_amount;
        private Label label13;
        private Label lbl_start_lotnum;
        private Label lbl_start_check;
        private Label lbl_start_status;
        private Panel panel17;
        private Panel panel15;
        private Label label16;
        private Label label15;
        private Button btn_start_search;
        private TextBox tbox_start_lotnum;
        private Label lbl_start_item;
    }
}