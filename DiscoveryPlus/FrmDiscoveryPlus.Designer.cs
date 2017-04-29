namespace DiscoveryPlus
{
    partial class FrmDiscoveryPlus
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDiscoveryPlus));
            this.textBoxAPIKey = new System.Windows.Forms.TextBox();
            this.labelAPIKey = new System.Windows.Forms.Label();
            this.btnSubmitLogin = new System.Windows.Forms.Button();
            this.lblDisplayName = new System.Windows.Forms.Label();
            this.checkBoxRemindMe = new System.Windows.Forms.CheckBox();
            this.lblFollowers = new System.Windows.Forms.Label();
            this.btnLogout = new System.Windows.Forms.Button();
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.listBoxPlaylists = new System.Windows.Forms.ListBox();
            this.listBoxTracks = new System.Windows.Forms.ListBox();
            this.textBoxSerach = new System.Windows.Forms.TextBox();
            this.pictureBoxUserProfile = new System.Windows.Forms.PictureBox();
            this.lblPlaylistCount = new System.Windows.Forms.Label();
            this.lblSavedTracksCount = new System.Windows.Forms.Label();
            this.lblSavedTracksTotalCount = new System.Windows.Forms.Label();
            this.listBoxFriends = new System.Windows.Forms.ListBox();
            this.lblPlaylistName = new System.Windows.Forms.Label();
            this.pictureBoxPlaylistImage = new System.Windows.Forms.PictureBox();
            this.lblPlaylistAccessor = new System.Windows.Forms.Label();
            this.lblTrackPopularity = new System.Windows.Forms.Label();
            this.pictureBoxTrackImage = new System.Windows.Forms.PictureBox();
            this.lblTrackName = new System.Windows.Forms.Label();
            this.lblArtist = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUserProfile)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPlaylistImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTrackImage)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxAPIKey
            // 
            this.textBoxAPIKey.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxAPIKey.Location = new System.Drawing.Point(40, 187);
            this.textBoxAPIKey.Name = "textBoxAPIKey";
            this.textBoxAPIKey.Size = new System.Drawing.Size(203, 20);
            this.textBoxAPIKey.TabIndex = 0;
            this.textBoxAPIKey.TextChanged += new System.EventHandler(this.textBoxAPIKey_TextChanged);
            // 
            // labelAPIKey
            // 
            this.labelAPIKey.AutoSize = true;
            this.labelAPIKey.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAPIKey.Location = new System.Drawing.Point(37, 168);
            this.labelAPIKey.Name = "labelAPIKey";
            this.labelAPIKey.Size = new System.Drawing.Size(61, 16);
            this.labelAPIKey.TabIndex = 2;
            this.labelAPIKey.Text = "API key";
            // 
            // btnSubmitLogin
            // 
            this.btnSubmitLogin.Location = new System.Drawing.Point(74, 213);
            this.btnSubmitLogin.Name = "btnSubmitLogin";
            this.btnSubmitLogin.Size = new System.Drawing.Size(75, 23);
            this.btnSubmitLogin.TabIndex = 3;
            this.btnSubmitLogin.Text = "Submit";
            this.btnSubmitLogin.UseVisualStyleBackColor = true;
            this.btnSubmitLogin.Click += new System.EventHandler(this.btnSubmitLogin_Click);
            // 
            // lblDisplayName
            // 
            this.lblDisplayName.AutoSize = true;
            this.lblDisplayName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Bold);
            this.lblDisplayName.Location = new System.Drawing.Point(762, 3);
            this.lblDisplayName.Name = "lblDisplayName";
            this.lblDisplayName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblDisplayName.Size = new System.Drawing.Size(138, 20);
            this.lblDisplayName.TabIndex = 4;
            this.lblDisplayName.Text = "IncredibleMarlz";
            this.lblDisplayName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // checkBoxRemindMe
            // 
            this.checkBoxRemindMe.AutoSize = true;
            this.checkBoxRemindMe.Location = new System.Drawing.Point(155, 217);
            this.checkBoxRemindMe.Name = "checkBoxRemindMe";
            this.checkBoxRemindMe.Size = new System.Drawing.Size(79, 17);
            this.checkBoxRemindMe.TabIndex = 5;
            this.checkBoxRemindMe.Text = "Remind me";
            this.checkBoxRemindMe.UseVisualStyleBackColor = true;
            // 
            // lblFollowers
            // 
            this.lblFollowers.AutoSize = true;
            this.lblFollowers.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Bold);
            this.lblFollowers.Location = new System.Drawing.Point(819, 23);
            this.lblFollowers.Name = "lblFollowers";
            this.lblFollowers.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblFollowers.Size = new System.Drawing.Size(81, 16);
            this.lblFollowers.TabIndex = 6;
            this.lblFollowers.Text = "x followers";
            this.lblFollowers.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(906, 109);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(100, 23);
            this.btnLogout.TabIndex = 7;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.BackgroundImage = global::DiscoveryPlus.Properties.Resources.Spotify_256;
            this.pictureBoxLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBoxLogo.Location = new System.Drawing.Point(60, 10);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(162, 154);
            this.pictureBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxLogo.TabIndex = 8;
            this.pictureBoxLogo.TabStop = false;
            // 
            // listBoxPlaylists
            // 
            this.listBoxPlaylists.BackColor = System.Drawing.SystemColors.Control;
            this.listBoxPlaylists.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBoxPlaylists.FormattingEnabled = true;
            this.listBoxPlaylists.Location = new System.Drawing.Point(11, 10);
            this.listBoxPlaylists.Name = "listBoxPlaylists";
            this.listBoxPlaylists.Size = new System.Drawing.Size(138, 702);
            this.listBoxPlaylists.TabIndex = 9;
            this.listBoxPlaylists.SelectedIndexChanged += new System.EventHandler(this.listBoxPlaylists_SelectedIndexChanged);
            // 
            // listBoxTracks
            // 
            this.listBoxTracks.BackColor = System.Drawing.SystemColors.Control;
            this.listBoxTracks.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBoxTracks.FormattingEnabled = true;
            this.listBoxTracks.Location = new System.Drawing.Point(155, 114);
            this.listBoxTracks.Name = "listBoxTracks";
            this.listBoxTracks.Size = new System.Drawing.Size(160, 598);
            this.listBoxTracks.TabIndex = 10;
            this.listBoxTracks.SelectedIndexChanged += new System.EventHandler(this.listBoxTracks_SelectedIndexChanged);
            // 
            // textBoxSerach
            // 
            this.textBoxSerach.Location = new System.Drawing.Point(155, 90);
            this.textBoxSerach.Name = "textBoxSerach";
            this.textBoxSerach.Size = new System.Drawing.Size(160, 20);
            this.textBoxSerach.TabIndex = 11;
            // 
            // pictureBoxUserProfile
            // 
            this.pictureBoxUserProfile.BackgroundImage = global::DiscoveryPlus.Properties.Resources.Spotify_256;
            this.pictureBoxUserProfile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBoxUserProfile.Location = new System.Drawing.Point(906, 3);
            this.pictureBoxUserProfile.Name = "pictureBoxUserProfile";
            this.pictureBoxUserProfile.Size = new System.Drawing.Size(100, 100);
            this.pictureBoxUserProfile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxUserProfile.TabIndex = 12;
            this.pictureBoxUserProfile.TabStop = false;
            // 
            // lblPlaylistCount
            // 
            this.lblPlaylistCount.AutoSize = true;
            this.lblPlaylistCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlaylistCount.Location = new System.Drawing.Point(837, 53);
            this.lblPlaylistCount.Name = "lblPlaylistCount";
            this.lblPlaylistCount.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblPlaylistCount.Size = new System.Drawing.Size(62, 13);
            this.lblPlaylistCount.TabIndex = 13;
            this.lblPlaylistCount.Text = "x playlists";
            this.lblPlaylistCount.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblSavedTracksCount
            // 
            this.lblSavedTracksCount.AutoSize = true;
            this.lblSavedTracksCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSavedTracksCount.Location = new System.Drawing.Point(810, 66);
            this.lblSavedTracksCount.Name = "lblSavedTracksCount";
            this.lblSavedTracksCount.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblSavedTracksCount.Size = new System.Drawing.Size(90, 13);
            this.lblSavedTracksCount.TabIndex = 14;
            this.lblSavedTracksCount.Text = "x saved tracks";
            this.lblSavedTracksCount.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblSavedTracksTotalCount
            // 
            this.lblSavedTracksTotalCount.AutoSize = true;
            this.lblSavedTracksTotalCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSavedTracksTotalCount.Location = new System.Drawing.Point(818, 79);
            this.lblSavedTracksTotalCount.Name = "lblSavedTracksTotalCount";
            this.lblSavedTracksTotalCount.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblSavedTracksTotalCount.Size = new System.Drawing.Size(81, 13);
            this.lblSavedTracksTotalCount.TabIndex = 15;
            this.lblSavedTracksTotalCount.Text = "x tracks total";
            this.lblSavedTracksTotalCount.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // listBoxFriends
            // 
            this.listBoxFriends.FormattingEnabled = true;
            this.listBoxFriends.Location = new System.Drawing.Point(906, 138);
            this.listBoxFriends.Name = "listBoxFriends";
            this.listBoxFriends.Size = new System.Drawing.Size(100, 589);
            this.listBoxFriends.TabIndex = 16;
            // 
            // lblPlaylistName
            // 
            this.lblPlaylistName.AutoSize = true;
            this.lblPlaylistName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Bold);
            this.lblPlaylistName.Location = new System.Drawing.Point(240, 9);
            this.lblPlaylistName.Name = "lblPlaylistName";
            this.lblPlaylistName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblPlaylistName.Size = new System.Drawing.Size(116, 20);
            this.lblPlaylistName.TabIndex = 17;
            this.lblPlaylistName.Text = "Playlistname";
            this.lblPlaylistName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pictureBoxPlaylistImage
            // 
            this.pictureBoxPlaylistImage.BackgroundImage = global::DiscoveryPlus.Properties.Resources.Spotify_256;
            this.pictureBoxPlaylistImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBoxPlaylistImage.Location = new System.Drawing.Point(155, 10);
            this.pictureBoxPlaylistImage.Name = "pictureBoxPlaylistImage";
            this.pictureBoxPlaylistImage.Size = new System.Drawing.Size(79, 74);
            this.pictureBoxPlaylistImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxPlaylistImage.TabIndex = 18;
            this.pictureBoxPlaylistImage.TabStop = false;
            // 
            // lblPlaylistAccessor
            // 
            this.lblPlaylistAccessor.AutoSize = true;
            this.lblPlaylistAccessor.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlaylistAccessor.Location = new System.Drawing.Point(240, 29);
            this.lblPlaylistAccessor.Name = "lblPlaylistAccessor";
            this.lblPlaylistAccessor.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblPlaylistAccessor.Size = new System.Drawing.Size(132, 13);
            this.lblPlaylistAccessor.TabIndex = 19;
            this.lblPlaylistAccessor.Text = "Public/Private Playlist";
            this.lblPlaylistAccessor.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTrackPopularity
            // 
            this.lblTrackPopularity.AutoSize = true;
            this.lblTrackPopularity.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTrackPopularity.Location = new System.Drawing.Point(422, 129);
            this.lblTrackPopularity.Name = "lblTrackPopularity";
            this.lblTrackPopularity.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblTrackPopularity.Size = new System.Drawing.Size(63, 13);
            this.lblTrackPopularity.TabIndex = 22;
            this.lblTrackPopularity.Text = "Popularity";
            this.lblTrackPopularity.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pictureBoxTrackImage
            // 
            this.pictureBoxTrackImage.BackgroundImage = global::DiscoveryPlus.Properties.Resources.Spotify_256;
            this.pictureBoxTrackImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBoxTrackImage.Location = new System.Drawing.Point(336, 90);
            this.pictureBoxTrackImage.Name = "pictureBoxTrackImage";
            this.pictureBoxTrackImage.Size = new System.Drawing.Size(79, 74);
            this.pictureBoxTrackImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxTrackImage.TabIndex = 21;
            this.pictureBoxTrackImage.TabStop = false;
            // 
            // lblTrackName
            // 
            this.lblTrackName.AutoSize = true;
            this.lblTrackName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Bold);
            this.lblTrackName.Location = new System.Drawing.Point(421, 89);
            this.lblTrackName.Name = "lblTrackName";
            this.lblTrackName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblTrackName.Size = new System.Drawing.Size(101, 20);
            this.lblTrackName.TabIndex = 20;
            this.lblTrackName.Text = "Trackname";
            this.lblTrackName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblArtist
            // 
            this.lblArtist.AutoSize = true;
            this.lblArtist.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.lblArtist.Location = new System.Drawing.Point(422, 109);
            this.lblArtist.Name = "lblArtist";
            this.lblArtist.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblArtist.Size = new System.Drawing.Size(70, 18);
            this.lblArtist.TabIndex = 23;
            this.lblArtist.Text = "by LULZ";
            this.lblArtist.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblArtist.Click += new System.EventHandler(this.label1_Click);
            // 
            // FrmDiscoveryPlus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 729);
            this.Controls.Add(this.lblArtist);
            this.Controls.Add(this.lblTrackPopularity);
            this.Controls.Add(this.pictureBoxTrackImage);
            this.Controls.Add(this.lblTrackName);
            this.Controls.Add(this.lblPlaylistAccessor);
            this.Controls.Add(this.pictureBoxPlaylistImage);
            this.Controls.Add(this.lblPlaylistName);
            this.Controls.Add(this.listBoxFriends);
            this.Controls.Add(this.lblSavedTracksTotalCount);
            this.Controls.Add(this.lblSavedTracksCount);
            this.Controls.Add(this.lblPlaylistCount);
            this.Controls.Add(this.pictureBoxUserProfile);
            this.Controls.Add(this.textBoxSerach);
            this.Controls.Add(this.listBoxTracks);
            this.Controls.Add(this.listBoxPlaylists);
            this.Controls.Add(this.pictureBoxLogo);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.lblFollowers);
            this.Controls.Add(this.checkBoxRemindMe);
            this.Controls.Add(this.lblDisplayName);
            this.Controls.Add(this.btnSubmitLogin);
            this.Controls.Add(this.labelAPIKey);
            this.Controls.Add(this.textBoxAPIKey);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmDiscoveryPlus";
            this.Text = "Discovery+";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUserProfile)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPlaylistImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTrackImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxAPIKey;
        private System.Windows.Forms.Label labelAPIKey;
        private System.Windows.Forms.Button btnSubmitLogin;
        private System.Windows.Forms.Label lblDisplayName;
        private System.Windows.Forms.CheckBox checkBoxRemindMe;
        private System.Windows.Forms.Label lblFollowers;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.PictureBox pictureBoxLogo;
        private System.Windows.Forms.ListBox listBoxPlaylists;
        private System.Windows.Forms.ListBox listBoxTracks;
        private System.Windows.Forms.TextBox textBoxSerach;
        private System.Windows.Forms.PictureBox pictureBoxUserProfile;
        private System.Windows.Forms.Label lblPlaylistCount;
        private System.Windows.Forms.Label lblSavedTracksCount;
        private System.Windows.Forms.Label lblSavedTracksTotalCount;
        private System.Windows.Forms.ListBox listBoxFriends;
        private System.Windows.Forms.Label lblPlaylistName;
        private System.Windows.Forms.PictureBox pictureBoxPlaylistImage;
        private System.Windows.Forms.Label lblPlaylistAccessor;
        private System.Windows.Forms.Label lblTrackPopularity;
        private System.Windows.Forms.PictureBox pictureBoxTrackImage;
        private System.Windows.Forms.Label lblTrackName;
        private System.Windows.Forms.Label lblArtist;
    }
}

