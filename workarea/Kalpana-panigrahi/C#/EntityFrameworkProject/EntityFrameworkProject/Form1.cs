using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EntityFrameworkProject.EntityModel;
namespace EntityFrameworkProject
{
    public partial class Form1 : Form
    {
        TrainingDbEntities trainingDbEntities = new TrainingDbEntities();
        public Form1()
        {
            InitializeComponent();
            grid1.DataSource= trainingDbEntities.Employees.ToList();
        }

        private void grid1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < grid1.Rows.Count)
            {
                nametb.Text= grid1.Rows[e.RowIndex].Cells[1].Value.ToString();
                salarytb.Text  = grid1.Rows[e.RowIndex].Cells[5].Value.ToString();
                jobtb.Text  = grid1.Rows[e.RowIndex].Cells[2].Value.ToString();
                jdatetb.Text = grid1.Rows[e.RowIndex].Cells[4].Value.ToString();    
                bonustb.Text  = grid1.Rows[e.RowIndex].Cells[6].Value.ToString();
                int deptno= int.Parse(grid1.Rows[e.RowIndex].Cells[7].Value.ToString());
                var department = trainingDbEntities.Departments.FirstOrDefault(i => i.DeptNo == deptno);
                depttb.Text=department.DeptName.ToString();
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void depttb_TextChanged(object sender, EventArgs e)
        {
            
            
        }
    }
}
