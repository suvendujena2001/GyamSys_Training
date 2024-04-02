using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TreeviewProgram1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Reflectobjects obj = new Reflectobjects();
        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            obj.LoadForm(e.Node.Name, this);
        }
    }
}
