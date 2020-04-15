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

            //Draw Lander using DrawImage method
            

            //Start timer
            timer1.Start();

            //Form focus
            this.Focus();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //Create graphics object
            Graphics canvas = this.CreateGraphics();

            //Solid brushes
            SolidBrush greenYellow = new SolidBrush(Color.GreenYellow); //Landing pad
            SolidBrush orange = new SolidBrush(Color.Orange); //Lots of fuel remaining indicator
            SolidBrush red = new SolidBrush(Color.Red); //Low fuel indicator

            //Clear the picturebox with the color black
            canvas.Clear(Color.Black);

            //Apply gravity to the Lander
            int velocity = +1;
        }
    }
}
