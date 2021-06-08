using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;
//All Libraries used

namespace minigame
{
    public partial class Register : Form //Registration Form
    {
        //Register Form Variables
        private bool flag = false, flag2 = false;
        public Register() //Constructor
        {
            InitializeComponent(); //Method to communicate and start Main from Register.Designer.cs
        }

        private void CloseButton_Click(object sender, EventArgs e) => Close(); //Button to exit Current Window and return to Home Menu
        private void UsernameText_TextChanged(object sender, EventArgs e) //Username TextBox
        {
            if (Regex.Match(UsernameText.Text, "\\W").Success) //Regex Validation
            {
                UsernameText.ForeColor = System.Drawing.Color.FromArgb(255, 255, 40, 40); //Change Color upon using wrong input
                WrongUsernameRegister.Show();   //Show a label to help user with input
                flag = false; //Turn flag for sumbit off
            }
            else if (Regex.Match(UsernameText.Text, "^.*[a-zA-Z]").Success 
                    || UsernameText.Text == "") // Regex Validation
            {
                UsernameText.ForeColor = System.Drawing.Color.DarkGray; //Reset Color for correct input
                Variables.Username = UsernameText.Text;  //Store input to a Global Class
                WrongUsernameRegister.Hide();   //Hide help label
                flag = true; //Turn flag for sumbit on
            }
            else if (UsernameText.Text == null)   //Case no user input
            {
                UsernameText.ForeColor = System.Drawing.Color.DarkGray; //Reset Color
                WrongUsernameRegister.Hide(); //Hide help label
                flag = false; //Turn flag for sumbit off
            }
        }
        private void EmailText_TextChanged(object sender, EventArgs e) //Email Textbox
        {
            if ((Regex.Match(EmailText.Text, "[\\W-](?<exclude>@)").Success 
                    || !Regex.Match(EmailText.Text, "^.*[@]").Success) 
                    && !(EmailText.Text == "")) //Regex Validation
            {
                EmailText.ForeColor = System.Drawing.Color.FromArgb(255, 255, 40, 40); //Change Color upon using wrong input
                WrongEmailRegister.Show();   //Show a label to help user with input
                flag2 = false; //Turn flag for sumbit off
            }
            else if (Regex.Match(EmailText.Text, "^.*[a-zA-Z+](?<include>@)").Success 
                    || UsernameText.Text == "") // Regex Validation
            {
                EmailText.ForeColor = System.Drawing.Color.DarkGray; //Reset Color for correct input
                Variables.email = UsernameText.Text;  //Store input to a Global Class
                WrongEmailRegister.Hide();   //Hide help label
                flag2 = true; //Turn flag for sumbit on
            }
            else if (EmailText.Text == null)   //Case no user input
            {
                EmailText.ForeColor = System.Drawing.Color.DarkGray; //Reset Color
                WrongEmailRegister.Hide(); //Hide help label
                flag2 = false; //Turn flag for sumbit off
            }
        }
        private void SubmitButton_Click(object sender, EventArgs e) //Submit button to validate input and store input to Database
        {
            if (flag == false || flag2 == false) //Case user's input wrong
            {
                MessageBox.Show("Your input values are incorrect.");    //Messagebox to show Wrong user Input 
                this.Refresh(); //Refresh Current Form
            }
            else
            {
                Variables.Username = UsernameText.Text;             //Set Global's Variables Username
                Variables.email = EmailText.Text;                   //Set Global's Variables Email
                Variables.specialization = SpecializationText.Text; //Set Global's Variables Specialization
                Variables.RegisterConfim = true;                    //Set Global's Variables Bool RegisterConfirm
                MessageBox.Show("User: "+ Variables.Username +" , with email: "+ Variables.email +" , successfully listed as: "+ Variables.specialization); //Messabox to show Successful Registration
                this.Close();   //Close Current Form
            }

        }
        private void Return_Click(object sender, EventArgs e) //Button to exit Current Window and return to Home Menu
        {
            Close(); //Function to close Current Window
            Variables.RegisterConfim = false;
        }

    }
}
