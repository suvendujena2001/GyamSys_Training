using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClinicManagement
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            Mypatient Pat = new Mypatient();
            string query = "select * from patient";            
            DataSet ds = Pat.ShowPatient(query); 
            Patientdgv.DataSource= ds.Tables[0];
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string query = "insert into patient values ('" + PatNameTb.Text + "','" + PatPhoneTb.Text + "','" + AddressTb.Text + "','" + DOBdata.Value.Date + "','" + GenderCb.SelectedItem.ToString() + "','" + AllergiesTb.Text + "')";
            Mypatient Pat = new Mypatient();
            try
            {
                Pat.AddPatient(query);
                MessageBox.Show("Patient Successfully Added");
            }catch(Exception EX)
            {
                MessageBox.Show(EX.Message);
            }
        }
        int key = 0;

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < Patientdgv.Rows.Count)
            {
                PatNameTb.Text = Patientdgv.Rows[e.RowIndex].Cells[1].Value.ToString();
                PatPhoneTb.Text = Patientdgv.Rows[e.RowIndex].Cells[2].Value.ToString();
                AddressTb.Text = Patientdgv.Rows[e.RowIndex].Cells[3].Value.ToString();
                GenderCb.SelectedItem = Patientdgv.Rows[e.RowIndex].Cells[5].Value.ToString();
                AllergiesTb.Text = Patientdgv.Rows[e.RowIndex].Cells[6].Value.ToString();

                if (PatNameTb.Text == "")
                {
                    key = 0;
                }
                else
                {
                    key = Convert.ToInt32(Patientdgv.Rows[e.RowIndex].Cells[0].Value.ToString());
                }
            }
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Mypatient Pat = new Mypatient();
            string query = "Delete * from patient";
            DataSet ds = Pat.ShowPatient(query);
            Patientdgv.DataSource = ds.Tables[0];
        }
    }
}
