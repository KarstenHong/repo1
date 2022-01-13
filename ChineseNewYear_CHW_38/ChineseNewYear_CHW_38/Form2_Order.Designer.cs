
namespace ChineseNewYear_CHW_38
{
    partial class Form2_Order
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
            this.components = new System.ComponentModel.Container();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.orderPersonBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cNY_myHWDataSet = new ChineseNewYear_CHW_38.CNY_myHWDataSet();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtRemark = new System.Windows.Forms.TextBox();
            this.btnFirstID = new System.Windows.Forms.Button();
            this.btnBackID = new System.Windows.Forms.Button();
            this.btnNextID = new System.Windows.Forms.Button();
            this.btnLastID = new System.Windows.Forms.Button();
            this.btnSaveFix = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnRecoverID = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cBoxFilter = new System.Windows.Forms.ComboBox();
            this.cBoxFind = new System.Windows.Forms.ComboBox();
            this.btnFilter = new System.Windows.Forms.Button();
            this.btnRemoveFilter = new System.Windows.Forms.Button();
            this.btnFind = new System.Windows.Forms.Button();
            this.txtFilter = new System.Windows.Forms.TextBox();
            this.txtFind = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnFix = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtDishesYes = new System.Windows.Forms.TextBox();
            this.txtDishesNo = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.txtDishes1 = new System.Windows.Forms.TextBox();
            this.txtDishes2 = new System.Windows.Forms.TextBox();
            this.txtDishes3 = new System.Windows.Forms.TextBox();
            this.txtDishes4 = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txtDishes5 = new System.Windows.Forms.TextBox();
            this.txtDishes6 = new System.Windows.Forms.TextBox();
            this.txtDishes7 = new System.Windows.Forms.TextBox();
            this.txtDishes8 = new System.Windows.Forms.TextBox();
            this.orderPersonTableAdapter = new ChineseNewYear_CHW_38.CNY_myHWDataSetTableAdapters.OrderPersonTableAdapter();
            this.tableAdapterManager = new ChineseNewYear_CHW_38.CNY_myHWDataSetTableAdapters.TableAdapterManager();
            ((System.ComponentModel.ISupportInitialize)(this.orderPersonBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cNY_myHWDataSet)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("華康行楷體W5(P)", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(82, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 30);
            this.label2.TabIndex = 14;
            this.label2.Text = "姓名";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("華康行楷體W5(P)", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(81, 152);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 30);
            this.label3.TabIndex = 15;
            this.label3.Text = "電話";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("華康行楷體W5(P)", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(80, 203);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 30);
            this.label4.TabIndex = 16;
            this.label4.Text = "備註";
            // 
            // txtName
            // 
            this.txtName.BackColor = System.Drawing.Color.Cornsilk;
            this.txtName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.orderPersonBindingSource, "姓名", true));
            this.txtName.Font = new System.Drawing.Font("標楷體", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtName.Location = new System.Drawing.Point(156, 99);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(178, 40);
            this.txtName.TabIndex = 17;
            // 
            // orderPersonBindingSource
            // 
            this.orderPersonBindingSource.DataMember = "OrderPerson";
            this.orderPersonBindingSource.DataSource = this.cNY_myHWDataSet;
            // 
            // cNY_myHWDataSet
            // 
            this.cNY_myHWDataSet.DataSetName = "CNY_myHWDataSet";
            this.cNY_myHWDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtPhone
            // 
            this.txtPhone.BackColor = System.Drawing.Color.Cornsilk;
            this.txtPhone.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.orderPersonBindingSource, "電話", true));
            this.txtPhone.Font = new System.Drawing.Font("標楷體", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtPhone.Location = new System.Drawing.Point(156, 150);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(178, 40);
            this.txtPhone.TabIndex = 18;
            // 
            // txtRemark
            // 
            this.txtRemark.BackColor = System.Drawing.Color.Cornsilk;
            this.txtRemark.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.orderPersonBindingSource, "備註", true));
            this.txtRemark.Font = new System.Drawing.Font("標楷體", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtRemark.Location = new System.Drawing.Point(156, 199);
            this.txtRemark.Name = "txtRemark";
            this.txtRemark.Size = new System.Drawing.Size(749, 40);
            this.txtRemark.TabIndex = 19;
            // 
            // btnFirstID
            // 
            this.btnFirstID.BackColor = System.Drawing.Color.Transparent;
            this.btnFirstID.BackgroundImage = global::ChineseNewYear_CHW_38.Properties.Resources.按鈕;
            this.btnFirstID.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnFirstID.FlatAppearance.BorderColor = System.Drawing.Color.Cornsilk;
            this.btnFirstID.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Cornsilk;
            this.btnFirstID.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Crimson;
            this.btnFirstID.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFirstID.Font = new System.Drawing.Font("標楷體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnFirstID.ForeColor = System.Drawing.Color.White;
            this.btnFirstID.Location = new System.Drawing.Point(40, 470);
            this.btnFirstID.Name = "btnFirstID";
            this.btnFirstID.Size = new System.Drawing.Size(144, 43);
            this.btnFirstID.TabIndex = 33;
            this.btnFirstID.Text = "第一筆";
            this.btnFirstID.UseVisualStyleBackColor = false;
            this.btnFirstID.Click += new System.EventHandler(this.btnFirstID_Click);
            // 
            // btnBackID
            // 
            this.btnBackID.BackColor = System.Drawing.Color.Transparent;
            this.btnBackID.BackgroundImage = global::ChineseNewYear_CHW_38.Properties.Resources.按鈕;
            this.btnBackID.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBackID.FlatAppearance.BorderColor = System.Drawing.Color.Cornsilk;
            this.btnBackID.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Cornsilk;
            this.btnBackID.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Crimson;
            this.btnBackID.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBackID.Font = new System.Drawing.Font("標楷體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnBackID.ForeColor = System.Drawing.Color.White;
            this.btnBackID.Location = new System.Drawing.Point(190, 470);
            this.btnBackID.Name = "btnBackID";
            this.btnBackID.Size = new System.Drawing.Size(144, 43);
            this.btnBackID.TabIndex = 34;
            this.btnBackID.Text = "上一筆";
            this.btnBackID.UseVisualStyleBackColor = false;
            this.btnBackID.Click += new System.EventHandler(this.btnBackID_Click);
            // 
            // btnNextID
            // 
            this.btnNextID.BackColor = System.Drawing.Color.Transparent;
            this.btnNextID.BackgroundImage = global::ChineseNewYear_CHW_38.Properties.Resources.按鈕;
            this.btnNextID.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnNextID.FlatAppearance.BorderColor = System.Drawing.Color.Cornsilk;
            this.btnNextID.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Cornsilk;
            this.btnNextID.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Crimson;
            this.btnNextID.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNextID.Font = new System.Drawing.Font("標楷體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnNextID.ForeColor = System.Drawing.Color.White;
            this.btnNextID.Location = new System.Drawing.Point(340, 470);
            this.btnNextID.Name = "btnNextID";
            this.btnNextID.Size = new System.Drawing.Size(144, 43);
            this.btnNextID.TabIndex = 35;
            this.btnNextID.Text = "下一筆";
            this.btnNextID.UseVisualStyleBackColor = false;
            this.btnNextID.Click += new System.EventHandler(this.btnNextID_Click);
            // 
            // btnLastID
            // 
            this.btnLastID.BackColor = System.Drawing.Color.Transparent;
            this.btnLastID.BackgroundImage = global::ChineseNewYear_CHW_38.Properties.Resources.按鈕;
            this.btnLastID.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLastID.FlatAppearance.BorderColor = System.Drawing.Color.Cornsilk;
            this.btnLastID.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Cornsilk;
            this.btnLastID.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Crimson;
            this.btnLastID.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLastID.Font = new System.Drawing.Font("標楷體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnLastID.ForeColor = System.Drawing.Color.White;
            this.btnLastID.Location = new System.Drawing.Point(490, 470);
            this.btnLastID.Name = "btnLastID";
            this.btnLastID.Size = new System.Drawing.Size(144, 43);
            this.btnLastID.TabIndex = 36;
            this.btnLastID.Text = "最後一筆";
            this.btnLastID.UseVisualStyleBackColor = false;
            this.btnLastID.Click += new System.EventHandler(this.btnLastID_Click);
            // 
            // btnSaveFix
            // 
            this.btnSaveFix.BackColor = System.Drawing.Color.Transparent;
            this.btnSaveFix.BackgroundImage = global::ChineseNewYear_CHW_38.Properties.Resources.按鈕;
            this.btnSaveFix.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSaveFix.FlatAppearance.BorderColor = System.Drawing.Color.Cornsilk;
            this.btnSaveFix.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Cornsilk;
            this.btnSaveFix.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Crimson;
            this.btnSaveFix.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveFix.Font = new System.Drawing.Font("標楷體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnSaveFix.ForeColor = System.Drawing.Color.White;
            this.btnSaveFix.Location = new System.Drawing.Point(190, 524);
            this.btnSaveFix.Name = "btnSaveFix";
            this.btnSaveFix.Size = new System.Drawing.Size(144, 43);
            this.btnSaveFix.TabIndex = 37;
            this.btnSaveFix.Text = "儲存修改";
            this.btnSaveFix.UseVisualStyleBackColor = false;
            this.btnSaveFix.Click += new System.EventHandler(this.btnSaveFix_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Transparent;
            this.btnDelete.BackgroundImage = global::ChineseNewYear_CHW_38.Properties.Resources.按鈕;
            this.btnDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDelete.FlatAppearance.BorderColor = System.Drawing.Color.Cornsilk;
            this.btnDelete.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Cornsilk;
            this.btnDelete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Crimson;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("標楷體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(340, 524);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(144, 43);
            this.btnDelete.TabIndex = 38;
            this.btnDelete.Text = "刪除";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnRecoverID
            // 
            this.btnRecoverID.BackColor = System.Drawing.Color.Transparent;
            this.btnRecoverID.BackgroundImage = global::ChineseNewYear_CHW_38.Properties.Resources.按鈕;
            this.btnRecoverID.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRecoverID.FlatAppearance.BorderColor = System.Drawing.Color.Cornsilk;
            this.btnRecoverID.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Cornsilk;
            this.btnRecoverID.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Crimson;
            this.btnRecoverID.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRecoverID.Font = new System.Drawing.Font("標楷體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnRecoverID.ForeColor = System.Drawing.Color.White;
            this.btnRecoverID.Location = new System.Drawing.Point(489, 524);
            this.btnRecoverID.Name = "btnRecoverID";
            this.btnRecoverID.Size = new System.Drawing.Size(144, 43);
            this.btnRecoverID.TabIndex = 39;
            this.btnRecoverID.Text = "回復資料";
            this.btnRecoverID.UseVisualStyleBackColor = false;
            this.btnRecoverID.Click += new System.EventHandler(this.btnRecoverID_Click);
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.Color.Cornsilk;
            this.listBox1.DataSource = this.orderPersonBindingSource;
            this.listBox1.DisplayMember = "姓名";
            this.listBox1.Font = new System.Drawing.Font("微軟正黑體", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 35;
            this.listBox1.Location = new System.Drawing.Point(640, 362);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(265, 144);
            this.listBox1.TabIndex = 43;
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.Color.Cornsilk;
            this.comboBox1.DataSource = this.orderPersonBindingSource;
            this.comboBox1.DisplayMember = "序號";
            this.comboBox1.Font = new System.Drawing.Font("微軟正黑體", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(640, 522);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(265, 43);
            this.comboBox1.TabIndex = 44;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.cBoxFilter);
            this.groupBox1.Controls.Add(this.cBoxFind);
            this.groupBox1.Controls.Add(this.btnFilter);
            this.groupBox1.Controls.Add(this.btnRemoveFilter);
            this.groupBox1.Controls.Add(this.btnFind);
            this.groupBox1.Controls.Add(this.txtFilter);
            this.groupBox1.Controls.Add(this.txtFind);
            this.groupBox1.Font = new System.Drawing.Font("標楷體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(354, 31);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(551, 159);
            this.groupBox1.TabIndex = 45;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "搜尋訂購人資料";
            // 
            // cBoxFilter
            // 
            this.cBoxFilter.BackColor = System.Drawing.Color.Cornsilk;
            this.cBoxFilter.FormattingEnabled = true;
            this.cBoxFilter.Location = new System.Drawing.Point(156, 101);
            this.cBoxFilter.Name = "cBoxFilter";
            this.cBoxFilter.Size = new System.Drawing.Size(103, 31);
            this.cBoxFilter.TabIndex = 5;
            // 
            // cBoxFind
            // 
            this.cBoxFind.BackColor = System.Drawing.Color.Cornsilk;
            this.cBoxFind.FormattingEnabled = true;
            this.cBoxFind.Location = new System.Drawing.Point(156, 51);
            this.cBoxFind.Name = "cBoxFind";
            this.cBoxFind.Size = new System.Drawing.Size(103, 31);
            this.cBoxFind.TabIndex = 4;
            // 
            // btnFilter
            // 
            this.btnFilter.BackColor = System.Drawing.Color.Transparent;
            this.btnFilter.BackgroundImage = global::ChineseNewYear_CHW_38.Properties.Resources.按鈕;
            this.btnFilter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnFilter.FlatAppearance.BorderColor = System.Drawing.Color.Cornsilk;
            this.btnFilter.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Cornsilk;
            this.btnFilter.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Crimson;
            this.btnFilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFilter.Font = new System.Drawing.Font("標楷體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnFilter.Location = new System.Drawing.Point(265, 98);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(133, 35);
            this.btnFilter.TabIndex = 3;
            this.btnFilter.Text = "模糊搜尋";
            this.btnFilter.UseVisualStyleBackColor = false;
            this.btnFilter.Click += new System.EventHandler(this.btnFilter_Click);
            // 
            // btnRemoveFilter
            // 
            this.btnRemoveFilter.BackgroundImage = global::ChineseNewYear_CHW_38.Properties.Resources.按鈕;
            this.btnRemoveFilter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRemoveFilter.FlatAppearance.BorderColor = System.Drawing.Color.Cornsilk;
            this.btnRemoveFilter.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Cornsilk;
            this.btnRemoveFilter.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Crimson;
            this.btnRemoveFilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemoveFilter.Font = new System.Drawing.Font("標楷體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnRemoveFilter.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnRemoveFilter.Location = new System.Drawing.Point(414, 50);
            this.btnRemoveFilter.Name = "btnRemoveFilter";
            this.btnRemoveFilter.Size = new System.Drawing.Size(121, 83);
            this.btnRemoveFilter.TabIndex = 42;
            this.btnRemoveFilter.Text = "移除模糊搜尋條件";
            this.btnRemoveFilter.UseVisualStyleBackColor = false;
            this.btnRemoveFilter.Click += new System.EventHandler(this.btnRemoveFilter_Click);
            // 
            // btnFind
            // 
            this.btnFind.BackColor = System.Drawing.Color.Transparent;
            this.btnFind.BackgroundImage = global::ChineseNewYear_CHW_38.Properties.Resources.按鈕;
            this.btnFind.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnFind.FlatAppearance.BorderColor = System.Drawing.Color.Cornsilk;
            this.btnFind.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Cornsilk;
            this.btnFind.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Crimson;
            this.btnFind.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFind.Font = new System.Drawing.Font("標楷體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnFind.ForeColor = System.Drawing.Color.White;
            this.btnFind.Location = new System.Drawing.Point(265, 49);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(133, 35);
            this.btnFind.TabIndex = 2;
            this.btnFind.Text = "指定搜尋";
            this.btnFind.UseVisualStyleBackColor = false;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // txtFilter
            // 
            this.txtFilter.BackColor = System.Drawing.Color.Cornsilk;
            this.txtFilter.Location = new System.Drawing.Point(19, 100);
            this.txtFilter.Name = "txtFilter";
            this.txtFilter.Size = new System.Drawing.Size(131, 35);
            this.txtFilter.TabIndex = 1;
            // 
            // txtFind
            // 
            this.txtFind.BackColor = System.Drawing.Color.Cornsilk;
            this.txtFind.Location = new System.Drawing.Point(19, 49);
            this.txtFind.Name = "txtFind";
            this.txtFind.Size = new System.Drawing.Size(131, 35);
            this.txtFind.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("華康行楷體W5(P)", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(28, 255);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 28);
            this.label1.TabIndex = 46;
            this.label1.Text = "訂購內容";
            // 
            // txtID
            // 
            this.txtID.BackColor = System.Drawing.Color.Cornsilk;
            this.txtID.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.orderPersonBindingSource, "序號", true));
            this.txtID.Font = new System.Drawing.Font("標楷體", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtID.Location = new System.Drawing.Point(156, 49);
            this.txtID.Name = "txtID";
            this.txtID.ReadOnly = true;
            this.txtID.Size = new System.Drawing.Size(99, 40);
            this.txtID.TabIndex = 49;
            this.txtID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label5.Font = new System.Drawing.Font("華康行楷體W5(P)", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(82, 53);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 30);
            this.label5.TabIndex = 48;
            this.label5.Text = "序號";
            // 
            // btnFix
            // 
            this.btnFix.BackColor = System.Drawing.Color.Transparent;
            this.btnFix.BackgroundImage = global::ChineseNewYear_CHW_38.Properties.Resources.按鈕;
            this.btnFix.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnFix.FlatAppearance.BorderColor = System.Drawing.Color.Cornsilk;
            this.btnFix.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Cornsilk;
            this.btnFix.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Crimson;
            this.btnFix.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFix.Font = new System.Drawing.Font("標楷體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnFix.ForeColor = System.Drawing.Color.White;
            this.btnFix.Location = new System.Drawing.Point(40, 524);
            this.btnFix.Name = "btnFix";
            this.btnFix.Size = new System.Drawing.Size(144, 43);
            this.btnFix.TabIndex = 61;
            this.btnFix.Text = "訂單修改";
            this.btnFix.UseVisualStyleBackColor = false;
            this.btnFix.Click += new System.EventHandler(this.btnFix_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("標楷體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(638, 253);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(161, 24);
            this.label10.TabIndex = 66;
            this.label10.Text = "佛跳牆(含甕)";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("標楷體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(638, 305);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(186, 24);
            this.label11.TabIndex = 67;
            this.label11.Text = "佛跳牆(不含甕)";
            // 
            // txtDishesYes
            // 
            this.txtDishesYes.BackColor = System.Drawing.Color.Cornsilk;
            this.txtDishesYes.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.orderPersonBindingSource, "干貝佛跳牆(含甕", true));
            this.txtDishesYes.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtDishesYes.Location = new System.Drawing.Point(845, 248);
            this.txtDishesYes.Name = "txtDishesYes";
            this.txtDishesYes.Size = new System.Drawing.Size(60, 38);
            this.txtDishesYes.TabIndex = 82;
            this.txtDishesYes.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtDishesNo
            // 
            this.txtDishesNo.BackColor = System.Drawing.Color.Cornsilk;
            this.txtDishesNo.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.orderPersonBindingSource, "干貝佛跳牆(不含甕", true));
            this.txtDishesNo.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtDishesNo.Location = new System.Drawing.Point(845, 300);
            this.txtDishesNo.Name = "txtDishesNo";
            this.txtDishesNo.Size = new System.Drawing.Size(60, 38);
            this.txtDishesNo.TabIndex = 83;
            this.txtDishesNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("標楷體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(157, 257);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(148, 24);
            this.label6.TabIndex = 62;
            this.label6.Text = "甘蔗香燻雞 ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("標楷體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(157, 363);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(136, 24);
            this.label7.TabIndex = 63;
            this.label7.Text = "筍干Q蹄膀 ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("標楷體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(155, 415);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(135, 24);
            this.label8.TabIndex = 64;
            this.label8.Text = "魚翅蝦仁羹";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("標楷體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(157, 311);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(148, 24);
            this.label9.TabIndex = 65;
            this.label9.Text = "糖醋海鱸魚 ";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("標楷體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(401, 259);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(135, 24);
            this.label12.TabIndex = 68;
            this.label12.Text = "櫻花蝦米糕";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("標楷體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(401, 311);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(148, 24);
            this.label13.TabIndex = 69;
            this.label13.Text = "蜜汁全排骨 ";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Font = new System.Drawing.Font("標楷體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label14.ForeColor = System.Drawing.Color.White;
            this.label14.Location = new System.Drawing.Point(401, 368);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(135, 24);
            this.label14.TabIndex = 70;
            this.label14.Text = "白雪旗魚丸";
            // 
            // txtDishes1
            // 
            this.txtDishes1.BackColor = System.Drawing.Color.Cornsilk;
            this.txtDishes1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.orderPersonBindingSource, "甘蔗香燻雞", true));
            this.txtDishes1.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtDishes1.Location = new System.Drawing.Point(310, 252);
            this.txtDishes1.Name = "txtDishes1";
            this.txtDishes1.Size = new System.Drawing.Size(59, 38);
            this.txtDishes1.TabIndex = 71;
            this.txtDishes1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtDishes2
            // 
            this.txtDishes2.BackColor = System.Drawing.Color.Cornsilk;
            this.txtDishes2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.orderPersonBindingSource, "糖醋海鱸魚", true));
            this.txtDishes2.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtDishes2.Location = new System.Drawing.Point(310, 304);
            this.txtDishes2.Name = "txtDishes2";
            this.txtDishes2.Size = new System.Drawing.Size(59, 38);
            this.txtDishes2.TabIndex = 72;
            this.txtDishes2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtDishes3
            // 
            this.txtDishes3.BackColor = System.Drawing.Color.Cornsilk;
            this.txtDishes3.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.orderPersonBindingSource, "筍干Q蹄膀", true));
            this.txtDishes3.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtDishes3.Location = new System.Drawing.Point(310, 357);
            this.txtDishes3.Name = "txtDishes3";
            this.txtDishes3.Size = new System.Drawing.Size(59, 38);
            this.txtDishes3.TabIndex = 73;
            this.txtDishes3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtDishes4
            // 
            this.txtDishes4.BackColor = System.Drawing.Color.Cornsilk;
            this.txtDishes4.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.orderPersonBindingSource, "魚翅蝦仁羹", true));
            this.txtDishes4.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtDishes4.Location = new System.Drawing.Point(310, 412);
            this.txtDishes4.Name = "txtDishes4";
            this.txtDishes4.Size = new System.Drawing.Size(59, 38);
            this.txtDishes4.TabIndex = 76;
            this.txtDishes4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.label15.Font = new System.Drawing.Font("標楷體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label15.ForeColor = System.Drawing.Color.White;
            this.label15.Location = new System.Drawing.Point(401, 417);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(135, 24);
            this.label15.TabIndex = 77;
            this.label15.Text = "極鮮旗魚卷";
            // 
            // txtDishes5
            // 
            this.txtDishes5.BackColor = System.Drawing.Color.Cornsilk;
            this.txtDishes5.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.orderPersonBindingSource, "櫻花蝦米糕", true));
            this.txtDishes5.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtDishes5.Location = new System.Drawing.Point(554, 254);
            this.txtDishes5.Name = "txtDishes5";
            this.txtDishes5.Size = new System.Drawing.Size(56, 38);
            this.txtDishes5.TabIndex = 78;
            this.txtDishes5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtDishes6
            // 
            this.txtDishes6.BackColor = System.Drawing.Color.Cornsilk;
            this.txtDishes6.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.orderPersonBindingSource, "蜜汁全排骨", true));
            this.txtDishes6.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtDishes6.Location = new System.Drawing.Point(554, 306);
            this.txtDishes6.Name = "txtDishes6";
            this.txtDishes6.Size = new System.Drawing.Size(56, 38);
            this.txtDishes6.TabIndex = 79;
            this.txtDishes6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtDishes7
            // 
            this.txtDishes7.BackColor = System.Drawing.Color.Cornsilk;
            this.txtDishes7.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.orderPersonBindingSource, "白雪旗魚丸", true));
            this.txtDishes7.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtDishes7.Location = new System.Drawing.Point(554, 359);
            this.txtDishes7.Name = "txtDishes7";
            this.txtDishes7.Size = new System.Drawing.Size(56, 38);
            this.txtDishes7.TabIndex = 80;
            this.txtDishes7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtDishes8
            // 
            this.txtDishes8.BackColor = System.Drawing.Color.Cornsilk;
            this.txtDishes8.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.orderPersonBindingSource, "極鮮旗魚卷", true));
            this.txtDishes8.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtDishes8.Location = new System.Drawing.Point(554, 414);
            this.txtDishes8.Name = "txtDishes8";
            this.txtDishes8.Size = new System.Drawing.Size(56, 38);
            this.txtDishes8.TabIndex = 81;
            this.txtDishes8.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // orderPersonTableAdapter
            // 
            this.orderPersonTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.OrderPersonTableAdapter = this.orderPersonTableAdapter;
            this.tableAdapterManager.UpdateOrder = ChineseNewYear_CHW_38.CNY_myHWDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // Form2_Order
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.BackgroundImage = global::ChineseNewYear_CHW_38.Properties.Resources.分頁_2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(950, 600);
            this.Controls.Add(this.txtDishesNo);
            this.Controls.Add(this.txtDishesYes);
            this.Controls.Add(this.txtDishes8);
            this.Controls.Add(this.txtDishes7);
            this.Controls.Add(this.txtDishes6);
            this.Controls.Add(this.txtDishes5);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.txtDishes4);
            this.Controls.Add(this.txtDishes3);
            this.Controls.Add(this.txtDishes2);
            this.Controls.Add(this.txtDishes1);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnFix);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.txtRemark);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnRecoverID);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnSaveFix);
            this.Controls.Add(this.btnLastID);
            this.Controls.Add(this.btnNextID);
            this.Controls.Add(this.btnBackID);
            this.Controls.Add(this.btnFirstID);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "Form2_Order";
            this.Text = "訂購人資料";
            this.Load += new System.EventHandler(this.Form2_Order_Load);
            ((System.ComponentModel.ISupportInitialize)(this.orderPersonBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cNY_myHWDataSet)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtRemark;
        private System.Windows.Forms.Button btnFirstID;
        private System.Windows.Forms.Button btnBackID;
        private System.Windows.Forms.Button btnNextID;
        private System.Windows.Forms.Button btnLastID;
        private System.Windows.Forms.Button btnSaveFix;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnRecoverID;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cBoxFilter;
        private System.Windows.Forms.ComboBox cBoxFind;
        private System.Windows.Forms.Button btnFilter;
        private System.Windows.Forms.Button btnRemoveFilter;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.TextBox txtFilter;
        private System.Windows.Forms.TextBox txtFind;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnFix;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtDishesYes;
        private System.Windows.Forms.TextBox txtDishesNo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtDishes1;
        private System.Windows.Forms.TextBox txtDishes2;
        private System.Windows.Forms.TextBox txtDishes3;
        private System.Windows.Forms.TextBox txtDishes4;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtDishes5;
        private System.Windows.Forms.TextBox txtDishes6;
        private System.Windows.Forms.TextBox txtDishes7;
        private System.Windows.Forms.TextBox txtDishes8;
        private CNY_myHWDataSet cNY_myHWDataSet;
        private System.Windows.Forms.BindingSource orderPersonBindingSource;
        private CNY_myHWDataSetTableAdapters.OrderPersonTableAdapter orderPersonTableAdapter;
        private CNY_myHWDataSetTableAdapters.TableAdapterManager tableAdapterManager;
    }
}