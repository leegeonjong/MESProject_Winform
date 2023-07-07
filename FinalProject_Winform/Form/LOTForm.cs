using BarcodeStandard;
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
        public LOTForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e) //지우면 날라감
        {

        }

        private void label3_Click(object sender, EventArgs e) //지우면 날라감
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox_item.Text == "제품선택" || textBox_count.Text.IsNullOrEmpty())
            {
                MessageBox.Show("제품과 수량을 입력해주세요");
            }
            else
            {
                lbl_item.Text = comboBox_item.Text;
                lbl_count.Text = textBox_count.Text;
            }

                string barcodeText = lbl_barcode.Text.Trim();
                if (string.IsNullOrEmpty(barcodeText)) { return; }

                Barcode barcode = new();

                SKImage img = barcode.Encode(
                    BarcodeStandard.Type.Ean13   // Barcode type
                    , barcodeText                // 변환할 텍스트
                    , new SKColor(0, 0, 0)       // fore color (바코드 색상) r,g,b
                    , new SKColor(0, 0, 0, 0)   // back color (배경 색상)  r,g,b,a
                    , (int)(picture_Barcode.Width * 0.8)   // width
                    , (int)(picture_Barcode.Height * 0.8) // height
                    );

                picture_Barcode.Image = Image.FromStream(img.Encode().AsStream());
            
        }

        private void btn_process_Click(object sender, EventArgs e)
        {
            var ProcessForm = Application.OpenForms["ProcessForm"] as ProcessForm;

            if (ProcessForm == null)
            {
                ProcessForm = new ProcessForm();
                ProcessForm.Show();
            }
            this.Close();
        }


        private void btn_check_Click(object sender, EventArgs e)
        {
            var TestForm = Application.OpenForms["TestForm"] as TestForm;

            if (TestForm == null)
            {
                TestForm = new TestForm();
                TestForm.Show();
            }
            this.Hide();
        }

        private void btn_stock_Click(object sender, EventArgs e)
        {
            var StockForm = Application.OpenForms["StockForm"] as StockForm;

            if (StockForm == null)
            {
                StockForm = new StockForm();
                StockForm.Show();
            }
            this.Hide();
        }

        private void btn_order_Click(object sender, EventArgs e)
        {
            var OrderForm = Application.OpenForms["OrderForm"] as OrderForm;

            if (OrderForm == null)
            {
                OrderForm = new OrderForm();
                OrderForm.Show();
            }
            this.Hide();
        }
        //닫으면 모든 폼 닫기 
        private void LOTForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            foreach (Form form in Application.OpenForms)
            {
                if (form != this)
                {
                    form.Close();
                }
            }
        }

        private void btn_chart_Click(object sender, EventArgs e)
        {
            var ChartForm = Application.OpenForms["ChartForm"] as ChartForm;

            if (ChartForm == null)
            {
                ChartForm = new ChartForm();
                ChartForm.Show();
            }
            this.Hide();
        }
    }
}
