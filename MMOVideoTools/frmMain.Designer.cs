namespace MMOVideoTools
{
    partial class frmMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pnlMain = new Panel();
            menuStrip1 = new MenuStrip();
            menuToolStripMenuItem = new ToolStripMenuItem();
            downloadToolStripMenuItem = new ToolStripMenuItem();
            itemDownloadSingle = new ToolStripMenuItem();
            editToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // pnlMain
            // 
            pnlMain.Location = new Point(12, 27);
            pnlMain.Name = "pnlMain";
            pnlMain.Size = new Size(890, 426);
            pnlMain.TabIndex = 0;
            // 
            // menuStrip1
            // 
            menuStrip1.Font = new Font("Consolas", 9F, FontStyle.Regular, GraphicsUnit.Point);
            menuStrip1.Items.AddRange(new ToolStripItem[] { menuToolStripMenuItem, downloadToolStripMenuItem, editToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(911, 24);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            menuToolStripMenuItem.Size = new Size(47, 20);
            menuToolStripMenuItem.Text = "Menu";
            // 
            // downloadToolStripMenuItem
            // 
            downloadToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { itemDownloadSingle });
            downloadToolStripMenuItem.Name = "downloadToolStripMenuItem";
            downloadToolStripMenuItem.Size = new Size(75, 20);
            downloadToolStripMenuItem.Text = "Download";
            // 
            // itemDownloadSingle
            // 
            itemDownloadSingle.Name = "itemDownloadSingle";
            itemDownloadSingle.Size = new Size(158, 22);
            itemDownloadSingle.Text = "Single Video";
            itemDownloadSingle.Click += itemDownloadSingle_Click;
            // 
            // editToolStripMenuItem
            // 
            editToolStripMenuItem.Name = "editToolStripMenuItem";
            editToolStripMenuItem.Size = new Size(47, 20);
            editToolStripMenuItem.Text = "Edit";
            // 
            // frmMain
            // 
            AutoScaleDimensions = new SizeF(7F, 14F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(911, 491);
            Controls.Add(pnlMain);
            Controls.Add(menuStrip1);
            Font = new Font("Consolas", 9F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            MainMenuStrip = menuStrip1;
            Name = "frmMain";
            Text = "Form1";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pnlMain;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem menuToolStripMenuItem;
        private ToolStripMenuItem downloadToolStripMenuItem;
        private ToolStripMenuItem itemDownloadSingle;
        private ToolStripMenuItem editToolStripMenuItem;
    }
}