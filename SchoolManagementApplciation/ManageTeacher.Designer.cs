namespace SchoolManagementApplciation
{
    partial class ManageTeacher
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManageTeacher));
            this.TextBox1 = new System.Windows.Forms.TextBox();
            this.bnadd = new System.Windows.Forms.Button();
            this.bnrefresh = new System.Windows.Forms.Button();
            this.bndelete = new System.Windows.Forms.Button();
            this.Label1 = new System.Windows.Forms.Label();
            this.bnprint = new System.Windows.Forms.Button();
            this.DataGridView1 = new System.Windows.Forms.DataGridView();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.Label11 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // TextBox1
            // 
            this.TextBox1.BackColor = System.Drawing.Color.MistyRose;
            this.TextBox1.Location = new System.Drawing.Point(63, 67);
            this.TextBox1.Margin = new System.Windows.Forms.Padding(2);
            this.TextBox1.Name = "TextBox1";
            this.TextBox1.Size = new System.Drawing.Size(332, 20);
            this.TextBox1.TabIndex = 1;
            this.TextBox1.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TextBox1_KeyUp);
            // 
            // bnadd
            // 
            this.bnadd.BackColor = System.Drawing.Color.DarkRed;
            this.bnadd.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.bnadd.Location = new System.Drawing.Point(14, 465);
            this.bnadd.Margin = new System.Windows.Forms.Padding(2);
            this.bnadd.Name = "bnadd";
            this.bnadd.Size = new System.Drawing.Size(193, 48);
            this.bnadd.TabIndex = 2;
            this.bnadd.Text = "Add New Teacher";
            this.bnadd.UseVisualStyleBackColor = false;
            this.bnadd.Click += new System.EventHandler(this.Bnadd_Click);
            // 
            // bnrefresh
            // 
            this.bnrefresh.BackColor = System.Drawing.Color.DarkRed;
            this.bnrefresh.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.bnrefresh.Location = new System.Drawing.Point(453, 465);
            this.bnrefresh.Margin = new System.Windows.Forms.Padding(2);
            this.bnrefresh.Name = "bnrefresh";
            this.bnrefresh.Size = new System.Drawing.Size(193, 48);
            this.bnrefresh.TabIndex = 4;
            this.bnrefresh.Text = "Refresh";
            this.bnrefresh.UseVisualStyleBackColor = false;
            this.bnrefresh.Click += new System.EventHandler(this.bnrefresh_Click);
            // 
            // bndelete
            // 
            this.bndelete.BackColor = System.Drawing.Color.DarkRed;
            this.bndelete.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.bndelete.Location = new System.Drawing.Point(232, 465);
            this.bndelete.Margin = new System.Windows.Forms.Padding(2);
            this.bndelete.Name = "bndelete";
            this.bndelete.Size = new System.Drawing.Size(193, 48);
            this.bndelete.TabIndex = 5;
            this.bndelete.Text = "Delete Selected Teacher Records";
            this.bndelete.UseVisualStyleBackColor = false;
            this.bndelete.Click += new System.EventHandler(this.bndelete_Click);
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(18, 70);
            this.Label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(41, 13);
            this.Label1.TabIndex = 6;
            this.Label1.Text = "Search";
            // 
            // bnprint
            // 
            this.bnprint.BackColor = System.Drawing.Color.IndianRed;
            this.bnprint.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.bnprint.Location = new System.Drawing.Point(672, 465);
            this.bnprint.Margin = new System.Windows.Forms.Padding(2);
            this.bnprint.Name = "bnprint";
            this.bnprint.Size = new System.Drawing.Size(193, 48);
            this.bnprint.TabIndex = 3;
            this.bnprint.Text = "Close";
            this.bnprint.UseVisualStyleBackColor = false;
            this.bnprint.Click += new System.EventHandler(this.bnprint_Click);
            // 
            // DataGridView1
            // 
            this.DataGridView1.AllowUserToAddRows = false;
            this.DataGridView1.AllowUserToDeleteRows = false;
            this.DataGridView1.BackgroundColor = System.Drawing.Color.MistyRose;
            this.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridView1.Location = new System.Drawing.Point(14, 107);
            this.DataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.DataGridView1.Name = "DataGridView1";
            this.DataGridView1.RowTemplate.Height = 24;
            this.DataGridView1.Size = new System.Drawing.Size(850, 344);
            this.DataGridView1.TabIndex = 7;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::SchoolManagementApplciation.Properties.Resources.acc;
            this.pictureBox2.Location = new System.Drawing.Point(737, 13);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(127, 89);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 37;
            this.pictureBox2.TabStop = false;
            // 
            // Label11
            // 
            this.Label11.AutoSize = true;
            this.Label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label11.ForeColor = System.Drawing.Color.DarkRed;
            this.Label11.Location = new System.Drawing.Point(15, 13);
            this.Label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Label11.Name = "Label11";
            this.Label11.Size = new System.Drawing.Size(370, 36);
            this.Label11.TabIndex = 36;
            this.Label11.Text = "Manage Staff Information";
            // 
            // ManageTeacher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(878, 530);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.Label11);
            this.Controls.Add(this.DataGridView1);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.bndelete);
            this.Controls.Add(this.bnrefresh);
            this.Controls.Add(this.bnprint);
            this.Controls.Add(this.bnadd);
            this.Controls.Add(this.TextBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ManageTeacher";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bright Academy | Manage Staff Information";
            this.Load += new System.EventHandler(this.ManageTeacher_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        internal System.Windows.Forms.TextBox TextBox1;
        internal System.Windows.Forms.Button bnadd;
        internal System.Windows.Forms.Button bnrefresh;
        internal System.Windows.Forms.Button bndelete;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.DataGridViewTextBoxColumn StaffIDDataGridViewTextBoxColumn;
        internal System.Windows.Forms.DataGridViewTextBoxColumn PhoneNumberDataGridViewTextBoxColumn;
        internal System.Windows.Forms.DataGridViewTextBoxColumn EmailAddressDataGridViewTextBoxColumn;
        internal System.Windows.Forms.Button bnprint;
        internal System.Windows.Forms.DataGridView DataGridView1;

        #endregion

        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label Label11;
    }
}