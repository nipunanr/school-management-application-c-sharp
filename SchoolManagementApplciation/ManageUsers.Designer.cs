namespace SchoolManagementApplciation
{
    partial class ManageUsers
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManageUsers));
            this.lstusernames = new System.Windows.Forms.ListBox();
            this.bndelete = new System.Windows.Forms.Button();
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this.txtrepass = new System.Windows.Forms.TextBox();
            this.txtpass = new System.Windows.Forms.TextBox();
            this.txtsecurity = new System.Windows.Forms.TextBox();
            this.Label7 = new System.Windows.Forms.Label();
            this.txtfullname = new System.Windows.Forms.TextBox();
            this.Label6 = new System.Windows.Forms.Label();
            this.Label5 = new System.Windows.Forms.Label();
            this.Label4 = new System.Windows.Forms.Label();
            this.Label3 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.bnsubmit = new System.Windows.Forms.Button();
            this.bnclear = new System.Windows.Forms.Button();
            this.bnload = new System.Windows.Forms.Button();
            this.PictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtusername = new System.Windows.Forms.TextBox();
            this.OpenFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label9 = new System.Windows.Forms.Label();
            this.GroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // lstusernames
            // 
            this.lstusernames.BackColor = System.Drawing.Color.MistyRose;
            this.lstusernames.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstusernames.FormattingEnabled = true;
            this.lstusernames.ItemHeight = 37;
            this.lstusernames.Location = new System.Drawing.Point(17, 119);
            this.lstusernames.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lstusernames.Name = "lstusernames";
            this.lstusernames.Size = new System.Drawing.Size(290, 300);
            this.lstusernames.TabIndex = 0;
            // 
            // bndelete
            // 
            this.bndelete.BackColor = System.Drawing.Color.RosyBrown;
            this.bndelete.Location = new System.Drawing.Point(18, 438);
            this.bndelete.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.bndelete.Name = "bndelete";
            this.bndelete.Size = new System.Drawing.Size(289, 63);
            this.bndelete.TabIndex = 2;
            this.bndelete.Text = "Delete the Selected User ";
            this.bndelete.UseVisualStyleBackColor = false;
            this.bndelete.Click += new System.EventHandler(this.bndelete_Click);
            // 
            // GroupBox1
            // 
            this.GroupBox1.BackColor = System.Drawing.Color.MistyRose;
            this.GroupBox1.Controls.Add(this.txtrepass);
            this.GroupBox1.Controls.Add(this.txtpass);
            this.GroupBox1.Controls.Add(this.txtsecurity);
            this.GroupBox1.Controls.Add(this.Label7);
            this.GroupBox1.Controls.Add(this.txtfullname);
            this.GroupBox1.Controls.Add(this.Label6);
            this.GroupBox1.Controls.Add(this.Label5);
            this.GroupBox1.Controls.Add(this.Label4);
            this.GroupBox1.Controls.Add(this.Label3);
            this.GroupBox1.Controls.Add(this.Label2);
            this.GroupBox1.Controls.Add(this.bnsubmit);
            this.GroupBox1.Controls.Add(this.bnclear);
            this.GroupBox1.Controls.Add(this.bnload);
            this.GroupBox1.Controls.Add(this.PictureBox1);
            this.GroupBox1.Controls.Add(this.txtusername);
            this.GroupBox1.Location = new System.Drawing.Point(326, 78);
            this.GroupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.GroupBox1.Size = new System.Drawing.Size(380, 426);
            this.GroupBox1.TabIndex = 3;
            this.GroupBox1.TabStop = false;
            this.GroupBox1.Text = "Creating New User";
            // 
            // txtrepass
            // 
            this.txtrepass.Location = new System.Drawing.Point(132, 189);
            this.txtrepass.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtrepass.Name = "txtrepass";
            this.txtrepass.PasswordChar = '*';
            this.txtrepass.Size = new System.Drawing.Size(236, 20);
            this.txtrepass.TabIndex = 4;
            // 
            // txtpass
            // 
            this.txtpass.Location = new System.Drawing.Point(132, 159);
            this.txtpass.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtpass.Name = "txtpass";
            this.txtpass.PasswordChar = '*';
            this.txtpass.Size = new System.Drawing.Size(236, 20);
            this.txtpass.TabIndex = 3;
            // 
            // txtsecurity
            // 
            this.txtsecurity.Location = new System.Drawing.Point(131, 118);
            this.txtsecurity.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtsecurity.Name = "txtsecurity";
            this.txtsecurity.PasswordChar = '*';
            this.txtsecurity.Size = new System.Drawing.Size(236, 20);
            this.txtsecurity.TabIndex = 2;
            // 
            // Label7
            // 
            this.Label7.AutoSize = true;
            this.Label7.Location = new System.Drawing.Point(72, 40);
            this.Label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Label7.Name = "Label7";
            this.Label7.Size = new System.Drawing.Size(54, 13);
            this.Label7.TabIndex = 13;
            this.Label7.Text = "Full Name";
            // 
            // txtfullname
            // 
            this.txtfullname.Location = new System.Drawing.Point(131, 37);
            this.txtfullname.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtfullname.Name = "txtfullname";
            this.txtfullname.Size = new System.Drawing.Size(236, 20);
            this.txtfullname.TabIndex = 0;
            // 
            // Label6
            // 
            this.Label6.AutoSize = true;
            this.Label6.Location = new System.Drawing.Point(8, 118);
            this.Label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(124, 13);
            this.Label6.TabIndex = 12;
            this.Label6.Text = "Authentication Password";
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.Location = new System.Drawing.Point(76, 164);
            this.Label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(53, 13);
            this.Label5.TabIndex = 11;
            this.Label5.Text = "Password";
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Location = new System.Drawing.Point(39, 191);
            this.Label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(90, 13);
            this.Label4.TabIndex = 10;
            this.Label4.Text = "Retype Password";
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Location = new System.Drawing.Point(76, 237);
            this.Label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(35, 13);
            this.Label3.TabIndex = 9;
            this.Label3.Text = "Photo";
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Location = new System.Drawing.Point(76, 73);
            this.Label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(55, 13);
            this.Label2.TabIndex = 8;
            this.Label2.Text = "Username";
            // 
            // bnsubmit
            // 
            this.bnsubmit.BackColor = System.Drawing.Color.DarkRed;
            this.bnsubmit.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.bnsubmit.Location = new System.Drawing.Point(131, 360);
            this.bnsubmit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.bnsubmit.Name = "bnsubmit";
            this.bnsubmit.Size = new System.Drawing.Size(211, 51);
            this.bnsubmit.TabIndex = 7;
            this.bnsubmit.Text = "Submit";
            this.bnsubmit.UseVisualStyleBackColor = false;
            this.bnsubmit.Click += new System.EventHandler(this.bnsubmit_Click);
            // 
            // bnclear
            // 
            this.bnclear.Location = new System.Drawing.Point(260, 300);
            this.bnclear.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.bnclear.Name = "bnclear";
            this.bnclear.Size = new System.Drawing.Size(82, 47);
            this.bnclear.TabIndex = 6;
            this.bnclear.Text = "Clear";
            this.bnclear.UseVisualStyleBackColor = true;
            this.bnclear.Click += new System.EventHandler(this.bnclear_Click);
            // 
            // bnload
            // 
            this.bnload.Location = new System.Drawing.Point(260, 237);
            this.bnload.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.bnload.Name = "bnload";
            this.bnload.Size = new System.Drawing.Size(82, 50);
            this.bnload.TabIndex = 5;
            this.bnload.Text = "LOAD";
            this.bnload.UseVisualStyleBackColor = true;
            this.bnload.Click += new System.EventHandler(this.bnload_Click);
            // 
            // PictureBox1
            // 
            this.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PictureBox1.Location = new System.Drawing.Point(131, 237);
            this.PictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.PictureBox1.Name = "PictureBox1";
            this.PictureBox1.Size = new System.Drawing.Size(93, 110);
            this.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureBox1.TabIndex = 4;
            this.PictureBox1.TabStop = false;
            // 
            // txtusername
            // 
            this.txtusername.Location = new System.Drawing.Point(131, 71);
            this.txtusername.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtusername.Name = "txtusername";
            this.txtusername.Size = new System.Drawing.Size(236, 20);
            this.txtusername.TabIndex = 1;
            // 
            // OpenFileDialog1
            // 
            this.OpenFileDialog1.FileName = "OpenFileDialog1";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::SchoolManagementApplciation.Properties.Resources.acc;
            this.pictureBox2.Location = new System.Drawing.Point(90, 9);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(134, 105);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 571;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.DarkRed;
            this.label9.Location = new System.Drawing.Point(424, 23);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(220, 36);
            this.label9.TabIndex = 570;
            this.label9.Text = "Manage Users";
            // 
            // ManageUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(721, 517);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.GroupBox1);
            this.Controls.Add(this.bndelete);
            this.Controls.Add(this.lstusernames);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "ManageUsers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bright Academy | Manage Users";
            this.Load += new System.EventHandler(this.ManageUsers_Load);
            this.GroupBox1.ResumeLayout(false);
            this.GroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        internal System.Windows.Forms.ListBox lstusernames;
        internal System.Windows.Forms.Button bndelete;
        internal System.Windows.Forms.GroupBox GroupBox1;
        internal System.Windows.Forms.Label Label6;
        internal System.Windows.Forms.Label Label5;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Button bnsubmit;
        internal System.Windows.Forms.Button bnclear;
        internal System.Windows.Forms.Button bnload;
        internal System.Windows.Forms.PictureBox PictureBox1;
        internal System.Windows.Forms.TextBox txtusername;
        internal System.Windows.Forms.Label Label7;
        internal System.Windows.Forms.TextBox txtfullname;
        internal System.Windows.Forms.OpenFileDialog OpenFileDialog1;
        internal System.Windows.Forms.TextBox txtrepass;
        internal System.Windows.Forms.TextBox txtpass;
        internal System.Windows.Forms.TextBox txtsecurity;

        #endregion

        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label9;
    }
}