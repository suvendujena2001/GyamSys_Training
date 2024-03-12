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

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lblHelloWorld.Text = "Hello world";
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            dateTimePicker1 = new DateTimePicker();
            dateTimePicker1.Value = DateTime.Now;
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            string gender = rdMale.Text;
            string gender1 = rdFemale.Text;
            


        }

        private void checkBox1_CheckedChanged_1(object sender, EventArgs e)
        {
            string course1 = chkC.Text;
            string course2 = chP.Text; 

            
        }

        private void lstCity_SelectedIndexChanged(object sender, EventArgs e)
        {
            string text=lstCity.GetItemText(lstCity.SelectedItem);
            MessageBox.Show(text);
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string name=textName.Text;
            string address=textAddress.Text;

            MessageBox.Show(name +" "+ address);
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("http://www.google.com");
        }

        private void rdFemale_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
