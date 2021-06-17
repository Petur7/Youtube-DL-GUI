using System;
using System.Windows.Forms;
using System.IO;
using System.Text;
using System.Diagnostics;
using Newtonsoft.Json.Linq;
using System.Collections.Generic;
using System.Net;
using System.Drawing;
using System.Drawing.Imaging;


namespace Youtube_DL_GUI
{
    public partial class Youtube_DL_GUI : Form
    {
        public void SaveImage(string imageUrl, string filename, ImageFormat format)
        {
            WebClient client = new WebClient();
            Stream stream = client.OpenRead(imageUrl);
            Bitmap bitmap; bitmap = new Bitmap(stream);

            if (bitmap != null)
            {
                bitmap.Save(filename, format);
            }

            stream.Flush();
            stream.Close();
            client.Dispose();
        }

        private void GetVideoInfo()
        {
            this.textStatus.Text = "Status: Get video information.";
            this.progressSDDownload.Value = 0;
            this.videoID = "";

            string videoURL = this.textSDLink.Text;
            string currentDir = Directory.GetCurrentDirectory();
            string tempFileLocation = Path.Combine(currentDir, "temp.txt");

            Process process = new Process();
            process.StartInfo.RedirectStandardOutput = true;
            process.StartInfo.UseShellExecute = false;
            process.StartInfo.CreateNoWindow = true;
            process.StartInfo.StandardOutputEncoding = Encoding.UTF8;

            process.StartInfo.FileName = "Youtube-dlExec";
            process.StartInfo.Arguments = $"\"{videoURL}\" \"{tempFileLocation}\" --get-id --encoding UTF8";
            process.Start();
            process.WaitForExit();
            this.progressSDDownload.Value += 30;

            string videoID = File.ReadAllText(tempFileLocation);
            File.Delete(tempFileLocation);
            int videoIDIndex = 0;
            while (videoIDIndex < videoID.Length - 1)
            {
                if (!Char.IsLetterOrDigit(videoID[videoIDIndex])) videoID = videoID.Remove(videoIDIndex);
                else videoIDIndex++;
            }

            string[] currentDirList = currentDir.Split('\\');
            currentDirList[currentDirList.Length - 1] = "temp";
            this.appConfig.tempDir = Path.Combine(currentDirList);

            string tempFileName = $"{videoID}.txt";
            tempFileLocation = Path.Combine(currentDir, tempFileName);

            process.StartInfo.Arguments = $"\"{videoURL}\" \"{tempFileLocation}\" -J --encoding utf8";
            process.Start();
            process.WaitForExit();
            this.progressSDDownload.Value += 50;

            string videoInfoContent = File.ReadAllText(tempFileLocation);
            JObject videoInfo = JObject.Parse(videoInfoContent);
            File.Delete(tempFileLocation);

            this.textSDVideoTitle.Text = (string)videoInfo.SelectToken("title");
            this.textSDVideoAuthor.Text = (string)videoInfo.SelectToken("channel");
            string thumbnailURL = (string)videoInfo.SelectToken("thumbnail");
            this.pictureSDPicture.Image = null;
            try { this.pictureSDPicture.Load(thumbnailURL); }
            catch 
            {
                try
                {
                    using (WebClient client = new WebClient())
                    {
                        client.DownloadFile(new Uri(thumbnailURL), Path.Combine(currentDir, $"{videoID}.webp"));
                    }
                    using (var image = Aspose.Imaging.Image.Load(Path.Combine(currentDir, $"{videoID}.webp")))
                    {
                        image.Save(Path.Combine(currentDir, $"{videoID}.png"), new Aspose.Imaging.ImageOptions.PngOptions());
                    }
                    this.pictureSDPicture.Image = Image.FromFile(Path.Combine(currentDir, $"{videoID}.png"));

                    File.Delete(Path.Combine(currentDir, $"{videoID}.webp"));
                }
                catch { this.textStatus.Text = "Warning: Can not load video thumbnail."; }
            }
            this.progressSDDownload.Value += 20;


            int duration = (int)videoInfo.SelectToken("duration");
            if (duration != 0)
            {
                this.videoID = videoID;
                this.videoInfoContent = videoInfoContent;
            }
            else
            {
                this.textStatus.Text = "Error: Can not download livestream.";
                return;
            }

            this.textSDOutputDir.Text = Environment.GetFolderPath(Environment.SpecialFolder.MyVideos);
            if (this.radioSDFormatMP4.Checked) updateOption(videoID, "mp4", videoInfoContent);
            if (this.radioSDFormatWEBM.Checked) updateOption(videoID, "webm", videoInfoContent);
            return;
        }

        static readonly string[] SizeSuffixes =
                   { "bytes", "KB", "MB", "GB", "TB", "PB", "EB", "ZB", "YB" };
        static string SizeSuffix(Int64 value, int decimalPlaces = 1)
        {
            if (decimalPlaces < 0) { throw new ArgumentOutOfRangeException("decimalPlaces"); }
            if (value < 0) { return "-" + SizeSuffix(-value, decimalPlaces); }
            if (value == 0) { return string.Format("{0:n" + decimalPlaces + "} bytes", 0); }

            // mag is 0 for bytes, 1 for KB, 2, for MB, etc.
            int mag = (int)Math.Log(value, 1024);

            // 1L << (mag * 10) == 2 ^ (10 * mag) 
            // [i.e. the number of bytes in the unit corresponding to mag]
            decimal adjustedSize = (decimal)value / (1L << (mag * 10));

            // make adjustment when the value is large enough that
            // it would round up to 1000 or more
            if (Math.Round(adjustedSize, decimalPlaces) >= 1000)
            {
                mag += 1;
                adjustedSize /= 1024;
            }

            return string.Format("{0:n" + decimalPlaces + "} {1}",
                adjustedSize,
                SizeSuffixes[mag]);
        }


        private void updateOption(string videoID, string extension, string videoInfoContent)
        {
            if (videoID == "" || videoInfoContent == "") return;
            JObject videoInfo = JObject.Parse(videoInfoContent);

            this.textSDOutputDir.Text = Environment.GetFolderPath(Environment.SpecialFolder.MyVideos);

            var formats = videoInfo.SelectToken("formats");

            Dictionary<string, string> videoOption = new Dictionary<string, string>();
            videoOption.Add("No video", "No video");
            foreach (JObject format in formats)
            {
                string fps = (string)format.SelectToken("fps");
                string ext = (string)format.SelectToken("ext");
                string asr = (string)format.SelectToken("asr");
                if (fps != null && ext == extension && asr == null)
                {
                    string videoSize = (string)format.SelectToken("filesize");
                    string videoFormat = (string)format.SelectToken("format");
                    videoFormat = videoFormat.Split('-')[1] + " " + SizeSuffix(Int64.Parse(videoSize));
                    videoOption.Add(videoFormat, (string)format.SelectToken("format_id"));
                }
                else continue;
            }
            this.comboSDVideoResolution.DataSource = new BindingSource(videoOption, null);
            this.comboSDVideoResolution.DisplayMember = "Key";
            this.comboSDVideoResolution.ValueMember = "Value";

            Dictionary<string, string> audioOption = new Dictionary<string, string>();
            audioOption.Add("No audio", "No audio");
            string audioExt = "";
            if (extension == "mp4") audioExt = "m4a";
            else audioExt = "webm";
            foreach (JObject format in formats)
            {
                string fps = (string)format.SelectToken("fps");
                string ext = (string)format.SelectToken("ext");
                if (fps == null && ext == audioExt)
                {
                    string asr = (string)format.SelectToken("asr");
                    string tbr = (string)format.SelectToken("tbr");
                    string audioSize = (string)format.SelectToken("filesize");
                    string audioID = (string)format.SelectToken("format_id");

                    audioOption.Add($"{asr}Hz @{tbr}k {SizeSuffix(Int64.Parse(audioSize))}", audioID);
                }
                else continue;
            }
            this.comboSDAudioQuality.DataSource = new BindingSource(audioOption, null);
            this.comboSDAudioQuality.DisplayMember = "Key";
            this.comboSDAudioQuality.ValueMember = "Value";

            this.textSDOutputDir.Text = Environment.GetFolderPath(Environment.SpecialFolder.MyVideos);
        }
    }
}
