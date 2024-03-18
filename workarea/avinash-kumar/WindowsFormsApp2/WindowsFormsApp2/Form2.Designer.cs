namespace WindowsFormsApp2
{
    partial class Form2
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
            this.EmployeeId = new System.Windows.Forms.Label();
            this.EmployeeName = new System.Windows.Forms.Label();
            this.EmployeeSalary = new System.Windows.Forms.Label();
            this.EmployeDepartementId = new System.Windows.Forms.Label();
            this.EmployeeIdtxt = new System.Windows.Forms.TextBox();
            this.EmployeeNameTxt = new System.Windows.Forms.TextBox();
            this.EmployeeDepartmentIdTxt = new System.Windows.Forms.TextBox();
            this.EmployeeSalaryTxt = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.DepartmentId = new System.Windows.Forms.Label();
            this.DepartmentIdTxt = new System.Windows.Forms.TextBox();
            this.DepartmentName = new System.Windows.Forms.Label();
            this.DepartmentNameTxt = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.Delete = new System.Windows.Forms.Button();
            this.deltxt = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // EmployeeId
            // 
            this.EmployeeId.AutoSize = true;
            this.EmployeeId.Location = new System.Drawing.Point(12, 24);
            this.EmployeeId.Name = "EmployeeId";
            this.EmployeeId.Size = new System.Drawing.Size(97, 20);
            this.EmployeeId.TabIndex = 0;
            this.EmployeeId.Text = "Employee Id";
            // 
            // EmployeeName
            // 
            this.EmployeeName.AutoSize = true;
            this.EmployeeName.Location = new System.Drawing.Point(12, 59);
            this.EmployeeName.Name = "EmployeeName";
            this.EmployeeName.Size = new System.Drawing.Size(125, 20);
            this.EmployeeName.TabIndex = 0;
            this.EmployeeName.Text = "Employee Name";
            // 
            // EmployeeSalary
            // 
            this.EmployeeSalary.AutoSize = true;
            this.EmployeeSalary.Location = new System.Drawing.Point(12, 91);
            this.EmployeeSalary.Name = "EmployeeSalary";
            this.EmployeeSalary.Size = new System.Drawing.Size(127, 20);
            this.EmployeeSalary.TabIndex = 0;
            this.EmployeeSalary.Text = "Employee Salary";
            // 
            // EmployeDepartementId
            // 
            this.EmployeDepartementId.AutoSize = true;
            this.EmployeDepartementId.Location = new System.Drawing.Point(12, 124);
            this.EmployeDepartementId.Name = "EmployeDepartementId";
            this.EmployeDepartementId.Size = new System.Drawing.Size(186, 20);
            this.EmployeDepartementId.TabIndex = 0;
            this.EmployeDepartementId.Text = "Employee Department Id";
            // 
            // EmployeeIdtxt
            // 
            this.EmployeeIdtxt.Location = new System.Drawing.Point(124, 21);
            this.EmployeeIdtxt.Name = "EmployeeIdtxt";
            this.EmployeeIdtxt.Size = new System.Drawing.Size(210, 26);
            this.EmployeeIdtxt.TabIndex = 1;
            // 
            // EmployeeNameTxt
            // 
            this.EmployeeNameTxt.Location = new System.Drawing.Point(143, 57);
            this.EmployeeNameTxt.Name = "EmployeeNameTxt";
            this.EmployeeNameTxt.Size = new System.Drawing.Size(191, 26);
            this.EmployeeNameTxt.TabIndex = 1;
           // this.EmployeeNameTxt.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // EmployeeDepartmentIdTxt
            // 
            this.EmployeeDepartmentIdTxt.Location = new System.Drawing.Point(204, 121);
            this.EmployeeDepartmentIdTxt.Name = "EmployeeDepartmentIdTxt";
            this.EmployeeDepartmentIdTxt.Size = new System.Drawing.Size(139, 26);
            this.EmployeeDepartmentIdTxt.TabIndex = 1;
            // 
            // EmployeeSalaryTxt
            // 
            this.EmployeeSalaryTxt.Location = new System.Drawing.Point(143, 85);
            this.EmployeeSalaryTxt.Name = "EmployeeSalaryTxt";
            this.EmployeeSalaryTxt.Size = new System.Drawing.Size(191, 26);
            this.EmployeeSalaryTxt.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(78, 167);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(210, 44);
            this.button1.TabIndex = 2;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(16, 243);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(728, 383);
            this.dataGridView1.TabIndex = 3;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(750, 243);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 62;
            this.dataGridView2.RowTemplate.Height = 28;
            this.dataGridView2.Size = new System.Drawing.Size(509, 383);
            this.dataGridView2.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 217);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Employee Table";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(760, 217);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Department Table";
            // 
            // DepartmentId
            // 
            this.DepartmentId.AutoSize = true;
            this.DepartmentId.Location = new System.Drawing.Point(722, 37);
            this.DepartmentId.Name = "DepartmentId";
            this.DepartmentId.Size = new System.Drawing.Size(112, 20);
            this.DepartmentId.TabIndex = 0;
            this.DepartmentId.Text = "Department Id";
            // 
            // DepartmentIdTxt
            // 
            this.DepartmentIdTxt.Location = new System.Drawing.Point(864, 34);
            this.DepartmentIdTxt.Name = "DepartmentIdTxt";
            this.DepartmentIdTxt.Size = new System.Drawing.Size(210, 26);
            this.DepartmentIdTxt.TabIndex = 1;
            // 
            // DepartmentName
            // 
            this.DepartmentName.AutoSize = true;
            this.DepartmentName.Location = new System.Drawing.Point(722, 73);
            this.DepartmentName.Name = "DepartmentName";
            this.DepartmentName.Size = new System.Drawing.Size(136, 20);
            this.DepartmentName.TabIndex = 0;
            this.DepartmentName.Text = "DepartmentName";
            // 
            // DepartmentNameTxt
            // 
            this.DepartmentNameTxt.Location = new System.Drawing.Point(864, 70);
            this.DepartmentNameTxt.Name = "DepartmentNameTxt";
            this.DepartmentNameTxt.Size = new System.Drawing.Size(210, 26);
            this.DepartmentNameTxt.TabIndex = 1;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(777, 122);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(210, 44);
            this.button2.TabIndex = 2;
            this.button2.Text = "Save";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(459, 203);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(155, 34);
            this.button3.TabIndex = 6;
            this.button3.Text = "Fetch The data";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(43, 666);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(199, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Enter Id To delete the data";
            // 
            // Delete
            // 
            this.Delete.Location = new System.Drawing.Point(446, 647);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(155, 58);
            this.Delete.TabIndex = 8;
            this.Delete.Text = "Delete";
            this.Delete.UseVisualStyleBackColor = true;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // deltxt
            // 
            this.deltxt.Location = new System.Drawing.Point(264, 663);
            this.deltxt.Name = "deltxt";
            this.deltxt.Size = new System.Drawing.Size(162, 26);
            this.deltxt.TabIndex = 9;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1209, 893);
            this.Controls.Add(this.deltxt);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.EmployeeSalaryTxt);
            this.Controls.Add(this.EmployeeDepartmentIdTxt);
            this.Controls.Add(this.EmployeeNameTxt);
            this.Controls.Add(this.DepartmentNameTxt);
            this.Controls.Add(this.DepartmentIdTxt);
            this.Controls.Add(this.EmployeeIdtxt);
            this.Controls.Add(this.EmployeDepartementId);
            this.Controls.Add(this.EmployeeSalary);
            this.Controls.Add(this.EmployeeName);
            this.Controls.Add(this.DepartmentName);
            this.Controls.Add(this.DepartmentId);
            this.Controls.Add(this.EmployeeId);
            this.Name = "Form2";
            this.Text = "Form2";
           // this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label EmployeeId;
        private System.Windows.Forms.Label EmployeeName;
        private System.Windows.Forms.Label EmployeeSalary;
        private System.Windows.Forms.Label EmployeDepartementId;
        private System.Windows.Forms.TextBox EmployeeIdtxt;
        private System.Windows.Forms.TextBox EmployeeNameTxt;
        private System.Windows.Forms.TextBox EmployeeDepartmentIdTxt;
        private System.Windows.Forms.TextBox EmployeeSalaryTxt;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label DepartmentId;
        private System.Windows.Forms.TextBox DepartmentIdTxt;
        private System.Windows.Forms.Label DepartmentName;
        private System.Windows.Forms.TextBox DepartmentNameTxt;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.TextBox deltxt;
    }
}