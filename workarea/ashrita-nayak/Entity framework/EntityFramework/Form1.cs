using EntityFramework.ConsumerTable;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EntityFramework
{
    public partial class Form1 : Form
    {
        ConsTable model = new ConsTable();
        public Form1()
        {
            InitializeComponent();
        }
       
        private void btnCancel_Click(object sender, EventArgs e)
        {
            Clear();
        }

        void Clear()
        {
            txtFirstname.Text = txtLastname.Text = txtCity.Text = txtAddress.Text = " ";
            btnSave.Text = "SAVE";
            btnDelete.Enabled = false;
            model.cons_id = 0;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            Clear();
           
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            model.first_name = txtFirstname.Text.Trim();
            model.last_name = txtLastname.Text.Trim();
            model.city = txtCity.Text.Trim();
            model.address = txtAddress.Text.Trim();
            MyconsumersEntities db = new MyconsumersEntities();
            if (model.cons_id == 0)
                db.ConsTables.Add(model);
            else
                db.Entry(model).State = EntityState.Modified;
                db.SaveChanges();
            
            Clear();
            PopulateDataGridView();
            MessageBox.Show("Submitted Successfully");
        }
        void PopulateDataGridView()
        {
            datagridconsumers.AutoGenerateColumns = false;
             MyconsumersEntities db = new MyconsumersEntities();
            datagridconsumers.DataSource = db.ConsTables.ToList<ConsTable>();
            
        }

        private void datagridconsumers_DoubleClick(object sender, EventArgs e)
        {
            if(datagridconsumers.CurrentRow.Index != -1)
            {
                model.cons_id = Convert.ToInt32(datagridconsumers.CurrentRow.Cells["cons_id"].Value);
                MyconsumersEntities db = new MyconsumersEntities();
                model = db.ConsTables.Where(x => x.cons_id == model.cons_id).FirstOrDefault();
                txtFirstname.Text = model.first_name;
                txtLastname.Text = model.last_name;
                txtCity.Text = model.city;
                txtAddress.Text = model.address;
                btnSave.Text = "UPDATE";
                btnDelete.Enabled = true;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure User, you want to delete this?",
                "EF CRUD OPERATION", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                MyconsumersEntities db = new MyconsumersEntities();
                var entry = db.Entry(model);
                if (entry.State == EntityState.Detached)
                    db.ConsTables.Attach(model);
                db.ConsTables.Remove(model);
                db.SaveChanges();
                PopulateDataGridView();
                Clear();
                MessageBox.Show("Deletion was executed successfully");
            }
        }
    }
}


