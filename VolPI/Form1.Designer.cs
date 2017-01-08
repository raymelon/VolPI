namespace VolPI
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItemExit = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripItemAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemOpenVolumeMixer = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItemPlaybackDevices = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemRecordingDevices = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemSounds = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItemVolumeControlOptions = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.ContextMenuStrip = this.contextMenuStrip1;
            this.notifyIcon1.Text = "Speakers: ";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.DoubleClick += new System.EventHandler(this.notifyIcon1_DoubleClick);
            this.notifyIcon1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemOpenVolumeMixer,
            this.toolStripSeparator1,
            this.toolStripMenuItemPlaybackDevices,
            this.toolStripMenuItemRecordingDevices,
            this.toolStripMenuItemSounds,
            this.toolStripSeparator2,
            this.toolStripMenuItemVolumeControlOptions,
            this.toolStripSeparator3,
            this.toolStripItemAbout,
            this.toolStripMenuItemExit});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.contextMenuStrip1.Size = new System.Drawing.Size(204, 176);
            // 
            // toolStripMenuItemExit
            // 
            this.toolStripMenuItemExit.Name = "toolStripMenuItemExit";
            this.toolStripMenuItemExit.Size = new System.Drawing.Size(203, 22);
            this.toolStripMenuItemExit.Text = "Exit";
            // 
            // toolStripItemAbout
            // 
            this.toolStripItemAbout.Name = "toolStripItemAbout";
            this.toolStripItemAbout.Size = new System.Drawing.Size(203, 22);
            this.toolStripItemAbout.Text = "About VolPI";
            // 
            // toolStripMenuItemOpenVolumeMixer
            // 
            this.toolStripMenuItemOpenVolumeMixer.Name = "toolStripMenuItemOpenVolumeMixer";
            this.toolStripMenuItemOpenVolumeMixer.Size = new System.Drawing.Size(203, 22);
            this.toolStripMenuItemOpenVolumeMixer.Text = "Open Volume Mixer";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(200, 6);
            // 
            // toolStripMenuItemPlaybackDevices
            // 
            this.toolStripMenuItemPlaybackDevices.Name = "toolStripMenuItemPlaybackDevices";
            this.toolStripMenuItemPlaybackDevices.Size = new System.Drawing.Size(203, 22);
            this.toolStripMenuItemPlaybackDevices.Text = "Playback Devices";
            // 
            // toolStripMenuItemRecordingDevices
            // 
            this.toolStripMenuItemRecordingDevices.Name = "toolStripMenuItemRecordingDevices";
            this.toolStripMenuItemRecordingDevices.Size = new System.Drawing.Size(203, 22);
            this.toolStripMenuItemRecordingDevices.Text = "Recording Devices";
            // 
            // toolStripMenuItemSounds
            // 
            this.toolStripMenuItemSounds.Name = "toolStripMenuItemSounds";
            this.toolStripMenuItemSounds.Size = new System.Drawing.Size(203, 22);
            this.toolStripMenuItemSounds.Text = "Sounds";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(200, 6);
            // 
            // toolStripMenuItemVolumeControlOptions
            // 
            this.toolStripMenuItemVolumeControlOptions.Name = "toolStripMenuItemVolumeControlOptions";
            this.toolStripMenuItemVolumeControlOptions.Size = new System.Drawing.Size(203, 22);
            this.toolStripMenuItemVolumeControlOptions.Text = "Volume Control Options";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(200, 6);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(160, 0);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Opacity = 0D;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "VolPI";
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemExit;
        private System.Windows.Forms.ToolStripMenuItem toolStripItemAbout;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemOpenVolumeMixer;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemPlaybackDevices;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemRecordingDevices;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemSounds;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemVolumeControlOptions;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
    }
}

