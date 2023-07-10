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
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_ChartForm = new System.Windows.Forms.Button();
            this.btn_OrderForm = new System.Windows.Forms.Button();
            this.btn_StockForm = new System.Windows.Forms.Button();
            this.btn_TestForm = new System.Windows.Forms.Button();
            this.btn_ProcessForm = new System.Windows.Forms.Button();
            this.btn_LOTForm = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_next = new System.Windows.Forms.Button();
            this.btn_prev = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnSearchProcess = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.panel5 = new System.Windows.Forms.Panel();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.combo_process = new System.Windows.Forms.ComboBox();
            this.panel7 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.LOT_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Process_Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LOT_StartDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LOT_EndDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel3.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(-3, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1267, 88);
            this.panel2.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("맑은 고딕", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(550, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 50);
            this.label1.TabIndex = 0;
            this.label1.Text = "아무거나";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(210)))), ((int)(((byte)(230)))));
            this.panel1.Controls.Add(this.btn_ChartForm);
            this.panel1.Controls.Add(this.btn_OrderForm);
            this.panel1.Controls.Add(this.btn_StockForm);
            this.panel1.Controls.Add(this.btn_TestForm);
            this.panel1.Controls.Add(this.btn_ProcessForm);
            this.panel1.Controls.Add(this.btn_LOTForm);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(160, 761);
            this.panel1.TabIndex = 2;
            // 
            // btn_ChartForm
            // 
            this.btn_ChartForm.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btn_ChartForm.FlatAppearance.BorderSize = 2;
            this.btn_ChartForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ChartForm.Font = new System.Drawing.Font("맑은 고딕", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_ChartForm.Location = new System.Drawing.Point(-4, 580);
            this.btn_ChartForm.Name = "btn_ChartForm";
            this.btn_ChartForm.Size = new System.Drawing.Size(168, 104);
            this.btn_ChartForm.TabIndex = 12;
            this.btn_ChartForm.Text = "현황판";
            this.btn_ChartForm.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_ChartForm.UseVisualStyleBackColor = true;
            // 
            // btn_OrderForm
            // 
            this.btn_OrderForm.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btn_OrderForm.FlatAppearance.BorderSize = 2;
            this.btn_OrderForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_OrderForm.Font = new System.Drawing.Font("맑은 고딕", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_OrderForm.Location = new System.Drawing.Point(-4, 480);
            this.btn_OrderForm.Name = "btn_OrderForm";
            this.btn_OrderForm.Size = new System.Drawing.Size(168, 104);
            this.btn_OrderForm.TabIndex = 13;
            this.btn_OrderForm.Text = "주문";
            this.btn_OrderForm.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_OrderForm.UseVisualStyleBackColor = true;
            // 
            // btn_StockForm
            // 
            this.btn_StockForm.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btn_StockForm.FlatAppearance.BorderSize = 2;
            this.btn_StockForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_StockForm.Font = new System.Drawing.Font("맑은 고딕", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_StockForm.Location = new System.Drawing.Point(-4, 380);
            this.btn_StockForm.Name = "btn_StockForm";
            this.btn_StockForm.Size = new System.Drawing.Size(168, 104);
            this.btn_StockForm.TabIndex = 14;
            this.btn_StockForm.Text = "재고관리";
            this.btn_StockForm.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_StockForm.UseVisualStyleBackColor = true;
            // 
            // btn_TestForm
            // 
            this.btn_TestForm.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btn_TestForm.FlatAppearance.BorderSize = 2;
            this.btn_TestForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_TestForm.Font = new System.Drawing.Font("맑은 고딕", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_TestForm.Location = new System.Drawing.Point(-4, 279);
            this.btn_TestForm.Name = "btn_TestForm";
            this.btn_TestForm.Size = new System.Drawing.Size(168, 104);
            this.btn_TestForm.TabIndex = 15;
            this.btn_TestForm.Text = "검사";
            this.btn_TestForm.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_TestForm.UseVisualStyleBackColor = true;
            // 
            // btn_ProcessForm
            // 
            this.btn_ProcessForm.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btn_ProcessForm.FlatAppearance.BorderSize = 2;
            this.btn_ProcessForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ProcessForm.Font = new System.Drawing.Font("맑은 고딕", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_ProcessForm.Location = new System.Drawing.Point(-4, 178);
            this.btn_ProcessForm.Name = "btn_ProcessForm";
            this.btn_ProcessForm.Size = new System.Drawing.Size(168, 104);
            this.btn_ProcessForm.TabIndex = 11;
            this.btn_ProcessForm.Text = "공정";
            this.btn_ProcessForm.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_ProcessForm.UseVisualStyleBackColor = true;
            // 
            // btn_LOTForm
            // 
            this.btn_LOTForm.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btn_LOTForm.FlatAppearance.BorderSize = 2;
            this.btn_LOTForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_LOTForm.Font = new System.Drawing.Font("맑은 고딕", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_LOTForm.Location = new System.Drawing.Point(-4, 77);
            this.btn_LOTForm.Name = "btn_LOTForm";
            this.btn_LOTForm.Size = new System.Drawing.Size(168, 104);
            this.btn_LOTForm.TabIndex = 10;
            this.btn_LOTForm.Text = "LOT";
            this.btn_LOTForm.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_LOTForm.UseVisualStyleBackColor = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tabControl1.ItemSize = new System.Drawing.Size(200, 40);
            this.tabControl1.Location = new System.Drawing.Point(160, 90);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1104, 671);
            this.tabControl1.TabIndex = 4;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.panel4);
            this.tabPage1.Location = new System.Drawing.Point(4, 44);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1096, 623);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "    공정조회    ";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Silver;
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.btn_next);
            this.panel4.Controls.Add(this.btn_prev);
            this.panel4.Controls.Add(this.dataGridView1);
            this.panel4.Controls.Add(this.panel3);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(3, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1090, 617);
            this.panel4.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("맑은 고딕", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(522, 568);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 32);
            this.label3.TabIndex = 9;
            this.label3.Text = "1";
            // 
            // btn_next
            // 
            this.btn_next.Location = new System.Drawing.Point(574, 568);
            this.btn_next.Name = "btn_next";
            this.btn_next.Size = new System.Drawing.Size(75, 37);
            this.btn_next.TabIndex = 10;
            this.btn_next.Text = ">";
            this.btn_next.UseVisualStyleBackColor = true;
            // 
            // btn_prev
            // 
            this.btn_prev.Location = new System.Drawing.Point(429, 568);
            this.btn_prev.Name = "btn_prev";
            this.btn_prev.Size = new System.Drawing.Size(75, 37);
            this.btn_prev.TabIndex = 9;
            this.btn_prev.Text = "<";
            this.btn_prev.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.LOT_ID,
            this.Process_Status,
            this.LOT_StartDate,
            this.LOT_EndDate});
            this.dataGridView1.Location = new System.Drawing.Point(28, 122);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(1037, 431);
            this.dataGridView1.TabIndex = 8;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel3.Controls.Add(this.btnSearchProcess);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.textBox1);
            this.panel3.Location = new System.Drawing.Point(28, 24);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1037, 82);
            this.panel3.TabIndex = 7;
            // 
            // btnSearchProcess
            // 
            this.btnSearchProcess.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.btnSearchProcess.Location = new System.Drawing.Point(776, 15);
            this.btnSearchProcess.Name = "btnSearchProcess";
            this.btnSearchProcess.Size = new System.Drawing.Size(126, 52);
            this.btnSearchProcess.TabIndex = 8;
            this.btnSearchProcess.Text = "검색";
            this.btnSearchProcess.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("맑은 고딕", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(86, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(148, 32);
            this.label2.TabIndex = 6;
            this.label2.Text = "공정 검색  : ";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("맑은 고딕", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox1.Location = new System.Drawing.Point(240, 26);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(484, 32);
            this.textBox1.TabIndex = 5;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.panel5);
            this.tabPage2.Location = new System.Drawing.Point(4, 44);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1096, 623);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "    설비설정    ";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Silver;
            this.panel5.Controls.Add(this.comboBox2);
            this.panel5.Controls.Add(this.combo_process);
            this.panel5.Controls.Add(this.panel7);
            this.panel5.Controls.Add(this.button3);
            this.panel5.Controls.Add(this.panel6);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(3, 3);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1090, 617);
            this.panel5.TabIndex = 9;
            // 
            // comboBox2
            // 
            this.comboBox2.Font = new System.Drawing.Font("맑은 고딕", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(565, 229);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(500, 40);
            this.comboBox2.TabIndex = 10;
            // 
            // combo_process
            // 
            this.combo_process.Font = new System.Drawing.Font("맑은 고딕", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.combo_process.FormattingEnabled = true;
            this.combo_process.Location = new System.Drawing.Point(28, 229);
            this.combo_process.Name = "combo_process";
            this.combo_process.Size = new System.Drawing.Size(500, 40);
            this.combo_process.TabIndex = 9;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel7.Controls.Add(this.label6);
            this.panel7.Controls.Add(this.label4);
            this.panel7.Location = new System.Drawing.Point(28, 134);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(1037, 49);
            this.panel7.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(155, 17);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(118, 21);
            this.label6.TabIndex = 7;
            this.label6.Text = "설비 진행 상황";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(15, 17);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 21);
            this.label4.TabIndex = 6;
            this.label4.Text = "설비 진행 상황";
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.button3.Location = new System.Drawing.Point(939, 517);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(126, 52);
            this.button3.TabIndex = 8;
            this.button3.Text = "검색";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel6.Controls.Add(this.label5);
            this.panel6.Location = new System.Drawing.Point(28, 24);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(1037, 82);
            this.panel6.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("맑은 고딕", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(16, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(174, 32);
            this.label5.TabIndex = 6;
            this.label5.Text = "설비 상태 설정";
            // 
            // LOT_ID
            // 
            this.LOT_ID.HeaderText = "LOT";
            this.LOT_ID.Name = "LOT_ID";
            this.LOT_ID.ReadOnly = true;
            // 
            // Process_Status
            // 
            this.Process_Status.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Process_Status.HeaderText = "상태";
            this.Process_Status.Name = "Process_Status";
            this.Process_Status.ReadOnly = true;
            // 
            // LOT_StartDate
            // 
            this.LOT_StartDate.HeaderText = "시작시간";
            this.LOT_StartDate.Name = "LOT_StartDate";
            this.LOT_StartDate.ReadOnly = true;
            this.LOT_StartDate.Width = 300;
            // 
            // LOT_EndDate
            // 
            this.LOT_EndDate.HeaderText = "종료시간";
            this.LOT_EndDate.Name = "LOT_EndDate";
            this.LOT_EndDate.ReadOnly = true;
            this.LOT_EndDate.Width = 300;
            // 
            // ProcessForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 761);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "ProcessForm";
            this.Text = "ProcessForm";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel2;
        private Label label1;
        private Panel panel1;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TextBox textBox1;
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
        private Button button3;
        private Label label5;
        private Panel panel7;
        private Label label4;
        private Label label6;
        private ComboBox comboBox2;
        private ComboBox combo_process;
        private Button btn_ChartForm;
        private Button btn_OrderForm;
        private Button btn_StockForm;
        private Button btn_TestForm;
        private Button btn_ProcessForm;
        private Button btn_LOTForm;
        private DataGridViewTextBoxColumn LOT_ID;
        private DataGridViewTextBoxColumn Process_Status;
        private DataGridViewTextBoxColumn LOT_StartDate;
        private DataGridViewTextBoxColumn LOT_EndDate;
    }
}