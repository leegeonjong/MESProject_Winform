using FinalProject_Winform.Data;
using FinalProject_Winform.Models.domain;

namespace FinalProject_Winform
{
    public partial class LoginForm : Form
    {
        private readonly FinalDbContext db;
        TextBox idbox;
        TextBox pwbox;
        public LoginForm()
        {
            InitializeComponent();
            idbox = textBox1;
            pwbox = textBox2;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var b = Login(idbox.Text);
            MessageBox.Show(b.PUser_id);
        }

        private User Login(string id)
        {
            var a = db.Users.Find(id);
            return a;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}