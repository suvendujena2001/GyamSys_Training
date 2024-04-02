using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp2.Models;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        EntityFrameWork obj = new EntityFrameWork();
        

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            List<Employee> list = obj.Employees.ToList();
            dataGridView1.DataSource = list;

            comboBox1.DataSource = list;
            comboBox1.DisplayMember = "Name";
            comboBox1.ValueMember = "NationalIDNumber";
            progressBar1.Value= 0;


        }

        
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           var a=comboBox1.GetItemText(comboBox1.SelectedIndex);
            List<Employee> list = obj.Employees.ToList();
            textBox1.Text =a;
            
            progressBar1.Value += 10;
            if(progressBar1.Value == 100)
            {
                this.Close();
            }
            if(progressBar1.Value == 90)
            {
                MessageBox.Show("You are left with 1 attempt ");
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 frm=new Form2();
            frm.Show();
        }

        private void exiteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
