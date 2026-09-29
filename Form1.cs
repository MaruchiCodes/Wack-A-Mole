using System;
using System.CodeDom.Compiler;
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
            buttonMoveMole.Enabled = true;
            buttonResetGame.Enabled = true;
            if (textBoxFirstName.Text == "" || textBoxLastName.Text == "")
            {
                MessageBox.Show("Please enter your first and last name.");

            }
            else
            {
                string welcomeMessage;
                welcomeMessage = "Welcome, " + textBoxFirstName.Text + " " + textBoxLastName.Text;
                labelWelcome.Text = welcomeMessage;
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Whole1_Click(object sender, EventArgs e)
        {
            PictureBox tempPictureBox = (PictureBox)sender;
            if (tempPictureBox.Tag.ToString() == "Mole")
            {
                labelScoreBox.Text = (int.Parse(labelScoreBox.Text) + 10).ToString();
            }
        }

        private void buttonMoveMole_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            int holeNumber = random.Next(1, 10);

            hole1.Image = Properties.Resources.hole; hole1.Tag = "Hole";
            hole2.Image = Properties.Resources.hole; hole2.Tag = "Hole";
            hole3.Image = Properties.Resources.hole; hole3.Tag = "Hole";
            hole4.Image = Properties.Resources.hole; hole4.Tag = "Hole";
            hole5.Image = Properties.Resources.hole; hole5.Tag = "Hole";
            hole6.Image = Properties.Resources.hole; hole6.Tag = "Hole";
            hole7.Image = Properties.Resources.hole; hole7.Tag = "Hole";
            hole8.Image = Properties.Resources.hole; hole8.Tag = "Hole";
            hole9.Image = Properties.Resources.hole; hole9.Tag = "Hole";
            
            if (holeNumber == 1)
            {
                hole1.Image = Properties.Resources.Mole;
                hole1.Tag = "Mole";
                hole1.Enabled = true;
            }
            else if (holeNumber == 2)
            {
                hole2.Image = Properties.Resources.Mole;
                hole2.Tag = "Mole";
                hole2.Enabled = true;
            }
            else if (holeNumber == 3)
            {
                hole3.Image = Properties.Resources.Mole;
                hole3.Tag = "Mole";
                hole3.Enabled = true;
            }
            else if (holeNumber == 4)
            {
                hole4.Image = Properties.Resources.Mole;
                hole4.Tag = "Mole";
                hole4.Enabled = true;
            }
            else if (holeNumber == 5)
            {
                hole5.Image = Properties.Resources.Mole;
                hole5.Tag = "Mole";
                hole5.Enabled = true;
            }
            else if (holeNumber == 6)
            {
                hole6.Image = Properties.Resources.Mole;
                hole6.Tag = "Mole";
                hole6.Enabled = true;
            }
            else if (holeNumber == 7)
            {
                hole7.Image = Properties.Resources.Mole;
                hole7.Tag = "Mole";
                hole7.Enabled = true;
            }
            else if (holeNumber == 8)
            {
                hole8.Image = Properties.Resources.Mole;
                hole8.Tag = "Mole";
                hole8.Enabled = true;
            }
            else if (holeNumber == 9)
            {
               hole9.Image = Properties.Resources.Mole;
               hole9.Tag = "Mole";
               hole9.Enabled = true;
            }
    }

        private void buttonResetGame_Click(object sender, EventArgs e)
        {
            hole1.Image = Properties.Resources.hole; hole1.Tag = "Hole";
            hole2.Image = Properties.Resources.hole; hole2.Tag = "Hole";
            hole3.Image = Properties.Resources.hole; hole3.Tag = "Hole";
            hole4.Image = Properties.Resources.hole; hole4.Tag = "Hole";
            hole5.Image = Properties.Resources.hole; hole5.Tag = "Hole";
            hole6.Image = Properties.Resources.hole; hole6.Tag = "Hole";
            hole7.Image = Properties.Resources.hole; hole7.Tag = "Hole";
            hole8.Image = Properties.Resources.hole; hole8.Tag = "Hole";
            hole9.Image = Properties.Resources.hole; hole9.Tag = "Hole";
            textBoxFirstName.Text = "";
            textBoxLastName.Text = "";
            buttonMoveMole.Enabled = false;
            buttonResetGame.Enabled = false;
            if (labelScoreBox.Text != "0")
            {
                labelScoreBox.Text = "0";
            }
            if (labelScoreBox.Text == "0")
            {
                MessageBox.Show("Game has been reset.");
            }
            if (labelWelcome.Text != "")
            {
                labelWelcome.Text = "";
            }
        }
    }
}
