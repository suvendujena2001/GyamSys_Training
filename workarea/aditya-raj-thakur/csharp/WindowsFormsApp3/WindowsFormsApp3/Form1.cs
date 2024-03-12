using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn2_Click_1(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("1:  For Purchase,press=YES.\n 2: For trial \n 3:cancel order", " Purchasing Software ", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information);
            if (dr == DialogResult.Yes)
            {
                label3.Text = "purchased";
            }
            if (dr == DialogResult.No)
            {
                label3.Text = " take a 30 days free trial";
            }
            if (dr == DialogResult.Cancel)
            {
                label4.Text = "cancelled";
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
        private void Login()
        {
            string id = textUserID.Text;
            string pass = textPassword.Text;
            if (id == "25" && pass == "12345")
            {
                this.Hide();
                Form1 obj1 = new Form1();
                obj1.Show();

            }
            else
            {
                MessageBox.Show("INCORRECT");
                MessageBox.Show("Login Successful");
            }
        }
        private void btnlogin_Click(object sender, EventArgs e)
        {
            Login();
            MessageBox.Show("Login Successful");
           
        }

        private void btnreset_Click(object sender, EventArgs e)
        {
            textUserID.Text = "";
            textPassword.Text = "";
        }

        private void textPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                Login();
            }
            if((e.KeyChar == (char)Keys.Escape))
            {

                textUserID.Text = "";
                textPassword.Text = "";
            }
        }
    }
}
