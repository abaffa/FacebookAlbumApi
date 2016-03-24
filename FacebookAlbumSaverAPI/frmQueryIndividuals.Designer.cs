namespace FacebookAlbumSaverAPI
{
    partial class frmQueryIndividuals
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
            this.txtItemID = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.txtAccessToken = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.chkSaveImage = new System.Windows.Forms.CheckBox();
            this.chkShowPhotos = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtItemID
            // 
            this.txtItemID.Location = new System.Drawing.Point(141, 26);
            this.txtItemID.Name = "txtItemID";
            this.txtItemID.Size = new System.Drawing.Size(541, 20);
            this.txtItemID.TabIndex = 5;
            this.txtItemID.TextChanged += new System.EventHandler(this.txtItemID_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(607, 226);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Query";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtAccessToken
            // 
            this.txtAccessToken.Location = new System.Drawing.Point(141, 3);
            this.txtAccessToken.Name = "txtAccessToken";
            this.txtAccessToken.Size = new System.Drawing.Size(541, 20);
            this.txtAccessToken.TabIndex = 6;
            this.txtAccessToken.TextChanged += new System.EventHandler(this.txtAccessToken_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Access Token:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(52, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Album:";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(51, 235);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(96, 13);
            this.linkLabel1.TabIndex = 10;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Get Access Token";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(47, 52);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(635, 168);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // chkSaveImage
            // 
            this.chkSaveImage.AutoSize = true;
            this.chkSaveImage.Checked = true;
            this.chkSaveImage.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkSaveImage.Location = new System.Drawing.Point(264, 235);
            this.chkSaveImage.Name = "chkSaveImage";
            this.chkSaveImage.Size = new System.Drawing.Size(82, 17);
            this.chkSaveImage.TabIndex = 12;
            this.chkSaveImage.Text = "Save Photo";
            this.chkSaveImage.UseVisualStyleBackColor = true;
            // 
            // chkShowPhotos
            // 
            this.chkShowPhotos.AutoSize = true;
            this.chkShowPhotos.Location = new System.Drawing.Point(396, 234);
            this.chkShowPhotos.Name = "chkShowPhotos";
            this.chkShowPhotos.Size = new System.Drawing.Size(89, 17);
            this.chkShowPhotos.TabIndex = 13;
            this.chkShowPhotos.Text = "Show Photos";
            this.chkShowPhotos.UseVisualStyleBackColor = true;
            // 
            // frmQueryIndividuals
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(732, 261);
            this.Controls.Add(this.chkShowPhotos);
            this.Controls.Add(this.chkSaveImage);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtAccessToken);
            this.Controls.Add(this.txtItemID);
            this.Controls.Add(this.button1);
            this.Name = "frmQueryIndividuals";
            this.Text = "Query FB Individual";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtItemID;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtAccessToken;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.CheckBox chkSaveImage;
        private System.Windows.Forms.CheckBox chkShowPhotos;
    }
}