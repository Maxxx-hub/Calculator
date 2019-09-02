using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculator
{
    public partial class Form1 : Form
    {
        double first;
        double second;
        double result;
        string operation;
        public Form1()
        {
          
            InitializeComponent();
        }

        private void Button10_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "0";
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "1";
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "2";
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "3";
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "4";
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "5";
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "6";
        }

        private void Button7_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "7";
        }

        private void Button8_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "8";
        }

        private void Button9_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "9";
        }

        private void Button17_Click(object sender, EventArgs e)
        {
            operation = "+";
            first = double.Parse(textBox1.Text);
            textBox1.Clear();
        }

        private void Button18_Click(object sender, EventArgs e)
        {
            operation = "-";
            first = double.Parse(textBox1.Text);
            textBox1.Clear();
        }

        private void Button16_Click(object sender, EventArgs e)
        {
            operation = "/";
            first = double.Parse(textBox1.Text);
            textBox1.Clear();
        }

        private void Button15_Click(object sender, EventArgs e)
        {
            operation = "x";
            first = double.Parse(textBox1.Text);
            textBox1.Clear();
        }

        private void Button14_Click(object sender, EventArgs e)
        {
            operation = "%";
            first = double.Parse(textBox1.Text);
            textBox1.Clear();
        }

        private void Button19_Click(object sender, EventArgs e)
        {
            second = double.Parse(textBox1.Text);

            switch (operation)
            {
                case "+":
                    result = first + second;
                    textBox1.Text = result.ToString();
                    break;
                case "-":
                    result = first - second;
                    textBox1.Text = result.ToString();
                    break;
                case "x":
                    result = first * second;
                    textBox1.Text = result.ToString();
                    break;
                case "/":
                    result = first / second;
                    textBox1.Text = result.ToString();
                    break;
                case "%":
                    result = first - (first * (second * .01));
                    textBox1.Text = result.ToString();
                    break;

            }

        }

        private void Button12_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
        }

        private void Button13_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
        }

        private void Button11_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + ".";
        }
    }
}
