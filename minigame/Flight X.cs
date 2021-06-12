using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace minigame
{
    public partial class Flight_X : Form
    {
        int x, z;
        bool bombInternal = true, fireGunInternal = true, ultimateReady = false, goUp = false, goDown = false, goRight = false, goLeft = false, goBomb = false, goGun = false;

        Base playerCharacter = new Base(100, 99, 10, 3, 25, 5, true);    //Initialize Player's object Class
        //Bitmap bmp = new Bitmap(minigame.Properties.Resources.Player);

        public Flight_X()
        {
            InitializeComponent();
            DoubleBuffered = true;
            usernameLabel.Text = Variables.Username;    //Set Username
            belowHalfHP.SendToBack();   //Align Player HealthBar
            GeneralTimer.Interval = 2000;   //Set the clock Interval
            GeneralTimer.Start(); //Initiate our Timer
            ultimate.Width = 0;
            cycleLevels();
            //rotation(bmp, 15);
            //Player.Image = bmp;
            
        }

        protected override void OnPaintBackground(PaintEventArgs e) //Overriden System's Function
        {
            using (LinearGradientBrush brush = new LinearGradientBrush(ClientRectangle,
                                                                        Variables.ColorFlag ? Color.Black : Color.Khaki,
                                                                        Variables.ColorFlag ? Color.MidnightBlue : Color.White,
                                                                        90f))
            {
                e.Graphics.FillRectangle(brush, this.ClientRectangle);
                
            }
            base.OnPaint(e);
        }
        private void bringSea() // Sea Level
        {
            groundTopPanel.Top = Color.DodgerBlue;
            groundTopPanel.Bottom = Color.SkyBlue;
            groundPanel.Top = Color.SkyBlue;
            groundPanel.Bottom = Color.RoyalBlue;
            groundBottomPanel.Top = Color.RoyalBlue;
            groundBottomPanel.Bottom = Color.Navy;
            groundPanel.Invalidate();
        }
        private void bringDessert() // Dessert Level
        {
            groundTopPanel.Top = Color.Gold;
            groundTopPanel.Bottom = Color.Olive;
            groundPanel.Top = Color.Olive;
            groundPanel.Bottom = Color.Goldenrod;
            groundBottomPanel.Top = Color.DarkGoldenrod;
            groundBottomPanel.Bottom = Color.DarkOrange;
            groundPanel.Invalidate();
        }
        private void bringJungle()  // Jungler Level
        {
            groundTopPanel.Top = Color.ForestGreen;
            groundTopPanel.Bottom = Color.MediumSeaGreen;
            groundPanel.Top = Color.MediumSeaGreen;
            groundPanel.Bottom = Color.Olive;
            groundBottomPanel.Top = Color.DarkGreen;
            groundBottomPanel.Bottom = Color.Olive;
            groundPanel.Invalidate();
        }
        private void Close_Click(object sender, EventArgs e)   //Close Button
            => this.Close();
        private void Minimize_Click(object sender, EventArgs e) //Minimize Button
            => WindowState = FormWindowState.Minimized;
        private async void Maximize_Click(object sender, EventArgs e)   //Maximize Button
        {
            if (WindowState == FormWindowState.Normal)
            {
                WindowState = FormWindowState.Maximized; //Set Window to Fullscreen
            }
            else
            {
                WindowState = FormWindowState.Normal; //Set Window to normal Size
            }
            await Task.Delay(1);   //Set Delay
            this.Invalidate();  //Refresh colors
        }
        private async void playerAnimation()    //Player's Gif Animation
        {

        }

        private async void cycleLevels()
        {
            bringDessert();
            await Task.Delay(5000);
            bringJungle();
            await Task.Delay(5000);
            bringSea();
        }

        private async void Flight_X_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.W || e.KeyCode == Keys.Up)
                goUp = false;
            if (e.KeyCode == Keys.S || e.KeyCode == Keys.Down)
                goDown = false;
            if (e.KeyCode == Keys.A || e.KeyCode == Keys.Left)
                goLeft = false;
            if (e.KeyCode == Keys.D || e.KeyCode == Keys.Right)
                goRight = false;
            if (e.KeyCode == Keys.Space)
                goBomb = false;
            if (e.KeyCode == Keys.B)
                goGun = false;
        }

        private async void Flight_X_KeyDown(object sender, KeyEventArgs e)    //User inputs to handle airplane
        {
            Console.WriteLine(e.KeyCode);
            if (e.KeyCode == Keys.W || e.KeyData == Keys.Up)
                goUp = true;
            if (e.KeyCode == Keys.S || e.KeyCode == Keys.Down)
                goDown = true;
            if (e.KeyCode == Keys.A || e.KeyCode == Keys.Left)
                goLeft = true;
            if (e.KeyCode == Keys.D || e.KeyCode == Keys.Right)
                goRight = true;
            if (e.KeyCode == Keys.Space)
                goBomb = true;
            if (e.KeyCode == Keys.B)
                goGun = true; 

            if (goUp)    //Assign W to move Up
            {
                if (Player.Location.Y > topPanel.Height)
                {
                    Player.Location = new Point(Player.Location.X, Player.Location.Y - playerCharacter.moveSpeed);  //Move Up
                }
            }
            if (goDown) //Assign S to move Down
            {
                if (Player.Location.Y + Player.Height / 3 < groundPanel.Location.Y - groundPanel.Height)
                    Player.Location = new Point(Player.Location.X, Player.Location.Y + playerCharacter.moveSpeed);  //Move Down
            }
            if (goLeft)   //Assign A to move Left
            {
                if (Player.Location.X > playerHP.Width)
                    Player.Location = new Point(Player.Location.X - playerCharacter.moveSpeed, Player.Location.Y);  //Move Left
            }
            if (goRight)   //Assign D to move Right
            {
                if (Player.Location.X + Player.Width < flyingEnemyPanel.Location.X)
                    Player.Location = new Point(Player.Location.X + playerCharacter.moveSpeed, Player.Location.Y);  //Move Right
            }
            if (goBomb && fireGunInternal)   //Assign Spacebar to fire ammo
            {
                e.SuppressKeyPress = true;  //Make Space button unusable
                fireGunInternal = false;
                await Task.Delay(2);        //Adjust FireRate
                if (playerCharacter.bullets > 0)
                    fireGun();
                else
                    reloadGun();
                fireGunInternal = true;
            }
            if (goGun && bombInternal)   //Assign B to drop bombs
            {
                bombInternal = false;
                await Task.Delay(500);  //Adjust FireRate
                if (playerCharacter.bombs > 0 )
                    dropBomb();
                else
                    reloadBomb();
                bombInternal = true;
            }
            else if (e.KeyCode == Keys.CapsLock && ultimateReady)
            {
                e.SuppressKeyPress = true;
                ultimateReady = false;
                ultimate.Bottom = Color.Khaki;
                ultimate.Top = Color.Salmon;
                ultimate.Width = 0;
                castUltimate();
            }


        }

        private void timer1_Tick(object sender, EventArgs e)    //Passive Timer
        {
            if (ultimate.Width < 169)
                ultimate.Width += 2;
            else
            { 
                ultimate.Width = 170;
                ultimateReady = true;
                ultimate.Top = Color.Red;
                ultimate.Bottom = Color.Goldenrod;
                ultimate.Refresh();
            }
            
            if (ultimate.Width % 10 == 0 && ultimate.Width != 170)
                ultimate.Refresh();
        }
        private void fireGun()
        {
            --playerCharacter.bullets;
            bulletsLabel.Text = "Bullets : " + playerCharacter.bullets;
        }
        private void dropBomb()
        {
            --playerCharacter.bombs;
            bombsLabel.Text = "Bombs : " + playerCharacter.bombs;
        }
        private async void reloadGun()
        {
            bulletsLabel.Text = "Reloading...";
            await Task.Delay(500);
            playerCharacter.bullets = 99;
            bulletsLabel.Text = "Bullets : " + playerCharacter.bullets;
        }
        private async void reloadBomb()
        {
            bombsLabel.Text = "Reloading...";
            await Task.Delay(5000);
            playerCharacter.bombs = 10;
            bombsLabel.Text = "Bombs : " + playerCharacter.bombs;
        }
        private void castUltimate()
        {

        }
        public static Image rotation(Image image, float angle)
        {
            Bitmap bmp = new Bitmap(image.Width, image.Height);
            Graphics grs = Graphics.FromImage(image);
            grs.TranslateTransform((float)bmp.Width / 2, (float)bmp.Height / 2);
            grs.RotateTransform(angle);
            grs.TranslateTransform(-(float)bmp.Width / 2, -(float)bmp.Height / 2);
            grs.InterpolationMode = InterpolationMode.HighQualityBicubic;
            grs.DrawImage(image, new Point(0, 0));
            grs.Dispose();
            return bmp;
        }
    }
}
