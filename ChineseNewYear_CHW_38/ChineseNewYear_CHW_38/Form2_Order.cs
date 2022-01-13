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

namespace ChineseNewYear_CHW_38
{
    public partial class Form2_Order : Form
    {
        public Form2_Order()
        {
            InitializeComponent();
        }

        private void orderPersonBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.orderPersonBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.cNY_myHWDataSet);

        }

        private void Form2_Order_Load(object sender, EventArgs e)
        {
            // TODO: 這行程式碼會將資料載入 'cNY_myHWDataSet.OrderPerson' 資料表。您可以視需要進行移動或移除。
            this.orderPersonTableAdapter.Fill(this.cNY_myHWDataSet.OrderPerson);

            cBoxFind.Items.Add("序號"); //0
            cBoxFind.Items.Add("姓名"); //1
            cBoxFind.Items.Add("電話"); //2
            cBoxFind.SelectedIndex = 0;  // 預設欄位為序號

            cBoxFilter.Items.Add("序號");
            cBoxFilter.Items.Add("姓名");
            cBoxFilter.Items.Add("電話");
            cBoxFilter.SelectedIndex = 1;  //預設欄位為姓名

            UnEnableChk();
        }

        private void btnFirstID_Click(object sender, EventArgs e)
        {
            orderPersonBindingSource.MoveFirst();
        }

        private void btnBackID_Click(object sender, EventArgs e)
        {
            orderPersonBindingSource.MovePrevious();
        }

        private void btnNextID_Click(object sender, EventArgs e)
        {
            orderPersonBindingSource.MoveNext();
        }

        private void btnLastID_Click(object sender, EventArgs e)
        {
            orderPersonBindingSource.MoveLast();
        }

        private void btnSaveFix_Click(object sender, EventArgs e)
        {
            DialogResult R = MessageBox.Show("是否要儲存修改?", "儲存確認", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (R == DialogResult.Yes)
            {
                // 確認
                orderPersonBindingSource.EndEdit();  // 結束編輯模式
                int idxCurrent1 = orderPersonBindingSource.Position;
                orderPersonTableAdapter.Update(cNY_myHWDataSet.OrderPerson);  // 更新到 cNY_myHWDataSet
                orderPersonTableAdapter.Fill(cNY_myHWDataSet.OrderPerson);
                orderPersonBindingSource.Position = idxCurrent1;
                UnEnableChk();
                MessageBox.Show("資料修改儲存成功", "完成", MessageBoxButtons.OK);
                
            }
            else
            {
                // 取消
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult R = MessageBox.Show("您確認要刪除資料?", "刪除確認", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (R == DialogResult.Yes)
            {
                orderPersonBindingSource.EndEdit();
                int idxCurrent1 = orderPersonBindingSource.Position; // 繫結資料，索引
                orderPersonBindingSource.RemoveAt(idxCurrent1);
                orderPersonTableAdapter.Update(cNY_myHWDataSet.OrderPerson);
                MessageBox.Show("資料刪除成功", "完成", MessageBoxButtons.OK);
            }
            else
            {
                // 取消
            }
        }
        private void btnFix_Click(object sender, EventArgs e)
        {
            DialogResult R = MessageBox.Show("確定要修改訂單?", "提醒", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if(R == DialogResult.OK)
            {
                EnableChk();
            }
            else
            {
                //取消
            }
        }

        private void btnRecoverID_Click(object sender, EventArgs e)
        {
            DialogResult R = MessageBox.Show("您確認要回復資料?", "回復確認", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (R == DialogResult.Yes)
            {
                orderPersonBindingSource.EndEdit(); // 結束目前的動作
                int idxCurrent1 = orderPersonBindingSource.Position; // 繫結資料，索引
                orderPersonTableAdapter.Fill(cNY_myHWDataSet.OrderPerson); // 重新載入table的資料
                orderPersonBindingSource.Position = idxCurrent1; // 重新導回資料位置
                MessageBox.Show("資料回復成功", "完成", MessageBoxButtons.OK);
            }
            else
            {
                // 取消
            }
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            // 搜尋資料完全符合才能搜尋
            if (txtFind.Text != "")
            {
                string strSeach = txtFind.Text;
                string str欄位名稱 = cBoxFind.SelectedItem.ToString();
                int idxFind = orderPersonBindingSource.Find(str欄位名稱, strSeach);

                if (idxFind >= 0) // 找到資料 回傳0以上的值
                {
                    orderPersonBindingSource.Position = idxFind;
                    MessageBox.Show("找到資料了", "完成", MessageBoxButtons.OK);
                }
                else //找不到資料 回傳-1
                {
                    MessageBox.Show("找不到資料", "提醒", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("請輸入關鍵字搜尋", "提醒", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            // 模糊搜尋，可以出現多筆相同搜尋資料
            if (txtFilter.Text != "")
            {
                string strFilter = txtFilter.Text;
                string str欄位名稱 = cBoxFilter.SelectedItem.ToString();
                orderPersonBindingSource.Filter = $"{str欄位名稱} like '%{strFilter}%'";
                MessageBox.Show("搜尋完成", "完成", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("請輸入關鍵字搜尋", "提醒", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnRemoveFilter_Click(object sender, EventArgs e)
        {
            orderPersonBindingSource.RemoveFilter();
            txtFilter.Text = "";
            MessageBox.Show("模糊搜尋條件已移除", "完成", MessageBoxButtons.OK);
        }

        private void orderPersonBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.orderPersonBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.cNY_myHWDataSet);

        }

        private void orderPersonBindingNavigatorSaveItem_Click_2(object sender, EventArgs e)
        {
            this.Validate();
            this.orderPersonBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.cNY_myHWDataSet);

        }

        private void UnEnableChk()
        {
            txtID.ReadOnly = true;
            txtName.ReadOnly = true;
            txtPhone.ReadOnly = true;
            txtRemark.ReadOnly = true;
            txtDishes1.ReadOnly = true;
            txtDishes2.ReadOnly = true;
            txtDishes3.ReadOnly = true;
            txtDishes4.ReadOnly = true;
            txtDishes5.ReadOnly = true;
            txtDishes6.ReadOnly = true;
            txtDishes7.ReadOnly = true;
            txtDishes8.ReadOnly = true;
            txtDishesYes.ReadOnly = true;
            txtDishesNo.ReadOnly = true;
        }
        private void EnableChk()
        {
            txtID.ReadOnly = false;
            txtName.ReadOnly = false;
            txtPhone.ReadOnly = false;
            txtRemark.ReadOnly = false;
            txtDishes1.ReadOnly = false;
            txtDishes2.ReadOnly = false;
            txtDishes3.ReadOnly = false;
            txtDishes4.ReadOnly = false;
            txtDishes5.ReadOnly = false;
            txtDishes6.ReadOnly = false;
            txtDishes7.ReadOnly = false;
            txtDishes8.ReadOnly = false;
            txtDishesYes.ReadOnly = false;
            txtDishesNo.ReadOnly = false;
        }
    }
}
