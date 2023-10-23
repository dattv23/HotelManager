namespace QuanLyKhachSan
{
    partial class UserControlRoom
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
            this.tabControlRoom = new System.Windows.Forms.TabControl();
            this.tabPageAddRoom = new System.Windows.Forms.TabPage();
            this.txtRoomNo = new System.Windows.Forms.TextBox();
            this.cmbStatus = new System.Windows.Forms.ComboBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.rdbYes = new System.Windows.Forms.RadioButton();
            this.rdbNo = new System.Windows.Forms.RadioButton();
            this.txtBookingPrice = new System.Windows.Forms.TextBox();
            this.cmbType = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lblAddRoomNo = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblAddroom = new System.Windows.Forms.Label();
            this.tabPageSearchRoom = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvRoom = new System.Windows.Forms.DataGridView();
            this.dgvRoomNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvRoomType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvBookingPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvIsStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvIsSmoking = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtSearchRoomNo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tabPageUpDateAndDelete = new System.Windows.Forms.TabPage();
            this.lblBookingpriceUp = new System.Windows.Forms.Label();
            this.cmbStatusUp = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtRoomNoUp = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.rdbNo2 = new System.Windows.Forms.RadioButton();
            this.rdbYes2 = new System.Windows.Forms.RadioButton();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbTypeUp = new System.Windows.Forms.ComboBox();
            this.txtBookingPriceUp = new System.Windows.Forms.TextBox();
            this.lblType = new System.Windows.Forms.Label();
            this.tabControlRoom.SuspendLayout();
            this.tabPageAddRoom.SuspendLayout();
            this.tabPageSearchRoom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRoom)).BeginInit();
            this.tabPageUpDateAndDelete.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControlRoom
            // 
            this.tabControlRoom.Alignment = System.Windows.Forms.TabAlignment.Bottom;
            this.tabControlRoom.Controls.Add(this.tabPageAddRoom);
            this.tabControlRoom.Controls.Add(this.tabPageSearchRoom);
            this.tabControlRoom.Controls.Add(this.tabPageUpDateAndDelete);
            this.tabControlRoom.Location = new System.Drawing.Point(36, 14);
            this.tabControlRoom.Name = "tabControlRoom";
            this.tabControlRoom.SelectedIndex = 0;
            this.tabControlRoom.Size = new System.Drawing.Size(1046, 657);
            this.tabControlRoom.TabIndex = 0;
            this.tabControlRoom.SelectedIndexChanged += new System.EventHandler(this.tabControlRoom_SelectedIndexChanged);
            // 
            // tabPageAddRoom
            // 
            this.tabPageAddRoom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(238)))), ((int)(((byte)(224)))));
            this.tabPageAddRoom.Controls.Add(this.txtRoomNo);
            this.tabPageAddRoom.Controls.Add(this.cmbStatus);
            this.tabPageAddRoom.Controls.Add(this.lblStatus);
            this.tabPageAddRoom.Controls.Add(this.btnAdd);
            this.tabPageAddRoom.Controls.Add(this.label1);
            this.tabPageAddRoom.Controls.Add(this.rdbYes);
            this.tabPageAddRoom.Controls.Add(this.rdbNo);
            this.tabPageAddRoom.Controls.Add(this.txtBookingPrice);
            this.tabPageAddRoom.Controls.Add(this.cmbType);
            this.tabPageAddRoom.Controls.Add(this.label4);
            this.tabPageAddRoom.Controls.Add(this.lblAddRoomNo);
            this.tabPageAddRoom.Controls.Add(this.label6);
            this.tabPageAddRoom.Controls.Add(this.lblAddroom);
            this.tabPageAddRoom.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(128)))), ((int)(((byte)(235)))));
            this.tabPageAddRoom.Location = new System.Drawing.Point(4, 4);
            this.tabPageAddRoom.Name = "tabPageAddRoom";
            this.tabPageAddRoom.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageAddRoom.Size = new System.Drawing.Size(1038, 625);
            this.tabPageAddRoom.TabIndex = 0;
            this.tabPageAddRoom.Text = "ADD ROOM";
            this.tabPageAddRoom.Leave += new System.EventHandler(this.tabPageAddRoom_Leave);
            // 
            // txtRoomNo
            // 
            this.txtRoomNo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRoomNo.Location = new System.Drawing.Point(571, 149);
            this.txtRoomNo.Name = "txtRoomNo";
            this.txtRoomNo.Size = new System.Drawing.Size(350, 32);
            this.txtRoomNo.TabIndex = 2;
            this.txtRoomNo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtRoomNo_KeyPress);
            // 
            // cmbStatus
            // 
            this.cmbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbStatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbStatus.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbStatus.FormattingEnabled = true;
            this.cmbStatus.Items.AddRange(new object[] {
            "Available",
            "Not Available"});
            this.cmbStatus.Location = new System.Drawing.Point(91, 395);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Size = new System.Drawing.Size(315, 31);
            this.cmbStatus.TabIndex = 4;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.lblStatus.Location = new System.Drawing.Point(87, 340);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(72, 23);
            this.lblStatus.TabIndex = 0;
            this.lblStatus.Text = "Status:";
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
            this.btnAdd.Location = new System.Drawing.Point(277, 519);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(405, 45);
            this.btnAdd.TabIndex = 6;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.label1.Location = new System.Drawing.Point(23, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Add Room :";
            // 
            // rdbYes
            // 
            this.rdbYes.AutoSize = true;
            this.rdbYes.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbYes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.rdbYes.Location = new System.Drawing.Point(727, 252);
            this.rdbYes.Name = "rdbYes";
            this.rdbYes.Size = new System.Drawing.Size(65, 27);
            this.rdbYes.TabIndex = 5;
            this.rdbYes.TabStop = true;
            this.rdbYes.Text = "Yes";
            this.rdbYes.UseVisualStyleBackColor = true;
            // 
            // rdbNo
            // 
            this.rdbNo.AutoSize = true;
            this.rdbNo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbNo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.rdbNo.Location = new System.Drawing.Point(727, 319);
            this.rdbNo.Name = "rdbNo";
            this.rdbNo.Size = new System.Drawing.Size(59, 27);
            this.rdbNo.TabIndex = 5;
            this.rdbNo.TabStop = true;
            this.rdbNo.Text = "No";
            this.rdbNo.UseVisualStyleBackColor = true;
            // 
            // txtBookingPrice
            // 
            this.txtBookingPrice.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBookingPrice.Location = new System.Drawing.Point(91, 281);
            this.txtBookingPrice.Name = "txtBookingPrice";
            this.txtBookingPrice.Size = new System.Drawing.Size(315, 32);
            this.txtBookingPrice.TabIndex = 3;
            this.txtBookingPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBookingPrice_KeyPress);
            // 
            // cmbType
            // 
            this.cmbType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbType.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbType.FormattingEnabled = true;
            this.cmbType.Items.AddRange(new object[] {
            "Standard",
            "Deluxe",
            "Family",
            "Business"});
            this.cmbType.Location = new System.Drawing.Point(91, 150);
            this.cmbType.Name = "cmbType";
            this.cmbType.Size = new System.Drawing.Size(315, 31);
            this.cmbType.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.label4.Location = new System.Drawing.Point(87, 230);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(144, 23);
            this.label4.TabIndex = 0;
            this.label4.Text = "Booking Price";
            // 
            // lblAddRoomNo
            // 
            this.lblAddRoomNo.AutoSize = true;
            this.lblAddRoomNo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddRoomNo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.lblAddRoomNo.Location = new System.Drawing.Point(567, 97);
            this.lblAddRoomNo.Name = "lblAddRoomNo";
            this.lblAddRoomNo.Size = new System.Drawing.Size(107, 23);
            this.lblAddRoomNo.TabIndex = 0;
            this.lblAddRoomNo.Text = "Room No.";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.label6.Location = new System.Drawing.Point(553, 286);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(121, 23);
            this.label6.TabIndex = 0;
            this.label6.Text = "Is Smoking:";
            // 
            // lblAddroom
            // 
            this.lblAddroom.AutoSize = true;
            this.lblAddroom.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddroom.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.lblAddroom.Location = new System.Drawing.Point(87, 97);
            this.lblAddroom.Name = "lblAddroom";
            this.lblAddroom.Size = new System.Drawing.Size(62, 23);
            this.lblAddroom.TabIndex = 0;
            this.lblAddroom.Text = "Type:";
            // 
            // tabPageSearchRoom
            // 
            this.tabPageSearchRoom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(247)))), ((int)(((byte)(255)))));
            this.tabPageSearchRoom.Controls.Add(this.label3);
            this.tabPageSearchRoom.Controls.Add(this.dgvRoom);
            this.tabPageSearchRoom.Controls.Add(this.txtSearchRoomNo);
            this.tabPageSearchRoom.Controls.Add(this.label5);
            this.tabPageSearchRoom.Location = new System.Drawing.Point(4, 4);
            this.tabPageSearchRoom.Name = "tabPageSearchRoom";
            this.tabPageSearchRoom.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageSearchRoom.Size = new System.Drawing.Size(1038, 625);
            this.tabPageSearchRoom.TabIndex = 1;
            this.tabPageSearchRoom.Text = "SEARCH ROOM";
            this.tabPageSearchRoom.Leave += new System.EventHandler(this.tabPageSearchRoom_Leave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(128)))), ((int)(((byte)(235)))));
            this.label3.Location = new System.Drawing.Point(6, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(138, 22);
            this.label3.TabIndex = 0;
            this.label3.Text = "Search Room :";
            // 
            // dgvRoom
            // 
            this.dgvRoom.AllowUserToAddRows = false;
            this.dgvRoom.AllowUserToDeleteRows = false;
            this.dgvRoom.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvRoom.BackgroundColor = System.Drawing.Color.White;
            this.dgvRoom.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRoom.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvRoomNo,
            this.dgvRoomType,
            this.dgvBookingPrice,
            this.dgvIsStatus,
            this.dgvIsSmoking});
            this.dgvRoom.Location = new System.Drawing.Point(6, 148);
            this.dgvRoom.Name = "dgvRoom";
            this.dgvRoom.ReadOnly = true;
            this.dgvRoom.RowHeadersWidth = 51;
            this.dgvRoom.RowTemplate.Height = 24;
            this.dgvRoom.Size = new System.Drawing.Size(1010, 411);
            this.dgvRoom.TabIndex = 3;
            // 
            // dgvRoomNo
            // 
            this.dgvRoomNo.HeaderText = "No.";
            this.dgvRoomNo.MinimumWidth = 6;
            this.dgvRoomNo.Name = "dgvRoomNo";
            this.dgvRoomNo.ReadOnly = true;
            // 
            // dgvRoomType
            // 
            this.dgvRoomType.HeaderText = "Type";
            this.dgvRoomType.MinimumWidth = 6;
            this.dgvRoomType.Name = "dgvRoomType";
            this.dgvRoomType.ReadOnly = true;
            // 
            // dgvBookingPrice
            // 
            this.dgvBookingPrice.HeaderText = "Booking Price";
            this.dgvBookingPrice.MinimumWidth = 6;
            this.dgvBookingPrice.Name = "dgvBookingPrice";
            this.dgvBookingPrice.ReadOnly = true;
            // 
            // dgvIsStatus
            // 
            this.dgvIsStatus.HeaderText = "Is Status";
            this.dgvIsStatus.MinimumWidth = 6;
            this.dgvIsStatus.Name = "dgvIsStatus";
            this.dgvIsStatus.ReadOnly = true;
            // 
            // dgvIsSmoking
            // 
            this.dgvIsSmoking.HeaderText = "Is Smoking";
            this.dgvIsSmoking.MinimumWidth = 6;
            this.dgvIsSmoking.Name = "dgvIsSmoking";
            this.dgvIsSmoking.ReadOnly = true;
            // 
            // txtSearchRoomNo
            // 
            this.txtSearchRoomNo.Location = new System.Drawing.Point(187, 76);
            this.txtSearchRoomNo.Multiline = true;
            this.txtSearchRoomNo.Name = "txtSearchRoomNo";
            this.txtSearchRoomNo.Size = new System.Drawing.Size(358, 42);
            this.txtSearchRoomNo.TabIndex = 2;
            this.txtSearchRoomNo.TextChanged += new System.EventHandler(this.txtSearchRoomNo_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(128)))), ((int)(((byte)(235)))));
            this.label5.Location = new System.Drawing.Point(183, 45);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(119, 23);
            this.label5.TabIndex = 1;
            this.label5.Text = "Room No. :";
            // 
            // tabPageUpDateAndDelete
            // 
            this.tabPageUpDateAndDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(238)))), ((int)(((byte)(224)))));
            this.tabPageUpDateAndDelete.Controls.Add(this.lblBookingpriceUp);
            this.tabPageUpDateAndDelete.Controls.Add(this.cmbStatusUp);
            this.tabPageUpDateAndDelete.Controls.Add(this.label9);
            this.tabPageUpDateAndDelete.Controls.Add(this.txtRoomNoUp);
            this.tabPageUpDateAndDelete.Controls.Add(this.label8);
            this.tabPageUpDateAndDelete.Controls.Add(this.btnDelete);
            this.tabPageUpDateAndDelete.Controls.Add(this.btnUpdate);
            this.tabPageUpDateAndDelete.Controls.Add(this.label2);
            this.tabPageUpDateAndDelete.Controls.Add(this.rdbNo2);
            this.tabPageUpDateAndDelete.Controls.Add(this.rdbYes2);
            this.tabPageUpDateAndDelete.Controls.Add(this.label7);
            this.tabPageUpDateAndDelete.Controls.Add(this.cmbTypeUp);
            this.tabPageUpDateAndDelete.Controls.Add(this.txtBookingPriceUp);
            this.tabPageUpDateAndDelete.Controls.Add(this.lblType);
            this.tabPageUpDateAndDelete.Location = new System.Drawing.Point(4, 4);
            this.tabPageUpDateAndDelete.Name = "tabPageUpDateAndDelete";
            this.tabPageUpDateAndDelete.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageUpDateAndDelete.Size = new System.Drawing.Size(1038, 625);
            this.tabPageUpDateAndDelete.TabIndex = 2;
            this.tabPageUpDateAndDelete.Text = "UPDATE AND DELETE ROOM";
            this.tabPageUpDateAndDelete.Leave += new System.EventHandler(this.tabPageUpDateAndDelete_Leave);
            // 
            // lblBookingpriceUp
            // 
            this.lblBookingpriceUp.AutoSize = true;
            this.lblBookingpriceUp.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBookingpriceUp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(128)))), ((int)(((byte)(235)))));
            this.lblBookingpriceUp.Location = new System.Drawing.Point(83, 222);
            this.lblBookingpriceUp.Name = "lblBookingpriceUp";
            this.lblBookingpriceUp.Size = new System.Drawing.Size(144, 23);
            this.lblBookingpriceUp.TabIndex = 14;
            this.lblBookingpriceUp.Text = "Booking Price";
            // 
            // cmbStatusUp
            // 
            this.cmbStatusUp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbStatusUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbStatusUp.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbStatusUp.FormattingEnabled = true;
            this.cmbStatusUp.Items.AddRange(new object[] {
            "Available",
            "Not Available"});
            this.cmbStatusUp.Location = new System.Drawing.Point(86, 396);
            this.cmbStatusUp.Name = "cmbStatusUp";
            this.cmbStatusUp.Size = new System.Drawing.Size(325, 31);
            this.cmbStatusUp.TabIndex = 13;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(128)))), ((int)(((byte)(235)))));
            this.label9.Location = new System.Drawing.Point(82, 338);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(72, 23);
            this.label9.TabIndex = 12;
            this.label9.Text = "Status:";
            // 
            // txtRoomNoUp
            // 
            this.txtRoomNoUp.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRoomNoUp.Location = new System.Drawing.Point(533, 144);
            this.txtRoomNoUp.Name = "txtRoomNoUp";
            this.txtRoomNoUp.Size = new System.Drawing.Size(338, 32);
            this.txtRoomNoUp.TabIndex = 10;
            this.txtRoomNoUp.TextChanged += new System.EventHandler(this.txtRoomNoUp_TextChanged);
            this.txtRoomNoUp.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtRoomNoUp_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(128)))), ((int)(((byte)(235)))));
            this.label8.Location = new System.Drawing.Point(529, 101);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(107, 23);
            this.label8.TabIndex = 9;
            this.label8.Text = "Room No.";
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(73)))), ((int)(((byte)(73)))));
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(533, 486);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(338, 45);
            this.btnDelete.TabIndex = 8;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(128)))), ((int)(((byte)(235)))));
            this.btnUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdate.FlatAppearance.BorderSize = 0;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnUpdate.Location = new System.Drawing.Point(86, 486);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(325, 45);
            this.btnUpdate.TabIndex = 7;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(128)))), ((int)(((byte)(235)))));
            this.label2.Location = new System.Drawing.Point(17, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(270, 23);
            this.label2.TabIndex = 6;
            this.label2.Text = "Update and Delete Room :";
            // 
            // rdbNo2
            // 
            this.rdbNo2.AutoSize = true;
            this.rdbNo2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbNo2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(128)))), ((int)(((byte)(235)))));
            this.rdbNo2.Location = new System.Drawing.Point(702, 305);
            this.rdbNo2.Name = "rdbNo2";
            this.rdbNo2.Size = new System.Drawing.Size(59, 27);
            this.rdbNo2.TabIndex = 4;
            this.rdbNo2.TabStop = true;
            this.rdbNo2.Text = "No";
            this.rdbNo2.UseVisualStyleBackColor = true;
            // 
            // rdbYes2
            // 
            this.rdbYes2.AutoSize = true;
            this.rdbYes2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbYes2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(128)))), ((int)(((byte)(235)))));
            this.rdbYes2.Location = new System.Drawing.Point(702, 244);
            this.rdbYes2.Name = "rdbYes2";
            this.rdbYes2.Size = new System.Drawing.Size(65, 27);
            this.rdbYes2.TabIndex = 4;
            this.rdbYes2.TabStop = true;
            this.rdbYes2.Text = "Yes";
            this.rdbYes2.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(128)))), ((int)(((byte)(235)))));
            this.label7.Location = new System.Drawing.Point(515, 274);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(121, 23);
            this.label7.TabIndex = 3;
            this.label7.Text = "Is Smoking:";
            // 
            // cmbTypeUp
            // 
            this.cmbTypeUp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTypeUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbTypeUp.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTypeUp.FormattingEnabled = true;
            this.cmbTypeUp.Items.AddRange(new object[] {
            "Standard",
            "Deluxe",
            "Family",
            "Business"});
            this.cmbTypeUp.Location = new System.Drawing.Point(86, 144);
            this.cmbTypeUp.Name = "cmbTypeUp";
            this.cmbTypeUp.Size = new System.Drawing.Size(325, 31);
            this.cmbTypeUp.TabIndex = 2;
            // 
            // txtBookingPriceUp
            // 
            this.txtBookingPriceUp.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBookingPriceUp.Location = new System.Drawing.Point(87, 265);
            this.txtBookingPriceUp.Name = "txtBookingPriceUp";
            this.txtBookingPriceUp.Size = new System.Drawing.Size(324, 32);
            this.txtBookingPriceUp.TabIndex = 1;
            this.txtBookingPriceUp.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBookingPriceUp_KeyPress);
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(128)))), ((int)(((byte)(235)))));
            this.lblType.Location = new System.Drawing.Point(82, 97);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(62, 23);
            this.lblType.TabIndex = 0;
            this.lblType.Text = "Type:";
            // 
            // UserControlRoom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(236)))), ((int)(((byte)(236)))));
            this.Controls.Add(this.tabControlRoom);
            this.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "UserControlRoom";
            this.Size = new System.Drawing.Size(1102, 702);
            this.tabControlRoom.ResumeLayout(false);
            this.tabPageAddRoom.ResumeLayout(false);
            this.tabPageAddRoom.PerformLayout();
            this.tabPageSearchRoom.ResumeLayout(false);
            this.tabPageSearchRoom.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRoom)).EndInit();
            this.tabPageUpDateAndDelete.ResumeLayout(false);
            this.tabPageUpDateAndDelete.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlRoom;
        private System.Windows.Forms.TabPage tabPageAddRoom;
        private System.Windows.Forms.TabPage tabPageSearchRoom;
        private System.Windows.Forms.TabPage tabPageUpDateAndDelete;
        private System.Windows.Forms.TextBox txtBookingPriceUp;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.ComboBox cmbTypeUp;
        private System.Windows.Forms.RadioButton rdbNo2;
        private System.Windows.Forms.ComboBox cmbType;
        private System.Windows.Forms.Label lblAddRoomNo;
        private System.Windows.Forms.Label lblAddroom;
      //  private DevExpress.XtraBars.Ribbon.RadialMenu radialMenu2;
        private System.Windows.Forms.TextBox txtSearchRoomNo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dgvRoom;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.RadioButton rdbYes;
        private System.Windows.Forms.RadioButton rdbNo;
        private System.Windows.Forms.TextBox txtBookingPrice;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.RadioButton rdbYes2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbStatus;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.TextBox txtRoomNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvRoomNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvRoomType;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvBookingPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvIsStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvIsSmoking;
        private System.Windows.Forms.ComboBox cmbStatusUp;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtRoomNoUp;
        private System.Windows.Forms.Label lblBookingpriceUp;
    }
}
