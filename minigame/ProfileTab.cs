using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace minigame
{
    public partial class ProfileTab : Form
    {
        public ProfileTab() //Constructor
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
        private void PictureChange_Click(object sender, EventArgs e)    //Button to change Profile-Picture
        {
            //
            //  Custom Highlight On-Click & attach Navigation Panel
            //
            NavigationPanel.Height = PictureChange.Height; //Panel Height = Button Height
            NavigationPanel.Top = PictureChange.Top;   //Set Top Distance = Button Distance
            NavigationPanel.Left = PictureChange.Left; //Set Left Distance = Button Distance
            NavigationPanel.BackColor = Variables.ColorFlag ? Color.Khaki : Color.Cornsilk; //Set font color to Highlight
            PictureChange.ForeColor = Variables.ColorFlag ? Color.Khaki : Color.Cornsilk;
            PictureChange.BackColor = Variables.ColorFlag ? Color.RoyalBlue : Color.CornflowerBlue ;
            UsernameChange.BackColor = Color.FromArgb(0, 0, 0, 0);
            //
            //  Load Custom Form to 'LoaderForm' Panel
            //
            this.LoaderForm.Controls.Clear();   //Clear Current Form loaded
            ChangePicture pic = new ChangePicture() { TopLevel = false, TopMost = true };  //Create New Scores Form
            pic.FormBorderStyle = FormBorderStyle.None;   //Set Borderstyle to None
            pic.Height = LoaderForm.Height;   //Adjust Height
            pic.Width = LoaderForm.Width;     //Adjust Width
            //stats.Dock = DockStyle.Fill;    //Adjust dock type of Slot-Stats
            this.LoaderForm.Controls.Add(pic);    //Add Form to LoaderForm Panel
            pic.Show();
        }
        private void UsernameChange_Click(object sender, EventArgs e)   //Button to change Username
        {
            //
            //  Custom Highlight On-Click & attach Navigation Panel
            //
            NavigationPanel.Height = UsernameChange.Height; //Panel Height = Button Height
            NavigationPanel.Top = UsernameChange.Top;   //Set Top Distance = Button Distance
            NavigationPanel.Left = UsernameChange.Left; //Set Left Distance = Button Distance
            NavigationPanel.BackColor = Variables.ColorFlag ? Color.Khaki : Color.Cornsilk; //Set font color to Highlight
            UsernameChange.ForeColor = Variables.ColorFlag ? Color.Khaki : Color.Cornsilk;
            UsernameChange.BackColor = Variables.ColorFlag ? Color.RoyalBlue : Color.CornflowerBlue;
            PictureChange.BackColor = Color.FromArgb(0, 0, 0, 0);
            //
            //  Load Custom Form to 'LoaderForm' Panel
            //
            this.LoaderForm.Controls.Clear();   //Clear Current Form loaded
            ChangeUsername user = new ChangeUsername() { TopLevel = false, TopMost = true };  //Create New Scores Form
            user.FormBorderStyle = FormBorderStyle.None;   //Set Borderstyle to None
            user.Height = LoaderForm.Height;   //Adjust Height
            user.Width = LoaderForm.Width;     //Adjust Width
            //stats.Dock = DockStyle.Fill;    //Adjust dock type of Slot-Stats
            this.LoaderForm.Controls.Add(user);    //Add Form to LoaderForm Panel
            user.Show();
        }

        private void PictureChange_MouseLeave(object sender, EventArgs e)
            => PictureChange.BackColor = Color.FromArgb(0, 0, 0, 0);

        private void UsernameChange_MouseLeave(object sender, EventArgs e)
            => UsernameChange.BackColor = Color.FromArgb(0, 0, 0, 0);
    }
}
