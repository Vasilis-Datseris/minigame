
namespace minigame
{
    partial class Flight_X
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Flight_X));
            this.Player = new System.Windows.Forms.PictureBox();
            this.flyingEnemyPanel = new System.Windows.Forms.Panel();
            this.flyingEnemy = new System.Windows.Forms.PictureBox();
            this.GeneralTimer = new System.Windows.Forms.Timer(this.components);
            this.playerHP = new System.Windows.Forms.Panel();
            this.belowHalfHP = new minigame.GradientPanel();
            this.aboveHalfHP = new minigame.GradientPanel();
            this.topPanel = new minigame.GradientPanel();
            this.usernameLabel = new System.Windows.Forms.Label();
            this.Maximize = new System.Windows.Forms.Button();
            this.InventoryPanel = new System.Windows.Forms.Panel();
            this.ultimatePanel = new System.Windows.Forms.Panel();
            this.ultimateBorder = new System.Windows.Forms.Panel();
            this.ultimate = new minigame.GradientPanel();
            this.usernamePanel = new System.Windows.Forms.Panel();
            this.currentScoreLabel = new System.Windows.Forms.Label();
            this.bulletsPanel = new System.Windows.Forms.Panel();
            this.bulletsLabel = new System.Windows.Forms.Label();
            this.bombsPanel = new System.Windows.Forms.Panel();
            this.bombsLabel = new System.Windows.Forms.Label();
            this.Minimize = new System.Windows.Forms.Button();
            this.Close = new System.Windows.Forms.Button();
            this.groundPanel = new minigame.GradientPanel();
            this.groundTopPanel = new minigame.GradientPanel();
            this.groundBottomPanel = new minigame.GradientPanel();
            ((System.ComponentModel.ISupportInitialize)(this.Player)).BeginInit();
            this.flyingEnemyPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.flyingEnemy)).BeginInit();
            this.playerHP.SuspendLayout();
            this.topPanel.SuspendLayout();
            this.InventoryPanel.SuspendLayout();
            this.ultimatePanel.SuspendLayout();
            this.ultimateBorder.SuspendLayout();
            this.usernamePanel.SuspendLayout();
            this.bulletsPanel.SuspendLayout();
            this.bombsPanel.SuspendLayout();
            this.groundPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // Player
            // 
            this.Player.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.Player.BackColor = System.Drawing.Color.Transparent;
            this.Player.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Player.Image = ((System.Drawing.Image)(resources.GetObject("Player.Image")));
            this.Player.Location = new System.Drawing.Point(60, 228);
            this.Player.Name = "Player";
            this.Player.Size = new System.Drawing.Size(184, 96);
            this.Player.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Player.TabIndex = 21;
            this.Player.TabStop = false;
            // 
            // flyingEnemyPanel
            // 
            this.flyingEnemyPanel.BackColor = System.Drawing.Color.Transparent;
            this.flyingEnemyPanel.Controls.Add(this.flyingEnemy);
            this.flyingEnemyPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.flyingEnemyPanel.Location = new System.Drawing.Point(412, 93);
            this.flyingEnemyPanel.Name = "flyingEnemyPanel";
            this.flyingEnemyPanel.Size = new System.Drawing.Size(388, 487);
            this.flyingEnemyPanel.TabIndex = 22;
            // 
            // flyingEnemy
            // 
            this.flyingEnemy.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.flyingEnemy.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.flyingEnemy.Image = global::minigame.Properties.Resources.Enemy;
            this.flyingEnemy.Location = new System.Drawing.Point(159, 91);
            this.flyingEnemy.Name = "flyingEnemy";
            this.flyingEnemy.Size = new System.Drawing.Size(170, 140);
            this.flyingEnemy.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.flyingEnemy.TabIndex = 0;
            this.flyingEnemy.TabStop = false;
            // 
            // GeneralTimer
            // 
            this.GeneralTimer.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // playerHP
            // 
            this.playerHP.BackColor = System.Drawing.Color.Transparent;
            this.playerHP.Controls.Add(this.belowHalfHP);
            this.playerHP.Controls.Add(this.aboveHalfHP);
            this.playerHP.Dock = System.Windows.Forms.DockStyle.Left;
            this.playerHP.Location = new System.Drawing.Point(0, 93);
            this.playerHP.Name = "playerHP";
            this.playerHP.Padding = new System.Windows.Forms.Padding(5);
            this.playerHP.Size = new System.Drawing.Size(15, 487);
            this.playerHP.TabIndex = 23;
            // 
            // belowHalfHP
            // 
            this.belowHalfHP.Angle = 90F;
            this.belowHalfHP.Bottom = System.Drawing.Color.Red;
            this.belowHalfHP.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.belowHalfHP.Location = new System.Drawing.Point(5, 42);
            this.belowHalfHP.Name = "belowHalfHP";
            this.belowHalfHP.Size = new System.Drawing.Size(5, 220);
            this.belowHalfHP.TabIndex = 25;
            this.belowHalfHP.Top = System.Drawing.Color.Yellow;
            // 
            // aboveHalfHP
            // 
            this.aboveHalfHP.Angle = 90F;
            this.aboveHalfHP.Bottom = System.Drawing.Color.Yellow;
            this.aboveHalfHP.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.aboveHalfHP.Location = new System.Drawing.Point(5, 262);
            this.aboveHalfHP.Name = "aboveHalfHP";
            this.aboveHalfHP.Size = new System.Drawing.Size(5, 220);
            this.aboveHalfHP.TabIndex = 24;
            this.aboveHalfHP.Top = System.Drawing.Color.Lime;
            // 
            // topPanel
            // 
            this.topPanel.Angle = 90F;
            this.topPanel.BackColor = System.Drawing.Color.Transparent;
            this.topPanel.Bottom = System.Drawing.Color.SteelBlue;
            this.topPanel.Controls.Add(this.usernameLabel);
            this.topPanel.Controls.Add(this.Maximize);
            this.topPanel.Controls.Add(this.InventoryPanel);
            this.topPanel.Controls.Add(this.Minimize);
            this.topPanel.Controls.Add(this.Close);
            this.topPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topPanel.Location = new System.Drawing.Point(0, 0);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(800, 93);
            this.topPanel.TabIndex = 20;
            this.topPanel.Top = System.Drawing.Color.DarkSlateGray;
            // 
            // usernameLabel
            // 
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.usernameLabel.Location = new System.Drawing.Point(13, 4);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(231, 29);
            this.usernameLabel.TabIndex = 16;
            this.usernameLabel.Text = "Variables.Username";
            // 
            // Maximize
            // 
            this.Maximize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Maximize.BackColor = System.Drawing.Color.Transparent;
            this.Maximize.BackgroundImage = global::minigame.Properties.Resources.maximize_window_black;
            this.Maximize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Maximize.FlatAppearance.BorderSize = 0;
            this.Maximize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Maximize.Location = new System.Drawing.Point(699, 0);
            this.Maximize.Name = "Maximize";
            this.Maximize.Size = new System.Drawing.Size(50, 50);
            this.Maximize.TabIndex = 12;
            this.Maximize.UseVisualStyleBackColor = false;
            this.Maximize.Click += new System.EventHandler(this.Maximize_Click);
            // 
            // InventoryPanel
            // 
            this.InventoryPanel.BackColor = System.Drawing.Color.SteelBlue;
            this.InventoryPanel.Controls.Add(this.ultimatePanel);
            this.InventoryPanel.Controls.Add(this.usernamePanel);
            this.InventoryPanel.Controls.Add(this.bulletsPanel);
            this.InventoryPanel.Controls.Add(this.bombsPanel);
            this.InventoryPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.InventoryPanel.Location = new System.Drawing.Point(0, 56);
            this.InventoryPanel.Name = "InventoryPanel";
            this.InventoryPanel.Padding = new System.Windows.Forms.Padding(5);
            this.InventoryPanel.Size = new System.Drawing.Size(800, 37);
            this.InventoryPanel.TabIndex = 15;
            // 
            // ultimatePanel
            // 
            this.ultimatePanel.Controls.Add(this.ultimateBorder);
            this.ultimatePanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.ultimatePanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ultimatePanel.Location = new System.Drawing.Point(265, 5);
            this.ultimatePanel.Name = "ultimatePanel";
            this.ultimatePanel.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.ultimatePanel.Size = new System.Drawing.Size(280, 27);
            this.ultimatePanel.TabIndex = 18;
            // 
            // ultimateBorder
            // 
            this.ultimateBorder.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ultimateBorder.Controls.Add(this.ultimate);
            this.ultimateBorder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ultimateBorder.Location = new System.Drawing.Point(10, 7);
            this.ultimateBorder.Name = "ultimateBorder";
            this.ultimateBorder.Padding = new System.Windows.Forms.Padding(2);
            this.ultimateBorder.Size = new System.Drawing.Size(260, 13);
            this.ultimateBorder.TabIndex = 19;
            // 
            // ultimate
            // 
            this.ultimate.Angle = 0F;
            this.ultimate.Bottom = System.Drawing.Color.Khaki;
            this.ultimate.Dock = System.Windows.Forms.DockStyle.Left;
            this.ultimate.Location = new System.Drawing.Point(2, 2);
            this.ultimate.Name = "ultimate";
            this.ultimate.Size = new System.Drawing.Size(256, 9);
            this.ultimate.TabIndex = 21;
            this.ultimate.Top = System.Drawing.Color.Salmon;
            // 
            // usernamePanel
            // 
            this.usernamePanel.Controls.Add(this.currentScoreLabel);
            this.usernamePanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.usernamePanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernamePanel.Location = new System.Drawing.Point(545, 5);
            this.usernamePanel.Name = "usernamePanel";
            this.usernamePanel.Size = new System.Drawing.Size(250, 27);
            this.usernamePanel.TabIndex = 18;
            // 
            // currentScoreLabel
            // 
            this.currentScoreLabel.AutoSize = true;
            this.currentScoreLabel.Dock = System.Windows.Forms.DockStyle.Left;
            this.currentScoreLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentScoreLabel.Location = new System.Drawing.Point(0, 0);
            this.currentScoreLabel.Name = "currentScoreLabel";
            this.currentScoreLabel.Size = new System.Drawing.Size(187, 29);
            this.currentScoreLabel.TabIndex = 15;
            this.currentScoreLabel.Text = "CurrentScore : 0";
            // 
            // bulletsPanel
            // 
            this.bulletsPanel.Controls.Add(this.bulletsLabel);
            this.bulletsPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.bulletsPanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bulletsPanel.Location = new System.Drawing.Point(135, 5);
            this.bulletsPanel.Name = "bulletsPanel";
            this.bulletsPanel.Size = new System.Drawing.Size(130, 27);
            this.bulletsPanel.TabIndex = 18;
            // 
            // bulletsLabel
            // 
            this.bulletsLabel.AutoSize = true;
            this.bulletsLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bulletsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bulletsLabel.Location = new System.Drawing.Point(0, 0);
            this.bulletsLabel.Name = "bulletsLabel";
            this.bulletsLabel.Size = new System.Drawing.Size(130, 29);
            this.bulletsLabel.TabIndex = 15;
            this.bulletsLabel.Text = "Bullets : 99";
            // 
            // bombsPanel
            // 
            this.bombsPanel.Controls.Add(this.bombsLabel);
            this.bombsPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.bombsPanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bombsPanel.Location = new System.Drawing.Point(5, 5);
            this.bombsPanel.Name = "bombsPanel";
            this.bombsPanel.Size = new System.Drawing.Size(130, 27);
            this.bombsPanel.TabIndex = 16;
            // 
            // bombsLabel
            // 
            this.bombsLabel.AutoSize = true;
            this.bombsLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bombsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bombsLabel.Location = new System.Drawing.Point(0, 0);
            this.bombsLabel.Name = "bombsLabel";
            this.bombsLabel.Size = new System.Drawing.Size(139, 29);
            this.bombsLabel.TabIndex = 15;
            this.bombsLabel.Text = "Bombs : 10 ";
            // 
            // Minimize
            // 
            this.Minimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Minimize.BackColor = System.Drawing.Color.Transparent;
            this.Minimize.BackgroundImage = global::minigame.Properties.Resources.minimize_window_black;
            this.Minimize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Minimize.FlatAppearance.BorderSize = 0;
            this.Minimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Minimize.Location = new System.Drawing.Point(649, 0);
            this.Minimize.Name = "Minimize";
            this.Minimize.Size = new System.Drawing.Size(50, 50);
            this.Minimize.TabIndex = 11;
            this.Minimize.UseVisualStyleBackColor = false;
            this.Minimize.Click += new System.EventHandler(this.Minimize_Click);
            // 
            // Close
            // 
            this.Close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Close.BackColor = System.Drawing.Color.Transparent;
            this.Close.BackgroundImage = global::minigame.Properties.Resources.Close_black;
            this.Close.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Close.FlatAppearance.BorderSize = 0;
            this.Close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Close.Location = new System.Drawing.Point(749, 2);
            this.Close.Name = "Close";
            this.Close.Size = new System.Drawing.Size(50, 50);
            this.Close.TabIndex = 13;
            this.Close.UseVisualStyleBackColor = false;
            this.Close.Click += new System.EventHandler(this.Close_Click);
            // 
            // groundPanel
            // 
            this.groundPanel.Angle = 90F;
            this.groundPanel.BackColor = System.Drawing.Color.Transparent;
            this.groundPanel.Bottom = System.Drawing.Color.Goldenrod;
            this.groundPanel.Controls.Add(this.groundTopPanel);
            this.groundPanel.Controls.Add(this.groundBottomPanel);
            this.groundPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groundPanel.Location = new System.Drawing.Point(0, 580);
            this.groundPanel.Name = "groundPanel";
            this.groundPanel.Size = new System.Drawing.Size(800, 100);
            this.groundPanel.TabIndex = 19;
            this.groundPanel.Top = System.Drawing.Color.Olive;
            // 
            // groundTopPanel
            // 
            this.groundTopPanel.Angle = 90F;
            this.groundTopPanel.BackColor = System.Drawing.Color.Transparent;
            this.groundTopPanel.Bottom = System.Drawing.Color.Olive;
            this.groundTopPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.groundTopPanel.Location = new System.Drawing.Point(0, 0);
            this.groundTopPanel.Name = "groundTopPanel";
            this.groundTopPanel.Size = new System.Drawing.Size(800, 30);
            this.groundTopPanel.TabIndex = 21;
            this.groundTopPanel.Top = System.Drawing.Color.Gold;
            // 
            // groundBottomPanel
            // 
            this.groundBottomPanel.Angle = 90F;
            this.groundBottomPanel.BackColor = System.Drawing.Color.Transparent;
            this.groundBottomPanel.Bottom = System.Drawing.Color.DarkOrange;
            this.groundBottomPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groundBottomPanel.Location = new System.Drawing.Point(0, 70);
            this.groundBottomPanel.Name = "groundBottomPanel";
            this.groundBottomPanel.Size = new System.Drawing.Size(800, 30);
            this.groundBottomPanel.TabIndex = 20;
            this.groundBottomPanel.Top = System.Drawing.Color.DarkGoldenrod;
            // 
            // Flight_X
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 680);
            this.Controls.Add(this.playerHP);
            this.Controls.Add(this.flyingEnemyPanel);
            this.Controls.Add(this.Player);
            this.Controls.Add(this.topPanel);
            this.Controls.Add(this.groundPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "Flight_X";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Flight_X";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Flight_X_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Flight_X_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.Player)).EndInit();
            this.flyingEnemyPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.flyingEnemy)).EndInit();
            this.playerHP.ResumeLayout(false);
            this.topPanel.ResumeLayout(false);
            this.topPanel.PerformLayout();
            this.InventoryPanel.ResumeLayout(false);
            this.ultimatePanel.ResumeLayout(false);
            this.ultimateBorder.ResumeLayout(false);
            this.usernamePanel.ResumeLayout(false);
            this.usernamePanel.PerformLayout();
            this.bulletsPanel.ResumeLayout(false);
            this.bulletsPanel.PerformLayout();
            this.bombsPanel.ResumeLayout(false);
            this.bombsPanel.PerformLayout();
            this.groundPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Close;
        private System.Windows.Forms.Button Minimize;
        private System.Windows.Forms.Button Maximize;
        private System.Windows.Forms.Panel InventoryPanel;
        private System.Windows.Forms.Panel usernamePanel;
        private System.Windows.Forms.Label currentScoreLabel;
        private System.Windows.Forms.Panel bulletsPanel;
        private System.Windows.Forms.Label bulletsLabel;
        private System.Windows.Forms.Panel bombsPanel;
        private System.Windows.Forms.Label bombsLabel;
        private System.Windows.Forms.Panel ultimatePanel;
        private System.Windows.Forms.Panel ultimateBorder;
        private GradientPanel groundPanel;
        private GradientPanel groundTopPanel;
        private GradientPanel groundBottomPanel;
        private GradientPanel topPanel;
        private GradientPanel ultimate;
        private System.Windows.Forms.Label usernameLabel;
        private System.Windows.Forms.PictureBox Player;
        private System.Windows.Forms.Panel flyingEnemyPanel;
        private System.Windows.Forms.PictureBox flyingEnemy;
        private System.Windows.Forms.Timer GeneralTimer;
        private System.Windows.Forms.Panel playerHP;
        private GradientPanel belowHalfHP;
        private GradientPanel aboveHalfHP;
    }
}