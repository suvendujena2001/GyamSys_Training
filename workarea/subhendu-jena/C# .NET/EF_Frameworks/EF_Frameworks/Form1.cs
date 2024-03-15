using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace EF_Frameworks
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'trainingDBDataSet.DEPT' table. You can move, or remove it, as needed.
            this.dEPTTableAdapter.Fill(this.trainingDBDataSet.DEPT);
            // TODO: This line of code loads data into the 'trainingDBDataSet.EMPLOYEE' table. You can move, or remove it, as needed.
            this.eMPLOYEETableAdapter.Fill(this.trainingDBDataSet.EMPLOYEE);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void b1_Click(object sender, EventArgs e)
        { 
            int[] columnData = (from DataGridViewRow row in dataGridView1.Rows
                                where row.Cells[2].FormattedValue.ToString() != string.Empty
                                select Convert.ToInt32(row.Cells[2].FormattedValue)).ToArray();

            // Sum Value
            tB1.Text = columnData.Sum().ToString();
        }

        private void bClear_Click(object sender, EventArgs e)
        {
            tB1.Text = null;
            tB2.Text = null;
            tB3.Text = null;
            tB4.Text = null;
            tB5.Text = null;
        }

        private void b2_Click(object sender, EventArgs e)
        {
            int[] columnData = (from DataGridViewRow row in dataGridView1.Rows
                                where row.Cells[2].FormattedValue.ToString() != string.Empty
                                select Convert.ToInt32(row.Cells[2].FormattedValue)).ToArray();

            // Sum Value
            tB2.Text = columnData.Average().ToString();
        }

        private void b3_Click(object sender, EventArgs e)
        {
            int[] columnData = (from DataGridViewRow row in dataGridView1.Rows
                                where row.Cells[2].FormattedValue.ToString() != string.Empty
                                select Convert.ToInt32(row.Cells[2].FormattedValue)).ToArray();

            // Sum Value
            tB3.Text = columnData.Max().ToString();
        }

        private void b4_Click(object sender, EventArgs e)
        {
            int[] columnData = (from DataGridViewRow row in dataGridView1.Rows
                                where row.Cells[2].FormattedValue.ToString() != string.Empty
                                select Convert.ToInt32(row.Cells[2].FormattedValue)).ToArray();

            // Sum Value
            tB4.Text = columnData.Min().ToString();
        }

        private void cB1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string value = Convert.ToString(cB1.SelectedValue);
            tB5.Text = value.ToString();   
        }
    }
}
