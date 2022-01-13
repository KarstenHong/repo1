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
    public partial class Form4_POS : Form
    {
        public Form4_POS()
        {
            InitializeComponent();
        }        
        private void Form4_POS_Load(object sender, EventArgs e)
        {
            msbox1 = "";
            msbox2 = "";
            msbox3 = "";
            msbox4 = "";
            msbox5 = "";
            msbox6 = "";
            msbox7 = "";
            msbox8 = "";
            msbox9 = "";
            msbox10 = "";
            msbox11 = "";
            Count.Dishes1Count = 0;
            Count.Dishes2Count = 0;
            Count.Dishes3Count = 0;
            Count.Dishes4Count = 0;
            Count.Dishes5Count = 0;
            Count.Dishes6Count = 0;
            Count.Dishes7Count = 0;
            Count.Dishes8Count = 0;
            Count.Dishes9Count = 0;
            Count.Dishes10Count = 0;
            Count.Dishes11Count = 0;
            labTitle.Text = msbox1 + msbox2 + msbox3 + msbox4 + msbox5 + msbox6 + msbox7 + msbox8 + msbox9 + msbox10 + msbox11;
            txtTotal.Text = "NT$ 0";
        }
        class Count
        {
            public static int Dishes1Count = 0;
            public static int Dishes2Count = 0;
            public static int Dishes3Count = 0;
            public static int Dishes4Count = 0;
            public static int Dishes5Count = 0;
            public static int Dishes6Count = 0;
            public static int Dishes7Count = 0;
            public static int Dishes8Count = 0;
            public static int Dishes9Count = 0;
            public static int Dishes10Count = 0;
            public static int Dishes11Count = 0;
        }
        class Price
        {
            public static double Dishes1Price = 580;
            public static double Dishes2Price = 360;
            public static double Dishes3Price = 470;
            public static double Dishes4Price = 600;
            public static double Dishes5Price = 780;
            public static double Dishes6Price = 450;
            public static double Dishes7Price = 300;
            public static double Dishes8Price = 260;
            public static double Dishes9Price = 280;
            public static double Dishes10Price = 200;
            public static double Dishes11Price = 120;
        }
        double TotalPrice;
        string msbox1 = "";
        string msbox2 = "";
        string msbox3 = "";
        string msbox4 = "";
        string msbox5 = "";
        string msbox6 = "";
        string msbox7 = "";
        string msbox8 = "";
        string msbox9 = "";
        string msbox10 = "";
        string msbox11 = "";

        private void btnChicken_Click(object sender, EventArgs e)
        {
            if (msbox1 == "")
            {
                Count.Dishes1Count++;
                double totalPrice = Count.Dishes1Count * Price.Dishes1Price;
                msbox1 = msbox1 + "甘蔗香燻雞 x" + Count.Dishes1Count + ",共NT$" + totalPrice + "元" + Environment.NewLine;
                labTitle.Text = msbox1 + msbox2 + msbox3 + msbox4 + msbox5 + msbox6 + msbox7 + msbox8 + msbox9 + msbox10 + msbox11;
            }
            else
            {
                Count.Dishes1Count += 1;
                double totalPrice = Count.Dishes1Count * Price.Dishes1Price;
                msbox1 = "甘蔗香燻雞 x" + Count.Dishes1Count + ",共NT$" + totalPrice + "元" + Environment.NewLine;
                labTitle.Text = msbox1 + msbox2 + msbox3 + msbox4 + msbox5 + msbox6 + msbox7 + msbox8 + msbox9 + msbox10 + msbox11;
            }
            TotalPrice = Count.Dishes1Count * Price.Dishes1Price + Count.Dishes2Count * Price.Dishes2Price
           + Count.Dishes3Count * Price.Dishes3Price + Count.Dishes4Count * Price.Dishes4Price + Count.Dishes5Count * Price.Dishes5Price + Count.Dishes6Count * Price.Dishes6Price + Count.Dishes7Count * Price.Dishes7Price + Count.Dishes8Count * Price.Dishes8Price + Count.Dishes9Count * Price.Dishes9Price + Count.Dishes10Count * Price.Dishes10Price + Count.Dishes11Count * Price.Dishes11Price;
            txtTotal.Text = "NT$ " + TotalPrice.ToString();
        }

        private void btnFish_Click(object sender, EventArgs e)
        {
            if (msbox2 == "")
            {
                Count.Dishes2Count++;
                double totalPrice = Count.Dishes2Count * Price.Dishes2Price;
                msbox2 = msbox2 + "糖醋海鱸魚 x" + Count.Dishes2Count + ",共NT$" + totalPrice + "元" + Environment.NewLine;
                labTitle.Text = msbox1 + msbox2 + msbox3 + msbox4 + msbox5 + msbox6 + msbox7 + msbox8 + msbox9 + msbox10 + msbox11;
            }
            else
            {
                Count.Dishes2Count += 1;
                double totalPrice = Count.Dishes2Count * Price.Dishes2Price;
                msbox2 = "糖醋海鱸魚 x" + Count.Dishes2Count + ",共NT$" + totalPrice + "元" + Environment.NewLine;
                labTitle.Text = msbox1 + msbox2 + msbox3 + msbox4 + msbox5 + msbox6 + msbox7 + msbox8 + msbox9 + msbox10 + msbox11;
            }
            TotalPrice = Count.Dishes1Count * Price.Dishes1Price + Count.Dishes2Count * Price.Dishes2Price
           + Count.Dishes3Count * Price.Dishes3Price + Count.Dishes4Count * Price.Dishes4Price + Count.Dishes5Count * Price.Dishes5Price + Count.Dishes6Count * Price.Dishes6Price + Count.Dishes7Count * Price.Dishes7Price + Count.Dishes8Count * Price.Dishes8Price + Count.Dishes9Count * Price.Dishes9Price + Count.Dishes10Count * Price.Dishes10Price + Count.Dishes11Count * Price.Dishes11Price;
            txtTotal.Text = "NT$ " + TotalPrice.ToString();
        }

        private void btnThickSoup_Click(object sender, EventArgs e)
        {
            if (msbox3 == "")
            {
                Count.Dishes3Count++;
                double totalPrice = Count.Dishes3Count * Price.Dishes3Price;
                msbox3 = msbox3 + "魚翅蝦仁羹 x" + Count.Dishes3Count + ",共NT$" + totalPrice + "元" + Environment.NewLine;
                labTitle.Text = msbox1 + msbox2 + msbox3 + msbox4 + msbox5 + msbox6 + msbox7 + msbox8 + msbox9 + msbox10 + msbox11;
            }
            else
            {
                Count.Dishes3Count += 1;
                double totalPrice = Count.Dishes3Count * Price.Dishes3Price;
                msbox3 = "魚翅蝦仁羹 x" + Count.Dishes3Count + ",共NT$" + totalPrice + "元" + Environment.NewLine;
                labTitle.Text = msbox1 + msbox2 + msbox3 + msbox4 + msbox5 + msbox6 + msbox7 + msbox8 + msbox9 + msbox10 + msbox11;
            }
            TotalPrice = Count.Dishes1Count * Price.Dishes1Price + Count.Dishes2Count * Price.Dishes2Price
           + Count.Dishes3Count * Price.Dishes3Price + Count.Dishes4Count * Price.Dishes4Price + Count.Dishes5Count * Price.Dishes5Price + Count.Dishes6Count * Price.Dishes6Price + Count.Dishes7Count * Price.Dishes7Price + Count.Dishes8Count * Price.Dishes8Price + Count.Dishes9Count * Price.Dishes9Price + Count.Dishes10Count * Price.Dishes10Price + Count.Dishes11Count * Price.Dishes11Price;
            txtTotal.Text = "NT$ " + TotalPrice.ToString();
        }

        private void btnChickenSoup_Click(object sender, EventArgs e)
        {
            if (msbox4 == "")
            {
                Count.Dishes4Count++;
                double totalPrice = Count.Dishes4Count * Price.Dishes4Price;
                msbox4 = msbox4 + "藥膳烏骨雞 x" + Count.Dishes4Count + ",共NT$" + totalPrice + "元" + Environment.NewLine;
                labTitle.Text = msbox1 + msbox2 + msbox3 + msbox4 + msbox5 + msbox6 + msbox7 + msbox8 + msbox9 + msbox10 + msbox11;
            }
            else
            {
                Count.Dishes4Count += 1;
                double totalPrice = Count.Dishes4Count * Price.Dishes4Price;
                msbox4 = "藥膳烏骨雞 x" + Count.Dishes4Count + ",共NT$" + totalPrice + "元" + Environment.NewLine;
                labTitle.Text = msbox1 + msbox2 + msbox3 + msbox4 + msbox5 + msbox6 + msbox7 + msbox8 + msbox9 + msbox10 + msbox11;
            }
            TotalPrice = Count.Dishes1Count * Price.Dishes1Price + Count.Dishes2Count * Price.Dishes2Price
           + Count.Dishes3Count * Price.Dishes3Price + Count.Dishes4Count * Price.Dishes4Price + Count.Dishes5Count * Price.Dishes5Price + Count.Dishes6Count * Price.Dishes6Price + Count.Dishes7Count * Price.Dishes7Price + Count.Dishes8Count * Price.Dishes8Price + Count.Dishes9Count * Price.Dishes9Price + Count.Dishes10Count * Price.Dishes10Price + Count.Dishes11Count * Price.Dishes11Price;
            txtTotal.Text = "NT$ " + TotalPrice.ToString();
        }

        private void btnAllSoup_Click(object sender, EventArgs e)
        {
            if (msbox5 == "")
            {
                Count.Dishes5Count++;
                double totalPrice = Count.Dishes5Count * Price.Dishes5Price;
                msbox5 = msbox5 + "干貝佛跳牆 x" + Count.Dishes5Count + ",共NT$" + totalPrice + "元" + Environment.NewLine;
                labTitle.Text = msbox1 + msbox2 + msbox3 + msbox4 + msbox5 + msbox6 + msbox7 + msbox8 + msbox9 + msbox10 + msbox11;
            }
            else
            {
                Count.Dishes5Count += 1;
                double totalPrice = Count.Dishes5Count * Price.Dishes5Price;
                msbox5 = "干貝佛跳牆 x" + Count.Dishes5Count + ",共NT$" + totalPrice + "元" + Environment.NewLine;
                labTitle.Text = msbox1 + msbox2 + msbox3 + msbox4 + msbox5 + msbox6 + msbox7 + msbox8 + msbox9 + msbox10 + msbox11;
            }
            TotalPrice = Count.Dishes1Count * Price.Dishes1Price + Count.Dishes2Count * Price.Dishes2Price
           + Count.Dishes3Count * Price.Dishes3Price + Count.Dishes4Count * Price.Dishes4Price + Count.Dishes5Count * Price.Dishes5Price + Count.Dishes6Count * Price.Dishes6Price + Count.Dishes7Count * Price.Dishes7Price + Count.Dishes8Count * Price.Dishes8Price + Count.Dishes9Count * Price.Dishes9Price + Count.Dishes10Count * Price.Dishes10Price + Count.Dishes11Count * Price.Dishes11Price;
            txtTotal.Text = "NT$ " + TotalPrice.ToString();
        }

        private void btnPigLag_Click(object sender, EventArgs e)
        {
            if (msbox6 == "")
            {
                Count.Dishes6Count++;
                double totalPrice = Count.Dishes6Count * Price.Dishes6Price;
                msbox6 = msbox6 + "筍干Q蹄膀  x" + Count.Dishes6Count + ",共NT$" + totalPrice + "元" + Environment.NewLine;
                labTitle.Text = msbox1 + msbox2 + msbox3 + msbox4 + msbox5 + msbox6 + msbox7 + msbox8 + msbox9 + msbox10 + msbox11;
            }
            else
            {
                Count.Dishes6Count += 1;
                double totalPrice = Count.Dishes6Count * Price.Dishes6Price;
                msbox6 = "筍干Q蹄膀  x" + Count.Dishes6Count + ",共NT$" + totalPrice + "元" + Environment.NewLine;
                labTitle.Text = msbox1 + msbox2 + msbox3 + msbox4 + msbox5 + msbox6 + msbox7 + msbox8 + msbox9 + msbox10 + msbox11;
            }
            TotalPrice = Count.Dishes1Count * Price.Dishes1Price + Count.Dishes2Count * Price.Dishes2Price
           + Count.Dishes3Count * Price.Dishes3Price + Count.Dishes4Count * Price.Dishes4Price + Count.Dishes5Count * Price.Dishes5Price + Count.Dishes6Count * Price.Dishes6Price + Count.Dishes7Count * Price.Dishes7Price + Count.Dishes8Count * Price.Dishes8Price + Count.Dishes9Count * Price.Dishes9Price + Count.Dishes10Count * Price.Dishes10Price + Count.Dishes11Count * Price.Dishes11Price;
            txtTotal.Text = "NT$ " + TotalPrice.ToString();
        }

        private void btnRice_Click(object sender, EventArgs e)
        {
            if (msbox7 == "")
            {
                Count.Dishes7Count++;
                double totalPrice = Count.Dishes7Count * Price.Dishes7Price;
                msbox7 = msbox7 + "櫻花蝦米糕 x" + Count.Dishes7Count + ",共NT$" + totalPrice + "元" + Environment.NewLine;
                labTitle.Text = msbox1 + msbox2 + msbox3 + msbox4 + msbox5 + msbox6 + msbox7 + msbox8 + msbox9 + msbox10 + msbox11;
            }
            else
            {
                Count.Dishes7Count += 1;
                double totalPrice = Count.Dishes7Count * Price.Dishes7Price;
                msbox7 = "櫻花蝦米糕 x" + Count.Dishes7Count + ",共NT$" + totalPrice + "元" + Environment.NewLine;
                labTitle.Text = msbox1 + msbox2 + msbox3 + msbox4 + msbox5 + msbox6 + msbox7 + msbox8 + msbox9 + msbox10 + msbox11;
            }
            TotalPrice = Count.Dishes1Count * Price.Dishes1Price + Count.Dishes2Count * Price.Dishes2Price
           + Count.Dishes3Count * Price.Dishes3Price + Count.Dishes4Count * Price.Dishes4Price + Count.Dishes5Count * Price.Dishes5Price + Count.Dishes6Count * Price.Dishes6Price + Count.Dishes7Count * Price.Dishes7Price + Count.Dishes8Count * Price.Dishes8Price + Count.Dishes9Count * Price.Dishes9Price + Count.Dishes10Count * Price.Dishes10Price + Count.Dishes11Count * Price.Dishes11Price;
            txtTotal.Text = "NT$ " + TotalPrice.ToString();
        }

        private void btnEightBall_Click(object sender, EventArgs e)
        {
            if (msbox8 == "")
            {
                Count.Dishes8Count++;
                double totalPrice = Count.Dishes8Count * Price.Dishes8Price;
                msbox8 = msbox8 + "香酥八寶丸 x" + Count.Dishes8Count + ",共NT$" + totalPrice + "元" + Environment.NewLine;
                labTitle.Text = msbox1 + msbox2 + msbox3 + msbox4 + msbox5 + msbox6 + msbox7 + msbox8 + msbox9 + msbox10 + msbox11;
            }
            else
            {
                Count.Dishes8Count += 1;
                double totalPrice = Count.Dishes8Count * Price.Dishes8Price;
                msbox8 = "香酥八寶丸 x" + Count.Dishes8Count + ",共NT$" + totalPrice + "元" + Environment.NewLine;
                labTitle.Text = msbox1 + msbox2 + msbox3 + msbox4 + msbox5 + msbox6 + msbox7 + msbox8 + msbox9 + msbox10 + msbox11;
            }
            TotalPrice = Count.Dishes1Count * Price.Dishes1Price + Count.Dishes2Count * Price.Dishes2Price
           + Count.Dishes3Count * Price.Dishes3Price + Count.Dishes4Count * Price.Dishes4Price + Count.Dishes5Count * Price.Dishes5Price + Count.Dishes6Count * Price.Dishes6Price + Count.Dishes7Count * Price.Dishes7Price + Count.Dishes8Count * Price.Dishes8Price + Count.Dishes9Count * Price.Dishes9Price + Count.Dishes10Count * Price.Dishes10Price + Count.Dishes11Count * Price.Dishes11Price;
            txtTotal.Text = "NT$ " + TotalPrice.ToString();
        }

        private void btnPork_Click(object sender, EventArgs e)
        {
            if (msbox9 == "")
            {
                Count.Dishes9Count++;
                double totalPrice = Count.Dishes9Count * Price.Dishes9Price;
                msbox9 = msbox9 + "蜜汁全排骨 x" + Count.Dishes9Count + ",共NT$" + totalPrice + "元" + Environment.NewLine;
                labTitle.Text = msbox1 + msbox2 + msbox3 + msbox4 + msbox5 + msbox6 + msbox7 + msbox8 + msbox9 + msbox10 + msbox11;
            }
            else
            {
                Count.Dishes9Count += 1;
                double totalPrice = Count.Dishes9Count * Price.Dishes9Price;
                msbox9 = "蜜汁全排骨 x" + Count.Dishes9Count + ",共NT$" + totalPrice + "元" + Environment.NewLine;
                labTitle.Text = msbox1 + msbox2 + msbox3 + msbox4 + msbox5 + msbox6 + msbox7 + msbox8 + msbox9 + msbox10 + msbox11;
            }
            TotalPrice = Count.Dishes1Count * Price.Dishes1Price + Count.Dishes2Count * Price.Dishes2Price
           + Count.Dishes3Count * Price.Dishes3Price + Count.Dishes4Count * Price.Dishes4Price + Count.Dishes5Count * Price.Dishes5Price + Count.Dishes6Count * Price.Dishes6Price + Count.Dishes7Count * Price.Dishes7Price + Count.Dishes8Count * Price.Dishes8Price + Count.Dishes9Count * Price.Dishes9Price + Count.Dishes10Count * Price.Dishes10Price + Count.Dishes11Count * Price.Dishes11Price;
            txtTotal.Text = "NT$ " + TotalPrice.ToString();
        }

        private void btnFishball_Click(object sender, EventArgs e)
        {
            if (msbox10 == "")
            {
                Count.Dishes10Count++;
                double totalPrice = Count.Dishes10Count * Price.Dishes10Price;
                msbox10 = msbox10 + "白雪旗魚丸 x" + Count.Dishes10Count + ",共NT$" + totalPrice + "元" + Environment.NewLine;
                labTitle.Text = msbox1 + msbox2 + msbox3 + msbox4 + msbox5 + msbox6 + msbox7 + msbox8 + msbox9 + msbox10 + msbox11;
            }
            else
            {
                Count.Dishes10Count += 1;
                double totalPrice = Count.Dishes10Count * Price.Dishes10Price;
                msbox10 = "白雪旗魚丸 x" + Count.Dishes10Count + ",共NT$" + totalPrice + "元" + Environment.NewLine;
                labTitle.Text = msbox1 + msbox2 + msbox3 + msbox4 + msbox5 + msbox6 + msbox7 + msbox8 + msbox9 + msbox10 + msbox11;
            }
            TotalPrice = Count.Dishes1Count * Price.Dishes1Price + Count.Dishes2Count * Price.Dishes2Price
           + Count.Dishes3Count * Price.Dishes3Price + Count.Dishes4Count * Price.Dishes4Price + Count.Dishes5Count * Price.Dishes5Price + Count.Dishes6Count * Price.Dishes6Price + Count.Dishes7Count * Price.Dishes7Price + Count.Dishes8Count * Price.Dishes8Price + Count.Dishes9Count * Price.Dishes9Price + Count.Dishes10Count * Price.Dishes10Price + Count.Dishes11Count * Price.Dishes11Price;
            txtTotal.Text = "NT$ " + TotalPrice.ToString();
        }

        private void btnFishRoll_Click(object sender, EventArgs e)
        {
            if (msbox11 == "")
            {
                Count.Dishes11Count++;
                double totalPrice = Count.Dishes11Count * Price.Dishes11Price;
                msbox11 = msbox11 + "極鮮旗魚卷 x" + Count.Dishes11Count + ",共NT$" + totalPrice + "元" + Environment.NewLine;
                labTitle.Text = msbox1 + msbox2 + msbox3 + msbox4 + msbox5 + msbox6 + msbox7 + msbox8 + msbox9 + msbox10 + msbox11;
            }
            else
            {
                Count.Dishes11Count += 1;
                double totalPrice = Count.Dishes11Count * Price.Dishes11Price;
                msbox11 = "極鮮旗魚卷 x" + Count.Dishes11Count + ",共NT$" + totalPrice + "元" + Environment.NewLine;
                labTitle.Text = msbox1 + msbox2 + msbox3 + msbox4 + msbox5 + msbox6 + msbox7 + msbox8 + msbox9 + msbox10 + msbox11;
            }
            TotalPrice = Count.Dishes1Count * Price.Dishes1Price + Count.Dishes2Count * Price.Dishes2Price
           + Count.Dishes3Count * Price.Dishes3Price + Count.Dishes4Count * Price.Dishes4Price + Count.Dishes5Count * Price.Dishes5Price + Count.Dishes6Count * Price.Dishes6Price + Count.Dishes7Count * Price.Dishes7Price + Count.Dishes8Count * Price.Dishes8Price + Count.Dishes9Count * Price.Dishes9Price + Count.Dishes10Count * Price.Dishes10Price + Count.Dishes11Count * Price.Dishes11Price;
            txtTotal.Text = "NT$ " + TotalPrice.ToString();
        }

        private void btnCash_Click(object sender, EventArgs e)
        {
            if (txtTotal.Text == "NT$ 0")
            {
                MessageBox.Show("尚未點餐", "提醒", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            }
            else
            {
                MessageBox.Show("總金額：" + txtTotal.Text + "元",
                "確認付款", MessageBoxButtons.OKCancel);
            }
        }

        private void btnCuppon_Click(object sender, EventArgs e)
        {
            double Discount = TotalPrice - 1000;
            double FinalTotal = Discount - 5000;
            if (txtTotal.Text == "NT$ 0")
            {
                MessageBox.Show("尚未點餐", "確認付款", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            }
            else
            {
                if (TotalPrice >= 6000)
                {
                    MessageBox.Show("總金額：" + txtTotal.Text + "元" + "\n折扣後金額：NT$ " + Discount + "\n五倍券 5,000元" + "及現金 " + FinalTotal + "元","確認付款", MessageBoxButtons.OKCancel);
                }
                else
                {
                    MessageBox.Show("結帳金額未超過最低優惠門檻", "注意", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            msbox1 = "";
            msbox2 = "";
            msbox3 = "";
            msbox4 = "";
            msbox5 = "";
            msbox6 = "";
            msbox7 = "";
            msbox8 = "";
            msbox9 = "";
            msbox10 = "";
            msbox11 = "";
            Count.Dishes1Count = 0;
            Count.Dishes2Count = 0;
            Count.Dishes3Count = 0;
            Count.Dishes4Count = 0;
            Count.Dishes5Count = 0;
            Count.Dishes6Count = 0;
            Count.Dishes7Count = 0;
            Count.Dishes8Count = 0;
            Count.Dishes9Count = 0;
            Count.Dishes10Count = 0;
            Count.Dishes11Count = 0;
            labTitle.Text = msbox1 + msbox2 + msbox3 + msbox4 + msbox5 + msbox6 + msbox7 + msbox8 + msbox9 + msbox10 + msbox11;
            txtTotal.Text = "NT$ 0";
        }


    }
}
