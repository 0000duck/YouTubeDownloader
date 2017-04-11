using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VideoLibrary;

namespace YoutubeDownloader
{
    public class YouTubeFileManager
    {
        private string CONVERTER_PATH = Path.Combine(new DirectoryInfo(Directory.GetCurrentDirectory()).FullName, "lib\\ffmpeg.exe");

        public YouTubeFileManager(string musicFolderPath)
        {
            this.MusicFolderPath = musicFolderPath;
        }

        public string MusicFolderPath { get; set; }

        public YouTubeVideo GetVideo(DownloadFile file)
        {
            var youTube = YouTube.Default; // starting point for YouTube actions
            var video = youTube.GetVideo(file.YouTubeLink);

            return video;
        }

        public void WriteFileInFolder(DownloadFile file)
        {
            File.WriteAllBytes(Path.Combine(file.FolderPath, file.YouTubeVideo.FullName), file.YouTubeVideo.GetBytes());
        }

        private Process GetProc(DownloadFile file)
        {
            return new Process
            {
                StartInfo = new ProcessStartInfo
                {
                    WorkingDirectory = file.FolderPath,
                    UseShellExecute = false,
                    RedirectStandardOutput = true,
                    WindowStyle = ProcessWindowStyle.Hidden,
                    FileName = CONVERTER_PATH,
                    CreateNoWindow = true
                }
            };
        }

        public string Execute(DownloadFile file)
        {
            string inputFile = file.YouTubeVideo.FullName;
            string inputFileNoExtention = Path.GetFileNameWithoutExtension(inputFile);
            string fileExtention = Path.GetExtension(inputFile);
            var action = this.GetProc(file);
            action.StartInfo.Arguments = this.GetArguments(fileExtention, inputFile, inputFileNoExtention);
            action.Start();
            action.WaitForExit();
            File.Delete(Path.Combine(file.FolderPath,  inputFile));
            return action.StandardOutput.ReadToEnd();
        }

        private string GetArguments(string fileExtention, string inputFile, string inputFileWithNoExtention)
        {
            return "-i \"" + inputFile + "\" -acodec libmp3lame -aq 4 \"" + inputFileWithNoExtention + "\".mp3";
            //switch (fileExtention)
            //{
            //    case ".webm":
            //    case ".mp4":

            //    default:
            //        return " -i \"" + inputFile + "\" - vn -f mp3 -ab 192k \"" + inputFileWithNoExtention + "\".mp3";
            //}
        }
    }
}
