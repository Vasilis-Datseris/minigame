using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace minigame
{
    public partial class SlotMachine : Form
    {
        //Form's Variables
        Random rand = new Random();
        public SlotMachine()    //Constructor
        {
            InitializeComponent();
            DoubleBuffered = true;
            GameGroup.Text = "\nThe Unable-Hand\n (Ο Κουλοχέρης)";  //Text for Custom GroupBox
            UsernameLabel.Text = "User: "+ Variables.Username; //Set User's Username
            Variables.Currentscore = "20";  //Set Current score at 20 for beggining
            ScoreLabel.Text = Variables.Currentscore;   //Current user's Score
            HighscoreLabel.Text = Variables.Highscore;  //All times highScore
            Variables.Highscore = "0";
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
        private void Maximize_Click(object sender, EventArgs e) //Button to Maximize window
        {
            if (WindowState == FormWindowState.Normal)
                WindowState = FormWindowState.Maximized; //Set Window to Fullscreen
            else
                WindowState = FormWindowState.Normal; //Set Window to normal Size
        }
        private void Close_Click(object sender, EventArgs e) 
            => Close(); //Button to close Form
        private void Minimize_Click(object sender, EventArgs e) 
            => WindowState = FormWindowState.Minimized; //Button to Minimize window
        private void PlayButton_Click(object sender, EventArgs e)   //Round Start!
        {
            SetScores();    //Call function to Ajdust and Check currentScore/highScore
            Variables.Currentscore = (Int32.Parse(Variables.Currentscore) - 1).ToString();  //Remove each time 1 coin from Score
            ScoreLabel.Text = Variables.Currentscore;   //Refresh Score
            HighscoreLabel.Text = Variables.Highscore;  //Refresh HighScore
            Variables.TimesPlayed = (Int32.Parse(Variables.TimesPlayed) + 1).ToString();    //Count how many times user Played
            HandDown();
            Vital();    //Call funciton for Sudden-End
            BigWinner();    //Call function to check for Big Winner
            SweetMoney();   //Call function to multiply Current Score
            SetScores();    //Call function to Ajdust and Check currentScore/highScore
        }
        private void EndGame_Click(object sender, EventArgs e)  //On-Click Event for EndGame Button
        {
            SetScores();    //Call Function to adjust and store HighScore
            MessageBox.Show("You ended this Game.\nYou take "+ Variables.Currentscore +"€"); //Cash-out
            Close();   //Close current Form
        }
        private void SetScores()    //Function to Set Scores && Ends Game when out of coins
        {
            if (Int32.Parse(Variables.Currentscore) > Int32.Parse(Variables.Highscore))
            {
                Variables.Highscore = Variables.Currentscore;   //Set CurrentScore as HighScore 
            }

            if (Variables.Currentscore == "0")
            {
                MessageBox.Show("Loser!!! Game Over", "Slot Machine");  //End Game message if out of coins
                PlayButton.Enabled = false; //Disable PlayButton
            }
        }
        private void SweetMoney()   //Function to earn Money
        {
            if (First.Text == "7" && Second.Text == "7" && Third.Text == "7")   // 7 - 7 - 7
            {
                MessageBox.Show("Lucky-Triple 7-7-7!!!");   //Lucky-Triple for three "7" in a row!
                Variables.Currentscore = (Int32.Parse(Variables.Currentscore) * 7).ToString();  //Conversion and adjust of Current Score
            }
            else if ((First.Text == "7" && Second.Text == "7")
                || (Second.Text == "7" && Third.Text == "7"))    // 7 - 7 
            {
                MessageBox.Show("Lucky-Double 7-7!");   //Lucky-Double for two "7" in a row!
                Variables.Currentscore = (Int32.Parse(Variables.Currentscore) * 2).ToString();  //Conversion and adjust of Current Score
            }
            else if (First.Text == Second.Text && Second.Text == Third.Text)    //Three in a row
            {
                MessageBox.Show("Nice Shot!");   //Nice Shot!
                Variables.Currentscore = (Int32.Parse(Variables.Currentscore) * 3).ToString();  //Conversion and adjust of Current Score
            }
        }
        private void Vital()    //Function for Sudden-End
        {
            if (First.Text == "0" && Second.Text == "0" && Third.Text == "0")
                Variables.Currentscore = "0";   //Set coins to 0 if three Zero in a row
        }
        private void BigWinner()    //Function to Celebrate Huge Cash-out
        {
            if (Int32.Parse(Variables.Currentscore) >= 1000)
            {
                MessageBox.Show("Big Winner!!!\nSlot Machine is out of money.", "Slot Machine");    //Messagebox to Celebrate Winner
                PlayButton.Enabled = false; //Disable PlayButton
                Variables.Highscore = "1000";   //Cash-out && store
            }
        }
        private void HandDown()    //Function to Shuffle numbers (User pulled the Arm Bandit)
        {
            First.Text = rand.Next(0, 7).ToString();    //1rst Lucky Number
            Second.Text = rand.Next(0, 7).ToString();   //2nd Lucky Number
            Third.Text = rand.Next(0, 7).ToString();    //3rd Lucky Number
        }
        private void aboutSlotMachineToolStripMenuItem_Click(object sender, EventArgs e)    //About Game Tab
        {
            AboutGame game = new AboutGame();
            this.Hide();
            game.ShowDialog();
            this.Show();
        }
    }
}
