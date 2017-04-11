using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VideoLibrary;

namespace YoutubeDownloader
{
    public class DownloadFile
    {
        public string YouTubeLink { get; set; }

        public Video YouTubeVideo { get; set; }

        public string FolderPath { get; set; }
    }
}
