using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace minigame
{
    public partial class Games : Form
    {
        public Games()  //Constructor
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
        private void SlotmachineButton_Click(object sender, EventArgs e)    //On-Click Event for Button Slot Machine
        {
            SlotMachine slot = new SlotMachine();   //Create new Form for Slot Machine game
            Hide();    //Hide Current Form
            slot.ShowDialog();  //Show Slot Machine Form
            Show();    //Show Current Form once Slot Machine Form closes
        }
        private async void ChessButton_Click(object sender, EventArgs e)    //On-Click Event for Button Chess
        {
            ChessDevelopment.Show();    //Show Warning label
            await Task.Delay(5000); //Add a Delay (milisec)
            ChessDevelopment.Hide();    //Hide Warning label
        }
        private async void BackgammonButton_Click(object sender, EventArgs e)   //On-Click Event for Button Backgammon
        {
            BackgammonDevelopment.Show();   //Show Warning label
            await Task.Delay(5000); //Add a delay (milisec)
            BackgammonDevelopment.Hide();   //Hide Warning label
        }
    }
}
