namespace WindowsFormsApp4
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
            this.eMPIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eMPNAMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eMPSALARYDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eMPDEPTIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eMPLOYEEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.masterDataSet = new WindowsFormsApp4.masterDataSet();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.eMPLOYEETableAdapter = new WindowsFormsApp4.masterDataSetTableAdapters.EMPLOYEETableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eMPLOYEEBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.masterDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.eMPIDDataGridViewTextBoxColumn,
            this.eMPNAMEDataGridViewTextBoxColumn,
            this.eMPSALARYDataGridViewTextBoxColumn,
            this.eMPDEPTIDDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.eMPLOYEEBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 78);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1101, 503);
            this.dataGridView1.TabIndex = 0;
            // 
            // eMPIDDataGridViewTextBoxColumn
            // 
            this.eMPIDDataGridViewTextBoxColumn.DataPropertyName = "EMPID";
            this.eMPIDDataGridViewTextBoxColumn.HeaderText = "EMPID";
            this.eMPIDDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.eMPIDDataGridViewTextBoxColumn.Name = "eMPIDDataGridViewTextBoxColumn";
            this.eMPIDDataGridViewTextBoxColumn.Width = 150;
            // 
            // eMPNAMEDataGridViewTextBoxColumn
            // 
            this.eMPNAMEDataGridViewTextBoxColumn.DataPropertyName = "EMPNAME";
            this.eMPNAMEDataGridViewTextBoxColumn.HeaderText = "EMPNAME";
            this.eMPNAMEDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.eMPNAMEDataGridViewTextBoxColumn.Name = "eMPNAMEDataGridViewTextBoxColumn";
            this.eMPNAMEDataGridViewTextBoxColumn.Width = 150;
            // 
            // eMPSALARYDataGridViewTextBoxColumn
            // 
            this.eMPSALARYDataGridViewTextBoxColumn.DataPropertyName = "EMPSALARY";
            this.eMPSALARYDataGridViewTextBoxColumn.HeaderText = "EMPSALARY";
            this.eMPSALARYDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.eMPSALARYDataGridViewTextBoxColumn.Name = "eMPSALARYDataGridViewTextBoxColumn";
            this.eMPSALARYDataGridViewTextBoxColumn.Width = 150;
            // 
            // eMPDEPTIDDataGridViewTextBoxColumn
            // 
            this.eMPDEPTIDDataGridViewTextBoxColumn.DataPropertyName = "EMPDEPTID";
            this.eMPDEPTIDDataGridViewTextBoxColumn.HeaderText = "EMPDEPTID";
            this.eMPDEPTIDDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.eMPDEPTIDDataGridViewTextBoxColumn.Name = "eMPDEPTIDDataGridViewTextBoxColumn";
            this.eMPDEPTIDDataGridViewTextBoxColumn.Width = 150;
            // 
            // eMPLOYEEBindingSource
            // 
            this.eMPLOYEEBindingSource.DataMember = "EMPLOYEE";
            this.eMPLOYEEBindingSource.DataSource = this.masterDataSet;
            // 
            // masterDataSet
            // 
            this.masterDataSet.DataSetName = "masterDataSet";
            this.masterDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.eMPLOYEEBindingSource;
            this.comboBox1.DisplayMember = "EMPID";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(151, 37);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 28);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.ValueMember = "EMPID";
            // 
            // eMPLOYEETableAdapter
            // 
            this.eMPLOYEETableAdapter.ClearBeforeFill = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1146, 639);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eMPLOYEEBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.masterDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox comboBox1;
        private masterDataSet masterDataSet;
        private System.Windows.Forms.BindingSource eMPLOYEEBindingSource;
        private masterDataSetTableAdapters.EMPLOYEETableAdapter eMPLOYEETableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn eMPIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eMPNAMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eMPSALARYDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eMPDEPTIDDataGridViewTextBoxColumn;
    }
}

