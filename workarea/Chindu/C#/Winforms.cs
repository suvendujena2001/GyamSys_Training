using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        String CalTotal;
        int num1;
        int num2;
        String option;
        int result;

        private void button5_Click(object sender, EventArgs e)
        {
            textTOTAL.Text = textTOTAL.Text + btn5.Text;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textTOTAL.Text = textTOTAL.Text + btn2.Text;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textTOTAL.Text = textTOTAL.Text + btn4.Text;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textTOTAL.Text = textTOTAL.Text + btn7.Text;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            option = "+";
            num1 = int.Parse(textTOTAL.Text); 
            textTOTAL.Clear();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            textTOTAL.Text = textTOTAL.Text + btn1.Text;

        }

        private void btn3_Click(object sender, EventArgs e)
        {
            textTOTAL.Text = textTOTAL.Text + btn3.Text;
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            textTOTAL.Text = textTOTAL.Text + btn6.Text;
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            textTOTAL.Text = textTOTAL.Text + btn8.Text;
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            textTOTAL.Text = textTOTAL.Text + btn9.Text;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textTOTAL.Text = textTOTAL.Text + btn0.Text;
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            option = "-";
            num1 = int.Parse(textTOTAL.Text);
            textTOTAL.Clear();
        }

        private void btnMul_Click(object sender, EventArgs e)
        {
            option = "*";
            num1 = int.Parse(textTOTAL.Text);
            textTOTAL.Clear();
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            option = "/";
            num1 = int.Parse(textTOTAL.Text);
            textTOTAL.Clear();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            textTOTAL.Clear();
            result = (0);
            num1 = (0);
            num2 = (0);

        }
        private void btnEquals_Click(object sender, EventArgs e)
        {
            num2 = int.Parse(textTOTAL.Text);

            if (option.Equals("+"))
                result = num1 + num2;

            if (option.Equals("-"))
                result = num1 - num2;

            if (option.Equals("*"))
                result = num1 * num2;

            if (option.Equals("/"))
                result = num1 / num2;

            textTOTAL.Text = result + "";
        }
    }
}
