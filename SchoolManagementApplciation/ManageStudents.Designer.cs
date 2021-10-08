namespace SchoolManagementApplciation
{
    partial class ManageStudents
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManageStudents));
            this.DataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtsearch = new System.Windows.Forms.TextBox();
            this.bnnew = new System.Windows.Forms.Button();
            this.bnprint = new System.Windows.Forms.Button();
            this.bndelete = new System.Windows.Forms.Button();
            this.bnrefresh = new System.Windows.Forms.Button();
            this.Label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // DataGridView1
            // 
            this.DataGridView1.AllowUserToAddRows = false;
            this.DataGridView1.AllowUserToDeleteRows = false;
            this.DataGridView1.BackgroundColor = System.Drawing.Color.MistyRose;
            this.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridView1.Location = new System.Drawing.Point(25, 104);
            this.DataGridView1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.DataGridView1.Name = "DataGridView1";
            this.DataGridView1.ReadOnly = true;
            this.DataGridView1.RowTemplate.Height = 24;
            this.DataGridView1.Size = new System.Drawing.Size(828, 350);
            this.DataGridView1.TabIndex = 0;
            // 
            // txtsearch
            // 
            this.txtsearch.BackColor = System.Drawing.Color.MistyRose;
            this.txtsearch.Location = new System.Drawing.Point(25, 66);
            this.txtsearch.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtsearch.Name = "txtsearch";
            this.txtsearch.Size = new System.Drawing.Size(716, 20);
            this.txtsearch.TabIndex = 1;
            this.txtsearch.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtsearch_KeyUp);
            // 
            // bnnew
            // 
            this.bnnew.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bnnew.Location = new System.Drawing.Point(25, 472);
            this.bnnew.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.bnnew.Name = "bnnew";
            this.bnnew.Size = new System.Drawing.Size(172, 67);
            this.bnnew.TabIndex = 2;
            this.bnnew.Text = "New Student";
            this.bnnew.UseVisualStyleBackColor = true;
            this.bnnew.Click += new System.EventHandler(this.bnnew_Click);
            // 
            // bnprint
            // 
            this.bnprint.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bnprint.Location = new System.Drawing.Point(681, 472);
            this.bnprint.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.bnprint.Name = "bnprint";
            this.bnprint.Size = new System.Drawing.Size(172, 67);
            this.bnprint.TabIndex = 3;
            this.bnprint.Text = "Edit";
            this.bnprint.UseVisualStyleBackColor = true;
            this.bnprint.Click += new System.EventHandler(this.bnprint_Click);
            // 
            // bndelete
            // 
            this.bndelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bndelete.Location = new System.Drawing.Point(465, 472);
            this.bndelete.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.bndelete.Name = "bndelete";
            this.bndelete.Size = new System.Drawing.Size(172, 67);
            this.bndelete.TabIndex = 4;
            this.bndelete.Text = "Delete";
            this.bndelete.UseVisualStyleBackColor = true;
            this.bndelete.Click += new System.EventHandler(this.bndelete_Click);
            // 
            // bnrefresh
            // 
            this.bnrefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bnrefresh.Location = new System.Drawing.Point(248, 472);
            this.bnrefresh.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.bnrefresh.Name = "bnrefresh";
            this.bnrefresh.Size = new System.Drawing.Size(172, 67);
            this.bnrefresh.TabIndex = 5;
            this.bnrefresh.Text = "Refresh";
            this.bnrefresh.UseVisualStyleBackColor = true;
            this.bnrefresh.Click += new System.EventHandler(this.bnrefresh_Click);
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(22, 51);
            this.Label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(112, 13);
            this.Label1.TabIndex = 6;
            this.Label1.Text = "Search Student Name";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SchoolManagementApplciation.Properties.Resources.acc;
            this.pictureBox1.Location = new System.Drawing.Point(746, 11);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(107, 75);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkRed;
            this.label2.Location = new System.Drawing.Point(254, 9);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(327, 42);
            this.label2.TabIndex = 8;
            this.label2.Text = "Manage Students";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(258, 555);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(343, 13);
            this.label12.TabIndex = 35;
            this.label12.Text = "B  r  i  g  h  t     A  c  a  d  e  m  y     |     G  a  m  p  a  h  a";
            // 
            // ManageStudents
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(879, 579);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.bnrefresh);
            this.Controls.Add(this.bndelete);
            this.Controls.Add(this.bnprint);
            this.Controls.Add(this.bnnew);
            this.Controls.Add(this.txtsearch);
            this.Controls.Add(this.DataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "ManageStudents";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bright Academy | Manage Students";
            this.Load += new System.EventHandler(this.ManageStudents_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        internal System.Windows.Forms.DataGridView DataGridView1;
        internal System.Windows.Forms.TextBox txtsearch;
        internal System.Windows.Forms.Button bnnew;
        internal System.Windows.Forms.Button bnprint;
        internal System.Windows.Forms.Button bndelete;
        internal System.Windows.Forms.Button bnrefresh;
        internal System.Windows.Forms.DataGridViewTextBoxColumn RegistrationNumberDataGridViewTextBoxColumn;
        internal System.Windows.Forms.DataGridViewTextBoxColumn ContactPhoneNumberDataGridViewTextBoxColumn;
        internal System.Windows.Forms.Label Label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        internal System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label12;
    }
}
#endregion