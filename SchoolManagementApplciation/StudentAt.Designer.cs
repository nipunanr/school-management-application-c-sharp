﻿namespace SchoolManagementApplciation
{
    partial class StudentAt
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

        private void InitializeComponent()
        {
            this.Button1 = new System.Windows.Forms.Button();
            this.dtp = new System.Windows.Forms.DateTimePicker();
            this.Label1 = new System.Windows.Forms.Label();
            this.cbofill = new System.Windows.Forms.ComboBox();
            this.pan = new System.Windows.Forms.Panel();
            this.Label8 = new System.Windows.Forms.Label();
            this.lblname = new System.Windows.Forms.Label();
            this.cbosection = new System.Windows.Forms.ComboBox();
            this.cboclass = new System.Windows.Forms.ComboBox();
            this.Label10 = new System.Windows.Forms.Label();
            this.Label11 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.grpbox = new System.Windows.Forms.GroupBox();
            this.PictureBox1 = new System.Windows.Forms.PictureBox();
            this.Label2 = new System.Windows.Forms.Label();
            this.Label3 = new System.Windows.Forms.Label();
            this.lblnames = new System.Windows.Forms.Label();
            this.lblgender = new System.Windows.Forms.Label();
            this.Label7 = new System.Windows.Forms.Label();
            this.lblclass = new System.Windows.Forms.Label();
            this.Label13 = new System.Windows.Forms.Label();
            this.lblsection = new System.Windows.Forms.Label();
            this.Label15 = new System.Windows.Forms.Label();
            this.lblnoholidays = new System.Windows.Forms.Label();
            this.Label17 = new System.Windows.Forms.Label();
            this.ListBox1 = new System.Windows.Forms.ListBox();
            this.grphidden = new System.Windows.Forms.GroupBox();
            this.pan.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.grpbox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).BeginInit();
            this.grphidden.SuspendLayout();
            this.SuspendLayout();
            // 
            // Button1
            // 
            this.Button1.BackColor = System.Drawing.Color.DarkRed;
            this.Button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Button1.Location = new System.Drawing.Point(554, 550);
            this.Button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Button1.Name = "Button1";
            this.Button1.Size = new System.Drawing.Size(327, 49);
            this.Button1.TabIndex = 15;
            this.Button1.Text = "More Details";
            this.Button1.UseVisualStyleBackColor = false;
            this.Button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // dtp
            // 
            this.dtp.Location = new System.Drawing.Point(152, 85);
            this.dtp.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtp.Name = "dtp";
            this.dtp.Size = new System.Drawing.Size(231, 20);
            this.dtp.TabIndex = 14;
            this.dtp.ValueChanged += new System.EventHandler(this.dtp_ValueChanged);
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(387, 66);
            this.Label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(44, 13);
            this.Label1.TabIndex = 13;
            this.Label1.Text = "Auto Fill";
            // 
            // cbofill
            // 
            this.cbofill.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbofill.FormattingEnabled = true;
            this.cbofill.Items.AddRange(new object[] {
            "Present",
            "Absent"});
            this.cbofill.Location = new System.Drawing.Point(387, 85);
            this.cbofill.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbofill.Name = "cbofill";
            this.cbofill.Size = new System.Drawing.Size(151, 21);
            this.cbofill.TabIndex = 12;
            this.cbofill.SelectedIndexChanged += new System.EventHandler(this.cbofill_SelectedIndexChanged);
            // 
            // pan
            // 
            this.pan.AutoScroll = true;
            this.pan.BackColor = System.Drawing.Color.MistyRose;
            this.pan.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pan.Controls.Add(this.Label8);
            this.pan.Controls.Add(this.lblname);
            this.pan.Location = new System.Drawing.Point(21, 116);
            this.pan.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pan.Name = "pan";
            this.pan.Size = new System.Drawing.Size(517, 483);
            this.pan.TabIndex = 10;
            this.pan.Click += new System.EventHandler(this.pan_Click);
            // 
            // Label8
            // 
            this.Label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label8.Location = new System.Drawing.Point(292, -1);
            this.Label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Label8.Name = "Label8";
            this.Label8.Size = new System.Drawing.Size(189, 47);
            this.Label8.TabIndex = 3;
            this.Label8.Text = "Attendance";
            this.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblname
            // 
            this.lblname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblname.Location = new System.Drawing.Point(-1, 1);
            this.lblname.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblname.Name = "lblname";
            this.lblname.Size = new System.Drawing.Size(191, 47);
            this.lblname.TabIndex = 2;
            this.lblname.Text = "Names";
            this.lblname.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cbosection
            // 
            this.cbosection.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbosection.FormattingEnabled = true;
            this.cbosection.Location = new System.Drawing.Point(726, 85);
            this.cbosection.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbosection.Name = "cbosection";
            this.cbosection.Size = new System.Drawing.Size(155, 21);
            this.cbosection.TabIndex = 18;
            this.cbosection.SelectedIndexChanged += new System.EventHandler(this.cbosection_SelectedIndexChanged);
            // 
            // cboclass
            // 
            this.cboclass.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboclass.FormattingEnabled = true;
            this.cboclass.Location = new System.Drawing.Point(554, 85);
            this.cboclass.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cboclass.Name = "cboclass";
            this.cboclass.Size = new System.Drawing.Size(156, 21);
            this.cboclass.TabIndex = 19;
            this.cboclass.SelectedIndexChanged += new System.EventHandler(this.cboclass_SelectedIndexChanged);
            // 
            // Label10
            // 
            this.Label10.AutoSize = true;
            this.Label10.Location = new System.Drawing.Point(557, 69);
            this.Label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Label10.Name = "Label10";
            this.Label10.Size = new System.Drawing.Size(32, 13);
            this.Label10.TabIndex = 21;
            this.Label10.Text = "Class";
            this.Label10.Click += new System.EventHandler(this.Label10_Click);
            // 
            // Label11
            // 
            this.Label11.AutoSize = true;
            this.Label11.Location = new System.Drawing.Point(726, 69);
            this.Label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Label11.Name = "Label11";
            this.Label11.Size = new System.Drawing.Size(43, 13);
            this.Label11.TabIndex = 22;
            this.Label11.Text = "Section";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::SchoolManagementApplciation.Properties.Resources.acc;
            this.pictureBox2.Location = new System.Drawing.Point(21, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(120, 97);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 47;
            this.pictureBox2.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DarkRed;
            this.label4.Location = new System.Drawing.Point(146, 16);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(295, 36);
            this.label4.TabIndex = 46;
            this.label4.Text = "Student Attendance";
            // 
            // grpbox
            // 
            this.grpbox.Controls.Add(this.ListBox1);
            this.grpbox.Controls.Add(this.Label17);
            this.grpbox.Controls.Add(this.lblnoholidays);
            this.grpbox.Controls.Add(this.Label15);
            this.grpbox.Controls.Add(this.lblsection);
            this.grpbox.Controls.Add(this.Label13);
            this.grpbox.Controls.Add(this.lblclass);
            this.grpbox.Controls.Add(this.Label7);
            this.grpbox.Controls.Add(this.lblgender);
            this.grpbox.Controls.Add(this.lblnames);
            this.grpbox.Controls.Add(this.Label3);
            this.grpbox.Controls.Add(this.Label2);
            this.grpbox.Controls.Add(this.PictureBox1);
            this.grpbox.Location = new System.Drawing.Point(0, 0);
            this.grpbox.Margin = new System.Windows.Forms.Padding(2);
            this.grpbox.Name = "grpbox";
            this.grpbox.Padding = new System.Windows.Forms.Padding(2);
            this.grpbox.Size = new System.Drawing.Size(327, 437);
            this.grpbox.TabIndex = 23;
            this.grpbox.TabStop = false;
            // 
            // PictureBox1
            // 
            this.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PictureBox1.Location = new System.Drawing.Point(100, 29);
            this.PictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.PictureBox1.Name = "PictureBox1";
            this.PictureBox1.Size = new System.Drawing.Size(140, 149);
            this.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureBox1.TabIndex = 0;
            this.PictureBox1.TabStop = false;
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Location = new System.Drawing.Point(86, 204);
            this.Label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(35, 13);
            this.Label2.TabIndex = 1;
            this.Label2.Text = "Name";
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Location = new System.Drawing.Point(86, 240);
            this.Label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(42, 13);
            this.Label3.TabIndex = 2;
            this.Label3.Text = "Gender";
            // 
            // lblnames
            // 
            this.lblnames.AutoSize = true;
            this.lblnames.Location = new System.Drawing.Point(206, 204);
            this.lblnames.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblnames.Name = "lblnames";
            this.lblnames.Size = new System.Drawing.Size(39, 13);
            this.lblnames.TabIndex = 3;
            this.lblnames.Text = "Label4";
            // 
            // lblgender
            // 
            this.lblgender.AutoSize = true;
            this.lblgender.Location = new System.Drawing.Point(206, 240);
            this.lblgender.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblgender.Name = "lblgender";
            this.lblgender.Size = new System.Drawing.Size(39, 13);
            this.lblgender.TabIndex = 4;
            this.lblgender.Text = "Label6";
            // 
            // Label7
            // 
            this.Label7.AutoSize = true;
            this.Label7.Location = new System.Drawing.Point(86, 277);
            this.Label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Label7.Name = "Label7";
            this.Label7.Size = new System.Drawing.Size(32, 13);
            this.Label7.TabIndex = 5;
            this.Label7.Text = "Class";
            // 
            // lblclass
            // 
            this.lblclass.AutoSize = true;
            this.lblclass.Location = new System.Drawing.Point(206, 277);
            this.lblclass.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblclass.Name = "lblclass";
            this.lblclass.Size = new System.Drawing.Size(45, 13);
            this.lblclass.TabIndex = 6;
            this.lblclass.Text = "Label12";
            // 
            // Label13
            // 
            this.Label13.AutoSize = true;
            this.Label13.Location = new System.Drawing.Point(86, 314);
            this.Label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Label13.Name = "Label13";
            this.Label13.Size = new System.Drawing.Size(43, 13);
            this.Label13.TabIndex = 7;
            this.Label13.Text = "Section";
            // 
            // lblsection
            // 
            this.lblsection.AutoSize = true;
            this.lblsection.Location = new System.Drawing.Point(206, 314);
            this.lblsection.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblsection.Name = "lblsection";
            this.lblsection.Size = new System.Drawing.Size(45, 13);
            this.lblsection.TabIndex = 8;
            this.lblsection.Text = "Label14";
            // 
            // Label15
            // 
            this.Label15.AutoSize = true;
            this.Label15.Location = new System.Drawing.Point(86, 347);
            this.Label15.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Label15.Name = "Label15";
            this.Label15.Size = new System.Drawing.Size(74, 13);
            this.Label15.TabIndex = 9;
            this.Label15.Text = "No of holidays";
            // 
            // lblnoholidays
            // 
            this.lblnoholidays.AutoSize = true;
            this.lblnoholidays.Location = new System.Drawing.Point(206, 347);
            this.lblnoholidays.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblnoholidays.Name = "lblnoholidays";
            this.lblnoholidays.Size = new System.Drawing.Size(45, 13);
            this.lblnoholidays.TabIndex = 10;
            this.lblnoholidays.Text = "Label16";
            // 
            // Label17
            // 
            this.Label17.AutoSize = true;
            this.Label17.Location = new System.Drawing.Point(86, 387);
            this.Label17.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Label17.Name = "Label17";
            this.Label17.Size = new System.Drawing.Size(88, 13);
            this.Label17.TabIndex = 11;
            this.Label17.Text = "Dates of holidays";
            // 
            // ListBox1
            // 
            this.ListBox1.BackColor = System.Drawing.SystemColors.Control;
            this.ListBox1.FormattingEnabled = true;
            this.ListBox1.Location = new System.Drawing.Point(208, 387);
            this.ListBox1.Margin = new System.Windows.Forms.Padding(2);
            this.ListBox1.Name = "ListBox1";
            this.ListBox1.Size = new System.Drawing.Size(91, 43);
            this.ListBox1.TabIndex = 12;
            // 
            // grphidden
            // 
            this.grphidden.Controls.Add(this.grpbox);
            this.grphidden.Location = new System.Drawing.Point(554, 109);
            this.grphidden.Margin = new System.Windows.Forms.Padding(2);
            this.grphidden.Name = "grphidden";
            this.grphidden.Padding = new System.Windows.Forms.Padding(2);
            this.grphidden.Size = new System.Drawing.Size(327, 437);
            this.grphidden.TabIndex = 16;
            this.grphidden.TabStop = false;
            // 
            // StudentAt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(898, 617);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Label11);
            this.Controls.Add(this.grphidden);
            this.Controls.Add(this.Label10);
            this.Controls.Add(this.cboclass);
            this.Controls.Add(this.cbosection);
            this.Controls.Add(this.dtp);
            this.Controls.Add(this.Button1);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.cbofill);
            this.Controls.Add(this.pan);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "StudentAt";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bright Academy | Students Attendance";
            this.Load += new System.EventHandler(this.StudentsAt_Load);
            this.pan.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.grpbox.ResumeLayout(false);
            this.grpbox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).EndInit();
            this.grphidden.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        internal System.Windows.Forms.Button Button1;
        internal System.Windows.Forms.DateTimePicker dtp;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.ComboBox cbofill;
        internal System.Windows.Forms.Panel pan;
        internal System.Windows.Forms.Label Label8;
        internal System.Windows.Forms.Label lblname;
        internal System.Windows.Forms.ComboBox cbosection;
        internal System.Windows.Forms.ComboBox cboclass;
        internal System.Windows.Forms.Label Label10;
        internal System.Windows.Forms.Label Label11;

        #endregion

        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label4;
        internal System.Windows.Forms.GroupBox grpbox;
        internal System.Windows.Forms.ListBox ListBox1;
        internal System.Windows.Forms.Label Label17;
        internal System.Windows.Forms.Label lblnoholidays;
        internal System.Windows.Forms.Label Label15;
        internal System.Windows.Forms.Label lblsection;
        internal System.Windows.Forms.Label Label13;
        internal System.Windows.Forms.Label lblclass;
        internal System.Windows.Forms.Label Label7;
        internal System.Windows.Forms.Label lblgender;
        internal System.Windows.Forms.Label lblnames;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.PictureBox PictureBox1;
        internal System.Windows.Forms.GroupBox grphidden;
    }
}