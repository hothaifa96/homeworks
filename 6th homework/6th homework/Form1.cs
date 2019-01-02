using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _6th_homework
{
    public partial class Form1 : Form
    {
        int[] Sgame = new int[10];
        Color a, b, c, d;
        int hightscore = 0, score = 0;
        int pointer = 0; //int simonp = 0;
        int[] RandArr = new int[10];
        

        public Form1()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        
        private void panel1_Click(object sender, EventArgs e)
        {
            coloredLabel.ForeColor = panel1.BackColor;
        }
        private void panel2_Click_1(object sender, EventArgs e)
        {
            coloredLabel.ForeColor = panel2.BackColor;
        }
        private void panel3_Click_1(object sender, EventArgs e)
        {
            coloredLabel.ForeColor = panel3.BackColor;
        }
        private void panel4_Click(object sender, EventArgs e)
        {
            coloredLabel.ForeColor = panel4.BackColor;
        }

        private void simon1PL_Click(object sender, EventArgs e)
        {
            if (Sgame[pointer]==1)
            {
                score++;
                simonpointsLB.Text = "your score :" + score;
            }
            else
            {
                MessageBox.Show("Game over ");
                if (score > hightscore)
                    hightscore = score;
                simonhightscore.Text = "the high score is :" + hightscore;
                score = 0;
            }
            pointer++;

        }

        private void simon3PL_Click(object sender, EventArgs e)
        {
            if (Sgame[pointer] == 3)
            {
                
                score++;
                simonpointsLB.Text = "your score :" + score;
            }
            else
            {
                MessageBox.Show("Game over ");
                if (score > hightscore)
                    hightscore = score;
                simonhightscore.Text = "the high score is :" + hightscore;
                score = 0;
            }
            pointer++;
        }

        private void simon2PL_Click(object sender, EventArgs e)
        {
            if (Sgame[pointer] == 2)
            {
                score++;
                simonpointsLB.Text = "your score :" + score;
            }
            else
            {
                MessageBox.Show("Game over ");
                if (score > hightscore)
                    hightscore = score;
                simonhightscore.Text = "the high score is :" + hightscore;
                score = 0;
            }
            pointer++;
        }

        private void simon4PL_Click(object sender, EventArgs e)
        {
            if (Sgame[pointer] == 4)
            {
                score++;
                simonpointsLB.Text = "your score :" + score;
            }
            else
            {
                MessageBox.Show("Game over ");
                if (score > hightscore)
                    hightscore = score;
                score = 0;
                simonhightscore.Text = "the high score is :" + hightscore;
            }
            pointer++;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
            while (pictureBox1.Location.Y < 200)
            {
                pictureBox1.Location = new Point(pictureBox1.Location.X, pictureBox1.Location.Y + 1);
                Thread.Sleep(2);
            }
            while (pictureBox1.Location.Y > 0)
            {
                pictureBox1.Location = new Point(pictureBox1.Location.X, pictureBox1.Location.Y - 1);
                Thread.Sleep(2);
            }
        }

    

        private void panel5_Click(object sender, EventArgs e)
        {
            coloredLabel.ForeColor = panel5.BackColor;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Random r = new Random();
            for (int i = 0; i < RandArr.Length; i++)
            {
                RandArr[i] = r.Next(101);
            }
            simon1PL.BackColor = Color.FromArgb(r.Next(256), r.Next(256), r.Next(256));
            a = simon1PL.BackColor;
            simon2PL.BackColor = Color.FromArgb(r.Next(256), r.Next(256), r.Next(256));
            b = simon2PL.BackColor;
            simon3PL.BackColor = Color.FromArgb(r.Next(256), r.Next(256), r.Next(256));
            c = simon3PL.BackColor;
            simon4PL.BackColor = Color.FromArgb(r.Next(256), r.Next(256), r.Next(256));
            d = simon4PL.BackColor;
        }

        private void NextRandBt_Click( object sender, EventArgs e)
        {
            if (pointer < 10)
            {

                RandArrLB.Text = "" + RandArr[pointer];
                pointer++;
                if (pointer == 10)
                    RandArrLB.ForeColor = Color.Red;
            }
            else
                MessageBox.Show("End of the array ","warning",MessageBoxButtons.OK,MessageBoxIcon.Warning);
        }

        private void SimonStartBT_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            
            simonpointsLB.Text = $"your score:{score}";
            
            for (int i = 0; i < 10; i++)
            {
                Sgame[i] = rnd.Next(1, 5);
            }// to print the game from the array witch is random as the others 
            
                new Thread(() =>
                {
                    for (int i = 0; i < Sgame.Length; i++)
                    {

                        Thread.Sleep(750);
                        switch (Sgame[i])
                        {
                            case 1:
                                simon1PL.BackColor = Color.Black;
                                break;
                            case 2:
                                simon2PL.BackColor = Color.Black;
                                break;
                            case 3:
                                simon3PL.BackColor = Color.Black;
                                break;
                            case 4:
                                simon4PL.BackColor = Color.Black;
                                break;

                        }
                        Thread.Sleep(1000);
                        simon1PL.BackColor = a;
                        simon2PL.BackColor = b;
                        simon3PL.BackColor = c;
                        simon4PL.BackColor = d;

                    }
               
                }).Start();//thred to make the game start and black bpanel changes 
            

        }
    }
}
