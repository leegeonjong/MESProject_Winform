using FinalProject_Winform.Data;
using FinalProject_Winform.Models.domain;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProject_Winform
{
    public partial class AddUserForm : Form
    {
        private readonly FinalDbContext db;
        TextBox idbox;
        TextBox pwbox;
        TextBox namebox;
        TextBox phonenumbox;
        public AddUserForm()
        {
            InitializeComponent();
            idbox = textBox1;
            pwbox = textBox2;
            namebox = textBox3;
            phonenumbox = textBox4;
            db = new FinalDbContext();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            User user = new()
            {
                PUser_id = idbox.Text.Trim(),
                PUser_password = pwbox.Text.Trim(),
                PUser_name = namebox.Text.Trim(),
                PUser_phoneNum = phonenumbox.Text.Trim(),
            };
            var check = db.Users.FirstOrDefault(x => x.PUser_id == idbox.Text);
            if (check != null)
            {
                MessageBox.Show("입력하신 정보의 아이디가 있습니다.\n다른 아이디를 입력해주세요.");
                idbox.Focus();
            }
            else
            {
                await db.Users.AddAsync(user);
                await db.SaveChangesAsync();
                MessageBox.Show("회원가입 성공");
                this.Close();
            }

        }
    }
}
//
