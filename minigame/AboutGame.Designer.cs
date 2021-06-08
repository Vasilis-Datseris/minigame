
namespace minigame
{
    partial class AboutGame
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AboutGame));
            this.Minimize = new minigame.Details();
            this.Maximize = new minigame.Details();
            this.Close = new minigame.Details();
            this.SlotMachineImage = new System.Windows.Forms.PictureBox();
            this.Info = new System.Windows.Forms.Label();
            this.Maker = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.SlotMachineImage)).BeginInit();
            this.SuspendLayout();
            // 
            // Minimize
            // 
            this.Minimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Minimize.BackColor = System.Drawing.Color.Transparent;
            this.Minimize.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Minimize.BackgroundImage")));
            this.Minimize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Minimize.FlatAppearance.BorderSize = 0;
            this.Minimize.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Minimize.Location = new System.Drawing.Point(564, 12);
            this.Minimize.Name = "Minimize";
            this.Minimize.Size = new System.Drawing.Size(50, 50);
            this.Minimize.TabIndex = 22;
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
            this.Maximize.Location = new System.Drawing.Point(530, -4);
            this.Maximize.Name = "Maximize";
            this.Maximize.Size = new System.Drawing.Size(50, 50);
            this.Maximize.TabIndex = 21;
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
            this.Close.Location = new System.Drawing.Point(601, -4);
            this.Close.Name = "Close";
            this.Close.Size = new System.Drawing.Size(50, 50);
            this.Close.TabIndex = 20;
            this.Close.UseVisualStyleBackColor = false;
            this.Close.Click += new System.EventHandler(this.Close_Click);
            // 
            // SlotMachineImage
            // 
            this.SlotMachineImage.BackColor = System.Drawing.Color.Transparent;
            this.SlotMachineImage.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("SlotMachineImage.BackgroundImage")));
            this.SlotMachineImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.SlotMachineImage.Location = new System.Drawing.Point(72, 72);
            this.SlotMachineImage.Name = "SlotMachineImage";
            this.SlotMachineImage.Size = new System.Drawing.Size(508, 368);
            this.SlotMachineImage.TabIndex = 23;
            this.SlotMachineImage.TabStop = false;
            // 
            // Info
            // 
            this.Info.AutoSize = true;
            this.Info.BackColor = System.Drawing.Color.Transparent;
            this.Info.Font = new System.Drawing.Font("News706 BT", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Info.Location = new System.Drawing.Point(72, 472);
            this.Info.Name = "Info";
            this.Info.Size = new System.Drawing.Size(367, 24);
            this.Info.TabIndex = 24;
            this.Info.Text = "Παιχνίδι που εξομοιώνει ένα Slot Machine.";
            // 
            // Maker
            // 
            this.Maker.AutoSize = true;
            this.Maker.BackColor = System.Drawing.Color.Transparent;
            this.Maker.Font = new System.Drawing.Font("News706 BT", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Maker.Location = new System.Drawing.Point(72, 522);
            this.Maker.Name = "Maker";
            this.Maker.Size = new System.Drawing.Size(164, 24);
            this.Maker.TabIndex = 25;
            this.Maker.Text = "2021 - vDatseris";
            // 
            // AboutGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(650, 800);
            this.Controls.Add(this.Maker);
            this.Controls.Add(this.Info);
            this.Controls.Add(this.SlotMachineImage);
            this.Controls.Add(this.Minimize);
            this.Controls.Add(this.Maximize);
            this.Controls.Add(this.Close);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AboutGame";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AboutGame";
            ((System.ComponentModel.ISupportInitialize)(this.SlotMachineImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Details Minimize;
        private Details Maximize;
        private Details Close;
        private System.Windows.Forms.PictureBox SlotMachineImage;
        private System.Windows.Forms.Label Info;
        private System.Windows.Forms.Label Maker;
    }
}