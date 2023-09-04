namespace MMOVideoTools
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void itemDownloadSingle_Click(object sender, EventArgs e)
        {
            pnlMain.Controls.Add(new ucDownloadVideo());
        }
    }
}