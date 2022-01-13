
namespace ChineseNewYear_CHW_38
{
    partial class Form1_HomePage
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.btnOrder = new System.Windows.Forms.Button();
            this.btnDishes = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnOrder
            // 
            this.btnOrder.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnOrder.AutoSize = true;
            this.btnOrder.BackColor = System.Drawing.Color.Transparent;
            this.btnOrder.BackgroundImage = global::ChineseNewYear_CHW_38.Properties.Resources.控制項_1;
            this.btnOrder.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnOrder.FlatAppearance.BorderSize = 0;
            this.btnOrder.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnOrder.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOrder.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnOrder.ForeColor = System.Drawing.Color.Transparent;
            this.btnOrder.Location = new System.Drawing.Point(507, 170);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Size = new System.Drawing.Size(200, 200);
            this.btnOrder.TabIndex = 0;
            this.btnOrder.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnOrder.UseVisualStyleBackColor = false;
            this.btnOrder.Click += new System.EventHandler(this.btnOrder_Click);
            // 
            // btnDishes
            // 
            this.btnDishes.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnDishes.AutoSize = true;
            this.btnDishes.BackColor = System.Drawing.Color.Transparent;
            this.btnDishes.BackgroundImage = global::ChineseNewYear_CHW_38.Properties.Resources.控制項_2;
            this.btnDishes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnDishes.FlatAppearance.BorderSize = 0;
            this.btnDishes.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnDishes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnDishes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDishes.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnDishes.ForeColor = System.Drawing.Color.Transparent;
            this.btnDishes.Location = new System.Drawing.Point(228, 170);
            this.btnDishes.Name = "btnDishes";
            this.btnDishes.Size = new System.Drawing.Size(200, 200);
            this.btnDishes.TabIndex = 1;
            this.btnDishes.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnDishes.UseVisualStyleBackColor = false;
            this.btnDishes.Click += new System.EventHandler(this.btnDishes_Click);
            // 
            // label1
            // 
            this.label1.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("標楷體", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.ForeColor = System.Drawing.Color.Cornsilk;
            this.label1.Location = new System.Drawing.Point(195, 126);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(563, 28);
            this.label1.TabIndex = 2;
            this.label1.Text = "您好！請先點選年菜訂購單按鈕進行訂購！";
            // 
            // Form1_HomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.BackgroundImage = global::ChineseNewYear_CHW_38.Properties.Resources.首頁;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(942, 601);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDishes);
            this.Controls.Add(this.btnOrder);
            this.Name = "Form1_HomePage";
            this.Text = "金虎年開運年菜";
            this.Load += new System.EventHandler(this.Form1_HomePage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnDishes;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Button btnOrder;
    }
}

