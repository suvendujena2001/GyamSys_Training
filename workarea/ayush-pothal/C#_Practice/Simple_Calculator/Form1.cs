using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Calculator
{
    public partial class Form1 : Form
    {
        private double a; 
        private double b;
        private char c;

        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            double.TryParse(textBox1.Text, out a);
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            double.TryParse(textBox2.Text, out b); 
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            c = Convert.ToChar(textBox3.Text); 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double result;

            switch (c)
            {
                case '+':
                    result = a + b;
                    break;
                case '-':
                    result = a - b; 
                    break;
                case '*':
                    result = a * b; 
                    break;
                case '/':
                    if (b != 0) 
                        result = a / b; 
                    else
                    {
                        Console.WriteLine("Division by zero is not allowed.");
                        return;
                    }
                    break;
                default:
                    Console.WriteLine("Invalid operation.");
                    return;
                    
            }
            label4.Text = result.ToString();
        }
    }
}
