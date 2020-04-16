using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LunarLander
{
    public partial class Form1 : Form
    {
        const int FUEL_AMOUNT = 100; 

        public Form1()
        {
            InitializeComponent();
        }

        //Random number generator
        Random rand = new Random();
        //The velocity of the lander
        int velocity = 0;
        //A rectangle object tp represent the landing pad
        Rectangle pad = new Rectangle(0, -60, -50, 60);
        //A rectangle object to represent the fuel gauge
        Rectangle fuel = new Rectangle(0, 0, FUEL_AMOUNT, 10);
        //A point object to represent the top left hand corner of the ship sprite
        Point pos;

        private void buttonStart_Click(object sender, EventArgs e)
        {
            //Position of the lander
            Point landerPosition = new Point(this.Width/2, this.Height = velocity);

            //Start timer
            timer1.Start();

            //Form focus
            this.Focus();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //Create graphics object connected to the form using this.CreateGraphics
            Graphics canvas = this.CreateGraphics();

            //Create 3 Solid brushes
            SolidBrush greenYellow = new SolidBrush(Color.GreenYellow); //Landing pad
            SolidBrush orange = new SolidBrush(Color.Orange); //Lots of fuel remaining indicator
            SolidBrush red = new SolidBrush(Color.Red); //Low fuel indicator

            //Clear the picturebox with the color black
            canvas.Clear(Color.Black);

            //Apply gravity to the Lander
            this.velocity = +1;
            
            //Change the Y position of the Lander by adding velocity to it 
            Point landerPosition = new Point(Width / 2, velocity);

            //Draw Lander using DrawImage method
            Image landerImage = Image.FromFile("lander.jpg");
            Rectangle imageholder = new Rectangle(Width/2, velocity);


            //Draw landing pad

            //If the width of the fuel gauge is less than 20 then draw it in red otherwise draw it in orange.

            //If the lander sprite is completely in between the left and right edges of the landing pad and the
            //bottom edge of the sprite is greater than or equal to the top edge of the pad then stop the timer
            //display a landed message

            //set the visible property of the button to true
            //Otherwise if the bottom edge of the lander is greater than the height of the form then stop the timer
            //display a crashed message
            //set the visible property of the button to true




        }
    }
}
