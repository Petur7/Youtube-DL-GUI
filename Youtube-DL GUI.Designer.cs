using System.IO;
using System;

namespace Youtube_DL_GUI
{
    partial class Youtube_DL_GUI
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabLists = new System.Windows.Forms.TabControl();
            this.tabSingleDownload = new System.Windows.Forms.TabPage();
            this.buttonSDProgressDownload = new System.Windows.Forms.Button();
            this.labelSDProgressDownload = new System.Windows.Forms.Label();
            this.progressSDDownload = new System.Windows.Forms.ProgressBar();
            this.buttonSDSelectDir = new System.Windows.Forms.Button();
            this.labelSDOuputDir = new System.Windows.Forms.Label();
            this.textSDOutputDir = new System.Windows.Forms.TextBox();
            this.groupSDVideoOption = new System.Windows.Forms.GroupBox();
            this.labelSDAudioQuality = new System.Windows.Forms.Label();
            this.comboSDAudioQuality = new System.Windows.Forms.ComboBox();
            this.labelSDVideoResolution = new System.Windows.Forms.Label();
            this.comboSDVideoResolution = new System.Windows.Forms.ComboBox();
            this.radioSDFormatWEBM = new System.Windows.Forms.RadioButton();
            this.radioSDFormatMP4 = new System.Windows.Forms.RadioButton();
            this.labelSDOutputFormat = new System.Windows.Forms.Label();
            this.groupSDVideoInformation = new System.Windows.Forms.GroupBox();
            this.labelSDVideoAuthor = new System.Windows.Forms.Label();
            this.textSDVideoAuthor = new System.Windows.Forms.TextBox();
            this.textSDVideoTitle = new System.Windows.Forms.TextBox();
            this.labelSDVideoTitle = new System.Windows.Forms.Label();
            this.pictureSDPicture = new System.Windows.Forms.PictureBox();
            this.buttonSDGetLink = new System.Windows.Forms.Button();
            this.labelSDLink = new System.Windows.Forms.Label();
            this.textSDLink = new System.Windows.Forms.TextBox();
            this.tabSettings = new System.Windows.Forms.TabPage();
            this.groupSettingsInstallation = new System.Windows.Forms.GroupBox();
            this.labelSettingsInstallationProgress = new System.Windows.Forms.Label();
            this.progressSettingsInstallation = new System.Windows.Forms.ProgressBar();
            this.buttonSettingsInstallationInstall = new System.Windows.Forms.Button();
            this.checkSettingsInstallationDiffTemp = new System.Windows.Forms.CheckBox();
            this.checkSettingsInstallationDesktopIcon = new System.Windows.Forms.CheckBox();
            this.buttonSettingsInstallationTempDir = new System.Windows.Forms.Button();
            this.labelSettingsInstallationTemp = new System.Windows.Forms.Label();
            this.textSettingsInstallationTempDir = new System.Windows.Forms.TextBox();
            this.buttonSettingsInstallationSelectAppDir = new System.Windows.Forms.Button();
            this.labelSettingsInstallationDir = new System.Windows.Forms.Label();
            this.textSettingsInstallationAppDir = new System.Windows.Forms.TextBox();
            this.groupSettingsCore = new System.Windows.Forms.GroupBox();
            this.buttonSettingsCoreUpdate = new System.Windows.Forms.Button();
            this.labelSettingsCoreFFMPEGVersion = new System.Windows.Forms.Label();
            this.labelSettingsCoreYTDLVersion = new System.Windows.Forms.Label();
            this.textSettingsCoreFFMPEGVersion = new System.Windows.Forms.TextBox();
            this.textSettingsCoreYTDLVersion = new System.Windows.Forms.TextBox();
            this.groupSettingsApplication = new System.Windows.Forms.GroupBox();
            this.buttonSettingsAppUpdate = new System.Windows.Forms.Button();
            this.labelSettingsAppAuthor = new System.Windows.Forms.Label();
            this.textSettingsAppAuthor = new System.Windows.Forms.TextBox();
            this.labelSettingsAppVersion = new System.Windows.Forms.Label();
            this.textSettingsAppVersion = new System.Windows.Forms.TextBox();
            this.textStatus = new System.Windows.Forms.TextBox();
            this.tabLists.SuspendLayout();
            this.tabSingleDownload.SuspendLayout();
            this.groupSDVideoOption.SuspendLayout();
            this.groupSDVideoInformation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureSDPicture)).BeginInit();
            this.tabSettings.SuspendLayout();
            this.groupSettingsInstallation.SuspendLayout();
            this.groupSettingsCore.SuspendLayout();
            this.groupSettingsApplication.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabLists
            // 
            this.tabLists.Controls.Add(this.tabSingleDownload);
            this.tabLists.Controls.Add(this.tabSettings);
            this.tabLists.Location = new System.Drawing.Point(1, 2);
            this.tabLists.Name = "tabLists";
            this.tabLists.SelectedIndex = 0;
            this.tabLists.Size = new System.Drawing.Size(799, 405);
            this.tabLists.TabIndex = 0;
            // 
            // tabSingleDownload
            // 
            this.tabSingleDownload.Controls.Add(this.buttonSDProgressDownload);
            this.tabSingleDownload.Controls.Add(this.labelSDProgressDownload);
            this.tabSingleDownload.Controls.Add(this.progressSDDownload);
            this.tabSingleDownload.Controls.Add(this.buttonSDSelectDir);
            this.tabSingleDownload.Controls.Add(this.labelSDOuputDir);
            this.tabSingleDownload.Controls.Add(this.textSDOutputDir);
            this.tabSingleDownload.Controls.Add(this.groupSDVideoOption);
            this.tabSingleDownload.Controls.Add(this.groupSDVideoInformation);
            this.tabSingleDownload.Controls.Add(this.pictureSDPicture);
            this.tabSingleDownload.Controls.Add(this.buttonSDGetLink);
            this.tabSingleDownload.Controls.Add(this.labelSDLink);
            this.tabSingleDownload.Controls.Add(this.textSDLink);
            this.tabSingleDownload.Location = new System.Drawing.Point(4, 22);
            this.tabSingleDownload.Name = "tabSingleDownload";
            this.tabSingleDownload.Padding = new System.Windows.Forms.Padding(3);
            this.tabSingleDownload.Size = new System.Drawing.Size(791, 379);
            this.tabSingleDownload.TabIndex = 0;
            this.tabSingleDownload.Text = "Single Download";
            this.tabSingleDownload.UseVisualStyleBackColor = true;
            // 
            // buttonSDProgressDownload
            // 
            this.buttonSDProgressDownload.Location = new System.Drawing.Point(615, 337);
            this.buttonSDProgressDownload.Name = "buttonSDProgressDownload";
            this.buttonSDProgressDownload.Size = new System.Drawing.Size(162, 23);
            this.buttonSDProgressDownload.TabIndex = 11;
            this.buttonSDProgressDownload.Text = "Download";
            this.buttonSDProgressDownload.UseVisualStyleBackColor = true;
            this.buttonSDProgressDownload.Click += new System.EventHandler(this.buttonSDProgressDownload_Click);
            // 
            // labelSDProgressDownload
            // 
            this.labelSDProgressDownload.AutoSize = true;
            this.labelSDProgressDownload.Location = new System.Drawing.Point(6, 342);
            this.labelSDProgressDownload.Name = "labelSDProgressDownload";
            this.labelSDProgressDownload.Size = new System.Drawing.Size(51, 13);
            this.labelSDProgressDownload.TabIndex = 10;
            this.labelSDProgressDownload.Text = "Progress:";
            // 
            // progressSDDownload
            // 
            this.progressSDDownload.Location = new System.Drawing.Point(97, 337);
            this.progressSDDownload.Name = "progressSDDownload";
            this.progressSDDownload.Size = new System.Drawing.Size(512, 23);
            this.progressSDDownload.TabIndex = 9;
            // 
            // buttonSDSelectDir
            // 
            this.buttonSDSelectDir.Location = new System.Drawing.Point(615, 308);
            this.buttonSDSelectDir.Name = "buttonSDSelectDir";
            this.buttonSDSelectDir.Size = new System.Drawing.Size(162, 23);
            this.buttonSDSelectDir.TabIndex = 8;
            this.buttonSDSelectDir.Text = "Select Directory";
            this.buttonSDSelectDir.UseVisualStyleBackColor = true;
            // 
            // labelSDOuputDir
            // 
            this.labelSDOuputDir.AutoSize = true;
            this.labelSDOuputDir.Location = new System.Drawing.Point(6, 313);
            this.labelSDOuputDir.Name = "labelSDOuputDir";
            this.labelSDOuputDir.Size = new System.Drawing.Size(85, 13);
            this.labelSDOuputDir.TabIndex = 7;
            this.labelSDOuputDir.Text = "Output directory:";
            // 
            // textSDOutputDir
            // 
            this.textSDOutputDir.Location = new System.Drawing.Point(97, 310);
            this.textSDOutputDir.Name = "textSDOutputDir";
            this.textSDOutputDir.Size = new System.Drawing.Size(512, 20);
            this.textSDOutputDir.TabIndex = 6;
            // 
            // groupSDVideoOption
            // 
            this.groupSDVideoOption.Controls.Add(this.labelSDAudioQuality);
            this.groupSDVideoOption.Controls.Add(this.comboSDAudioQuality);
            this.groupSDVideoOption.Controls.Add(this.labelSDVideoResolution);
            this.groupSDVideoOption.Controls.Add(this.comboSDVideoResolution);
            this.groupSDVideoOption.Controls.Add(this.radioSDFormatWEBM);
            this.groupSDVideoOption.Controls.Add(this.radioSDFormatMP4);
            this.groupSDVideoOption.Controls.Add(this.labelSDOutputFormat);
            this.groupSDVideoOption.Location = new System.Drawing.Point(492, 203);
            this.groupSDVideoOption.Name = "groupSDVideoOption";
            this.groupSDVideoOption.Size = new System.Drawing.Size(291, 101);
            this.groupSDVideoOption.TabIndex = 5;
            this.groupSDVideoOption.TabStop = false;
            this.groupSDVideoOption.Text = "Video Option";
            // 
            // labelSDAudioQuality
            // 
            this.labelSDAudioQuality.AutoSize = true;
            this.labelSDAudioQuality.Location = new System.Drawing.Point(6, 71);
            this.labelSDAudioQuality.Name = "labelSDAudioQuality";
            this.labelSDAudioQuality.Size = new System.Drawing.Size(72, 13);
            this.labelSDAudioQuality.TabIndex = 6;
            this.labelSDAudioQuality.Text = "Audio Quality:";
            // 
            // comboSDAudioQuality
            // 
            this.comboSDAudioQuality.FormattingEnabled = true;
            this.comboSDAudioQuality.Location = new System.Drawing.Point(102, 68);
            this.comboSDAudioQuality.Name = "comboSDAudioQuality";
            this.comboSDAudioQuality.Size = new System.Drawing.Size(161, 21);
            this.comboSDAudioQuality.TabIndex = 5;
            this.comboSDAudioQuality.SelectedIndexChanged += new System.EventHandler(this.comboSDAudioQuality_SelectedIndexChanged);
            // 
            // labelSDVideoResolution
            // 
            this.labelSDVideoResolution.AutoSize = true;
            this.labelSDVideoResolution.Location = new System.Drawing.Point(6, 44);
            this.labelSDVideoResolution.Name = "labelSDVideoResolution";
            this.labelSDVideoResolution.Size = new System.Drawing.Size(90, 13);
            this.labelSDVideoResolution.TabIndex = 4;
            this.labelSDVideoResolution.Text = "Video Resolution:";
            // 
            // comboSDVideoResolution
            // 
            this.comboSDVideoResolution.FormattingEnabled = true;
            this.comboSDVideoResolution.Location = new System.Drawing.Point(102, 41);
            this.comboSDVideoResolution.Name = "comboSDVideoResolution";
            this.comboSDVideoResolution.Size = new System.Drawing.Size(161, 21);
            this.comboSDVideoResolution.TabIndex = 3;
            this.comboSDVideoResolution.SelectedIndexChanged += new System.EventHandler(this.comboSDVideoResolution_SelectedIndexChanged);
            // 
            // radioSDFormatWEBM
            // 
            this.radioSDFormatWEBM.AutoSize = true;
            this.radioSDFormatWEBM.Location = new System.Drawing.Point(140, 18);
            this.radioSDFormatWEBM.Name = "radioSDFormatWEBM";
            this.radioSDFormatWEBM.Size = new System.Drawing.Size(59, 17);
            this.radioSDFormatWEBM.TabIndex = 2;
            this.radioSDFormatWEBM.TabStop = true;
            this.radioSDFormatWEBM.Text = "WEBM";
            this.radioSDFormatWEBM.UseVisualStyleBackColor = true;
            this.radioSDFormatWEBM.CheckedChanged += new System.EventHandler(this.radioSDFormatWEBM_CheckedChanged);
            // 
            // radioSDFormatMP4
            // 
            this.radioSDFormatMP4.AutoSize = true;
            this.radioSDFormatMP4.Location = new System.Drawing.Point(87, 18);
            this.radioSDFormatMP4.Name = "radioSDFormatMP4";
            this.radioSDFormatMP4.Size = new System.Drawing.Size(47, 17);
            this.radioSDFormatMP4.TabIndex = 1;
            this.radioSDFormatMP4.TabStop = true;
            this.radioSDFormatMP4.Text = "MP4";
            this.radioSDFormatMP4.UseVisualStyleBackColor = true;
            this.radioSDFormatMP4.CheckedChanged += new System.EventHandler(this.radioSDFormatMP4_CheckedChanged);
            // 
            // labelSDOutputFormat
            // 
            this.labelSDOutputFormat.AutoSize = true;
            this.labelSDOutputFormat.Location = new System.Drawing.Point(7, 20);
            this.labelSDOutputFormat.Name = "labelSDOutputFormat";
            this.labelSDOutputFormat.Size = new System.Drawing.Size(74, 13);
            this.labelSDOutputFormat.TabIndex = 0;
            this.labelSDOutputFormat.Text = "Ouput Format:";
            // 
            // groupSDVideoInformation
            // 
            this.groupSDVideoInformation.Controls.Add(this.labelSDVideoAuthor);
            this.groupSDVideoInformation.Controls.Add(this.textSDVideoAuthor);
            this.groupSDVideoInformation.Controls.Add(this.textSDVideoTitle);
            this.groupSDVideoInformation.Controls.Add(this.labelSDVideoTitle);
            this.groupSDVideoInformation.Location = new System.Drawing.Point(492, 34);
            this.groupSDVideoInformation.Name = "groupSDVideoInformation";
            this.groupSDVideoInformation.Size = new System.Drawing.Size(291, 163);
            this.groupSDVideoInformation.TabIndex = 4;
            this.groupSDVideoInformation.TabStop = false;
            this.groupSDVideoInformation.Text = "Video Information";
            // 
            // labelSDVideoAuthor
            // 
            this.labelSDVideoAuthor.AutoSize = true;
            this.labelSDVideoAuthor.Location = new System.Drawing.Point(6, 135);
            this.labelSDVideoAuthor.Name = "labelSDVideoAuthor";
            this.labelSDVideoAuthor.Size = new System.Drawing.Size(41, 13);
            this.labelSDVideoAuthor.TabIndex = 3;
            this.labelSDVideoAuthor.Text = "Author:";
            // 
            // textSDVideoAuthor
            // 
            this.textSDVideoAuthor.BackColor = System.Drawing.SystemColors.Window;
            this.textSDVideoAuthor.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textSDVideoAuthor.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textSDVideoAuthor.Location = new System.Drawing.Point(53, 135);
            this.textSDVideoAuthor.Name = "textSDVideoAuthor";
            this.textSDVideoAuthor.ReadOnly = true;
            this.textSDVideoAuthor.Size = new System.Drawing.Size(232, 13);
            this.textSDVideoAuthor.TabIndex = 2;
            // 
            // textSDVideoTitle
            // 
            this.textSDVideoTitle.BackColor = System.Drawing.SystemColors.Window;
            this.textSDVideoTitle.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textSDVideoTitle.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textSDVideoTitle.Location = new System.Drawing.Point(53, 16);
            this.textSDVideoTitle.Multiline = true;
            this.textSDVideoTitle.Name = "textSDVideoTitle";
            this.textSDVideoTitle.ReadOnly = true;
            this.textSDVideoTitle.Size = new System.Drawing.Size(232, 113);
            this.textSDVideoTitle.TabIndex = 1;
            // 
            // labelSDVideoTitle
            // 
            this.labelSDVideoTitle.AutoSize = true;
            this.labelSDVideoTitle.Location = new System.Drawing.Point(6, 16);
            this.labelSDVideoTitle.Name = "labelSDVideoTitle";
            this.labelSDVideoTitle.Size = new System.Drawing.Size(30, 13);
            this.labelSDVideoTitle.TabIndex = 0;
            this.labelSDVideoTitle.Text = "Title:";
            // 
            // pictureSDPicture
            // 
            this.pictureSDPicture.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureSDPicture.Location = new System.Drawing.Point(6, 34);
            this.pictureSDPicture.Name = "pictureSDPicture";
            this.pictureSDPicture.Size = new System.Drawing.Size(480, 270);
            this.pictureSDPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureSDPicture.TabIndex = 3;
            this.pictureSDPicture.TabStop = false;
            // 
            // buttonSDGetLink
            // 
            this.buttonSDGetLink.Location = new System.Drawing.Point(615, 5);
            this.buttonSDGetLink.Name = "buttonSDGetLink";
            this.buttonSDGetLink.Size = new System.Drawing.Size(162, 23);
            this.buttonSDGetLink.TabIndex = 2;
            this.buttonSDGetLink.Text = "Get Link";
            this.buttonSDGetLink.UseVisualStyleBackColor = true;
            this.buttonSDGetLink.Click += new System.EventHandler(this.buttonSDGetLink_Click);
            // 
            // labelSDLink
            // 
            this.labelSDLink.AutoSize = true;
            this.labelSDLink.Location = new System.Drawing.Point(6, 10);
            this.labelSDLink.Name = "labelSDLink";
            this.labelSDLink.Size = new System.Drawing.Size(56, 13);
            this.labelSDLink.TabIndex = 1;
            this.labelSDLink.Text = "Video link:";
            // 
            // textSDLink
            // 
            this.textSDLink.Location = new System.Drawing.Point(68, 7);
            this.textSDLink.Name = "textSDLink";
            this.textSDLink.Size = new System.Drawing.Size(541, 20);
            this.textSDLink.TabIndex = 0;
            // 
            // tabSettings
            // 
            this.tabSettings.Controls.Add(this.groupSettingsInstallation);
            this.tabSettings.Controls.Add(this.groupSettingsCore);
            this.tabSettings.Controls.Add(this.groupSettingsApplication);
            this.tabSettings.Location = new System.Drawing.Point(4, 22);
            this.tabSettings.Name = "tabSettings";
            this.tabSettings.Padding = new System.Windows.Forms.Padding(3);
            this.tabSettings.Size = new System.Drawing.Size(791, 379);
            this.tabSettings.TabIndex = 1;
            this.tabSettings.Text = "Settings";
            this.tabSettings.UseVisualStyleBackColor = true;
            // 
            // groupSettingsInstallation
            // 
            this.groupSettingsInstallation.Controls.Add(this.labelSettingsInstallationProgress);
            this.groupSettingsInstallation.Controls.Add(this.progressSettingsInstallation);
            this.groupSettingsInstallation.Controls.Add(this.buttonSettingsInstallationInstall);
            this.groupSettingsInstallation.Controls.Add(this.checkSettingsInstallationDiffTemp);
            this.groupSettingsInstallation.Controls.Add(this.checkSettingsInstallationDesktopIcon);
            this.groupSettingsInstallation.Controls.Add(this.buttonSettingsInstallationTempDir);
            this.groupSettingsInstallation.Controls.Add(this.labelSettingsInstallationTemp);
            this.groupSettingsInstallation.Controls.Add(this.textSettingsInstallationTempDir);
            this.groupSettingsInstallation.Controls.Add(this.buttonSettingsInstallationSelectAppDir);
            this.groupSettingsInstallation.Controls.Add(this.labelSettingsInstallationDir);
            this.groupSettingsInstallation.Controls.Add(this.textSettingsInstallationAppDir);
            this.groupSettingsInstallation.Location = new System.Drawing.Point(6, 149);
            this.groupSettingsInstallation.Name = "groupSettingsInstallation";
            this.groupSettingsInstallation.Size = new System.Drawing.Size(777, 224);
            this.groupSettingsInstallation.TabIndex = 2;
            this.groupSettingsInstallation.TabStop = false;
            this.groupSettingsInstallation.Text = "Installation";
            // 
            // labelSettingsInstallationProgress
            // 
            this.labelSettingsInstallationProgress.AutoSize = true;
            this.labelSettingsInstallationProgress.Location = new System.Drawing.Point(7, 188);
            this.labelSettingsInstallationProgress.Name = "labelSettingsInstallationProgress";
            this.labelSettingsInstallationProgress.Size = new System.Drawing.Size(51, 13);
            this.labelSettingsInstallationProgress.TabIndex = 17;
            this.labelSettingsInstallationProgress.Text = "Progress:";
            // 
            // progressSettingsInstallation
            // 
            this.progressSettingsInstallation.Location = new System.Drawing.Point(64, 183);
            this.progressSettingsInstallation.Name = "progressSettingsInstallation";
            this.progressSettingsInstallation.Size = new System.Drawing.Size(546, 23);
            this.progressSettingsInstallation.TabIndex = 16;
            // 
            // buttonSettingsInstallationInstall
            // 
            this.buttonSettingsInstallationInstall.Location = new System.Drawing.Point(616, 183);
            this.buttonSettingsInstallationInstall.Name = "buttonSettingsInstallationInstall";
            this.buttonSettingsInstallationInstall.Size = new System.Drawing.Size(155, 23);
            this.buttonSettingsInstallationInstall.TabIndex = 15;
            this.buttonSettingsInstallationInstall.Text = "Install";
            this.buttonSettingsInstallationInstall.UseVisualStyleBackColor = true;
            this.buttonSettingsInstallationInstall.Click += new System.EventHandler(this.buttonSettingsInstallationInstall_Click);
            // 
            // checkSettingsInstallationDiffTemp
            // 
            this.checkSettingsInstallationDiffTemp.AutoSize = true;
            this.checkSettingsInstallationDiffTemp.Location = new System.Drawing.Point(243, 71);
            this.checkSettingsInstallationDiffTemp.Name = "checkSettingsInstallationDiffTemp";
            this.checkSettingsInstallationDiffTemp.Size = new System.Drawing.Size(155, 17);
            this.checkSettingsInstallationDiffTemp.TabIndex = 14;
            this.checkSettingsInstallationDiffTemp.Text = "Use different temp directory";
            this.checkSettingsInstallationDiffTemp.UseVisualStyleBackColor = true;
            // 
            // checkSettingsInstallationDesktopIcon
            // 
            this.checkSettingsInstallationDesktopIcon.AutoSize = true;
            this.checkSettingsInstallationDesktopIcon.Checked = true;
            this.checkSettingsInstallationDesktopIcon.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkSettingsInstallationDesktopIcon.Location = new System.Drawing.Point(116, 71);
            this.checkSettingsInstallationDesktopIcon.Name = "checkSettingsInstallationDesktopIcon";
            this.checkSettingsInstallationDesktopIcon.Size = new System.Drawing.Size(121, 17);
            this.checkSettingsInstallationDesktopIcon.TabIndex = 13;
            this.checkSettingsInstallationDesktopIcon.Text = "Create desktop icon";
            this.checkSettingsInstallationDesktopIcon.UseVisualStyleBackColor = true;
            // 
            // buttonSettingsInstallationTempDir
            // 
            this.buttonSettingsInstallationTempDir.Location = new System.Drawing.Point(616, 43);
            this.buttonSettingsInstallationTempDir.Name = "buttonSettingsInstallationTempDir";
            this.buttonSettingsInstallationTempDir.Size = new System.Drawing.Size(155, 23);
            this.buttonSettingsInstallationTempDir.TabIndex = 12;
            this.buttonSettingsInstallationTempDir.Text = "Select Directory";
            this.buttonSettingsInstallationTempDir.UseVisualStyleBackColor = true;
            // 
            // labelSettingsInstallationTemp
            // 
            this.labelSettingsInstallationTemp.AutoSize = true;
            this.labelSettingsInstallationTemp.Location = new System.Drawing.Point(7, 48);
            this.labelSettingsInstallationTemp.Name = "labelSettingsInstallationTemp";
            this.labelSettingsInstallationTemp.Size = new System.Drawing.Size(80, 13);
            this.labelSettingsInstallationTemp.TabIndex = 11;
            this.labelSettingsInstallationTemp.Text = "Temp directory:";
            // 
            // textSettingsInstallationTempDir
            // 
            this.textSettingsInstallationTempDir.Location = new System.Drawing.Point(116, 45);
            this.textSettingsInstallationTempDir.Name = "textSettingsInstallationTempDir";
            this.textSettingsInstallationTempDir.Size = new System.Drawing.Size(494, 20);
            this.textSettingsInstallationTempDir.TabIndex = 10;
            this.textSettingsInstallationTempDir.Text = "C:\\Program Files (x86)\\Youtube-DL GUI\\temp";
            // 
            // buttonSettingsInstallationSelectAppDir
            // 
            this.buttonSettingsInstallationSelectAppDir.Location = new System.Drawing.Point(616, 17);
            this.buttonSettingsInstallationSelectAppDir.Name = "buttonSettingsInstallationSelectAppDir";
            this.buttonSettingsInstallationSelectAppDir.Size = new System.Drawing.Size(155, 23);
            this.buttonSettingsInstallationSelectAppDir.TabIndex = 9;
            this.buttonSettingsInstallationSelectAppDir.Text = "Select Directory";
            this.buttonSettingsInstallationSelectAppDir.UseVisualStyleBackColor = true;
            // 
            // labelSettingsInstallationDir
            // 
            this.labelSettingsInstallationDir.AutoSize = true;
            this.labelSettingsInstallationDir.Location = new System.Drawing.Point(7, 22);
            this.labelSettingsInstallationDir.Name = "labelSettingsInstallationDir";
            this.labelSettingsInstallationDir.Size = new System.Drawing.Size(103, 13);
            this.labelSettingsInstallationDir.TabIndex = 1;
            this.labelSettingsInstallationDir.Text = "Installation directory:";
            // 
            // textSettingsInstallationAppDir
            // 
            this.textSettingsInstallationAppDir.Location = new System.Drawing.Point(116, 19);
            this.textSettingsInstallationAppDir.Name = "textSettingsInstallationAppDir";
            this.textSettingsInstallationAppDir.Size = new System.Drawing.Size(494, 20);
            this.textSettingsInstallationAppDir.TabIndex = 0;
            this.textSettingsInstallationAppDir.Text = "C:\\Program Files (x86)\\Youtube-DL GUI";
            // 
            // groupSettingsCore
            // 
            this.groupSettingsCore.Controls.Add(this.buttonSettingsCoreUpdate);
            this.groupSettingsCore.Controls.Add(this.labelSettingsCoreFFMPEGVersion);
            this.groupSettingsCore.Controls.Add(this.labelSettingsCoreYTDLVersion);
            this.groupSettingsCore.Controls.Add(this.textSettingsCoreFFMPEGVersion);
            this.groupSettingsCore.Controls.Add(this.textSettingsCoreYTDLVersion);
            this.groupSettingsCore.Location = new System.Drawing.Point(399, 7);
            this.groupSettingsCore.Name = "groupSettingsCore";
            this.groupSettingsCore.Size = new System.Drawing.Size(384, 136);
            this.groupSettingsCore.TabIndex = 1;
            this.groupSettingsCore.TabStop = false;
            this.groupSettingsCore.Text = "Core";
            // 
            // buttonSettingsCoreUpdate
            // 
            this.buttonSettingsCoreUpdate.Location = new System.Drawing.Point(6, 107);
            this.buttonSettingsCoreUpdate.Name = "buttonSettingsCoreUpdate";
            this.buttonSettingsCoreUpdate.Size = new System.Drawing.Size(372, 23);
            this.buttonSettingsCoreUpdate.TabIndex = 5;
            this.buttonSettingsCoreUpdate.Text = "Update Core";
            this.buttonSettingsCoreUpdate.UseVisualStyleBackColor = true;
            // 
            // labelSettingsCoreFFMPEGVersion
            // 
            this.labelSettingsCoreFFMPEGVersion.AutoSize = true;
            this.labelSettingsCoreFFMPEGVersion.Location = new System.Drawing.Point(6, 48);
            this.labelSettingsCoreFFMPEGVersion.Name = "labelSettingsCoreFFMPEGVersion";
            this.labelSettingsCoreFFMPEGVersion.Size = new System.Drawing.Size(90, 13);
            this.labelSettingsCoreFFMPEGVersion.TabIndex = 8;
            this.labelSettingsCoreFFMPEGVersion.Text = "FFMPEG version:";
            // 
            // labelSettingsCoreYTDLVersion
            // 
            this.labelSettingsCoreYTDLVersion.AutoSize = true;
            this.labelSettingsCoreYTDLVersion.Location = new System.Drawing.Point(6, 22);
            this.labelSettingsCoreYTDLVersion.Name = "labelSettingsCoreYTDLVersion";
            this.labelSettingsCoreYTDLVersion.Size = new System.Drawing.Size(104, 13);
            this.labelSettingsCoreYTDLVersion.TabIndex = 6;
            this.labelSettingsCoreYTDLVersion.Text = "Youtube-DL version:";
            // 
            // textSettingsCoreFFMPEGVersion
            // 
            this.textSettingsCoreFFMPEGVersion.BackColor = System.Drawing.SystemColors.Window;
            this.textSettingsCoreFFMPEGVersion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textSettingsCoreFFMPEGVersion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textSettingsCoreFFMPEGVersion.Location = new System.Drawing.Point(106, 48);
            this.textSettingsCoreFFMPEGVersion.Name = "textSettingsCoreFFMPEGVersion";
            this.textSettingsCoreFFMPEGVersion.ReadOnly = true;
            this.textSettingsCoreFFMPEGVersion.Size = new System.Drawing.Size(262, 13);
            this.textSettingsCoreFFMPEGVersion.TabIndex = 7;
            // 
            // textSettingsCoreYTDLVersion
            // 
            this.textSettingsCoreYTDLVersion.BackColor = System.Drawing.SystemColors.Window;
            this.textSettingsCoreYTDLVersion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textSettingsCoreYTDLVersion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textSettingsCoreYTDLVersion.Location = new System.Drawing.Point(111, 22);
            this.textSettingsCoreYTDLVersion.Name = "textSettingsCoreYTDLVersion";
            this.textSettingsCoreYTDLVersion.ReadOnly = true;
            this.textSettingsCoreYTDLVersion.Size = new System.Drawing.Size(258, 13);
            this.textSettingsCoreYTDLVersion.TabIndex = 5;
            // 
            // groupSettingsApplication
            // 
            this.groupSettingsApplication.Controls.Add(this.buttonSettingsAppUpdate);
            this.groupSettingsApplication.Controls.Add(this.labelSettingsAppAuthor);
            this.groupSettingsApplication.Controls.Add(this.textSettingsAppAuthor);
            this.groupSettingsApplication.Controls.Add(this.labelSettingsAppVersion);
            this.groupSettingsApplication.Controls.Add(this.textSettingsAppVersion);
            this.groupSettingsApplication.Location = new System.Drawing.Point(7, 7);
            this.groupSettingsApplication.Name = "groupSettingsApplication";
            this.groupSettingsApplication.Size = new System.Drawing.Size(386, 136);
            this.groupSettingsApplication.TabIndex = 0;
            this.groupSettingsApplication.TabStop = false;
            this.groupSettingsApplication.Text = "Application";
            // 
            // buttonSettingsAppUpdate
            // 
            this.buttonSettingsAppUpdate.Location = new System.Drawing.Point(6, 107);
            this.buttonSettingsAppUpdate.Name = "buttonSettingsAppUpdate";
            this.buttonSettingsAppUpdate.Size = new System.Drawing.Size(374, 23);
            this.buttonSettingsAppUpdate.TabIndex = 4;
            this.buttonSettingsAppUpdate.Text = "Update Application";
            this.buttonSettingsAppUpdate.UseVisualStyleBackColor = true;
            // 
            // labelSettingsAppAuthor
            // 
            this.labelSettingsAppAuthor.AutoSize = true;
            this.labelSettingsAppAuthor.Location = new System.Drawing.Point(6, 48);
            this.labelSettingsAppAuthor.Name = "labelSettingsAppAuthor";
            this.labelSettingsAppAuthor.Size = new System.Drawing.Size(95, 13);
            this.labelSettingsAppAuthor.TabIndex = 3;
            this.labelSettingsAppAuthor.Text = "Application author:";
            // 
            // textSettingsAppAuthor
            // 
            this.textSettingsAppAuthor.BackColor = System.Drawing.SystemColors.Window;
            this.textSettingsAppAuthor.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textSettingsAppAuthor.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textSettingsAppAuthor.Location = new System.Drawing.Point(106, 48);
            this.textSettingsAppAuthor.Name = "textSettingsAppAuthor";
            this.textSettingsAppAuthor.ReadOnly = true;
            this.textSettingsAppAuthor.Size = new System.Drawing.Size(262, 13);
            this.textSettingsAppAuthor.TabIndex = 2;
            this.textSettingsAppAuthor.Text = "Cuong Dinh";
            // 
            // labelSettingsAppVersion
            // 
            this.labelSettingsAppVersion.AutoSize = true;
            this.labelSettingsAppVersion.Location = new System.Drawing.Point(6, 22);
            this.labelSettingsAppVersion.Name = "labelSettingsAppVersion";
            this.labelSettingsAppVersion.Size = new System.Drawing.Size(99, 13);
            this.labelSettingsAppVersion.TabIndex = 1;
            this.labelSettingsAppVersion.Text = "Application version:";
            // 
            // textSettingsAppVersion
            // 
            this.textSettingsAppVersion.BackColor = System.Drawing.SystemColors.Window;
            this.textSettingsAppVersion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textSettingsAppVersion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textSettingsAppVersion.Location = new System.Drawing.Point(111, 22);
            this.textSettingsAppVersion.Name = "textSettingsAppVersion";
            this.textSettingsAppVersion.ReadOnly = true;
            this.textSettingsAppVersion.Size = new System.Drawing.Size(258, 13);
            this.textSettingsAppVersion.TabIndex = 0;
            this.textSettingsAppVersion.Text = "Beta v0.1";
            // 
            // textStatus
            // 
            this.textStatus.BackColor = System.Drawing.SystemColors.Control;
            this.textStatus.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textStatus.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textStatus.Location = new System.Drawing.Point(13, 409);
            this.textStatus.Multiline = true;
            this.textStatus.Name = "textStatus";
            this.textStatus.ReadOnly = true;
            this.textStatus.Size = new System.Drawing.Size(775, 20);
            this.textStatus.TabIndex = 1;
            this.textStatus.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Youtube_DL_GUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 434);
            this.Controls.Add(this.textStatus);
            this.Controls.Add(this.tabLists);
            this.Name = "Youtube_DL_GUI";
            this.Text = "Youtube-DL GUI";
            this.tabLists.ResumeLayout(false);
            this.tabSingleDownload.ResumeLayout(false);
            this.tabSingleDownload.PerformLayout();
            this.groupSDVideoOption.ResumeLayout(false);
            this.groupSDVideoOption.PerformLayout();
            this.groupSDVideoInformation.ResumeLayout(false);
            this.groupSDVideoInformation.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureSDPicture)).EndInit();
            this.tabSettings.ResumeLayout(false);
            this.groupSettingsInstallation.ResumeLayout(false);
            this.groupSettingsInstallation.PerformLayout();
            this.groupSettingsCore.ResumeLayout(false);
            this.groupSettingsCore.PerformLayout();
            this.groupSettingsApplication.ResumeLayout(false);
            this.groupSettingsApplication.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabLists;
        private System.Windows.Forms.TabPage tabSingleDownload;
        private System.Windows.Forms.GroupBox groupSDVideoInformation;
        private System.Windows.Forms.Label labelSDVideoAuthor;
        private System.Windows.Forms.TextBox textSDVideoAuthor;
        private System.Windows.Forms.TextBox textSDVideoTitle;
        private System.Windows.Forms.Label labelSDVideoTitle;
        private System.Windows.Forms.PictureBox pictureSDPicture;
        private System.Windows.Forms.Button buttonSDGetLink;
        private System.Windows.Forms.Label labelSDLink;
        private System.Windows.Forms.TextBox textSDLink;
        private System.Windows.Forms.TabPage tabSettings;
        private System.Windows.Forms.GroupBox groupSDVideoOption;
        private System.Windows.Forms.RadioButton radioSDFormatWEBM;
        private System.Windows.Forms.RadioButton radioSDFormatMP4;
        private System.Windows.Forms.Label labelSDOutputFormat;
        private System.Windows.Forms.Label labelSDAudioQuality;
        private System.Windows.Forms.ComboBox comboSDAudioQuality;
        private System.Windows.Forms.Label labelSDVideoResolution;
        private System.Windows.Forms.ComboBox comboSDVideoResolution;
        private System.Windows.Forms.TextBox textSDOutputDir;
        private System.Windows.Forms.Button buttonSDSelectDir;
        private System.Windows.Forms.Label labelSDOuputDir;
        private System.Windows.Forms.Button buttonSDProgressDownload;
        private System.Windows.Forms.Label labelSDProgressDownload;
        private System.Windows.Forms.ProgressBar progressSDDownload;
        private System.Windows.Forms.GroupBox groupSettingsCore;
        private System.Windows.Forms.GroupBox groupSettingsApplication;
        private System.Windows.Forms.Button buttonSettingsAppUpdate;
        private System.Windows.Forms.Label labelSettingsAppAuthor;
        private System.Windows.Forms.TextBox textSettingsAppAuthor;
        private System.Windows.Forms.Label labelSettingsAppVersion;
        private System.Windows.Forms.TextBox textSettingsAppVersion;
        private System.Windows.Forms.GroupBox groupSettingsInstallation;
        private System.Windows.Forms.Button buttonSettingsCoreUpdate;
        private System.Windows.Forms.Label labelSettingsCoreFFMPEGVersion;
        private System.Windows.Forms.Label labelSettingsCoreYTDLVersion;
        private System.Windows.Forms.TextBox textSettingsCoreFFMPEGVersion;
        private System.Windows.Forms.TextBox textSettingsCoreYTDLVersion;
        private System.Windows.Forms.Label labelSettingsInstallationProgress;
        private System.Windows.Forms.ProgressBar progressSettingsInstallation;
        private System.Windows.Forms.Button buttonSettingsInstallationInstall;
        private System.Windows.Forms.CheckBox checkSettingsInstallationDiffTemp;
        private System.Windows.Forms.CheckBox checkSettingsInstallationDesktopIcon;
        private System.Windows.Forms.Button buttonSettingsInstallationTempDir;
        private System.Windows.Forms.Label labelSettingsInstallationTemp;
        private System.Windows.Forms.TextBox textSettingsInstallationTempDir;
        private System.Windows.Forms.Button buttonSettingsInstallationSelectAppDir;
        private System.Windows.Forms.Label labelSettingsInstallationDir;
        private System.Windows.Forms.TextBox textSettingsInstallationAppDir;
        private System.Windows.Forms.TextBox textStatus;
        private string videoID = "";
        private string videoInfoContent = "";
        private string ext = "";

        public class AppConfig
        {
            public string appDir;
            public string binDir;
            public string coreDir;
            public string tempDir;
            public string shortcutLocation = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "Youtube-DL GUI.lnk");
        }
        AppConfig appConfig = new AppConfig();
    }
}

