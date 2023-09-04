namespace MMOVideoTools
{
    partial class ucItemVideo
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            picThumbnail = new PictureBox();
            lbLink = new Label();
            lbTitle = new Label();
            pgrDownload = new ProgressBar();
            lbFileSize = new Label();
            lblStatus = new Label();
            ((System.ComponentModel.ISupportInitialize)picThumbnail).BeginInit();
            SuspendLayout();
            // 
            // picThumbnail
            // 
            picThumbnail.Image = Properties.Resources.images;
            picThumbnail.InitialImage = null;
            picThumbnail.Location = new Point(8, 6);
            picThumbnail.Name = "picThumbnail";
            picThumbnail.Size = new Size(109, 61);
            picThumbnail.SizeMode = PictureBoxSizeMode.StretchImage;
            picThumbnail.TabIndex = 0;
            picThumbnail.TabStop = false;
            // 
            // lbLink
            // 
            lbLink.AutoSize = true;
            lbLink.Location = new Point(123, 6);
            lbLink.Name = "lbLink";
            lbLink.Size = new Size(259, 14);
            lbLink.TabIndex = 1;
            lbLink.Text = "http://tiktok.com/@manhict/123456798";
            // 
            // lbTitle
            // 
            lbTitle.AutoSize = true;
            lbTitle.Location = new Point(123, 25);
            lbTitle.Name = "lbTitle";
            lbTitle.Size = new Size(140, 14);
            lbTitle.TabIndex = 2;
            lbTitle.Text = "love you #123 #1234";
            // 
            // pgrDownload
            // 
            pgrDownload.Location = new Point(207, 53);
            pgrDownload.Name = "pgrDownload";
            pgrDownload.Size = new Size(243, 10);
            pgrDownload.TabIndex = 3;
            // 
            // lbFileSize
            // 
            lbFileSize.AutoSize = true;
            lbFileSize.Location = new Point(123, 51);
            lbFileSize.Name = "lbFileSize";
            lbFileSize.Size = new Size(63, 14);
            lbFileSize.TabIndex = 4;
            lbFileSize.Text = "123459KB";
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Location = new Point(769, 30);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(77, 14);
            lblStatus.TabIndex = 5;
            lblStatus.Text = "Downloaded";
            lblStatus.TextAlign = ContentAlignment.MiddleRight;
            // 
            // ucItemVideo
            // 
            AutoScaleDimensions = new SizeF(7F, 14F);
            AutoScaleMode = AutoScaleMode.Font;
            BorderStyle = BorderStyle.FixedSingle;
            Controls.Add(lblStatus);
            Controls.Add(lbFileSize);
            Controls.Add(pgrDownload);
            Controls.Add(lbTitle);
            Controls.Add(lbLink);
            Controls.Add(picThumbnail);
            Font = new Font("Consolas", 9F, FontStyle.Regular, GraphicsUnit.Point);
            Name = "ucItemVideo";
            Size = new Size(860, 73);
            Load += ucItemVideo_Load;
            ((System.ComponentModel.ISupportInitialize)picThumbnail).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox picThumbnail;
        private Label lbLink;
        private Label lbTitle;
        private ProgressBar pgrDownload;
        private Label lbFileSize;
        private Label lblStatus;
    }
}
