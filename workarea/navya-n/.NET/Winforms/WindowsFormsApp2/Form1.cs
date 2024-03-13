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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string text = Convert.ToString(txtName.Text);
            if(text.Length <0 ) { MessageBox.Show("Please enter name"); }
        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {
            toolTip1 = new ToolTip();
            toolTip1.SetToolTip(txtName, "Name should start from capital letter");
        }

        private void toolTip2_Popup(object sender, PopupEventArgs e)
        {
            toolPass = new ToolTip();
            toolPass.SetToolTip(txtPass, "Password should be atleast 8 characters wide");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(txtName.Text =="")
            {
                MessageBox.Show("Please enter user name");
            }
            if(txtPass.Text ==""||txtPass.Text.Length<=8)
            {
                MessageBox.Show("Please enter valid password");
            }
            if (txtName.Text != "" && txtPass.Text != ""&&txtPass.Text.Length>8)
            {
                MessageBox.Show("Registration complete");
            }
            
        }

        private void pictureReg_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox1.Items.Add("Bangalore");
            comboBox1.Items.Add("Chennai");
            comboBox1.Items.Add("Kerala");
            comboBox1.Items.Add("Telangana");

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
