using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
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

        public DataSet Data = new DataSet();

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
            Data.Tables.Add(CreatePlaylistTable());
            //FillDataTable(Data.Tables[Tbl.Playlist], Spotify.playlists);
        }

        private DataTable CreatePlaylistTable()
        {
            DataTable dt = new DataTable(Tbl.Playlist);
            dt.Columns.Add(new DataColumn("Image", typeof(Image)));
            dt.Columns.Add(new DataColumn("Name", typeof(string)));
            dt.Columns.Add(new DataColumn("IsPublic", typeof(bool)));
            return dt;
        }

        private void FillDataTable(DataTable dt, IEnumerable<Type> data)
        {
            DataColumnCollection colums = dt.Columns;
            foreach (DataColumn cln in colums)
            {
                var rows = data.Select(obj => obj.GetProperty(cln.ColumnName)).ToArray();
            }
        }

    }
}
