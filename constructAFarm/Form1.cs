using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace constructAFarm
{
    public partial class Form1 : Form
    {
        Farmer farmer;

        public Form1()
        {
            InitializeComponent();
            farmer = new constructAFarm.Farmer(15, 30);
            //create an instance of the Farmer object and set properites (using its constructor)
            //the statement calls the constructor, passes the parameters to the constructor method
        }



        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void numericUpDownCow_ValueChanged(object sender, EventArgs e)
        {
            farmer.NumberOfCows = (int)numericUpDownCow.Value;
            //when the user changes the number, set the value of NumberOfCows to match;
        }

        private void buttonCalculate_Click(object sender, EventArgs e)
        {
            Console.WriteLine("I need {0} bags of feed for {1} cows.", farmer.BagsOfFeed, farmer.NumberOfCows);
            //string format will take the previously set values
            //when user clicks calc, produce relevant message for the amount of feed needed.
        }
    }
}
