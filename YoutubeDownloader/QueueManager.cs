using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YoutubeDownloader
{
    public class QueueManager
    {
        private List<BackgroundWorker> workers;
        private List<DownloadFile> queue;

        public QueueManager()
        {
            this.workers = new List<BackgroundWorker>();
            this.queue = new List<DownloadFile>();
        }

        public void AddWorker(BackgroundWorker worker)
        {
            worker.WorkerReportsProgress = true;
            worker.WorkerSupportsCancellation = true;
            this.workers.Add(worker);
        }

        public void AddFile(DownloadFile file)
        {
            if (this.AreAvailableWorkers())
            {
                var worker = this.GetAvailableWorker();
                worker.RunWorkerAsync(file);
            } 
            else
            {
                this.queue.Add(file);
            }
        }

        public void Next()
        {
            if (this.queue.Any())
            {
                var nextFile = this.queue.First();
                this.AddFile(nextFile);
                this.queue.Remove(nextFile);
            }
        }

        private bool AreAvailableWorkers()
        {
            return this.workers.Any(x => !x.IsBusy);
        }

        private BackgroundWorker GetAvailableWorker()
        {
            return this.workers.Where(x => !x.IsBusy).First();
        }
    }
}
