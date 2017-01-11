using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Spotify_Small
{
    public partial class FormMain : Form
    {
        [DllImport("user32.dll", SetLastError = true)]
        private static extern void keybd_event(byte virtualKey, byte scanCode, uint flags, IntPtr extraInfo);

        private const int VK_MEDIA_NEXT_TRACK = 0xB0;        // Next
        private const int VK_MEDIA_PLAY_PAUSE = 0xB3;        // Pause
        private const int VK_MEDIA_PREV_TRACK = 0xB1;        // Previous
        private const int KEYEVENTF_EXTENDEDKEY = 0x0001;    // Key down flag
        private const int KEYEVENTF_KEYUP = 0x0002;          // Key up flag

        // Scraper to get the spotify status
        private Scraper scraper;

        public FormMain()
        {
            InitializeComponent();

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
    }
}
