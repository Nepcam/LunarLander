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
        public Form1()
        {
            InitializeComponent();
        }

        //Random number generator
        Random rand = new Random();
        //The velocity of the LANDER
        int velocity;
        //A rectangle object tp represent the landing pad
        Rectangle pad;
        //A rectangle object to represent the fuel gauge
        Rectangle fuel;
        //A point object to represent the top left hand corner of the ship sprite
        Point pos;
        //Fuel amount for the LANDER
        const int fuelAmount = 100;

        private void buttonStart_Click(object sender, EventArgs e)
        {
            //Create new Point to position the LANDER
            Point landerPosition = new Point(this.Width, 0);
            //Set velocity of the LANNDER to 0;
            int velocity = 0;
            //Create new Rectangle object for the LANDING_PAD - use the Rectangle variable already declared at class scope and just make a new object for it
            Rectangle pad = new Rectangle(0, -60, -50, 60);
            //Create a new Rectangle object for the fuel gauge - use the Rectangle variable already declared for you
            Rectangle fuel = new Rectangle(0, 0, fuelAmount, 10);
            //Start timer using the Start() method
            timer1.Start();
            //Give the form the focus - using this.Focus() ... this object refers to the current form 
            this.Focus();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //Create a Graphics object connect to the form - using this.CreateGraphics
            Graphics canvas = this.CreateGraphics();
            //Create three solid brushes
            //GreenYellow == landing pad
            SolidBrush greenYellow = new SolidBrush(Color.GreenYellow);
            //Orange == indicates lots of fuel remaining
            SolidBrush orange = new SolidBrush(Color.Orange);
            //Red == low fuel
            SolidBrush red = new SolidBrush(Color.Red);
            //Clear pictureBox with color black - using the Clear() of the graphics object
            canvas.Clear(Color.Black);
            //Apply gravity to the LANDER
            this.velocity = +1;
            Console.WriteLine(velocity);
            //Change the Y position of the LANDER by adding the velocity to it
            Point landerPosition = new Point(Width / 2, velocity);
            //Draw LANDER - using the DrawImage() of the graphics object at its current X and Y position
            
            //Draw landing pad as well + Test and Run 
            Pen padPen = new Pen(Color.GreenYellow, 5);
            canvas.DrawLine(padPen, 0, -60, -50, 60);

            // IF (width of the fuel gauge < 20)
                //Draw FUEL_GAUGE in RED
            // ELSE
                //Draw FUEL_GAUGE in Orange

            // IF (LANDER < LANDER_PAD && LANDER > top edge of LANDER_PAD)
                // Stop the timer
                // Display landed message
                // Set the visible property of the button to true
            // ELSE IF (bottom edge of LANDER > height of the form) 
                // stop the timer
                // Display crash message
                // Set visible property of the button to true 
        }
    }
}
