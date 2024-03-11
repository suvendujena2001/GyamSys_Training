using System;
using System.Drawing.Text;
using System.Windows.Forms;
using static System.Net.WebRequestMethods;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            // Initialize the controls
            checkBox1.Text = "Check me!";
            checkedListBox1.Items.AddRange(new object[] { "Item 1", "Item 2", "Item 3" });
            dateTimePicker1.Value = DateTime.Now;
            listView1.View = View.Details;
            listView1.Columns.Add("Column 1", -2, HorizontalAlignment.Left);
            listView1.Items.AddRange(new ListViewItem[] {
                new ListViewItem("Item 1", 0),
                new ListViewItem("Item 2", 1),
                new ListViewItem("Item 3", 0)
            });
            monthCalendar1.MaxSelectionCount = 1;
            progressBar1.Value = 0;
            treeView1.Nodes.AddRange(new TreeNode[] {
                new TreeNode("Node 1", new TreeNode[] {
                    new TreeNode("Subnode 1"),
                    new TreeNode("Subnode 2")
                }),
                new TreeNode("Node 2"),
                new TreeNode("Node 3")
            });

            // Wire up event handlers
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            checkedListBox1.ItemCheck += checkedListBox1_ItemCheck;
            dateTimePicker1.ValueChanged += dateTimePicker1_ValueChanged;
            listView1.SelectedIndexChanged += listView1_SelectedIndexChanged;
            monthCalendar1.DateChanged += monthCalendar1_DateChanged;
            progressBar1.Click += progressBar1_Click;
            treeView1.AfterSelect += treeView1_AfterSelect;
            webBrowser1.Navigated += webBrowser1_Navigated;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            MessageBox.Show("CheckBox " + checkBox1.Name + " is " + (checkBox1.Checked ? "checked" : "unchecked"));
        }

        private void checkedListBox1_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            MessageBox.Show("Item " + (e.Index + 1) + " " + (e.NewValue == CheckState.Checked ? "checked" : "unchecked"));
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            //MessageBox.Show("Selected date: " + dateTimePicker1.Value.ToString("yyyy-MM-dd"));
            //dateTimePicker1.Value = Value.ToString("yyyy-MM-dd");
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                MessageBox.Show("Selected item: " + listView1.SelectedItems[0].Text);
            }
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            MessageBox.Show("Selected date: " + monthCalendar1.SelectionStart.ToString("yyyy-MM-dd"));
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {
            // MessageBox.Show("ProgressBar value: " + progressBar1.Value);
            progressBar1.Value = 0;
           for (int i = 0;i<100;i++)
            {
                progressBar1.Value++;
                if (progressBar1.Value == 100)
                {
                    MessageBox.Show("Download Completed!!");
                }
            }
           
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            MessageBox.Show("Selected node: " + e.Node.Text);
        }

        private void webBrowser1_Navigated(object sender, WebBrowserNavigatedEventArgs e)
        {
            MessageBox.Show("WebBrowser URL: " + e.Url.ToString());
            FontHeight=10;
        }
    }
}