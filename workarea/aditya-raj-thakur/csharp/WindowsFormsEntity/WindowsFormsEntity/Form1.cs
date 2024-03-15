using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsEntity;

namespace WindowsFormsEntity
{
    public partial class Form1 : Form
    {   

        EntityModel obj=new EntityModel();
        public Form1()
        {
            InitializeComponent();
            this.Load += Form1_Load;
        }
        private void Form1_Load(object sender, EventArgs e)
        {   
            List<Employee> employees = obj.Employees.ToList();
            dataGridView1.DataSource = employees;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            var dt= obj.SaveChanges();
            Console.WriteLine(dt);
            MessageBox.Show("Saved");
        }

        
    }
}
