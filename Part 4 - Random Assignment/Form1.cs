using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Part_4___Random_Assignment
{
    public partial class RandomNumbers : Form
    {
        Random generator = new Random();
        public RandomNumbers()
        {
            InitializeComponent();
        }
        /////////////////////////////////////////////////////////////////// Get Integer
        private void btnRandom_Click(object sender, EventArgs e)
        {


            int number = generator.Next(minInput, maxInput);
            lblRandom.Text = number + "";
        }
        /////////////////////////////////////////////////////////////////// Get Double
        private void btnRandom1_Click(object sender, EventArgs e)
        {
            Double number = generator.NextDouble();
            lblRandom.Text = number + "";


 
        }
        /////////////////////////////////////////////////////////////////// Rounding Input



        //Double roundedInput = Math.Round(number, txtDecimal);



        /////////////////////////////////////////////////////////////////// If Statements



    }
}
