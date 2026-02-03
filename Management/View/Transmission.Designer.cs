namespace Management
{
    partial class Transmission
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
            label1 = new Label();
            groupBox1 = new GroupBox();
            checkBox3 = new CheckBox();
            checkBox2 = new CheckBox();
            checkBox1 = new CheckBox();
            label5 = new Label();
            reception_checkbox = new CheckBox();
            send_checkbox = new CheckBox();
            label4 = new Label();
            label3 = new Label();
            dtpEnd = new DateTimePicker();
            dtpStart = new DateTimePicker();
            label2 = new Label();
            clear_btn = new Button();
            search_btn = new Button();
            dataGridView1 = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            close_btn = new Button();
            update_btn = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Font = new Font("Yu Gothic UI", 10F);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(83, 32);
            label1.TabIndex = 5;
            label1.Text = "送受信管理";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(checkBox3);
            groupBox1.Controls.Add(checkBox2);
            groupBox1.Controls.Add(checkBox1);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(reception_checkbox);
            groupBox1.Controls.Add(send_checkbox);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(dtpEnd);
            groupBox1.Controls.Add(dtpStart);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(12, 44);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(489, 202);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            groupBox1.Text = "検索条件";
            // 
            // checkBox3
            // 
            checkBox3.AutoSize = true;
            checkBox3.Checked = true;
            checkBox3.CheckState = CheckState.Checked;
            checkBox3.Location = new Point(268, 123);
            checkBox3.Name = "checkBox3";
            checkBox3.Size = new Size(50, 19);
            checkBox3.TabIndex = 11;
            checkBox3.Text = "異常";
            checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Checked = true;
            checkBox2.CheckState = CheckState.Checked;
            checkBox2.Location = new Point(191, 123);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(71, 19);
            checkBox2.TabIndex = 10;
            checkBox2.Text = "再送待ち";
            checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Checked = true;
            checkBox1.CheckState = CheckState.Checked;
            checkBox1.Location = new Point(112, 123);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(73, 19);
            checkBox1.TabIndex = 9;
            checkBox1.Text = "処理済み";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            label5.BackColor = SystemColors.ActiveBorder;
            label5.Font = new Font("Yu Gothic UI", 9F);
            label5.Location = new Point(6, 119);
            label5.Name = "label5";
            label5.Padding = new Padding(0, 0, 30, 0);
            label5.Size = new Size(90, 25);
            label5.TabIndex = 8;
            label5.Text = "ステータス";
            label5.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // reception_checkbox
            // 
            reception_checkbox.AutoSize = true;
            reception_checkbox.Checked = true;
            reception_checkbox.CheckState = CheckState.Checked;
            reception_checkbox.Location = new Point(194, 76);
            reception_checkbox.Name = "reception_checkbox";
            reception_checkbox.Size = new Size(50, 19);
            reception_checkbox.TabIndex = 7;
            reception_checkbox.Text = "受信";
            reception_checkbox.UseVisualStyleBackColor = true;
            // 
            // send_checkbox
            // 
            send_checkbox.AutoSize = true;
            send_checkbox.Checked = true;
            send_checkbox.CheckState = CheckState.Checked;
            send_checkbox.Location = new Point(112, 76);
            send_checkbox.Name = "send_checkbox";
            send_checkbox.Size = new Size(50, 19);
            send_checkbox.TabIndex = 6;
            send_checkbox.Text = "送信";
            send_checkbox.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.BackColor = SystemColors.ActiveBorder;
            label4.Font = new Font("Yu Gothic UI", 9F);
            label4.Location = new Point(6, 72);
            label4.Name = "label4";
            label4.Padding = new Padding(0, 0, 30, 0);
            label4.Size = new Size(90, 25);
            label4.TabIndex = 5;
            label4.Text = "分類";
            label4.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(215, 34);
            label3.Name = "label3";
            label3.Size = new Size(19, 15);
            label3.TabIndex = 4;
            label3.Text = "～";
            // 
            // dtpEnd
            // 
            dtpEnd.CustomFormat = "yyyy/MM";
            dtpEnd.Format = DateTimePickerFormat.Custom;
            dtpEnd.Location = new Point(240, 31);
            dtpEnd.Name = "dtpEnd";
            dtpEnd.Size = new Size(107, 23);
            dtpEnd.TabIndex = 3;
            // 
            // dtpStart
            // 
            dtpStart.CustomFormat = "yyyy/MM";
            dtpStart.Format = DateTimePickerFormat.Custom;
            dtpStart.Location = new Point(102, 31);
            dtpStart.Name = "dtpStart";
            dtpStart.Size = new Size(107, 23);
            dtpStart.TabIndex = 2;
            // 
            // label2
            // 
            label2.BackColor = SystemColors.ActiveBorder;
            label2.Font = new Font("Yu Gothic UI", 9F);
            label2.Location = new Point(6, 29);
            label2.Name = "label2";
            label2.Padding = new Padding(0, 0, 30, 0);
            label2.Size = new Size(90, 25);
            label2.TabIndex = 1;
            label2.Text = "期間";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // clear_btn
            // 
            clear_btn.Location = new Point(644, 191);
            clear_btn.Name = "clear_btn";
            clear_btn.Size = new Size(90, 55);
            clear_btn.TabIndex = 8;
            clear_btn.Text = "条件クリア";
            clear_btn.UseVisualStyleBackColor = true;
            // 
            // search_btn
            // 
            search_btn.Location = new Point(542, 191);
            search_btn.Name = "search_btn";
            search_btn.Size = new Size(90, 55);
            search_btn.TabIndex = 7;
            search_btn.Text = "検索";
            search_btn.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5 });
            dataGridView1.Location = new Point(12, 252);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.Size = new Size(757, 291);
            dataGridView1.TabIndex = 9;
            // 
            // Column1
            // 
            Column1.HeaderText = "処理日時";
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
            Column3.HeaderText = "ファイル名";
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            // 
            // Column4
            // 
            Column4.HeaderText = "ステータス";
            Column4.Name = "Column4";
            Column4.ReadOnly = true;
            // 
            // Column5
            // 
            Column5.HeaderText = "出力メッセージ";
            Column5.Name = "Column5";
            Column5.ReadOnly = true;
            // 
            // close_btn
            // 
            close_btn.Location = new Point(644, 549);
            close_btn.Name = "close_btn";
            close_btn.Size = new Size(90, 36);
            close_btn.TabIndex = 11;
            close_btn.Text = "閉じる";
            close_btn.UseVisualStyleBackColor = true;
            close_btn.Click += close_btn_Click;
            // 
            // update_btn
            // 
            update_btn.Enabled = false;
            update_btn.Location = new Point(542, 549);
            update_btn.Name = "update_btn";
            update_btn.Size = new Size(90, 36);
            update_btn.TabIndex = 10;
            update_btn.Text = "更新";
            update_btn.UseVisualStyleBackColor = true;
            // 
            // Transmission
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(781, 597);
            Controls.Add(close_btn);
            Controls.Add(update_btn);
            Controls.Add(dataGridView1);
            Controls.Add(clear_btn);
            Controls.Add(search_btn);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Transmission";
            Text = "送受信管理";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private GroupBox groupBox1;
        private Label label2;
        private CheckBox reception_checkbox;
        private CheckBox send_checkbox;
        private Label label4;
        private Label label3;
        private DateTimePicker dtpEnd;
        private DateTimePicker dtpStart;
        private Label label5;
        private CheckBox checkBox2;
        private CheckBox checkBox1;
        private CheckBox checkBox3;
        private Button clear_btn;
        private Button search_btn;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private Button close_btn;
        private Button update_btn;
    }
}