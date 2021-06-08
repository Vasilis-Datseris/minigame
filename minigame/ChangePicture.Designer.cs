
namespace minigame
{
    partial class ChangePicture
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChangePicture));
            this.Upload = new System.Windows.Forms.Button();
            this.RemovePicture = new System.Windows.Forms.Button();
            this.PicturesPanel = new System.Windows.Forms.Panel();
            this.ClearPicture = new System.Windows.Forms.PictureBox();
            this.UploadPicture = new System.Windows.Forms.PictureBox();
            this.PicturesPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ClearPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UploadPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // Upload
            // 
            this.Upload.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.Upload.BackColor = System.Drawing.Color.Transparent;
            this.Upload.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Upload.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Upload.Location = new System.Drawing.Point(78, 70);
            this.Upload.Name = "Upload";
            this.Upload.Size = new System.Drawing.Size(305, 79);
            this.Upload.TabIndex = 0;
            this.Upload.Text = "Upload Picture";
            this.Upload.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Upload.UseVisualStyleBackColor = false;
            this.Upload.Click += new System.EventHandler(this.Upload_Click);
            this.Upload.MouseEnter += new System.EventHandler(this.Upload_MouseEnter);
            // 
            // RemovePicture
            // 
            this.RemovePicture.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.RemovePicture.BackColor = System.Drawing.Color.Transparent;
            this.RemovePicture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.RemovePicture.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RemovePicture.Location = new System.Drawing.Point(78, 260);
            this.RemovePicture.Name = "RemovePicture";
            this.RemovePicture.Size = new System.Drawing.Size(305, 79);
            this.RemovePicture.TabIndex = 1;
            this.RemovePicture.Text = "Clear Picture";
            this.RemovePicture.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.RemovePicture.UseVisualStyleBackColor = false;
            this.RemovePicture.Click += new System.EventHandler(this.RemovePicture_Click);
            this.RemovePicture.MouseEnter += new System.EventHandler(this.RemovePicture_MouseEnter);
            // 
            // PicturesPanel
            // 
            this.PicturesPanel.BackColor = System.Drawing.Color.Transparent;
            this.PicturesPanel.Controls.Add(this.ClearPicture);
            this.PicturesPanel.Controls.Add(this.UploadPicture);
            this.PicturesPanel.Location = new System.Drawing.Point(108, 432);
            this.PicturesPanel.Name = "PicturesPanel";
            this.PicturesPanel.Size = new System.Drawing.Size(200, 100);
            this.PicturesPanel.TabIndex = 2;
            this.PicturesPanel.Visible = false;
            // 
            // ClearPicture
            // 
            this.ClearPicture.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ClearPicture.BackgroundImage")));
            this.ClearPicture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClearPicture.Dock = System.Windows.Forms.DockStyle.Right;
            this.ClearPicture.Location = new System.Drawing.Point(0, 0);
            this.ClearPicture.Name = "ClearPicture";
            this.ClearPicture.Size = new System.Drawing.Size(100, 100);
            this.ClearPicture.TabIndex = 1;
            this.ClearPicture.TabStop = false;
            // 
            // UploadPicture
            // 
            this.UploadPicture.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("UploadPicture.BackgroundImage")));
            this.UploadPicture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.UploadPicture.Dock = System.Windows.Forms.DockStyle.Right;
            this.UploadPicture.Location = new System.Drawing.Point(100, 0);
            this.UploadPicture.Name = "UploadPicture";
            this.UploadPicture.Size = new System.Drawing.Size(100, 100);
            this.UploadPicture.TabIndex = 0;
            this.UploadPicture.TabStop = false;
            // 
            // ChangePicture
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 576);
            this.Controls.Add(this.PicturesPanel);
            this.Controls.Add(this.RemovePicture);
            this.Controls.Add(this.Upload);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ChangePicture";
            this.Text = "ChangePicture";
            this.PicturesPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ClearPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UploadPicture)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Upload;
        private System.Windows.Forms.Button RemovePicture;
        private System.Windows.Forms.Panel PicturesPanel;
        private System.Windows.Forms.PictureBox UploadPicture;
        private System.Windows.Forms.PictureBox ClearPicture;
    }
}