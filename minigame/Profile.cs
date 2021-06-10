using System;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace minigame
{
    public partial class Profile : Form
    {
        int red = 0, green = 0, blue = 0;
        public Profile() //Constructor
        {
            InitializeComponent();
            DoubleBuffered = true; //Enable Double Buffered Graphics for smoother transitions
            UsernameLabel.Text = Variables.Username; //Change Username label to user's Username
            GamesPicture.Parent = GamesButton;  //Set Joystick's parent the Games Button so it docks to its container
            ScoresPicture.Parent = ScoresButton;    //Set Fairy's parent the Games Button so it docks to its container
            ProfilePicture.Parent = ProfileButton;   //Set Profile's parent the Games Button so it docks to its container
            LogoutPicture.Parent = Logout;  //Set Logout's parent the Games Button so it docks to its container
            GamesPicture.Show();
            ScoresPicture.Show();
            ProfilePicture.Show();
            HeadLabel.Text = "Welcome aboard "; //Set Title to Welcome
            NameLabel.Text = Variables.Username + "!";  //Welcome Message for user
            Variables.ColorFlag = DarkMode.IsOn;    //Set Variable's class boolean ColorFLag based on current Darkmode
            Testlabel.Text = Variables.ColorFlag.ToString();    //Show Value of ColorFlag to a Test-Label
            Variables.TimesPlayed = "0";    //Initialize Variable since Database is not connected
        }

        protected override void OnPaintBackground(PaintEventArgs e) //Function to @Override Background color to Gradiend
        {
            using (LinearGradientBrush brush = new LinearGradientBrush(ClientRectangle,
                                                                    DarkMode.IsOn ? Color.MidnightBlue : Color.LightGray, //First Colors of Gradiend
                                                                    DarkMode.IsOn ? Color.Black : Color.RoyalBlue, //Second Colors of Gradiend
                                                                    120F)) //Define Gradient color
            {
                e.Graphics.FillRectangle(brush, this.ClientRectangle); //Paint Rectangle
            }
            base.OnPaint(e); //Paint on screen

        }
        private async void Maximize_Click(object sender, EventArgs e) //Button to set Fullscreen/Normal size of Window
        {
            if (WindowState == FormWindowState.Normal)
            {
                WindowState = FormWindowState.Maximized; //Set Window to Fullscreen
            }
            else
            {
                WindowState = FormWindowState.Normal; //Set Window to normal Size
            }
            await Task.Delay(1);
            Invalidate();
            Refresh();
        }
        private void Close_Click(object sender, EventArgs e) 
            => Environment.Exit(0); //Button to Terminate Application 
        private void Minimize_Click(object sender, EventArgs e) 
            => WindowState = FormWindowState.Minimized; //Button to Minimize Window
        private void PictureButton_Click(object sender, EventArgs e) 
            => ProfileButton_Click(sender, e); //On-Click Event for Profile PictureButton
        /*private void PictureButton_Leave(object sender, EventArgs e) 
            => ProfileButton_Leave(sender, e); //Leave event for Profile PictureButton
        private void GamesButton_Leave(object sender, EventArgs e) 
            => GamesButton.BackColor = Color.MidnightBlue; //Leave event for Button Games
        private void ScoresButton_Leave(object sender, EventArgs e) 
            => ScoresButton.BackColor = Color.MidnightBlue; //Leave event for Button Scores
        private void ProfileButton_Leave(object sender, EventArgs e) 
            => ProfileButton.BackColor = Color.MidnightBlue; //Leave event for Button Profile
        private void Logout_Leave(object sender, EventArgs e) 
            => Logout.BackColor = Color.MidnightBlue; //Leave event for Button Logout*/
        private void GamesButton_Click(object sender, EventArgs e) //On-Click event for Button Games
        {
            //
            //  Custom Highlight On-Click & attach Navigation Panel
            //
            Navigation.BackColor = DarkMode.IsOn ? Color.Khaki : Color.Cornsilk;
            Navigation.Height = GamesButton.Height; //Panel Height = Button Height
            Navigation.Top = GamesButton.Top;   //Set Top Distance = Button Distance
            Navigation.Left = GamesButton.Left; //Set Left Distance = Button Distance
            //
            GamesButton.BackColor = DarkMode.IsOn ? System.Drawing.Color.RoyalBlue : System.Drawing.Color.CornflowerBlue; //Set Color to Highlight
            GamesButton.ForeColor = DarkMode.IsOn ? Color.Khaki : Color.Cornsilk; //Set font color to Highlight
            ScoresButton.BackColor = Color.MidnightBlue;
            ScoresButton.ForeColor = Color.FromArgb(0, 126, 249);
            ProfileButton.BackColor = Color.MidnightBlue;
            ProfileButton.ForeColor = Color.FromArgb(0, 126, 249);
            Logout.BackColor = Color.MidnightBlue;
            Logout.ForeColor = Color.FromArgb(0, 126, 249);
            HeadLabel.Text = GamesButton.Text; //Set Label to Button's name
            NameLabel.Hide();   //Hide Welcome Message
            //
            //  Load Custom Form to 'LoaderForm' Panel
            //
            LoaderForm.Controls.Clear();
            Games games = new Games() { TopLevel = false, TopMost = true };  //Create New Games Form
            games.FormBorderStyle = FormBorderStyle.None;   //Set Borderstyle to None
            games.Height = LoaderForm.Height;   //Adjust Height
            games.Width = LoaderForm.Width;     //Adjust Width
            LoaderForm.Controls.Add(games);    //Add Form to LoaderForm Panel
            games.Show();   //Show Form
        }
        private void ScoresButton_Click(object sender, EventArgs e) //On-Click event for Button Scores
        {
            //
            //  Custom Highlight On-Click & attach Navigation Panel
            //
            Navigation.BackColor = DarkMode.IsOn ? Color.Khaki : Color.Cornsilk;
            Navigation.Height = ScoresButton.Height;    //Panel Height = Button Height
            Navigation.Top = ScoresButton.Top;      //Set Top Distance = Button Distance
            Navigation.Left = ScoresButton.Left;    //Set Left Distance = Button Distance
            //
            ScoresButton.BackColor = DarkMode.IsOn ? System.Drawing.Color.RoyalBlue : System.Drawing.Color.CornflowerBlue;    //Set Color to Highlight
            ScoresButton.ForeColor = DarkMode.IsOn ? Color.Khaki : Color.Cornsilk; //Set font color to Highlight
            GamesButton.BackColor = Color.MidnightBlue;
            GamesButton.ForeColor = Color.FromArgb(0, 126, 249);
            ProfileButton.BackColor = Color.MidnightBlue;
            ProfileButton.ForeColor = Color.FromArgb(0, 126, 249);
            Logout.BackColor = Color.MidnightBlue;
            Logout.ForeColor = Color.FromArgb(0, 126, 249);
            HeadLabel.Text = ScoresButton.Text; //Set Label to Score's name
            NameLabel.Hide();   //Hide Welcome Message
            //
            //  Load Custom Form to 'LoaderForm' Panel
            //
            LoaderForm.Controls.Clear();
            Scores score = new Scores() { TopLevel = false, TopMost = true };  //Create New Scores Form
            score.FormBorderStyle = FormBorderStyle.None;   //Set Borderstyle to None
            score.Height = LoaderForm.Height;   //Adjust Height
            score.Width = LoaderForm.Width;     //Adjust Width
            LoaderForm.Controls.Add(score);    //Add Form to LoaderForm Panel
            score.Show();   //Show Form
        }
        private void ProfileButton_Click(object sender, EventArgs e)    //On-Click event for Button Profile
        {
            //
            //  Custom Highlight On-Click & attach Navigation Panel
            //
            Navigation.BackColor = DarkMode.IsOn ? Color.Khaki : Color.Cornsilk;
            Navigation.Height = ProfileButton.Height;   //Panel Height = Button Height
            Navigation.Top = ProfileButton.Top; //Set Top Distance = Button Distance
            Navigation.Left = ProfileButton.Left;   //Set Left Distance = Button Distance
            //
            ProfileButton.BackColor = DarkMode.IsOn ? System.Drawing.Color.RoyalBlue : System.Drawing.Color.CornflowerBlue;   //Set Color to Highlight
            ProfileButton.ForeColor = DarkMode.IsOn ? Color.Khaki : Color.Cornsilk; //Set font color to Highlight
            GamesButton.BackColor = Color.MidnightBlue;
            GamesButton.ForeColor = Color.FromArgb(0, 126, 249);
            ScoresButton.BackColor = Color.MidnightBlue;
            ScoresButton.ForeColor = Color.FromArgb(0, 126, 249);
            Logout.BackColor = Color.MidnightBlue;
            Logout.ForeColor = Color.FromArgb(0, 126, 249);
            HeadLabel.Text = ProfileButton.Text; //Set Label to Profile's name
            NameLabel.Hide();   //Hide Welcome Message
            //
            //  Load Custom Form to 'LoaderForm' Panel
            //
            LoaderForm.Controls.Clear();
            ProfileTab tab = new ProfileTab() { TopMost = true, TopLevel = false };
            tab.Height = LoaderForm.Height;
            tab.Width = LoaderForm.Width;
            LoaderForm.Controls.Add(tab);
            tab.Show();
        }
        private void Logout_Click(object sender, EventArgs e)   //On-Click event for Button Logout
        {
            //
            //  Custom Highlight On-Click & attach Navigation Panel
            //
            Navigation.BackColor = DarkMode.IsOn ? Color.Khaki : Color.Cornsilk;
            Navigation.Height = Logout.Height;  //Panel Height = Button Height
            Navigation.Top = Logout.Top;    //Set Top Distance = Button Distance
            Navigation.Left = Logout.Left;  //Set Left Distance = Button Distance
            //
            Logout.BackColor = DarkMode.IsOn ? System.Drawing.Color.RoyalBlue : System.Drawing.Color.CornflowerBlue;  //Set Color to Highlight
            Logout.ForeColor = DarkMode.IsOn ? Color.Khaki : Color.Cornsilk; //Set font color to Highlight
            GamesButton.BackColor = Color.MidnightBlue;
            GamesButton.ForeColor = Color.FromArgb(0, 126, 249);
            ScoresButton.BackColor = Color.MidnightBlue;
            ScoresButton.ForeColor = Color.FromArgb(0, 126, 249);
            ProfileButton.BackColor = Color.MidnightBlue;
            ProfileButton.ForeColor = Color.FromArgb(0, 126, 249);
            NameLabel.Hide();   //Hide Welcome Message
            Close();
        }
        private async void DarkMode_Click_1(object sender, EventArgs e) //Function For ToggleButton
        {
            DarkMode.BackColor = DarkMode.IsOn ? Color.MidnightBlue : Color.MidnightBlue; //Set ToggleButton's Backround Color based on activation
            HeadLabel.ForeColor = Variables.ColorFlag ? Color.RoyalBlue : Color.CornflowerBlue ;
            NameLabel.ForeColor = Variables.ColorFlag ? Color.RoyalBlue : Color.CornflowerBlue ;
            Variables.ColorFlag = DarkMode.IsOn;    //Set flag to False/True
            //Testlabel.Text = Variables.ColorFlag.ToString();
            //Testlabel.Show();
            Refresh(); //Refresh Page
            await Task.Delay(500); //Add a delay before it can be pressed again (Millisecond)
            Invalidate(); //Reload Page to change color
        }
        private void GamesButton_Enter(object sender, EventArgs e)  //Enter event for Button Enter
            => GamesButton.BackColor = Color.RoyalBlue;

        private async void Minimize_MouseEnter(object sender, EventArgs e)
        {
            int delay = 2;
            if (DarkMode.IsOn)
                MinimizeDefault();
            else
                MinimizeSky();
            while (green < 200)
            {
                Minimize.FlatAppearance.MouseOverBackColor = Color.FromArgb((green + 1) / 2, 0, green, 50);
                green += 10;
                this.Invalidate();
                await Task.Delay(delay);
            }
            green = 0;
        }

        private async void Minimize_MouseLeave(object sender, EventArgs e)
        {
            green = 0;
            MinimizeBlack();
            await Task.Delay(1);
            Minimize.BackColor = Color.FromArgb(0, 0, 0, 0); //Function to restore default upon leave hover on Close
            this.Invalidate();
        }

        private async void Maximize_MouseEnter(object sender, EventArgs e)
        {
            int delay = 2;
            if (DarkMode.IsOn)
                MaximizeDefault();
            else
                MaximizeSky();
            while (blue < 255)
            {
                Maximize.FlatAppearance.MouseOverBackColor = Color.FromArgb((blue + 1) / 2, 0, 55, blue);
                blue += 10;
                this.Invalidate();
                await Task.Delay(delay);
            }
            blue = 0;
        }

        private async void Maximize_MouseLeave(object sender, EventArgs e)
        {
            blue = 0;
            MaximizeBlack();
            await Task.Delay(1);
            Maximize.BackColor = Color.FromArgb(0, 0, 0, 0); //Function to restore default upon leave hover on Close
            this.Invalidate();
        }

        private async void Close_MouseEnter(object sender, EventArgs e)
        {
            int delay = 2;
            Close.FlatAppearance.BorderColor = Color.FromArgb(1, 1, 1, 1);
            if (Variables.ColorFlag)
                CloseDefault();
            else
                CloseSky();
            while (red < 230)
            {
                Close.FlatAppearance.MouseOverBackColor = Color.FromArgb((red + 1) / 2, red, 30, 0);
                red += 10;
                this.Invalidate();
                await Task.Delay(delay);
            }
            red = 0;
        }

        private async void Close_MouseLeave(object sender, EventArgs e)
        {
            red = 0;
            CloseBlack();
            await Task.Delay(1);
            Close.BackColor = Color.FromArgb(0, 0, 0, 0); //Function to restore default upon leave hover on Close
            this.Invalidate();
        }
        private void MinimizeSky()  //Function to change image on mouse Hover
            => Minimize.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.minimize_window_sky));
        private void MinimizeDefault()  //Function to change image on mouse Hover
            => Minimize.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.minimize_window_black));
        private void MinimizeBlack()    //Function to change image on mouse Hover
            => Minimize.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.minimize_window));
        private void MaximizeSky()  //Function to change image on mouse Hover
            => Maximize.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.maximize_window_sky));
        private void MaximizeDefault()  //Function to change image on mouse Hover
            => Maximize.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.maximize_window_black));
        private void MaximizeBlack()    //Function to change image on mouse Hover
            => Maximize.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.maximize_window));
        private void CloseSky() //Function to change image on mouse Hover
            => Close.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.Close_skyt));
        private void CloseDefault() //Function to change image on mouse Hover
            => Close.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.Close_black));
        private void CloseBlack()   //Function to change image on mouse Hover
            => Close.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.Close));
    }
}
