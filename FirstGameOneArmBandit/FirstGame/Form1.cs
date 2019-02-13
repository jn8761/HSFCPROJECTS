using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FirstGame.Properties;

namespace FirstGame
{
    public partial class Form1 : Form
    {
        Image[] images = new Image[7];
        Random rdm = new Random();// new random instance
        bool Winner = true;

        int tempBox1 = -1;
        int tempBox2 = -1;
        int tempBox3 = -1;// variables 

        private void CheckWinner()
        {
            if ((tempBox1 == tempBox2) && (tempBox2 == tempBox3) && (tempBox1>=0))
            {
                Winner = true;
            }
            else
            {
                Winner = false;
            }
            if (Winner)
            {
                label2.Show();
            }
        }
        public Form1()
        {
            InitializeComponent();
            
            images[0] = Properties.Resources.BMTH;
            images[1] = Properties.Resources.No7;
            images[2] = Properties.Resources.FB;
            images[3] = Properties.Resources.Mouse;
            images[4] = Properties.Resources.OM_M;
            images[5] = Properties.Resources.Snake;
            images[6] = Properties.Resources.TTS;  //Assigning the images into an array
            label2.Hide();
        } 




        private void Form1_Load(object sender, EventArgs e)
        {
            pictureBoxOne.Image = Properties.Resources.BMTH;
            pictureBoxTwo.Image = Properties.Resources.BMTH;
            pictureBoxThree.Image = Properties.Resources.BMTH;
        }//presents images after loading

        private void spinButton_Click(object sender, EventArgs e)
        {
            label2.Hide();
            
            for (int i = 0; i < 10; i++)
            {
                tempBox1 = rdm.Next(0, 6);
                pictureBoxOne.Image = images[tempBox1];

              //  System.Threading.Thread.Sleep(1);
            }
            for (int i = 0; i < 10; i++)
            {
                tempBox2 = rdm.Next(0, 6);
                pictureBoxTwo.Image = images[tempBox2];

               // System.Threading.Thread.Sleep(10);
            }
            for (int i = 0; i < 10; i++)
            {
                tempBox3 = rdm.Next(0, 6);
                pictureBoxThree.Image = images[tempBox3];

                //System.Threading.Thread.Sleep(10);
            }
            CheckWinner();
        }

        private void nudgeButtonOne_Click(object sender, EventArgs e)
        {
            label2.Hide();
            tempBox1 = rdm.Next(0, 6);
            pictureBoxOne.Image = images[tempBox1];

            CheckWinner();
            
        }

        private void nudgeButtonTwo_Click(object sender, EventArgs e)
        {
            label2.Hide();
            tempBox2 = rdm.Next(0, 6);
           pictureBoxTwo.Image = images[tempBox2];

            CheckWinner();
        }

        private void nudgeButtonThree_Click(object sender, EventArgs e)
        {
            label2.Hide();
            tempBox3 = rdm.Next(0, 6);
            pictureBoxThree.Image = images[tempBox3];

            CheckWinner();
        }
    }
}
