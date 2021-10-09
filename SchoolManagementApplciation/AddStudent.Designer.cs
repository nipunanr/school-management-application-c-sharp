namespace SchoolManagementApplciation
{
    partial class AddStudent
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddStudent));
            this.txtfullname = new System.Windows.Forms.TextBox();
            this.cbogender = new System.Windows.Forms.ComboBox();
            this.txtaddress = new System.Windows.Forms.TextBox();
            this.txtphone = new System.Windows.Forms.TextBox();
            this.txtemail = new System.Windows.Forms.TextBox();
            this.cboclass = new System.Windows.Forms.ComboBox();
            this.cbostream = new System.Windows.Forms.ComboBox();
            this.bnloadpicture = new System.Windows.Forms.Button();
            this.bnclearpictue = new System.Windows.Forms.Button();
            this.bnclear = new System.Windows.Forms.Button();
            this.bnsave = new System.Windows.Forms.Button();
            this.Label1 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.Label3 = new System.Windows.Forms.Label();
            this.Label4 = new System.Windows.Forms.Label();
            this.Label5 = new System.Windows.Forms.Label();
            this.Label6 = new System.Windows.Forms.Label();
            this.Label7 = new System.Windows.Forms.Label();
            this.Label8 = new System.Windows.Forms.Label();
            this.Label9 = new System.Windows.Forms.Label();
            this.Label10 = new System.Windows.Forms.Label();
            this.Label11 = new System.Windows.Forms.Label();
            this.OpenFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.txtregno = new System.Windows.Forms.TextBox();
            this.Mtxt = new System.Windows.Forms.TextBox();
            this.Label14 = new System.Windows.Forms.Label();
            this.Ftxt = new System.Windows.Forms.TextBox();
            this.Label15 = new System.Windows.Forms.Label();
            this.dtp = new System.Windows.Forms.DateTimePicker();
            this.label12 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.PictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtfullname
            // 
            this.txtfullname.BackColor = System.Drawing.Color.MistyRose;
            this.txtfullname.Location = new System.Drawing.Point(51, 158);
            this.txtfullname.Margin = new System.Windows.Forms.Padding(2);
            this.txtfullname.Name = "txtfullname";
            this.txtfullname.Size = new System.Drawing.Size(314, 20);
            this.txtfullname.TabIndex = 2;
            // 
            // cbogender
            // 
            this.cbogender.BackColor = System.Drawing.Color.PeachPuff;
            this.cbogender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbogender.FormattingEnabled = true;
            this.cbogender.Items.AddRange(new object[] {
            "Male",
            "Female",
            "Trans Gender"});
            this.cbogender.Location = new System.Drawing.Point(51, 219);
            this.cbogender.Margin = new System.Windows.Forms.Padding(2);
            this.cbogender.Name = "cbogender";
            this.cbogender.Size = new System.Drawing.Size(100, 21);
            this.cbogender.TabIndex = 5;
            // 
            // txtaddress
            // 
            this.txtaddress.BackColor = System.Drawing.Color.MistyRose;
            this.txtaddress.Location = new System.Drawing.Point(48, 383);
            this.txtaddress.Margin = new System.Windows.Forms.Padding(2);
            this.txtaddress.Multiline = true;
            this.txtaddress.Name = "txtaddress";
            this.txtaddress.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtaddress.Size = new System.Drawing.Size(308, 76);
            this.txtaddress.TabIndex = 7;
            // 
            // txtphone
            // 
            this.txtphone.BackColor = System.Drawing.Color.MistyRose;
            this.txtphone.Location = new System.Drawing.Point(48, 283);
            this.txtphone.Margin = new System.Windows.Forms.Padding(2);
            this.txtphone.Name = "txtphone";
            this.txtphone.Size = new System.Drawing.Size(308, 20);
            this.txtphone.TabIndex = 9;
            this.txtphone.TextChanged += new System.EventHandler(this.txtphone_TextChanged);
            // 
            // txtemail
            // 
            this.txtemail.BackColor = System.Drawing.Color.MistyRose;
            this.txtemail.Location = new System.Drawing.Point(49, 334);
            this.txtemail.Margin = new System.Windows.Forms.Padding(2);
            this.txtemail.Name = "txtemail";
            this.txtemail.Size = new System.Drawing.Size(307, 20);
            this.txtemail.TabIndex = 10;
            // 
            // cboclass
            // 
            this.cboclass.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.cboclass.BackColor = System.Drawing.Color.MistyRose;
            this.cboclass.CausesValidation = false;
            this.cboclass.FormattingEnabled = true;
            this.cboclass.Items.AddRange(new object[] {
            "**ARTS**",
            "Arabic",
            "Art",
            "Bharatha Natayam",
            "Buddhism",
            "Buddhist Civilization",
            "Chinese",
            "Christian Civilization",
            "Christianity",
            "Communication and Media Studies",
            "Dance",
            "Economics",
            "English",
            "French",
            "Geography",
            "German",
            "Greek and Roman Civilization",
            "Hindi Language",
            "Hindu Civilization",
            "Hinduism",
            "History",
            "Home Economics",
            "Islam",
            "Islamic Civilization",
            "Japan Language",
            "Logic and Scientific Method",
            "Oriental Music",
            "Pali Language",
            "Political Science",
            "Russian",
            "Sanskrit",
            "Sinhala",
            "Tamil",
            "Western Music",
            "**COMMERCE**",
            "Accounting",
            "Business",
            "Statistics Business",
            "Studies Economics",
            "**BIOLOGICAL SCIENCE**",
            "Agriculture",
            "Bio System Technology",
            "Biology",
            "Chemistry",
            "Physics",
            "Science for Technology",
            "**PHYSICAL SCIENCE(MATHS)**",
            "Chemistry",
            "Combine Mathematics",
            "Higher Mathematics",
            "Physics",
            "**TECHNOLOGY**",
            "Agro Technology",
            "Engineering Technology",
            "General Information Technology",
            "Information & Communication Technology"});
            this.cboclass.Location = new System.Drawing.Point(411, 334);
            this.cboclass.Margin = new System.Windows.Forms.Padding(2);
            this.cboclass.Name = "cboclass";
            this.cboclass.Size = new System.Drawing.Size(170, 21);
            this.cboclass.TabIndex = 11;
            this.cboclass.SelectedIndexChanged += new System.EventHandler(this.cboclass_SelectedIndexChanged);
            // 
            // cbostream
            // 
            this.cbostream.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbostream.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.cbostream.BackColor = System.Drawing.Color.MistyRose;
            this.cbostream.FormattingEnabled = true;
            this.cbostream.Items.AddRange(new object[] {
            "Undivided",
            "A",
            "B",
            "C",
            "D"});
            this.cbostream.Location = new System.Drawing.Point(597, 334);
            this.cbostream.Margin = new System.Windows.Forms.Padding(2);
            this.cbostream.Name = "cbostream";
            this.cbostream.Size = new System.Drawing.Size(139, 21);
            this.cbostream.TabIndex = 12;
            // 
            // bnloadpicture
            // 
            this.bnloadpicture.BackColor = System.Drawing.Color.MistyRose;
            this.bnloadpicture.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bnloadpicture.Location = new System.Drawing.Point(654, 137);
            this.bnloadpicture.Margin = new System.Windows.Forms.Padding(2);
            this.bnloadpicture.Name = "bnloadpicture";
            this.bnloadpicture.Size = new System.Drawing.Size(82, 43);
            this.bnloadpicture.TabIndex = 13;
            this.bnloadpicture.Text = "LOAD";
            this.bnloadpicture.UseVisualStyleBackColor = false;
            this.bnloadpicture.Click += new System.EventHandler(this.bnloadpicture_Click);
            // 
            // bnclearpictue
            // 
            this.bnclearpictue.BackColor = System.Drawing.Color.MistyRose;
            this.bnclearpictue.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bnclearpictue.Location = new System.Drawing.Point(563, 137);
            this.bnclearpictue.Margin = new System.Windows.Forms.Padding(2);
            this.bnclearpictue.Name = "bnclearpictue";
            this.bnclearpictue.Size = new System.Drawing.Size(87, 43);
            this.bnclearpictue.TabIndex = 16;
            this.bnclearpictue.Text = "Clear";
            this.bnclearpictue.UseVisualStyleBackColor = false;
            this.bnclearpictue.Click += new System.EventHandler(this.bnclearpictue_Click);
            // 
            // bnclear
            // 
            this.bnclear.BackColor = System.Drawing.Color.IndianRed;
            this.bnclear.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bnclear.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.bnclear.Location = new System.Drawing.Point(597, 383);
            this.bnclear.Margin = new System.Windows.Forms.Padding(2);
            this.bnclear.Name = "bnclear";
            this.bnclear.Size = new System.Drawing.Size(139, 76);
            this.bnclear.TabIndex = 15;
            this.bnclear.Text = "Clear";
            this.bnclear.UseVisualStyleBackColor = false;
            this.bnclear.Click += new System.EventHandler(this.bnclear_Click);
            // 
            // bnsave
            // 
            this.bnsave.BackColor = System.Drawing.Color.DarkRed;
            this.bnsave.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bnsave.ForeColor = System.Drawing.Color.Transparent;
            this.bnsave.Location = new System.Drawing.Point(411, 383);
            this.bnsave.Margin = new System.Windows.Forms.Padding(2);
            this.bnsave.Name = "bnsave";
            this.bnsave.Size = new System.Drawing.Size(170, 76);
            this.bnsave.TabIndex = 14;
            this.bnsave.Text = "Save";
            this.bnsave.UseVisualStyleBackColor = false;
            this.bnsave.Click += new System.EventHandler(this.bnsave_Click);
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(49, 85);
            this.Label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(103, 13);
            this.Label1.TabIndex = 14;
            this.Label1.Text = "Registration Number";
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Location = new System.Drawing.Point(49, 142);
            this.Label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(188, 13);
            this.Label2.TabIndex = 15;
            this.Label2.Text = "Name with Initials (Eg : PERERA BCA)";
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Location = new System.Drawing.Point(48, 204);
            this.Label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(42, 13);
            this.Label3.TabIndex = 16;
            this.Label3.Text = "Gender";
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Location = new System.Drawing.Point(179, 205);
            this.Label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(68, 13);
            this.Label4.TabIndex = 17;
            this.Label4.Text = "Date Of Birth";
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.Location = new System.Drawing.Point(46, 366);
            this.Label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(85, 13);
            this.Label5.TabIndex = 18;
            this.Label5.Text = "Contact Address";
            // 
            // Label6
            // 
            this.Label6.AutoSize = true;
            this.Label6.Location = new System.Drawing.Point(45, 264);
            this.Label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(230, 13);
            this.Label6.TabIndex = 19;
            this.Label6.Text = "Contact Phone Number (Parents Recomended)";
            // 
            // Label7
            // 
            this.Label7.AutoSize = true;
            this.Label7.Location = new System.Drawing.Point(46, 319);
            this.Label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Label7.Name = "Label7";
            this.Label7.Size = new System.Drawing.Size(73, 13);
            this.Label7.TabIndex = 20;
            this.Label7.Text = "Email Address";
            // 
            // Label8
            // 
            this.Label8.AutoSize = true;
            this.Label8.Location = new System.Drawing.Point(597, 314);
            this.Label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Label8.Name = "Label8";
            this.Label8.Size = new System.Drawing.Size(43, 13);
            this.Label8.TabIndex = 21;
            this.Label8.Text = "Section";
            // 
            // Label9
            // 
            this.Label9.AutoSize = true;
            this.Label9.Location = new System.Drawing.Point(412, 314);
            this.Label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Label9.Name = "Label9";
            this.Label9.Size = new System.Drawing.Size(32, 13);
            this.Label9.TabIndex = 22;
            this.Label9.Text = "Class";
            // 
            // Label10
            // 
            this.Label10.AutoSize = true;
            this.Label10.Location = new System.Drawing.Point(409, 32);
            this.Label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Label10.Name = "Label10";
            this.Label10.Size = new System.Drawing.Size(82, 13);
            this.Label10.TabIndex = 23;
            this.Label10.Text = "Student\'s Photo";
            // 
            // Label11
            // 
            this.Label11.AutoSize = true;
            this.Label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label11.ForeColor = System.Drawing.Color.DarkRed;
            this.Label11.Location = new System.Drawing.Point(50, 23);
            this.Label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Label11.Name = "Label11";
            this.Label11.Size = new System.Drawing.Size(306, 36);
            this.Label11.TabIndex = 24;
            this.Label11.Text = "Student Registration";
            // 
            // OpenFileDialog1
            // 
            this.OpenFileDialog1.FileName = "OpenFileDialog1";
            // 
            // txtregno
            // 
            this.txtregno.BackColor = System.Drawing.Color.MistyRose;
            this.txtregno.Location = new System.Drawing.Point(51, 101);
            this.txtregno.Margin = new System.Windows.Forms.Padding(2);
            this.txtregno.Name = "txtregno";
            this.txtregno.Size = new System.Drawing.Size(141, 20);
            this.txtregno.TabIndex = 1;
            this.txtregno.TextChanged += new System.EventHandler(this.txtregno_TextChanged);
            // 
            // Mtxt
            // 
            this.Mtxt.BackColor = System.Drawing.Color.MistyRose;
            this.Mtxt.Location = new System.Drawing.Point(411, 283);
            this.Mtxt.Margin = new System.Windows.Forms.Padding(2);
            this.Mtxt.Name = "Mtxt";
            this.Mtxt.Size = new System.Drawing.Size(325, 20);
            this.Mtxt.TabIndex = 3;
            // 
            // Label14
            // 
            this.Label14.AutoSize = true;
            this.Label14.Location = new System.Drawing.Point(409, 265);
            this.Label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Label14.Name = "Label14";
            this.Label14.Size = new System.Drawing.Size(78, 13);
            this.Label14.TabIndex = 31;
            this.Label14.Text = "Mother\'s Name";
            // 
            // Ftxt
            // 
            this.Ftxt.BackColor = System.Drawing.Color.MistyRose;
            this.Ftxt.Location = new System.Drawing.Point(411, 220);
            this.Ftxt.Margin = new System.Windows.Forms.Padding(2);
            this.Ftxt.Name = "Ftxt";
            this.Ftxt.Size = new System.Drawing.Size(325, 20);
            this.Ftxt.TabIndex = 4;
            // 
            // Label15
            // 
            this.Label15.AutoSize = true;
            this.Label15.Location = new System.Drawing.Point(409, 199);
            this.Label15.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Label15.Name = "Label15";
            this.Label15.Size = new System.Drawing.Size(84, 13);
            this.Label15.TabIndex = 33;
            this.Label15.Text = "Father\'s Number";
            // 
            // dtp
            // 
            this.dtp.Location = new System.Drawing.Point(176, 220);
            this.dtp.Margin = new System.Windows.Forms.Padding(2);
            this.dtp.MaxDate = new System.DateTime(2100, 12, 31, 0, 0, 0, 0);
            this.dtp.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.dtp.Name = "dtp";
            this.dtp.Size = new System.Drawing.Size(182, 20);
            this.dtp.TabIndex = 6;
            this.dtp.Value = new System.DateTime(2000, 10, 8, 23, 45, 0, 0);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(211, 479);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(343, 13);
            this.label12.TabIndex = 34;
            this.label12.Text = "B  r  i  g  h  t     A  c  a  d  e  m  y     |     G  a  m  p  a  h  a";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::SchoolManagementApplciation.Properties.Resources.acc;
            this.pictureBox2.Location = new System.Drawing.Point(587, 32);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(131, 89);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 35;
            this.pictureBox2.TabStop = false;
            // 
            // PictureBox1
            // 
            this.PictureBox1.BackColor = System.Drawing.Color.MistyRose;
            this.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PictureBox1.Location = new System.Drawing.Point(411, 47);
            this.PictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.PictureBox1.Name = "PictureBox1";
            this.PictureBox1.Size = new System.Drawing.Size(127, 133);
            this.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureBox1.TabIndex = 9;
            this.PictureBox1.TabStop = false;
            // 
            // AddStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(770, 507);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.dtp);
            this.Controls.Add(this.Ftxt);
            this.Controls.Add(this.Label15);
            this.Controls.Add(this.Mtxt);
            this.Controls.Add(this.Label14);
            this.Controls.Add(this.txtregno);
            this.Controls.Add(this.Label11);
            this.Controls.Add(this.Label10);
            this.Controls.Add(this.Label9);
            this.Controls.Add(this.Label8);
            this.Controls.Add(this.Label7);
            this.Controls.Add(this.Label6);
            this.Controls.Add(this.Label5);
            this.Controls.Add(this.Label4);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.bnsave);
            this.Controls.Add(this.bnclear);
            this.Controls.Add(this.bnclearpictue);
            this.Controls.Add(this.bnloadpicture);
            this.Controls.Add(this.PictureBox1);
            this.Controls.Add(this.cbostream);
            this.Controls.Add(this.cboclass);
            this.Controls.Add(this.txtemail);
            this.Controls.Add(this.txtphone);
            this.Controls.Add(this.txtaddress);
            this.Controls.Add(this.cbogender);
            this.Controls.Add(this.txtfullname);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "AddStudent";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bright Academy | Student Registration";
            this.Load += new System.EventHandler(this.AddStudent_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.TextBox txtfullname;
        private System.Windows.Forms.ComboBox cbogender;
        private System.Windows.Forms.TextBox txtaddress;
        private System.Windows.Forms.TextBox txtphone;
        private System.Windows.Forms.TextBox txtemail;
        private System.Windows.Forms.ComboBox cboclass;
        private System.Windows.Forms.ComboBox cbostream;
        private System.Windows.Forms.PictureBox PictureBox1;
        private System.Windows.Forms.Button bnloadpicture;
        private System.Windows.Forms.Button bnclearpictue;
        private System.Windows.Forms.Button bnclear;
        private System.Windows.Forms.Button bnsave;
        private System.Windows.Forms.Label Label1;
        private System.Windows.Forms.Label Label2;
        private System.Windows.Forms.Label Label3;
        private System.Windows.Forms.Label Label4;
        private System.Windows.Forms.Label Label5;
        private System.Windows.Forms.Label Label6;
        private System.Windows.Forms.Label Label7;
        private System.Windows.Forms.Label Label8;
        private System.Windows.Forms.Label Label9;
        private System.Windows.Forms.Label Label10;
        private System.Windows.Forms.Label Label11;
        private System.Windows.Forms.OpenFileDialog OpenFileDialog1;
        private System.Windows.Forms.TextBox txtregno;
        private System.Windows.Forms.TextBox Mtxt;
        private System.Windows.Forms.Label Label14;
        private System.Windows.Forms.TextBox Ftxt;
        private System.Windows.Forms.Label Label15;
        private System.Windows.Forms.DateTimePicker dtp;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.PictureBox pictureBox2;
    }

    #endregion
}