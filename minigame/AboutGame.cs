using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace minigame
{
    public partial class AboutGame : Form
    {
        public AboutGame()  //Constructor
        {
            InitializeComponent();
        }
        protected override void OnPaintBackground(PaintEventArgs e) //Function to @Override Background color to Gradiend
        {
            using (LinearGradientBrush brush = new LinearGradientBrush(ClientRectangle,
                                                                    Variables.ColorFlag ? Color.SlateBlue : Color.MediumSlateBlue, //First Colors of Gradiend
                                                                    Variables.ColorFlag ? Color.Black : Color.SlateBlue, //Second Colors of Gradiend
                                                                    30F)) //Define Gradient color
            {
                e.Graphics.FillRectangle(brush, ClientRectangle); //Paint Rectangle
            }
            base.OnPaint(e); //Paint on screen

        }
        private void Maximize_Click(object sender, EventArgs e) //Button to Maximize window
        {
            if (WindowState == FormWindowState.Normal)
                WindowState = FormWindowState.Maximized; //Set Window to Fullscreen
            else
                WindowState = FormWindowState.Normal; //Set Window to normal Size
        }
        private void Close_Click(object sender, EventArgs e) => Close();//Button to close Form
        private void Minimize_Click(object sender, EventArgs e) => WindowState = FormWindowState.Minimized; //Button to Minimize window
    }
}
