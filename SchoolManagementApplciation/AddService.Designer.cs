namespace SchoolManagementApplciation
{
    partial class AddService
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddService));
            this.Label1 = new System.Windows.Forms.Label();
            this.txtservicename = new System.Windows.Forms.TextBox();
            this.txtserviceamount = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbofreq = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.Label11 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(149, 66);
            this.Label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(74, 13);
            this.Label1.TabIndex = 5;
            this.Label1.Text = "Service Name";
            // 
            // txtservicename
            // 
            this.txtservicename.BackColor = System.Drawing.Color.MistyRose;
            this.txtservicename.Location = new System.Drawing.Point(261, 64);
            this.txtservicename.Margin = new System.Windows.Forms.Padding(2);
            this.txtservicename.Name = "txtservicename";
            this.txtservicename.Size = new System.Drawing.Size(165, 20);
            this.txtservicename.TabIndex = 6;
            // 
            // txtserviceamount
            // 
            this.txtserviceamount.BackColor = System.Drawing.Color.MistyRose;
            this.txtserviceamount.Location = new System.Drawing.Point(261, 99);
            this.txtserviceamount.Margin = new System.Windows.Forms.Padding(2);
            this.txtserviceamount.Name = "txtserviceamount";
            this.txtserviceamount.Size = new System.Drawing.Size(165, 20);
            this.txtserviceamount.TabIndex = 8;
            this.txtserviceamount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox2_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(149, 101);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Amount";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(149, 137);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Frequency";
            // 
            // cbofreq
            // 
            this.cbofreq.BackColor = System.Drawing.Color.MistyRose;
            this.cbofreq.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbofreq.FormattingEnabled = true;
            this.cbofreq.Items.AddRange(new object[] {
            "Daily",
            "Monthly",
            "Yearly",
            "Term Wise",
            "One Time"});
            this.cbofreq.Location = new System.Drawing.Point(261, 135);
            this.cbofreq.Margin = new System.Windows.Forms.Padding(2);
            this.cbofreq.Name = "cbofreq";
            this.cbofreq.Size = new System.Drawing.Size(165, 21);
            this.cbofreq.TabIndex = 10;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkRed;
            this.button1.ForeColor = System.Drawing.Color.Transparent;
            this.button1.Location = new System.Drawing.Point(171, 170);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(130, 41);
            this.button1.TabIndex = 11;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::SchoolManagementApplciation.Properties.Resources.acc;
            this.pictureBox2.Location = new System.Drawing.Point(14, 54);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(131, 112);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 37;
            this.pictureBox2.TabStop = false;
            // 
            // Label11
            // 
            this.Label11.AutoSize = true;
            this.Label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label11.ForeColor = System.Drawing.Color.DarkRed;
            this.Label11.Location = new System.Drawing.Point(146, 9);
            this.Label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Label11.Name = "Label11";
            this.Label11.Size = new System.Drawing.Size(188, 36);
            this.Label11.TabIndex = 36;
            this.Label11.Text = "Add Service";
            this.Label11.Click += new System.EventHandler(this.Label11_Click);
            // 
            // AddService
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(465, 222);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.Label11);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cbofreq);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtserviceamount);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtservicename);
            this.Controls.Add(this.Label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "AddService";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bright Academy | Add Service";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Label Label1;
        private System.Windows.Forms.TextBox txtservicename;
        private System.Windows.Forms.TextBox txtserviceamount;
        internal System.Windows.Forms.Label label2;
        internal System.Windows.Forms.Label label3;
        internal System.Windows.Forms.ComboBox cbofreq;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label Label11;
    }
}