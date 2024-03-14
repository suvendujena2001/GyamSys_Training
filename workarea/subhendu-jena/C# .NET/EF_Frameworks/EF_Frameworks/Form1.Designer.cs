namespace EF_Frameworks
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
            this.empIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emapNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.empSalaryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deptIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eMPLOYEEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.trainingDBDataSet = new EF_Frameworks.TrainingDBDataSet();
            this.eMPLOYEETableAdapter = new EF_Frameworks.TrainingDBDataSetTableAdapters.EMPLOYEETableAdapter();
            this.dEPTBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dEPTTableAdapter = new EF_Frameworks.TrainingDBDataSetTableAdapters.DEPTTableAdapter();
            this.b1 = new System.Windows.Forms.Button();
            this.tB1 = new System.Windows.Forms.TextBox();
            this.bClear = new System.Windows.Forms.Button();
            this.b2 = new System.Windows.Forms.Button();
            this.tB2 = new System.Windows.Forms.TextBox();
            this.b3 = new System.Windows.Forms.Button();
            this.b4 = new System.Windows.Forms.Button();
            this.tB3 = new System.Windows.Forms.TextBox();
            this.tB4 = new System.Windows.Forms.TextBox();
            this.cB1 = new System.Windows.Forms.ComboBox();
            this.eMPLOYEEBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.tB5 = new System.Windows.Forms.TextBox();
            this.eMPLOYEEBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.eMPLOYEEBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.eMPLOYEEBindingSource4 = new System.Windows.Forms.BindingSource(this.components);
            this.L1 = new System.Windows.Forms.Label();
            this.L2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eMPLOYEEBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trainingDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dEPTBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eMPLOYEEBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eMPLOYEEBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eMPLOYEEBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eMPLOYEEBindingSource4)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.empIdDataGridViewTextBoxColumn,
            this.emapNameDataGridViewTextBoxColumn,
            this.empSalaryDataGridViewTextBoxColumn,
            this.deptIDDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.eMPLOYEEBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(195, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(812, 311);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // empIdDataGridViewTextBoxColumn
            // 
            this.empIdDataGridViewTextBoxColumn.DataPropertyName = "EmpId";
            this.empIdDataGridViewTextBoxColumn.HeaderText = "EmpId";
            this.empIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.empIdDataGridViewTextBoxColumn.Name = "empIdDataGridViewTextBoxColumn";
            this.empIdDataGridViewTextBoxColumn.Width = 125;
            // 
            // emapNameDataGridViewTextBoxColumn
            // 
            this.emapNameDataGridViewTextBoxColumn.DataPropertyName = "EmapName";
            this.emapNameDataGridViewTextBoxColumn.HeaderText = "EmapName";
            this.emapNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.emapNameDataGridViewTextBoxColumn.Name = "emapNameDataGridViewTextBoxColumn";
            this.emapNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // empSalaryDataGridViewTextBoxColumn
            // 
            this.empSalaryDataGridViewTextBoxColumn.DataPropertyName = "EmpSalary";
            this.empSalaryDataGridViewTextBoxColumn.HeaderText = "EmpSalary";
            this.empSalaryDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.empSalaryDataGridViewTextBoxColumn.Name = "empSalaryDataGridViewTextBoxColumn";
            this.empSalaryDataGridViewTextBoxColumn.Width = 125;
            // 
            // deptIDDataGridViewTextBoxColumn
            // 
            this.deptIDDataGridViewTextBoxColumn.DataPropertyName = "DeptID";
            this.deptIDDataGridViewTextBoxColumn.HeaderText = "DeptID";
            this.deptIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.deptIDDataGridViewTextBoxColumn.Name = "deptIDDataGridViewTextBoxColumn";
            this.deptIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // eMPLOYEEBindingSource
            // 
            this.eMPLOYEEBindingSource.DataMember = "EMPLOYEE";
            this.eMPLOYEEBindingSource.DataSource = this.trainingDBDataSet;
            // 
            // trainingDBDataSet
            // 
            this.trainingDBDataSet.DataSetName = "TrainingDBDataSet";
            this.trainingDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // eMPLOYEETableAdapter
            // 
            this.eMPLOYEETableAdapter.ClearBeforeFill = true;
            // 
            // dEPTBindingSource
            // 
            this.dEPTBindingSource.DataMember = "DEPT";
            this.dEPTBindingSource.DataSource = this.trainingDBDataSet;
            // 
            // dEPTTableAdapter
            // 
            this.dEPTTableAdapter.ClearBeforeFill = true;
            // 
            // b1
            // 
            this.b1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.b1.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b1.Location = new System.Drawing.Point(195, 396);
            this.b1.Name = "b1";
            this.b1.Size = new System.Drawing.Size(134, 48);
            this.b1.TabIndex = 1;
            this.b1.Text = "TotalSal";
            this.b1.UseVisualStyleBackColor = false;
            this.b1.Click += new System.EventHandler(this.b1_Click);
            // 
            // tB1
            // 
            this.tB1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tB1.Location = new System.Drawing.Point(438, 405);
            this.tB1.Name = "tB1";
            this.tB1.Size = new System.Drawing.Size(158, 30);
            this.tB1.TabIndex = 2;
            // 
            // bClear
            // 
            this.bClear.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.bClear.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bClear.Location = new System.Drawing.Point(509, 622);
            this.bClear.Name = "bClear";
            this.bClear.Size = new System.Drawing.Size(119, 48);
            this.bClear.TabIndex = 3;
            this.bClear.Text = "CLEAR";
            this.bClear.UseVisualStyleBackColor = false;
            this.bClear.Click += new System.EventHandler(this.bClear_Click);
            // 
            // b2
            // 
            this.b2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.b2.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b2.Location = new System.Drawing.Point(195, 482);
            this.b2.Name = "b2";
            this.b2.Size = new System.Drawing.Size(134, 47);
            this.b2.TabIndex = 4;
            this.b2.Text = "AverageSal";
            this.b2.UseVisualStyleBackColor = false;
            this.b2.Click += new System.EventHandler(this.b2_Click);
            // 
            // tB2
            // 
            this.tB2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tB2.Location = new System.Drawing.Point(438, 490);
            this.tB2.Name = "tB2";
            this.tB2.Size = new System.Drawing.Size(158, 30);
            this.tB2.TabIndex = 5;
            // 
            // b3
            // 
            this.b3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.b3.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b3.Location = new System.Drawing.Point(728, 396);
            this.b3.Name = "b3";
            this.b3.Size = new System.Drawing.Size(134, 48);
            this.b3.TabIndex = 6;
            this.b3.Text = "MaxSal";
            this.b3.UseVisualStyleBackColor = false;
            this.b3.Click += new System.EventHandler(this.b3_Click);
            // 
            // b4
            // 
            this.b4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.b4.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b4.Location = new System.Drawing.Point(728, 488);
            this.b4.Name = "b4";
            this.b4.Size = new System.Drawing.Size(134, 43);
            this.b4.TabIndex = 7;
            this.b4.Text = "MinSal";
            this.b4.UseVisualStyleBackColor = false;
            this.b4.Click += new System.EventHandler(this.b4_Click);
            // 
            // tB3
            // 
            this.tB3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tB3.Location = new System.Drawing.Point(974, 405);
            this.tB3.Name = "tB3";
            this.tB3.Size = new System.Drawing.Size(145, 30);
            this.tB3.TabIndex = 8;
            // 
            // tB4
            // 
            this.tB4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tB4.Location = new System.Drawing.Point(974, 488);
            this.tB4.Name = "tB4";
            this.tB4.Size = new System.Drawing.Size(145, 30);
            this.tB4.TabIndex = 9;
            // 
            // cB1
            // 
            this.cB1.DataSource = this.eMPLOYEEBindingSource2;
            this.cB1.DisplayMember = "EmapName";
            this.cB1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cB1.FormattingEnabled = true;
            this.cB1.Location = new System.Drawing.Point(12, 63);
            this.cB1.Name = "cB1";
            this.cB1.Size = new System.Drawing.Size(176, 31);
            this.cB1.TabIndex = 10;
            this.cB1.ValueMember = "EmpSalary";
            this.cB1.SelectedIndexChanged += new System.EventHandler(this.cB1_SelectedIndexChanged);
            // 
            // eMPLOYEEBindingSource1
            // 
            this.eMPLOYEEBindingSource1.DataMember = "EMPLOYEE";
            this.eMPLOYEEBindingSource1.DataSource = this.trainingDBDataSet;
            // 
            // tB5
            // 
            this.tB5.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tB5.Location = new System.Drawing.Point(12, 177);
            this.tB5.Name = "tB5";
            this.tB5.Size = new System.Drawing.Size(176, 28);
            this.tB5.TabIndex = 11;
            // 
            // eMPLOYEEBindingSource2
            // 
            this.eMPLOYEEBindingSource2.DataMember = "EMPLOYEE";
            this.eMPLOYEEBindingSource2.DataSource = this.trainingDBDataSet;
            // 
            // eMPLOYEEBindingSource3
            // 
            this.eMPLOYEEBindingSource3.DataMember = "EMPLOYEE";
            this.eMPLOYEEBindingSource3.DataSource = this.trainingDBDataSet;
            // 
            // eMPLOYEEBindingSource4
            // 
            this.eMPLOYEEBindingSource4.DataMember = "EMPLOYEE";
            this.eMPLOYEEBindingSource4.DataSource = this.trainingDBDataSet;
            // 
            // L1
            // 
            this.L1.AutoSize = true;
            this.L1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.L1.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L1.Location = new System.Drawing.Point(13, 27);
            this.L1.Name = "L1";
            this.L1.Size = new System.Drawing.Size(134, 19);
            this.L1.TabIndex = 12;
            this.L1.Text = "Employee Name:";
            // 
            // L2
            // 
            this.L2.AutoSize = true;
            this.L2.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.L2.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L2.Location = new System.Drawing.Point(13, 143);
            this.L2.Name = "L2";
            this.L2.Size = new System.Drawing.Size(139, 19);
            this.L2.TabIndex = 13;
            this.L2.Text = "Employee Salary:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(1199, 682);
            this.Controls.Add(this.L2);
            this.Controls.Add(this.L1);
            this.Controls.Add(this.tB5);
            this.Controls.Add(this.cB1);
            this.Controls.Add(this.tB4);
            this.Controls.Add(this.tB3);
            this.Controls.Add(this.b4);
            this.Controls.Add(this.b3);
            this.Controls.Add(this.tB2);
            this.Controls.Add(this.b2);
            this.Controls.Add(this.bClear);
            this.Controls.Add(this.tB1);
            this.Controls.Add(this.b1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eMPLOYEEBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trainingDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dEPTBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eMPLOYEEBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eMPLOYEEBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eMPLOYEEBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eMPLOYEEBindingSource4)).EndInit();
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
        private System.Windows.Forms.BindingSource dEPTBindingSource;
        private TrainingDBDataSetTableAdapters.DEPTTableAdapter dEPTTableAdapter;
        private System.Windows.Forms.Button b1;
        private System.Windows.Forms.TextBox tB1;
        private System.Windows.Forms.Button bClear;
        private System.Windows.Forms.Button b2;
        private System.Windows.Forms.TextBox tB2;
        private System.Windows.Forms.Button b3;
        private System.Windows.Forms.Button b4;
        private System.Windows.Forms.TextBox tB3;
        private System.Windows.Forms.TextBox tB4;
        private System.Windows.Forms.ComboBox cB1;
        private System.Windows.Forms.BindingSource eMPLOYEEBindingSource1;
        private System.Windows.Forms.TextBox tB5;
        private System.Windows.Forms.BindingSource eMPLOYEEBindingSource2;
        private System.Windows.Forms.BindingSource eMPLOYEEBindingSource3;
        private System.Windows.Forms.BindingSource eMPLOYEEBindingSource4;
        private System.Windows.Forms.Label L1;
        private System.Windows.Forms.Label L2;
    }
}

