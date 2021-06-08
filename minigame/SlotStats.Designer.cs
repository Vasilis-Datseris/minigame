
namespace minigame
{
    partial class SlotStats
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SlotStats));
            this.Played = new System.Windows.Forms.Label();
            this.Highscore = new System.Windows.Forms.Label();
            this.Username = new System.Windows.Forms.Label();
            this.Stats = new System.Windows.Forms.Panel();
            this.PlayedLabel = new System.Windows.Forms.Label();
            this.HighScoreLabel = new System.Windows.Forms.Label();
            this.UsernameLabel = new System.Windows.Forms.Label();
            this.Personal = new System.Windows.Forms.Panel();
            this.PicturePanel = new System.Windows.Forms.Panel();
            this.a = new System.Windows.Forms.PictureBox();
            this.Stats.SuspendLayout();
            this.Personal.SuspendLayout();
            this.PicturePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.a)).BeginInit();
            this.SuspendLayout();
            // 
            // Played
            // 
            this.Played.AutoSize = true;
            this.Played.BackColor = System.Drawing.Color.Transparent;
            this.Played.Font = new System.Drawing.Font("Malgun Gothic", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Played.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.Played.Location = new System.Drawing.Point(3, 119);
            this.Played.Name = "Played";
            this.Played.Size = new System.Drawing.Size(121, 45);
            this.Played.TabIndex = 40;
            this.Played.Text = "played";
            this.Played.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Highscore
            // 
            this.Highscore.AutoSize = true;
            this.Highscore.BackColor = System.Drawing.Color.Transparent;
            this.Highscore.Font = new System.Drawing.Font("Malgun Gothic", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Highscore.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.Highscore.Location = new System.Drawing.Point(3, 59);
            this.Highscore.Name = "Highscore";
            this.Highscore.Size = new System.Drawing.Size(175, 45);
            this.Highscore.TabIndex = 38;
            this.Highscore.Text = "Highscore";
            this.Highscore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Username
            // 
            this.Username.AutoSize = true;
            this.Username.BackColor = System.Drawing.Color.Transparent;
            this.Username.Font = new System.Drawing.Font("Malgun Gothic", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Username.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.Username.Location = new System.Drawing.Point(3, 0);
            this.Username.Name = "Username";
            this.Username.Size = new System.Drawing.Size(173, 45);
            this.Username.TabIndex = 36;
            this.Username.Text = "Username";
            this.Username.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Stats
            // 
            this.Stats.BackColor = System.Drawing.Color.Transparent;
            this.Stats.Controls.Add(this.PlayedLabel);
            this.Stats.Controls.Add(this.HighScoreLabel);
            this.Stats.Controls.Add(this.UsernameLabel);
            this.Stats.Location = new System.Drawing.Point(12, 305);
            this.Stats.Name = "Stats";
            this.Stats.Size = new System.Drawing.Size(239, 171);
            this.Stats.TabIndex = 41;
            // 
            // PlayedLabel
            // 
            this.PlayedLabel.AutoSize = true;
            this.PlayedLabel.BackColor = System.Drawing.Color.Transparent;
            this.PlayedLabel.Font = new System.Drawing.Font("Malgun Gothic", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlayedLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.PlayedLabel.Location = new System.Drawing.Point(3, 119);
            this.PlayedLabel.Name = "PlayedLabel";
            this.PlayedLabel.Size = new System.Drawing.Size(231, 45);
            this.PlayedLabel.TabIndex = 44;
            this.PlayedLabel.Text = "Times Played:";
            this.PlayedLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // HighScoreLabel
            // 
            this.HighScoreLabel.AutoSize = true;
            this.HighScoreLabel.BackColor = System.Drawing.Color.Transparent;
            this.HighScoreLabel.Font = new System.Drawing.Font("Malgun Gothic", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HighScoreLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.HighScoreLabel.Location = new System.Drawing.Point(3, 59);
            this.HighScoreLabel.Name = "HighScoreLabel";
            this.HighScoreLabel.Size = new System.Drawing.Size(183, 45);
            this.HighScoreLabel.TabIndex = 43;
            this.HighScoreLabel.Text = "Highscore:";
            this.HighScoreLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // UsernameLabel
            // 
            this.UsernameLabel.AutoSize = true;
            this.UsernameLabel.BackColor = System.Drawing.Color.Transparent;
            this.UsernameLabel.Font = new System.Drawing.Font("Malgun Gothic", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsernameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.UsernameLabel.Location = new System.Drawing.Point(3, 0);
            this.UsernameLabel.Name = "UsernameLabel";
            this.UsernameLabel.Size = new System.Drawing.Size(181, 45);
            this.UsernameLabel.TabIndex = 42;
            this.UsernameLabel.Text = "Username:";
            this.UsernameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Personal
            // 
            this.Personal.BackColor = System.Drawing.Color.Transparent;
            this.Personal.Controls.Add(this.Highscore);
            this.Personal.Controls.Add(this.Username);
            this.Personal.Controls.Add(this.Played);
            this.Personal.Location = new System.Drawing.Point(257, 305);
            this.Personal.Name = "Personal";
            this.Personal.Size = new System.Drawing.Size(329, 164);
            this.Personal.TabIndex = 42;
            // 
            // PicturePanel
            // 
            this.PicturePanel.BackColor = System.Drawing.Color.Transparent;
            this.PicturePanel.Controls.Add(this.a);
            this.PicturePanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.PicturePanel.Location = new System.Drawing.Point(0, 0);
            this.PicturePanel.Name = "PicturePanel";
            this.PicturePanel.Size = new System.Drawing.Size(650, 299);
            this.PicturePanel.TabIndex = 43;
            // 
            // a
            // 
            this.a.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("a.BackgroundImage")));
            this.a.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.a.Dock = System.Windows.Forms.DockStyle.Left;
            this.a.Location = new System.Drawing.Point(0, 0);
            this.a.Name = "a";
            this.a.Size = new System.Drawing.Size(280, 299);
            this.a.TabIndex = 0;
            this.a.TabStop = false;
            // 
            // SlotStats
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(650, 800);
            this.Controls.Add(this.PicturePanel);
            this.Controls.Add(this.Personal);
            this.Controls.Add(this.Stats);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SlotStats";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SlotStats";
            this.Stats.ResumeLayout(false);
            this.Stats.PerformLayout();
            this.Personal.ResumeLayout(false);
            this.Personal.PerformLayout();
            this.PicturePanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.a)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label Played;
        private System.Windows.Forms.Label Highscore;
        private System.Windows.Forms.Label Username;
        private System.Windows.Forms.Panel Stats;
        private System.Windows.Forms.Label PlayedLabel;
        private System.Windows.Forms.Label HighScoreLabel;
        private System.Windows.Forms.Label UsernameLabel;
        private System.Windows.Forms.Panel Personal;
        private System.Windows.Forms.Panel PicturePanel;
        private System.Windows.Forms.PictureBox a;
    }
}