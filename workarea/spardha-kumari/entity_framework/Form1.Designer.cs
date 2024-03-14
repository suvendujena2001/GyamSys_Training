namespace WindowsFormsApp5
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.trainingDbDataSet = new WindowsFormsApp5.TrainingDbDataSet();
            this.departmentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.departmentTableAdapter = new WindowsFormsApp5.TrainingDbDataSetTableAdapters.DepartmentTableAdapter();
            this.deptNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deptNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.locationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.employeeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.employeeTableAdapter = new WindowsFormsApp5.TrainingDbDataSetTableAdapters.EmployeeTableAdapter();
            this.empNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.empNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jobDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.managerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.joiningDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salaryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bonusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deptNoDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trainingDbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.departmentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.deptNoDataGridViewTextBoxColumn,
            this.deptNameDataGridViewTextBoxColumn,
            this.locationDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.departmentBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(28, 35);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.Size = new System.Drawing.Size(628, 150);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // trainingDbDataSet
            // 
            this.trainingDbDataSet.DataSetName = "TrainingDbDataSet";
            this.trainingDbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // departmentBindingSource
            // 
            this.departmentBindingSource.DataMember = "Department";
            this.departmentBindingSource.DataSource = this.trainingDbDataSet;
            // 
            // departmentTableAdapter
            // 
            this.departmentTableAdapter.ClearBeforeFill = true;
            // 
            // deptNoDataGridViewTextBoxColumn
            // 
            this.deptNoDataGridViewTextBoxColumn.DataPropertyName = "DeptNo";
            this.deptNoDataGridViewTextBoxColumn.HeaderText = "DeptNo";
            this.deptNoDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.deptNoDataGridViewTextBoxColumn.Name = "deptNoDataGridViewTextBoxColumn";
            this.deptNoDataGridViewTextBoxColumn.Width = 150;
            // 
            // deptNameDataGridViewTextBoxColumn
            // 
            this.deptNameDataGridViewTextBoxColumn.DataPropertyName = "DeptName";
            this.deptNameDataGridViewTextBoxColumn.HeaderText = "DeptName";
            this.deptNameDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.deptNameDataGridViewTextBoxColumn.Name = "deptNameDataGridViewTextBoxColumn";
            this.deptNameDataGridViewTextBoxColumn.Width = 150;
            // 
            // locationDataGridViewTextBoxColumn
            // 
            this.locationDataGridViewTextBoxColumn.DataPropertyName = "Location";
            this.locationDataGridViewTextBoxColumn.HeaderText = "Location";
            this.locationDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.locationDataGridViewTextBoxColumn.Name = "locationDataGridViewTextBoxColumn";
            this.locationDataGridViewTextBoxColumn.Width = 150;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.empNoDataGridViewTextBoxColumn,
            this.empNameDataGridViewTextBoxColumn,
            this.jobDataGridViewTextBoxColumn,
            this.managerDataGridViewTextBoxColumn,
            this.joiningDateDataGridViewTextBoxColumn,
            this.salaryDataGridViewTextBoxColumn,
            this.bonusDataGridViewTextBoxColumn,
            this.deptNoDataGridViewTextBoxColumn1});
            this.dataGridView2.DataSource = this.employeeBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(12, 191);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 62;
            this.dataGridView2.RowTemplate.Height = 28;
            this.dataGridView2.Size = new System.Drawing.Size(1069, 178);
            this.dataGridView2.TabIndex = 1;
            // 
            // employeeBindingSource
            // 
            this.employeeBindingSource.DataMember = "Employee";
            this.employeeBindingSource.DataSource = this.trainingDbDataSet;
            // 
            // employeeTableAdapter
            // 
            this.employeeTableAdapter.ClearBeforeFill = true;
            // 
            // empNoDataGridViewTextBoxColumn
            // 
            this.empNoDataGridViewTextBoxColumn.DataPropertyName = "EmpNo";
            this.empNoDataGridViewTextBoxColumn.HeaderText = "EmpNo";
            this.empNoDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.empNoDataGridViewTextBoxColumn.Name = "empNoDataGridViewTextBoxColumn";
            this.empNoDataGridViewTextBoxColumn.Width = 150;
            // 
            // empNameDataGridViewTextBoxColumn
            // 
            this.empNameDataGridViewTextBoxColumn.DataPropertyName = "EmpName";
            this.empNameDataGridViewTextBoxColumn.HeaderText = "EmpName";
            this.empNameDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.empNameDataGridViewTextBoxColumn.Name = "empNameDataGridViewTextBoxColumn";
            this.empNameDataGridViewTextBoxColumn.Width = 150;
            // 
            // jobDataGridViewTextBoxColumn
            // 
            this.jobDataGridViewTextBoxColumn.DataPropertyName = "Job";
            this.jobDataGridViewTextBoxColumn.HeaderText = "Job";
            this.jobDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.jobDataGridViewTextBoxColumn.Name = "jobDataGridViewTextBoxColumn";
            this.jobDataGridViewTextBoxColumn.Width = 150;
            // 
            // managerDataGridViewTextBoxColumn
            // 
            this.managerDataGridViewTextBoxColumn.DataPropertyName = "Manager";
            this.managerDataGridViewTextBoxColumn.HeaderText = "Manager";
            this.managerDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.managerDataGridViewTextBoxColumn.Name = "managerDataGridViewTextBoxColumn";
            this.managerDataGridViewTextBoxColumn.Width = 150;
            // 
            // joiningDateDataGridViewTextBoxColumn
            // 
            this.joiningDateDataGridViewTextBoxColumn.DataPropertyName = "JoiningDate";
            this.joiningDateDataGridViewTextBoxColumn.HeaderText = "JoiningDate";
            this.joiningDateDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.joiningDateDataGridViewTextBoxColumn.Name = "joiningDateDataGridViewTextBoxColumn";
            this.joiningDateDataGridViewTextBoxColumn.Width = 150;
            // 
            // salaryDataGridViewTextBoxColumn
            // 
            this.salaryDataGridViewTextBoxColumn.DataPropertyName = "Salary";
            this.salaryDataGridViewTextBoxColumn.HeaderText = "Salary";
            this.salaryDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.salaryDataGridViewTextBoxColumn.Name = "salaryDataGridViewTextBoxColumn";
            this.salaryDataGridViewTextBoxColumn.Width = 150;
            // 
            // bonusDataGridViewTextBoxColumn
            // 
            this.bonusDataGridViewTextBoxColumn.DataPropertyName = "Bonus";
            this.bonusDataGridViewTextBoxColumn.HeaderText = "Bonus";
            this.bonusDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.bonusDataGridViewTextBoxColumn.Name = "bonusDataGridViewTextBoxColumn";
            this.bonusDataGridViewTextBoxColumn.Width = 150;
            // 
            // deptNoDataGridViewTextBoxColumn1
            // 
            this.deptNoDataGridViewTextBoxColumn1.DataPropertyName = "DeptNo";
            this.deptNoDataGridViewTextBoxColumn1.HeaderText = "DeptNo";
            this.deptNoDataGridViewTextBoxColumn1.MinimumWidth = 8;
            this.deptNoDataGridViewTextBoxColumn1.Name = "deptNoDataGridViewTextBoxColumn1";
            this.deptNoDataGridViewTextBoxColumn1.Width = 150;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1104, 450);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trainingDbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.departmentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private TrainingDbDataSet trainingDbDataSet;
        private System.Windows.Forms.BindingSource departmentBindingSource;
        private TrainingDbDataSetTableAdapters.DepartmentTableAdapter departmentTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn deptNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn deptNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn locationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.BindingSource employeeBindingSource;
        private TrainingDbDataSetTableAdapters.EmployeeTableAdapter employeeTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn empNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn empNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn jobDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn managerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn joiningDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn salaryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bonusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn deptNoDataGridViewTextBoxColumn1;
    }
}

