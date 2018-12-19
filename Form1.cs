using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace home_work_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int min, max, x;
            if (Int32.TryParse(textBox1.Text, out min) && Int32.TryParse(textBox2.Text, out max))
            {
                if (min > max)
                {
                    label1.Text = "the first number should be bigger than the second number try again ";
                    label1.Visible = true;
                    
                }
                else
                {
                    x = rnd.Next(min, max + 1);

                    label1.Text = $"the random nimber is {x}";
                    Debug.WriteLine($"the random number is {x} ");
                    Debug.WriteLine($"the min vallue for the random number is {int.Parse(textBox1.Text)} and the max value is {int.Parse(textBox2.Text)}");
                    label1.Visible = true;
                }
            }

            else
            {
                label1.Text = "please check your input";
                label1.Visible = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
            textBox2.Text = "0";
            label1.Visible = false;
        }
    }
}
