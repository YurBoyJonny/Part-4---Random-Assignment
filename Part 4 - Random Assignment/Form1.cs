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

        private void btnRandom_Click(object sender, EventArgs e)
        {
            int number = generator.Next(1,11);
            lblRandom.Text = number + "";




        }
        private void btnRandom1_Click(object sender, EventArgs e)
        {
            Double number = generator.NextDouble();
            lblRandom.Text = number + "";





        }
    }
}
