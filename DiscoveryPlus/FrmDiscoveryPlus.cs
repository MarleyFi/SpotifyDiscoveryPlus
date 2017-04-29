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
        public FrmDiscoveryPlus()
        {
            InitializeComponent();
            DiscoveryPlus = new DiscoveryPlus();
            SwitchLoginPage(DiscoveryPlus.isLoggedIn);
        }

        private void SwitchLoginPage(bool isLoggedIn)
        {
            textBoxAPIKey.Visible = !isLoggedIn;
            labelAPIKey.Visible = !isLoggedIn;
            pictureBoxLogo.Visible = !isLoggedIn;
            btnSubmitLogin.Visible = !isLoggedIn;
            checkBoxRemindMe.Visible = !isLoggedIn;

            // ---------------------------------//

            this.Size = new Size(isLoggedIn ? 1024 : 300, isLoggedIn ? 758 : 300);

            lblDisplayName.Visible = isLoggedIn;
            listBoxPlaylists.Visible = isLoggedIn;
            if (isLoggedIn)
            {
                InitLabels(DiscoveryPlus.Spotify.Profile);
                InitPlaylists(DiscoveryPlus.Spotify.playlists);
            }
        }

        private void InitLabels(PrivateProfile profile)
        {
            lblDisplayName.Text = profile.Id;
            lblFollowers.Text = profile.Followers.Total.ToString();

        }

        private void InitPlaylists(List<SimplePlaylist> playlists)
        {
            listBoxPlaylists.DataSource = playlists.Select(playlist => playlist.Name).ToList();
        }

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
    }
}
