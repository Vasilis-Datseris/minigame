using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace minigame
{
    public partial class Scores : Form
    {
        public Scores() //Constructor
        {
            InitializeComponent();
            Username.Text = Variables.Username;     //Update stats to Form
            Highscore.Text = Variables.Highscore;   //
            Played.Text = Variables.TimesPlayed;    //
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
        private void SlotMachine_Leave(object sender, EventArgs e)
            => SlotMachine.BackColor = Color.Transparent; //Leave Event for Button Slot-Machine
        private void ClassicChess_Leave(object sender, EventArgs e)
            => ClassicChess.BackColor = Color.Transparent; //Leave Event for Button Classic-Chess
        private void Backgammon_Leave(object sender, EventArgs e)
            => Backgammon.BackColor = Color.Transparent; //Leave Event for Button Backgammon
        private void SlotMachine_Click(object sender, EventArgs e)  //On-Click Event for Button Slot-Machine
        {
            //
            //  Custom Highlight On-Click & attach Navigation Panel
            //
            NavigationPanel.Height = SlotMachine.Height; //Panel Height = Button Height
            NavigationPanel.Top = SlotMachine.Top;   //Set Top Distance = Button Distance
            NavigationPanel.Left = SlotMachine.Left; //Set Left Distance = Button Distance
            NavigationPanel.BackColor = Variables.ColorFlag ? Color.Khaki : Color.Cornsilk;
            SlotMachine.BackColor = Variables.ColorFlag ? System.Drawing.Color.RoyalBlue : System.Drawing.Color.CornflowerBlue ; //Set Color to Highlight
            ClassicChess.BackColor = Color.FromArgb(0, 0, 0, 0);
            Backgammon.BackColor = Color.FromArgb(0, 0, 0, 0);
            //
            //  Load Custom Form to 'LoaderForm' Panel
            //
            LoaderForm.Controls.Clear();   //Clear Current Form loaded
            SlotStats stats = new SlotStats() { TopLevel = false, TopMost = true };  //Create New Scores Form
            stats.FormBorderStyle = FormBorderStyle.None;   //Set Borderstyle to None
            stats.Height = LoaderForm.Height;   //Adjust Height
            stats.Width = LoaderForm.Width;     //Adjust Width
            //stats.Dock = DockStyle.Fill;    //Adjust dock type of Slot-Stats
            LoaderForm.Controls.Add(stats);    //Add Form to LoaderForm Panel
            stats.Show();
        }
        private void ClassicChess_Click(object sender, EventArgs e) //On-Click Event for Button Classic-Chess
        {
            //
            //  Custom Highlight On-Click & attach Navigation Panel
            //
            NavigationPanel.BackColor = Variables.ColorFlag ? Color.Khaki : Color.Cornsilk;
            NavigationPanel.Height = ClassicChess.Height; //Panel Height = Button Height
            NavigationPanel.Top = ClassicChess.Top;   //Set Top Distance = Button Distance
            NavigationPanel.Left = ClassicChess.Left; //Set Left Distance = Button Distance
            ClassicChess.BackColor = Variables.ColorFlag ? System.Drawing.Color.RoyalBlue : System.Drawing.Color.CornflowerBlue ; //Set Color to Highlight
            SlotMachine.BackColor = Color.FromArgb(0, 0, 0, 0);
            Backgammon.BackColor = Color.FromArgb(0, 0, 0, 0);
            //
            //  Load Custom Form to 'LoaderForm' Panel
            //
            CurrentlyUnderConstruction();   //Show label
            HidePrevious();                 //Hide other Elements
            Invalidate();
        }
        private void Backgammon_Click(object sender, EventArgs e)   //On-Click Event for Button Backgammon
        {
            //
            //  Custom Highlight On-Click & attach Navigation Panel
            //
            NavigationPanel.BackColor = Variables.ColorFlag ? Color.Khaki : Color.Cornsilk;
            NavigationPanel.Height = Backgammon.Height; //Panel Height = Button Height
            NavigationPanel.Top = Backgammon.Top;   //Set Top Distance = Button Distance
            NavigationPanel.Left = Backgammon.Left; //Set Left Distance = Button Distance
            Backgammon.BackColor = Variables.ColorFlag ? System.Drawing.Color.RoyalBlue : System.Drawing.Color.CornflowerBlue ; //Set Color to Highlight
            ClassicChess.BackColor = Color.FromArgb(0, 0, 0, 0);
            SlotMachine.BackColor = Color.FromArgb(0, 0, 0, 0);
            //
            //  Load Custom Form to 'LoaderForm' Panel
            //
            CurrentlyUnderConstruction();   //Show label
            HidePrevious();                 //Hide other Elements
            Invalidate();
        }
        private void CurrentlyUnderConstruction()   //Function to load Under Construction Page
        {
            LoaderForm.Controls.Clear();
            UnderConstruction mustFix = new UnderConstruction() { TopLevel = false, TopMost = true };  //Create New Scores Form
            mustFix.FormBorderStyle = FormBorderStyle.None;   //Set Borderstyle to None
            mustFix.Height = LoaderForm.Height;   //Adjust Height
            mustFix.Width = LoaderForm.Width;     //Adjust Width
            LoaderForm.Controls.Add(mustFix);    //Add Form to LoaderForm Panel
            mustFix.Show();   //Show Form
        }
        private void HidePrevious() //Hide Slot Machince's Stats
        {
            SlotPicture.Hide(); //Hide picture of Slot
            UsernameLabel.Hide();   //
            Username.Hide();//Hide Username
            HighScoreLabel.Hide();  //
            Highscore.Hide();   //Hide Highscore
            PlayedLabel.Hide(); //
            Played.Hide();      //Hide times Played
        }
    }
}