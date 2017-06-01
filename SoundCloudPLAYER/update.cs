using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;
using System.Net;

namespace TigerTube
{
    public partial class update : Form
    {
        string aa = "https://initiate.alphacoders.com/download/wallpaper/597309/images2/jpg/0945183157.jpg";
        string pc = "mb.jpg";
        WebClient webClient;
        Stopwatch sw = new Stopwatch();
        public update()
        {
            InitializeComponent();
        }

        private void update_Load(object sender, EventArgs e)
        {
            string DOWNLOADFILE = "http://releases.ubuntu.com/16.04.2/ubuntu-16.04.2-desktop-amd64.iso";
            string filePath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

            DownloadFile(DOWNLOADFILE, filePath);
        }
        public void DownloadFile(string urlAddress, string Location)
        {
            using (webClient = new WebClient())
            {
                webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(Completed);
                webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(ProgressChanged);
                Uri URL = urlAddress.StartsWith("http://", StringComparison.OrdinalIgnoreCase) ? new Uri(urlAddress) : new Uri("http://" + urlAddress);
                sw.Start();

                try
                {
                    webClient.DownloadFileAsync(URL, pc);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void ProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
            labelSpeed.Text = string.Format("{0} kb/s", (e.BytesReceived / 1024d / sw.Elapsed.TotalSeconds).ToString("0.00"));
            progressBar.Value = e.ProgressPercentage;
            labelPerc.Text = e.ProgressPercentage.ToString() + "%";
            labelDownloaded.Text = string.Format("{0} Mb / {1} Mb",
                (e.BytesReceived / 1024d / 1024d).ToString("0.00"),
                (e.TotalBytesToReceive / 1024d / 1024d).ToString("0.00"));
        }

        private void Completed(object sender, AsyncCompletedEventArgs e)
        {
            sw.Reset();

            if (e.Cancelled == true)
            {
                MessageBox.Show("Download has been canceled.");
            }
            else
            {
                MessageBox.Show("Download completed!");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
