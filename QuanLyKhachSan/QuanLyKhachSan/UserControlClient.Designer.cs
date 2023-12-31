﻿namespace QuanLyKhachSan
{
    partial class UserControlClient
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
            this.components = new System.ComponentModel.Container();
            this.tabControlClient = new System.Windows.Forms.TabControl();
            this.tabPageAddClient = new System.Windows.Forms.TabPage();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtphone = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.lblphone = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.tabPageSearchClient = new System.Windows.Forms.TabPage();
            this.btnFind = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvUser = new System.Windows.Forms.DataGridView();
            this.Client_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Client_FullName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Client_Phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Client_Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Client_Address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtSearchClient = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tabPageUpdateandDelete = new System.Windows.Forms.TabPage();
            this.txtEmailUp = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.lblLN = new System.Windows.Forms.Label();
            this.lblFN = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblAR = new System.Windows.Forms.Label();
            this.txtLastNameUp = new System.Windows.Forms.TextBox();
            this.txtAddressUp = new System.Windows.Forms.TextBox();
            this.txtPhoneUp = new System.Windows.Forms.TextBox();
            this.txtFirstNameUp = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.contextMenuStrip3 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tabControlClient.SuspendLayout();
            this.tabPageAddClient.SuspendLayout();
            this.tabPageSearchClient.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUser)).BeginInit();
            this.tabPageUpdateandDelete.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControlClient
            // 
            this.tabControlClient.Alignment = System.Windows.Forms.TabAlignment.Bottom;
            this.tabControlClient.Controls.Add(this.tabPageAddClient);
            this.tabControlClient.Controls.Add(this.tabPageSearchClient);
            this.tabControlClient.Controls.Add(this.tabPageUpdateandDelete);
            this.tabControlClient.Location = new System.Drawing.Point(36, 14);
            this.tabControlClient.Name = "tabControlClient";
            this.tabControlClient.SelectedIndex = 0;
            this.tabControlClient.Size = new System.Drawing.Size(1046, 657);
            this.tabControlClient.TabIndex = 0;
            // 
            // tabPageAddClient
            // 
            this.tabPageAddClient.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(238)))), ((int)(((byte)(224)))));
            this.tabPageAddClient.Controls.Add(this.txtEmail);
            this.tabPageAddClient.Controls.Add(this.lblEmail);
            this.tabPageAddClient.Controls.Add(this.btnAdd);
            this.tabPageAddClient.Controls.Add(this.label4);
            this.tabPageAddClient.Controls.Add(this.txtphone);
            this.tabPageAddClient.Controls.Add(this.txtAddress);
            this.tabPageAddClient.Controls.Add(this.txtLastName);
            this.tabPageAddClient.Controls.Add(this.txtFirstName);
            this.tabPageAddClient.Controls.Add(this.lblphone);
            this.tabPageAddClient.Controls.Add(this.lblAddress);
            this.tabPageAddClient.Controls.Add(this.lblLastName);
            this.tabPageAddClient.Controls.Add(this.lblFirstName);
            this.tabPageAddClient.Location = new System.Drawing.Point(4, 4);
            this.tabPageAddClient.Name = "tabPageAddClient";
            this.tabPageAddClient.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageAddClient.Size = new System.Drawing.Size(1038, 625);
            this.tabPageAddClient.TabIndex = 0;
            this.tabPageAddClient.Text = "ADD CLIENT";
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(575, 275);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(383, 32);
            this.txtEmail.TabIndex = 4;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.lblEmail.Location = new System.Drawing.Point(571, 215);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(68, 23);
            this.lblEmail.TabIndex = 0;
            this.lblEmail.Text = "Email:";
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(282, 530);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(333, 45);
            this.btnAdd.TabIndex = 6;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.label4.Location = new System.Drawing.Point(3, 3);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 22);
            this.label4.TabIndex = 0;
            this.label4.Text = "Add Client :";
            // 
            // txtphone
            // 
            this.txtphone.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtphone.Location = new System.Drawing.Point(70, 275);
            this.txtphone.Name = "txtphone";
            this.txtphone.Size = new System.Drawing.Size(313, 32);
            this.txtphone.TabIndex = 3;
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(70, 387);
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(888, 104);
            this.txtAddress.TabIndex = 5;
            // 
            // txtLastName
            // 
            this.txtLastName.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLastName.Location = new System.Drawing.Point(575, 145);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(383, 32);
            this.txtLastName.TabIndex = 2;
            // 
            // txtFirstName
            // 
            this.txtFirstName.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFirstName.Location = new System.Drawing.Point(70, 145);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(313, 32);
            this.txtFirstName.TabIndex = 1;
            // 
            // lblphone
            // 
            this.lblphone.AutoSize = true;
            this.lblphone.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblphone.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.lblphone.Location = new System.Drawing.Point(66, 215);
            this.lblphone.Name = "lblphone";
            this.lblphone.Size = new System.Drawing.Size(123, 23);
            this.lblphone.TabIndex = 0;
            this.lblphone.Text = "Phone No. :";
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddress.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.lblAddress.Location = new System.Drawing.Point(66, 347);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(103, 23);
            this.lblAddress.TabIndex = 0;
            this.lblAddress.Text = "Addresss:";
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLastName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.lblLastName.Location = new System.Drawing.Point(571, 76);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(113, 23);
            this.lblLastName.TabIndex = 0;
            this.lblLastName.Text = "LastName:";
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFirstName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.lblFirstName.Location = new System.Drawing.Point(66, 76);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(112, 23);
            this.lblFirstName.TabIndex = 0;
            this.lblFirstName.Text = "FirstName:";
            // 
            // tabPageSearchClient
            // 
            this.tabPageSearchClient.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(247)))), ((int)(((byte)(255)))));
            this.tabPageSearchClient.Controls.Add(this.btnFind);
            this.tabPageSearchClient.Controls.Add(this.label1);
            this.tabPageSearchClient.Controls.Add(this.dgvUser);
            this.tabPageSearchClient.Controls.Add(this.txtSearchClient);
            this.tabPageSearchClient.Controls.Add(this.label2);
            this.tabPageSearchClient.Location = new System.Drawing.Point(4, 4);
            this.tabPageSearchClient.Name = "tabPageSearchClient";
            this.tabPageSearchClient.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageSearchClient.Size = new System.Drawing.Size(1023, 559);
            this.tabPageSearchClient.TabIndex = 1;
            this.tabPageSearchClient.Text = "SEARCH CLIENT";
            // 
            // btnFind
            // 
            this.btnFind.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnFind.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFind.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFind.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFind.ForeColor = System.Drawing.Color.White;
            this.btnFind.Location = new System.Drawing.Point(572, 78);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(241, 53);
            this.btnFind.TabIndex = 3;
            this.btnFind.Text = "Find";
            this.btnFind.UseVisualStyleBackColor = false;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.label1.Location = new System.Drawing.Point(3, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Search Client :";
            // 
            // dgvUser
            // 
            this.dgvUser.AllowUserToAddRows = false;
            this.dgvUser.AllowUserToDeleteRows = false;
            this.dgvUser.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvUser.BackgroundColor = System.Drawing.Color.White;
            this.dgvUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUser.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Client_ID,
            this.Client_FullName,
            this.Client_Phone,
            this.Client_Email,
            this.Client_Address});
            this.dgvUser.Location = new System.Drawing.Point(10, 167);
            this.dgvUser.Name = "dgvUser";
            this.dgvUser.ReadOnly = true;
            this.dgvUser.RowHeadersWidth = 51;
            this.dgvUser.RowTemplate.Height = 24;
            this.dgvUser.Size = new System.Drawing.Size(1010, 392);
            this.dgvUser.TabIndex = 2;
            // 
            // Client_ID
            // 
            this.Client_ID.HeaderText = "ID";
            this.Client_ID.MinimumWidth = 6;
            this.Client_ID.Name = "Client_ID";
            this.Client_ID.ReadOnly = true;
            // 
            // Client_FullName
            // 
            this.Client_FullName.HeaderText = "FullName";
            this.Client_FullName.MinimumWidth = 6;
            this.Client_FullName.Name = "Client_FullName";
            this.Client_FullName.ReadOnly = true;
            // 
            // Client_Phone
            // 
            this.Client_Phone.HeaderText = "Phone No.";
            this.Client_Phone.MinimumWidth = 6;
            this.Client_Phone.Name = "Client_Phone";
            this.Client_Phone.ReadOnly = true;
            // 
            // Client_Email
            // 
            this.Client_Email.HeaderText = "Email";
            this.Client_Email.MinimumWidth = 6;
            this.Client_Email.Name = "Client_Email";
            this.Client_Email.ReadOnly = true;
            // 
            // Client_Address
            // 
            this.Client_Address.HeaderText = "Address";
            this.Client_Address.MinimumWidth = 6;
            this.Client_Address.Name = "Client_Address";
            this.Client_Address.ReadOnly = true;
            // 
            // txtSearchClient
            // 
            this.txtSearchClient.Location = new System.Drawing.Point(161, 78);
            this.txtSearchClient.Multiline = true;
            this.txtSearchClient.Name = "txtSearchClient";
            this.txtSearchClient.Size = new System.Drawing.Size(324, 53);
            this.txtSearchClient.TabIndex = 1;
            this.txtSearchClient.TextChanged += new System.EventHandler(this.txtSearchClient_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.label2.Location = new System.Drawing.Point(157, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 23);
            this.label2.TabIndex = 0;
            this.label2.Text = "Phone No. :";
            // 
            // tabPageUpdateandDelete
            // 
            this.tabPageUpdateandDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(238)))), ((int)(((byte)(224)))));
            this.tabPageUpdateandDelete.Controls.Add(this.txtEmailUp);
            this.tabPageUpdateandDelete.Controls.Add(this.label5);
            this.tabPageUpdateandDelete.Controls.Add(this.btnDelete);
            this.tabPageUpdateandDelete.Controls.Add(this.btnUpdate);
            this.tabPageUpdateandDelete.Controls.Add(this.label3);
            this.tabPageUpdateandDelete.Controls.Add(this.lblLN);
            this.tabPageUpdateandDelete.Controls.Add(this.lblFN);
            this.tabPageUpdateandDelete.Controls.Add(this.label7);
            this.tabPageUpdateandDelete.Controls.Add(this.lblAR);
            this.tabPageUpdateandDelete.Controls.Add(this.txtLastNameUp);
            this.tabPageUpdateandDelete.Controls.Add(this.txtAddressUp);
            this.tabPageUpdateandDelete.Controls.Add(this.txtPhoneUp);
            this.tabPageUpdateandDelete.Controls.Add(this.txtFirstNameUp);
            this.tabPageUpdateandDelete.Location = new System.Drawing.Point(4, 4);
            this.tabPageUpdateandDelete.Name = "tabPageUpdateandDelete";
            this.tabPageUpdateandDelete.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageUpdateandDelete.Size = new System.Drawing.Size(1023, 559);
            this.tabPageUpdateandDelete.TabIndex = 2;
            this.tabPageUpdateandDelete.Text = "UPDATE AND DELETE CLIENT";
            // 
            // txtEmailUp
            // 
            this.txtEmailUp.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmailUp.Location = new System.Drawing.Point(595, 263);
            this.txtEmailUp.Name = "txtEmailUp";
            this.txtEmailUp.Size = new System.Drawing.Size(351, 32);
            this.txtEmailUp.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.label5.Location = new System.Drawing.Point(591, 215);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 23);
            this.label5.TabIndex = 0;
            this.label5.Text = "Email:";
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(73)))), ((int)(((byte)(73)))));
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(595, 494);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(351, 45);
            this.btnDelete.TabIndex = 7;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdate.FlatAppearance.BorderSize = 0;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.Color.Transparent;
            this.btnUpdate.Location = new System.Drawing.Point(75, 494);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(342, 45);
            this.btnUpdate.TabIndex = 6;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.label3.Location = new System.Drawing.Point(3, 3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(243, 22);
            this.label3.TabIndex = 0;
            this.label3.Text = "Update and Delete Client :";
            // 
            // lblLN
            // 
            this.lblLN.AutoSize = true;
            this.lblLN.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLN.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.lblLN.Location = new System.Drawing.Point(591, 79);
            this.lblLN.Name = "lblLN";
            this.lblLN.Size = new System.Drawing.Size(113, 23);
            this.lblLN.TabIndex = 0;
            this.lblLN.Text = "LastName:";
            // 
            // lblFN
            // 
            this.lblFN.AutoSize = true;
            this.lblFN.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFN.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.lblFN.Location = new System.Drawing.Point(77, 79);
            this.lblFN.Name = "lblFN";
            this.lblFN.Size = new System.Drawing.Size(112, 23);
            this.lblFN.TabIndex = 0;
            this.lblFN.Text = "FirstName:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.label7.Location = new System.Drawing.Point(71, 196);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(123, 23);
            this.label7.TabIndex = 0;
            this.label7.Text = "Phone No. :";
            // 
            // lblAR
            // 
            this.lblAR.AutoSize = true;
            this.lblAR.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAR.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.lblAR.Location = new System.Drawing.Point(71, 339);
            this.lblAR.Name = "lblAR";
            this.lblAR.Size = new System.Drawing.Size(100, 23);
            this.lblAR.TabIndex = 0;
            this.lblAR.Text = "Address :";
            // 
            // txtLastNameUp
            // 
            this.txtLastNameUp.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLastNameUp.Location = new System.Drawing.Point(595, 131);
            this.txtLastNameUp.Name = "txtLastNameUp";
            this.txtLastNameUp.Size = new System.Drawing.Size(351, 32);
            this.txtLastNameUp.TabIndex = 2;
            // 
            // txtAddressUp
            // 
            this.txtAddressUp.Location = new System.Drawing.Point(75, 378);
            this.txtAddressUp.Multiline = true;
            this.txtAddressUp.Name = "txtAddressUp";
            this.txtAddressUp.Size = new System.Drawing.Size(871, 99);
            this.txtAddressUp.TabIndex = 5;
            // 
            // txtPhoneUp
            // 
            this.txtPhoneUp.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPhoneUp.Location = new System.Drawing.Point(75, 263);
            this.txtPhoneUp.Name = "txtPhoneUp";
            this.txtPhoneUp.Size = new System.Drawing.Size(361, 32);
            this.txtPhoneUp.TabIndex = 3;
            this.txtPhoneUp.TextChanged += new System.EventHandler(this.txtPhoneUp_TextChanged);
            // 
            // txtFirstNameUp
            // 
            this.txtFirstNameUp.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFirstNameUp.Location = new System.Drawing.Point(75, 131);
            this.txtFirstNameUp.Name = "txtFirstNameUp";
            this.txtFirstNameUp.Size = new System.Drawing.Size(361, 32);
            this.txtFirstNameUp.TabIndex = 1;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(61, 4);
            // 
            // contextMenuStrip3
            // 
            this.contextMenuStrip3.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip3.Name = "contextMenuStrip3";
            this.contextMenuStrip3.Size = new System.Drawing.Size(61, 4);
            // 
            // UserControlClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(236)))), ((int)(((byte)(236)))));
            this.Controls.Add(this.tabControlClient);
            this.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "UserControlClient";
            this.Size = new System.Drawing.Size(1102, 702);
            this.tabControlClient.ResumeLayout(false);
            this.tabPageAddClient.ResumeLayout(false);
            this.tabPageAddClient.PerformLayout();
            this.tabPageSearchClient.ResumeLayout(false);
            this.tabPageSearchClient.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUser)).EndInit();
            this.tabPageUpdateandDelete.ResumeLayout(false);
            this.tabPageUpdateandDelete.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlClient;
        private System.Windows.Forms.TabPage tabPageAddClient;
        private System.Windows.Forms.TabPage tabPageSearchClient;
        private System.Windows.Forms.TextBox txtphone;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Label lblphone;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.DataGridView dgvUser;
        private System.Windows.Forms.TextBox txtSearchClient;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabPage tabPageUpdateandDelete;
        private System.Windows.Forms.Label lblLN;
        private System.Windows.Forms.Label lblFN;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblAR;
        private System.Windows.Forms.TextBox txtLastNameUp;
        private System.Windows.Forms.TextBox txtAddressUp;
        private System.Windows.Forms.TextBox txtPhoneUp;
        private System.Windows.Forms.TextBox txtFirstNameUp;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.TextBox txtEmailUp;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip3;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.DataGridViewTextBoxColumn Client_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Client_FullName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Client_Phone;
        private System.Windows.Forms.DataGridViewTextBoxColumn Client_Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn Client_Address;
    }
}
