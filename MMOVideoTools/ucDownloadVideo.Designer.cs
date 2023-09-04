namespace MMOVideoTools
{
    partial class ucDownloadVideo
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
            btnPaste = new Button();
            flPnlVideos = new FlowLayoutPanel();
            SuspendLayout();
            // 
            // btnPaste
            // 
            btnPaste.Location = new Point(3, 25);
            btnPaste.Name = "btnPaste";
            btnPaste.Size = new Size(115, 35);
            btnPaste.TabIndex = 0;
            btnPaste.Text = "Paste";
            btnPaste.UseVisualStyleBackColor = true;
            btnPaste.Click += btnPaste_Click;
            // 
            // flPnlVideos
            // 
            flPnlVideos.AutoScroll = true;
            flPnlVideos.BackColor = Color.White;
            flPnlVideos.Font = new Font("Consolas", 9F, FontStyle.Regular, GraphicsUnit.Point);
            flPnlVideos.Location = new Point(3, 66);
            flPnlVideos.Name = "flPnlVideos";
            flPnlVideos.Size = new Size(884, 373);
            flPnlVideos.TabIndex = 1;
            flPnlVideos.Paint += flPnlVideos_Paint;
            // 
            // ucDownloadVideo
            // 
            AutoScaleDimensions = new SizeF(7F, 14F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(flPnlVideos);
            Controls.Add(btnPaste);
            Font = new Font("Consolas", 9F, FontStyle.Regular, GraphicsUnit.Point);
            Name = "ucDownloadVideo";
            Size = new Size(890, 442);
            ResumeLayout(false);
        }

        #endregion

        private Button btnPaste;
        private FlowLayoutPanel flPnlVideos;
    }
}
