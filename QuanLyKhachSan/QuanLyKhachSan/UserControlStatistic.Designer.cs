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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtpOut = new System.Windows.Forms.DateTimePicker();
            this.dtpIn = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.lblAmount = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tabControlStatictis = new System.Windows.Forms.TabControl();
            this.tabPageStatisticsbyUser = new System.Windows.Forms.TabPage();
            this.ckbStatisticsReservationByMonth = new System.Windows.Forms.CheckBox();
            this.btnStatisticsByUser = new System.Windows.Forms.Button();
            this.chartStatisticsByUser = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.ckbStatisticsForMonth = new System.Windows.Forms.CheckBox();
            this.btnStatistic = new System.Windows.Forms.Button();
            this.chartStatistics = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tabPageStatisticsbyPrice = new System.Windows.Forms.TabPage();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblUser = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.tabControlStatictis.SuspendLayout();
            this.tabPageStatisticsbyUser.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartStatisticsByUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartStatistics)).BeginInit();
            this.tabPageStatisticsbyPrice.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtpOut);
            this.groupBox1.Controls.Add(this.dtpIn);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label8);
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
            this.dtpOut.Size = new System.Drawing.Size(254, 28);
            this.dtpOut.TabIndex = 11;
            // 
            // dtpIn
            // 
            this.dtpIn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpIn.Location = new System.Drawing.Point(129, 71);
            this.dtpIn.Name = "dtpIn";
            this.dtpIn.Size = new System.Drawing.Size(262, 28);
            this.dtpIn.TabIndex = 10;
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
            this.lblAmount.ForeColor = System.Drawing.Color.Turquoise;
            this.lblAmount.Location = new System.Drawing.Point(775, 14);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(30, 25);
            this.lblAmount.TabIndex = 13;
            this.lblAmount.Text = "...";
            this.lblAmount.Click += new System.EventHandler(this.lblAmount_Click);
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
            // tabControlStatictis
            // 
            this.tabControlStatictis.Alignment = System.Windows.Forms.TabAlignment.Bottom;
            this.tabControlStatictis.Controls.Add(this.tabPageStatisticsbyPrice);
            this.tabControlStatictis.Controls.Add(this.tabPageStatisticsbyUser);
            this.tabControlStatictis.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControlStatictis.Location = new System.Drawing.Point(30, 117);
            this.tabControlStatictis.Name = "tabControlStatictis";
            this.tabControlStatictis.SelectedIndex = 0;
            this.tabControlStatictis.Size = new System.Drawing.Size(1031, 490);
            this.tabControlStatictis.TabIndex = 9;
            this.tabControlStatictis.Click += new System.EventHandler(this.tabControlStatictis_Click);
            // 
            // tabPageStatisticsbyUser
            // 
            this.tabPageStatisticsbyUser.Controls.Add(this.lblUser);
            this.tabPageStatisticsbyUser.Controls.Add(this.label1);
            this.tabPageStatisticsbyUser.Controls.Add(this.ckbStatisticsReservationByMonth);
            this.tabPageStatisticsbyUser.Controls.Add(this.btnStatisticsByUser);
            this.tabPageStatisticsbyUser.Controls.Add(this.chartStatisticsByUser);
            this.tabPageStatisticsbyUser.Location = new System.Drawing.Point(4, 4);
            this.tabPageStatisticsbyUser.Name = "tabPageStatisticsbyUser";
            this.tabPageStatisticsbyUser.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageStatisticsbyUser.Size = new System.Drawing.Size(1023, 458);
            this.tabPageStatisticsbyUser.TabIndex = 1;
            this.tabPageStatisticsbyUser.Text = "Statistics by User";
            this.tabPageStatisticsbyUser.UseVisualStyleBackColor = true;
            this.tabPageStatisticsbyUser.Click += new System.EventHandler(this.tabPageStatisticsbyUser_Click);
            // 
            // ckbStatisticsReservationByMonth
            // 
            this.ckbStatisticsReservationByMonth.AutoSize = true;
            this.ckbStatisticsReservationByMonth.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbStatisticsReservationByMonth.ForeColor = System.Drawing.Color.Cyan;
            this.ckbStatisticsReservationByMonth.Location = new System.Drawing.Point(26, 15);
            this.ckbStatisticsReservationByMonth.Name = "ckbStatisticsReservationByMonth";
            this.ckbStatisticsReservationByMonth.Size = new System.Drawing.Size(443, 29);
            this.ckbStatisticsReservationByMonth.TabIndex = 14;
            this.ckbStatisticsReservationByMonth.Text = "Reservation statistics for the current month";
            this.ckbStatisticsReservationByMonth.UseVisualStyleBackColor = true;
            this.ckbStatisticsReservationByMonth.CheckedChanged += new System.EventHandler(this.ckbStatisticsReservationByMonth_CheckedChanged);
            // 
            // btnStatisticsByUser
            // 
            this.btnStatisticsByUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnStatisticsByUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStatisticsByUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStatisticsByUser.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStatisticsByUser.ForeColor = System.Drawing.Color.White;
            this.btnStatisticsByUser.Location = new System.Drawing.Point(892, 15);
            this.btnStatisticsByUser.Name = "btnStatisticsByUser";
            this.btnStatisticsByUser.Size = new System.Drawing.Size(102, 49);
            this.btnStatisticsByUser.TabIndex = 13;
            this.btnStatisticsByUser.Text = "Statistic";
            this.btnStatisticsByUser.UseVisualStyleBackColor = false;
            this.btnStatisticsByUser.Click += new System.EventHandler(this.btnStatisticsByUser_Click);
            // 
            // chartStatisticsByUser
            // 
            chartArea2.Name = "ChartArea1";
            this.chartStatisticsByUser.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chartStatisticsByUser.Legends.Add(legend2);
            this.chartStatisticsByUser.Location = new System.Drawing.Point(47, 52);
            this.chartStatisticsByUser.Name = "chartStatisticsByUser";
            series2.ChartArea = "ChartArea1";
            series2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series2.Legend = "Legend1";
            series2.Name = "Quanlity";
            series2.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int32;
            this.chartStatisticsByUser.Series.Add(series2);
            this.chartStatisticsByUser.Size = new System.Drawing.Size(839, 356);
            this.chartStatisticsByUser.TabIndex = 11;
            this.chartStatisticsByUser.Text = "chart1";
            this.chartStatisticsByUser.Click += new System.EventHandler(this.chartStatisticsByUser_Click);
            // 
            // ckbStatisticsForMonth
            // 
            this.ckbStatisticsForMonth.AutoSize = true;
            this.ckbStatisticsForMonth.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbStatisticsForMonth.ForeColor = System.Drawing.Color.Cyan;
            this.ckbStatisticsForMonth.Location = new System.Drawing.Point(6, 14);
            this.ckbStatisticsForMonth.Name = "ckbStatisticsForMonth";
            this.ckbStatisticsForMonth.Size = new System.Drawing.Size(384, 29);
            this.ckbStatisticsForMonth.TabIndex = 9;
            this.ckbStatisticsForMonth.Text = "Room statistics for the current month";
            this.ckbStatisticsForMonth.UseVisualStyleBackColor = true;
            this.ckbStatisticsForMonth.CheckedChanged += new System.EventHandler(this.ckbStatisticsForMonth_CheckedChanged);
            // 
            // btnStatistic
            // 
            this.btnStatistic.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnStatistic.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStatistic.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStatistic.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStatistic.ForeColor = System.Drawing.Color.White;
            this.btnStatistic.Location = new System.Drawing.Point(883, 6);
            this.btnStatistic.Name = "btnStatistic";
            this.btnStatistic.Size = new System.Drawing.Size(102, 49);
            this.btnStatistic.TabIndex = 12;
            this.btnStatistic.Text = "Statistic";
            this.btnStatistic.UseVisualStyleBackColor = false;
            this.btnStatistic.Click += new System.EventHandler(this.btnStatistic_Click);
            // 
            // chartStatistics
            // 
            chartArea1.Name = "ChartArea1";
            this.chartStatistics.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartStatistics.Legends.Add(legend1);
            this.chartStatistics.Location = new System.Drawing.Point(36, 62);
            this.chartStatistics.Name = "chartStatistics";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "RoomPrices";
            this.chartStatistics.Series.Add(series1);
            this.chartStatistics.Size = new System.Drawing.Size(839, 356);
            this.chartStatistics.TabIndex = 10;
            this.chartStatistics.Text = "chart1";
            // 
            // tabPageStatisticsbyPrice
            // 
            this.tabPageStatisticsbyPrice.Controls.Add(this.chartStatistics);
            this.tabPageStatisticsbyPrice.Controls.Add(this.btnStatistic);
            this.tabPageStatisticsbyPrice.Controls.Add(this.ckbStatisticsForMonth);
            this.tabPageStatisticsbyPrice.Controls.Add(this.lblAmount);
            this.tabPageStatisticsbyPrice.Controls.Add(this.label7);
            this.tabPageStatisticsbyPrice.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPageStatisticsbyPrice.Location = new System.Drawing.Point(4, 4);
            this.tabPageStatisticsbyPrice.Name = "tabPageStatisticsbyPrice";
            this.tabPageStatisticsbyPrice.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageStatisticsbyPrice.Size = new System.Drawing.Size(1023, 458);
            this.tabPageStatisticsbyPrice.TabIndex = 0;
            this.tabPageStatisticsbyPrice.Text = "Statistics by Price";
            this.tabPageStatisticsbyPrice.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Turquoise;
            this.label7.Location = new System.Drawing.Point(603, 15);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(154, 25);
            this.label7.TabIndex = 7;
            this.label7.Text = "Total Amount :";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Turquoise;
            this.label1.Location = new System.Drawing.Point(616, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 25);
            this.label1.TabIndex = 15;
            this.label1.Text = "Total Users:";
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUser.ForeColor = System.Drawing.Color.Turquoise;
            this.lblUser.Location = new System.Drawing.Point(775, 19);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(30, 25);
            this.lblUser.TabIndex = 16;
            this.lblUser.Text = "...";
            // 
            // UserControlStatistic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(198)))), ((int)(((byte)(218)))));
            this.Controls.Add(this.tabControlStatictis);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "UserControlStatistic";
            this.Size = new System.Drawing.Size(1102, 643);
            this.Load += new System.EventHandler(this.UserControlStatistic_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabControlStatictis.ResumeLayout(false);
            this.tabPageStatisticsbyUser.ResumeLayout(false);
            this.tabPageStatisticsbyUser.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartStatisticsByUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartStatistics)).EndInit();
            this.tabPageStatisticsbyPrice.ResumeLayout(false);
            this.tabPageStatisticsbyPrice.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dtpOut;
        private System.Windows.Forms.DateTimePicker dtpIn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TabControl tabControlStatictis;
        private System.Windows.Forms.TabPage tabPageStatisticsbyUser;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartStatisticsByUser;
        private System.Windows.Forms.Button btnStatisticsByUser;
        private System.Windows.Forms.CheckBox ckbStatisticsReservationByMonth;
        private System.Windows.Forms.TabPage tabPageStatisticsbyPrice;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartStatistics;
        private System.Windows.Forms.Button btnStatistic;
        private System.Windows.Forms.CheckBox ckbStatisticsForMonth;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblUser;
    }
}
