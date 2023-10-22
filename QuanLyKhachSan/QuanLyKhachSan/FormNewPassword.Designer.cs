namespace QuanLyKhachSan
{
    partial class FormNewPassword
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormNewPassword));
            this.panel1 = new System.Windows.Forms.Panel();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.picShow = new System.Windows.Forms.PictureBox();
            this.btnCanCel = new System.Windows.Forms.Button();
            this.btnChange = new System.Windows.Forms.Button();
            this.lblConfirmPassword = new System.Windows.Forms.Label();
            this.lblNewPW = new System.Windows.Forms.Label();
            this.picHide = new System.Windows.Forms.PictureBox();
            this.txtConfirmPassword = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.grNewPassWord = new System.Windows.Forms.GroupBox();
            this.picHideNewPW = new System.Windows.Forms.PictureBox();
            this.picShowNW = new System.Windows.Forms.PictureBox();
            this.txtNewPassWord = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picShow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picHide)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.grNewPassWord.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picHideNewPW)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picShowNW)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.grNewPassWord);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1294, 751);
            this.panel1.TabIndex = 0;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Location = new System.Drawing.Point(51, 37);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(437, 32);
            this.dateTimePicker1.TabIndex = 22;
            // 
            // picShow
            // 
            this.picShow.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picShow.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picShow.Image = global::QuanLyKhachSan.Properties.Resources.icons8_eye_64;
            this.picShow.Location = new System.Drawing.Point(449, 247);
            this.picShow.Name = "picShow";
            this.picShow.Size = new System.Drawing.Size(38, 30);
            this.picShow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picShow.TabIndex = 20;
            this.picShow.TabStop = false;
            // 
            // btnCanCel
            // 
            this.btnCanCel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCanCel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(198)))), ((int)(((byte)(218)))));
            this.btnCanCel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCanCel.FlatAppearance.BorderSize = 0;
            this.btnCanCel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCanCel.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCanCel.ForeColor = System.Drawing.Color.White;
            this.btnCanCel.Location = new System.Drawing.Point(51, 370);
            this.btnCanCel.Name = "btnCanCel";
            this.btnCanCel.Size = new System.Drawing.Size(437, 45);
            this.btnCanCel.TabIndex = 18;
            this.btnCanCel.Text = "CANCEL";
            this.btnCanCel.UseVisualStyleBackColor = false;
            this.btnCanCel.Click += new System.EventHandler(this.btnCanCel_Click);
            // 
            // btnChange
            // 
            this.btnChange.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnChange.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(198)))), ((int)(((byte)(218)))));
            this.btnChange.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnChange.FlatAppearance.BorderSize = 0;
            this.btnChange.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChange.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChange.ForeColor = System.Drawing.Color.White;
            this.btnChange.Location = new System.Drawing.Point(51, 308);
            this.btnChange.Name = "btnChange";
            this.btnChange.Size = new System.Drawing.Size(437, 45);
            this.btnChange.TabIndex = 19;
            this.btnChange.Text = "CHANGE";
            this.btnChange.UseVisualStyleBackColor = false;
            this.btnChange.Click += new System.EventHandler(this.btnChange_Click);
            // 
            // lblConfirmPassword
            // 
            this.lblConfirmPassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblConfirmPassword.AutoSize = true;
            this.lblConfirmPassword.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConfirmPassword.Location = new System.Drawing.Point(47, 203);
            this.lblConfirmPassword.Name = "lblConfirmPassword";
            this.lblConfirmPassword.Size = new System.Drawing.Size(180, 23);
            this.lblConfirmPassword.TabIndex = 14;
            this.lblConfirmPassword.Text = "Confirm Pasword:";
            // 
            // lblNewPW
            // 
            this.lblNewPW.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblNewPW.AutoSize = true;
            this.lblNewPW.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNewPW.Location = new System.Drawing.Point(47, 104);
            this.lblNewPW.Name = "lblNewPW";
            this.lblNewPW.Size = new System.Drawing.Size(156, 23);
            this.lblNewPW.TabIndex = 15;
            this.lblNewPW.Text = "New Password:";
            // 
            // picHide
            // 
            this.picHide.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picHide.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picHide.Image = global::QuanLyKhachSan.Properties.Resources.icons8_hide_64;
            this.picHide.Location = new System.Drawing.Point(449, 247);
            this.picHide.Name = "picHide";
            this.picHide.Size = new System.Drawing.Size(38, 30);
            this.picHide.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picHide.TabIndex = 21;
            this.picHide.TabStop = false;
            // 
            // txtConfirmPassword
            // 
            this.txtConfirmPassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtConfirmPassword.Location = new System.Drawing.Point(51, 247);
            this.txtConfirmPassword.Name = "txtConfirmPassword";
            this.txtConfirmPassword.Size = new System.Drawing.Size(395, 28);
            this.txtConfirmPassword.TabIndex = 17;
            this.txtConfirmPassword.UseSystemPasswordChar = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(525, 86);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(283, 146);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // grNewPassWord
            // 
            this.grNewPassWord.Controls.Add(this.dateTimePicker1);
            this.grNewPassWord.Controls.Add(this.btnCanCel);
            this.grNewPassWord.Controls.Add(this.picShowNW);
            this.grNewPassWord.Controls.Add(this.picShow);
            this.grNewPassWord.Controls.Add(this.btnChange);
            this.grNewPassWord.Controls.Add(this.picHideNewPW);
            this.grNewPassWord.Controls.Add(this.lblNewPW);
            this.grNewPassWord.Controls.Add(this.picHide);
            this.grNewPassWord.Controls.Add(this.lblConfirmPassword);
            this.grNewPassWord.Controls.Add(this.txtNewPassWord);
            this.grNewPassWord.Controls.Add(this.txtConfirmPassword);
            this.grNewPassWord.Location = new System.Drawing.Point(388, 238);
            this.grNewPassWord.Name = "grNewPassWord";
            this.grNewPassWord.Size = new System.Drawing.Size(556, 436);
            this.grNewPassWord.TabIndex = 23;
            this.grNewPassWord.TabStop = false;
            // 
            // picHideNewPW
            // 
            this.picHideNewPW.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picHideNewPW.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picHideNewPW.Image = global::QuanLyKhachSan.Properties.Resources.icons8_hide_64;
            this.picHideNewPW.Location = new System.Drawing.Point(449, 147);
            this.picHideNewPW.Name = "picHideNewPW";
            this.picHideNewPW.Size = new System.Drawing.Size(38, 30);
            this.picHideNewPW.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picHideNewPW.TabIndex = 21;
            this.picHideNewPW.TabStop = false;
            // 
            // picShowNW
            // 
            this.picShowNW.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picShowNW.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picShowNW.Image = global::QuanLyKhachSan.Properties.Resources.icons8_eye_64;
            this.picShowNW.Location = new System.Drawing.Point(449, 147);
            this.picShowNW.Name = "picShowNW";
            this.picShowNW.Size = new System.Drawing.Size(38, 30);
            this.picShowNW.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picShowNW.TabIndex = 20;
            this.picShowNW.TabStop = false;
            this.picShowNW.Click += new System.EventHandler(this.picShowNW_Click);
            // 
            // txtNewPassWord
            // 
            this.txtNewPassWord.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtNewPassWord.Location = new System.Drawing.Point(48, 147);
            this.txtNewPassWord.Name = "txtNewPassWord";
            this.txtNewPassWord.Size = new System.Drawing.Size(395, 28);
            this.txtNewPassWord.TabIndex = 17;
            this.txtNewPassWord.UseSystemPasswordChar = true;
            // 
            // FormNewPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1294, 751);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormNewPassword";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Log In | NewPassword";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picShow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picHide)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.grNewPassWord.ResumeLayout(false);
            this.grNewPassWord.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picHideNewPW)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picShowNW)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.PictureBox picShow;
        private System.Windows.Forms.Button btnCanCel;
        private System.Windows.Forms.Button btnChange;
        private System.Windows.Forms.Label lblConfirmPassword;
        private System.Windows.Forms.Label lblNewPW;
        private System.Windows.Forms.PictureBox picHide;
        private System.Windows.Forms.TextBox txtConfirmPassword;
        private System.Windows.Forms.GroupBox grNewPassWord;
        private System.Windows.Forms.PictureBox picShowNW;
        private System.Windows.Forms.PictureBox picHideNewPW;
        private System.Windows.Forms.TextBox txtNewPassWord;
    }
}