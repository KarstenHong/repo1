
namespace ChineseNewYear_CHW_38
{
    partial class Form5_DishesView
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form5_DishesView));
            this.group修改商品 = new System.Windows.Forms.GroupBox();
            this.btnSaveChange = new System.Windows.Forms.Button();
            this.btnChangePicture = new System.Windows.Forms.Button();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.labPrice = new System.Windows.Forms.Label();
            this.labName = new System.Windows.Forms.Label();
            this.labID = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pboxPicture = new System.Windows.Forms.PictureBox();
            this.group修改商品.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // group修改商品
            // 
            this.group修改商品.BackColor = System.Drawing.Color.Transparent;
            this.group修改商品.Controls.Add(this.btnSaveChange);
            this.group修改商品.Controls.Add(this.btnChangePicture);
            this.group修改商品.Font = new System.Drawing.Font("標楷體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.group修改商品.ForeColor = System.Drawing.Color.White;
            this.group修改商品.Location = new System.Drawing.Point(21, 337);
            this.group修改商品.Name = "group修改商品";
            this.group修改商品.Size = new System.Drawing.Size(606, 114);
            this.group修改商品.TabIndex = 15;
            this.group修改商品.TabStop = false;
            this.group修改商品.Text = "修改商品資訊";
            // 
            // btnSaveChange
            // 
            this.btnSaveChange.BackColor = System.Drawing.Color.Transparent;
            this.btnSaveChange.BackgroundImage = global::ChineseNewYear_CHW_38.Properties.Resources.按鈕;
            this.btnSaveChange.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSaveChange.FlatAppearance.BorderColor = System.Drawing.Color.Cornsilk;
            this.btnSaveChange.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Cornsilk;
            this.btnSaveChange.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Crimson;
            this.btnSaveChange.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveChange.ForeColor = System.Drawing.Color.White;
            this.btnSaveChange.Location = new System.Drawing.Point(319, 46);
            this.btnSaveChange.Name = "btnSaveChange";
            this.btnSaveChange.Size = new System.Drawing.Size(229, 39);
            this.btnSaveChange.TabIndex = 1;
            this.btnSaveChange.Text = "儲存修改";
            this.btnSaveChange.UseVisualStyleBackColor = false;
            this.btnSaveChange.Click += new System.EventHandler(this.btnSaveChange_Click);
            // 
            // btnChangePicture
            // 
            this.btnChangePicture.BackColor = System.Drawing.Color.Transparent;
            this.btnChangePicture.BackgroundImage = global::ChineseNewYear_CHW_38.Properties.Resources.按鈕;
            this.btnChangePicture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnChangePicture.FlatAppearance.BorderColor = System.Drawing.Color.Cornsilk;
            this.btnChangePicture.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Cornsilk;
            this.btnChangePicture.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Crimson;
            this.btnChangePicture.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChangePicture.ForeColor = System.Drawing.Color.White;
            this.btnChangePicture.Location = new System.Drawing.Point(62, 46);
            this.btnChangePicture.Name = "btnChangePicture";
            this.btnChangePicture.Size = new System.Drawing.Size(229, 39);
            this.btnChangePicture.TabIndex = 0;
            this.btnChangePicture.Text = "選擇商品照片";
            this.btnChangePicture.UseVisualStyleBackColor = false;
            this.btnChangePicture.Click += new System.EventHandler(this.btnChangePicture_Click);
            // 
            // txtPrice
            // 
            this.txtPrice.BackColor = System.Drawing.Color.Cornsilk;
            this.txtPrice.Font = new System.Drawing.Font("標楷體", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtPrice.Location = new System.Drawing.Point(97, 136);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(219, 40);
            this.txtPrice.TabIndex = 13;
            // 
            // txtName
            // 
            this.txtName.BackColor = System.Drawing.Color.Cornsilk;
            this.txtName.Font = new System.Drawing.Font("標楷體", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtName.Location = new System.Drawing.Point(97, 79);
            this.txtName.Name = "txtName";
            this.txtName.ReadOnly = true;
            this.txtName.Size = new System.Drawing.Size(219, 40);
            this.txtName.TabIndex = 12;
            // 
            // txtID
            // 
            this.txtID.BackColor = System.Drawing.Color.Cornsilk;
            this.txtID.Font = new System.Drawing.Font("標楷體", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtID.Location = new System.Drawing.Point(97, 24);
            this.txtID.Name = "txtID";
            this.txtID.ReadOnly = true;
            this.txtID.Size = new System.Drawing.Size(111, 40);
            this.txtID.TabIndex = 11;
            this.txtID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labPrice
            // 
            this.labPrice.AutoSize = true;
            this.labPrice.BackColor = System.Drawing.Color.Transparent;
            this.labPrice.Font = new System.Drawing.Font("標楷體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labPrice.ForeColor = System.Drawing.Color.White;
            this.labPrice.Location = new System.Drawing.Point(16, 139);
            this.labPrice.Name = "labPrice";
            this.labPrice.Size = new System.Drawing.Size(75, 30);
            this.labPrice.TabIndex = 10;
            this.labPrice.Text = "價格";
            // 
            // labName
            // 
            this.labName.AutoSize = true;
            this.labName.BackColor = System.Drawing.Color.Transparent;
            this.labName.Font = new System.Drawing.Font("標楷體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labName.ForeColor = System.Drawing.Color.White;
            this.labName.Location = new System.Drawing.Point(16, 82);
            this.labName.Name = "labName";
            this.labName.Size = new System.Drawing.Size(75, 30);
            this.labName.TabIndex = 9;
            this.labName.Text = "菜名";
            // 
            // labID
            // 
            this.labID.AutoSize = true;
            this.labID.BackColor = System.Drawing.Color.Transparent;
            this.labID.Font = new System.Drawing.Font("標楷體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labID.ForeColor = System.Drawing.Color.White;
            this.labID.Location = new System.Drawing.Point(16, 27);
            this.labID.Name = "labID";
            this.labID.Size = new System.Drawing.Size(75, 30);
            this.labID.TabIndex = 8;
            this.labID.Text = "序號";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::ChineseNewYear_CHW_38.Properties.Resources.插圖_1;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(21, 186);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(295, 132);
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // pboxPicture
            // 
            this.pboxPicture.BackColor = System.Drawing.Color.Transparent;
            this.pboxPicture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pboxPicture.Location = new System.Drawing.Point(322, 19);
            this.pboxPicture.Name = "pboxPicture";
            this.pboxPicture.Size = new System.Drawing.Size(300, 300);
            this.pboxPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pboxPicture.TabIndex = 14;
            this.pboxPicture.TabStop = false;
            // 
            // Form5_DishesView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ChineseNewYear_CHW_38.Properties.Resources.分頁_2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(658, 476);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.group修改商品);
            this.Controls.Add(this.pboxPicture);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.labPrice);
            this.Controls.Add(this.labName);
            this.Controls.Add(this.labID);
            this.MaximizeBox = false;
            this.Name = "Form5_DishesView";
            this.Text = "菜餚資訊";
            this.Load += new System.EventHandler(this.Form5_DishesView_Load);
            this.group修改商品.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxPicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox group修改商品;
        private System.Windows.Forms.Button btnSaveChange;
        private System.Windows.Forms.Button btnChangePicture;
        private System.Windows.Forms.PictureBox pboxPicture;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label labPrice;
        private System.Windows.Forms.Label labName;
        private System.Windows.Forms.Label labID;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}