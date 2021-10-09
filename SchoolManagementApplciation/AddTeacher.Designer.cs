namespace SchoolManagementApplciation
{
    partial class AddTeacher
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddTeacher));
            this.imageT = new System.Windows.Forms.PictureBox();
            this.txtfullname = new System.Windows.Forms.TextBox();
            this.cbogender = new System.Windows.Forms.ComboBox();
            this.cbodesignation = new System.Windows.Forms.ComboBox();
            this.txtaddress = new System.Windows.Forms.TextBox();
            this.txtphone = new System.Windows.Forms.TextBox();
            this.txtemail = new System.Windows.Forms.TextBox();
            this.Label2 = new System.Windows.Forms.Label();
            this.Label3 = new System.Windows.Forms.Label();
            this.Label4 = new System.Windows.Forms.Label();
            this.Label5 = new System.Windows.Forms.Label();
            this.Label7 = new System.Windows.Forms.Label();
            this.Label8 = new System.Windows.Forms.Label();
            this.bnsave = new System.Windows.Forms.Button();
            this.bnload = new System.Windows.Forms.Button();
            this.bnclear = new System.Windows.Forms.Button();
            this.OpenFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.DateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.Label10 = new System.Windows.Forms.Label();
            this.bnclearing = new System.Windows.Forms.Button();
            this.Label11 = new System.Windows.Forms.Label();
            this.txtqua = new System.Windows.Forms.TextBox();
            this.ComboBox1 = new System.Windows.Forms.TextBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.Label6 = new System.Windows.Forms.Label();
            this.dtp = new System.Windows.Forms.DateTimePicker();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.imageT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // imageT
            // 
            this.imageT.BackColor = System.Drawing.SystemColors.ControlDark;
            this.imageT.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.imageT.Location = new System.Drawing.Point(404, 142);
            this.imageT.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.imageT.Name = "imageT";
            this.imageT.Size = new System.Drawing.Size(142, 151);
            this.imageT.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imageT.TabIndex = 0;
            this.imageT.TabStop = false;
            // 
            // txtfullname
            // 
            this.txtfullname.BackColor = System.Drawing.Color.MistyRose;
            this.txtfullname.Location = new System.Drawing.Point(135, 69);
            this.txtfullname.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtfullname.Name = "txtfullname";
            this.txtfullname.Size = new System.Drawing.Size(234, 20);
            this.txtfullname.TabIndex = 1;
            // 
            // cbogender
            // 
            this.cbogender.BackColor = System.Drawing.Color.MistyRose;
            this.cbogender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbogender.FormattingEnabled = true;
            this.cbogender.Items.AddRange(new object[] {
            "Male",
            "Female",
            "Trans Gender"});
            this.cbogender.Location = new System.Drawing.Point(135, 104);
            this.cbogender.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbogender.Name = "cbogender";
            this.cbogender.Size = new System.Drawing.Size(234, 21);
            this.cbogender.TabIndex = 2;
            // 
            // cbodesignation
            // 
            this.cbodesignation.AutoCompleteCustomSource.AddRange(new string[] {
            "Day Care Helper",
            "Day Care Teacher",
            "Primary School Teacher",
            "Account Manager",
            "Tuition Teacher"});
            this.cbodesignation.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbodesignation.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.cbodesignation.BackColor = System.Drawing.Color.MistyRose;
            this.cbodesignation.FormattingEnabled = true;
            this.cbodesignation.Items.AddRange(new object[] {
            "Day Care Helper",
            "Day Care Teacher",
            "Primary School Teacher",
            "Account Manager",
            "Tuition Teacher"});
            this.cbodesignation.Location = new System.Drawing.Point(135, 182);
            this.cbodesignation.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbodesignation.Name = "cbodesignation";
            this.cbodesignation.Size = new System.Drawing.Size(234, 21);
            this.cbodesignation.TabIndex = 4;
            // 
            // txtaddress
            // 
            this.txtaddress.BackColor = System.Drawing.Color.MistyRose;
            this.txtaddress.Location = new System.Drawing.Point(135, 265);
            this.txtaddress.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtaddress.Multiline = true;
            this.txtaddress.Name = "txtaddress";
            this.txtaddress.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtaddress.Size = new System.Drawing.Size(234, 88);
            this.txtaddress.TabIndex = 6;
            // 
            // txtphone
            // 
            this.txtphone.BackColor = System.Drawing.Color.MistyRose;
            this.txtphone.Location = new System.Drawing.Point(135, 369);
            this.txtphone.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtphone.Name = "txtphone";
            this.txtphone.Size = new System.Drawing.Size(136, 20);
            this.txtphone.TabIndex = 7;
            this.txtphone.TextChanged += new System.EventHandler(this.txtphone_TextChanged);
            // 
            // txtemail
            // 
            this.txtemail.BackColor = System.Drawing.Color.MistyRose;
            this.txtemail.Location = new System.Drawing.Point(373, 369);
            this.txtemail.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtemail.Name = "txtemail";
            this.txtemail.Size = new System.Drawing.Size(200, 20);
            this.txtemail.TabIndex = 8;
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Location = new System.Drawing.Point(289, 372);
            this.Label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(72, 13);
            this.Label2.TabIndex = 10;
            this.Label2.Text = "Email address";
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Location = new System.Drawing.Point(27, 372);
            this.Label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(38, 13);
            this.Label3.TabIndex = 11;
            this.Label3.Text = "Phone";
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Location = new System.Drawing.Point(27, 265);
            this.Label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(85, 13);
            this.Label4.TabIndex = 12;
            this.Label4.Text = "Contact Address";
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.Location = new System.Drawing.Point(27, 188);
            this.Label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(63, 13);
            this.Label5.TabIndex = 13;
            this.Label5.Text = "Designation";
            // 
            // Label7
            // 
            this.Label7.AutoSize = true;
            this.Label7.Location = new System.Drawing.Point(27, 106);
            this.Label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Label7.Name = "Label7";
            this.Label7.Size = new System.Drawing.Size(42, 13);
            this.Label7.TabIndex = 15;
            this.Label7.Text = "Gender";
            // 
            // Label8
            // 
            this.Label8.AutoSize = true;
            this.Label8.Location = new System.Drawing.Point(27, 69);
            this.Label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Label8.Name = "Label8";
            this.Label8.Size = new System.Drawing.Size(54, 13);
            this.Label8.TabIndex = 16;
            this.Label8.Text = "Full Name";
            // 
            // bnsave
            // 
            this.bnsave.BackColor = System.Drawing.Color.DarkRed;
            this.bnsave.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.bnsave.Location = new System.Drawing.Point(75, 449);
            this.bnsave.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.bnsave.Name = "bnsave";
            this.bnsave.Size = new System.Drawing.Size(190, 58);
            this.bnsave.TabIndex = 12;
            this.bnsave.Text = "Save";
            this.bnsave.UseVisualStyleBackColor = false;
            this.bnsave.Click += new System.EventHandler(this.bnsave_Click);
            // 
            // bnload
            // 
            this.bnload.Location = new System.Drawing.Point(404, 307);
            this.bnload.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.bnload.Name = "bnload";
            this.bnload.Size = new System.Drawing.Size(99, 45);
            this.bnload.TabIndex = 11;
            this.bnload.Text = "Load Photo";
            this.bnload.UseVisualStyleBackColor = true;
            this.bnload.Click += new System.EventHandler(this.bnload_Click);
            // 
            // bnclear
            // 
            this.bnclear.Location = new System.Drawing.Point(507, 307);
            this.bnclear.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.bnclear.Name = "bnclear";
            this.bnclear.Size = new System.Drawing.Size(39, 46);
            this.bnclear.TabIndex = 19;
            this.bnclear.Text = "Clear";
            this.bnclear.UseVisualStyleBackColor = true;
            this.bnclear.Click += new System.EventHandler(this.bnclear_Click);
            // 
            // OpenFileDialog1
            // 
            this.OpenFileDialog1.FileName = "OpenFileDialog1";
            // 
            // DateTimePicker1
            // 
            this.DateTimePicker1.Location = new System.Drawing.Point(135, 143);
            this.DateTimePicker1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.DateTimePicker1.Name = "DateTimePicker1";
            this.DateTimePicker1.Size = new System.Drawing.Size(234, 20);
            this.DateTimePicker1.TabIndex = 3;
            // 
            // Label10
            // 
            this.Label10.AutoSize = true;
            this.Label10.Location = new System.Drawing.Point(27, 414);
            this.Label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Label10.Name = "Label10";
            this.Label10.Size = new System.Drawing.Size(65, 13);
            this.Label10.TabIndex = 559;
            this.Label10.Text = "Monthly Pay";
            // 
            // bnclearing
            // 
            this.bnclearing.BackColor = System.Drawing.Color.Salmon;
            this.bnclearing.Location = new System.Drawing.Point(340, 449);
            this.bnclearing.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.bnclearing.Name = "bnclearing";
            this.bnclearing.Size = new System.Drawing.Size(188, 58);
            this.bnclearing.TabIndex = 13;
            this.bnclearing.Text = "Clear";
            this.bnclearing.UseVisualStyleBackColor = false;
            this.bnclearing.Click += new System.EventHandler(this.bnclearing_Click);
            // 
            // Label11
            // 
            this.Label11.AutoSize = true;
            this.Label11.Location = new System.Drawing.Point(27, 229);
            this.Label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Label11.Name = "Label11";
            this.Label11.Size = new System.Drawing.Size(104, 13);
            this.Label11.TabIndex = 562;
            this.Label11.Text = "Highest Qualification";
            // 
            // txtqua
            // 
            this.txtqua.BackColor = System.Drawing.Color.MistyRose;
            this.txtqua.Location = new System.Drawing.Point(135, 226);
            this.txtqua.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtqua.Name = "txtqua";
            this.txtqua.Size = new System.Drawing.Size(234, 20);
            this.txtqua.TabIndex = 5;
            // 
            // ComboBox1
            // 
            this.ComboBox1.BackColor = System.Drawing.Color.MistyRose;
            this.ComboBox1.Location = new System.Drawing.Point(135, 408);
            this.ComboBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ComboBox1.Name = "ComboBox1";
            this.ComboBox1.Size = new System.Drawing.Size(136, 20);
            this.ComboBox1.TabIndex = 9;
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(27, 143);
            this.Label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(68, 13);
            this.Label1.TabIndex = 563;
            this.Label1.Text = "Date Of Birth";
            // 
            // Label6
            // 
            this.Label6.AutoSize = true;
            this.Label6.Location = new System.Drawing.Point(289, 413);
            this.Label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(80, 13);
            this.Label6.TabIndex = 565;
            this.Label6.Text = "Date Of Joining";
            // 
            // dtp
            // 
            this.dtp.Location = new System.Drawing.Point(373, 408);
            this.dtp.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtp.Name = "dtp";
            this.dtp.Size = new System.Drawing.Size(200, 20);
            this.dtp.TabIndex = 10;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::SchoolManagementApplciation.Properties.Resources.acc;
            this.pictureBox2.Location = new System.Drawing.Point(404, 17);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(144, 108);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 567;
            this.pictureBox2.TabStop = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.DarkRed;
            this.label9.Location = new System.Drawing.Point(24, 18);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(345, 36);
            this.label9.TabIndex = 566;
            this.label9.Text = "Add Teacher/Employee";
            // 
            // AddTeacher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(591, 518);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.Label6);
            this.Controls.Add(this.dtp);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.ComboBox1);
            this.Controls.Add(this.txtqua);
            this.Controls.Add(this.Label11);
            this.Controls.Add(this.bnclearing);
            this.Controls.Add(this.Label10);
            this.Controls.Add(this.DateTimePicker1);
            this.Controls.Add(this.bnclear);
            this.Controls.Add(this.bnload);
            this.Controls.Add(this.bnsave);
            this.Controls.Add(this.Label8);
            this.Controls.Add(this.Label7);
            this.Controls.Add(this.Label5);
            this.Controls.Add(this.Label4);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.txtemail);
            this.Controls.Add(this.txtphone);
            this.Controls.Add(this.txtaddress);
            this.Controls.Add(this.cbodesignation);
            this.Controls.Add(this.cbogender);
            this.Controls.Add(this.txtfullname);
            this.Controls.Add(this.imageT);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "AddTeacher";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bright Academy | Add Teachers & Employees";
            this.Load += new System.EventHandler(this.AddTeacher_Load);
            ((System.ComponentModel.ISupportInitialize)(this.imageT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        internal System.Windows.Forms.PictureBox imageT;
        internal System.Windows.Forms.TextBox txtfullname;
        internal System.Windows.Forms.ComboBox cbogender;
        internal System.Windows.Forms.ComboBox cbodesignation;
        internal System.Windows.Forms.TextBox txtaddress;
        internal System.Windows.Forms.TextBox txtphone;
        internal System.Windows.Forms.TextBox txtemail;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.Label Label5;
        internal System.Windows.Forms.Label Label7;
        internal System.Windows.Forms.Label Label8;
        internal System.Windows.Forms.Button bnsave;
        internal System.Windows.Forms.Button bnload;
        internal System.Windows.Forms.Button bnclear;
        internal System.Windows.Forms.OpenFileDialog OpenFileDialog1;
        internal System.Windows.Forms.DateTimePicker DateTimePicker1;
        internal System.Windows.Forms.Label Label10;
        internal System.Windows.Forms.Button bnclearing;
        internal System.Windows.Forms.Label Label11;
        internal System.Windows.Forms.TextBox txtqua;
        internal System.Windows.Forms.TextBox ComboBox1;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.Label Label6;
        internal System.Windows.Forms.DateTimePicker dtp;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label9;
    }
    #endregion
}