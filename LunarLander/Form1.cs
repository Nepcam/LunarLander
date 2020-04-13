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
        //The velocity of the lander
        int velocity;
        //A rectangle object tp represent the landing pad
        Rectangle pad;
        //A rectangle object to represent the fuel gauge
        Rectangle fuel;
        //A point object to represent the top left hand corner of the ship sprite
        Point pos;


    }
}
