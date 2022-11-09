namespace $safeprojectname$
{
    partial class Reservations
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
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader11 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader12 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader13 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.BtnRefresh = new System.Windows.Forms.Button();
            this.BtnUpdate = new System.Windows.Forms.Button();
            this.BtnDelete = new System.Windows.Forms.Button();
            this.BtnSearch = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label17 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.TxtDays = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.TxtPayment = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.TxtRoomNumber = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.DtpCheckout = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.DtpCheckin = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtAddress = new System.Windows.Forms.RichTextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.MskTxtPhoneNumber = new System.Windows.Forms.MaskedTextBox();
            this.TxtSurname = new System.Windows.Forms.TextBox();
            this.TxtName = new System.Windows.Forms.TextBox();
            this.TxtEmail = new System.Windows.Forms.TextBox();
            this.TxtTcnumber = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnClear = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader9,
            this.columnHeader10,
            this.columnHeader11,
            this.columnHeader12,
            this.columnHeader13});
            this.listView1.Location = new System.Drawing.Point(9, 410);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(1067, 388);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.ListView1_MouseDoubleClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "TcNumber";
            this.columnHeader1.Width = 78;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Name";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "LastName";
            this.columnHeader3.Width = 79;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Address";
            this.columnHeader4.Width = 119;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "DateofBirth";
            this.columnHeader5.Width = 97;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Gender";
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Email";
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "PhoneNumber";
            this.columnHeader8.Width = 107;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Check-In";
            this.columnHeader9.Width = 82;
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "Check-Out";
            this.columnHeader10.Width = 82;
            // 
            // columnHeader11
            // 
            this.columnHeader11.Text = "NumofDays";
            this.columnHeader11.Width = 90;
            // 
            // columnHeader12
            // 
            this.columnHeader12.Text = "RoomID";
            this.columnHeader12.Width = 79;
            // 
            // columnHeader13
            // 
            this.columnHeader13.Text = "Payment";
            this.columnHeader13.Width = 77;
            // 
            // BtnRefresh
            // 
            this.BtnRefresh.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnRefresh.Location = new System.Drawing.Point(9, 354);
            this.BtnRefresh.Name = "BtnRefresh";
            this.BtnRefresh.Size = new System.Drawing.Size(138, 47);
            this.BtnRefresh.TabIndex = 1;
            this.BtnRefresh.Text = "Refresh";
            this.BtnRefresh.UseVisualStyleBackColor = true;
            this.BtnRefresh.Click += new System.EventHandler(this.Button1_Click);
            // 
            // BtnUpdate
            // 
            this.BtnUpdate.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnUpdate.Location = new System.Drawing.Point(153, 354);
            this.BtnUpdate.Name = "BtnUpdate";
            this.BtnUpdate.Size = new System.Drawing.Size(138, 47);
            this.BtnUpdate.TabIndex = 2;
            this.BtnUpdate.Text = "Update";
            this.BtnUpdate.UseVisualStyleBackColor = true;
            this.BtnUpdate.Click += new System.EventHandler(this.BtnUpdate_Click);
            // 
            // BtnDelete
            // 
            this.BtnDelete.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnDelete.Location = new System.Drawing.Point(297, 354);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(138, 47);
            this.BtnDelete.TabIndex = 3;
            this.BtnDelete.Text = "Delete";
            this.BtnDelete.UseVisualStyleBackColor = true;
            this.BtnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // BtnSearch
            // 
            this.BtnSearch.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnSearch.Location = new System.Drawing.Point(612, 354);
            this.BtnSearch.Name = "BtnSearch";
            this.BtnSearch.Size = new System.Drawing.Size(138, 47);
            this.BtnSearch.TabIndex = 4;
            this.BtnSearch.Text = "Search";
            this.BtnSearch.UseVisualStyleBackColor = true;
            this.BtnSearch.Click += new System.EventHandler(this.BtnSearch_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.Info;
            this.textBox1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox1.Location = new System.Drawing.Point(756, 364);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(320, 30);
            this.textBox1.TabIndex = 54;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label17);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.TxtDays);
            this.groupBox1.Controls.Add(this.label19);
            this.groupBox1.Controls.Add(this.TxtPayment);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.TxtRoomNumber);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.DtpCheckout);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.DtpCheckin);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.TxtAddress);
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.MskTxtPhoneNumber);
            this.groupBox1.Controls.Add(this.TxtSurname);
            this.groupBox1.Controls.Add(this.TxtName);
            this.groupBox1.Controls.Add(this.TxtEmail);
            this.groupBox1.Controls.Add(this.TxtTcnumber);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 1);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1064, 347);
            this.groupBox1.TabIndex = 97;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Informations";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Segoe Print", 13.8F, System.Drawing.FontStyle.Bold);
            this.label17.Location = new System.Drawing.Point(558, 290);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(203, 43);
            this.label17.TabIndex = 122;
            this.label17.Text = "Date Of Birth :";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarFont = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dateTimePicker1.CalendarTitleBackColor = System.Drawing.SystemColors.ControlText;
            this.dateTimePicker1.CalendarTitleForeColor = System.Drawing.SystemColors.HotTrack;
            this.dateTimePicker1.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dateTimePicker1.Location = new System.Drawing.Point(780, 298);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(278, 27);
            this.dateTimePicker1.TabIndex = 121;
            // 
            // TxtDays
            // 
            this.TxtDays.BackColor = System.Drawing.SystemColors.Info;
            this.TxtDays.Enabled = false;
            this.TxtDays.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtDays.Location = new System.Drawing.Point(220, 307);
            this.TxtDays.Name = "TxtDays";
            this.TxtDays.Size = new System.Drawing.Size(250, 30);
            this.TxtDays.TabIndex = 120;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Segoe Print", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label19.Location = new System.Drawing.Point(11, 300);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(112, 43);
            this.label19.TabIndex = 119;
            this.label19.Text = "Day(s) :";
            // 
            // TxtPayment
            // 
            this.TxtPayment.BackColor = System.Drawing.SystemColors.Info;
            this.TxtPayment.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtPayment.Location = new System.Drawing.Point(780, 254);
            this.TxtPayment.Name = "TxtPayment";
            this.TxtPayment.Size = new System.Drawing.Size(250, 30);
            this.TxtPayment.TabIndex = 118;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Segoe Print", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label14.Location = new System.Drawing.Point(558, 247);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(144, 43);
            this.label14.TabIndex = 117;
            this.label14.Text = "Payment :";
            // 
            // TxtRoomNumber
            // 
            this.TxtRoomNumber.BackColor = System.Drawing.SystemColors.Info;
            this.TxtRoomNumber.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtRoomNumber.Location = new System.Drawing.Point(780, 35);
            this.TxtRoomNumber.Name = "TxtRoomNumber";
            this.TxtRoomNumber.Size = new System.Drawing.Size(250, 30);
            this.TxtRoomNumber.TabIndex = 116;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe Print", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label13.Location = new System.Drawing.Point(558, 31);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(211, 43);
            this.label13.TabIndex = 115;
            this.label13.Text = "Room Number :";
            // 
            // DtpCheckout
            // 
            this.DtpCheckout.CalendarFont = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.DtpCheckout.CalendarTitleBackColor = System.Drawing.SystemColors.ControlText;
            this.DtpCheckout.CalendarTitleForeColor = System.Drawing.SystemColors.HotTrack;
            this.DtpCheckout.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.DtpCheckout.Location = new System.Drawing.Point(220, 260);
            this.DtpCheckout.Name = "DtpCheckout";
            this.DtpCheckout.Size = new System.Drawing.Size(296, 27);
            this.DtpCheckout.TabIndex = 114;
            this.DtpCheckout.ValueChanged += new System.EventHandler(this.DtpCheckout_ValueChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe Print", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(10, 257);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(166, 43);
            this.label6.TabIndex = 113;
            this.label6.Text = "Check-Out :";
            // 
            // DtpCheckin
            // 
            this.DtpCheckin.CalendarFont = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.DtpCheckin.CalendarTitleBackColor = System.Drawing.SystemColors.ControlText;
            this.DtpCheckin.CalendarTitleForeColor = System.Drawing.SystemColors.HotTrack;
            this.DtpCheckin.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.DtpCheckin.Location = new System.Drawing.Point(220, 222);
            this.DtpCheckin.Name = "DtpCheckin";
            this.DtpCheckin.Size = new System.Drawing.Size(296, 27);
            this.DtpCheckin.TabIndex = 112;
            this.DtpCheckin.ValueChanged += new System.EventHandler(this.DtpCheckin_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe Print", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(10, 214);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(145, 43);
            this.label4.TabIndex = 111;
            this.label4.Text = "Check-In :";
            // 
            // TxtAddress
            // 
            this.TxtAddress.BackColor = System.Drawing.SystemColors.Info;
            this.TxtAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtAddress.Location = new System.Drawing.Point(780, 167);
            this.TxtAddress.Name = "TxtAddress";
            this.TxtAddress.Size = new System.Drawing.Size(250, 68);
            this.TxtAddress.TabIndex = 109;
            this.TxtAddress.Text = "";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Segoe Print", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label16.Location = new System.Drawing.Point(558, 112);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(119, 43);
            this.label16.TabIndex = 110;
            this.label16.Text = "E-mail :";
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.SystemColors.Info;
            this.comboBox1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.comboBox1.Location = new System.Drawing.Point(220, 167);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(250, 32);
            this.comboBox1.TabIndex = 108;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Segoe Print", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label15.Location = new System.Drawing.Point(11, 161);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(123, 43);
            this.label15.TabIndex = 107;
            this.label15.Text = "Gender :";
            // 
            // MskTxtPhoneNumber
            // 
            this.MskTxtPhoneNumber.BackColor = System.Drawing.SystemColors.Info;
            this.MskTxtPhoneNumber.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.MskTxtPhoneNumber.Location = new System.Drawing.Point(780, 78);
            this.MskTxtPhoneNumber.Mask = "(999) 000-0000";
            this.MskTxtPhoneNumber.Name = "MskTxtPhoneNumber";
            this.MskTxtPhoneNumber.Size = new System.Drawing.Size(250, 30);
            this.MskTxtPhoneNumber.TabIndex = 106;
            // 
            // TxtSurname
            // 
            this.TxtSurname.BackColor = System.Drawing.SystemColors.Info;
            this.TxtSurname.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtSurname.Location = new System.Drawing.Point(220, 124);
            this.TxtSurname.Name = "TxtSurname";
            this.TxtSurname.Size = new System.Drawing.Size(250, 30);
            this.TxtSurname.TabIndex = 105;
            // 
            // TxtName
            // 
            this.TxtName.BackColor = System.Drawing.SystemColors.Info;
            this.TxtName.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtName.Location = new System.Drawing.Point(220, 81);
            this.TxtName.Name = "TxtName";
            this.TxtName.Size = new System.Drawing.Size(250, 30);
            this.TxtName.TabIndex = 104;
            // 
            // TxtEmail
            // 
            this.TxtEmail.BackColor = System.Drawing.SystemColors.Info;
            this.TxtEmail.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtEmail.Location = new System.Drawing.Point(780, 125);
            this.TxtEmail.Name = "TxtEmail";
            this.TxtEmail.Size = new System.Drawing.Size(250, 30);
            this.TxtEmail.TabIndex = 103;
            // 
            // TxtTcnumber
            // 
            this.TxtTcnumber.BackColor = System.Drawing.SystemColors.Info;
            this.TxtTcnumber.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtTcnumber.Location = new System.Drawing.Point(220, 38);
            this.TxtTcnumber.MaxLength = 11;
            this.TxtTcnumber.Name = "TxtTcnumber";
            this.TxtTcnumber.Size = new System.Drawing.Size(250, 30);
            this.TxtTcnumber.TabIndex = 102;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe Print", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(6, 28);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(181, 43);
            this.label7.TabIndex = 101;
            this.label7.Text = "T.C Number :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe Print", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(11, 114);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(144, 43);
            this.label5.TabIndex = 100;
            this.label5.Text = "Surname :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe Print", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(558, 167);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 43);
            this.label3.TabIndex = 99;
            this.label3.Text = "Address :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe Print", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(558, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(216, 43);
            this.label2.TabIndex = 98;
            this.label2.Text = "Phone Number :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(11, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 43);
            this.label1.TabIndex = 97;
            this.label1.Text = "Name :";
            // 
            // BtnClear
            // 
            this.BtnClear.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnClear.Location = new System.Drawing.Point(441, 354);
            this.BtnClear.Name = "BtnClear";
            this.BtnClear.Size = new System.Drawing.Size(138, 47);
            this.BtnClear.TabIndex = 98;
            this.BtnClear.Text = "Clear";
            this.BtnClear.UseVisualStyleBackColor = true;
            this.BtnClear.Click += new System.EventHandler(this.BtnClear_Click);
            // 
            // Reservations
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.LightCoral;
            this.ClientSize = new System.Drawing.Size(1086, 801);
            this.Controls.Add(this.BtnClear);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.BtnSearch);
            this.Controls.Add(this.BtnDelete);
            this.Controls.Add(this.BtnUpdate);
            this.Controls.Add(this.BtnRefresh);
            this.Controls.Add(this.listView1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Reservations";
            this.Text = "FrmReservations";
            this.Load += new System.EventHandler(this.FrmGuests_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Button BtnRefresh;
        private System.Windows.Forms.Button BtnUpdate;
        private System.Windows.Forms.Button BtnDelete;
        private System.Windows.Forms.Button BtnSearch;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.ColumnHeader columnHeader11;
        private System.Windows.Forms.ColumnHeader columnHeader12;
        private System.Windows.Forms.ColumnHeader columnHeader13;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox TxtDays;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox TxtPayment;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox TxtRoomNumber;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DateTimePicker DtpCheckout;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker DtpCheckin;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RichTextBox TxtAddress;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.MaskedTextBox MskTxtPhoneNumber;
        private System.Windows.Forms.TextBox TxtSurname;
        private System.Windows.Forms.TextBox TxtName;
        private System.Windows.Forms.TextBox TxtEmail;
        private System.Windows.Forms.TextBox TxtTcnumber;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnClear;
    }
}