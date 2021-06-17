using System;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;
using System.Text;
using System.Threading;

namespace Youtube_DL_GUI
{
    public partial class Youtube_DL_GUI : Form
    {
        private void downloadAudio(string audioQualityID)
        {
            Process process = new Process();
            process.StartInfo.FileName = "youtube-dl";
            process.StartInfo.Arguments = $"-f {audioQualityID} --encoding UTF8 -o {this.textSDOutputDir.Text} {this.textSDLink.Text}";
            process.StartInfo.RedirectStandardOutput = true;
            process.StartInfo.UseShellExecute = false;
            process.StartInfo.CreateNoWindow = true;
            process.StartInfo.StandardOutputEncoding = Encoding.UTF8;
            process.Start();
            int processID = process.Id;

            while (!process.HasExited)
            {
                string output = process.StandardOutput.ReadLine();
                Thread thread = new Thread(() =>
                {
                    try
                    {
                        if (output.Contains("[download]"))
                        {
                            this.textStatus.Text = output;
                            string[] outputArray = output.Split(' ');
                            foreach (string eachOutput in outputArray)
                            {
                                if (eachOutput.Contains("%"))
                                {
                                    string percent = eachOutput.Remove(eachOutput.Length - 1);
                                    int percentInt = Convert.ToInt32(Convert.ToDouble(percent));
                                    this.progressSDDownload.Value = percentInt;
                                }
                            }
                        }

                    }
                    catch { }
                });
                thread.Start(); thread.Join();
            }
        }

        private void downloadVideo(string videoResolutionID)
        {
            Process process = new Process();
            process.StartInfo.FileName = "youtube-dl";
            process.StartInfo.Arguments = $"-f {videoResolutionID} --encoding UTF8 -o {this.textSDOutputDir.Text} {this.textSDLink.Text}";
            process.StartInfo.RedirectStandardOutput = true;
            process.StartInfo.UseShellExecute = false;
            process.StartInfo.CreateNoWindow = true;
            process.StartInfo.StandardOutputEncoding = Encoding.UTF8;
            process.Start();
            int processID = process.Id;

            while (!process.HasExited)
            {
                string output = process.StandardOutput.ReadLine();
                Thread thread = new Thread(() =>
                {
                    try
                    {
                        if (output.Contains("[download]"))
                        {
                            this.textStatus.Text = output;
                            string[] outputArray = output.Split(' ');
                            foreach (string eachOutput in outputArray)
                            {
                                if (eachOutput.Contains("%"))
                                {
                                    string percent = eachOutput.Remove(eachOutput.Length - 1);
                                    int percentInt = Convert.ToInt32(Convert.ToDouble(percent));
                                    this.progressSDDownload.Value = percentInt;
                                    if (percentInt == 100) { this.textStatus.Text = "Merging video..."; }
                                }
                            }
                        }

                    }
                    catch { }
                });
                thread.Start(); thread.Join();
            }
        }

        private void downloadAndMerge(string videoResolutionID, string audioQualityID)
        {
            Process process = new Process();
            process.StartInfo.FileName = "youtube-dl";
            process.StartInfo.Arguments = $"-f {videoResolutionID}+{audioQualityID} --merge-output-format {this.ext} --encoding UTF8 -o {this.textSDOutputDir.Text} {this.textSDLink.Text}";
            process.StartInfo.RedirectStandardOutput = true;
            process.StartInfo.UseShellExecute = false;
            process.StartInfo.CreateNoWindow = true;
            process.StartInfo.StandardOutputEncoding = Encoding.UTF8;
            process.Start();
            int processID = process.Id;

            while (!process.HasExited)
            {
                string output = process.StandardOutput.ReadLine();
                Thread thread = new Thread(() =>
                {
                    try
                    {
                        if (output.Contains("[download]"))
                        {
                            this.textStatus.Text = output;
                            string[] outputArray = output.Split(' ');
                            foreach (string eachOutput in outputArray)
                            {
                                if (eachOutput.Contains("%"))
                                {
                                    string percent = eachOutput.Remove(eachOutput.Length - 1);
                                    int percentInt = Convert.ToInt32(Convert.ToDouble(percent));
                                    this.progressSDDownload.Value = percentInt;
                                }
                            }
                        }

                    }
                    catch { }
                });
                thread.Start(); thread.Join();
            }
        }

        private void changeVideo()
        {
            if (this.comboSDVideoResolution.SelectedValue.ToString() == "No video" && this.comboSDAudioQuality.SelectedValue.ToString() == "No audio") return;
            this.textSDOutputDir.Text = Environment.GetFolderPath(Environment.SpecialFolder.MyVideos);

            if (this.ext == "mp4" || this.ext == "m4a")
            {
                this.textSDOutputDir.Text = Path.Combine(this.textSDOutputDir.Text, $"{videoID}.mp4");
            }

            if (this.ext == "webm")
            {
                this.textSDOutputDir.Text = Path.Combine(this.textSDOutputDir.Text, $"{videoID}.webm");
            }
        }

        private void changeAudio()
        {
            if (this.comboSDVideoResolution.SelectedValue.ToString() == "No video" && this.comboSDAudioQuality.SelectedValue.ToString() == "No audio") return;
            this.textSDOutputDir.Text = Environment.GetFolderPath(Environment.SpecialFolder.MyVideos);

            if ((this.ext == "mp4" || this.ext == "m4a") && this.comboSDVideoResolution.SelectedValue.ToString() == "No video")
            {
                this.textSDOutputDir.Text = Path.Combine(this.textSDOutputDir.Text, $"{videoID}.m4a");
                return;
            }
            if (this.ext == "mp4" || this.ext == "m4a")
            {
                this.textSDOutputDir.Text = Path.Combine(this.textSDOutputDir.Text, $"{videoID}.mp4");
                return;
            }

            if (this.ext == "webm")
            {
                this.textSDOutputDir.Text = Path.Combine(this.textSDOutputDir.Text, $"{videoID}.webm");
            }
        }

        private void download()
        {
            string ext = null;
            if (this.radioSDFormatMP4.Checked) ext = "mp4";
            if (this.radioSDFormatWEBM.Checked) ext = "webm";
            if (ext == null) { this.textStatus.Text = "Warning: Please select output format."; return; }

            string videoResolutionID = this.comboSDVideoResolution.SelectedValue.ToString();
            string audioQualityID = this.comboSDAudioQuality.SelectedValue.ToString();
            if (videoResolutionID == "No video" && audioQualityID == "No audio")
            {
                this.textStatus.Text = "Warning: Please select video resolution or audio quality to download";
                return;
            }

            if (videoResolutionID != "No video" && audioQualityID != "No audio") downloadAndMerge(videoResolutionID, audioQualityID);
            if (videoResolutionID == "No video") downloadAudio(audioQualityID);
            if (audioQualityID == "No audio") downloadVideo(videoResolutionID);
        }
    }
}
