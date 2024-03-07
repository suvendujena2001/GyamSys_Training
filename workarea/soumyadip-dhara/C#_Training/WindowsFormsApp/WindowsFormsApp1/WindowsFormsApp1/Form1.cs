using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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

        public string addition_res()
        {
            string ret;
            try
            {
                double a = Convert.ToDouble(txtbox1.Text);
                double b = Convert.ToDouble(txtBox2.Text);
                double c = a + b;
                ret = c.ToString();
            }
            catch (Exception ex)
            {
                ret = ex.Message + "\nPlease enter only numeric value.";
            }
            return ret;
       
        }
        public string mult_res()
        {
            string ret;
            try
            {
                double a = Convert.ToDouble(txtbox1.Text);
                double b = Convert.ToDouble(txtBox2.Text);
                double c = a * b;
                ret = c.ToString();
            }
            catch (Exception ex)
            {
                ret = ex.Message + "\nPlease enter only numeric value.";
            }
            return ret;
        }


        

        private void Form1_Load(object sender, EventArgs e)
        {
            txtbox1.Focus();
            BackColor = Color.Black;
            ForeColor = Color.White;
            btnbutton1.ForeColor = Color.Black;
            btnmult.ForeColor = Color.Black;
        }


        private void txtBox2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string c = addition_res();
                lblresult.Text = c;
                lblsum.Text = "sum=";
                lblresult.BackColor = Color.Red;

                string res = mult_res();
                lblmultcomment.Text = "Multiplication result=";
                lblmult.Text = res;
                lblmult.BackColor = Color.Red;
            }
            else if (e.KeyCode == Keys.Up)
            {
                txtbox1.Focus();
            }
        }

        private void txtbox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtBox2.Focus();
            }
            else if (e.KeyCode == Keys.Down)
            {
                txtBox2.Focus();
            }
        }

        private void btnbutton1_Click_1(object sender, EventArgs e)
        {
            string c = addition_res();
            lblsum.Text = "sum=";
            lblresult.Text = c;
            lblresult.BackColor = Color.Blue;
        }

        private void btnmult_Click(object sender, EventArgs e)
        {
            string res = mult_res();
            lblmultcomment.Text = "Multiplication result=";
            lblmult.Text = res;
            lblmult.BackColor = Color.Blue;
        }
    }
}
