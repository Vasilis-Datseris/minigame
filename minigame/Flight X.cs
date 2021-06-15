using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace minigame
{
    public partial class Flight_X : Form
    {
        int x, z, enemiesKilled = 0;
        bool bombInternal = true, fireGunInternal = true, ultimateReady = false, goUp = false, goDown = false, goRight = false, goLeft = false, goBomb = false, goGun = false;
        string currentLevel;
        Random random = new Random();

        Base playerCharacter = new Base(100, 99, 10, 3, 25, 5, true);    //Initialize Player's object Class
        Base enemyFlying = new Base(10, 10, 0, 15, 0, 10, false);   //Initialize Flying enemy
        Base enemyArmy = new Base(5, 15, 0, 10, 0, 10, false);   //Initialize Army enemy
        Base enemyTank = new Base(20, 0, 5, 0, 20, 10, false);   //Initialize Tank enemy
        Base enemyBoat = new Base(20, 15, 5, 10, 10, 10, false);   //Initialize Boat enemy
        Base enemyBoss = new Base(50, 15, 15, 30, 15, 10, false);   //Initialize Boss enemy
        
        public Flight_X()
        {
            InitializeComponent();
            DoubleBuffered = true;
            usernameLabel.Text = Variables.Username;    //Set Username
            belowHalfHP.SendToBack();   //Align Player HealthBar
            GeneralTimer.Interval = 100;   //Set the clock Interval
            GeneralTimer.Start(); //Initiate our Timer
            ultimate.Width = 0;
            cycleLevels();
            createEnemyAir();
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
            currentLevel = "Sea";
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
            currentLevel = "Dessert";
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
            currentLevel = "Jungle";
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
        private async void cycleLevels()    //Function to Change current Level
        {
            await Task.Delay(10000);
            int a = random.Next(1, 3);  //Random Level
            if(a == 1)
            {
                currentLevel = "Sea";
                bringSea();
            }    
            else if (a == 2)
            {
                currentLevel = "Dessert";
                bringDessert();
            }
            else if (a == 3)
            {
                currentLevel = "Jungle";
                bringJungle();
            }
            groundPanel.Invalidate();
            groundBottomPanel.Invalidate();
            groundTopPanel.Invalidate();
        }
        private void Flight_X_KeyUp(object sender, KeyEventArgs e)  //Set Boolean values to false
        {
            if (e.KeyCode == Keys.W || e.KeyCode == Keys.Up)    //Set boolean for Upwards movement to True
                goUp = false;
            if (e.KeyCode == Keys.S || e.KeyCode == Keys.Down)  //Set boolean for Downwards movement to True
                goDown = false;
            if (e.KeyCode == Keys.A || e.KeyCode == Keys.Left)  //Set boolean for Left movement to True
                goLeft = false;
            if (e.KeyCode == Keys.D || e.KeyCode == Keys.Right) //Set boolean for Right movement to True
                goRight = false;
            if (e.KeyCode == Keys.Space)    //Set boolean for Fire Gun to True
                goGun = false;
            if (e.KeyCode == Keys.B)    //Set boolean for Dropping Bomb to True
                goBomb = false;
        }
        private async void Flight_X_KeyDown(object sender, KeyEventArgs e)    //User's Movement
        {
            e.SuppressKeyPress = true;
            //Console.WriteLine(e.KeyCode);
            if (e.KeyCode == Keys.W || e.KeyData == Keys.Up)
                goUp = true;
            if (e.KeyCode == Keys.S || e.KeyCode == Keys.Down)
                goDown = true;
            if (e.KeyCode == Keys.A || e.KeyCode == Keys.Left)
                goLeft = true;
            if (e.KeyCode == Keys.D || e.KeyCode == Keys.Right)
                goRight = true;
            if (e.KeyCode == Keys.Space)
                goGun = true; 
            if (e.KeyCode == Keys.B)
                goBomb = true;

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
            if (goGun  && fireGunInternal)   //Assign Spacebar to fire ammo
            {
                e.SuppressKeyPress = true;  //Make Space button unusable
                fireGunInternal = false;
                await Task.Delay(100);        //Adjust FireRate
                if (playerCharacter.bullets > 0)
                    fireGun();
                else
                    reloadGun();
                fireGunInternal = true;
            }
            if (goBomb && bombInternal)   //Assign B to drop bombs
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
        private void createEnemyAir()   //Spawn Enemy Helicopter
        {
            if (!enemyFlying.alive)
            {
                flyingEnemy.Location = new Point(flyingEnemyPanel.Width, random.Next(50, 150));
                enemyFlying.alive = true;
                enemyFlying.HP = 10;
                enemyFlying.bullets = 10;
                flyingEnemy.Visible = true;
                enemyDefaultMovement();
            }
        }
        private void createEnemyGround()    //Spawn Ground enemy Based on Level
        {
            if(!enemyArmy.alive && !enemyBoat.alive && !enemyTank.alive)
            {
                if(currentLevel == "Sea")
                {
                    groundEnemy.Image = minigame.Properties.Resources.ship;
                    groundEnemy.BringToFront();
                    groundEnemy.Location = new Point(groundPanel.Right, groundBottomPanel.Bounds.Top);
                    enemyBoat.alive = true;
                    enemyBoat.HP = 20;
                    enemyBoat.bullets = 15;
                    enemyBoat.bombs = 5;
                    groundEnemy.Visible = true;
                }
                if(currentLevel == "Dessert")
                {
                    groundEnemy.Image = minigame.Properties.Resources.tank;
                    groundEnemy.BringToFront();
                    groundEnemy.Location = new Point(groundPanel.Right, groundBottomPanel.Bounds.Top);
                    enemyTank.alive = true;
                    enemyTank.HP = 20;
                    enemyTank.bombs = 5;
                    groundEnemy.Visible = true;
                }
                if(currentLevel == "Jungle")
                {
                    groundEnemy.Image = minigame.Properties.Resources.army;
                    groundEnemy.BringToFront();
                    groundEnemy.Location = new Point(groundPanel.Right, groundBottomPanel.Bounds.Top);
                    enemyArmy.alive = true;
                    enemyArmy.HP = 5;
                    enemyArmy.bullets = 15;
                    groundEnemy.Visible = true;
                }    
            }
        }
        private void enemyDefaultMovement() //Enemy Default Movement
        {
            if(playerCharacter.alive)
            {
                if(enemyFlying.alive && flyingEnemy.Left > 0)
                    flyingEnemy.Location = new Point(flyingEnemy.Location.X - enemyFlying.moveSpeed, flyingEnemy.Location.Y);
                if(enemyTank.alive && groundEnemy.Left > 0)
                    groundEnemy.Location = new Point(groundEnemy.Location.X - enemyTank.moveSpeed, groundEnemy.Location.Y);
                if(enemyArmy.alive && groundEnemy.Left > 0)
                    groundEnemy.Location = new Point(groundEnemy.Location.X - enemyArmy.moveSpeed, groundEnemy.Location.Y);
                if(enemyBoat.alive && groundEnemy.Left > 0)
                    groundEnemy.Location = new Point(groundEnemy.Location.X - enemyBoat.moveSpeed, groundEnemy.Location.Y);

            }
        }
        private void BulletTimer_Tick(object sender, EventArgs e)
        {

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

            if (enemyFlying.alive || enemyArmy.alive 
                || enemyBoat.alive || enemyTank.alive 
                || enemyBoss.alive)
                enemyDefaultMovement();
        }
        private void fireGun()  //Function to fire Bullets
        {
            --playerCharacter.bullets;
            bulletsLabel.Text = "Bullets : " + playerCharacter.bullets;
            playerBullets();
        }
        private void dropBomb() //Function to Show Bullets
        {
            --playerCharacter.bombs;
            bombsLabel.Text = "Bombs : " + playerCharacter.bombs;
        }
        private async void reloadGun()  //Function to reload Ammo
        {
            bulletsLabel.Text = "Reloading...";
            await Task.Delay(500);
            playerCharacter.bullets = 99;
            bulletsLabel.Text = "Bullets : " + playerCharacter.bullets;
        }
        private async void reloadBomb() //Function to reload Bombs
        {
            bombsLabel.Text = "Reloading...";
            await Task.Delay(5000);
            playerCharacter.bombs = 10;
            bombsLabel.Text = "Bombs : " + playerCharacter.bombs;
        }
        private void castUltimate() //Function to Case Ultimate
        {

        }
        private async void playerBullets()  //Function to Create custom Player's bullets
        {
            GradientPanel panel = new GradientPanel();
            Controls.Add(panel);
            panel.Width = 5;
            panel.Height = 3;
            //panel.Size = new Size(50, 20);
            panel.Name = "Bullet";
            panel.Top = Color.Black;
            panel.Bottom = Color.Red;
            panel.Angle = 0;
            panel.Location = new Point(Player.Right, Player.Top + Player.Height / 2);
            panel.BringToFront();

            while(panel.Right < flyingEnemyPanel.Right)
            {
                
                //Console.WriteLine("Bullet:\n Right : {0} Top : {1} \n Panel: \n Left : {2] Right : {3} \n Flying : \n Left {4} Right {5} Top {6} Bottom {7}", panel.Right, panel.Bounds.Top, flyingEnemyPanel.Left, flyingEnemyPanel.Bounds.Right, flyingEnemy.Left, flyingEnemy.Bounds.Right, flyingEnemy.Top, flyingEnemy.Bounds.Bottom);
                Console.WriteLine("\nBullet:\n Right : " + panel.Right + " | Top : " + panel.Bounds.Top + 
                                    "\nPanel:\n Left : " + flyingEnemyPanel.Left + " | Right : " + flyingEnemyPanel.Bounds.Right + 
                                    "\nFlying:\n Left : " + flyingEnemy.Left + " | Right : " + flyingEnemy.Bounds.Right + " | Top : " + flyingEnemy.Bounds.Top + " | Bottom : " + flyingEnemy.Bottom);
                panel.Location = new Point(panel.Location.X + 5, panel.Location.Y);
                await Task.Delay(50);
                if (panel.Bounds.Right - flyingEnemy.Width * 2 > flyingEnemy.Left
                    && panel.Bounds.Right - flyingEnemy.Width * 2 < flyingEnemy.Right
                    && panel.Bounds.Top - flyingEnemy.Height / 2 < flyingEnemy.Bottom - 30
                    && panel.Bounds.Top - flyingEnemy.Height / 2 > flyingEnemy.Top + 30
                    && enemyFlying.alive)
                {
                    enemyFlying.HP -= playerCharacter.bulletDamage;
                    ultimate.Width += 3;
                    panel.Dispose();
                    if (enemyFlying.HP <= 0)
                    {
                        enemyFlying.alive = false;
                        flyingEnemy.Visible = false;
                        await Task.Delay(500);
                        createEnemyAir();
                    }
                }
                panel.Invalidate();
            }
            
            panel.Dispose();
            chooseLevel();
        }
        private void chooseLevel()
        {
            if (enemiesKilled % 10 == 0)
                cycleLevels();
        }
    }
}
