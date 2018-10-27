namespace YourPlaylistDownloader
{
    partial class frmYourPlaylistDownloader
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
            this.btnDownload = new System.Windows.Forms.Button();
            this.txtUrl = new System.Windows.Forms.TextBox();
            this.cboResolution = new System.Windows.Forms.ComboBox();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.lblUrl = new System.Windows.Forms.Label();
            this.lblResolution = new System.Windows.Forms.Label();
            this.lblPercentage = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.txtSavePath = new System.Windows.Forms.Label();
            this.lblMp4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnDownload
            // 
            this.btnDownload.Location = new System.Drawing.Point(342, 148);
            this.btnDownload.Name = "btnDownload";
            this.btnDownload.Size = new System.Drawing.Size(133, 23);
            this.btnDownload.TabIndex = 0;
            this.btnDownload.Text = "Download";
            this.btnDownload.UseVisualStyleBackColor = true;
            this.btnDownload.Click += new System.EventHandler(this.btnDownload_Click);
            // 
            // txtUrl
            // 
            this.txtUrl.Location = new System.Drawing.Point(109, 26);
            this.txtUrl.Name = "txtUrl";
            this.txtUrl.Size = new System.Drawing.Size(376, 20);
            this.txtUrl.TabIndex = 1;
            // 
            // cboResolution
            // 
            this.cboResolution.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboResolution.FormattingEnabled = true;
            this.cboResolution.Items.AddRange(new object[] {
            "360",
            "480",
            "720",
            "1080",
            "1440"});
            this.cboResolution.Location = new System.Drawing.Point(59, 148);
            this.cboResolution.Name = "cboResolution";
            this.cboResolution.Size = new System.Drawing.Size(88, 21);
            this.cboResolution.TabIndex = 2;
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(33, 99);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(437, 21);
            this.progressBar.TabIndex = 3;
            // 
            // lblUrl
            // 
            this.lblUrl.AutoSize = true;
            this.lblUrl.Location = new System.Drawing.Point(56, 29);
            this.lblUrl.Name = "lblUrl";
            this.lblUrl.Size = new System.Drawing.Size(32, 13);
            this.lblUrl.TabIndex = 4;
            this.lblUrl.Text = "URL:";
            // 
            // lblResolution
            // 
            this.lblResolution.AutoSize = true;
            this.lblResolution.Location = new System.Drawing.Point(30, 132);
            this.lblResolution.Name = "lblResolution";
            this.lblResolution.Size = new System.Drawing.Size(60, 13);
            this.lblResolution.TabIndex = 4;
            this.lblResolution.Text = "Resolution:";
            // 
            // lblPercentage
            // 
            this.lblPercentage.AutoSize = true;
            this.lblPercentage.Location = new System.Drawing.Point(487, 107);
            this.lblPercentage.Name = "lblPercentage";
            this.lblPercentage.Size = new System.Drawing.Size(21, 13);
            this.lblPercentage.TabIndex = 4;
            this.lblPercentage.Text = "0%";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(109, 59);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(376, 20);
            this.textBox1.TabIndex = 1;
            // 
            // txtSavePath
            // 
            this.txtSavePath.AutoSize = true;
            this.txtSavePath.Location = new System.Drawing.Point(31, 62);
            this.txtSavePath.Name = "txtSavePath";
            this.txtSavePath.Size = new System.Drawing.Size(57, 13);
            this.txtSavePath.TabIndex = 4;
            this.txtSavePath.Text = "Save Path";
            // 
            // lblMp4
            // 
            this.lblMp4.AutoSize = true;
            this.lblMp4.Location = new System.Drawing.Point(24, 151);
            this.lblMp4.Name = "lblMp4";
            this.lblMp4.Size = new System.Drawing.Size(29, 13);
            this.lblMp4.TabIndex = 4;
            this.lblMp4.Text = "MP4";
            // 
            // frmYourPlaylistDownloader
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(537, 203);
            this.Controls.Add(this.lblPercentage);
            this.Controls.Add(this.lblMp4);
            this.Controls.Add(this.lblResolution);
            this.Controls.Add(this.txtSavePath);
            this.Controls.Add(this.lblUrl);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.cboResolution);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.txtUrl);
            this.Controls.Add(this.btnDownload);
            this.MaximizeBox = false;
            this.Name = "frmYourPlaylistDownloader";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Your Playlist Downloader";
            this.Load += new System.EventHandler(this.frmYourPlaylistDownloader_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDownload;
        private System.Windows.Forms.TextBox txtUrl;
        private System.Windows.Forms.ComboBox cboResolution;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Label lblUrl;
        private System.Windows.Forms.Label lblResolution;
        private System.Windows.Forms.Label lblPercentage;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label txtSavePath;
        private System.Windows.Forms.Label lblMp4;
    }
}

