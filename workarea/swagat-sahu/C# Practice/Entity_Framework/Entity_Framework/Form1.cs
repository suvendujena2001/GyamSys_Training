using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Entity_Framework
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'trainingDBDataSet.EMPLOYEE' table. You can move, or remove it, as needed.
            this.eMPLOYEETableAdapter.Fill(this.trainingDBDataSet.EMPLOYEE);

        }

        private void b1_Click(object sender, EventArgs e)
        {
            int[] columnData = (from DataGridViewRow row in dataGridView1.Rows
                                where row.Cells[2].FormattedValue.ToString() != string.Empty
                                select Convert.ToInt32(row.Cells[2].FormattedValue)).ToArray();

            tB1.Text = columnData.Sum().ToString();
        }
    }
}
