using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string welcomeMessage;

            welcomeMessage = "Welcome, " + textBoxFirstName.Text + " " + textBoxLastName.Text;

            labelWelcome.Text = welcomeMessage;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void wackAMoleLabel_Click(object sender, EventArgs e)
        {
   
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void labelWhole_Click(object sender, EventArgs e)
        {

        }

        private void labelScore_Click(object sender, EventArgs e)
        {

        }

        private void Whole1_Click(object sender, EventArgs e)
        {
            labelhole.Text = "Hole 1";
            if (hole1.Tag as string == "Mole")      
            {
                labelScoreBox.Text = (int.Parse(labelScoreBox.Text) + 10).ToString();
            }
        }

        private void Whole2_Click(object sender, EventArgs e)
        {
            labelhole.Text = "Hole 2";
            if (hole2.Tag as string == "Mole")
            {
                labelScoreBox.Text = (int.Parse(labelScoreBox.Text) + 10).ToString();
            }
        }

        private void Whole3_Click_1(object sender, EventArgs e)
        {
            labelhole.Text = "Hole 3";
            if (hole3.Tag as string == "Mole")
            {
                labelScoreBox.Text = (int.Parse(labelScoreBox.Text) + 10).ToString();
            }
        }

        private void Whole4_Click(object sender, EventArgs e)
        {
            labelhole.Text = "Hole 4";
            if (hole4.Tag as string == "Mole")
            {
                labelScoreBox.Text = (int.Parse(labelScoreBox.Text) + 10).ToString();
            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            labelhole.Text = "Hole 5";
            if (hole5.Tag as string == "Mole")
            {
                labelScoreBox.Text = (int.Parse(labelScoreBox.Text) + 10).ToString();
            }
        }

        private void Whole5_Click(object sender, EventArgs e)
        {
            labelhole.Text = "Hole 6";
            if (hole6.Tag as string == "Mole")
            {
                labelScoreBox.Text = (int.Parse(labelScoreBox.Text) + 10).ToString();
            }
        }

        private void hole7_Click(object sender, EventArgs e)
        {
            labelhole.Text = "Hole 7";
            if (hole7.Tag as string == "Mole")
            {
                labelScoreBox.Text = (int.Parse(labelScoreBox.Text) + 10).ToString();
            }
        }

        private void hole8_Click(object sender, EventArgs e)
        {
            labelhole.Text = "Hole 8";
            if (hole8.Tag as string == "Mole")
            {
                labelScoreBox.Text = (int.Parse(labelScoreBox.Text) + 10).ToString();
            }
        }

        private void hole9_Click(object sender, EventArgs e)
        {
            labelhole.Text = "Hole 9";
            if (hole9.Tag as string == "Mole")
            {
                labelScoreBox.Text = (int.Parse(labelScoreBox.Text) + 10).ToString();
            }
        }

        private void buttonMoveMole_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            int holeNumber = random.Next(1, 10);
            if (holeNumber == 1)
            {
                hole1.BackgroundImage = Properties.Resources.Mole; hole1.Tag = "Mole";
                hole2.BackgroundImage = Properties.Resources.hole; hole2.Tag = null;
                hole3.BackgroundImage = Properties.Resources.hole; hole3.Tag = null;
                hole4.BackgroundImage = Properties.Resources.hole; hole4.Tag = null;
                hole5.BackgroundImage = Properties.Resources.hole; hole5.Tag = null;
                hole6.BackgroundImage = Properties.Resources.hole; hole6.Tag = null;
                hole7.BackgroundImage = Properties.Resources.hole; hole7.Tag = null;
                hole8.BackgroundImage = Properties.Resources.hole; hole8.Tag = null;
                hole9.BackgroundImage = Properties.Resources.hole; hole9.Tag = null;
            }
            else if (holeNumber == 2)
            {
                hole1.BackgroundImage = Properties.Resources.hole; hole1.Tag = null;
                hole2.BackgroundImage = Properties.Resources.Mole; hole2.Tag = "Mole";
                hole3.BackgroundImage = Properties.Resources.hole; hole3.Tag = null;
                hole4.BackgroundImage = Properties.Resources.hole; hole4.Tag = null;
                hole5.BackgroundImage = Properties.Resources.hole; hole5.Tag = null;
                hole6.BackgroundImage = Properties.Resources.hole; hole6.Tag = null;
                hole7.BackgroundImage = Properties.Resources.hole; hole7.Tag = null;
                hole8.BackgroundImage = Properties.Resources.hole; hole8.Tag = null;
                hole9.BackgroundImage = Properties.Resources.hole; hole9.Tag = null;
            }
            else if (holeNumber == 3)
            {
                hole1.BackgroundImage = Properties.Resources.hole; hole1.Tag = null;
                hole2.BackgroundImage = Properties.Resources.hole; hole2.Tag = null;
                hole3.BackgroundImage = Properties.Resources.Mole; hole3.Tag = "Mole";
                hole4.BackgroundImage = Properties.Resources.hole; hole4.Tag = null;
                hole5.BackgroundImage = Properties.Resources.hole; hole5.Tag = null;
                hole6.BackgroundImage = Properties.Resources.hole; hole6.Tag = null;
                hole7.BackgroundImage = Properties.Resources.hole; hole7.Tag = null;
                hole8.BackgroundImage = Properties.Resources.hole; hole8.Tag = null;
                hole9.BackgroundImage = Properties.Resources.hole; hole9.Tag = null;
            }
            else if (holeNumber == 4)
            {
                hole1.BackgroundImage = Properties.Resources.hole; hole1.Tag = null;
                hole2.BackgroundImage = Properties.Resources.hole; hole2.Tag = null;
                hole3.BackgroundImage = Properties.Resources.hole; hole3.Tag = null;
                hole4.BackgroundImage = Properties.Resources.Mole; hole4.Tag = "Mole";
                hole5.BackgroundImage = Properties.Resources.hole; hole5.Tag = null;
                hole6.BackgroundImage = Properties.Resources.hole; hole6.Tag = null;
                hole7.BackgroundImage = Properties.Resources.hole; hole7.Tag = null;
                hole8.BackgroundImage = Properties.Resources.hole; hole8.Tag = null;
                hole9.BackgroundImage = Properties.Resources.hole; hole9.Tag = null;
            }
            else if (holeNumber == 5)
            {
                hole1.BackgroundImage = Properties.Resources.hole; hole1.Tag = null;
                hole2.BackgroundImage = Properties.Resources.hole; hole2.Tag = null;
                hole3.BackgroundImage = Properties.Resources.hole; hole3.Tag = null;
                hole4.BackgroundImage = Properties.Resources.hole; hole4.Tag = null;
                hole5.BackgroundImage = Properties.Resources.Mole; hole5.Tag = "Mole";
                hole6.BackgroundImage = Properties.Resources.hole; hole6.Tag = null;
                hole7.BackgroundImage = Properties.Resources.hole; hole7.Tag = null;
                hole8.BackgroundImage = Properties.Resources.hole; hole8.Tag = null;
                hole9.BackgroundImage = Properties.Resources.hole; hole9.Tag = null;
            }
            else if (holeNumber == 6)
            {
                hole1.BackgroundImage = Properties.Resources.hole; hole1.Tag = null;
                hole2.BackgroundImage = Properties.Resources.hole; hole2.Tag = null;
                hole3.BackgroundImage = Properties.Resources.hole; hole3.Tag = null;
                hole4.BackgroundImage = Properties.Resources.hole; hole4.Tag = null;
                hole5.BackgroundImage = Properties.Resources.hole; hole5.Tag = null;
                hole6.BackgroundImage = Properties.Resources.Mole; hole6.Tag = "Mole";
                hole7.BackgroundImage = Properties.Resources.hole; hole7.Tag = null;
                hole8.BackgroundImage = Properties.Resources.hole; hole8.Tag = null;
                hole9.BackgroundImage = Properties.Resources.hole; hole9.Tag = null;
            }
            else if (holeNumber == 7)
            {
                hole1.BackgroundImage = Properties.Resources.hole; hole1.Tag = null;
                hole2.BackgroundImage = Properties.Resources.hole; hole2.Tag = null;
                hole3.BackgroundImage = Properties.Resources.hole; hole3.Tag = null;
                hole4.BackgroundImage = Properties.Resources.hole; hole4.Tag = null;
                hole5.BackgroundImage = Properties.Resources.hole; hole5.Tag = null;
                hole6.BackgroundImage = Properties.Resources.hole; hole6.Tag = null;
                hole7.BackgroundImage = Properties.Resources.Mole; hole7.Tag = "Mole";
                hole8.BackgroundImage = Properties.Resources.hole; hole8.Tag = null;
                hole9.BackgroundImage = Properties.Resources.hole; hole9.Tag = null;
            }
            else if (holeNumber == 8)
            {
                hole1.BackgroundImage = Properties.Resources.hole; hole1.Tag = null;
                hole2.BackgroundImage = Properties.Resources.hole; hole2.Tag = null;
                hole3.BackgroundImage = Properties.Resources.hole; hole3.Tag = null;
                hole4.BackgroundImage = Properties.Resources.hole; hole4.Tag = null;
                hole5.BackgroundImage = Properties.Resources.hole; hole5.Tag = null;
                hole6.BackgroundImage = Properties.Resources.hole; hole6.Tag = null;
                hole7.BackgroundImage = Properties.Resources.hole; hole7.Tag = null;
                hole8.BackgroundImage = Properties.Resources.Mole; hole8.Tag = "Mole";
                hole9.BackgroundImage = Properties.Resources.hole; hole9.Tag = null;
            }
            else if (holeNumber == 9)
            {
                hole1.BackgroundImage = Properties.Resources.hole; hole1.Tag = null;
                hole2.BackgroundImage = Properties.Resources.hole; hole2.Tag = null;
                hole3.BackgroundImage = Properties.Resources.hole; hole3.Tag = null;
                hole4.BackgroundImage = Properties.Resources.hole; hole4.Tag = null;
                hole5.BackgroundImage = Properties.Resources.hole; hole5.Tag = null;
                hole6.BackgroundImage = Properties.Resources.hole; hole6.Tag = null;
                hole7.BackgroundImage = Properties.Resources.hole; hole7.Tag = null;
                hole8.BackgroundImage = Properties.Resources.hole; hole8.Tag = null;
                hole9.BackgroundImage = Properties.Resources.Mole; hole9.Tag = "Mole";
            }
    }
    }
}
