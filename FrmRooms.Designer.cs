namespace $safeprojectname$
{
    partial class FrmRooms
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
            this.BtnClear = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.BtnSearch = new System.Windows.Forms.Button();
            this.BtnDelete = new System.Windows.Forms.Button();
            this.BtnUpdate = new System.Windows.Forms.Button();
            this.BtnRefresh = new System.Windows.Forms.Button();
            this.TxtNumofSingleBed = new System.Windows.Forms.TextBox();
            this.TxtRoomID = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtNumofDoubleBed = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtFloor = new System.Windows.Forms.TextBox();
            this.TxtDailyPayment = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.TxtExtras = new System.Windows.Forms.RichTextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.BtnAdd = new System.Windows.Forms.Button();
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
            this.columnHeader7});
            this.listView1.Location = new System.Drawing.Point(12, 229);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(851, 379);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.ListView1_MouseDoubleClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "RoomID";
            this.columnHeader1.Width = 113;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Status";
            this.columnHeader2.Width = 89;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "NumofSingleBed";
            this.columnHeader3.Width = 140;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "NumofDoubleBed";
            this.columnHeader4.Width = 128;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "DailyPayment";
            this.columnHeader5.Width = 127;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Floor";
            this.columnHeader6.Width = 81;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Extras";
            this.columnHeader7.Width = 72;
            // 
            // BtnClear
            // 
            this.BtnClear.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnClear.Location = new System.Drawing.Point(330, 181);
            this.BtnClear.Name = "BtnClear";
            this.BtnClear.Size = new System.Drawing.Size(105, 38);
            this.BtnClear.TabIndex = 104;
            this.BtnClear.Text = "Clear";
            this.BtnClear.UseVisualStyleBackColor = true;
            this.BtnClear.Click += new System.EventHandler(this.BtnClear_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.Info;
            this.textBox1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox1.Location = new System.Drawing.Point(657, 187);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(198, 30);
            this.textBox1.TabIndex = 103;
            // 
            // BtnSearch
            // 
            this.BtnSearch.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnSearch.Location = new System.Drawing.Point(551, 183);
            this.BtnSearch.Name = "BtnSearch";
            this.BtnSearch.Size = new System.Drawing.Size(100, 35);
            this.BtnSearch.TabIndex = 102;
            this.BtnSearch.Text = "Search";
            this.BtnSearch.UseVisualStyleBackColor = true;
            this.BtnSearch.Click += new System.EventHandler(this.BtnSearch_Click);
            // 
            // BtnDelete
            // 
            this.BtnDelete.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnDelete.Location = new System.Drawing.Point(224, 181);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(105, 38);
            this.BtnDelete.TabIndex = 101;
            this.BtnDelete.Text = "Delete";
            this.BtnDelete.UseVisualStyleBackColor = true;
            this.BtnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // BtnUpdate
            // 
            this.BtnUpdate.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnUpdate.Location = new System.Drawing.Point(118, 181);
            this.BtnUpdate.Name = "BtnUpdate";
            this.BtnUpdate.Size = new System.Drawing.Size(105, 38);
            this.BtnUpdate.TabIndex = 100;
            this.BtnUpdate.Text = "Update";
            this.BtnUpdate.UseVisualStyleBackColor = true;
            this.BtnUpdate.Click += new System.EventHandler(this.BtnUpdate_Click);
            // 
            // BtnRefresh
            // 
            this.BtnRefresh.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnRefresh.Location = new System.Drawing.Point(12, 181);
            this.BtnRefresh.Name = "BtnRefresh";
            this.BtnRefresh.Size = new System.Drawing.Size(105, 38);
            this.BtnRefresh.TabIndex = 99;
            this.BtnRefresh.Text = "Refresh";
            this.BtnRefresh.UseVisualStyleBackColor = true;
            this.BtnRefresh.Click += new System.EventHandler(this.BtnRefresh_Click_1);
            // 
            // TxtNumofSingleBed
            // 
            this.TxtNumofSingleBed.BackColor = System.Drawing.SystemColors.Info;
            this.TxtNumofSingleBed.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtNumofSingleBed.Location = new System.Drawing.Point(224, 86);
            this.TxtNumofSingleBed.Name = "TxtNumofSingleBed";
            this.TxtNumofSingleBed.Size = new System.Drawing.Size(195, 30);
            this.TxtNumofSingleBed.TabIndex = 111;
            // 
            // TxtRoomID
            // 
            this.TxtRoomID.BackColor = System.Drawing.SystemColors.Info;
            this.TxtRoomID.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtRoomID.Location = new System.Drawing.Point(224, 19);
            this.TxtRoomID.MaxLength = 11;
            this.TxtRoomID.Name = "TxtRoomID";
            this.TxtRoomID.Size = new System.Drawing.Size(195, 30);
            this.TxtRoomID.TabIndex = 109;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(10, 16);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(108, 35);
            this.label7.TabIndex = 108;
            this.label7.Text = "RoomID :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(15, 86);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(200, 35);
            this.label5.TabIndex = 107;
            this.label5.Text = "NumofSingleBed : ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(15, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 35);
            this.label1.TabIndex = 106;
            this.label1.Text = "Status : ";
            // 
            // TxtNumofDoubleBed
            // 
            this.TxtNumofDoubleBed.BackColor = System.Drawing.SystemColors.Info;
            this.TxtNumofDoubleBed.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtNumofDoubleBed.Location = new System.Drawing.Point(224, 121);
            this.TxtNumofDoubleBed.Name = "TxtNumofDoubleBed";
            this.TxtNumofDoubleBed.Size = new System.Drawing.Size(195, 30);
            this.TxtNumofDoubleBed.TabIndex = 113;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(15, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(208, 35);
            this.label2.TabIndex = 112;
            this.label2.Text = "NumofDoubleBed : ";
            // 
            // TxtFloor
            // 
            this.TxtFloor.BackColor = System.Drawing.SystemColors.Info;
            this.TxtFloor.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtFloor.Location = new System.Drawing.Point(619, 51);
            this.TxtFloor.Name = "TxtFloor";
            this.TxtFloor.Size = new System.Drawing.Size(195, 30);
            this.TxtFloor.TabIndex = 118;
            // 
            // TxtDailyPayment
            // 
            this.TxtDailyPayment.BackColor = System.Drawing.SystemColors.Info;
            this.TxtDailyPayment.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtDailyPayment.Location = new System.Drawing.Point(619, 19);
            this.TxtDailyPayment.MaxLength = 11;
            this.TxtDailyPayment.Name = "TxtDailyPayment";
            this.TxtDailyPayment.Size = new System.Drawing.Size(195, 30);
            this.TxtDailyPayment.TabIndex = 117;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(434, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(179, 35);
            this.label4.TabIndex = 116;
            this.label4.Text = "DailyPayment : ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(439, 86);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(101, 35);
            this.label6.TabIndex = 115;
            this.label6.Text = "Extras : ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(439, 51);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(87, 35);
            this.label8.TabIndex = 114;
            this.label8.Text = "Floor : ";
            // 
            // TxtExtras
            // 
            this.TxtExtras.BackColor = System.Drawing.SystemColors.Info;
            this.TxtExtras.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtExtras.Location = new System.Drawing.Point(619, 83);
            this.TxtExtras.Name = "TxtExtras";
            this.TxtExtras.Size = new System.Drawing.Size(195, 68);
            this.TxtExtras.TabIndex = 119;
            this.TxtExtras.Text = "";
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.SystemColors.Info;
            this.comboBox1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Empty",
            "Full"});
            this.comboBox1.Location = new System.Drawing.Point(224, 51);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(195, 32);
            this.comboBox1.TabIndex = 120;
            // 
            // BtnAdd
            // 
            this.BtnAdd.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnAdd.Location = new System.Drawing.Point(435, 181);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(105, 38);
            this.BtnAdd.TabIndex = 121;
            this.BtnAdd.Text = "Add";
            this.BtnAdd.UseVisualStyleBackColor = true;
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // FrmRooms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(867, 620);
            this.Controls.Add(this.BtnAdd);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.TxtExtras);
            this.Controls.Add(this.TxtFloor);
            this.Controls.Add(this.TxtDailyPayment);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.TxtNumofDoubleBed);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxtNumofSingleBed);
            this.Controls.Add(this.TxtRoomID);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnClear);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.BtnSearch);
            this.Controls.Add(this.BtnDelete);
            this.Controls.Add(this.BtnUpdate);
            this.Controls.Add(this.BtnRefresh);
            this.Controls.Add(this.listView1);
            this.Name = "FrmRooms";
            this.Text = "Rooms";
            this.Load += new System.EventHandler(this.FrmRooms_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.Button BtnClear;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button BtnSearch;
        private System.Windows.Forms.Button BtnDelete;
        private System.Windows.Forms.Button BtnUpdate;
        private System.Windows.Forms.Button BtnRefresh;
        private System.Windows.Forms.TextBox TxtNumofSingleBed;
        private System.Windows.Forms.TextBox TxtRoomID;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtNumofDoubleBed;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtFloor;
        private System.Windows.Forms.TextBox TxtDailyPayment;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.RichTextBox TxtExtras;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button BtnAdd;
    }
}