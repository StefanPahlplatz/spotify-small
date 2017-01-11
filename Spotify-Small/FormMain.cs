using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Spotify_Small
{
    public partial class FormMain : Form
    {
        [DllImport("user32.dll", SetLastError = true)]
        private static extern void keybd_event(byte virtualKey, byte scanCode, uint flags, IntPtr extraInfo);
        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        private const int VK_MEDIA_NEXT_TRACK = 0xB0;        // Next
        private const int VK_MEDIA_PLAY_PAUSE = 0xB3;        // Pause
        private const int VK_MEDIA_PREV_TRACK = 0xB1;        // Previous
        private const int KEYEVENTF_EXTENDEDKEY = 0x0001;    // Key down flag
        private const int KEYEVENTF_KEYUP = 0x0002;          // Key up flag

        private const int WM_NCLBUTTONDOWN = 0xA1;
        private const int HT_CAPTION = 0x2;

        // Scraper to get the spotify status
        private Scraper scraper;

        public FormMain()
        {
            InitializeComponent();
            this.TopMost = true;

            // Create scraper
            scraper = new Scraper();

            // Create timer to update the spotify title
            Timer t = new Timer();
            t.Interval = 1000 / 14;
            t.Enabled = true;
            t.Tick += T_Tick;
        }

        // Update the label
        private void T_Tick(object sender, EventArgs e)
        {
            lb_CurrentSong.Text = scraper.GetSpotifyTrackInfo(); 
        }

        // Previous song
        private void PrevSong(object sender, MouseEventArgs e)
        {
            keybd_event(VK_MEDIA_PREV_TRACK, 0, KEYEVENTF_EXTENDEDKEY, IntPtr.Zero);
            keybd_event(VK_MEDIA_PREV_TRACK, 0, KEYEVENTF_KEYUP, IntPtr.Zero);
        }

        // Next song
        private void NextSong(object sender, MouseEventArgs e)
        {
            keybd_event(VK_MEDIA_NEXT_TRACK, 0, KEYEVENTF_EXTENDEDKEY, IntPtr.Zero);
            keybd_event(VK_MEDIA_NEXT_TRACK, 0, KEYEVENTF_KEYUP, IntPtr.Zero);
        }

        // Pause song
        private void PauseSong(object sender, MouseEventArgs e)
        {
            keybd_event(VK_MEDIA_PLAY_PAUSE, 0, KEYEVENTF_EXTENDEDKEY, IntPtr.Zero);
            keybd_event(VK_MEDIA_PLAY_PAUSE, 0, KEYEVENTF_KEYUP, IntPtr.Zero);
        }

        // Drag the form around
        private void FormMain_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        // Exit
        private void lb_Exit_MouseClick(object sender, MouseEventArgs e)
        {
            Application.Exit();
        }

        // Toggle 'always on top'
        private void lb_AlwaysOnTop_MouseClick(object sender, MouseEventArgs e)
        {
            this.TopMost = !this.TopMost;
            lb_AlwaysOnTop.Text = this.TopMost ? "Always on top: ON" : "Always on top: OFF";
        }
    }
}
