
namespace minigame
{
    partial class googleForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(googleForm));
            this.PictureboxPanel = new System.Windows.Forms.Panel();
            this.GpictureBox = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.IntroPanel = new System.Windows.Forms.Panel();
            this.IntroLabel2 = new System.Windows.Forms.Label();
            this.GooglePicturebox = new System.Windows.Forms.PictureBox();
            this.IntroLabel = new System.Windows.Forms.Label();
            this.Close = new System.Windows.Forms.Button();
            this.LoadPanel = new System.Windows.Forms.Panel();
            this.PictureboxPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GpictureBox)).BeginInit();
            this.panel1.SuspendLayout();
            this.IntroPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GooglePicturebox)).BeginInit();
            this.SuspendLayout();
            // 
            // PictureboxPanel
            // 
            this.PictureboxPanel.BackColor = System.Drawing.Color.Transparent;
            this.PictureboxPanel.Controls.Add(this.GpictureBox);
            this.PictureboxPanel.Controls.Add(this.panel1);
            this.PictureboxPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.PictureboxPanel.Location = new System.Drawing.Point(0, 0);
            this.PictureboxPanel.Name = "PictureboxPanel";
            this.PictureboxPanel.Size = new System.Drawing.Size(700, 290);
            this.PictureboxPanel.TabIndex = 0;
            // 
            // GpictureBox
            // 
            this.GpictureBox.BackColor = System.Drawing.Color.Transparent;
            this.GpictureBox.BackgroundImage = global::minigame.Properties.Resources.Google__G__Logo_svg;
            this.GpictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.GpictureBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.GpictureBox.Location = new System.Drawing.Point(0, 58);
            this.GpictureBox.Name = "GpictureBox";
            this.GpictureBox.Size = new System.Drawing.Size(700, 229);
            this.GpictureBox.TabIndex = 1;
            this.GpictureBox.TabStop = false;
            this.GpictureBox.Click += new System.EventHandler(this.GpictureBox_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.IntroPanel);
            this.panel1.Controls.Add(this.Close);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.panel1.Size = new System.Drawing.Size(700, 58);
            this.panel1.TabIndex = 18;
            // 
            // IntroPanel
            // 
            this.IntroPanel.BackColor = System.Drawing.Color.Transparent;
            this.IntroPanel.Controls.Add(this.IntroLabel2);
            this.IntroPanel.Controls.Add(this.GooglePicturebox);
            this.IntroPanel.Controls.Add(this.IntroLabel);
            this.IntroPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.IntroPanel.Location = new System.Drawing.Point(0, 0);
            this.IntroPanel.Name = "IntroPanel";
            this.IntroPanel.Padding = new System.Windows.Forms.Padding(10);
            this.IntroPanel.Size = new System.Drawing.Size(515, 58);
            this.IntroPanel.TabIndex = 0;
            // 
            // IntroLabel2
            // 
            this.IntroLabel2.AutoSize = true;
            this.IntroLabel2.BackColor = System.Drawing.Color.Transparent;
            this.IntroLabel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.IntroLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IntroLabel2.Location = new System.Drawing.Point(267, 10);
            this.IntroLabel2.Name = "IntroLabel2";
            this.IntroLabel2.Size = new System.Drawing.Size(104, 29);
            this.IntroLabel2.TabIndex = 2;
            this.IntroLabel2.Text = " Account";
            this.IntroLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // GooglePicturebox
            // 
            this.GooglePicturebox.BackColor = System.Drawing.Color.Transparent;
            this.GooglePicturebox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("GooglePicturebox.BackgroundImage")));
            this.GooglePicturebox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.GooglePicturebox.Dock = System.Windows.Forms.DockStyle.Left;
            this.GooglePicturebox.Location = new System.Drawing.Point(167, 10);
            this.GooglePicturebox.Name = "GooglePicturebox";
            this.GooglePicturebox.Size = new System.Drawing.Size(100, 38);
            this.GooglePicturebox.TabIndex = 3;
            this.GooglePicturebox.TabStop = false;
            // 
            // IntroLabel
            // 
            this.IntroLabel.AutoSize = true;
            this.IntroLabel.BackColor = System.Drawing.Color.Transparent;
            this.IntroLabel.Dock = System.Windows.Forms.DockStyle.Left;
            this.IntroLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IntroLabel.Location = new System.Drawing.Point(10, 10);
            this.IntroLabel.Name = "IntroLabel";
            this.IntroLabel.Size = new System.Drawing.Size(157, 29);
            this.IntroLabel.TabIndex = 0;
            this.IntroLabel.Text = "Connect with ";
            this.IntroLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Close
            // 
            this.Close.BackColor = System.Drawing.Color.Transparent;
            this.Close.BackgroundImage = global::minigame.Properties.Resources.Close_black;
            this.Close.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Close.Dock = System.Windows.Forms.DockStyle.Right;
            this.Close.FlatAppearance.BorderSize = 0;
            this.Close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Close.Location = new System.Drawing.Point(645, 0);
            this.Close.Name = "Close";
            this.Close.Size = new System.Drawing.Size(50, 58);
            this.Close.TabIndex = 17;
            this.Close.UseVisualStyleBackColor = false;
            this.Close.Click += new System.EventHandler(this.Close_Click);
            // 
            // LoadPanel
            // 
            this.LoadPanel.BackColor = System.Drawing.Color.Transparent;
            this.LoadPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LoadPanel.Location = new System.Drawing.Point(0, 290);
            this.LoadPanel.Name = "LoadPanel";
            this.LoadPanel.Size = new System.Drawing.Size(700, 510);
            this.LoadPanel.TabIndex = 1;
            // 
            // googleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(700, 800);
            this.Controls.Add(this.LoadPanel);
            this.Controls.Add(this.PictureboxPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "googleForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "googleForm";
            this.PictureboxPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GpictureBox)).EndInit();
            this.panel1.ResumeLayout(false);
            this.IntroPanel.ResumeLayout(false);
            this.IntroPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GooglePicturebox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PictureboxPanel;
        private System.Windows.Forms.PictureBox GpictureBox;
        private System.Windows.Forms.Label IntroLabel;
        private System.Windows.Forms.Panel IntroPanel;
        private System.Windows.Forms.Label IntroLabel2;
        private System.Windows.Forms.PictureBox GooglePicturebox;
        private System.Windows.Forms.Button Close;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel LoadPanel;
    }
}