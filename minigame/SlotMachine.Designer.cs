
namespace minigame
{
    partial class SlotMachine
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SlotMachine));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutSlotMachineToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.Minimize = new minigame.Details();
            this.Maximize = new minigame.Details();
            this.Close = new minigame.Details();
            this.GameGroup = new minigame.CstmGroupbox();
            this.EndGame = new System.Windows.Forms.Button();
            this.PlayButton = new System.Windows.Forms.Button();
            this.ScorePanel = new System.Windows.Forms.Panel();
            this.HighscoreLabel = new System.Windows.Forms.Label();
            this.ScoreLabel = new System.Windows.Forms.Label();
            this.Highscore = new System.Windows.Forms.Label();
            this.CurrentScore = new System.Windows.Forms.Label();
            this.UsernameLabel = new System.Windows.Forms.Label();
            this.NumberPanel = new System.Windows.Forms.Panel();
            this.secondRow = new System.Windows.Forms.Panel();
            this.Second = new System.Windows.Forms.Label();
            this.thirdRow = new System.Windows.Forms.Panel();
            this.Third = new System.Windows.Forms.Label();
            this.firstRow = new System.Windows.Forms.Panel();
            this.First = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.GameGroup.SuspendLayout();
            this.ScorePanel.SuspendLayout();
            this.NumberPanel.SuspendLayout();
            this.secondRow.SuspendLayout();
            this.thirdRow.SuspendLayout();
            this.firstRow.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Raleway SemiBold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(900, 32);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(61, 28);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutSlotMachineToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(72, 28);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutSlotMachineToolStripMenuItem
            // 
            this.aboutSlotMachineToolStripMenuItem.Name = "aboutSlotMachineToolStripMenuItem";
            this.aboutSlotMachineToolStripMenuItem.Size = new System.Drawing.Size(307, 34);
            this.aboutSlotMachineToolStripMenuItem.Text = "About Slot Machine...";
            this.aboutSlotMachineToolStripMenuItem.Click += new System.EventHandler(this.aboutSlotMachineToolStripMenuItem_Click);
            // 
            // Minimize
            // 
            this.Minimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Minimize.BackColor = System.Drawing.Color.Transparent;
            this.Minimize.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Minimize.BackgroundImage")));
            this.Minimize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Minimize.FlatAppearance.BorderSize = 0;
            this.Minimize.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Minimize.Location = new System.Drawing.Point(814, 17);
            this.Minimize.Name = "Minimize";
            this.Minimize.Size = new System.Drawing.Size(50, 50);
            this.Minimize.TabIndex = 19;
            this.Minimize.UseVisualStyleBackColor = false;
            this.Minimize.Click += new System.EventHandler(this.Minimize_Click);
            // 
            // Maximize
            // 
            this.Maximize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Maximize.BackColor = System.Drawing.Color.Transparent;
            this.Maximize.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Maximize.BackgroundImage")));
            this.Maximize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Maximize.FlatAppearance.BorderSize = 0;
            this.Maximize.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Maximize.Location = new System.Drawing.Point(780, 1);
            this.Maximize.Name = "Maximize";
            this.Maximize.Size = new System.Drawing.Size(50, 50);
            this.Maximize.TabIndex = 18;
            this.Maximize.UseVisualStyleBackColor = false;
            this.Maximize.Click += new System.EventHandler(this.Maximize_Click);
            // 
            // Close
            // 
            this.Close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Close.BackColor = System.Drawing.Color.Transparent;
            this.Close.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Close.BackgroundImage")));
            this.Close.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Close.FlatAppearance.BorderSize = 0;
            this.Close.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Close.Location = new System.Drawing.Point(851, 1);
            this.Close.Name = "Close";
            this.Close.Size = new System.Drawing.Size(50, 50);
            this.Close.TabIndex = 17;
            this.Close.UseVisualStyleBackColor = false;
            this.Close.Click += new System.EventHandler(this.Close_Click);
            // 
            // GameGroup
            // 
            this.GameGroup.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GameGroup.BackColor = System.Drawing.Color.Transparent;
            this.GameGroup.Controls.Add(this.EndGame);
            this.GameGroup.Controls.Add(this.PlayButton);
            this.GameGroup.Controls.Add(this.ScorePanel);
            this.GameGroup.Controls.Add(this.NumberPanel);
            this.GameGroup.Font = new System.Drawing.Font("Malgun Gothic", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GameGroup.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.GameGroup.Location = new System.Drawing.Point(13, 64);
            this.GameGroup.Name = "GameGroup";
            this.GameGroup.Size = new System.Drawing.Size(875, 924);
            this.GameGroup.TabIndex = 20;
            this.GameGroup.TabStop = false;
            this.GameGroup.Text = "";
            // 
            // EndGame
            // 
            this.EndGame.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.EndGame.BackColor = System.Drawing.Color.DimGray;
            this.EndGame.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.EndGame.FlatAppearance.BorderSize = 0;
            this.EndGame.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.EndGame.Location = new System.Drawing.Point(66, 716);
            this.EndGame.Name = "EndGame";
            this.EndGame.Size = new System.Drawing.Size(254, 108);
            this.EndGame.TabIndex = 3;
            this.EndGame.Text = "End Game";
            this.EndGame.UseVisualStyleBackColor = false;
            this.EndGame.Click += new System.EventHandler(this.EndGame_Click);
            // 
            // PlayButton
            // 
            this.PlayButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.PlayButton.BackColor = System.Drawing.Color.DimGray;
            this.PlayButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.PlayButton.FlatAppearance.BorderSize = 0;
            this.PlayButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.PlayButton.Location = new System.Drawing.Point(563, 716);
            this.PlayButton.Name = "PlayButton";
            this.PlayButton.Size = new System.Drawing.Size(254, 108);
            this.PlayButton.TabIndex = 2;
            this.PlayButton.Text = "Play Game";
            this.PlayButton.UseVisualStyleBackColor = false;
            this.PlayButton.Click += new System.EventHandler(this.PlayButton_Click);
            // 
            // ScorePanel
            // 
            this.ScorePanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ScorePanel.BackColor = System.Drawing.Color.DimGray;
            this.ScorePanel.Controls.Add(this.HighscoreLabel);
            this.ScorePanel.Controls.Add(this.ScoreLabel);
            this.ScorePanel.Controls.Add(this.Highscore);
            this.ScorePanel.Controls.Add(this.CurrentScore);
            this.ScorePanel.Controls.Add(this.UsernameLabel);
            this.ScorePanel.Location = new System.Drawing.Point(66, 99);
            this.ScorePanel.Name = "ScorePanel";
            this.ScorePanel.Size = new System.Drawing.Size(751, 155);
            this.ScorePanel.TabIndex = 1;
            // 
            // HighscoreLabel
            // 
            this.HighscoreLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.HighscoreLabel.AutoSize = true;
            this.HighscoreLabel.Location = new System.Drawing.Point(330, 76);
            this.HighscoreLabel.Name = "HighscoreLabel";
            this.HighscoreLabel.Size = new System.Drawing.Size(0, 30);
            this.HighscoreLabel.TabIndex = 4;
            this.HighscoreLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ScoreLabel
            // 
            this.ScoreLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ScoreLabel.AutoSize = true;
            this.ScoreLabel.Location = new System.Drawing.Point(696, 76);
            this.ScoreLabel.Name = "ScoreLabel";
            this.ScoreLabel.Size = new System.Drawing.Size(0, 30);
            this.ScoreLabel.TabIndex = 3;
            this.ScoreLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Highscore
            // 
            this.Highscore.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Highscore.AutoSize = true;
            this.Highscore.Location = new System.Drawing.Point(330, 8);
            this.Highscore.Name = "Highscore";
            this.Highscore.Size = new System.Drawing.Size(101, 30);
            this.Highscore.TabIndex = 2;
            this.Highscore.Text = "Record :";
            this.Highscore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CurrentScore
            // 
            this.CurrentScore.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CurrentScore.AutoSize = true;
            this.CurrentScore.Location = new System.Drawing.Point(673, 8);
            this.CurrentScore.Name = "CurrentScore";
            this.CurrentScore.Size = new System.Drawing.Size(93, 30);
            this.CurrentScore.TabIndex = 1;
            this.CurrentScore.Text = "Score : ";
            this.CurrentScore.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // UsernameLabel
            // 
            this.UsernameLabel.AutoSize = true;
            this.UsernameLabel.Location = new System.Drawing.Point(7, 8);
            this.UsernameLabel.Name = "UsernameLabel";
            this.UsernameLabel.Size = new System.Drawing.Size(76, 30);
            this.UsernameLabel.TabIndex = 0;
            this.UsernameLabel.Text = "label1";
            // 
            // NumberPanel
            // 
            this.NumberPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.NumberPanel.BackColor = System.Drawing.Color.DimGray;
            this.NumberPanel.Controls.Add(this.secondRow);
            this.NumberPanel.Controls.Add(this.thirdRow);
            this.NumberPanel.Controls.Add(this.firstRow);
            this.NumberPanel.Location = new System.Drawing.Point(66, 350);
            this.NumberPanel.Name = "NumberPanel";
            this.NumberPanel.Size = new System.Drawing.Size(751, 265);
            this.NumberPanel.TabIndex = 0;
            // 
            // secondRow
            // 
            this.secondRow.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.secondRow.BackColor = System.Drawing.Color.MidnightBlue;
            this.secondRow.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.secondRow.Controls.Add(this.Second);
            this.secondRow.Location = new System.Drawing.Point(273, 15);
            this.secondRow.Name = "secondRow";
            this.secondRow.Size = new System.Drawing.Size(200, 232);
            this.secondRow.TabIndex = 2;
            // 
            // Second
            // 
            this.Second.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Second.BackColor = System.Drawing.Color.Transparent;
            this.Second.Location = new System.Drawing.Point(4, 4);
            this.Second.Name = "Second";
            this.Second.Size = new System.Drawing.Size(187, 219);
            this.Second.TabIndex = 1;
            this.Second.Text = "Play";
            this.Second.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // thirdRow
            // 
            this.thirdRow.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.thirdRow.BackColor = System.Drawing.Color.MidnightBlue;
            this.thirdRow.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.thirdRow.Controls.Add(this.Third);
            this.thirdRow.Location = new System.Drawing.Point(538, 15);
            this.thirdRow.Name = "thirdRow";
            this.thirdRow.Size = new System.Drawing.Size(200, 232);
            this.thirdRow.TabIndex = 1;
            // 
            // Third
            // 
            this.Third.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.Third.BackColor = System.Drawing.Color.Transparent;
            this.Third.Location = new System.Drawing.Point(3, 4);
            this.Third.Name = "Third";
            this.Third.Size = new System.Drawing.Size(190, 219);
            this.Third.TabIndex = 2;
            this.Third.Text = "Play";
            this.Third.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // firstRow
            // 
            this.firstRow.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.firstRow.BackColor = System.Drawing.Color.MidnightBlue;
            this.firstRow.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.firstRow.Controls.Add(this.First);
            this.firstRow.Location = new System.Drawing.Point(12, 15);
            this.firstRow.Name = "firstRow";
            this.firstRow.Size = new System.Drawing.Size(200, 232);
            this.firstRow.TabIndex = 0;
            // 
            // First
            // 
            this.First.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.First.BackColor = System.Drawing.Color.Transparent;
            this.First.Location = new System.Drawing.Point(4, 4);
            this.First.Name = "First";
            this.First.Size = new System.Drawing.Size(187, 219);
            this.First.TabIndex = 0;
            this.First.Text = "Play";
            this.First.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SlotMachine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SlateBlue;
            this.ClientSize = new System.Drawing.Size(900, 1000);
            this.Controls.Add(this.GameGroup);
            this.Controls.Add(this.Minimize);
            this.Controls.Add(this.Maximize);
            this.Controls.Add(this.Close);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "SlotMachine";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SlotMachine";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.GameGroup.ResumeLayout(false);
            this.ScorePanel.ResumeLayout(false);
            this.ScorePanel.PerformLayout();
            this.NumberPanel.ResumeLayout(false);
            this.secondRow.ResumeLayout(false);
            this.thirdRow.ResumeLayout(false);
            this.firstRow.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutSlotMachineToolStripMenuItem;
        private System.Windows.Forms.Timer timer1;
        private Details Minimize;
        private Details Maximize;
        private Details Close;
        private CstmGroupbox GameGroup;
        private System.Windows.Forms.Button EndGame;
        private System.Windows.Forms.Button PlayButton;
        private System.Windows.Forms.Panel ScorePanel;
        private System.Windows.Forms.Panel NumberPanel;
        private System.Windows.Forms.Label UsernameLabel;
        private System.Windows.Forms.Label CurrentScore;
        private System.Windows.Forms.Label ScoreLabel;
        private System.Windows.Forms.Label Highscore;
        private System.Windows.Forms.Label HighscoreLabel;
        private System.Windows.Forms.Panel secondRow;
        private System.Windows.Forms.Panel thirdRow;
        private System.Windows.Forms.Panel firstRow;
        private System.Windows.Forms.Label Second;
        private System.Windows.Forms.Label Third;
        private System.Windows.Forms.Label First;
    }
}