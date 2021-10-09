namespace SchoolManagementApplciation
{
    partial class Studentsdetailedlist
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
            this.Label2 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.cboname = new System.Windows.Forms.ComboBox();
            this.dtp = new System.Windows.Forms.DateTimePicker();
            this.cboclass = new System.Windows.Forms.ComboBox();
            this.cbosection = new System.Windows.Forms.ComboBox();
            this.Label3 = new System.Windows.Forms.Label();
            this.Label4 = new System.Windows.Forms.Label();
            this.PrintDocument1 = new System.Drawing.Printing.PrintDocument();
            this.DataGridView1 = new System.Windows.Forms.DataGridView();
            this.Button1 = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Location = new System.Drawing.Point(286, 79);
            this.Label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(80, 13);
            this.Label2.TabIndex = 12;
            this.Label2.Text = "Enter The Date";
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(11, 79);
            this.Label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(75, 13);
            this.Label1.TabIndex = 10;
            this.Label1.Text = "Student Name";
            // 
            // cboname
            // 
            this.cboname.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboname.FormattingEnabled = true;
            this.cboname.Location = new System.Drawing.Point(14, 97);
            this.cboname.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cboname.Name = "cboname";
            this.cboname.Size = new System.Drawing.Size(197, 21);
            this.cboname.TabIndex = 9;
            this.cboname.SelectedIndexChanged += new System.EventHandler(this.cboname_SelectedIndexChanged);
            // 
            // dtp
            // 
            this.dtp.Location = new System.Drawing.Point(289, 98);
            this.dtp.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtp.Name = "dtp";
            this.dtp.Size = new System.Drawing.Size(181, 20);
            this.dtp.TabIndex = 8;
            this.dtp.ValueChanged += new System.EventHandler(this.dtp_ValueChanged);
            // 
            // cboclass
            // 
            this.cboclass.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboclass.FormattingEnabled = true;
            this.cboclass.Location = new System.Drawing.Point(489, 97);
            this.cboclass.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cboclass.Name = "cboclass";
            this.cboclass.Size = new System.Drawing.Size(86, 21);
            this.cboclass.TabIndex = 13;
            this.cboclass.SelectedIndexChanged += new System.EventHandler(this.cboclass_SelectedIndexChanged);
            // 
            // cbosection
            // 
            this.cbosection.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbosection.FormattingEnabled = true;
            this.cbosection.Location = new System.Drawing.Point(598, 97);
            this.cbosection.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbosection.Name = "cbosection";
            this.cbosection.Size = new System.Drawing.Size(133, 21);
            this.cbosection.TabIndex = 14;
            this.cbosection.SelectedIndexChanged += new System.EventHandler(this.cbosection_SelectedIndexChanged);
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Location = new System.Drawing.Point(486, 79);
            this.Label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(32, 13);
            this.Label3.TabIndex = 15;
            this.Label3.Text = "Class";
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Location = new System.Drawing.Point(595, 79);
            this.Label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(43, 13);
            this.Label4.TabIndex = 16;
            this.Label4.Text = "Section";
            this.Label4.Click += new System.EventHandler(this.Label4_Click);
            // 
            // PrintDocument1
            // 
            this.PrintDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.PrintDocument1_PrintPage);
            // 
            // DataGridView1
            // 
            this.DataGridView1.AllowUserToAddRows = false;
            this.DataGridView1.AllowUserToDeleteRows = false;
            this.DataGridView1.BackgroundColor = System.Drawing.Color.MistyRose;
            this.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridView1.Location = new System.Drawing.Point(11, 132);
            this.DataGridView1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.DataGridView1.Name = "DataGridView1";
            this.DataGridView1.ReadOnly = true;
            this.DataGridView1.RowTemplate.Height = 24;
            this.DataGridView1.Size = new System.Drawing.Size(720, 349);
            this.DataGridView1.TabIndex = 17;
            // 
            // Button1
            // 
            this.Button1.Location = new System.Drawing.Point(215, 98);
            this.Button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Button1.Name = "Button1";
            this.Button1.Size = new System.Drawing.Size(53, 20);
            this.Button1.TabIndex = 18;
            this.Button1.Text = "Only";
            this.Button1.UseVisualStyleBackColor = true;
            this.Button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::SchoolManagementApplciation.Properties.Resources.acc;
            this.pictureBox2.Location = new System.Drawing.Point(11, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(88, 74);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 49;
            this.pictureBox2.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DarkRed;
            this.label5.Location = new System.Drawing.Point(104, 20);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(420, 36);
            this.label5.TabIndex = 48;
            this.label5.Text = "Detailed Student Attendance";
            // 
            // Studentsdetailedlist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(742, 492);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Button1);
            this.Controls.Add(this.DataGridView1);
            this.Controls.Add(this.Label4);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.cbosection);
            this.Controls.Add(this.cboclass);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.cboname);
            this.Controls.Add(this.dtp);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Studentsdetailedlist";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bright Academy | Detailed Student Attendance";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Studentsdetailedlist_FormClosed);
            this.Load += new System.EventHandler(this.Studentsdetailedlist_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.ComboBox cboname;
        internal System.Windows.Forms.DateTimePicker dtp;
        internal System.Windows.Forms.ComboBox cboclass;
        internal System.Windows.Forms.ComboBox cbosection;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.Label Label4;
        internal System.Drawing.Printing.PrintDocument PrintDocument1;
        internal System.Windows.Forms.DataGridView DataGridView1;
        internal System.Windows.Forms.Button Button1;

        #endregion

        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label5;
    }
}