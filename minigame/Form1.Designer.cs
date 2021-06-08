
namespace minigame
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.LoginGroupbox = new System.Windows.Forms.GroupBox();
            this.WrongCredentialsLabel = new System.Windows.Forms.Label();
            this.EmailTextbox = new System.Windows.Forms.TextBox();
            this.UsernameTextbox = new System.Windows.Forms.TextBox();
            this.EmailLabel = new System.Windows.Forms.Label();
            this.UsernameLabel = new System.Windows.Forms.Label();
            this.WrongUsername = new System.Windows.Forms.Label();
            this.WrongEmail = new System.Windows.Forms.Label();
            this.show = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.windowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.darkModeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.onToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Close = new System.Windows.Forms.Button();
            this.Minimize = new System.Windows.Forms.Button();
            this.Maximize = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rightPanel = new System.Windows.Forms.Panel();
            this.FacebookButton = new System.Windows.Forms.Button();
            this.GoogleButton = new System.Windows.Forms.Button();
            this.DarkMode = new minigame.ToggleCheckbox();
            this.LoginButton = new minigame.RoundButton();
            this.Signup = new minigame.RoundButton();
            this.GuestButton = new minigame.RoundButton();
            this.LoginGroupbox.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // LoginGroupbox
            // 
            this.LoginGroupbox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LoginGroupbox.BackColor = System.Drawing.Color.Transparent;
            this.LoginGroupbox.Controls.Add(this.WrongCredentialsLabel);
            this.LoginGroupbox.Controls.Add(this.LoginButton);
            this.LoginGroupbox.Controls.Add(this.Signup);
            this.LoginGroupbox.Controls.Add(this.EmailTextbox);
            this.LoginGroupbox.Controls.Add(this.UsernameTextbox);
            this.LoginGroupbox.Controls.Add(this.EmailLabel);
            this.LoginGroupbox.Controls.Add(this.UsernameLabel);
            this.LoginGroupbox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.LoginGroupbox.Font = new System.Drawing.Font("News706 BT", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginGroupbox.Location = new System.Drawing.Point(212, 44);
            this.LoginGroupbox.Name = "LoginGroupbox";
            this.LoginGroupbox.Size = new System.Drawing.Size(410, 498);
            this.LoginGroupbox.TabIndex = 6;
            this.LoginGroupbox.TabStop = false;
            this.LoginGroupbox.Text = "Log-in";
            // 
            // WrongCredentialsLabel
            // 
            this.WrongCredentialsLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.WrongCredentialsLabel.AutoSize = true;
            this.WrongCredentialsLabel.BackColor = System.Drawing.Color.Transparent;
            this.WrongCredentialsLabel.ForeColor = System.Drawing.Color.Firebrick;
            this.WrongCredentialsLabel.Location = new System.Drawing.Point(72, 220);
            this.WrongCredentialsLabel.Name = "WrongCredentialsLabel";
            this.WrongCredentialsLabel.Size = new System.Drawing.Size(398, 26);
            this.WrongCredentialsLabel.TabIndex = 12;
            this.WrongCredentialsLabel.Text = "Wrong Credentials, please try again.";
            this.WrongCredentialsLabel.Visible = false;
            // 
            // EmailTextbox
            // 
            this.EmailTextbox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.EmailTextbox.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.EmailTextbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.EmailTextbox.ForeColor = System.Drawing.Color.Gainsboro;
            this.EmailTextbox.Location = new System.Drawing.Point(189, 148);
            this.EmailTextbox.Name = "EmailTextbox";
            this.EmailTextbox.Size = new System.Drawing.Size(202, 34);
            this.EmailTextbox.TabIndex = 1;
            this.EmailTextbox.TextChanged += new System.EventHandler(this.EmailTextbox_TextChanged);
            // 
            // UsernameTextbox
            // 
            this.UsernameTextbox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.UsernameTextbox.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.UsernameTextbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.UsernameTextbox.ForeColor = System.Drawing.Color.Gainsboro;
            this.UsernameTextbox.Location = new System.Drawing.Point(189, 70);
            this.UsernameTextbox.Name = "UsernameTextbox";
            this.UsernameTextbox.Size = new System.Drawing.Size(202, 34);
            this.UsernameTextbox.TabIndex = 0;
            this.UsernameTextbox.TextChanged += new System.EventHandler(this.UsernameTextbox_TextChanged);
            // 
            // EmailLabel
            // 
            this.EmailLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.EmailLabel.AutoSize = true;
            this.EmailLabel.Font = new System.Drawing.Font("News706 BT", 11F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmailLabel.ForeColor = System.Drawing.Color.DimGray;
            this.EmailLabel.Location = new System.Drawing.Point(100, 150);
            this.EmailLabel.Name = "EmailLabel";
            this.EmailLabel.Size = new System.Drawing.Size(82, 26);
            this.EmailLabel.TabIndex = 1;
            this.EmailLabel.Text = "email: ";
            // 
            // UsernameLabel
            // 
            this.UsernameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.UsernameLabel.AutoSize = true;
            this.UsernameLabel.Font = new System.Drawing.Font("News706 BT", 11F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsernameLabel.ForeColor = System.Drawing.Color.DimGray;
            this.UsernameLabel.Location = new System.Drawing.Point(49, 71);
            this.UsernameLabel.Name = "UsernameLabel";
            this.UsernameLabel.Size = new System.Drawing.Size(133, 26);
            this.UsernameLabel.TabIndex = 0;
            this.UsernameLabel.Text = "Username: ";
            // 
            // WrongUsername
            // 
            this.WrongUsername.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.WrongUsername.AutoSize = true;
            this.WrongUsername.BackColor = System.Drawing.Color.Transparent;
            this.WrongUsername.ForeColor = System.Drawing.Color.Firebrick;
            this.WrongUsername.Location = new System.Drawing.Point(623, 121);
            this.WrongUsername.Name = "WrongUsername";
            this.WrongUsername.Size = new System.Drawing.Size(122, 20);
            this.WrongUsername.TabIndex = 10;
            this.WrongUsername.Text = "Characters Only";
            this.WrongUsername.Visible = false;
            // 
            // WrongEmail
            // 
            this.WrongEmail.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.WrongEmail.AutoSize = true;
            this.WrongEmail.BackColor = System.Drawing.Color.Transparent;
            this.WrongEmail.ForeColor = System.Drawing.Color.Firebrick;
            this.WrongEmail.Location = new System.Drawing.Point(623, 199);
            this.WrongEmail.Name = "WrongEmail";
            this.WrongEmail.Size = new System.Drawing.Size(179, 20);
            this.WrongEmail.TabIndex = 11;
            this.WrongEmail.Text = "Example@example.com";
            this.WrongEmail.Visible = false;
            // 
            // show
            // 
            this.show.AutoSize = true;
            this.show.BackColor = System.Drawing.Color.Transparent;
            this.show.Location = new System.Drawing.Point(337, 737);
            this.show.Name = "show";
            this.show.Size = new System.Drawing.Size(0, 20);
            this.show.TabIndex = 12;
            this.show.Visible = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.DimGray;
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.windowToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 36);
            this.menuStrip1.TabIndex = 13;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // windowToolStripMenuItem
            // 
            this.windowToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.darkModeToolStripMenuItem});
            this.windowToolStripMenuItem.Name = "windowToolStripMenuItem";
            this.windowToolStripMenuItem.Size = new System.Drawing.Size(94, 29);
            this.windowToolStripMenuItem.Text = "Window";
            // 
            // darkModeToolStripMenuItem
            // 
            this.darkModeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.onToolStripMenuItem});
            this.darkModeToolStripMenuItem.Name = "darkModeToolStripMenuItem";
            this.darkModeToolStripMenuItem.Size = new System.Drawing.Size(203, 34);
            this.darkModeToolStripMenuItem.Text = "Dark Mode";
            this.darkModeToolStripMenuItem.Click += new System.EventHandler(this.darkModeToolStripMenuItem_Click);
            // 
            // onToolStripMenuItem
            // 
            this.onToolStripMenuItem.BackColor = System.Drawing.Color.DimGray;
            this.onToolStripMenuItem.Name = "onToolStripMenuItem";
            this.onToolStripMenuItem.Size = new System.Drawing.Size(140, 34);
            this.onToolStripMenuItem.Text = "Off";
            // 
            // Close
            // 
            this.Close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Close.BackColor = System.Drawing.Color.Transparent;
            this.Close.BackgroundImage = global::minigame.Properties.Resources.Close_black;
            this.Close.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Close.FlatAppearance.BorderSize = 0;
            this.Close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Close.Location = new System.Drawing.Point(749, 0);
            this.Close.Name = "Close";
            this.Close.Size = new System.Drawing.Size(50, 50);
            this.Close.TabIndex = 16;
            this.Close.UseVisualStyleBackColor = false;
            this.Close.Click += new System.EventHandler(this.Close_Click);
            // 
            // Minimize
            // 
            this.Minimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Minimize.BackColor = System.Drawing.Color.Transparent;
            this.Minimize.BackgroundImage = global::minigame.Properties.Resources.minimize_window_black;
            this.Minimize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Minimize.FlatAppearance.BorderSize = 0;
            this.Minimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Minimize.Location = new System.Drawing.Point(649, -2);
            this.Minimize.Name = "Minimize";
            this.Minimize.Size = new System.Drawing.Size(50, 50);
            this.Minimize.TabIndex = 15;
            this.Minimize.UseVisualStyleBackColor = false;
            this.Minimize.Click += new System.EventHandler(this.Minimize_Click);
            // 
            // Maximize
            // 
            this.Maximize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Maximize.BackColor = System.Drawing.Color.Transparent;
            this.Maximize.BackgroundImage = global::minigame.Properties.Resources.maximize_window_black;
            this.Maximize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Maximize.FlatAppearance.BorderSize = 0;
            this.Maximize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Maximize.Location = new System.Drawing.Point(699, -2);
            this.Maximize.Name = "Maximize";
            this.Maximize.Size = new System.Drawing.Size(50, 50);
            this.Maximize.TabIndex = 14;
            this.Maximize.UseVisualStyleBackColor = false;
            this.Maximize.Click += new System.EventHandler(this.Maximize_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel1.Location = new System.Drawing.Point(20, 344);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(283, 312);
            this.panel1.TabIndex = 9;
            // 
            // rightPanel
            // 
            this.rightPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rightPanel.BackColor = System.Drawing.Color.Transparent;
            this.rightPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("rightPanel.BackgroundImage")));
            this.rightPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.rightPanel.Location = new System.Drawing.Point(484, 344);
            this.rightPanel.Name = "rightPanel";
            this.rightPanel.Size = new System.Drawing.Size(283, 312);
            this.rightPanel.TabIndex = 8;
            // 
            // FacebookButton
            // 
            this.FacebookButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.FacebookButton.BackColor = System.Drawing.Color.Transparent;
            this.FacebookButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("FacebookButton.BackgroundImage")));
            this.FacebookButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.FacebookButton.FlatAppearance.BorderSize = 0;
            this.FacebookButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.FacebookButton.Location = new System.Drawing.Point(533, 668);
            this.FacebookButton.Name = "FacebookButton";
            this.FacebookButton.Size = new System.Drawing.Size(208, 54);
            this.FacebookButton.TabIndex = 5;
            this.FacebookButton.UseVisualStyleBackColor = false;
            this.FacebookButton.Click += new System.EventHandler(this.FacebookButton_Click);
            // 
            // GoogleButton
            // 
            this.GoogleButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.GoogleButton.BackColor = System.Drawing.Color.Transparent;
            this.GoogleButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("GoogleButton.BackgroundImage")));
            this.GoogleButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.GoogleButton.FlatAppearance.BorderSize = 0;
            this.GoogleButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.GoogleButton.Location = new System.Drawing.Point(51, 668);
            this.GoogleButton.Name = "GoogleButton";
            this.GoogleButton.Size = new System.Drawing.Size(201, 54);
            this.GoogleButton.TabIndex = 4;
            this.GoogleButton.UseVisualStyleBackColor = false;
            this.GoogleButton.Click += new System.EventHandler(this.GoogleButton_Click);
            // 
            // DarkMode
            // 
            this.DarkMode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.DarkMode.BackColor = System.Drawing.Color.DimGray;
            this.DarkMode.BorderColor = System.Drawing.Color.DarkGray;
            this.DarkMode.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DarkMode.ForeColor = System.Drawing.Color.DarkGray;
            this.DarkMode.IsOn = false;
            this.DarkMode.Location = new System.Drawing.Point(512, -2);
            this.DarkMode.Name = "DarkMode";
            this.DarkMode.OffColor = System.Drawing.Color.LightGray;
            this.DarkMode.OffText = "Light";
            this.DarkMode.OnColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.DarkMode.OnText = "Dark";
            this.DarkMode.Size = new System.Drawing.Size(66, 35);
            this.DarkMode.TabIndex = 7;
            this.DarkMode.TextEnabled = true;
            this.DarkMode.Click += new System.EventHandler(this.DarkMode_Click);
            // 
            // LoginButton
            // 
            this.LoginButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LoginButton.BorderColor = System.Drawing.Color.Transparent;
            this.LoginButton.ButtonColor = System.Drawing.Color.Transparent;
            this.LoginButton.FlatAppearance.BorderSize = 0;
            this.LoginButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LoginButton.Location = new System.Drawing.Point(125, 295);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.OnHoverBorderColor = System.Drawing.Color.Transparent;
            this.LoginButton.OnHoverButtonColor = System.Drawing.Color.Transparent;
            this.LoginButton.OnHoverTextColor = System.Drawing.Color.Transparent;
            this.LoginButton.Size = new System.Drawing.Size(138, 76);
            this.LoginButton.TabIndex = 2;
            this.LoginButton.Text = "Log-In";
            this.LoginButton.TextColor = System.Drawing.Color.DimGray;
            this.LoginButton.UseVisualStyleBackColor = true;
            this.LoginButton.Click += new System.EventHandler(this.LoginButton_Click);
            // 
            // Signup
            // 
            this.Signup.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Signup.BorderColor = System.Drawing.Color.Transparent;
            this.Signup.ButtonColor = System.Drawing.Color.Transparent;
            this.Signup.FlatAppearance.BorderSize = 0;
            this.Signup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Signup.Location = new System.Drawing.Point(125, 398);
            this.Signup.Name = "Signup";
            this.Signup.OnHoverBorderColor = System.Drawing.Color.Transparent;
            this.Signup.OnHoverButtonColor = System.Drawing.Color.Transparent;
            this.Signup.OnHoverTextColor = System.Drawing.Color.Transparent;
            this.Signup.Size = new System.Drawing.Size(138, 76);
            this.Signup.TabIndex = 3;
            this.Signup.Text = "Sign-up";
            this.Signup.TextColor = System.Drawing.Color.Gainsboro;
            this.Signup.UseVisualStyleBackColor = true;
            this.Signup.Click += new System.EventHandler(this.Signup_Click);
            // 
            // GuestButton
            // 
            this.GuestButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GuestButton.BackColor = System.Drawing.Color.Transparent;
            this.GuestButton.BorderColor = System.Drawing.Color.Transparent;
            this.GuestButton.ButtonColor = System.Drawing.Color.Transparent;
            this.GuestButton.FlatAppearance.BorderSize = 0;
            this.GuestButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GuestButton.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 10F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GuestButton.Location = new System.Drawing.Point(327, 580);
            this.GuestButton.Name = "GuestButton";
            this.GuestButton.OnHoverBorderColor = System.Drawing.Color.Transparent;
            this.GuestButton.OnHoverButtonColor = System.Drawing.Color.Transparent;
            this.GuestButton.OnHoverTextColor = System.Drawing.Color.Transparent;
            this.GuestButton.Size = new System.Drawing.Size(138, 76);
            this.GuestButton.TabIndex = 5;
            this.GuestButton.Text = "Continue as Guest";
            this.GuestButton.TextColor = System.Drawing.Color.Transparent;
            this.GuestButton.UseVisualStyleBackColor = false;
            this.GuestButton.Click += new System.EventHandler(this.GuestButton_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(800, 956);
            this.Controls.Add(this.GuestButton);
            this.Controls.Add(this.Close);
            this.Controls.Add(this.Minimize);
            this.Controls.Add(this.Maximize);
            this.Controls.Add(this.show);
            this.Controls.Add(this.WrongEmail);
            this.Controls.Add(this.WrongUsername);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.rightPanel);
            this.Controls.Add(this.DarkMode);
            this.Controls.Add(this.LoginGroupbox);
            this.Controls.Add(this.FacebookButton);
            this.Controls.Add(this.GoogleButton);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login Form";
            this.LoginGroupbox.ResumeLayout(false);
            this.LoginGroupbox.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button GoogleButton;
        private System.Windows.Forms.Button FacebookButton;
        private ToggleCheckbox DarkMode;
        private System.Windows.Forms.GroupBox LoginGroupbox;
        private System.Windows.Forms.Label UsernameLabel;
        private System.Windows.Forms.TextBox UsernameTextbox;
        private System.Windows.Forms.Label EmailLabel;
        private System.Windows.Forms.TextBox EmailTextbox;
        private RoundButton Signup;
        private RoundButton LoginButton;
        private System.Windows.Forms.Panel rightPanel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label WrongUsername;
        private System.Windows.Forms.Label WrongEmail;
        private System.Windows.Forms.Label show;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem windowToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem darkModeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem onToolStripMenuItem;
        private System.Windows.Forms.Label WrongCredentialsLabel;
        private System.Windows.Forms.Button Maximize;
        private System.Windows.Forms.Button Minimize;
        private System.Windows.Forms.Button Close;
        private RoundButton GuestButton;
    }
}

