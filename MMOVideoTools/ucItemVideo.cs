using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MMOVideoTools
{
    public partial class ucItemVideo : UserControl
    {
        public ucItemVideo()
        {
            InitializeComponent();
        }

        private void ucItemVideo_Load(object sender, EventArgs e)
        {
            string url = "https://v16m-default.akamaized.net/c82bd25d709ab63d1f16c44e4b6a51da/64f5f5ef/video/tos/useast2a/tos-useast2a-ve-0068c001-euttp/oM3PBFohKnoNhtH6VoQCjEgdIAyyWNziov1hfA/?a=0&ch=0&cr=0&dr=0&lr=all&cd=0%7C0%7C0%7C0&cv=1&br=1460&bt=730&cs=0&ds=6&ft=e-t4p2BHj4M9woZLDkLnzJLO5canuz0iXjzGvdlMyeF&mime_type=video_mp4&qs=0&rc=bGRzaWdoMXJud2YpQHN1eWgxZnNud2xAKWhkaWlpOWk7ZTc5OzMzaDhnKXc1NXN4Om1nbmYzM2o1aXl5bVx2K2JjaHFmOmQycCNib3BoXitsaHFgLjFiXzJeYjNeMl4uMGEzMjpjLWNuXmE0YGsyZy0tYDItLTo%3D&l=20230904092015EC7537B841D473070ACF&btag=e00090000";

            Uri uri = new Uri(url);
            string fileName = System.IO.Path.GetFileName(uri.AbsolutePath);
            SaveFile(url, Application.StartupPath + "/" + fileName+".mp4");
        }

        private async Task SaveFile(string fileUrl, string pathToSave)
        {
            var httpClient = new HttpClient();

            var httpResult = await httpClient.GetAsync(fileUrl);
            using var resultStream = await httpResult.Content.ReadAsStreamAsync();
            using var fileStream = File.Create(pathToSave);
            resultStream.CopyTo(fileStream);
        }
    }
}
