
namespace minigame
{
    partial class ProfileTab
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProfileTab));
            this.ProfilePanel = new System.Windows.Forms.Panel();
            this.ProfilePicture = new System.Windows.Forms.PictureBox();
            this.MenuPanel = new System.Windows.Forms.Panel();
            this.NavigationPanel = new System.Windows.Forms.Panel();
            this.UsernameChange = new System.Windows.Forms.Button();
            this.PictureChange = new System.Windows.Forms.Button();
            this.LoaderForm = new System.Windows.Forms.Panel();
            this.ProfilePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProfilePicture)).BeginInit();
            this.MenuPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // ProfilePanel
            // 
            this.ProfilePanel.BackColor = System.Drawing.Color.Transparent;
            this.ProfilePanel.Controls.Add(this.ProfilePicture);
            this.ProfilePanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.ProfilePanel.Location = new System.Drawing.Point(0, 0);
            this.ProfilePanel.Name = "ProfilePanel";
            this.ProfilePanel.Size = new System.Drawing.Size(650, 224);
            this.ProfilePanel.TabIndex = 0;
            // 
            // ProfilePicture
            // 
            this.ProfilePicture.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ProfilePicture.BackgroundImage")));
            this.ProfilePicture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ProfilePicture.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ProfilePicture.Location = new System.Drawing.Point(0, 0);
            this.ProfilePicture.Name = "ProfilePicture";
            this.ProfilePicture.Size = new System.Drawing.Size(650, 224);
            this.ProfilePicture.TabIndex = 0;
            this.ProfilePicture.TabStop = false;
            // 
            // MenuPanel
            // 
            this.MenuPanel.BackColor = System.Drawing.Color.Transparent;
            this.MenuPanel.Controls.Add(this.NavigationPanel);
            this.MenuPanel.Controls.Add(this.UsernameChange);
            this.MenuPanel.Controls.Add(this.PictureChange);
            this.MenuPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.MenuPanel.Location = new System.Drawing.Point(0, 224);
            this.MenuPanel.Name = "MenuPanel";
            this.MenuPanel.Size = new System.Drawing.Size(200, 576);
            this.MenuPanel.TabIndex = 1;
            // 
            // NavigationPanel
            // 
            this.NavigationPanel.BackColor = System.Drawing.Color.SlateBlue;
            this.NavigationPanel.Location = new System.Drawing.Point(0, 21);
            this.NavigationPanel.Name = "NavigationPanel";
            this.NavigationPanel.Size = new System.Drawing.Size(5, 40);
            this.NavigationPanel.TabIndex = 2;
            // 
            // UsernameChange
            // 
            this.UsernameChange.Dock = System.Windows.Forms.DockStyle.Top;
            this.UsernameChange.FlatAppearance.BorderSize = 0;
            this.UsernameChange.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UsernameChange.Font = new System.Drawing.Font("Mongolian Baiti", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsernameChange.ForeColor = System.Drawing.Color.Beige;
            this.UsernameChange.Location = new System.Drawing.Point(0, 67);
            this.UsernameChange.Name = "UsernameChange";
            this.UsernameChange.Size = new System.Drawing.Size(200, 67);
            this.UsernameChange.TabIndex = 1;
            this.UsernameChange.Text = "Change Username";
            this.UsernameChange.UseVisualStyleBackColor = true;
            this.UsernameChange.Click += new System.EventHandler(this.UsernameChange_Click);
            this.UsernameChange.MouseLeave += new System.EventHandler(this.UsernameChange_MouseLeave);
            // 
            // PictureChange
            // 
            this.PictureChange.Dock = System.Windows.Forms.DockStyle.Top;
            this.PictureChange.FlatAppearance.BorderSize = 0;
            this.PictureChange.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PictureChange.Font = new System.Drawing.Font("Mongolian Baiti", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PictureChange.ForeColor = System.Drawing.Color.Beige;
            this.PictureChange.Location = new System.Drawing.Point(0, 0);
            this.PictureChange.Name = "PictureChange";
            this.PictureChange.Size = new System.Drawing.Size(200, 67);
            this.PictureChange.TabIndex = 0;
            this.PictureChange.Text = "Change Picture";
            this.PictureChange.UseVisualStyleBackColor = true;
            this.PictureChange.Click += new System.EventHandler(this.PictureChange_Click);
            this.PictureChange.MouseLeave += new System.EventHandler(this.PictureChange_MouseLeave);
            // 
            // LoaderForm
            // 
            this.LoaderForm.BackColor = System.Drawing.Color.Transparent;
            this.LoaderForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LoaderForm.Location = new System.Drawing.Point(200, 224);
            this.LoaderForm.Name = "LoaderForm";
            this.LoaderForm.Size = new System.Drawing.Size(450, 576);
            this.LoaderForm.TabIndex = 2;
            // 
            // ProfileTab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SlateBlue;
            this.ClientSize = new System.Drawing.Size(650, 800);
            this.Controls.Add(this.LoaderForm);
            this.Controls.Add(this.MenuPanel);
            this.Controls.Add(this.ProfilePanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ProfileTab";
            this.Text = "ProfileTab";
            this.ProfilePanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ProfilePicture)).EndInit();
            this.MenuPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel ProfilePanel;
        private System.Windows.Forms.PictureBox ProfilePicture;
        private System.Windows.Forms.Panel MenuPanel;
        private System.Windows.Forms.Button PictureChange;
        private System.Windows.Forms.Button UsernameChange;
        private System.Windows.Forms.Panel LoaderForm;
        private System.Windows.Forms.Panel NavigationPanel;
    }
}