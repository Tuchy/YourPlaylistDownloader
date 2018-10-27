using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Windows.Forms;
using YoutubeExtractor;
using System.IO;

namespace YourPlaylistDownloader
{
    public partial class frmYourPlaylistDownloader : Form
    {
        public frmYourPlaylistDownloader()
        {
            InitializeComponent();
        }

        private void frmYourPlaylistDownloader_Load(object sender, EventArgs e)
        {
            cboResolution.SelectedIndex = 0;
        }

        private void btnDownload_Click(object sender, EventArgs e)
        {
            progressBar.Minimum = 0;
            progressBar.Maximum = 100;

            DownloadVideo(txtUrl.Text, Convert.ToInt32(cboResolution.Text));


            MessageBox.Show("Your download completed successfully." + MessageBoxButtons.OK + MessageBoxIcon.Information);
        }




        private void DownloadVideo(string url, int resolution)
        {
            IEnumerable<VideoInfo> videos = DownloadUrlResolver.GetDownloadUrls(url);
            VideoInfo video = videos.First(p => p.VideoType == VideoType.Mp4 && p.Resolution == resolution);

            if (video.RequiresDecryption)
            {
                DownloadUrlResolver.DecryptDownloadUrl(video);
            }

            VideoDownloader downloader = new VideoDownloader(video, Path.Combine(Application.StartupPath + "\\", video.Title + video.VideoExtension));
            downloader.DownloadProgressChanged += Downloader_DownloadProgressChanged;

            // Thread to handle downloading youtube videos
            // Advantages is that it helps applications use more than one tread during execution that the same time
            Thread thread = new Thread(() => { downloader.Execute(); }) { IsBackground = true };
            thread.Start();

        }

        private void Downloader_DownloadProgressChanged(object sender, ProgressEventArgs e)
        {
            Invoke(new MethodInvoker(delegate ()
            {
                progressBar.Value = (int)e.ProgressPercentage;
                lblPercentage.Text = $"{ string.Format("{0:0.##}", e.ProgressPercentage)}%";
                progressBar.Update();
            }));
        }
    }
}
