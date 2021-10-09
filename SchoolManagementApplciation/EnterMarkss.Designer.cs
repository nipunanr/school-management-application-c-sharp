namespace SchoolManagementApplciation
{
    partial class EnterMarkss
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EnterMarkss));
            this.DataGridView1 = new System.Windows.Forms.DataGridView();
            this.cboname = new System.Windows.Forms.ComboBox();
            this.dtp = new System.Windows.Forms.DateTimePicker();
            this.bnload = new System.Windows.Forms.Button();
            this.cbosub = new System.Windows.Forms.ComboBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.lblcurentdate = new System.Windows.Forms.Label();
            this.bnclear = new System.Windows.Forms.Button();
            this.bnprint = new System.Windows.Forms.Button();
            this.PrintDocument1 = new System.Drawing.Printing.PrintDocument();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.Label11 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // DataGridView1
            // 
            this.DataGridView1.AllowUserToAddRows = false;
            this.DataGridView1.AllowUserToDeleteRows = false;
            this.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridView1.Location = new System.Drawing.Point(24, 164);
            this.DataGridView1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.DataGridView1.Name = "DataGridView1";
            this.DataGridView1.RowTemplate.Height = 24;
            this.DataGridView1.Size = new System.Drawing.Size(871, 362);
            this.DataGridView1.TabIndex = 0;
            this.DataGridView1.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_CellEndEdit);
            this.DataGridView1.CellParsing += new System.Windows.Forms.DataGridViewCellParsingEventHandler(this.DataGridView1_CellParsing);
            // 
            // cboname
            // 
            this.cboname.BackColor = System.Drawing.Color.MistyRose;
            this.cboname.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboname.FormattingEnabled = true;
            this.cboname.Location = new System.Drawing.Point(24, 87);
            this.cboname.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cboname.Name = "cboname";
            this.cboname.Size = new System.Drawing.Size(186, 21);
            this.cboname.TabIndex = 1;
            this.cboname.SelectedIndexChanged += new System.EventHandler(this.cboname_SelectedIndexChanged);
            // 
            // dtp
            // 
            this.dtp.CalendarMonthBackground = System.Drawing.Color.MistyRose;
            this.dtp.Location = new System.Drawing.Point(24, 120);
            this.dtp.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtp.Name = "dtp";
            this.dtp.Size = new System.Drawing.Size(220, 20);
            this.dtp.TabIndex = 2;
            this.dtp.ValueChanged += new System.EventHandler(this.dtp_ValueChanged);
            // 
            // bnload
            // 
            this.bnload.BackColor = System.Drawing.Color.DarkRed;
            this.bnload.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.bnload.Location = new System.Drawing.Point(523, 112);
            this.bnload.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.bnload.Name = "bnload";
            this.bnload.Size = new System.Drawing.Size(119, 41);
            this.bnload.TabIndex = 3;
            this.bnload.Text = "LOAD";
            this.bnload.UseVisualStyleBackColor = false;
            this.bnload.Click += new System.EventHandler(this.bnload_Click);
            // 
            // cbosub
            // 
            this.cbosub.AutoCompleteCustomSource.AddRange(new string[] {
            "Maths",
            "Physics",
            "English",
            "Chemisty",
            "History",
            "Econmics",
            "Computer Science",
            "Bussinesss Maths",
            "Civics",
            "Tamil",
            "Hindi",
            "French",
            "Biology",
            "Science",
            "Zoology",
            "Botany",
            "Ariviyal Tamil",
            "English",
            "Geography",
            " Environmental Science",
            " Agricultural Science",
            "Commercial Studies",
            "Technical Drawing",
            "Drawing",
            "Abacus",
            "SST"});
            this.cbosub.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.cbosub.BackColor = System.Drawing.Color.MistyRose;
            this.cbosub.FormattingEnabled = true;
            this.cbosub.Location = new System.Drawing.Point(281, 87);
            this.cbosub.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbosub.Name = "cbosub";
            this.cbosub.Size = new System.Drawing.Size(184, 21);
            this.cbosub.TabIndex = 4;
            this.cbosub.SelectedIndexChanged += new System.EventHandler(this.cbosub_SelectedIndexChanged);
            this.cbosub.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cbosub_KeyDown);
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(278, 66);
            this.Label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(71, 13);
            this.Label1.TabIndex = 5;
            this.Label1.Text = "Enter Subject";
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Location = new System.Drawing.Point(21, 66);
            this.Label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(63, 13);
            this.Label2.TabIndex = 6;
            this.Label2.Text = "Enter Name";
            // 
            // lblcurentdate
            // 
            this.lblcurentdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcurentdate.Location = new System.Drawing.Point(309, 112);
            this.lblcurentdate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblcurentdate.Name = "lblcurentdate";
            this.lblcurentdate.Size = new System.Drawing.Size(156, 41);
            this.lblcurentdate.TabIndex = 7;
            this.lblcurentdate.Text = "Label3";
            this.lblcurentdate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bnclear
            // 
            this.bnclear.BackColor = System.Drawing.Color.Sienna;
            this.bnclear.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.bnclear.Location = new System.Drawing.Point(776, 112);
            this.bnclear.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.bnclear.Name = "bnclear";
            this.bnclear.Size = new System.Drawing.Size(119, 41);
            this.bnclear.TabIndex = 8;
            this.bnclear.Text = "Delete Record";
            this.bnclear.UseVisualStyleBackColor = false;
            this.bnclear.Click += new System.EventHandler(this.bnclear_Click);
            // 
            // bnprint
            // 
            this.bnprint.BackColor = System.Drawing.Color.DarkRed;
            this.bnprint.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.bnprint.Location = new System.Drawing.Point(646, 112);
            this.bnprint.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.bnprint.Name = "bnprint";
            this.bnprint.Size = new System.Drawing.Size(126, 41);
            this.bnprint.TabIndex = 9;
            this.bnprint.Text = "PRINT";
            this.bnprint.UseVisualStyleBackColor = false;
            this.bnprint.Click += new System.EventHandler(this.bnprint_Click);
            // 
            // PrintDocument1
            // 
            this.PrintDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.PrintDocument1_PrintPage);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::SchoolManagementApplciation.Properties.Resources.acc;
            this.pictureBox2.Location = new System.Drawing.Point(764, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(131, 89);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 37;
            this.pictureBox2.TabStop = false;
            // 
            // Label11
            // 
            this.Label11.AutoSize = true;
            this.Label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label11.ForeColor = System.Drawing.Color.DarkRed;
            this.Label11.Location = new System.Drawing.Point(18, 15);
            this.Label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Label11.Name = "Label11";
            this.Label11.Size = new System.Drawing.Size(331, 36);
            this.Label11.TabIndex = 36;
            this.Label11.Text = "Update Student Marks";
            // 
            // EnterMarkss
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(922, 547);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.Label11);
            this.Controls.Add(this.bnprint);
            this.Controls.Add(this.bnclear);
            this.Controls.Add(this.lblcurentdate);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.cbosub);
            this.Controls.Add(this.bnload);
            this.Controls.Add(this.dtp);
            this.Controls.Add(this.cboname);
            this.Controls.Add(this.DataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "EnterMarkss";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bright Academy | Update Student Marks";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Entermarkss_FormClosed);
            this.Load += new System.EventHandler(this.Entermarkss_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        internal System.Windows.Forms.DataGridView DataGridView1;
        internal System.Windows.Forms.ComboBox cboname;
        internal System.Windows.Forms.DateTimePicker dtp;
        internal System.Windows.Forms.Button bnload;
        internal System.Windows.Forms.ComboBox cbosub;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Label lblcurentdate;
        internal System.Windows.Forms.Button bnclear;
        internal System.Windows.Forms.Button bnprint;
        internal System.Drawing.Printing.PrintDocument PrintDocument1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label Label11;
    }

    #endregion
}