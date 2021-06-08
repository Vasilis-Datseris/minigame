
namespace minigame
{
    partial class Scores
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Scores));
            this.SlotMachine = new System.Windows.Forms.Button();
            this.ClassicChess = new System.Windows.Forms.Button();
            this.Backgammon = new System.Windows.Forms.Button();
            this.NavigationPanel = new System.Windows.Forms.Panel();
            this.ButtonsPanel = new System.Windows.Forms.Panel();
            this.LoaderForm = new System.Windows.Forms.Panel();
            this.Played = new System.Windows.Forms.Label();
            this.PlayedLabel = new System.Windows.Forms.Label();
            this.Highscore = new System.Windows.Forms.Label();
            this.HighScoreLabel = new System.Windows.Forms.Label();
            this.Username = new System.Windows.Forms.Label();
            this.UsernameLabel = new System.Windows.Forms.Label();
            this.SlotPicture = new System.Windows.Forms.PictureBox();
            this.ButtonsPanel.SuspendLayout();
            this.LoaderForm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SlotPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // SlotMachine
            // 
            this.SlotMachine.BackColor = System.Drawing.Color.Transparent;
            this.SlotMachine.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.SlotMachine.Dock = System.Windows.Forms.DockStyle.Left;
            this.SlotMachine.FlatAppearance.BorderSize = 0;
            this.SlotMachine.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SlotMachine.Location = new System.Drawing.Point(0, 0);
            this.SlotMachine.Name = "SlotMachine";
            this.SlotMachine.Size = new System.Drawing.Size(150, 90);
            this.SlotMachine.TabIndex = 0;
            this.SlotMachine.Text = "Slot Machine";
            this.SlotMachine.UseVisualStyleBackColor = false;
            this.SlotMachine.Click += new System.EventHandler(this.SlotMachine_Click);
            this.SlotMachine.Leave += new System.EventHandler(this.SlotMachine_Leave);
            // 
            // ClassicChess
            // 
            this.ClassicChess.BackColor = System.Drawing.Color.Transparent;
            this.ClassicChess.Dock = System.Windows.Forms.DockStyle.Right;
            this.ClassicChess.FlatAppearance.BorderSize = 0;
            this.ClassicChess.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ClassicChess.Location = new System.Drawing.Point(350, 0);
            this.ClassicChess.Name = "ClassicChess";
            this.ClassicChess.Size = new System.Drawing.Size(150, 90);
            this.ClassicChess.TabIndex = 1;
            this.ClassicChess.Text = "Classic Chess";
            this.ClassicChess.UseVisualStyleBackColor = false;
            this.ClassicChess.Click += new System.EventHandler(this.ClassicChess_Click);
            this.ClassicChess.Leave += new System.EventHandler(this.ClassicChess_Leave);
            // 
            // Backgammon
            // 
            this.Backgammon.BackColor = System.Drawing.Color.Transparent;
            this.Backgammon.Dock = System.Windows.Forms.DockStyle.Right;
            this.Backgammon.FlatAppearance.BorderSize = 0;
            this.Backgammon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Backgammon.Location = new System.Drawing.Point(500, 0);
            this.Backgammon.Name = "Backgammon";
            this.Backgammon.Size = new System.Drawing.Size(150, 90);
            this.Backgammon.TabIndex = 2;
            this.Backgammon.Text = "Backgammon";
            this.Backgammon.UseVisualStyleBackColor = false;
            this.Backgammon.Click += new System.EventHandler(this.Backgammon_Click);
            this.Backgammon.Leave += new System.EventHandler(this.Backgammon_Leave);
            // 
            // NavigationPanel
            // 
            this.NavigationPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.NavigationPanel.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.NavigationPanel.Location = new System.Drawing.Point(125, 0);
            this.NavigationPanel.Name = "NavigationPanel";
            this.NavigationPanel.Size = new System.Drawing.Size(202, 5);
            this.NavigationPanel.TabIndex = 3;
            // 
            // ButtonsPanel
            // 
            this.ButtonsPanel.BackColor = System.Drawing.Color.Transparent;
            this.ButtonsPanel.Controls.Add(this.NavigationPanel);
            this.ButtonsPanel.Controls.Add(this.SlotMachine);
            this.ButtonsPanel.Controls.Add(this.ClassicChess);
            this.ButtonsPanel.Controls.Add(this.Backgammon);
            this.ButtonsPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.ButtonsPanel.Location = new System.Drawing.Point(0, 0);
            this.ButtonsPanel.Name = "ButtonsPanel";
            this.ButtonsPanel.Size = new System.Drawing.Size(650, 90);
            this.ButtonsPanel.TabIndex = 4;
            // 
            // LoaderForm
            // 
            this.LoaderForm.BackColor = System.Drawing.Color.Transparent;
            this.LoaderForm.Controls.Add(this.Played);
            this.LoaderForm.Controls.Add(this.PlayedLabel);
            this.LoaderForm.Controls.Add(this.Highscore);
            this.LoaderForm.Controls.Add(this.HighScoreLabel);
            this.LoaderForm.Controls.Add(this.Username);
            this.LoaderForm.Controls.Add(this.UsernameLabel);
            this.LoaderForm.Controls.Add(this.SlotPicture);
            this.LoaderForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LoaderForm.Location = new System.Drawing.Point(0, 90);
            this.LoaderForm.Name = "LoaderForm";
            this.LoaderForm.Size = new System.Drawing.Size(650, 810);
            this.LoaderForm.TabIndex = 5;
            // 
            // Played
            // 
            this.Played.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Played.AutoSize = true;
            this.Played.BackColor = System.Drawing.Color.Transparent;
            this.Played.Font = new System.Drawing.Font("Malgun Gothic", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Played.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.Played.Location = new System.Drawing.Point(342, 448);
            this.Played.Name = "Played";
            this.Played.Size = new System.Drawing.Size(121, 45);
            this.Played.TabIndex = 8;
            this.Played.Text = "played";
            this.Played.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Played.Visible = false;
            // 
            // PlayedLabel
            // 
            this.PlayedLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PlayedLabel.AutoSize = true;
            this.PlayedLabel.BackColor = System.Drawing.Color.Transparent;
            this.PlayedLabel.Font = new System.Drawing.Font("Malgun Gothic", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlayedLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.PlayedLabel.Location = new System.Drawing.Point(96, 448);
            this.PlayedLabel.Name = "PlayedLabel";
            this.PlayedLabel.Size = new System.Drawing.Size(231, 45);
            this.PlayedLabel.TabIndex = 7;
            this.PlayedLabel.Text = "Times Played:";
            this.PlayedLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.PlayedLabel.Visible = false;
            // 
            // Highscore
            // 
            this.Highscore.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Highscore.AutoSize = true;
            this.Highscore.BackColor = System.Drawing.Color.Transparent;
            this.Highscore.Font = new System.Drawing.Font("Malgun Gothic", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Highscore.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.Highscore.Location = new System.Drawing.Point(342, 388);
            this.Highscore.Name = "Highscore";
            this.Highscore.Size = new System.Drawing.Size(175, 45);
            this.Highscore.TabIndex = 6;
            this.Highscore.Text = "Highscore";
            this.Highscore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Highscore.Visible = false;
            // 
            // HighScoreLabel
            // 
            this.HighScoreLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.HighScoreLabel.AutoSize = true;
            this.HighScoreLabel.BackColor = System.Drawing.Color.Transparent;
            this.HighScoreLabel.Font = new System.Drawing.Font("Malgun Gothic", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HighScoreLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.HighScoreLabel.Location = new System.Drawing.Point(144, 388);
            this.HighScoreLabel.Name = "HighScoreLabel";
            this.HighScoreLabel.Size = new System.Drawing.Size(183, 45);
            this.HighScoreLabel.TabIndex = 5;
            this.HighScoreLabel.Text = "Highscore:";
            this.HighScoreLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.HighScoreLabel.Visible = false;
            // 
            // Username
            // 
            this.Username.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Username.AutoSize = true;
            this.Username.BackColor = System.Drawing.Color.Transparent;
            this.Username.Font = new System.Drawing.Font("Malgun Gothic", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Username.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.Username.Location = new System.Drawing.Point(342, 329);
            this.Username.Name = "Username";
            this.Username.Size = new System.Drawing.Size(173, 45);
            this.Username.TabIndex = 4;
            this.Username.Text = "Username";
            this.Username.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Username.Visible = false;
            // 
            // UsernameLabel
            // 
            this.UsernameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.UsernameLabel.AutoSize = true;
            this.UsernameLabel.BackColor = System.Drawing.Color.Transparent;
            this.UsernameLabel.Font = new System.Drawing.Font("Malgun Gothic", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsernameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.UsernameLabel.Location = new System.Drawing.Point(146, 329);
            this.UsernameLabel.Name = "UsernameLabel";
            this.UsernameLabel.Size = new System.Drawing.Size(181, 45);
            this.UsernameLabel.TabIndex = 3;
            this.UsernameLabel.Text = "Username:";
            this.UsernameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.UsernameLabel.Visible = false;
            // 
            // SlotPicture
            // 
            this.SlotPicture.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SlotPicture.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("SlotPicture.BackgroundImage")));
            this.SlotPicture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.SlotPicture.Location = new System.Drawing.Point(154, 28);
            this.SlotPicture.Name = "SlotPicture";
            this.SlotPicture.Size = new System.Drawing.Size(329, 282);
            this.SlotPicture.TabIndex = 0;
            this.SlotPicture.TabStop = false;
            this.SlotPicture.Visible = false;
            // 
            // Scores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(650, 900);
            this.Controls.Add(this.LoaderForm);
            this.Controls.Add(this.ButtonsPanel);
            this.Font = new System.Drawing.Font("Calisto MT", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "Scores";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Scores";
            this.ButtonsPanel.ResumeLayout(false);
            this.LoaderForm.ResumeLayout(false);
            this.LoaderForm.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SlotPicture)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button SlotMachine;
        private System.Windows.Forms.Button ClassicChess;
        private System.Windows.Forms.Button Backgammon;
        private System.Windows.Forms.Panel NavigationPanel;
        private System.Windows.Forms.Panel ButtonsPanel;
        private System.Windows.Forms.Panel LoaderForm;
        private System.Windows.Forms.PictureBox SlotPicture;
        private System.Windows.Forms.Label Played;
        private System.Windows.Forms.Label PlayedLabel;
        private System.Windows.Forms.Label Highscore;
        private System.Windows.Forms.Label HighScoreLabel;
        private System.Windows.Forms.Label Username;
        private System.Windows.Forms.Label UsernameLabel;
    }
}