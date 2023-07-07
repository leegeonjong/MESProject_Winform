using BarcodeStandard;
using FinalProject_Winform.Repositories;
using Microsoft.IdentityModel.Tokens;
using SkiaSharp;
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
    public partial class LOTForm : Form
    {
        private ILotRepository lotRepository;
        public LOTForm()
        {
            InitializeComponent();
            lotRepository = new LotRepository();
        }
        //



        private void button1_Click(object sender, EventArgs e)
        {

            if (comboBox_item.Text == "제품선택" || textBox_count.Text.IsNullOrEmpty())
            {
                MessageBox.Show("제품과 수량을 입력해주세요");
            }
            else
            {
                string bartext = makebarcode();
                while (true)
                {
                    bool result = lotRepository.FindAsync(bartext);
                    if (result)
                    {
                        break;
                    }
                }
                lbl_barcode.Text = bartext;
                lbl_text_item.Text = comboBox_item.Text;
                lbl_text_count.Text = textBox_count.Text;

            }


            string barcodeText = lbl_barcode.Text.Trim();
            if (string.IsNullOrEmpty(barcodeText)) { return; }

            Barcode barcode = new();

            SKImage img = barcode.Encode(
                BarcodeStandard.Type.Ean13   // Barcode type
                , barcodeText                // 변환할 텍스트
                , new SKColor(0, 0, 0)       // fore color (바코드 색상) r,g,b
                , new SKColor(0, 0, 0, 0)   // back color (배경 색상)  r,g,b,a
                , (int)(picture_Barcode.Width)   // width
                , (int)(picture_Barcode.Height) // height
                );

            picture_Barcode.Image = Image.FromStream(img.Encode().AsStream());
            ////

        }

        private string makebarcode()
        {
            const int length = 12;
            const string chars = "0123456789";
            StringBuilder sb = new StringBuilder(length);
            Random random = new Random();

            for (int i = 0; i < length; i++)
            {
                int index = random.Next(chars.Length);
                sb.Append(chars[index]);
            }

            return sb.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            lotRepository.AddLotAsync(lbl_text_item.Text, lbl_barcode.Text, int.Parse(lbl_text_count.Text));
            MessageBox.Show("Lot이 생성되었습니다");
        }

        private void Button_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;
            if (button != null)
            {
                string formName = button.Name.Replace("btn_", "");
                FormUtility.OpenForm(formName, this);
            }
        }

        //메인폼으로 돌아가기
        private void LOTForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            var MainForm = Application.OpenForms["MainForm"] as MainForm;

            if (MainForm != null)
            {
                MainForm = new MainForm();
                MainForm.Show();
            }
            this.Hide();
        }
    }
}
