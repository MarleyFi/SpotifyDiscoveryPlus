using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SpotifyAPI.Web.Models;

namespace DiscoveryPlus
{
    public partial class FrmDiscoveryPlus : Form
    {
        DiscoveryPlus DiscoveryPlus;

        private SimplePlaylist selectedPlaylist;
        private Paging<PlaylistTrack> playlistTracks;
        private PlaylistTrack selectedTrack;

        public FrmDiscoveryPlus()
        {
            InitializeComponent();
            DiscoveryPlus = new DiscoveryPlus();
            SwitchLoginPage(DiscoveryPlus.isLoggedIn);
        }

        #region PageMethods

        private void SwitchLoginPage(bool isLoggedIn)
        {
            textBoxAPIKey.Visible = !isLoggedIn;
            labelAPIKey.Visible = !isLoggedIn;
            pictureBoxLogo.Visible = !isLoggedIn;
            btnSubmitLogin.Visible = !isLoggedIn;
            checkBoxRemindMe.Visible = !isLoggedIn;

            // ---------------------------------//

            this.Size = new Size(isLoggedIn ? 1024 : 300, isLoggedIn ? 758 : 300);

            // ------------Userprofile--------------//

            lblDisplayName.Visible = isLoggedIn;
            listBoxPlaylists.Visible = isLoggedIn;
            pictureBoxUserProfile.Visible = isLoggedIn;

            // ------------Playlists-------------//

            listBoxTracks.Visible = false;
            textBoxSerach.Visible = false;
            lblPlaylistName.Visible = false;
            lblPlaylistAccessor.Visible = false;
            pictureBoxPlaylistImage.Visible = false;

            // ------------Tracks--------------//

            lblTrackName.Visible = false;
            lblTrackPopularity.Visible = false;
            pictureBoxTrackImage.Visible = false;
            lblArtist.Visible = false;

            if (isLoggedIn)
            {
                InitLabels(DiscoveryPlus.Spotify.Profile);
                InitPlaylists(DiscoveryPlus.Spotify.playlists);
                pictureBoxUserProfile.LoadAsync(DiscoveryPlus.Spotify.Profile.Images.First().Url);
            }
        }

        #region Init

        private void InitLabels(PrivateProfile profile)
        {
            lblDisplayName.Text = profile.Id;
            lblFollowers.Text = profile.Followers.Total.ToString() + " followers";
            lblPlaylistCount.Text = DiscoveryPlus.Spotify.playlists.Count.ToString()+ " playlists";
            lblSavedTracksCount.Text = DiscoveryPlus.Spotify.savedTracks.Count.ToString() + "saved tracks";
        }

        private void InitPlaylists(List<SimplePlaylist> playlists)
        {
            listBoxPlaylists.DataSource = playlists.Select(playlist => playlist.Name).ToList();
            //dataGridViewPlaylists.DataSource = DiscoveryPlus.Data.Tables[Tbl.Playlist];
        }

        #endregion Init

        #endregion PageMethods

        private void FillPlaylistDetails(SimplePlaylist playlist)
        {
            listBoxTracks.Visible = true;
            textBoxSerach.Visible = true;
            lblPlaylistName.Visible = true;
            lblPlaylistAccessor.Visible = true;
            pictureBoxPlaylistImage.Visible = true;
            try
            {
                playlistTracks = DiscoveryPlus.Spotify.GetTracksOfPlaylist(playlist);
                listBoxTracks.DataSource = DiscoveryPlus.Spotify.GetTracksOfPlaylist(playlist).Items.Select(playlistItem => playlistItem.Track.Name).ToList();
                lblPlaylistName.Text = playlist.Name;
                lblPlaylistAccessor.Text = playlist.Public ? "Public playlist" : "Private playlist";
                pictureBoxPlaylistImage.LoadAsync(playlist.Images.First().Url);

            }
            catch (Exception)
            {
                listBoxTracks.DataSource = new string[] { "ERROR" };
                listBoxTracks.Visible = false;
            }
        }

        private void FillTrackDetails(PlaylistTrack playlistTrack)
        {
            lblTrackName.Visible = true;
            lblTrackPopularity.Visible = true;
            pictureBoxTrackImage.Visible = true;
            lblArtist.Visible = true;
            try
            {
                lblTrackName.Text = playlistTrack.Track.Name;
                pictureBoxTrackImage.LoadAsync(playlistTrack.Track.Album.Images.First().Url);
                lblTrackPopularity.Text = "Popularity: " + playlistTrack.Track.Popularity;
                lblArtist.Text = playlistTrack.Track.Artists.Join(", ");
                //FullTrack fTrack = DiscoveryPlus.Spotify.GetTrack(track.Id);
                //if (fTrack != null)
                //{
                //    pictureBoxTrackImage.LoadAsync(fTrack.Album.Images.First().Url);
                //    lblTrackPopularity.Text = "Popularity: " + fTrack.Popularity;
                //}
            }
            catch (Exception)
            {
            }
        }

        #region Events

        private void textBoxAPIKey_TextChanged(object sender, EventArgs e)
        {
            btnSubmitLogin.Enabled = (textBoxAPIKey.Text != "");
        }

        private void btnSubmitLogin_Click(object sender, EventArgs e)
        {
            string apiKey = textBoxAPIKey.Text;
            bool wasSuccessfull = this.DiscoveryPlus.Login(apiKey);
            SwitchLoginPage(wasSuccessfull);
            Properties.Settings.Default.AutoLogin = checkBoxRemindMe.Checked;
            Properties.Settings.Default.Save();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            SwitchLoginPage(false);
            textBoxAPIKey.Text = Properties.Settings.Default.SpotifyAPIKey;
        }

        private void listBoxPlaylists_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedPlaylist = DiscoveryPlus.Spotify.playlists.ElementAt(listBoxPlaylists.SelectedIndex);
            FillPlaylistDetails(selectedPlaylist);
        }
        #endregion Events

        private void listBoxTracks_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                selectedTrack = playlistTracks.Items.Where(playlistTrack => playlistTrack.Track.Name.Equals(listBoxTracks.SelectedItem.ToString())).First();
                FillTrackDetails(selectedTrack);
            }
            catch (Exception)
            {
                // Track is local
            }
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
