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

namespace _5th_homework
{
    public partial class Form1 : Form
    {
        private object debug;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double x, y;
            ConvertTextBoxValue(out x, out y);
            listBox1.Items.Add($"{x} + {y} = {x+y}");
        }

        private void ConvertTextBoxValue(out double x, out double y)
        {
            
             double.TryParse(firstTXTB.Text,out x);
             double.TryParse(secondTXTB.Text,out y );
            
               

        }

        private void minBt_Click(object sender, EventArgs e)
        {
            double x, y;
            ConvertTextBoxValue(out x, out y);
            listBox1.Items.Add($"{x} - {y} = {x - y}");
        }

        private void timesBt_Click(object sender, EventArgs e)
        {
            double x, y;
            ConvertTextBoxValue(out x, out y);
            listBox1.Items.Add($"{x} * {y} = {x * y}");
        }

        private void divideBt_Click(object sender, EventArgs e)
        {
            double x, y;
            ConvertTextBoxValue(out x, out y);
            if (y != 0)
                listBox1.Items.Add($"{x} / {y} = {x / y}");
            else
            {
                listBox1.Items.Add("you can't divide by 0 try again");
                this.BackColor = System.Drawing.Color.Red;
            }
        }

        private void powerBt_Click(object sender, EventArgs e)
        {
            double x, y;
            ConvertTextBoxValue(out x, out y);
            listBox1.Items.Add(y!=0? $"{x} ^ {y} = {Math.Pow(x,y)}": $"{x} ^ {y} = 1");
        }

        private void rootBt_Click(object sender, EventArgs e)
        {
            double x, y;
            ConvertTextBoxValue(out x, out y);
            listBox1.Items.Add($"{x} root {y} = {Math.Pow(x,( 1.0/y))}");
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void clearBt_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            Debug.WriteLine("listbox cleard !!!");
        }

        private void randomBt_Click(object sender, EventArgs e)
        {
            Random r = new Random();
            firstTXTB.Clear();secondTXTB.Clear();
            firstTXTB.Text = $"{r.Next(0,101)}";
            secondTXTB.Text = $"{r.Next(0, 101)}";

        }
    }
}
