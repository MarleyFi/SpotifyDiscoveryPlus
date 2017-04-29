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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
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
            this.lblDisplayName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold);
            this.lblDisplayName.Location = new System.Drawing.Point(902, 10);
            this.lblDisplayName.Name = "lblDisplayName";
            this.lblDisplayName.Size = new System.Drawing.Size(69, 17);
            this.lblDisplayName.TabIndex = 4;
            this.lblDisplayName.Text = "<NAME>";
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
            this.lblFollowers.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFollowers.Location = new System.Drawing.Point(874, 27);
            this.lblFollowers.Name = "lblFollowers";
            this.lblFollowers.Size = new System.Drawing.Size(97, 13);
            this.lblFollowers.TabIndex = 6;
            this.lblFollowers.Text = "<FOLLOWERS>";
            this.lblFollowers.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(977, 10);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(29, 30);
            this.btnLogout.TabIndex = 7;
            this.btnLogout.Text = "OFF";
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
            this.listBoxPlaylists.Location = new System.Drawing.Point(285, 10);
            this.listBoxPlaylists.Name = "listBoxPlaylists";
            this.listBoxPlaylists.Size = new System.Drawing.Size(138, 403);
            this.listBoxPlaylists.TabIndex = 9;
            // 
            // FrmDiscoveryPlus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 729);
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
    }
}

