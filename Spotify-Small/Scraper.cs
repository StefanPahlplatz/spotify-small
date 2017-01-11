using System;
using System.Diagnostics;
using System.Linq;

namespace Spotify_Small
{
    public class Scraper
    {
        public string GetSpotifyTrackInfo()
        {
            // Get all spotify processes
            Process proc = Process.GetProcessesByName("Spotify").FirstOrDefault(p => !string.IsNullOrWhiteSpace(p.MainWindowTitle));

            if (proc == null)
                return "Spotify is not running!";

            if (string.Equals(proc.MainWindowTitle, "Spotify", StringComparison.InvariantCultureIgnoreCase))
                return "No track is playing";

            return proc.MainWindowTitle;
        }
    }
}
