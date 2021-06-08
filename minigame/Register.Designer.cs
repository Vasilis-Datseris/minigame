
namespace minigame
{
    partial class Register
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Register));
            this.CloseButton = new minigame.Details();
            this.RegisterGroupbox = new minigame.CstmGroupbox();
            this.Return = new System.Windows.Forms.Button();
            this.SubmitButton = new System.Windows.Forms.Button();
            this.WrongEmailRegister = new System.Windows.Forms.Label();
            this.WrongUsernameRegister = new System.Windows.Forms.Label();
            this.SpecializationText = new System.Windows.Forms.ComboBox();
            this.EmailText = new System.Windows.Forms.TextBox();
            this.UsernameText = new System.Windows.Forms.TextBox();
            this.SpecializationTag = new System.Windows.Forms.Label();
            this.EmailTag = new System.Windows.Forms.Label();
            this.UsernameTag = new System.Windows.Forms.Label();
            this.RegisterGroupbox.SuspendLayout();
            this.SuspendLayout();
            // 
            // CloseButton
            // 
            this.CloseButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CloseButton.BackColor = System.Drawing.Color.Transparent;
            this.CloseButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("CloseButton.BackgroundImage")));
            this.CloseButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.CloseButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CloseButton.Location = new System.Drawing.Point(674, -1);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(40, 40);
            this.CloseButton.TabIndex = 0;
            this.CloseButton.UseVisualStyleBackColor = false;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // RegisterGroupbox
            // 
            this.RegisterGroupbox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RegisterGroupbox.Controls.Add(this.Return);
            this.RegisterGroupbox.Controls.Add(this.SubmitButton);
            this.RegisterGroupbox.Controls.Add(this.WrongEmailRegister);
            this.RegisterGroupbox.Controls.Add(this.WrongUsernameRegister);
            this.RegisterGroupbox.Controls.Add(this.SpecializationText);
            this.RegisterGroupbox.Controls.Add(this.EmailText);
            this.RegisterGroupbox.Controls.Add(this.UsernameText);
            this.RegisterGroupbox.Controls.Add(this.SpecializationTag);
            this.RegisterGroupbox.Controls.Add(this.EmailTag);
            this.RegisterGroupbox.Controls.Add(this.UsernameTag);
            this.RegisterGroupbox.Font = new System.Drawing.Font("Engravers MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RegisterGroupbox.Location = new System.Drawing.Point(13, 13);
            this.RegisterGroupbox.Name = "RegisterGroupbox";
            this.RegisterGroupbox.Size = new System.Drawing.Size(688, 833);
            this.RegisterGroupbox.TabIndex = 0;
            this.RegisterGroupbox.TabStop = false;
            this.RegisterGroupbox.Text = "\nRegister";
            // 
            // Return
            // 
            this.Return.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Return.BackColor = System.Drawing.Color.Firebrick;
            this.Return.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Return.Location = new System.Drawing.Point(211, 623);
            this.Return.Name = "Return";
            this.Return.Size = new System.Drawing.Size(268, 60);
            this.Return.TabIndex = 7;
            this.Return.Text = "Cancel";
            this.Return.UseVisualStyleBackColor = false;
            this.Return.Click += new System.EventHandler(this.Return_Click);
            // 
            // SubmitButton
            // 
            this.SubmitButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SubmitButton.BackColor = System.Drawing.Color.Firebrick;
            this.SubmitButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.SubmitButton.Location = new System.Drawing.Point(211, 506);
            this.SubmitButton.Name = "SubmitButton";
            this.SubmitButton.Size = new System.Drawing.Size(268, 60);
            this.SubmitButton.TabIndex = 6;
            this.SubmitButton.Text = "Submit";
            this.SubmitButton.UseVisualStyleBackColor = false;
            this.SubmitButton.Click += new System.EventHandler(this.SubmitButton_Click);
            // 
            // WrongEmailRegister
            // 
            this.WrongEmailRegister.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.WrongEmailRegister.AutoSize = true;
            this.WrongEmailRegister.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WrongEmailRegister.ForeColor = System.Drawing.Color.Firebrick;
            this.WrongEmailRegister.Location = new System.Drawing.Point(186, 405);
            this.WrongEmailRegister.Name = "WrongEmailRegister";
            this.WrongEmailRegister.Size = new System.Drawing.Size(498, 29);
            this.WrongEmailRegister.TabIndex = 5;
            this.WrongEmailRegister.Text = "Wrong e-mail type. (Example@example.com)";
            this.WrongEmailRegister.Visible = false;
            // 
            // WrongUsernameRegister
            // 
            this.WrongUsernameRegister.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.WrongUsernameRegister.AutoSize = true;
            this.WrongUsernameRegister.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WrongUsernameRegister.ForeColor = System.Drawing.Color.Firebrick;
            this.WrongUsernameRegister.Location = new System.Drawing.Point(186, 356);
            this.WrongUsernameRegister.Name = "WrongUsernameRegister";
            this.WrongUsernameRegister.Size = new System.Drawing.Size(293, 29);
            this.WrongUsernameRegister.TabIndex = 4;
            this.WrongUsernameRegister.Text = "Wrong input for Username";
            this.WrongUsernameRegister.Visible = false;
            // 
            // SpecializationText
            // 
            this.SpecializationText.AllowDrop = true;
            this.SpecializationText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SpecializationText.BackColor = System.Drawing.Color.Silver;
            this.SpecializationText.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SpecializationText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SpecializationText.FormattingEnabled = true;
            this.SpecializationText.Items.AddRange(new object[] {
            "Πληροφορική",
            "Φυσική",
            "Μαθηματικά",
            "Χημεία",
            "Φιλολογία",
            "Παιδαγωγικά",
            "Ψυχολογία",
            "Ιατρική",
            "Μηχανολογία",
            "Διοίκηση",
            "Δημόσιος Τομέας"});
            this.SpecializationText.Location = new System.Drawing.Point(211, 287);
            this.SpecializationText.Name = "SpecializationText";
            this.SpecializationText.Size = new System.Drawing.Size(450, 37);
            this.SpecializationText.TabIndex = 3;
            // 
            // EmailText
            // 
            this.EmailText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.EmailText.BackColor = System.Drawing.Color.Silver;
            this.EmailText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.EmailText.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmailText.Location = new System.Drawing.Point(211, 239);
            this.EmailText.Name = "EmailText";
            this.EmailText.Size = new System.Drawing.Size(450, 32);
            this.EmailText.TabIndex = 1;
            this.EmailText.TextChanged += new System.EventHandler(this.EmailText_TextChanged);
            // 
            // UsernameText
            // 
            this.UsernameText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.UsernameText.BackColor = System.Drawing.Color.Silver;
            this.UsernameText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.UsernameText.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsernameText.Location = new System.Drawing.Point(211, 184);
            this.UsernameText.Name = "UsernameText";
            this.UsernameText.Size = new System.Drawing.Size(450, 32);
            this.UsernameText.TabIndex = 0;
            this.UsernameText.TextChanged += new System.EventHandler(this.UsernameText_TextChanged);
            // 
            // SpecializationTag
            // 
            this.SpecializationTag.AutoSize = true;
            this.SpecializationTag.BackColor = System.Drawing.Color.Transparent;
            this.SpecializationTag.Font = new System.Drawing.Font("Schadow BT", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SpecializationTag.Location = new System.Drawing.Point(3, 293);
            this.SpecializationTag.Name = "SpecializationTag";
            this.SpecializationTag.Size = new System.Drawing.Size(202, 29);
            this.SpecializationTag.TabIndex = 2;
            this.SpecializationTag.Text = "Specialization: ";
            // 
            // EmailTag
            // 
            this.EmailTag.AutoSize = true;
            this.EmailTag.BackColor = System.Drawing.Color.Transparent;
            this.EmailTag.Font = new System.Drawing.Font("Schadow BT", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmailTag.Location = new System.Drawing.Point(107, 242);
            this.EmailTag.Name = "EmailTag";
            this.EmailTag.Size = new System.Drawing.Size(98, 29);
            this.EmailTag.TabIndex = 1;
            this.EmailTag.Text = "Email: ";
            // 
            // UsernameTag
            // 
            this.UsernameTag.AutoSize = true;
            this.UsernameTag.BackColor = System.Drawing.Color.Transparent;
            this.UsernameTag.Font = new System.Drawing.Font("Schadow BT", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsernameTag.Location = new System.Drawing.Point(54, 187);
            this.UsernameTag.Name = "UsernameTag";
            this.UsernameTag.Size = new System.Drawing.Size(151, 29);
            this.UsernameTag.TabIndex = 0;
            this.UsernameTag.Text = "Username: ";
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(713, 867);
            this.Controls.Add(this.CloseButton);
            this.Controls.Add(this.RegisterGroupbox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Register";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Register";
            this.RegisterGroupbox.ResumeLayout(false);
            this.RegisterGroupbox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private CstmGroupbox RegisterGroupbox;
        private Details CloseButton;
        private System.Windows.Forms.TextBox UsernameText;
        private System.Windows.Forms.Label SpecializationTag;
        private System.Windows.Forms.Label EmailTag;
        private System.Windows.Forms.Label UsernameTag;
        private System.Windows.Forms.ComboBox SpecializationText;
        private System.Windows.Forms.TextBox EmailText;
        private System.Windows.Forms.Label WrongUsernameRegister;
        private System.Windows.Forms.Label WrongEmailRegister;
        private System.Windows.Forms.Button SubmitButton;
        private System.Windows.Forms.Button Return;
    }
}