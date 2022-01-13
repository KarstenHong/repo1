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
using System.IO;
using System.Configuration;

namespace ChineseNewYear_CHW_38
{
    public partial class Form5_DishesView : Form
    {
        public int DishesID = 0;
        string CNY_myHWConnectionString = "";
        string image_dir = @"image\";
        string image_name = "";
        bool ChangePicture = false;
        public Form5_DishesView()
        {
            InitializeComponent();
        }

        private void Form5_DishesView_Load(object sender, EventArgs e)
        {
            CNY_myHWConnectionString = ConfigurationManager.ConnectionStrings["ChineseNewYear_CHW_38.Properties.Settings.CNY_myHWConnectionString"].ConnectionString;

            ShowDishesDetail();
        }
        void ShowDishesDetail()
        {
            SqlConnection con = new SqlConnection(CNY_myHWConnectionString);
            con.Open();
            string strSQL = "select * from Dishes where 序號 = @SearchID";
            SqlCommand cmd = new SqlCommand(strSQL, con);
            cmd.Parameters.AddWithValue("@SearchID", DishesID);
            SqlDataReader reader = cmd.ExecuteReader();
            int i = 0;
            while (reader.Read())
            {
                txtID.Text = Convert.ToString(reader["序號"]);
                txtName.Text = Convert.ToString(reader["菜名"]);
                txtPrice.Text = Convert.ToString(reader["價錢"]);
                image_name = Convert.ToString(reader["圖片"]);
                pboxPicture.Image = Image.FromFile(image_dir + image_name);
                i += 1;
            }
            reader.Close();
            con.Close();
        }

        private void btnChangePicture_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog f = new OpenFileDialog();
                f.Filter = "圖檔類型(*.jpg, *.jpeg, *.png) | *.jpeg; *.jpg; *.png";
                DialogResult R = f.ShowDialog();

                if (R == DialogResult.OK)
                {
                    pboxPicture.Image = Image.FromFile(f.FileName);

                    string fileExt = Path.GetExtension(f.SafeFileName);
                    Random myRnd = new Random();
                    image_name = DateTime.Now.ToString("yyyyMMdd") + myRnd.Next(100, 999).ToString() + fileExt;
                    ChangePicture = true;
                }

            }
            catch (Exception error)
            {
                Console.WriteLine(error.ToString());
            }

        }

        private void btnSaveChange_Click(object sender, EventArgs e)
        {
            if ((txtName.Text != "") && (txtPrice.Text != "") && (pboxPicture.Image != null))
            {
                if (ChangePicture == true)
                {
                    pboxPicture.Image.Save(image_dir + image_name);
                    ChangePicture = false;
                }
                SqlConnection con = new SqlConnection(CNY_myHWConnectionString);
                con.Open();
                string strSQL = "update Dishes set 價錢 = @NewPrice, 圖片 = @Newimage where 序號 = @SearchID";
                SqlCommand cmd = new SqlCommand(strSQL, con);
                cmd.Parameters.AddWithValue("@SearchID", DishesID);
                cmd.Parameters.AddWithValue("@Newimage", image_name);
                int myPrice = 0;
                Int32.TryParse(txtPrice.Text, out myPrice);
                cmd.Parameters.AddWithValue("@NewPrice", myPrice);

                int rows = cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show($"修改完成, 影響{rows}筆資料", "修改成功", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                MessageBox.Show("所有欄位必填", "提醒", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
