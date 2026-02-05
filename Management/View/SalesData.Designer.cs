namespace Management
{
    partial class SalesData
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
            groupBox1 = new GroupBox();
            ProductName_txt = new TextBox();
            ProductNumber_txt = new TextBox();
            cbxOther = new CheckBox();
            cbxLiving = new CheckBox();
            cbxEquipment = new CheckBox();
            cbxFood = new CheckBox();
            dtpEnd = new DateTimePicker();
            label5 = new Label();
            dtpStart = new DateTimePicker();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            search_btn = new Button();
            clear_btn = new Button();
            dgvResult = new DataGridView();
            sale_date = new DataGridViewTextBoxColumn();
            category = new DataGridViewTextBoxColumn();
            item_no = new DataGridViewTextBoxColumn();
            item_name = new DataGridViewTextBoxColumn();
            quantity = new DataGridViewTextBoxColumn();
            discount = new DataGridViewTextBoxColumn();
            amount = new DataGridViewTextBoxColumn();
            label6 = new Label();
            update_btn = new Button();
            close_btn = new Button();
            data_btn = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvResult).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(ProductName_txt);
            groupBox1.Controls.Add(ProductNumber_txt);
            groupBox1.Controls.Add(cbxOther);
            groupBox1.Controls.Add(cbxLiving);
            groupBox1.Controls.Add(cbxEquipment);
            groupBox1.Controls.Add(cbxFood);
            groupBox1.Controls.Add(dtpEnd);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(dtpStart);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(11, 44);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(489, 202);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "検索条件";
            // 
            // ProductName_txt
            // 
            ProductName_txt.Location = new Point(112, 129);
            ProductName_txt.MaxLength = 30;
            ProductName_txt.Name = "ProductName_txt";
            ProductName_txt.Size = new Size(247, 23);
            ProductName_txt.TabIndex = 12;
            // 
            // ProductNumber_txt
            // 
            ProductNumber_txt.ImeMode = ImeMode.Disable;
            ProductNumber_txt.Location = new Point(112, 95);
            ProductNumber_txt.MaxLength = 5;
            ProductNumber_txt.Name = "ProductNumber_txt";
            ProductNumber_txt.Size = new Size(247, 23);
            ProductNumber_txt.TabIndex = 11;
            ProductNumber_txt.KeyPress += NumericalInputControl;
            // 
            // cbxOther
            // 
            cbxOther.AutoSize = true;
            cbxOther.Checked = true;
            cbxOther.CheckState = CheckState.Checked;
            cbxOther.Location = new Point(316, 61);
            cbxOther.Name = "cbxOther";
            cbxOther.Size = new Size(81, 19);
            cbxOther.TabIndex = 10;
            cbxOther.Text = "その他用品";
            cbxOther.UseVisualStyleBackColor = true;
            // 
            // cbxLiving
            // 
            cbxLiving.AutoSize = true;
            cbxLiving.Checked = true;
            cbxLiving.CheckState = CheckState.Checked;
            cbxLiving.Location = new Point(236, 61);
            cbxLiving.Name = "cbxLiving";
            cbxLiving.Size = new Size(74, 19);
            cbxLiving.TabIndex = 9;
            cbxLiving.Text = "生活用品";
            cbxLiving.UseVisualStyleBackColor = true;
            // 
            // cbxEquipment
            // 
            cbxEquipment.AutoSize = true;
            cbxEquipment.Checked = true;
            cbxEquipment.CheckState = CheckState.Checked;
            cbxEquipment.Location = new Point(180, 62);
            cbxEquipment.Name = "cbxEquipment";
            cbxEquipment.Size = new Size(50, 19);
            cbxEquipment.TabIndex = 8;
            cbxEquipment.Text = "機器";
            cbxEquipment.UseVisualStyleBackColor = true;
            // 
            // cbxFood
            // 
            cbxFood.AutoSize = true;
            cbxFood.Checked = true;
            cbxFood.CheckState = CheckState.Checked;
            cbxFood.Location = new Point(112, 62);
            cbxFood.Name = "cbxFood";
            cbxFood.Size = new Size(62, 19);
            cbxFood.TabIndex = 7;
            cbxFood.Text = "食料品";
            cbxFood.UseVisualStyleBackColor = true;
            // 
            // dtpEnd
            // 
            dtpEnd.CustomFormat = "yyyy/MM";
            dtpEnd.Format = DateTimePickerFormat.Custom;
            dtpEnd.Location = new Point(251, 21);
            dtpEnd.Name = "dtpEnd";
            dtpEnd.ShowUpDown = true;
            dtpEnd.Size = new Size(108, 23);
            dtpEnd.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(226, 27);
            label5.Name = "label5";
            label5.Size = new Size(19, 15);
            label5.TabIndex = 5;
            label5.Text = "～";
            // 
            // dtpStart
            // 
            dtpStart.Checked = false;
            dtpStart.CustomFormat = "yyyy/MM";
            dtpStart.Format = DateTimePickerFormat.Custom;
            dtpStart.Location = new Point(112, 21);
            dtpStart.Name = "dtpStart";
            dtpStart.ShowUpDown = true;
            dtpStart.Size = new Size(108, 23);
            dtpStart.TabIndex = 7;
            // 
            // label4
            // 
            label4.BackColor = SystemColors.ActiveBorder;
            label4.Font = new Font("Yu Gothic UI", 9F);
            label4.Location = new Point(6, 129);
            label4.Name = "label4";
            label4.Size = new Size(90, 20);
            label4.TabIndex = 3;
            label4.Text = "商品名";
            label4.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            label3.BackColor = SystemColors.ActiveBorder;
            label3.Font = new Font("Yu Gothic UI", 9F);
            label3.Location = new Point(6, 95);
            label3.Name = "label3";
            label3.Size = new Size(90, 20);
            label3.TabIndex = 2;
            label3.Text = "商品番号";
            label3.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            label2.BackColor = SystemColors.ActiveBorder;
            label2.Font = new Font("Yu Gothic UI", 9F);
            label2.Location = new Point(6, 60);
            label2.Name = "label2";
            label2.Size = new Size(90, 20);
            label2.TabIndex = 1;
            label2.Text = "商品分類";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            label1.BackColor = SystemColors.ActiveBorder;
            label1.Font = new Font("Yu Gothic UI", 9F);
            label1.Location = new Point(6, 24);
            label1.Name = "label1";
            label1.Padding = new Padding(0, 0, 30, 0);
            label1.Size = new Size(90, 20);
            label1.TabIndex = 0;
            label1.Text = "期間";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // search_btn
            // 
            search_btn.Location = new Point(536, 191);
            search_btn.Name = "search_btn";
            search_btn.Size = new Size(90, 55);
            search_btn.TabIndex = 1;
            search_btn.Text = "検索";
            search_btn.UseVisualStyleBackColor = true;
            search_btn.Click += search_btn_Click;
            // 
            // clear_btn
            // 
            clear_btn.Location = new Point(638, 191);
            clear_btn.Name = "clear_btn";
            clear_btn.Size = new Size(90, 55);
            clear_btn.TabIndex = 2;
            clear_btn.Text = "条件クリア";
            clear_btn.UseVisualStyleBackColor = true;
            clear_btn.Click += clear_btn_Click;
            // 
            // dgvResult
            // 
            dgvResult.AllowUserToDeleteRows = false;
            dgvResult.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvResult.Columns.AddRange(new DataGridViewColumn[] { sale_date, category, item_no, item_name, quantity, discount, amount });
            dgvResult.Location = new Point(12, 262);
            dgvResult.Name = "dgvResult";
            dgvResult.ReadOnly = true;
            dgvResult.Size = new Size(752, 271);
            dgvResult.TabIndex = 3;
            // 
            // sale_date
            // 
            sale_date.HeaderText = "販売日時";
            sale_date.Name = "sale_date";
            sale_date.ReadOnly = true;
            // 
            // category
            // 
            category.HeaderText = "分類";
            category.Name = "category";
            category.ReadOnly = true;
            // 
            // item_no
            // 
            item_no.HeaderText = "商品番号";
            item_no.Name = "item_no";
            item_no.ReadOnly = true;
            // 
            // item_name
            // 
            item_name.HeaderText = "商品名";
            item_name.Name = "item_name";
            item_name.ReadOnly = true;
            // 
            // quantity
            // 
            quantity.HeaderText = "売上数量";
            quantity.Name = "quantity";
            quantity.ReadOnly = true;
            // 
            // discount
            // 
            discount.HeaderText = "割引適用額";
            discount.Name = "discount";
            discount.ReadOnly = true;
            // 
            // amount
            // 
            amount.HeaderText = "売上額";
            amount.Name = "amount";
            amount.ReadOnly = true;
            // 
            // label6
            // 
            label6.Font = new Font("Yu Gothic UI", 10F);
            label6.Location = new Point(11, 9);
            label6.Name = "label6";
            label6.Size = new Size(83, 32);
            label6.TabIndex = 4;
            label6.Text = "売上管理";
            label6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // update_btn
            // 
            update_btn.Enabled = false;
            update_btn.Location = new Point(536, 549);
            update_btn.Name = "update_btn";
            update_btn.Size = new Size(90, 36);
            update_btn.TabIndex = 5;
            update_btn.Text = "更新";
            update_btn.UseVisualStyleBackColor = true;
            update_btn.Click += update_btn_Click;
            // 
            // close_btn
            // 
            close_btn.Location = new Point(638, 549);
            close_btn.Name = "close_btn";
            close_btn.Size = new Size(90, 36);
            close_btn.TabIndex = 6;
            close_btn.Text = "閉じる";
            close_btn.UseVisualStyleBackColor = true;
            close_btn.Click += close_btn_Click;
            // 
            // data_btn
            // 
            data_btn.Location = new Point(17, 549);
            data_btn.Name = "data_btn";
            data_btn.Size = new Size(168, 36);
            data_btn.TabIndex = 7;
            data_btn.Text = "売上データ送信";
            data_btn.UseVisualStyleBackColor = true;
            data_btn.Click += data_btn_Click;
            // 
            // SalesData
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(781, 597);
            Controls.Add(data_btn);
            Controls.Add(close_btn);
            Controls.Add(update_btn);
            Controls.Add(label6);
            Controls.Add(dgvResult);
            Controls.Add(clear_btn);
            Controls.Add(search_btn);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "SalesData";
            Text = "売上管理";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvResult).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label label1;
        private Button search_btn;
        private Button clear_btn;
        private CheckBox cbxFood;
        private DateTimePicker dtpEnd;
        private Label label5;
        private DateTimePicker dtpStart;
        private Label label4;
        private Label label3;
        private Label label2;
        private CheckBox cbxOther;
        private CheckBox cbxLiving;
        private CheckBox cbxEquipment;
        private TextBox ProductName_txt;
        private TextBox ProductNumber_txt;
        private DataGridView dgvResult;
        private Label label6;
        private Button update_btn;
        private Button close_btn;
        private Button data_btn;
        private DataGridViewTextBoxColumn sale_date;
        private DataGridViewTextBoxColumn category;
        private DataGridViewTextBoxColumn item_no;
        private DataGridViewTextBoxColumn item_name;
        private DataGridViewTextBoxColumn quantity;
        private DataGridViewTextBoxColumn discount;
        private DataGridViewTextBoxColumn amount;
    }
}