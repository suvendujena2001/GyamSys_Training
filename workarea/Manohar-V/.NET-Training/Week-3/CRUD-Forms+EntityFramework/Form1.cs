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
using System.Configuration;

namespace CRUD_Forms_EntityFramework
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            WindowsForms1 db = new WindowsForms1 ();
            User user = new User ();
            user.UserId = int.Parse(textbox_UserId.Text);
            user.UserName = textBox_UserName.Text;
            db.Users.Add (user);
            db.SaveChanges ();
            MessageBox.Show("inserted!!");
        }
    }
}
