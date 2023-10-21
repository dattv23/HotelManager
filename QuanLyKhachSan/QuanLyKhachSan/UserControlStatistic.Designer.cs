namespace QuanLyKhachSan
{
    partial class UserControlStatistic
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvStatistic = new System.Windows.Forms.DataGridView();
            this.dgvRoomNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dvRoomType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvStartDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvIsSmoking = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dgvPhoneNumberUser = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtpOut = new System.Windows.Forms.DateTimePicker();
            this.dtpIn = new System.Windows.Forms.DateTimePicker();
            this.ckbStatisticsForMonth = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lblAmount = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnStatistic = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStatistic)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvStatistic
            // 
            this.dgvStatistic.AllowUserToAddRows = false;
            this.dgvStatistic.AllowUserToDeleteRows = false;
            this.dgvStatistic.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvStatistic.BackgroundColor = System.Drawing.Color.White;
            this.dgvStatistic.ColumnHeadersHeight = 29;
            this.dgvStatistic.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvRoomNum,
            this.dvRoomType,
            this.dgvAmount,
            this.dgvStartDate,
            this.dgvIsSmoking,
            this.dgvPhoneNumberUser});
            this.dgvStatistic.Location = new System.Drawing.Point(0, 114);
            this.dgvStatistic.Name = "dgvStatistic";
            this.dgvStatistic.ReadOnly = true;
            this.dgvStatistic.RowHeadersWidth = 51;
            this.dgvStatistic.RowTemplate.Height = 24;
            this.dgvStatistic.Size = new System.Drawing.Size(1102, 348);
            this.dgvStatistic.TabIndex = 7;
            // 
            // dgvRoomNum
            // 
            this.dgvRoomNum.HeaderText = "Room Num";
            this.dgvRoomNum.MinimumWidth = 6;
            this.dgvRoomNum.Name = "dgvRoomNum";
            this.dgvRoomNum.ReadOnly = true;
            // 
            // dvRoomType
            // 
            this.dvRoomType.HeaderText = "Room Type";
            this.dvRoomType.MinimumWidth = 6;
            this.dvRoomType.Name = "dvRoomType";
            this.dvRoomType.ReadOnly = true;
            // 
            // dgvAmount
            // 
            this.dgvAmount.HeaderText = "Amount";
            this.dgvAmount.MinimumWidth = 6;
            this.dgvAmount.Name = "dgvAmount";
            this.dgvAmount.ReadOnly = true;
            // 
            // dgvStartDate
            // 
            this.dgvStartDate.HeaderText = "Start Date";
            this.dgvStartDate.MinimumWidth = 8;
            this.dgvStartDate.Name = "dgvStartDate";
            this.dgvStartDate.ReadOnly = true;
            // 
            // dgvIsSmoking
            // 
            this.dgvIsSmoking.HeaderText = "isSmoking";
            this.dgvIsSmoking.MinimumWidth = 8;
            this.dgvIsSmoking.Name = "dgvIsSmoking";
            this.dgvIsSmoking.ReadOnly = true;
            // 
            // dgvPhoneNumberUser
            // 
            this.dgvPhoneNumberUser.HeaderText = "PhoneNumberUser";
            this.dgvPhoneNumberUser.MinimumWidth = 8;
            this.dgvPhoneNumberUser.Name = "dgvPhoneNumberUser";
            this.dgvPhoneNumberUser.ReadOnly = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtpOut);
            this.groupBox1.Controls.Add(this.dtpIn);
            this.groupBox1.Controls.Add(this.ckbStatisticsForMonth);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.lblAmount);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.btnStatistic);
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1102, 111);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Manage room booking status";
            // 
            // dtpOut
            // 
            this.dtpOut.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpOut.Location = new System.Drawing.Point(502, 71);
            this.dtpOut.Name = "dtpOut";
            this.dtpOut.Size = new System.Drawing.Size(263, 28);
            this.dtpOut.TabIndex = 11;
            // 
            // dtpIn
            // 
            this.dtpIn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpIn.Location = new System.Drawing.Point(129, 71);
            this.dtpIn.Name = "dtpIn";
            this.dtpIn.Size = new System.Drawing.Size(263, 28);
            this.dtpIn.TabIndex = 10;
            // 
            // ckbStatisticsForMonth
            // 
            this.ckbStatisticsForMonth.AutoSize = true;
            this.ckbStatisticsForMonth.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbStatisticsForMonth.ForeColor = System.Drawing.Color.White;
            this.ckbStatisticsForMonth.Location = new System.Drawing.Point(6, 39);
            this.ckbStatisticsForMonth.Name = "ckbStatisticsForMonth";
            this.ckbStatisticsForMonth.Size = new System.Drawing.Size(384, 29);
            this.ckbStatisticsForMonth.TabIndex = 9;
            this.ckbStatisticsForMonth.Text = "Room statistics for the current month";
            this.ckbStatisticsForMonth.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(397, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 25);
            this.label4.TabIndex = 6;
            this.label4.Text = "To date :";
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAmount.ForeColor = System.Drawing.Color.White;
            this.lblAmount.Location = new System.Drawing.Point(1038, 77);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(30, 25);
            this.lblAmount.TabIndex = 13;
            this.lblAmount.Text = "...";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(887, 77);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(154, 25);
            this.label7.TabIndex = 7;
            this.label7.Text = "Total Amount :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(1, 74);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(122, 25);
            this.label8.TabIndex = 8;
            this.label8.Text = "From date :";
            // 
            // btnStatistic
            // 
            this.btnStatistic.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnStatistic.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStatistic.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStatistic.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStatistic.ForeColor = System.Drawing.Color.White;
            this.btnStatistic.Location = new System.Drawing.Point(779, 56);
            this.btnStatistic.Name = "btnStatistic";
            this.btnStatistic.Size = new System.Drawing.Size(102, 49);
            this.btnStatistic.TabIndex = 12;
            this.btnStatistic.Text = "Statistic";
            this.btnStatistic.UseVisualStyleBackColor = false;
            this.btnStatistic.Click += new System.EventHandler(this.button1_Click);
            // 
            // UserControlStatistic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(198)))), ((int)(((byte)(218)))));
            this.Controls.Add(this.dgvStatistic);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "UserControlStatistic";
            this.Size = new System.Drawing.Size(1102, 462);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStatistic)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvStatistic;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dtpOut;
        private System.Windows.Forms.DateTimePicker dtpIn;
        private System.Windows.Forms.CheckBox ckbStatisticsForMonth;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnStatistic;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvRoomNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn dvRoomType;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvStartDate;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dgvIsSmoking;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvPhoneNumberUser;
    }
}
