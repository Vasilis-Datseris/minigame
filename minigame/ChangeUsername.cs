using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace minigame
{
    public partial class ChangeUsername : Form
    {
        public ChangeUsername() //Constructor
        {
            InitializeComponent();
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
        private void Submit_Click(object sender, EventArgs e) 
            => Variables.Username = UserNameText.Text;  //Function to Change User's Username
        private void setForeColor()
            => Submit.ForeColor = Variables.ColorFlag ? Color.Khaki : Color.Cornsilk ;
        private void Submit_MouseEnter(object sender, EventArgs e)
            => Submit.BackColor = Variables.ColorFlag ? Color.RoyalBlue : Color.CornflowerBlue ;
        private void Submit_MouseLeave(object sender, EventArgs e)
            => Submit.BackColor = Color.FromArgb(0, 0, 0, 0);
    }
}
