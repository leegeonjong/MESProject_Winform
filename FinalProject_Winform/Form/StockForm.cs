using FinalProject_Winform.Repositories;
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
    public partial class StockForm : Form
    {
        private IItemRepository itemRepository;
        public StockForm()
        {
            InitializeComponent();

          
            comboBox1.DataSource = items;
            comboBox1.DisplayMember = "Name";
            comboBox1.ValueMember = "Id";
        }


    }
}
