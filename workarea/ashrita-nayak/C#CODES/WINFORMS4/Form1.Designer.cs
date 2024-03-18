namespace TreeviewProgram1
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Supervisor");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Students");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Parents");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Principal", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3});
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Coordinator");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("Teacher");
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.SuspendLayout();
            // 
            // treeView1
            // 
            this.treeView1.ImageIndex = 0;
            this.treeView1.ImageList = this.imageList1;
            this.treeView1.Location = new System.Drawing.Point(12, 12);
            this.treeView1.Name = "treeView1";
            treeNode1.ImageKey = "download (5).png";
            treeNode1.Name = "Node3";
            treeNode1.SelectedImageIndex = 0;
            treeNode1.Text = "Supervisor";
            treeNode2.ImageKey = "download (4).png";
            treeNode2.Name = "Students";
            treeNode2.SelectedImageIndex = 1;
            treeNode2.Text = "Students";
            treeNode3.ImageKey = "download (3).png";
            treeNode3.Name = "Parents";
            treeNode3.SelectedImageIndex = 2;
            treeNode3.Text = "Parents";
            treeNode4.ImageKey = "download (2).png";
            treeNode4.Name = "Node0";
            treeNode4.SelectedImageIndex = 3;
            treeNode4.Text = "Principal";
            treeNode5.ImageKey = "download (1).png";
            treeNode5.Name = "Node1";
            treeNode5.SelectedImageIndex = 4;
            treeNode5.Text = "Coordinator";
            treeNode6.ImageKey = "download.png";
            treeNode6.Name = "Node2";
            treeNode6.SelectedImageIndex = 5;
            treeNode6.Text = "Teacher";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode4,
            treeNode5,
            treeNode6});
            this.treeView1.SelectedImageIndex = 0;
            this.treeView1.Size = new System.Drawing.Size(1058, 426);
            this.treeView1.TabIndex = 0;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "download (5).png");
            this.imageList1.Images.SetKeyName(1, "download (4).png");
            this.imageList1.Images.SetKeyName(2, "download (3).png");
            this.imageList1.Images.SetKeyName(3, "download (2).png");
            this.imageList1.Images.SetKeyName(4, "download (1).png");
            this.imageList1.Images.SetKeyName(5, "download.png");
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1102, 450);
            this.Controls.Add(this.treeView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.ImageList imageList1;
    }
}

