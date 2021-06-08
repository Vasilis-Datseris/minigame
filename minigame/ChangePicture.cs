using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace minigame
{
    public partial class ChangePicture : Form
    {
        public ChangePicture()  //Constructor
        {
            InitializeComponent();
            UploadPicture.Parent = Upload;  //Align Parent of Picture 'Upload'
            ClearPicture.Parent = RemovePicture;    //Align Parent of Picture 'ClearPicture'
            setButtonsColors();
        }
        protected override void OnPaintBackground(PaintEventArgs e) //Function to @Override Background color to Gradiend
        {
            using (LinearGradientBrush brush = new LinearGradientBrush(ClientRectangle,
                                                                    Variables.ColorFlag ? Color.MidnightBlue : Color.LightGray, //First Colors of Gradiend
                                                                    Variables.ColorFlag ? Color.Black : Color.RoyalBlue, //Second Colors of Gradiend
                                                                    120F)) //Define Gradient color
            {
                e.Graphics.FillRectangle(brush, this.ClientRectangle); //Paint Rectangle
            }
            base.OnPaint(e); //Paint on screen

        }
        private void Upload_Click(object sender, EventArgs e)   //Function for user to Upload new Picture
        {

        }
        private void RemovePicture_Click(object sender, EventArgs e)    //Function to Clear Current Picture
        {

        }
        private void setButtonsColors()
        {
            Upload.ForeColor = Variables.ColorFlag ? Color.Khaki : Color.Cornsilk ;
            RemovePicture.ForeColor = Variables.ColorFlag ? Color.Khaki : Color.Cornsilk ;
        }

        private void Upload_MouseEnter(object sender, EventArgs e)
        {
            Upload.BackColor = Variables.ColorFlag ? Color.RoyalBlue : Color.CornflowerBlue ;
            RemovePicture.BackColor = Color.FromArgb(0, 0, 0, 0);
        }

        private void RemovePicture_MouseEnter(object sender, EventArgs e)
        {
            RemovePicture.BackColor = Variables.ColorFlag ? Color.RoyalBlue : Color.CornflowerBlue;
            Upload.BackColor = Color.FromArgb(0, 0, 0, 0);
        }
    }
}
