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
/////////////////////////////////////////////////////// Get Integer ///////////////////////////////////////////////////////
        private void btnRandom_Click(object sender, EventArgs e)
        {
            int result1;
            int result2;

            int a;
            if (int.TryParse(minInput.Text, out result1))
                a = result1;
            int b;
            if (int.TryParse(maxInput.Text, out result2))
                b = result2;

            int number = generator.Next(result1, result2 + 1);
            lblRandom.Text = number + "";
        }



/////////////////////////////////////////////////////// Get Double ///////////////////////////////////////////////////////
        private void btnRandom1_Click(object sender, EventArgs e)
        {
            double result3;
            double result4;

            double c;
            if (Double.TryParse(minInput.Text, out result3))
                c = result3;
            double d;
            if (Double.TryParse(maxInput.Text, out result4))
                d = result4;

            int result1;
            int result2;
            int a;
            if (int.TryParse(minInput.Text, out result1))
                a = result1;
            int b;
            if (int.TryParse(maxInput.Text, out result2))
                b = result2;

            int number = generator.Next(result1, result2);

            if (result4 > 0)
            {
                int roundInput;
                int rounded = 0;
                if (int.TryParse(txtDecimal.Text, out roundInput))
                    rounded = roundInput;

                double number1 = generator.NextDouble();
                number1 = Math.Round(number1, rounded, MidpointRounding.AwayFromZero);
                lblRandom.Text = number + number1 + "";



            }
        }


    }
}
