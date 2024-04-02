using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using static System.Net.Mime.MediaTypeNames;

namespace DataShow
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection con;
        DataTable table = new DataTable();
        private void Form1_Load(object sender, EventArgs e)
        {
            con = new SqlConnection(@"data source=IN-GVF3NX3;Database=TrainingDb;User Id=sa;Password=sa;");
            string selectquery = "select * from Employee";
            SqlDataAdapter adpt = new SqlDataAdapter(selectquery, con);

            // Open the connection before filling the DataTable
            con.Open();
            adpt.Fill(table);
            Console.WriteLine("Number of rows retrieved: " + table.Rows.Count);

            con.Close(); // Close the connection after filling the DataTable

            dataGridView1.DataSource = table;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                using (con = new SqlConnection(@"data source=IN-GVF3NX3;Database=TrainingDb;User Id=sa;Password=sa;"))
                {
                    con.Open();
                    string selectquery = "select * from Employee where id = @id";
                    SqlCommand cmd = new SqlCommand(selectquery, con);
                    cmd.Parameters.AddWithValue("@id", int.Parse(textID.Text));

                    SqlDataReader reader1 = cmd.ExecuteReader();
                    if (reader1.Read())
                    {
                        textName.Text = reader1.GetValue(1).ToString();
                        textCity.Text = reader1.GetValue(2).ToString();
                        textDeptId.Text = reader1.GetValue(3).ToString();
                        textDesignation.Text = reader1.GetValue(4).ToString();

                    }
                    else
                    {
                        MessageBox.Show("NO DATA FOUND");
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'trainingDbDataSet.Employee' table. You can move, or remove it, as needed.
            this.employeeTableAdapter.Fill(this.trainingDbDataSet.Employee);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                using (con = new SqlConnection(@"data source=IN-GVF3NX3;Database=TrainingDb;User Id=sa;Password=sa;"))
                {
                    con.Open();

                    string insertquery = "insert into Employee(id, name, city, depid, designation) values(@id, @name, @city, @depid, @designation)";
                    SqlCommand cmd = new SqlCommand(insertquery, con);
                    cmd.Parameters.AddWithValue("@id", int.Parse(textID.Text));
                    cmd.Parameters.AddWithValue("@name", textName.Text);
                    cmd.Parameters.AddWithValue("@city", textCity.Text);
                    cmd.Parameters.AddWithValue("@depid", int.Parse(textDeptId.Text));
                    cmd.Parameters.AddWithValue("@designation", textDesignation.Text);

                    if (cmd.ExecuteNonQuery() == 1)
                    {
                        MessageBox.Show("Data inserted successfully");
                    }
                    else
                    {
                        MessageBox.Show("Data not inserted successfully");
                    }

                    con.Close();
                }

                // Refresh DataGridView after inserting data
                SHOWALL();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void SHOWALL()
        {
            try
            {
                using (con = new SqlConnection(@"data source=IN-GVF3NX3;Database=TrainingDb;User Id=sa;Password=sa;"))
                {
                    string selectquery = "select * from Employee";
                    SqlDataAdapter adpt = new SqlDataAdapter(selectquery, con);

                    DataTable table = new DataTable();
                    adpt.Fill(table);

                    dataGridView1.DataSource = table;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                string deletequery = "DELETE FROM Employee WHERE id = @id";
                using (SqlConnection con = new SqlConnection(@"data source=IN-GVF3NX3;Database=TrainingDb;User Id=sa;Password=sa;"))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand(deletequery, con);
                    cmd.Parameters.AddWithValue("@id", int.Parse(textID.Text));

                    if (cmd.ExecuteNonQuery() == 1)
                    {
                        MessageBox.Show("Data deleted successfully");
                    }
                    else
                    {
                        MessageBox.Show("Data not deleted successfully");
                    }
                }

                // Refresh DataGridView after deleting data
                SHOWALL();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
       
        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                // Construct the basic query
                string updatequery = "UPDATE Employee SET ";

                // Check if the name field is specified
                if (!string.IsNullOrEmpty(textName.Text))
                {
                    updatequery += "name = @name, ";
                }

                // Check if the city field is specified
                if (!string.IsNullOrEmpty(textCity.Text))
                {
                    updatequery += "city = @city, ";
                }

                // Check if the depid field is specified
                if (!string.IsNullOrEmpty(textDeptId.Text))
                {
                    updatequery += "depid = @depid, ";
                }

                // Check if the designation field is specified
                if (!string.IsNullOrEmpty(textDesignation.Text))
                {
                    updatequery += "designation = @designation, ";
                }

                // Remove the trailing comma and space
                updatequery = updatequery.TrimEnd(',', ' ');

                // Add the WHERE clause
                updatequery += " WHERE id = @id";

                using (SqlConnection con = new SqlConnection(@"data source=IN-GVF3NX3;Database=TrainingDb;User Id=sa;Password=sa;"))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand(updatequery, con);

                    // Add parameters for fields that are specified
                    if (!string.IsNullOrEmpty(textName.Text))
                    {
                        cmd.Parameters.AddWithValue("@name", textName.Text);
                    }
                    if (!string.IsNullOrEmpty(textCity.Text))
                    {
                        cmd.Parameters.AddWithValue("@city", textCity.Text);
                    }
                    if (!string.IsNullOrEmpty(textDeptId.Text))
                    {
                        cmd.Parameters.AddWithValue("@depid", int.Parse(textDeptId.Text));
                    }
                    if (!string.IsNullOrEmpty(textDesignation.Text))
                    {
                        cmd.Parameters.AddWithValue("@designation", textDesignation.Text);
                    }

                    // Add parameter for the WHERE clause
                    cmd.Parameters.AddWithValue("@id", int.Parse(textID.Text));

                    if (cmd.ExecuteNonQuery() == 1)
                    {
                        MessageBox.Show("Data updated successfully");
                    }
                    else
                    {
                        MessageBox.Show("Data not updated successfully");
                    }
                }

                // Refresh DataGridView after updating data
                SHOWALL();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }


    }
}