namespace Entity_Framework
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
            this.trainingDBDataSet = new Entity_Framework.TrainingDBDataSet();
            this.eMPLOYEEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.eMPLOYEETableAdapter = new Entity_Framework.TrainingDBDataSetTableAdapters.EMPLOYEETableAdapter();
            this.empIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emapNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.empSalaryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deptIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tB1 = new System.Windows.Forms.TextBox();
            this.b1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trainingDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eMPLOYEEBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.empIdDataGridViewTextBoxColumn,
            this.emapNameDataGridViewTextBoxColumn,
            this.empSalaryDataGridViewTextBoxColumn,
            this.deptIDDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.eMPLOYEEBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 47);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(1012, 271);
            this.dataGridView1.TabIndex = 0;
            // 
            // trainingDBDataSet
            // 
            this.trainingDBDataSet.DataSetName = "TrainingDBDataSet";
            this.trainingDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // eMPLOYEEBindingSource
            // 
            this.eMPLOYEEBindingSource.DataMember = "EMPLOYEE";
            this.eMPLOYEEBindingSource.DataSource = this.trainingDBDataSet;
            // 
            // eMPLOYEETableAdapter
            // 
            this.eMPLOYEETableAdapter.ClearBeforeFill = true;
            // 
            // empIdDataGridViewTextBoxColumn
            // 
            this.empIdDataGridViewTextBoxColumn.DataPropertyName = "EmpId";
            this.empIdDataGridViewTextBoxColumn.HeaderText = "EmpId";
            this.empIdDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.empIdDataGridViewTextBoxColumn.Name = "empIdDataGridViewTextBoxColumn";
            this.empIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.empIdDataGridViewTextBoxColumn.Width = 150;
            // 
            // emapNameDataGridViewTextBoxColumn
            // 
            this.emapNameDataGridViewTextBoxColumn.DataPropertyName = "EmapName";
            this.emapNameDataGridViewTextBoxColumn.HeaderText = "EmapName";
            this.emapNameDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.emapNameDataGridViewTextBoxColumn.Name = "emapNameDataGridViewTextBoxColumn";
            this.emapNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.emapNameDataGridViewTextBoxColumn.Width = 150;
            // 
            // empSalaryDataGridViewTextBoxColumn
            // 
            this.empSalaryDataGridViewTextBoxColumn.DataPropertyName = "EmpSalary";
            this.empSalaryDataGridViewTextBoxColumn.HeaderText = "EmpSalary";
            this.empSalaryDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.empSalaryDataGridViewTextBoxColumn.Name = "empSalaryDataGridViewTextBoxColumn";
            this.empSalaryDataGridViewTextBoxColumn.ReadOnly = true;
            this.empSalaryDataGridViewTextBoxColumn.Width = 150;
            // 
            // deptIDDataGridViewTextBoxColumn
            // 
            this.deptIDDataGridViewTextBoxColumn.DataPropertyName = "DeptID";
            this.deptIDDataGridViewTextBoxColumn.HeaderText = "DeptID";
            this.deptIDDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.deptIDDataGridViewTextBoxColumn.Name = "deptIDDataGridViewTextBoxColumn";
            this.deptIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.deptIDDataGridViewTextBoxColumn.Width = 150;
            // 
            // tB1
            // 
            this.tB1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tB1.Location = new System.Drawing.Point(484, 384);
            this.tB1.Name = "tB1";
            this.tB1.Size = new System.Drawing.Size(167, 35);
            this.tB1.TabIndex = 1;
            // 
            // b1
            // 
            this.b1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.b1.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b1.Location = new System.Drawing.Point(257, 366);
            this.b1.Name = "b1";
            this.b1.Size = new System.Drawing.Size(167, 66);
            this.b1.TabIndex = 2;
            this.b1.Text = "TotalSal";
            this.b1.UseVisualStyleBackColor = false;
            this.b1.Click += new System.EventHandler(this.b1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1036, 611);
            this.Controls.Add(this.b1);
            this.Controls.Add(this.tB1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trainingDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eMPLOYEEBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private TrainingDBDataSet trainingDBDataSet;
        private System.Windows.Forms.BindingSource eMPLOYEEBindingSource;
        private TrainingDBDataSetTableAdapters.EMPLOYEETableAdapter eMPLOYEETableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn empIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emapNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn empSalaryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn deptIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox tB1;
        private System.Windows.Forms.Button b1;
    }
}

