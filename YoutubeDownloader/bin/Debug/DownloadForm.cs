using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VideoLibrary;
using static System.Windows.Forms.ListViewItem;

namespace YoutubeDownloader
{
    public partial class DownloadForm : Form
    {
        private string DEFAULT_MUSIC_URL = @"C:\Music\";
        
        private QueueManager queueManager;
        private YouTubeFileManager youTubeManager;

        private List<DownloadFile> youTubeLinkQueue = new List<DownloadFile>();
        private List<string> errors = new List<string>(); 

        public DownloadForm()
        {
            InitializeComponent();
            this.queueManager = new QueueManager();
            this.queueManager.AddWorker(this.QueueProcessing_1);
            this.queueManager.AddWorker(this.QueueProcessing_2);
            this.queueManager.AddWorker(this.QueueProcessing_3);
            this.queueManager.AddWorker(this.QueueProcessing_4);
            
            this.txtDownloadUrl.Text = @"C:\Users\hernan\Desktop\musica.txt";
            this.textBox1.Text = DEFAULT_MUSIC_URL;
        }

        private void AddToQueue_Click(object sender, EventArgs e)
        {
            this.youTubeManager = new YouTubeFileManager(this.textBox1.Text);
            string fullPath = Path.GetFullPath(this.txtDownloadUrl.Text);
            this.ReadFromFile(fullPath);
        }

        private void ReadFromFile(string path)
        {
            string line;
            string folderPath = this.textBox1.Text;
            // Read the file and display it line by line.
            System.IO.StreamReader file =
               new System.IO.StreamReader(path);
            while ((line = file.ReadLine()) != null)
            {
                if (line.StartsWith("##"))
                {
                    //NADA
                }
                else if (line.Contains("https://www.youtube.com"))
                {
                    DownloadFile newFile = new DownloadFile();

                    newFile.YouTubeLink = line;
                    newFile.FolderPath = folderPath;

                    this.queueManager.AddFile(newFile);
                } 
                else if (line.StartsWith("#"))
                {
                    folderPath = Path.Combine(this.textBox1.Text, line.Substring(1));
                    Directory.CreateDirectory(folderPath);
                }
            }

            file.Close();
        }

        //async void SaveVideoToDisk(string link)
        //{
        //    var youTube = YouTube.Default; // starting point for YouTube actions
        //    await youTube.GetVideoAsync(link)
        //        .ContinueWith(x => this.WriteFileInFolder(x.Result))
        //        .ContinueWith(x => this.Execute(x.Result)); // gets a Video object with info about the video
        //}

        private void AddLog(YouTubeResult result)
        {
            ListViewItem item = new ListViewItem();

            if (result.HasError)
            {
                item.Text = result.ProcessedFile.YouTubeVideo != null ? result.ProcessedFile.YouTubeVideo.FullName : item.Text = result.ProcessedFile.YouTubeLink;
                item.BackColor = Color.Red;
                item.ForeColor = Color.White;
                this.errors.Add(result.Error);
                this.lblError1.Text = result.Error;
                this.lblError1.Visible = true;
            } 
            else
            {
                item.Text = result.ProcessedFile.YouTubeVideo.FullName;
                item.BackColor = Color.Green;
                item.ForeColor = Color.White;
            }

            this.lvLog.Items.Add(item);
         }

        #region workers

        private void QueueProcessing_1_DoWork(object sender, DoWorkEventArgs e)
        {
            DownloadFile newFile = e.Argument as DownloadFile;
            var worker = (BackgroundWorker)sender;

            YouTubeResult result = new YouTubeResult();

            try
            {
                worker.ReportProgress(0);

                newFile.YouTubeVideo = this.youTubeManager.GetVideo(newFile);
                
                worker.ReportProgress(30);

                this.youTubeManager.WriteFileInFolder(newFile);
                worker.ReportProgress(70);

                this.youTubeManager.Execute(newFile); // gets a Video object with info about the video
                worker.ReportProgress(100);
                
                result.ProcessedFile = newFile;
            }
            catch (Exception ex)
            {
                result.ProcessedFile = newFile;
                result.Error = ex.Message;
                result.HasError = true;
            }

            e.Result = result;
        }

        private void QueueProcessing_2_DoWork(object sender, DoWorkEventArgs e)
        {
            DownloadFile newFile = e.Argument as DownloadFile;
            var worker = (BackgroundWorker)sender;
            YouTubeResult result = new YouTubeResult();

            try
            {

                worker.ReportProgress(0);

                newFile.YouTubeVideo = this.youTubeManager.GetVideo(newFile);
                worker.ReportProgress(30);

                this.youTubeManager.WriteFileInFolder(newFile);
                worker.ReportProgress(70);

                this.youTubeManager.Execute(newFile); // gets a Video object with info about the video
                worker.ReportProgress(100);
                
                result.ProcessedFile = newFile;
            }
            catch (Exception ex)
            {
                result.ProcessedFile = newFile;
                result.Error = ex.Message;
                result.HasError = true;
            }

            e.Result = result;
        }

        private void QueueProcessing_3_DoWork(object sender, DoWorkEventArgs e)
        {
            DownloadFile newFile = e.Argument as DownloadFile;
            var worker = (BackgroundWorker)sender;
            YouTubeResult result = new YouTubeResult();

            try
            {

                worker.ReportProgress(0);

                newFile.YouTubeVideo = this.youTubeManager.GetVideo(newFile);
                worker.ReportProgress(30);

                this.youTubeManager.WriteFileInFolder(newFile);
                worker.ReportProgress(70);

                this.youTubeManager.Execute(newFile); // gets a Video object with info about the video
                worker.ReportProgress(100);
                
                result.ProcessedFile = newFile;
            }
            catch (Exception ex)
            {
                result.Error = ex.Message;
                result.HasError = true;
                result.ProcessedFile = newFile;
            }

            e.Result = result;
        }

        private void QueueProcessing_4_DoWork(object sender, DoWorkEventArgs e)
        {
            DownloadFile newFile = e.Argument as DownloadFile;
            var worker = (BackgroundWorker)sender;
            YouTubeResult result = new YouTubeResult();

            try
            {
                worker.ReportProgress(0);

                newFile.YouTubeVideo = this.youTubeManager.GetVideo(newFile);
                worker.ReportProgress(30);

                this.youTubeManager.WriteFileInFolder(newFile);
                worker.ReportProgress(70);

                this.youTubeManager.Execute(newFile); // gets a Video object with info about the video
                worker.ReportProgress(100);
                
                result.ProcessedFile = newFile;
            }
            catch (Exception ex)
            {
                result.Error = ex.Message;
                result.ProcessedFile = newFile;
                result.HasError = true;
            }

            e.Result = result;
        }

        private void QueueProcessing_1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            var result = e.Result as YouTubeResult;

            if (result.HasError)
            {
                this.lblError1.Text = result.Error;
                this.lblError1.Visible = true;
                System.Threading.Thread.Sleep(1000);
                this.lblError1.Visible = false;
            }

            this.AddLog(result);

            this.queueManager.Next();
        }

        private void QueueProcessing_2_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            var result = e.Result as YouTubeResult;

            if (result.HasError)
            {
                this.lblError2.Text = result.Error;
                this.lblError2.Visible = true;
                System.Threading.Thread.Sleep(1000);
                this.lblError2.Visible = false;
            }

            this.AddLog(result);

            this.queueManager.Next();
        }        

        private void QueueProcessing_3_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            var result = e.Result as YouTubeResult;

            if (result.HasError)
            {
                this.lblError3.Text = result.Error;
                this.lblError3.Visible = true;
                System.Threading.Thread.Sleep(1000);
                this.lblError3.Visible = false;
            }

            this.AddLog(result);

            this.queueManager.Next();
        }
        
        private void QueueProcessing_4_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            var result = e.Result as YouTubeResult;

            if (result.HasError)
            {
                this.lblError4.Text = result.Error;
                this.lblError4.Visible = true;
                System.Threading.Thread.Sleep(1000);
                this.lblError4.Visible = false;
            }

            this.AddLog(result);

            this.queueManager.Next();
        }

        private void QueueProcessing_1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            this.pbProgress1.Value = e.ProgressPercentage;
            this.lblFileName1.Text = "Progress : " + e.ProgressPercentage + "%";
        }

        private void QueueProcessing_2_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            this.pbProgressBar2.Value = e.ProgressPercentage;
            this.lblFileName2.Text = "Progress : " + e.ProgressPercentage + "%";
        }

        private void QueueProcessing_3_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            this.pbProgressBar3.Value = e.ProgressPercentage;
            this.lblFileName3.Text = "Progress : " + e.ProgressPercentage + "%";
        }

        private void QueueProcessing_4_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            this.pbProgressBar4.Value = e.ProgressPercentage;
            this.lblFileName4.Text = "Progress : " + e.ProgressPercentage + "%";
        }

        #endregion
    }
}
