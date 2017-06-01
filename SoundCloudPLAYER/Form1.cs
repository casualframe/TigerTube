using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Google.Apis.YouTube.v3;
using Google.Apis.YouTube.v3.Data;
using Google.Apis.Services;

namespace SoundCloudPLAYER
{
    public partial class Form1 : MaterialForm
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            
             
                if(System.IO.File.Exists("settings.tt"))
                {

                }
                else
                {
                DialogResult dialogResult = MessageBox.Show("Welcome to TigerTube , if you want change the volume check Show YouTube player , press ok to do not show this message again", "TigerTube", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (dialogResult == DialogResult.Yes)
                {
                    System.IO.File.Create("settings.tt");
                }

                if (dialogResult == DialogResult.No)
                {

                }

  
                  
            }

            
            webBrowser1.Visible = false;
            videoid.Visible = false;
            playvideo.Visible = false;
        }
        internal class Search
        {
            [STAThread]
            static void Maina(string[] args)
            {
                Console.WriteLine("YouTube Data API: Search");
                Console.WriteLine("========================");

                try
                {
                    new Search();
                }
                catch (AggregateException ex)
                {
                    foreach (var e in ex.InnerExceptions)
                    {
                        Console.WriteLine("Error: " + e.Message);
                    }
                }
            }

 
        }

        private void serachbtn_Click(object sender, EventArgs e)
        {
            materialSingleLineTextField1.Location = new Point(728, 32);
            materialSingleLineTextField1.Visible = true;
            videoid.Visible = false;
            playvideo.Location = new Point(107, 32);
             serachbtn.Location = new Point(956, 32);
            playvideo.Anchor = (AnchorStyles.Left | AnchorStyles.Top);

        }
         
            private void textBox1_TextChanged(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
           
        }

        private void materialSingleLineTextField1_Click(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            var vidid = 0;
            if (e.KeyChar == (char)13)
            {
                playvideo.Visible = true;
                materialSingleLineTextField1.Visible = false;
                serachbtn.Location = new Point(120, 33);
                playvideo.Location = new Point(956, 33);
                playvideo.Click += new EventHandler(playvideo_Click);
                videoid.Visible = true;
                videoid.Location = new Point(728, 32);
                var youtubeService = new YouTubeService(new BaseClientService.Initializer()
                {
                    ApiKey = "AIzaSyDcH3_mJ3JnNWYaE7_quexgJXEZ9fFQZyo",
                    ApplicationName = this.GetType().ToString()
                });

                var searchListRequest = youtubeService.Search.List("snippet");
                searchListRequest.Q = materialSingleLineTextField1.Text + "audio";
                searchListRequest.MaxResults = 50;
                var searchListResponse = searchListRequest.Execute();
                serachbtn.Enabled = true;
                List<string> videos = new List<string>();
                foreach (var searchResult in searchListResponse.Items)
                {
                    switch (searchResult.Id.Kind)
                    {
                        case "youtube#video":
                            videos.Add(String.Format("{0} (ID : {1})", searchResult.Snippet.Title, searchResult.Id.VideoId));
                            break;

                            
                    }
                }

                richTextBox1.Text = (String.Format("\n{0}\n", string.Join("\n", videos)));
            }

        }

        private void playvideo_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://www.youtube.com/watch?v=" + videoid.Text);
            webBrowser1.Visible = false;
            
        }

        private void testbtn()
        {
               
        }

        private void testbtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Work");
        }

        private void showYouTubePlayerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            
        }

        private void materialCheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (materialCheckBox1.Checked)
            {
                materialCheckBox2.Enabled = true;
                webBrowser1.Visible = true;
                webBrowser1.Visible = true;
                richTextBox1.Visible = false;
            }
            else
            {
                
                webBrowser1.Visible = false;
                richTextBox1.Visible = true;
            }
        }

        private void materialCheckBox2_CheckedChanged(object sender, EventArgs e)
        {
            
            
            webBrowser1.Navigate(@"C:\Users\brad\Documents\Visual Studio 2017\Projects\SoundCloudPLAYER\SoundCloudPLAYER\bin\Debug\page.html");
            materialCheckBox2.Enabled = false;
            webBrowser1.Visible = false;

        }

        private void playvideo_Click_1(object sender, EventArgs e)
        {
            materialSingleLineTextField1.Visible = false;
            videoid.Visible = true;
            videoid.Location = new Point(728, 32);
            playvideo.Location = new Point(956, 32);
            serachbtn.Location = new Point(107, 32);
            serachbtn.Anchor = (AnchorStyles.Left | AnchorStyles.Top);
            playvideo.Anchor = (AnchorStyles.Left | AnchorStyles.Top);
            videoid.Anchor = (AnchorStyles.Left | AnchorStyles.Top);
            serachbtn.Anchor = (AnchorStyles.Right | AnchorStyles.Top);
        }

        private void materialSingleLineTextField1_Click(object sender, EventArgs e)
        {

        }
    }
    }

