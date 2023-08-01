namespace FinalProject_Winform
{
    partial class AddUserForm
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
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            label3 = new Label();
            label2 = new Label();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            label1 = new Label();
            label4 = new Label();
            panel1 = new Panel();
            label5 = new Label();
            btnJoin = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // textBox2
            // 
            textBox2.Location = new Point(117, 115);
            textBox2.Name = "textBox2";
            textBox2.PasswordChar = '●';
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 8;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(117, 86);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("맑은 고딕", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(73, 113);
            label3.Name = "label3";
            label3.Size = new Size(38, 21);
            label3.TabIndex = 6;
            label3.Text = "PW:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("맑은 고딕", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(82, 86);
            label2.Name = "label2";
            label2.Size = new Size(29, 21);
            label2.TabIndex = 5;
            label2.Text = "ID:";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(117, 144);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(100, 23);
            textBox3.TabIndex = 9;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(117, 176);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(100, 23);
            textBox4.TabIndex = 10;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("맑은 고딕", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(16, 174);
            label1.Name = "label1";
            label1.Size = new Size(95, 21);
            label1.TabIndex = 10;
            label1.Text = "PhoneNum:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("맑은 고딕", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(54, 142);
            label4.Name = "label4";
            label4.Size = new Size(57, 21);
            label4.TabIndex = 9;
            label4.Text = "Name:";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(108, 160, 220);
            panel1.Controls.Add(label5);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(266, 70);
            panel1.TabIndex = 16;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("맑은 고딕", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.White;
            label5.Location = new Point(82, 20);
            label5.Name = "label5";
            label5.Size = new Size(97, 30);
            label5.TabIndex = 0;
            label5.Text = "회원가입";
            // 
            // btnJoin
            // 
            btnJoin.BackColor = Color.FromArgb(108, 160, 220);
            btnJoin.FlatStyle = FlatStyle.Flat;
            btnJoin.Font = new Font("맑은 고딕", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnJoin.ForeColor = Color.White;
            btnJoin.Location = new Point(82, 228);
            btnJoin.Name = "btnJoin";
            btnJoin.Size = new Size(111, 37);
            btnJoin.TabIndex = 17;
            btnJoin.Text = "가입하기";
            btnJoin.UseVisualStyleBackColor = false;
            btnJoin.Click += button1_Click;
            // 
            // AddUserForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(266, 316);
            Controls.Add(btnJoin);
            Controls.Add(panel1);
            Controls.Add(textBox3);
            Controls.Add(textBox4);
            Controls.Add(label1);
            Controls.Add(label4);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Name = "AddUserForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AddUserForm";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox2;
        private TextBox textBox1;
        private Label label3;
        private Label label2;
        private TextBox textBox3;
        private TextBox textBox4;
        private Label label1;
        private Label label4;
        private Panel panel1;
        private Label label5;
        private Button btnJoin;
    }
}