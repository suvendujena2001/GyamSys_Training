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

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            int first = Convert.ToInt32(txtFirst.Text);
            int second = Convert.ToInt32(txtSecond.Text);
            int sum =  first + second;
            lblResult.Text = sum.ToString();
        }
    }
}
