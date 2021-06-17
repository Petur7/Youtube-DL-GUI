using System.Windows.Forms;
using System.IO;
using System;
using System.Threading;
using Newtonsoft.Json.Linq;

namespace Youtube_DL_GUI
{
    public partial class Youtube_DL_GUI : Form
    {
        private void updateCoreVersion()
        {
            string youtubedlVersion = processThread("youtube-dl", "--version");
            youtubedlVersion = youtubedlVersion.Replace("\\r\\n", "");
            this.textSettingsCoreYTDLVersion.Text = youtubedlVersion;

            string ffmpegVersion = processThread("ffmpeg", "-version");
            ffmpegVersion = ffmpegVersion.Split(' ')[2].Split('-')[0];
            this.textSettingsCoreFFMPEGVersion.Text = ffmpegVersion;
        }

        private void threadUpdateCoreVersion()
        {
            Thread thread = new Thread(() => {
                this.updateCoreVersion();
            });
            thread.Start();
            thread.Join();
        }

        private void afterStartup()
        {
            string currentDir = Directory.GetCurrentDirectory();
            DirectoryInfo currentDirInfo = new DirectoryInfo(currentDir);
            FileInfo[] currentFilesInfo = currentDirInfo.GetFiles();
            int appConfigFileIndex = Array.FindIndex(currentFilesInfo, fileInfo => fileInfo.Name == "appConfig.json");

            if (appConfigFileIndex == -1)
            {
                MessageBox.Show("Go to Settings and press Install to install application.");
                this.textStatus.Text = "Go to Settings and press Install to install application.";
                return;
            }

            string appConfigLocation = Path.Combine(currentDir, "appConfig.json");
            string appConfigContent = File.ReadAllText(appConfigLocation);
            JObject appConfig = JObject.Parse(appConfigContent);

            this.textSettingsCoreYTDLVersion.Text = (string)appConfig.SelectToken("yotubedlVersion");
            this.textSettingsCoreFFMPEGVersion.Text = (string)appConfig.SelectToken("ffmpegVersion");
            this.textSettingsInstallationAppDir.Text = (string)appConfig.SelectToken("appDir");
            this.textSettingsInstallationTempDir.Text = (string)appConfig.SelectToken("tempDir");
        }
    }
}
