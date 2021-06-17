using System;
using System.Windows.Forms;

namespace Youtube_DL_GUI
{
    public partial class Youtube_DL_GUI : Form
    {
        public Youtube_DL_GUI()
        {
            InitializeComponent();
            afterStartup();
        }

        private void buttonSettingsInstallationInstall_Click(object sender, EventArgs e)
        {
            Install();
        }

        private void buttonSDGetLink_Click(object sender, EventArgs e)
        {
            GetVideoInfo();
        }

        private void radioSDFormatMP4_CheckedChanged(object sender, EventArgs e)
        {
            this.ext = "mp4";
            this.updateOption(this.videoID, "mp4", this.videoInfoContent);
        }

        private void radioSDFormatWEBM_CheckedChanged(object sender, EventArgs e)
        {
            this.ext = "webm";
            this.updateOption(this.videoID, "webm", this.videoInfoContent);
        }

        private void buttonSDProgressDownload_Click(object sender, EventArgs e)
        {
            this.download();
        }

        private void comboSDAudioQuality_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.changeAudio();
        }

        private void comboSDVideoResolution_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.changeVideo();
        }
    }
}
