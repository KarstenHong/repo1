using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChineseNewYear_CHW_38
{
    public partial class Form1_HomePage : Form
    {
        public Form1_HomePage()
        {
            InitializeComponent();
        }
        private void Form1_HomePage_Load(object sender, EventArgs e)
        {
            btnOrder.Enabled = false;
        }

        private void btnDishes_Click(object sender, EventArgs e)
        {
            Form3_Dishes Dishes = new Form3_Dishes();
            btnOrder.Enabled = true;
            Dishes.ShowDialog();
            
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            Form2_Order Order = new Form2_Order();
            Order.ShowDialog();
        }

        
    }
}
