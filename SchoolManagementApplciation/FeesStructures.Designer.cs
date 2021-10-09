using System.Windows.Forms;

namespace SchoolManagementApplciation
{
    partial class FeesStructures
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
            this.Label1 = new System.Windows.Forms.Label();
            this.Grpdetails = new System.Windows.Forms.GroupBox();
            this.butedit = new System.Windows.Forms.Button();
            this.txtdue = new System.Windows.Forms.TextBox();
            this.lblsection = new System.Windows.Forms.Label();
            this.lblclass = new System.Windows.Forms.Label();
            this.Label7 = new System.Windows.Forms.Label();
            this.Label6 = new System.Windows.Forms.Label();
            this.lblname = new System.Windows.Forms.Label();
            this.Label5 = new System.Windows.Forms.Label();
            this.lbldue = new System.Windows.Forms.Label();
            this.Label4 = new System.Windows.Forms.Label();
            this.lblage = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.loadpay = new System.Windows.Forms.Button();
            this.Button3 = new System.Windows.Forms.Button();
            this.lblpay = new System.Windows.Forms.Label();
            this.txtpay = new System.Windows.Forms.TextBox();
            this.makepay = new System.Windows.Forms.Button();
            this.loadcan = new System.Windows.Forms.Button();
            this.PrintDocument1 = new System.Drawing.Printing.PrintDocument();
            this.txtrange = new System.Windows.Forms.TextBox();
            this.Label3 = new System.Windows.Forms.Label();
            this.cboname = new System.Windows.Forms.ComboBox();
            this.Label11 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.picbox = new System.Windows.Forms.PictureBox();
            this.Grpdetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbox)).BeginInit();
            this.SuspendLayout();
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(28, 126);
            this.Label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(79, 13);
            this.Label1.TabIndex = 1;
            this.Label1.Text = "Sudent\'s Name";
            // 
            // Grpdetails
            // 
            this.Grpdetails.BackColor = System.Drawing.Color.MistyRose;
            this.Grpdetails.Controls.Add(this.butedit);
            this.Grpdetails.Controls.Add(this.txtdue);
            this.Grpdetails.Controls.Add(this.picbox);
            this.Grpdetails.Controls.Add(this.lblsection);
            this.Grpdetails.Controls.Add(this.lblclass);
            this.Grpdetails.Controls.Add(this.Label7);
            this.Grpdetails.Controls.Add(this.Label6);
            this.Grpdetails.Controls.Add(this.lblname);
            this.Grpdetails.Controls.Add(this.Label5);
            this.Grpdetails.Controls.Add(this.lbldue);
            this.Grpdetails.Controls.Add(this.Label4);
            this.Grpdetails.Controls.Add(this.lblage);
            this.Grpdetails.Controls.Add(this.Label2);
            this.Grpdetails.Location = new System.Drawing.Point(464, 38);
            this.Grpdetails.Margin = new System.Windows.Forms.Padding(2);
            this.Grpdetails.Name = "Grpdetails";
            this.Grpdetails.Padding = new System.Windows.Forms.Padding(2);
            this.Grpdetails.Size = new System.Drawing.Size(361, 454);
            this.Grpdetails.TabIndex = 2;
            this.Grpdetails.TabStop = false;
            this.Grpdetails.Text = "Student Details";
            this.Grpdetails.Enter += new System.EventHandler(this.Grpdetails_Enter);
            // 
            // butedit
            // 
            this.butedit.Location = new System.Drawing.Point(254, 416);
            this.butedit.Margin = new System.Windows.Forms.Padding(2);
            this.butedit.Name = "butedit";
            this.butedit.Size = new System.Drawing.Size(67, 21);
            this.butedit.TabIndex = 18;
            this.butedit.Text = "Edit";
            this.butedit.UseVisualStyleBackColor = true;
            this.butedit.Click += new System.EventHandler(this.butedit_Click);
            // 
            // txtdue
            // 
            this.txtdue.Location = new System.Drawing.Point(188, 417);
            this.txtdue.Margin = new System.Windows.Forms.Padding(2);
            this.txtdue.Name = "txtdue";
            this.txtdue.Size = new System.Drawing.Size(62, 20);
            this.txtdue.TabIndex = 17;
            this.txtdue.Visible = false;
            this.txtdue.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtdue_KeyDown);
            // 
            // lblsection
            // 
            this.lblsection.AutoSize = true;
            this.lblsection.Location = new System.Drawing.Point(197, 352);
            this.lblsection.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblsection.Name = "lblsection";
            this.lblsection.Size = new System.Drawing.Size(39, 13);
            this.lblsection.TabIndex = 13;
            this.lblsection.Text = "Label9";
            // 
            // lblclass
            // 
            this.lblclass.AutoSize = true;
            this.lblclass.Location = new System.Drawing.Point(195, 316);
            this.lblclass.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblclass.Name = "lblclass";
            this.lblclass.Size = new System.Drawing.Size(39, 13);
            this.lblclass.TabIndex = 12;
            this.lblclass.Text = "Label8";
            // 
            // Label7
            // 
            this.Label7.AutoSize = true;
            this.Label7.Location = new System.Drawing.Point(111, 352);
            this.Label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Label7.Name = "Label7";
            this.Label7.Size = new System.Drawing.Size(43, 13);
            this.Label7.TabIndex = 11;
            this.Label7.Text = "Section";
            // 
            // Label6
            // 
            this.Label6.AutoSize = true;
            this.Label6.Location = new System.Drawing.Point(111, 316);
            this.Label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(32, 13);
            this.Label6.TabIndex = 10;
            this.Label6.Text = "Class";
            // 
            // lblname
            // 
            this.lblname.AutoSize = true;
            this.lblname.Location = new System.Drawing.Point(193, 277);
            this.lblname.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblname.Name = "lblname";
            this.lblname.Size = new System.Drawing.Size(39, 13);
            this.lblname.TabIndex = 9;
            this.lblname.Text = "Label6";
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.Location = new System.Drawing.Point(111, 277);
            this.Label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(35, 13);
            this.Label5.TabIndex = 8;
            this.Label5.Text = "Name";
            // 
            // lbldue
            // 
            this.lbldue.AutoSize = true;
            this.lbldue.Location = new System.Drawing.Point(187, 420);
            this.lbldue.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbldue.Name = "lbldue";
            this.lbldue.Size = new System.Drawing.Size(39, 13);
            this.lbldue.TabIndex = 7;
            this.lbldue.Text = "Label5";
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Location = new System.Drawing.Point(111, 420);
            this.Label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(27, 13);
            this.Label4.TabIndex = 6;
            this.Label4.Text = "Due";
            // 
            // lblage
            // 
            this.lblage.AutoSize = true;
            this.lblage.Location = new System.Drawing.Point(193, 387);
            this.lblage.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblage.Name = "lblage";
            this.lblage.Size = new System.Drawing.Size(39, 13);
            this.lblage.TabIndex = 3;
            this.lblage.Text = "Label3";
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Location = new System.Drawing.Point(113, 387);
            this.Label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(26, 13);
            this.Label2.TabIndex = 2;
            this.Label2.Text = "Age";
            // 
            // loadpay
            // 
            this.loadpay.BackColor = System.Drawing.Color.DarkRed;
            this.loadpay.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.loadpay.Location = new System.Drawing.Point(90, 359);
            this.loadpay.Margin = new System.Windows.Forms.Padding(2);
            this.loadpay.Name = "loadpay";
            this.loadpay.Size = new System.Drawing.Size(90, 55);
            this.loadpay.TabIndex = 6;
            this.loadpay.Text = "Save";
            this.loadpay.UseVisualStyleBackColor = false;
            this.loadpay.Visible = false;
            this.loadpay.Click += new System.EventHandler(this.loadpay_Click);
            // 
            // Button3
            // 
            this.Button3.BackColor = System.Drawing.Color.DarkRed;
            this.Button3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Button3.Location = new System.Drawing.Point(249, 172);
            this.Button3.Margin = new System.Windows.Forms.Padding(2);
            this.Button3.Name = "Button3";
            this.Button3.Size = new System.Drawing.Size(149, 49);
            this.Button3.TabIndex = 2;
            this.Button3.Text = "Show All Transactions";
            this.Button3.UseVisualStyleBackColor = false;
            this.Button3.Click += new System.EventHandler(this.Button3_Click);
            // 
            // lblpay
            // 
            this.lblpay.AutoSize = true;
            this.lblpay.Location = new System.Drawing.Point(74, 281);
            this.lblpay.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblpay.Name = "lblpay";
            this.lblpay.Size = new System.Drawing.Size(121, 13);
            this.lblpay.TabIndex = 22;
            this.lblpay.Text = "Enter The Amount Paid*";
            this.lblpay.Visible = false;
            // 
            // txtpay
            // 
            this.txtpay.BackColor = System.Drawing.Color.MistyRose;
            this.txtpay.Location = new System.Drawing.Point(214, 277);
            this.txtpay.Margin = new System.Windows.Forms.Padding(2);
            this.txtpay.Name = "txtpay";
            this.txtpay.Size = new System.Drawing.Size(144, 20);
            this.txtpay.TabIndex = 4;
            this.txtpay.Visible = false;
            this.txtpay.TextChanged += new System.EventHandler(this.txtpay_TextChanged);
            // 
            // makepay
            // 
            this.makepay.BackColor = System.Drawing.Color.DarkRed;
            this.makepay.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.makepay.Location = new System.Drawing.Point(31, 174);
            this.makepay.Margin = new System.Windows.Forms.Padding(2);
            this.makepay.Name = "makepay";
            this.makepay.Size = new System.Drawing.Size(149, 43);
            this.makepay.TabIndex = 3;
            this.makepay.Text = "Make Payment";
            this.makepay.UseVisualStyleBackColor = false;
            this.makepay.Click += new System.EventHandler(this.makepay_Click);
            // 
            // loadcan
            // 
            this.loadcan.BackColor = System.Drawing.Color.Peru;
            this.loadcan.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.loadcan.Location = new System.Drawing.Point(249, 359);
            this.loadcan.Margin = new System.Windows.Forms.Padding(2);
            this.loadcan.Name = "loadcan";
            this.loadcan.Size = new System.Drawing.Size(105, 55);
            this.loadcan.TabIndex = 8;
            this.loadcan.Text = "Cancel";
            this.loadcan.UseVisualStyleBackColor = false;
            this.loadcan.Visible = false;
            this.loadcan.Click += new System.EventHandler(this.loadcan_Click);
            // 
            // PrintDocument1
            // 
            this.PrintDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.PrintDocument1_PrintPage);
            // 
            // txtrange
            // 
            this.txtrange.BackColor = System.Drawing.Color.MistyRose;
            this.txtrange.Location = new System.Drawing.Point(214, 314);
            this.txtrange.Margin = new System.Windows.Forms.Padding(2);
            this.txtrange.Name = "txtrange";
            this.txtrange.Size = new System.Drawing.Size(144, 20);
            this.txtrange.TabIndex = 5;
            this.txtrange.Visible = false;
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Location = new System.Drawing.Point(76, 318);
            this.Label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(89, 13);
            this.Label3.TabIndex = 41;
            this.Label3.Text = "Paid For Duration";
            this.Label3.Visible = false;
            // 
            // cboname
            // 
            this.cboname.BackColor = System.Drawing.Color.MistyRose;
            this.cboname.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboname.FormattingEnabled = true;
            this.cboname.Location = new System.Drawing.Point(132, 126);
            this.cboname.Margin = new System.Windows.Forms.Padding(2);
            this.cboname.Name = "cboname";
            this.cboname.Size = new System.Drawing.Size(266, 21);
            this.cboname.TabIndex = 1;
            this.cboname.SelectedIndexChanged += new System.EventHandler(this.cboname_SelectedIndexChanged);
            this.cboname.TextChanged += new System.EventHandler(this.cboname_TextChanged);
            // 
            // Label11
            // 
            this.Label11.AutoSize = true;
            this.Label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label11.ForeColor = System.Drawing.Color.DarkRed;
            this.Label11.Location = new System.Drawing.Point(148, 38);
            this.Label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Label11.Name = "Label11";
            this.Label11.Size = new System.Drawing.Size(258, 36);
            this.Label11.TabIndex = 42;
            this.Label11.Text = "Fee Management";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::SchoolManagementApplciation.Properties.Resources.acc;
            this.pictureBox2.Location = new System.Drawing.Point(12, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(127, 89);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 43;
            this.pictureBox2.TabStop = false;
            // 
            // picbox
            // 
            this.picbox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picbox.ErrorImage = global::SchoolManagementApplciation.Properties.Resources._1200px_No_Image_Placeholder_svg;
            this.picbox.Location = new System.Drawing.Point(100, 61);
            this.picbox.Margin = new System.Windows.Forms.Padding(2);
            this.picbox.Name = "picbox";
            this.picbox.Size = new System.Drawing.Size(160, 195);
            this.picbox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picbox.TabIndex = 16;
            this.picbox.TabStop = false;
            // 
            // FeesStructures
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(850, 521);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.Label11);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.txtrange);
            this.Controls.Add(this.loadcan);
            this.Controls.Add(this.makepay);
            this.Controls.Add(this.txtpay);
            this.Controls.Add(this.lblpay);
            this.Controls.Add(this.Button3);
            this.Controls.Add(this.loadpay);
            this.Controls.Add(this.cboname);
            this.Controls.Add(this.Grpdetails);
            this.Controls.Add(this.Label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FeesStructures";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Student\'s Fees Manager";
            this.Load += new System.EventHandler(this.FeesStructures_Load);
            this.Grpdetails.ResumeLayout(false);
            this.Grpdetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void Loadpay_Click(object sender, System.EventArgs e)
        {
            throw new System.NotImplementedException();
        }

        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.GroupBox Grpdetails;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.Label lblage;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Label lblsection;
        internal System.Windows.Forms.Label lblclass;
        internal System.Windows.Forms.Label Label7;
        internal System.Windows.Forms.Label Label6;
        internal System.Windows.Forms.Label lblname;
        internal System.Windows.Forms.Label Label5;
        internal System.Windows.Forms.Label lbldue;
        internal System.Windows.Forms.Button loadpay;
        internal System.Windows.Forms.Button Button3;
        internal System.Windows.Forms.Label lblpay;
        internal System.Windows.Forms.TextBox txtpay;
        internal System.Windows.Forms.Button makepay;
        internal System.Windows.Forms.Button loadcan;
        internal System.Drawing.Printing.PrintDocument PrintDocument1;
        internal System.Windows.Forms.PictureBox picbox;
        internal System.Windows.Forms.Button butedit;
        internal System.Windows.Forms.TextBox txtdue;
        internal TextBox txtrange;
        internal Label Label3;
        #endregion

        internal ComboBox cboname;
        private PictureBox pictureBox2;
        private Label Label11;
    }
}