using System;
using System.Windows.Forms;
using System.Drawing;
using System.Diagnostics;

using AudioSwitcher.AudioApi.CoreAudio;
using NAudio.CoreAudioApi;

namespace VolPI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            this.InitializeComponent();

            this.volumeString = this.defaultPlaybackDevice.Volume.ToString();
            this.notifyIcon1.Icon = generateNotifyIcon();
            this.notifyIcon1.Text += this.defaultPlaybackDevice.Volume + "%";
            
            mmdevice.AudioEndpointVolume.OnVolumeNotification += AudioEndpointVolume_OnVolumeNotification;

            contextMenuStrip1.ItemClicked += new ToolStripItemClickedEventHandler(contextMenuStrip1_ItemClicked);


            //this.Hide();
        }

        #region Events
        private void notifyIcon1_MouseClick(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left)
            {
                openSndVol("-f ");
            }
            else if(e.Button == MouseButtons.Right)
            {
                this.Left = Cursor.Position.X;
                this.Top = Screen.PrimaryScreen.WorkingArea.Bottom - this.Height;

                contextMenuStrip1.Left = this.Left;
                contextMenuStrip1.Top = this.Top;

                contextMenuStrip1.Show();
            }
        }

        /// <summary>
        /// mutes master audio device when notify icon is double clicked
        /// </summary>
        private void notifyIcon1_DoubleClick(object sender, EventArgs e)
        {
            if (this.defaultPlaybackDevice.IsMuted)
            {
                this.unmute();
            }
            else
            {
                this.mute();
            }
        }

        private void AudioEndpointVolume_OnVolumeNotification(AudioVolumeNotificationData data)
        {
            this.volumeString = this.defaultPlaybackDevice.Volume.ToString();
            this.notifyIcon1.Icon = generateNotifyIcon();
        }

        private void contextMenuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            ToolStripItem clickedItem = e.ClickedItem;

            if (clickedItem == this.toolStripMenuItemExit)
            {
                this.Close();
            }
            else if(clickedItem == this.toolStripMenuItemOpenVolumeMixer)
            {
                openSndVol("-r ");
            }
            else if(clickedItem == this.toolStripMenuItemPlaybackDevices)
            {
                Process.Start("control.exe", "mmsys.cpl,,0");
            }
            else if(clickedItem == this.toolStripMenuItemRecordingDevices)
            {
                Process.Start("control.exe", "mmsys.cpl,,1");
            }
            else if(clickedItem == this.toolStripMenuItemSounds)
            {
                Process.Start("control.exe", "mmsys.cpl,,2");
            }
            else if (clickedItem == this.toolStripMenuItemVolumeControlOptions)
            {
                openSndVol("-p ");
            }
            else if (clickedItem == this.toolStripItemAbout)
            {
                contextMenuStrip1.Hide();
                AboutBox1 aboutBox = new AboutBox1();

                aboutBox.Left = Cursor.Position.X - aboutBox.Width / 2;
                aboutBox.Top = Cursor.Position.Y - aboutBox.Height;
                aboutBox.Show();
            }
        }
        #endregion

        #region Class Methods
        /// <summary>
        /// shows volume adjuster/mixer/settings window (depending on the arguments supplied) positioned above the tray notification icon
        /// </summary>
        private void openSndVol(string arg)
        {
            this.Hide();

            this.Left = Cursor.Position.X;
            this.Top = Cursor.Position.Y - this.Height;

            Process volTrack = new Process();
            volTrack.StartInfo.WindowStyle = ProcessWindowStyle.Normal;
            volTrack.StartInfo.FileName = "sndvol.exe";

            // position relative to the tray icon
            int notifyIconPos = this.Top * 65536 + this.Left;

            // open volume process & position it above the tray icon
            volTrack.StartInfo.Arguments = arg + notifyIconPos.ToString();

            volTrack.Start();
        }

        /// <summary>
        /// Generates custom text-like tray icon showing the current master volume percentage
        /// </summary>
        /// <returns>icon generated (Icon object)</returns>
        private Icon generateNotifyIcon()
        {
            using (Bitmap bitmap = new Bitmap(16, 16))
            {
                using (Graphics graphics = Graphics.FromImage(bitmap))
                {
                    graphics.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SingleBitPerPixelGridFit;
                    graphics.DrawIcon(Properties.Resources.notifyIconTemplate, 0, 0);

                    // ajusts string's top left position between fonts Arial and Webdings to maintain vertical center alignment on system tray
                    graphics.DrawString(this.volumeString, this.drawFont, this.drawBrush, 1, this.drawFont.Name == "Webdings" ? -1 : 1);

                    using (Icon createdIcon = Icon.FromHandle(bitmap.GetHicon()))
                    {
                        return createdIcon;
                    }
                }
            }
        }

        private void mute()
        {
            this.defaultPlaybackDevice.Mute(true);

            this.notifyIcon1.Text = "Speakers: Muted";
            this.drawFont = new Font("Webdings", 10, FontStyle.Regular);
            this.drawBrush = new SolidBrush(Color.Red);
            this.volumeString = "x"; // Webdings equivalent of "x" is 'no symbol' " ⃠" unicode U+20E0

            this.notifyIcon1.Icon = generateNotifyIcon();

            this.notifyIcon1.ShowBalloonTip(2, "VolPI", "Master volume muted.", ToolTipIcon.Warning);
        }

        private void unmute()
        {
            this.defaultPlaybackDevice.Mute(false);

            this.notifyIcon1.Text = "Speakers: " + this.defaultPlaybackDevice.Volume + "%";
            this.drawFont = new Font("Arial", 8, FontStyle.Regular);
            this.drawBrush = new SolidBrush(Color.White);
            this.volumeString = this.defaultPlaybackDevice.Volume.ToString();

            this.notifyIcon1.Icon = generateNotifyIcon();

            this.notifyIcon1.ShowBalloonTip(2, "VolPI", "Master volume unmuted.", ToolTipIcon.Info);
        }
        #endregion

        #region Class Fields

        /// <summary>
        /// volume control object
        /// courtesy of Audio Switcher Core Audio API (NuGet package)
        /// </summary>
        CoreAudioDevice defaultPlaybackDevice = new CoreAudioController().DefaultPlaybackDevice;

        /// <summary>
        /// volume change event object
        /// courtesy of NAudio Core Audio API (NuGet package)
        /// </summary>
        private MMDevice mmdevice = (MMDevice) new MMDeviceEnumerator().GetDefaultAudioEndpoint(DataFlow.Render, Role.Multimedia);
        private static MMDeviceEnumerator enumer = new MMDeviceEnumerator();

        /// <summary>
        /// dynamic custom notify icon stuff
        /// </summary>
        private Font drawFont = new Font("Arial", 8, FontStyle.Regular);
        private SolidBrush drawBrush = new SolidBrush(Color.White);
        private string volumeString = "NaN";

        #endregion
    }
}
