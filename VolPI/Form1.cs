using System;
using System.Windows.Forms;
using AudioSwitcher.AudioApi.CoreAudio;
using System.Drawing;
using System.Diagnostics;

namespace VolPI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            this.InitializeComponent();
            this.notifyIcon1.Icon = generateNotifyIcon();
            
            this.notifyIcon1.Text += defaultPlaybackDevice.Volume + "%";
            this.Hide();
        }

        #region Events
        private void notifyIcon1_Click(object sender, EventArgs e)
        {
            showMasterMixer();
        }

        /// <summary>
        /// mutes master audio device when notify icon is double clicked
        /// </summary>
        private void notifyIcon1_DoubleClick(object sender, EventArgs e)
        {
            if (defaultPlaybackDevice.IsMuted)
            {
                defaultPlaybackDevice.Mute(false);
            }
            else
            {
                defaultPlaybackDevice.Mute(true);
            }
        }
        #endregion

        #region Class Methods
        /// <summary>
        /// shows volume adjuster/master mixer window position above the tray notification icon
        /// </summary>
        private void showMasterMixer()
        {
            this.Hide();

            this.Left = Cursor.Position.X;
            this.Top = Screen.PrimaryScreen.WorkingArea.Bottom - Height;

            Process volTrack = new Process();
            volTrack.StartInfo.WindowStyle = ProcessWindowStyle.Normal;
            volTrack.StartInfo.FileName = "sndvol.exe";

            int notifyIconPos = this.Top * 65536 + this.Left;

            volTrack.StartInfo.Arguments = "-f " + notifyIconPos.ToString();
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
                    graphics.DrawString(this.defaultPlaybackDevice.Volume.ToString(), drawFont, drawBrush, 1, 2);

                    using (Icon createdIcon = Icon.FromHandle(bitmap.GetHicon()))
                    {
                        return createdIcon;
                    }
                }
            }
        }
        #endregion

        #region Class Fields

        /// <summary>
        /// volume control object
        /// courtesy of Audio Switcher Core Audio 3.0.0.1 API (NuGet package)
        /// </summary>
        CoreAudioDevice defaultPlaybackDevice = new CoreAudioController().DefaultPlaybackDevice;

        /// <summary>
        /// dynamic custom notify icon stuff
        /// </summary>
        private Font drawFont = new Font("Arial", 8, FontStyle.Regular);
        public static SolidBrush drawBrush = new SolidBrush(Color.White);

        #endregion
    }
}
