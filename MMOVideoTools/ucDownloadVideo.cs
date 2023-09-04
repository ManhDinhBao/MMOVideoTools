using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MMOVideoTools
{
    public partial class ucDownloadVideo : UserControl
    {
        public ucDownloadVideo()
        {
            InitializeComponent();
        }

        private void btnPaste_Click(object sender, EventArgs e)
        {
            flPnlVideos.Controls.Add(new ucItemVideo());
        }

        private void flPnlVideos_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
