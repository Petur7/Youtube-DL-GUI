using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.IO;
using Shortcut;
using System.Threading;
using System.Diagnostics;

namespace Youtube_DL_GUI
{
    public partial class Youtube_DL_GUI : Form
    {
        private void updateSettingProgress(int updateValue)
        { 
            this.progressSettingsInstallation.Value += updateValue;
        }

        private void reset()
        {
            this.textStatus.Text = "";
            this.progressSettingsInstallation.Value = 0;
            this.updateSettingProgress(10);
        }

        private bool checkFilesExist()
        {
            List<string> checkFiles = new List<string>() { "Youtube-DL GUI.exe", "youtube-dl.exe", "ffmpeg.exe", "Youtube-dlExec.exe" };

            string currentDir = Directory.GetCurrentDirectory();
            DirectoryInfo currentDirInfo = new DirectoryInfo(currentDir);
            FileInfo[] currentDirFilesInfo = currentDirInfo.GetFiles();

            foreach (FileInfo file in currentDirFilesInfo)
            {
                int checkFilesIndex = checkFiles.FindIndex(checkFile => checkFile == file.Name);
                if (checkFilesIndex != -1)
                {
                    checkFiles.RemoveAt(checkFilesIndex);
                }
            }

            if (checkFiles.Count != 0)
            {
                this.textStatus.Text = $"Error: Can not find {checkFiles[0]}.";
                return false;
            }

            this.updateSettingProgress(10);
            return true;
        }

        private void DeleteDirectory(string target_dir)
        {
            string[] files = Directory.GetFiles(target_dir);
            string[] dirs = Directory.GetDirectories(target_dir);

            foreach (string file in files)
            {
                File.SetAttributes(file, FileAttributes.Normal);
                File.Delete(file);
            }

            foreach (string dir in dirs)
            {
                DeleteDirectory(dir);
            }

            Directory.Delete(target_dir, false);
        }

        private bool deleteLastProgram()
        {
            this.appConfig.appDir = this.textSettingsInstallationAppDir.Text;
            this.appConfig.binDir = Path.Combine(this.appConfig.appDir, "bin");
            this.appConfig.coreDir = Path.Combine(this.appConfig.appDir, "core");
            this.appConfig.tempDir = this.textSettingsInstallationTempDir.Text;

            try
            {
                if (Directory.Exists(this.appConfig.appDir)) DeleteDirectory(this.appConfig.appDir);
                if (Directory.Exists(this.appConfig.tempDir)) DeleteDirectory(this.appConfig.tempDir);
                if (Directory.Exists(this.appConfig.shortcutLocation)) DeleteDirectory(this.appConfig.shortcutLocation);
            }
            catch
            {
                this.textStatus.Text = "Error: Require administrator permisstion.";
                return false;
            }

            this.updateSettingProgress(10);
            return true;
        }

        private bool createProgram()
        {
            string currentDir = Directory.GetCurrentDirectory();

            try
            {
                Directory.CreateDirectory(this.appConfig.appDir);
                Directory.CreateDirectory(this.appConfig.binDir);
                Directory.CreateDirectory(this.appConfig.coreDir);
                Directory.CreateDirectory(this.appConfig.tempDir);
            }
            catch
            {
                this.textStatus.Text = "Error: Require administrator permisstion.";
                return false;
            }

            File.Copy(Path.Combine(currentDir, "Youtube-DL GUI.exe"), Path.Combine(this.appConfig.binDir, "Youtube-DL GUI.exe"));
            File.Copy(Path.Combine(currentDir, "Youtube-dlExec.exe"), Path.Combine(this.appConfig.binDir, "Youtube-dlExec.exe"));
            File.Copy(Path.Combine(currentDir, "youtube-dl.exe"), Path.Combine(this.appConfig.coreDir, "youtube-dl.exe"));
            File.Copy(Path.Combine(currentDir, "ffmpeg.exe"), Path.Combine(this.appConfig.coreDir, "ffmpeg.exe"));

            DirectoryInfo currentDirInfo = new DirectoryInfo(currentDir);
            FileInfo[] packagesInfo = currentDirInfo.GetFiles("*.dll");
            foreach (FileInfo package in packagesInfo)
            {
                File.Copy(Path.Combine(currentDir, package.Name), Path.Combine(this.appConfig.binDir, package.Name));
            }

            this.updateSettingProgress(20);
            return true;
        }

        private void createEnvironmentPath()
        {
            string EnvironmentPath = Environment.GetEnvironmentVariable("Path", EnvironmentVariableTarget.User);
            if (!EnvironmentPath.Contains(this.appConfig.coreDir))
            {
                EnvironmentPath = $"{EnvironmentPath};{this.appConfig.coreDir};";
            }
            if (!EnvironmentPath.Contains(this.appConfig.binDir))
            {
                EnvironmentPath = $"{EnvironmentPath};{this.appConfig.binDir};";
            }
            Environment.SetEnvironmentVariable("Path", EnvironmentPath, EnvironmentVariableTarget.User);
            this.updateSettingProgress(10);
        }

        private string processThread(string file, string arguments)
        {
            string returnValue = "";

            Thread thread = new Thread(() =>
            {
                Process process = new Process();
                process.StartInfo.RedirectStandardOutput = true;
                process.StartInfo.UseShellExecute = false;
                process.StartInfo.CreateNoWindow = true;
                process.StartInfo.StandardOutputEncoding = Encoding.UTF8;

                process.StartInfo.FileName = file;
                process.StartInfo.Arguments = arguments;

                process.Start();
                process.WaitForExit();
                if (process.ExitCode == 0) { returnValue = process.StandardOutput.ReadToEnd(); }
            });
            thread.Start();
            thread.Join();

            return returnValue;
        }

        private void checkCores()
        {
            string youtubedlVersion = processThread("youtube-dl", "--version");
            youtubedlVersion = youtubedlVersion.Replace("\\r\\n", "");
            this.textSettingsCoreYTDLVersion.Text = youtubedlVersion;

            string ffmpegVersion = processThread("ffmpeg", "-version");
            ffmpegVersion = ffmpegVersion.Split(' ')[2].Split('-')[0];
            this.textSettingsCoreFFMPEGVersion.Text = ffmpegVersion;

            this.updateSettingProgress(20);
        }

        private void createAppConfig()
        {
            ApplicationConfig appConfig = new ApplicationConfig();
            appConfig.appDir = this.appConfig.appDir;
            appConfig.binDir = this.appConfig.binDir;
            appConfig.coreDir = this.appConfig.coreDir;
            appConfig.tempDir = this.appConfig.tempDir;
            appConfig.shortcutLocation = this.appConfig.shortcutLocation;
            appConfig.youtubedlVersion = this.textSettingsCoreYTDLVersion.Text.Replace("\\r\\n", "\0");
            appConfig.ffmpegVersion = this.textSettingsCoreFFMPEGVersion.Text;

            string appConfigContent = this.ApplicationConfigSerialize(appConfig);
            string appConfigDir = Path.Combine(appConfig.binDir, "appConfig.json");
            File.WriteAllText(appConfigDir, appConfigContent);

            this.updateSettingProgress(10);
        }

        private void createShortcut()
        {
            if (this.checkSettingsInstallationDesktopIcon.Checked)
            {
                string sourceLocation = Path.Combine(this.appConfig.binDir, "Youtube-DL GUI.exe");
                Shortcut.Shortcut.createShortcut(sourceLocation, this.appConfig.shortcutLocation);
            }

            this.updateSettingProgress(10);
        }



        private void Install()
        {
            this.reset();
            if (!this.checkFilesExist()) return;
            if (!this.deleteLastProgram()) return;
            if (!this.createProgram()) return;
            this.createEnvironmentPath();
            this.checkCores();
            this.createAppConfig();
            this.createShortcut();
            this.textStatus.Text = "Success: Installation completed. You can delete all files now.";
        }
    }
}
