using System;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb; //Database Library
using System.Drawing.Drawing2D;
using System.Text.RegularExpressions;

namespace minigame
{
    public partial class LoginForm : Form
    {
        //Database Variables
        OleDbConnection conn;
        OleDbCommand SQL;
        OleDbDataReader search;
        private string usernameQuery;   // = "SELECT * FROM MainTable WHERE MainTable.UserName ='" + UsernameTextbox.Text + "'";

        //Login Form's Variables
        private static string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) +"\\Classic Games\\";
        private static bool flag = false;
        private int blue = 0, red = 0, green = 0, alpha = 0;

        public LoginForm()  //Constructor
        {
            InitializeComponent();  //Run Main of Form1.Designer.cs
            DoubleBuffered = true;  //Doublebuffered to support Gradiend Colors
            StartDatabase();        //Function to Check the Database
            
            Close.MouseEnter += OnMouseEnterCloses;         //Function to Highlight Close Button on Hover
            Close.MouseLeave += OnMouseLeaveCloses;         //Function to Restore Default 
            Maximize.MouseEnter += OnMouseEnterMaximizes;   //Function to Highlight Maximize Button on Hover
            Maximize.MouseLeave += OnMouseLeaveMaximizes;   //Function to Restore Default 
            Minimize.MouseEnter += OnMouseEnterMinimizes;   //Function to Highlight Minimize Button on Hover
            Minimize.MouseLeave += OnMouseLeaveMinimizes;   //Function to Restore Default 
            windowToolStripMenuItem.BackColor = System.Drawing.Color.SlateGray;     //Set Color of Menu Strip
            windowToolStripMenuItem.ForeColor = System.Drawing.Color.DimGray;       //Set Color of Menu Font to DimGray
            darkModeToolStripMenuItem.BackColor = System.Drawing.Color.SlateGray;   //Set Color of Menu, Darkmode Strip
            onToolStripMenuItem.BackColor = System.Drawing.Color.SlateGray;         //Set Color of Menu, On/Off Strip
            Variables.RegisterConfim = false;       //Set Flag to False
        }

        private void GoogleButton_Click(object sender, EventArgs e) //Sign-in With Google Account
        {

        }
        private void FacebookButton_Click(object sender, EventArgs e) //Sign-in With Facebook Account
        {
            facebookForm facebookForm = new facebookForm(); //Create new Form to Login with Facebook
            Hide(); //Close Current Form
            facebookForm.ShowDialog(); //Show Facebook Form
            Show(); //Show Current Form once Facebook Form is closed
        }
        protected override void OnPaintBackground(PaintEventArgs e) //Function to @Override Background color to Gradiend
        {
            using (LinearGradientBrush brush = new LinearGradientBrush(ClientRectangle,
                                                                    DarkMode.IsOn ? Color.DarkSlateGray : Color.LightSlateGray, //First Colors of Gradiend
                                                                    DarkMode.IsOn ? Color.Black : Color.DarkGray,               //Second Colors of Gradiend
                                                                    30F)) //Define Gradient color
            {
                e.Graphics.FillRectangle(brush, this.ClientRectangle); //Paint Rectangle
            }
            base.OnPaint(e); //Paint on screen
            
        }
        private void StartDatabase() //Connect to Database
        {
            conn = new OleDbConnection(@"Provider = Microsoft.ACE.OLEDB.12.0; Data Source = " + path + "forProgram.accdb");//Provide the path of Database
            try
            {
                conn.Open(); //Connect to database
                //MessageBox.Show("Η Σύνδεση με την βάση ήταν επιτυχής!"); //Confirmation dialog for connecting to database
                conn.Close();
            }
            catch(Exception Database)
            {
                MessageBox.Show("Error Connecting with Database, \nPlease Contact Admin."); //Messabox to show error for database
                Application.Exit(); //Close Application if there is issue with Database
            }
        }
        private void WriteDatabase() //Method to Write inputs stored to Variables to Database
        {
            conn = new OleDbConnection(@"Provider = Microsoft.ACE.OLEDB.12.0; Data Source = " + path + "forProgram.accdb");//Provide the path of Database
            var add = "INSERT INTO MainTable(UserName, Email, Specialization) VALUES(@UserName, @Email, @Specialization)"; //Command Variable
            using (SQL = new OleDbCommand(add, conn)) //Using due to release of data upon exit
            {
                conn.Open(); //Connect to database
                SQL.Parameters.AddWithValue("@UserName", Variables.Username);   //Store Username
                SQL.Parameters.AddWithValue("@Email", Variables.email);                  //Store Email
                SQL.Parameters.AddWithValue("@Specialization", Variables.specialization);//Store Specialization
                SQL.ExecuteNonQuery();                                          //Execute Commands
                conn.Close();
            }
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
            await Task.Delay(1);   //Set Delay
            this.Invalidate();  //Refresh colors
        }
        private void Close_Click(object sender, EventArgs e) 
            => Application.Exit(); //Exit on-Click Button
        private void Minimize_Click(object sender, EventArgs e) 
            => WindowState = FormWindowState.Minimized; //Button to Minimize Window
        private void LoginForm_Resize(object sender, EventArgs e) 
            => Invalidate(); //Function to adjust Gradient color on Resize/Maximize/Minimize
        private async void OnMouseEnterCloses(object sender, EventArgs e)
        {
            int delay = 2;
            Close.FlatAppearance.BorderColor = Color.FromArgb(1, 1, 1, 1);
            if (DarkMode.IsOn)
                CloseDefault();
            else
                CloseSky();
            while (red < 230)
            {
                Close.FlatAppearance.MouseOverBackColor = Color.FromArgb((red+1)/2, red, 30, 0);
                red += 10;
                this.Invalidate();
                await Task.Delay(delay);
            }
            red = 0;
        }
        private async void OnMouseLeaveCloses(object sender, EventArgs e)
        {
            red = 0;
            CloseBlack();
            await Task.Delay(1);
            Close.BackColor = Color.FromArgb(0, 0, 0, 0); //Function to restore default upon leave hover on Close
            this.Invalidate();
        }
        private async void OnMouseEnterMaximizes(object sender, EventArgs e)
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
        private async void OnMouseLeaveMaximizes(object sender, EventArgs e)
        {
            blue = 0;
            MaximizeBlack();
            await Task.Delay(1);
            Maximize.BackColor = Color.FromArgb(0, 0, 0, 0); //Function to restore default upon leave hover on Close
            this.Invalidate();
        }
        private async void OnMouseEnterMinimizes(object sender, EventArgs e)
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
        private async void OnMouseLeaveMinimizes(object sender, EventArgs e)
        {
            green = 0;
            MinimizeBlack();
            await Task.Delay(1);
            Minimize.BackColor = Color.FromArgb(0, 0, 0, 0); //Function to restore default upon leave hover on Close
            this.Invalidate();
        }
        private void darkModeToolStripMenuItem_Click(object sender, EventArgs e) 
            => DarkMode_Click(sender, e);
        private async void DarkMode_Click(object sender, EventArgs e) //Custom Toggle Button to turn On/Off Darkmode
        {
            if (!DarkMode.IsOn) //If Dark mode is Off
            {
                onToolStripMenuItem.Text = "Off"; //Menustip's Darkmode text change => Off
                //Set each item's Color to Light Gray
                windowToolStripMenuItem.BackColor = System.Drawing.Color.LightSlateGray; //Window
                darkModeToolStripMenuItem.BackColor = System.Drawing.Color.LightSlateGray; //Dark-Mode
                onToolStripMenuItem.BackColor = System.Drawing.Color.LightSlateGray; //Off
            }
            else //If Dark mode is On
            {
                onToolStripMenuItem.Text = "On"; //Menustip's Darkmode text change => On
                //Set each item's Color to Dark Gray
                windowToolStripMenuItem.BackColor = System.Drawing.Color.DarkSlateGray; //Window
                darkModeToolStripMenuItem.BackColor = System.Drawing.Color.DarkSlateGray; //Dark-Mode
                onToolStripMenuItem.BackColor = System.Drawing.Color.DarkSlateGray; //On
            }
            Invalidate(); //Reload Page to change color
            await Task.Delay(500); //Add a delay before it can be pressed again (Millisecond)
            Refresh(); //Refresh Page
        }
        private void UsernameTextbox_TextChanged(object sender, EventArgs e) //OnClick Function to Validate and Store user input
        {
            if (Regex.Match(UsernameTextbox.Text, "\\W").Success) //Regex Validation
            {
                UsernameTextbox.ForeColor = Color.FromArgb(255, 255, 40, 40); //Change Color upon using wrong input
                WrongUsername.Show();   //Show a label to help user with input
            }
            else if (Regex.Match(UsernameTextbox.Text, "^.*[a-zA-Z]").Success
                     || UsernameTextbox.Text == "") // Regex Validation
            {
                UsernameTextbox.ForeColor = Color.DarkGray; //Reset Color for correct input
                Variables.Username = UsernameTextbox.Text;  //Store input to a Global Class
                WrongUsername.Hide();   //Hide help label
            }
            else if(UsernameTextbox.Text == null)   //Case no user input
            {
                UsernameTextbox.ForeColor = Color.DarkGray; //Reset Color
                WrongUsername.Hide(); //Hide help label
            }
        }
        private void EmailTextbox_TextChanged(object sender, EventArgs e) //OnClick Function to Validate and store user email
        {
            if ((Regex.Match(EmailTextbox.Text, "[\\W-](?<exclude>@)").Success
                || !Regex.Match(EmailTextbox.Text, "^.*[@]").Success) && !(EmailTextbox.Text == "")) //Regex Validation
            {
                EmailTextbox.ForeColor = Color.FromArgb(255, 255, 40, 40); //Change Color upon using wrong input
                WrongEmail.Show();   //Show a label to help user with input
            }
            else if (Regex.Match(EmailTextbox.Text, "^.*[a-zA-Z+](?<include>@)").Success 
                     || UsernameTextbox.Text == "") // Regex Validation
            {
                EmailTextbox.ForeColor = Color.DarkGray; //Reset Color for correct input
                Variables.email = UsernameTextbox.Text;  //Store input to a Global Class
                WrongEmail.Hide();   //Hide help label
            }
            else if (EmailTextbox.Text == null)   //Case no user input
            {
                EmailTextbox.ForeColor = System.Drawing.Color.DarkGray; //Reset Color
                WrongEmail.Hide(); //Hide help label
            }
        }
        private void LoginButton_Click(object sender, EventArgs e) //When user Clicks Log-in Button =>
        {
            CheckDatabase();

            if (UsernameTextbox.Text == null || EmailTextbox.Text == null) //If Textboxes are empty
                MessageBox.Show("Enter Username and Password, or login with Facebook/Google"); //Inform user for appropriate Login
            else if (Regex.Match(UsernameTextbox.Text, "^.*[a-zA-Z]").Success 
                    && Regex.Match(EmailTextbox.Text, "^.*[a-zA-Z+](?<include>@)").Success) //Check correct input
            {
                if (flag)
                {
                    show.Show(); //Show Label with inputs
                    show.Text = "User: " + UsernameTextbox.Text + " with email: " + EmailTextbox.Text + " has logged in."; //Change Label's Text to user input
                    Profile profile = new Profile();
                    Hide();
                    profile.ShowDialog();
                    Show();
                }
                else
                {
                    WrongCredentials();
                }
            }
        }
        private void Signup_Click(object sender, EventArgs e) //Signup Button properties
        {
            Register register = new Register(); //Create new Form
            Hide(); //Hide current Window
            register.ShowDialog(); //Show Created Window
            Show(); //When Created Window closes, resume on this Window

            if (Variables.Username != ""
                && Variables.email != ""
                && Variables.specialization != ""
                && Variables.RegisterConfim == true) //In Case user had successful Registration
            {
                WriteDatabase();    //Call Function to Write to Database
                UsernameTextbox.Text = Variables.Username; //Autofill Username
                EmailTextbox.Text = Variables.email; //Autofill Email
            }
        }
        private void GuestButton_Click(object sender, EventArgs e)  //Guest Button for instant login

        {
            //
            // Set values for Guest
            //
            Variables.ID = 0;
            Variables.Username = "Guest";
            Variables.email = "Guest@";
            Variables.password = "guest";
            Variables.specialization = "Unknown";
            Variables.Highscore = "0";
            //
            // Load form
            //
            Profile profile = new Profile();
            Hide();
            profile.ShowDialog();
            Show();
        }
        private void CheckDatabase() //Function to check user's input for Database Match 
        {
            conn = new OleDbConnection(@"Provider = Microsoft.ACE.OLEDB.12.0; Data Source = " + path + "forProgram.accdb");//Provide the path of Database
            usernameQuery = "SELECT * FROM MainTable WHERE MainTable.UserName ='" + UsernameTextbox.Text + "'"; //The Query based on username user entered
            conn.Open();    //Open connection to database
            SQL = new OleDbCommand(usernameQuery, conn);    //define commant with 2 parameters
            search = SQL.ExecuteReader();   //function to search

            if (search.Read())
            {
                Variables.ID = Int32.Parse(search.GetValue(0).ToString());
                Variables.Username = search.GetValue(1).ToString(); //Store user's Username from Database
                Variables.email = search.GetValue(2).ToString();    //Store user's Email from Database
                Variables.password = search.GetValue(3).ToString(); //Store user's Password from Database
                Variables.specialization = search.GetValue(4).ToString();   //Store user's Specialization from Database
                Variables.Highscore = Int32.Parse((string)search.GetValue(6)).ToString();    //Store user's Highscore from Database
                if (Int32.Parse(Variables.Highscore) >= 1000)   //if user has already won the game, username is adapted
                    UsernameAdapter();
                MessageBox.Show(Variables.Username + "\n" + Variables.email);  
                flag = true;    //Set boolean to true
            }
            else
                flag = false;   //Set boolean to false
        }
        private void UsernameAdapter()  //Set nicknames based on specialization
        {
            if (Variables.specialization == "Πληροφορική")
            {
                Variables.Username = "hacker " + Variables.Username;
            }
            else if (Variables.specialization == "Φυσική")
            {
                Variables.Username = "surreal " + Variables.Username;
            }
            else if (Variables.specialization == "Μαθηματικά")
            {
                Variables.Username = "hypothetical " + Variables.Username;
            }
            else if (Variables.specialization == "Χημεία")
            {
                Variables.Username = "matterialist " + Variables.Username;
            }
            else if (Variables.specialization == "Φιλολογία")
            {
                Variables.Username = "hated " + Variables.Username;
            }
            else if (Variables.specialization == "Παιδαγωγικά")
            {
                Variables.Username = "teacher " + Variables.Username;
            }
            else if (Variables.specialization == "Ιατρική" || Variables.specialization == "Ψυχολογία")
            {
                Variables.Username = "dr " + Variables.Username;
            }
            else if (Variables.specialization == "Μηχανολογία")
            {
                Variables.Username = "grinder " + Variables.Username;
            }
            else if (Variables.specialization == "Δημόσιος Τομέας")
            {
                Variables.Username = "looser " + Variables.Username;
            }
        }
        private async void WrongCredentials() //Function to remind user of wrong input
        {
            WrongCredentialsLabel.Text = "Wrong Credentials,\n please try again.";
            WrongCredentialsLabel.Show();   //Show warning label
            await Task.Delay(5000); //Add a delay (milisec)
            WrongCredentialsLabel.Hide();   //Hide warning label
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
