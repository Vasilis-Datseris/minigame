
namespace minigame
{
    partial class UnderConstruction
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
            this.WarningLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // WarningLabel
            // 
            this.WarningLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.WarningLabel.BackColor = System.Drawing.Color.Transparent;
            this.WarningLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.WarningLabel.Font = new System.Drawing.Font("Geometr212 BkCn BT", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WarningLabel.ForeColor = System.Drawing.Color.Peru;
            this.WarningLabel.Location = new System.Drawing.Point(12, 9);
            this.WarningLabel.Name = "WarningLabel";
            this.WarningLabel.Size = new System.Drawing.Size(626, 782);
            this.WarningLabel.TabIndex = 0;
            this.WarningLabel.Text = "Currently Under Construction!";
            this.WarningLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // UnderConstruction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(650, 800);
            this.Controls.Add(this.WarningLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "UnderConstruction";
            this.Text = "UnderConstruction";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label WarningLabel;
    }
}