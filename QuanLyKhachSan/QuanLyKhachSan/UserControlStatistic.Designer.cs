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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
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
            this.chartStatistics = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartStatistics)).BeginInit();
            this.SuspendLayout();
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
            this.dtpOut.Size = new System.Drawing.Size(254, 33);
            this.dtpOut.TabIndex = 11;
            // 
            // dtpIn
            // 
            this.dtpIn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpIn.Location = new System.Drawing.Point(129, 71);
            this.dtpIn.Name = "dtpIn";
            this.dtpIn.Size = new System.Drawing.Size(262, 33);
            this.dtpIn.TabIndex = 10;
            // 
            // ckbStatisticsForMonth
            // 
            this.ckbStatisticsForMonth.AutoSize = true;
            this.ckbStatisticsForMonth.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbStatisticsForMonth.ForeColor = System.Drawing.Color.White;
            this.ckbStatisticsForMonth.Location = new System.Drawing.Point(6, 39);
            this.ckbStatisticsForMonth.Name = "ckbStatisticsForMonth";
            this.ckbStatisticsForMonth.Size = new System.Drawing.Size(463, 33);
            this.ckbStatisticsForMonth.TabIndex = 9;
            this.ckbStatisticsForMonth.Text = "Room statistics for the current month";
            this.ckbStatisticsForMonth.UseVisualStyleBackColor = true;
            this.ckbStatisticsForMonth.CheckedChanged += new System.EventHandler(this.ckbStatisticsForMonth_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(397, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 29);
            this.label4.TabIndex = 6;
            this.label4.Text = "To date :";
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAmount.ForeColor = System.Drawing.Color.White;
            this.lblAmount.Location = new System.Drawing.Point(1017, 76);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(34, 29);
            this.lblAmount.TabIndex = 13;
            this.lblAmount.Text = "...";
            this.lblAmount.Click += new System.EventHandler(this.lblAmount_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(870, 74);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(181, 29);
            this.label7.TabIndex = 7;
            this.label7.Text = "Total Amount :";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(1, 74);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(146, 29);
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
            this.btnStatistic.Location = new System.Drawing.Point(762, 56);
            this.btnStatistic.Name = "btnStatistic";
            this.btnStatistic.Size = new System.Drawing.Size(102, 49);
            this.btnStatistic.TabIndex = 12;
            this.btnStatistic.Text = "Statistic";
            this.btnStatistic.UseVisualStyleBackColor = false;
            this.btnStatistic.Click += new System.EventHandler(this.btnStatistic_Click);
            // 
            // chartStatistics
            // 
            chartArea4.Name = "ChartArea1";
            this.chartStatistics.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            this.chartStatistics.Legends.Add(legend4);
            this.chartStatistics.Location = new System.Drawing.Point(0, 106);
            this.chartStatistics.Name = "chartStatistics";
            series4.ChartArea = "ChartArea1";
            series4.Legend = "Legend1";
            series4.Name = "RoomPrices";
            this.chartStatistics.Series.Add(series4);
            this.chartStatistics.Size = new System.Drawing.Size(1102, 356);
            this.chartStatistics.TabIndex = 9;
            this.chartStatistics.Text = "chart1";
            // 
            // UserControlStatistic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(198)))), ((int)(((byte)(218)))));
            this.Controls.Add(this.chartStatistics);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "UserControlStatistic";
            this.Size = new System.Drawing.Size(1102, 462);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartStatistics)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dtpOut;
        private System.Windows.Forms.DateTimePicker dtpIn;
        private System.Windows.Forms.CheckBox ckbStatisticsForMonth;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnStatistic;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartStatistics;
    }
}
