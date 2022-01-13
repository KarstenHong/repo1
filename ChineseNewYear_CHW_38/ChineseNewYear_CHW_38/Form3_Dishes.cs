using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace ChineseNewYear_CHW_38
{
    public partial class Form3_Dishes : Form
    {
        //右半部
        SqlConnectionStringBuilder scsb;
        string CNY_myHWconnectionString = "";
        //左半部
        string CNY_myHWconnectionString_View = "";
        List<string> listName = new List<string>();
        List<int> listPrice = new List<int>();
        List<int> listID = new List<int>();

        public Form3_Dishes()
        {
            InitializeComponent();
        }

        private void Form3_Dishes_Load(object sender, EventArgs e)
        {
            //右半部
            scsb = new SqlConnectionStringBuilder();
            scsb.DataSource = @".";
            scsb.InitialCatalog = "CNY_myHW";
            scsb.IntegratedSecurity = true;
            CNY_myHWconnectionString = scsb.ToString();
            //左半部
            SqlConnectionStringBuilder scsbView = new SqlConnectionStringBuilder();
            scsbView.DataSource = @".";
            scsbView.InitialCatalog = "CNY_myHW";
            scsbView.IntegratedSecurity = true;
            CNY_myHWconnectionString_View = scsbView.ToString();
            ReadDatabase();
            listView_PictureMod();

            MessageBox.Show("請輸入序號、姓名、電話建立新訂單！", "開始訂購", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        //右半部
        private void btnNewID_Click(object sender, EventArgs e)
        {
            if ((txtName.Text != "") && (txtID.Text != ""))
            {
                SqlConnection con = new SqlConnection(CNY_myHWconnectionString);
                con.Open();
                string strSQL = "insert into OrderPerson values(@NewID, @NewName, @NewPhone, @NewRemark, @NewDishes1, @NewDishes2, @NewDishes3, @NewDishes4, @NewDishes5, @NewDishes6, @NewDishes7, @NewDishes8, @NewDishes9, @NewDishes10);";
                SqlCommand cmd = new SqlCommand(strSQL, con);
                cmd.Parameters.AddWithValue("@NewID", txtID.Text);
                cmd.Parameters.AddWithValue("@NewName", txtName.Text);
                cmd.Parameters.AddWithValue("@NewPhone", txtPhone.Text);
                cmd.Parameters.AddWithValue("@NewRemark", txtRemark.Text);
                cmd.Parameters.AddWithValue("@NewDishes1", txtDishes1.Text);
                cmd.Parameters.AddWithValue("@NewDishes2", txtDishes2.Text);
                cmd.Parameters.AddWithValue("@NewDishes3", txtDishes3.Text);
                cmd.Parameters.AddWithValue("@NewDishes4", txtDishes4.Text);
                cmd.Parameters.AddWithValue("@NewDishes5", txtDishes5.Text);
                cmd.Parameters.AddWithValue("@NewDishes6", txtDishes6.Text);
                cmd.Parameters.AddWithValue("@NewDishes7", txtDishes7.Text);
                cmd.Parameters.AddWithValue("@NewDishes8", txtDishes8.Text);
                cmd.Parameters.AddWithValue("@NewDishes9", txtDishesYes.Text);
                cmd.Parameters.AddWithValue("@NewDishes10", txtDishesNo.Text);

                int rows = cmd.ExecuteNonQuery();
                con.Close();
                DialogResult R = MessageBox.Show($"{rows}筆訂單新增成功，按下確認即可再新增訂單！", "完成", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                if (R == DialogResult.OK)
                {
                    txtID.Text = "";
                    txtName.Text = "";
                    txtPhone.Text = "";
                    txtRemark.Text = "";
                    txtDishes1.Text = "";
                    txtDishes2.Text = "";
                    txtDishes3.Text = "";
                    txtDishes4.Text = "";
                    txtDishes5.Text = "";
                    txtDishes6.Text = "";
                    txtDishes7.Text = "";
                    txtDishes8.Text = "";
                    txtDishesYes.Text = "";
                    txtDishesNo.Text = "";
                }
            }
            else
            {
                MessageBox.Show("請輸入序號、姓名、電話，並輸入訂購菜餚數量！", "提醒", MessageBoxButtons.OK);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (txtName.Text != "")
            {
                SqlConnection con = new SqlConnection(CNY_myHWconnectionString);
                con.Open();
                string strSQL = "select * from OrderPerson where 姓名 like @SearchName ";
                SqlCommand cmd = new SqlCommand(strSQL, con);
                cmd.Parameters.AddWithValue("@SearchName", "%" + txtName.Text + "%");
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    txtID.Text = $"{reader["序號"]}";
                    txtName.Text = $"{reader["姓名"]}";
                    txtPhone.Text = $"{reader["電話"]}";
                    txtRemark.Text = $"{reader["備註"]}";
                    txtDishes1.Text = $"{reader["甘蔗香燻雞"]}";
                    txtDishes2.Text = $"{reader["糖醋海鱸魚"]}";
                    txtDishes3.Text = $"{reader["筍干Q蹄膀"]}";
                    txtDishes4.Text = $"{reader["魚翅蝦仁羹"]}";
                    txtDishes5.Text = $"{reader["櫻花蝦米糕"]}";
                    txtDishes6.Text = $"{reader["蜜汁全排骨"]}";
                    txtDishes7.Text = $"{reader["白雪旗魚丸"]}";
                    txtDishes8.Text = $"{reader["極鮮旗魚卷"]}";
                    txtDishesYes.Text = $"{reader["[干貝佛跳牆(含甕]"]}";
                    txtDishesNo.Text = $"{reader["[干貝佛跳牆(不含甕]"]}";
                    DialogResult R = MessageBox.Show("已找到訂單，按下確認即可重新搜尋！", "完成", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    if (R == DialogResult.OK)
                    {
                        txtID.Text = "";
                        txtName.Text = "";
                        txtPhone.Text = "";
                        txtRemark.Text = "";
                        txtDishes1.Text = "";
                        txtDishes2.Text = "";
                        txtDishes3.Text = "";
                        txtDishes4.Text = "";
                        txtDishes5.Text = "";
                        txtDishes6.Text = "";
                        txtDishes7.Text = "";
                        txtDishes8.Text = "";
                        txtDishesYes.Text = "";
                        txtDishesNo.Text = "";
                    }
                }
                else
                {
                    MessageBox.Show("查無此訂單，請重新搜尋", "提醒", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                reader.Close();
                con.Close();
            }
            else
            {
                MessageBox.Show("請輸入姓名搜尋", "提醒", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnAllOrder_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(CNY_myHWconnectionString);
            con.Open();
            string strSQL = "select * from OrderPerson";
            SqlCommand cmd = new SqlCommand(strSQL, con); //兩個參數(SQL命令 ， 資料庫連線物件)
            SqlDataReader reader = cmd.ExecuteReader();

            string strMsg = "";
            int i = 0;

            while (reader.Read()) // 只要有讀到資料就會回傳true
            {
                strMsg += $"{reader["序號"]} {reader["姓名"]} {reader["電話"]}\n";
                i += 1;
            }

            strMsg += "資料筆數：" + i.ToString();

            reader.Close();
            con.Close();

            MessageBox.Show(strMsg);
        }

        private void btnNowPurchers_Click(object sender, EventArgs e)
        {
            Form4_POS POS = new Form4_POS();
            POS.ShowDialog();      
        }
        //左半部
        void ReadDatabase()
        {
            SqlConnection con = new SqlConnection(CNY_myHWconnectionString);
            con.Open();
            string strSQL = "select * from Dishes";
            SqlCommand cmd = new SqlCommand(strSQL, con);
            SqlDataReader reader = cmd.ExecuteReader();

            string image_dir = @"image\";
            string image_name = "";
            int i = 0;

            while (reader.Read())
            {
                listID.Add(Convert.ToInt32(reader["序號"]));
                listName.Add(Convert.ToString(reader["菜名"]));
                listPrice.Add(Convert.ToInt32(reader["價錢"]));
                image_name = Convert.ToString(reader["圖片"]);
                imageList1.Images.Add(Image.FromFile(image_dir + image_name));
                i += 1;
            }
            Console.WriteLine("讀取{0}筆資料", i);
            reader.Close();
            con.Close();
        }
        void listView_PictureMod()
        {
            listView.Clear();
            //listView.View = View.SmallIcon;
            listView.View = View.LargeIcon;
            imageList1.ImageSize = new Size(90, 90);
            listView.LargeImageList = imageList1;
            //listView.SmallImageList = imageList1;
            for (int i = 0; i < imageList1.Images.Count; i += 1)
            {
                ListViewItem item = new ListViewItem();
                item.ImageIndex = i;
                item.Font = new Font("標楷體", 14, FontStyle.Regular);
                item.Text = listName[i];
                item.Tag = listID[i];
                listView.Items.Add(item);
            }
        }
        void listView_ListMod()
        {
            listView.Clear();
            listView.View = View.Details;
            listView.Columns.Add("序號", 70);
            listView.Columns.Add("菜名", 140);
            listView.Columns.Add("價錢", 100);
            listView.FullRowSelect = true;

            for (int i = 0; i < listID.Count; i += 1)
            {
                ListViewItem item = new ListViewItem();
                item.Font = new Font("標楷體", 14, FontStyle.Regular);
                item.Tag = listID[i];
                item.Text = listID[i].ToString();
                item.SubItems.Add(listName[i]);
                item.SubItems.Add(listPrice[i].ToString());

                listView.Items.Add(item);
            }
        }

        private void btnPictureMod_Click(object sender, EventArgs e)
        {
            listView_PictureMod();
        }

        private void btnListMod_Click(object sender, EventArgs e)
        {
            listView_ListMod();
        }

        private void btnRecover_Click(object sender, EventArgs e)
        {
            listID.Clear();
            listName.Clear();
            listPrice.Clear();
            imageList1.Images.Clear();
            ReadDatabase();

            if (listView.View == View.Details)
            {
                listView_ListMod();
            }
            else
            {
                listView_PictureMod();
            }
        }

        private void listView_ItemActivate(object sender, EventArgs e)
        {
            int selectID = Convert.ToInt32(listView.SelectedItems[0].Tag); //只能開一個
            Form5_DishesView DishesView = new Form5_DishesView();
            DishesView.DishesID = selectID;
            DishesView.ShowDialog();
        }

        private void txtDishes7_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
