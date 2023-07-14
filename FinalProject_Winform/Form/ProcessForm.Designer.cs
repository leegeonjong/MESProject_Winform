namespace FinalProject_Winform
{
    partial class ProcessForm
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
            tabPage1 = new TabPage();
            panel4 = new Panel();
            label3 = new Label();
            btn_next = new Button();
            btn_prev = new Button();
            dataGridView1 = new DataGridView();
            panel3 = new Panel();
            btnSearchProcess = new Button();
            label2 = new Label();
            ProcessSearch = new TextBox();
            tabPage2 = new TabPage();
            panel5 = new Panel();
            btnOff = new Button();
            combo_process = new ComboBox();
            panel7 = new Panel();
            label6 = new Label();
            label4 = new Label();
            btnOn = new Button();
            panel6 = new Panel();
            label5 = new Label();
            LOT_ID = new DataGridViewTextBoxColumn();
            LOT_NAME = new DataGridViewTextBoxColumn();
            LOT_StartDate = new DataGridViewTextBoxColumn();
            LOT_STATUS = new DataGridViewTextBoxColumn();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel3.SuspendLayout();
            tabPage2.SuspendLayout();
            panel5.SuspendLayout();
            panel7.SuspendLayout();
            panel6.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(52, 152, 219);
            panel2.Controls.Add(label1);
            panel2.Location = new Point(-3, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1267, 88);
            panel2.TabIndex = 3;
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
            panel1.TabIndex = 2;
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
            tabControl1.TabIndex = 4;
            tabControl1.Selected += tabControl1_Selected;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(panel4);
            tabPage1.Location = new Point(4, 44);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(1096, 623);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "    공정조회    ";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            panel4.BackColor = Color.Silver;
            panel4.Controls.Add(label3);
            panel4.Controls.Add(btn_next);
            panel4.Controls.Add(btn_prev);
            panel4.Controls.Add(dataGridView1);
            panel4.Controls.Add(panel3);
            panel4.Dock = DockStyle.Fill;
            panel4.Location = new Point(3, 3);
            panel4.Name = "panel4";
            panel4.Size = new Size(1090, 617);
            panel4.TabIndex = 8;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("맑은 고딕", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(522, 568);
            label3.Name = "label3";
            label3.Size = new Size(28, 32);
            label3.TabIndex = 9;
            label3.Text = "1";
            // 
            // btn_next
            // 
            btn_next.Location = new Point(574, 568);
            btn_next.Name = "btn_next";
            btn_next.Size = new Size(75, 37);
            btn_next.TabIndex = 10;
            btn_next.Text = ">";
            btn_next.UseVisualStyleBackColor = true;
            // 
            // btn_prev
            // 
            btn_prev.Location = new Point(429, 568);
            btn_prev.Name = "btn_prev";
            btn_prev.Size = new Size(75, 37);
            btn_prev.TabIndex = 9;
            btn_prev.Text = "<";
            btn_prev.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { LOT_ID, LOT_NAME, LOT_StartDate, LOT_STATUS });
            dataGridView1.Location = new Point(28, 122);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(1037, 431);
            dataGridView1.TabIndex = 8;
            // 
            // panel3
            // 
            panel3.BackColor = Color.WhiteSmoke;
            panel3.Controls.Add(btnSearchProcess);
            panel3.Controls.Add(label2);
            panel3.Controls.Add(ProcessSearch);
            panel3.Location = new Point(28, 24);
            panel3.Name = "panel3";
            panel3.Size = new Size(1037, 82);
            panel3.TabIndex = 7;
            // 
            // btnSearchProcess
            // 
            btnSearchProcess.BackColor = Color.FromArgb(52, 152, 219);
            btnSearchProcess.Location = new Point(776, 15);
            btnSearchProcess.Name = "btnSearchProcess";
            btnSearchProcess.Size = new Size(126, 52);
            btnSearchProcess.TabIndex = 8;
            btnSearchProcess.Text = "검색";
            btnSearchProcess.UseVisualStyleBackColor = false;
            btnSearchProcess.Click += btnSearchProcess_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("맑은 고딕", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(86, 26);
            label2.Name = "label2";
            label2.Size = new Size(148, 32);
            label2.TabIndex = 6;
            label2.Text = "공정 검색  : ";
            // 
            // ProcessSearch
            // 
            ProcessSearch.Font = new Font("맑은 고딕", 18F, FontStyle.Regular, GraphicsUnit.Point);
            ProcessSearch.Location = new Point(240, 26);
            ProcessSearch.Multiline = true;
            ProcessSearch.Name = "ProcessSearch";
            ProcessSearch.Size = new Size(484, 32);
            ProcessSearch.TabIndex = 5;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(panel5);
            tabPage2.Location = new Point(4, 44);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(1096, 623);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "    설비설정    ";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // panel5
            // 
            panel5.BackColor = Color.Silver;
            panel5.Controls.Add(btnOff);
            panel5.Controls.Add(combo_process);
            panel5.Controls.Add(panel7);
            panel5.Controls.Add(btnOn);
            panel5.Controls.Add(panel6);
            panel5.Dock = DockStyle.Fill;
            panel5.Location = new Point(3, 3);
            panel5.Name = "panel5";
            panel5.Size = new Size(1090, 617);
            panel5.TabIndex = 9;
            // 
            // btnOff
            // 
            btnOff.BackColor = Color.Red;
            btnOff.Location = new Point(592, 343);
            btnOff.Name = "btnOff";
            btnOff.Size = new Size(366, 147);
            btnOff.TabIndex = 10;
            btnOff.Text = "OFF";
            btnOff.UseVisualStyleBackColor = false;
            btnOff.Click += btnOff_Click;
            // 
            // combo_process
            // 
            combo_process.Font = new Font("맑은 고딕", 18F, FontStyle.Regular, GraphicsUnit.Point);
            combo_process.FormattingEnabled = true;
            combo_process.Items.AddRange(new object[] { "Mix", "Shape", "Steam", "Fry", "Freeze", "Pack" });
            combo_process.Location = new Point(28, 229);
            combo_process.Name = "combo_process";
            combo_process.Size = new Size(1037, 40);
            combo_process.TabIndex = 9;
            combo_process.SelectedIndexChanged += combo_process_SelectedIndexChanged;
            // 
            // panel7
            // 
            panel7.BackColor = Color.WhiteSmoke;
            panel7.Controls.Add(label6);
            panel7.Controls.Add(label4);
            panel7.Location = new Point(28, 134);
            panel7.Name = "panel7";
            panel7.Size = new Size(1037, 49);
            panel7.TabIndex = 8;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("맑은 고딕", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(155, 17);
            label6.Name = "label6";
            label6.Size = new Size(0, 21);
            label6.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("맑은 고딕", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(15, 17);
            label4.Name = "label4";
            label4.Size = new Size(118, 21);
            label4.TabIndex = 6;
            label4.Text = "설비 진행 상황";
            // 
            // btnOn
            // 
            btnOn.BackColor = Color.Lime;
            btnOn.Location = new Point(82, 343);
            btnOn.Name = "btnOn";
            btnOn.Size = new Size(366, 147);
            btnOn.TabIndex = 8;
            btnOn.Text = "ON";
            btnOn.UseVisualStyleBackColor = false;
            btnOn.Click += btnOn_Click;
            // 
            // panel6
            // 
            panel6.BackColor = Color.WhiteSmoke;
            panel6.Controls.Add(label5);
            panel6.Location = new Point(28, 24);
            panel6.Name = "panel6";
            panel6.Size = new Size(1037, 82);
            panel6.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("맑은 고딕", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(16, 23);
            label5.Name = "label5";
            label5.Size = new Size(174, 32);
            label5.TabIndex = 6;
            label5.Text = "설비 상태 설정";
            // 
            // LOT_ID
            // 
            LOT_ID.HeaderText = "LOT";
            LOT_ID.Name = "LOT_ID";
            LOT_ID.ReadOnly = true;
            // 
            // LOT_NAME
            // 
            LOT_NAME.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            LOT_NAME.HeaderText = "이름";
            LOT_NAME.Name = "LOT_NAME";
            LOT_NAME.ReadOnly = true;
            // 
            // LOT_StartDate
            // 
            LOT_StartDate.HeaderText = "시작시간";
            LOT_StartDate.Name = "LOT_StartDate";
            LOT_StartDate.ReadOnly = true;
            LOT_StartDate.Width = 300;
            // 
            // LOT_STATUS
            // 
            LOT_STATUS.HeaderText = "상태";
            LOT_STATUS.Name = "LOT_STATUS";
            LOT_STATUS.ReadOnly = true;
            LOT_STATUS.Width = 300;
            // 
            // ProcessForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1264, 761);
            Controls.Add(tabControl1);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "ProcessForm";
            Text = "ProcessForm";
            FormClosed += ProcessForm_FormClosed;
            Load += ProcessForm_Load;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            tabPage2.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel2;
        private Label label1;
        private Panel panel1;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TextBox ProcessSearch;
        private Label label2;
        private Panel panel3;
        private Panel panel4;
        private Button btnSearchProcess;
        private DataGridView dataGridView1;
        private Button btn_next;
        private Button btn_prev;
        private Label label3;
        private Panel panel5;
        private Panel panel6;
        private Button btnOn;
        private Label label5;
        private Panel panel7;
        private Label label4;
        private Label label6;
        private ComboBox combo_process;
        private Button btn_ChartForm;
        private Button btn_OrderForm;
        private Button btn_StockForm;
        private Button btn_TestForm;
        private Button btn_ProcessForm;
        private Button btn_LOTForm;
        private Button btnOff;
        private DataGridViewTextBoxColumn LOT_ID;
        private DataGridViewTextBoxColumn LOT_NAME;
        private DataGridViewTextBoxColumn LOT_StartDate;
        private DataGridViewTextBoxColumn LOT_STATUS;
    }
}