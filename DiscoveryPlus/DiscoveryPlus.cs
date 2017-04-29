using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiscoveryPlus
{
    class DiscoveryPlus
    {
        public static Properties.Settings Settings;

        public Spotify Spotify;

        public bool isLoggedIn = false;

        public DiscoveryPlus()
        {
            Settings = Properties.Settings.Default;
            Spotify = new Spotify();

            if (Settings.SpotifyAPIKey != "" && Settings.AutoLogin)
                isLoggedIn = Login();

            if (isLoggedIn)
            {
                Init();
            }
        }

        public bool Login(string apiKey = null)
        {
            if(apiKey == null)
            {
                apiKey = Settings.SpotifyAPIKey;
            }
            isLoggedIn = Spotify.RunAuthentication(apiKey);
            return isLoggedIn;
        }

        private void Init()
        {

        }

    }
}
