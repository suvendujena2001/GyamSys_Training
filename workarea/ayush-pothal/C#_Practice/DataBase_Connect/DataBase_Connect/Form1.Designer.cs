namespace DataBase_Connect
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
            this.trainingDbDataSet = new DataBase_Connect.TrainingDbDataSet();
            this.trainingDbDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dEPTTABLEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dEPT_TABLETableAdapter = new DataBase_Connect.TrainingDbDataSetTableAdapters.DEPT_TABLETableAdapter();
            this.deptIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deptNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.empIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.eMPLOYEETABLEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.eMPLOYEE_TABLETableAdapter = new DataBase_Connect.TrainingDbDataSetTableAdapters.EMPLOYEE_TABLETableAdapter();
            this.empIdDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.empNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.empSalaryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deptIdDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trainingDbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trainingDbDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dEPTTABLEBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eMPLOYEETABLEBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.deptIdDataGridViewTextBoxColumn,
            this.deptNameDataGridViewTextBoxColumn,
            this.empIdDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.dEPTTABLEBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(58, 28);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(513, 263);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // trainingDbDataSet
            // 
            this.trainingDbDataSet.DataSetName = "TrainingDbDataSet";
            this.trainingDbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // trainingDbDataSetBindingSource
            // 
            this.trainingDbDataSetBindingSource.DataSource = this.trainingDbDataSet;
            this.trainingDbDataSetBindingSource.Position = 0;
            // 
            // dEPTTABLEBindingSource
            // 
            this.dEPTTABLEBindingSource.DataMember = "DEPT_TABLE";
            this.dEPTTABLEBindingSource.DataSource = this.trainingDbDataSetBindingSource;
            // 
            // dEPT_TABLETableAdapter
            // 
            this.dEPT_TABLETableAdapter.ClearBeforeFill = true;
            // 
            // deptIdDataGridViewTextBoxColumn
            // 
            this.deptIdDataGridViewTextBoxColumn.DataPropertyName = "DeptId";
            this.deptIdDataGridViewTextBoxColumn.HeaderText = "DeptId";
            this.deptIdDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.deptIdDataGridViewTextBoxColumn.Name = "deptIdDataGridViewTextBoxColumn";
            this.deptIdDataGridViewTextBoxColumn.Width = 150;
            // 
            // deptNameDataGridViewTextBoxColumn
            // 
            this.deptNameDataGridViewTextBoxColumn.DataPropertyName = "DeptName";
            this.deptNameDataGridViewTextBoxColumn.HeaderText = "DeptName";
            this.deptNameDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.deptNameDataGridViewTextBoxColumn.Name = "deptNameDataGridViewTextBoxColumn";
            this.deptNameDataGridViewTextBoxColumn.Width = 150;
            // 
            // empIdDataGridViewTextBoxColumn
            // 
            this.empIdDataGridViewTextBoxColumn.DataPropertyName = "EmpId";
            this.empIdDataGridViewTextBoxColumn.HeaderText = "EmpId";
            this.empIdDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.empIdDataGridViewTextBoxColumn.Name = "empIdDataGridViewTextBoxColumn";
            this.empIdDataGridViewTextBoxColumn.Width = 150;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.empIdDataGridViewTextBoxColumn1,
            this.empNameDataGridViewTextBoxColumn,
            this.empSalaryDataGridViewTextBoxColumn,
            this.deptIdDataGridViewTextBoxColumn1});
            this.dataGridView2.DataSource = this.eMPLOYEETABLEBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(622, 3);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 62;
            this.dataGridView2.RowTemplate.Height = 28;
            this.dataGridView2.Size = new System.Drawing.Size(666, 328);
            this.dataGridView2.TabIndex = 1;
            // 
            // eMPLOYEETABLEBindingSource
            // 
            this.eMPLOYEETABLEBindingSource.DataMember = "EMPLOYEE_TABLE";
            this.eMPLOYEETABLEBindingSource.DataSource = this.trainingDbDataSetBindingSource;
            // 
            // eMPLOYEE_TABLETableAdapter
            // 
            this.eMPLOYEE_TABLETableAdapter.ClearBeforeFill = true;
            // 
            // empIdDataGridViewTextBoxColumn1
            // 
            this.empIdDataGridViewTextBoxColumn1.DataPropertyName = "EmpId";
            this.empIdDataGridViewTextBoxColumn1.HeaderText = "EmpId";
            this.empIdDataGridViewTextBoxColumn1.MinimumWidth = 8;
            this.empIdDataGridViewTextBoxColumn1.Name = "empIdDataGridViewTextBoxColumn1";
            this.empIdDataGridViewTextBoxColumn1.Width = 150;
            // 
            // empNameDataGridViewTextBoxColumn
            // 
            this.empNameDataGridViewTextBoxColumn.DataPropertyName = "EmpName";
            this.empNameDataGridViewTextBoxColumn.HeaderText = "EmpName";
            this.empNameDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.empNameDataGridViewTextBoxColumn.Name = "empNameDataGridViewTextBoxColumn";
            this.empNameDataGridViewTextBoxColumn.Width = 150;
            // 
            // empSalaryDataGridViewTextBoxColumn
            // 
            this.empSalaryDataGridViewTextBoxColumn.DataPropertyName = "EmpSalary";
            this.empSalaryDataGridViewTextBoxColumn.HeaderText = "EmpSalary";
            this.empSalaryDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.empSalaryDataGridViewTextBoxColumn.Name = "empSalaryDataGridViewTextBoxColumn";
            this.empSalaryDataGridViewTextBoxColumn.Width = 150;
            // 
            // deptIdDataGridViewTextBoxColumn1
            // 
            this.deptIdDataGridViewTextBoxColumn1.DataPropertyName = "DeptId";
            this.deptIdDataGridViewTextBoxColumn1.HeaderText = "DeptId";
            this.deptIdDataGridViewTextBoxColumn1.MinimumWidth = 8;
            this.deptIdDataGridViewTextBoxColumn1.Name = "deptIdDataGridViewTextBoxColumn1";
            this.deptIdDataGridViewTextBoxColumn1.Width = 150;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1300, 662);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trainingDbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trainingDbDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dEPTTABLEBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eMPLOYEETABLEBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource trainingDbDataSetBindingSource;
        private TrainingDbDataSet trainingDbDataSet;
        private System.Windows.Forms.BindingSource dEPTTABLEBindingSource;
        private TrainingDbDataSetTableAdapters.DEPT_TABLETableAdapter dEPT_TABLETableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn deptIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn deptNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn empIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.BindingSource eMPLOYEETABLEBindingSource;
        private TrainingDbDataSetTableAdapters.EMPLOYEE_TABLETableAdapter eMPLOYEE_TABLETableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn empIdDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn empNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn empSalaryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn deptIdDataGridViewTextBoxColumn1;
    }
}

