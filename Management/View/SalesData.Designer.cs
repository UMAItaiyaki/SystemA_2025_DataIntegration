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
            checkBox4 = new CheckBox();
            checkBox3 = new CheckBox();
            checkBox2 = new CheckBox();
            checkBox1 = new CheckBox();
            dateTimePicker2 = new DateTimePicker();
            label5 = new Label();
            dateTimePicker1 = new DateTimePicker();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            search_btn = new Button();
            clear_btn = new Button();
            dataGridView1 = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            Column7 = new DataGridViewTextBoxColumn();
            label6 = new Label();
            update_btn = new Button();
            close_btn = new Button();
            data_btn = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(ProductName_txt);
            groupBox1.Controls.Add(ProductNumber_txt);
            groupBox1.Controls.Add(checkBox4);
            groupBox1.Controls.Add(checkBox3);
            groupBox1.Controls.Add(checkBox2);
            groupBox1.Controls.Add(checkBox1);
            groupBox1.Controls.Add(dateTimePicker2);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(dateTimePicker1);
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
            // checkBox4
            // 
            checkBox4.AutoSize = true;
            checkBox4.Checked = true;
            checkBox4.CheckState = CheckState.Checked;
            checkBox4.Location = new Point(316, 61);
            checkBox4.Name = "checkBox4";
            checkBox4.Size = new Size(81, 19);
            checkBox4.TabIndex = 10;
            checkBox4.Text = "その他用品";
            checkBox4.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            checkBox3.AutoSize = true;
            checkBox3.Checked = true;
            checkBox3.CheckState = CheckState.Checked;
            checkBox3.Location = new Point(236, 61);
            checkBox3.Name = "checkBox3";
            checkBox3.Size = new Size(74, 19);
            checkBox3.TabIndex = 9;
            checkBox3.Text = "生活用品";
            checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Checked = true;
            checkBox2.CheckState = CheckState.Checked;
            checkBox2.Location = new Point(180, 62);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(50, 19);
            checkBox2.TabIndex = 8;
            checkBox2.Text = "機器";
            checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Checked = true;
            checkBox1.CheckState = CheckState.Checked;
            checkBox1.Location = new Point(112, 62);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(62, 19);
            checkBox1.TabIndex = 7;
            checkBox1.Text = "食料品";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Checked = false;
            dateTimePicker2.CustomFormat = "yyyy/MM";
            dateTimePicker2.Format = DateTimePickerFormat.Custom;
            dateTimePicker2.Location = new Point(251, 21);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(108, 23);
            dateTimePicker2.TabIndex = 2;
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
            // dateTimePicker1
            // 
            dateTimePicker1.Checked = false;
            dateTimePicker1.CustomFormat = "yyyy/MM";
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.Location = new Point(112, 21);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(108, 23);
            dateTimePicker1.TabIndex = 2;
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
            // 
            // clear_btn
            // 
            clear_btn.Location = new Point(638, 191);
            clear_btn.Name = "clear_btn";
            clear_btn.Size = new Size(90, 55);
            clear_btn.TabIndex = 2;
            clear_btn.Text = "条件クリア";
            clear_btn.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5, Column6, Column7 });
            dataGridView1.Location = new Point(12, 262);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.Size = new Size(752, 271);
            dataGridView1.TabIndex = 3;
            // 
            // Column1
            // 
            Column1.HeaderText = "販売日時";
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            // 
            // Column2
            // 
            Column2.HeaderText = "分類";
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            // 
            // Column3
            // 
            Column3.HeaderText = "商品番号";
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            // 
            // Column4
            // 
            Column4.HeaderText = "商品名";
            Column4.Name = "Column4";
            Column4.ReadOnly = true;
            // 
            // Column5
            // 
            Column5.HeaderText = "売上数量";
            Column5.Name = "Column5";
            Column5.ReadOnly = true;
            // 
            // Column6
            // 
            Column6.HeaderText = "割引適用額";
            Column6.Name = "Column6";
            Column6.ReadOnly = true;
            // 
            // Column7
            // 
            Column7.HeaderText = "売上額";
            Column7.Name = "Column7";
            Column7.ReadOnly = true;
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
            Controls.Add(dataGridView1);
            Controls.Add(clear_btn);
            Controls.Add(search_btn);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "SalesData";
            Text = "売上管理";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label label1;
        private Button search_btn;
        private Button clear_btn;
        private CheckBox checkBox1;
        private DateTimePicker dateTimePicker2;
        private Label label5;
        private DateTimePicker dateTimePicker1;
        private Label label4;
        private Label label3;
        private Label label2;
        private CheckBox checkBox4;
        private CheckBox checkBox3;
        private CheckBox checkBox2;
        private TextBox ProductName_txt;
        private TextBox ProductNumber_txt;
        private DataGridView dataGridView1;
        private Label label6;
        private Button update_btn;
        private Button close_btn;
        private Button data_btn;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn Column7;
    }
}