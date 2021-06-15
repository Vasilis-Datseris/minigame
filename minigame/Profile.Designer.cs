
using System.Drawing;

namespace minigame
{
    partial class Profile
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Profile));
            this.SidePanel = new System.Windows.Forms.Panel();
            this.Images = new System.Windows.Forms.Panel();
            this.LogoutPicture = new System.Windows.Forms.PictureBox();
            this.ProfilePicture = new System.Windows.Forms.PictureBox();
            this.GamesPicture = new System.Windows.Forms.PictureBox();
            this.ScoresPicture = new System.Windows.Forms.PictureBox();
            this.Navigation = new System.Windows.Forms.Panel();
            this.Logout = new System.Windows.Forms.Button();
            this.ProfileButton = new System.Windows.Forms.Button();
            this.ScoresButton = new System.Windows.Forms.Button();
            this.GamesButton = new System.Windows.Forms.Button();
            this.ProfilePanel = new System.Windows.Forms.Panel();
            this.UsernameLabel = new System.Windows.Forms.Label();
            this.PictureButton = new minigame.Details();
            this.HeadLabel = new System.Windows.Forms.Label();
            this.Testlabel = new System.Windows.Forms.Label();
            this.LoaderForm = new System.Windows.Forms.Panel();
            this.NameLabel = new System.Windows.Forms.Label();
            this.DarkMode = new minigame.ToggleCheckbox();
            this.Close = new System.Windows.Forms.Button();
            this.Minimize = new System.Windows.Forms.Button();
            this.Maximize = new System.Windows.Forms.Button();
            this.SidePanel.SuspendLayout();
            this.Images.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LogoutPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProfilePicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GamesPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ScoresPicture)).BeginInit();
            this.ProfilePanel.SuspendLayout();
            this.LoaderForm.SuspendLayout();
            this.SuspendLayout();
            // 
            // SidePanel
            // 
            this.SidePanel.BackColor = System.Drawing.Color.MidnightBlue;
            this.SidePanel.Controls.Add(this.Images);
            this.SidePanel.Controls.Add(this.Navigation);
            this.SidePanel.Controls.Add(this.Logout);
            this.SidePanel.Controls.Add(this.ProfileButton);
            this.SidePanel.Controls.Add(this.ScoresButton);
            this.SidePanel.Controls.Add(this.GamesButton);
            this.SidePanel.Controls.Add(this.ProfilePanel);
            this.SidePanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.SidePanel.Location = new System.Drawing.Point(0, 0);
            this.SidePanel.Name = "SidePanel";
            this.SidePanel.Size = new System.Drawing.Size(255, 1000);
            this.SidePanel.TabIndex = 17;
            // 
            // Images
            // 
            this.Images.Controls.Add(this.LogoutPicture);
            this.Images.Controls.Add(this.ProfilePicture);
            this.Images.Controls.Add(this.GamesPicture);
            this.Images.Controls.Add(this.ScoresPicture);
            this.Images.Location = new System.Drawing.Point(73, 588);
            this.Images.Name = "Images";
            this.Images.Size = new System.Drawing.Size(142, 106);
            this.Images.TabIndex = 5;
            // 
            // LogoutPicture
            // 
            this.LogoutPicture.BackColor = System.Drawing.Color.Transparent;
            this.LogoutPicture.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("LogoutPicture.BackgroundImage")));
            this.LogoutPicture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.LogoutPicture.Dock = System.Windows.Forms.DockStyle.Right;
            this.LogoutPicture.Location = new System.Drawing.Point(42, 0);
            this.LogoutPicture.Name = "LogoutPicture";
            this.LogoutPicture.Size = new System.Drawing.Size(100, 106);
            this.LogoutPicture.TabIndex = 5;
            this.LogoutPicture.TabStop = false;
            // 
            // ProfilePicture
            // 
            this.ProfilePicture.BackColor = System.Drawing.Color.Transparent;
            this.ProfilePicture.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ProfilePicture.BackgroundImage")));
            this.ProfilePicture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ProfilePicture.Dock = System.Windows.Forms.DockStyle.Left;
            this.ProfilePicture.Location = new System.Drawing.Point(200, 0);
            this.ProfilePicture.Name = "ProfilePicture";
            this.ProfilePicture.Size = new System.Drawing.Size(100, 106);
            this.ProfilePicture.TabIndex = 4;
            this.ProfilePicture.TabStop = false;
            // 
            // GamesPicture
            // 
            this.GamesPicture.BackColor = System.Drawing.Color.Transparent;
            this.GamesPicture.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("GamesPicture.BackgroundImage")));
            this.GamesPicture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.GamesPicture.Dock = System.Windows.Forms.DockStyle.Left;
            this.GamesPicture.Location = new System.Drawing.Point(100, 0);
            this.GamesPicture.Name = "GamesPicture";
            this.GamesPicture.Size = new System.Drawing.Size(100, 106);
            this.GamesPicture.TabIndex = 2;
            this.GamesPicture.TabStop = false;
            // 
            // ScoresPicture
            // 
            this.ScoresPicture.BackColor = System.Drawing.Color.Transparent;
            this.ScoresPicture.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ScoresPicture.BackgroundImage")));
            this.ScoresPicture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ScoresPicture.Dock = System.Windows.Forms.DockStyle.Left;
            this.ScoresPicture.Location = new System.Drawing.Point(0, 0);
            this.ScoresPicture.Name = "ScoresPicture";
            this.ScoresPicture.Size = new System.Drawing.Size(100, 106);
            this.ScoresPicture.TabIndex = 3;
            this.ScoresPicture.TabStop = false;
            // 
            // Navigation
            // 
            this.Navigation.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.Navigation.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.Navigation.Location = new System.Drawing.Point(0, 230);
            this.Navigation.Name = "Navigation";
            this.Navigation.Size = new System.Drawing.Size(5, 150);
            this.Navigation.TabIndex = 18;
            // 
            // Logout
            // 
            this.Logout.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Logout.FlatAppearance.BorderSize = 0;
            this.Logout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Logout.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Logout.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.Logout.Location = new System.Drawing.Point(0, 930);
            this.Logout.Name = "Logout";
            this.Logout.Size = new System.Drawing.Size(255, 70);
            this.Logout.TabIndex = 7;
            this.Logout.Text = "Logout";
            this.Logout.UseVisualStyleBackColor = true;
            this.Logout.Click += new System.EventHandler(this.Logout_Click);
            // 
            // ProfileButton
            // 
            this.ProfileButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.ProfileButton.FlatAppearance.BorderSize = 0;
            this.ProfileButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ProfileButton.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProfileButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.ProfileButton.Location = new System.Drawing.Point(0, 340);
            this.ProfileButton.Name = "ProfileButton";
            this.ProfileButton.Size = new System.Drawing.Size(255, 70);
            this.ProfileButton.TabIndex = 3;
            this.ProfileButton.Text = "Profile";
            this.ProfileButton.UseVisualStyleBackColor = true;
            this.ProfileButton.Click += new System.EventHandler(this.ProfileButton_Click);
            // 
            // ScoresButton
            // 
            this.ScoresButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ScoresButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.ScoresButton.FlatAppearance.BorderSize = 0;
            this.ScoresButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ScoresButton.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ScoresButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.ScoresButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ScoresButton.Location = new System.Drawing.Point(0, 270);
            this.ScoresButton.Name = "ScoresButton";
            this.ScoresButton.Size = new System.Drawing.Size(255, 70);
            this.ScoresButton.TabIndex = 2;
            this.ScoresButton.Text = "Scores";
            this.ScoresButton.UseVisualStyleBackColor = true;
            this.ScoresButton.Click += new System.EventHandler(this.ScoresButton_Click);
            // 
            // GamesButton
            // 
            this.GamesButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.GamesButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.GamesButton.FlatAppearance.BorderSize = 0;
            this.GamesButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GamesButton.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GamesButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.GamesButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.GamesButton.Location = new System.Drawing.Point(0, 200);
            this.GamesButton.Name = "GamesButton";
            this.GamesButton.Size = new System.Drawing.Size(255, 70);
            this.GamesButton.TabIndex = 1;
            this.GamesButton.Text = "Games";
            this.GamesButton.UseVisualStyleBackColor = true;
            this.GamesButton.Click += new System.EventHandler(this.GamesButton_Click);
            this.GamesButton.Enter += new System.EventHandler(this.GamesButton_Enter);
            // 
            // ProfilePanel
            // 
            this.ProfilePanel.Controls.Add(this.UsernameLabel);
            this.ProfilePanel.Controls.Add(this.PictureButton);
            this.ProfilePanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.ProfilePanel.Location = new System.Drawing.Point(0, 0);
            this.ProfilePanel.Name = "ProfilePanel";
            this.ProfilePanel.Size = new System.Drawing.Size(255, 200);
            this.ProfilePanel.TabIndex = 0;
            // 
            // UsernameLabel
            // 
            this.UsernameLabel.AutoSize = true;
            this.UsernameLabel.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsernameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.UsernameLabel.Location = new System.Drawing.Point(56, 119);
            this.UsernameLabel.Name = "UsernameLabel";
            this.UsernameLabel.Size = new System.Drawing.Size(129, 32);
            this.UsernameLabel.TabIndex = 1;
            this.UsernameLabel.Text = "Username";
            this.UsernameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PictureButton
            // 
            this.PictureButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PictureButton.BackgroundImage")));
            this.PictureButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.PictureButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PictureButton.Location = new System.Drawing.Point(73, 16);
            this.PictureButton.Name = "PictureButton";
            this.PictureButton.Size = new System.Drawing.Size(100, 100);
            this.PictureButton.TabIndex = 0;
            this.PictureButton.UseVisualStyleBackColor = true;
            this.PictureButton.Click += new System.EventHandler(this.PictureButton_Click);
            // 
            // HeadLabel
            // 
            this.HeadLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.HeadLabel.AutoSize = true;
            this.HeadLabel.BackColor = System.Drawing.Color.Transparent;
            this.HeadLabel.Font = new System.Drawing.Font("Malgun Gothic", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HeadLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.HeadLabel.Location = new System.Drawing.Point(478, 35);
            this.HeadLabel.Name = "HeadLabel";
            this.HeadLabel.Size = new System.Drawing.Size(173, 45);
            this.HeadLabel.TabIndex = 2;
            this.HeadLabel.Text = "Username";
            this.HeadLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Testlabel
            // 
            this.Testlabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Testlabel.AutoSize = true;
            this.Testlabel.BackColor = System.Drawing.Color.Transparent;
            this.Testlabel.Font = new System.Drawing.Font("Malgun Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Testlabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.Testlabel.Location = new System.Drawing.Point(511, 12);
            this.Testlabel.Name = "Testlabel";
            this.Testlabel.Size = new System.Drawing.Size(107, 28);
            this.Testlabel.TabIndex = 19;
            this.Testlabel.Text = "Username";
            this.Testlabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Testlabel.Visible = false;
            // 
            // LoaderForm
            // 
            this.LoaderForm.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LoaderForm.BackColor = System.Drawing.Color.Transparent;
            this.LoaderForm.Controls.Add(this.NameLabel);
            this.LoaderForm.Location = new System.Drawing.Point(257, 97);
            this.LoaderForm.Name = "LoaderForm";
            this.LoaderForm.Size = new System.Drawing.Size(650, 900);
            this.LoaderForm.TabIndex = 20;
            // 
            // NameLabel
            // 
            this.NameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.NameLabel.BackColor = System.Drawing.Color.Transparent;
            this.NameLabel.Font = new System.Drawing.Font("Malgun Gothic", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.NameLabel.Location = new System.Drawing.Point(221, 1);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(181, 45);
            this.NameLabel.TabIndex = 21;
            this.NameLabel.Text = "Username";
            this.NameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DarkMode
            // 
            this.DarkMode.BackColor = System.Drawing.Color.MidnightBlue;
            this.DarkMode.BorderColor = System.Drawing.Color.DarkGray;
            this.DarkMode.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DarkMode.ForeColor = System.Drawing.Color.White;
            this.DarkMode.IsOn = false;
            this.DarkMode.Location = new System.Drawing.Point(185, 3);
            this.DarkMode.Name = "DarkMode";
            this.DarkMode.OffColor = System.Drawing.Color.LightGray;
            this.DarkMode.OffText = "Light";
            this.DarkMode.OnColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.DarkMode.OnText = "Dark";
            this.DarkMode.Size = new System.Drawing.Size(70, 37);
            this.DarkMode.TabIndex = 18;
            this.DarkMode.TextEnabled = true;
            this.DarkMode.Click += new System.EventHandler(this.DarkMode_Click_1);
            // 
            // Close
            // 
            this.Close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Close.BackColor = System.Drawing.Color.Transparent;
            this.Close.BackgroundImage = global::minigame.Properties.Resources.Close_black;
            this.Close.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Close.FlatAppearance.BorderSize = 0;
            this.Close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Close.Location = new System.Drawing.Point(850, 0);
            this.Close.Name = "Close";
            this.Close.Size = new System.Drawing.Size(50, 50);
            this.Close.TabIndex = 19;
            this.Close.UseVisualStyleBackColor = false;
            this.Close.Click += new System.EventHandler(this.Close_Click);
            this.Close.MouseEnter += new System.EventHandler(this.Close_MouseEnter);
            this.Close.MouseLeave += new System.EventHandler(this.Close_MouseLeave);
            // 
            // Minimize
            // 
            this.Minimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Minimize.BackColor = System.Drawing.Color.Transparent;
            this.Minimize.BackgroundImage = global::minigame.Properties.Resources.minimize_window_black;
            this.Minimize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Minimize.FlatAppearance.BorderSize = 0;
            this.Minimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Minimize.Location = new System.Drawing.Point(751, -1);
            this.Minimize.Name = "Minimize";
            this.Minimize.Size = new System.Drawing.Size(50, 50);
            this.Minimize.TabIndex = 18;
            this.Minimize.UseVisualStyleBackColor = false;
            this.Minimize.Click += new System.EventHandler(this.Minimize_Click);
            this.Minimize.MouseEnter += new System.EventHandler(this.Minimize_MouseEnter);
            this.Minimize.MouseLeave += new System.EventHandler(this.Minimize_MouseLeave);
            // 
            // Maximize
            // 
            this.Maximize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Maximize.BackColor = System.Drawing.Color.Transparent;
            this.Maximize.BackgroundImage = global::minigame.Properties.Resources.maximize_window_black;
            this.Maximize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Maximize.FlatAppearance.BorderSize = 0;
            this.Maximize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Maximize.Location = new System.Drawing.Point(801, -1);
            this.Maximize.Name = "Maximize";
            this.Maximize.Size = new System.Drawing.Size(50, 50);
            this.Maximize.TabIndex = 17;
            this.Maximize.UseVisualStyleBackColor = false;
            this.Maximize.Click += new System.EventHandler(this.Maximize_Click);
            this.Maximize.MouseEnter += new System.EventHandler(this.Maximize_MouseEnter);
            this.Maximize.MouseLeave += new System.EventHandler(this.Maximize_MouseLeave);
            // 
            // Profile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(900, 1000);
            this.Controls.Add(this.Close);
            this.Controls.Add(this.Minimize);
            this.Controls.Add(this.LoaderForm);
            this.Controls.Add(this.Maximize);
            this.Controls.Add(this.Testlabel);
            this.Controls.Add(this.HeadLabel);
            this.Controls.Add(this.DarkMode);
            this.Controls.Add(this.SidePanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Profile";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Profile";
            this.Load += new System.EventHandler(this.Profile_Load);
            this.SidePanel.ResumeLayout(false);
            this.Images.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.LogoutPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProfilePicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GamesPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ScoresPicture)).EndInit();
            this.ProfilePanel.ResumeLayout(false);
            this.ProfilePanel.PerformLayout();
            this.LoaderForm.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel SidePanel;
        private System.Windows.Forms.Panel ProfilePanel;
        private Details PictureButton;
        private System.Windows.Forms.Label UsernameLabel;
        private System.Windows.Forms.Button GamesButton;
        private System.Windows.Forms.Button ProfileButton;
        private System.Windows.Forms.Button ScoresButton;
        private System.Windows.Forms.Button Logout;
        private System.Windows.Forms.Panel Navigation;
        private System.Windows.Forms.PictureBox GamesPicture;
        private System.Windows.Forms.PictureBox ProfilePicture;
        private System.Windows.Forms.PictureBox ScoresPicture;
        private System.Windows.Forms.Panel Images;
        private System.Windows.Forms.PictureBox LogoutPicture;
        private ToggleCheckbox DarkMode;
        private System.Windows.Forms.Label HeadLabel;
        private System.Windows.Forms.Label Testlabel;
        private System.Windows.Forms.Panel LoaderForm;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.Button Close;
        private System.Windows.Forms.Button Minimize;
        private System.Windows.Forms.Button Maximize;
    }
}