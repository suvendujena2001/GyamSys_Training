using System;

namespace EntityFramework
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtFirstname = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.datagridconsumers = new System.Windows.Forms.DataGridView();
            this.consTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.myconsumersDataSet = new EntityFramework.MyconsumersDataSet();
            this.label2 = new System.Windows.Forms.Label();
            this.txtLastname = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.consTableTableAdapter = new EntityFramework.MyconsumersDataSetTableAdapters.ConsTableTableAdapter();
            this.cons_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.first_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.last_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.city = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.datagridconsumers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.consTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.myconsumersDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 26);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "First Name";
            // 
            // txtFirstname
            // 
            this.txtFirstname.Location = new System.Drawing.Point(140, 26);
            this.txtFirstname.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtFirstname.Name = "txtFirstname";
            this.txtFirstname.Size = new System.Drawing.Size(248, 29);
            this.txtFirstname.TabIndex = 1;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(79, 344);
            this.btnSave.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(110, 57);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "SAVE";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // datagridconsumers
            // 
            this.datagridconsumers.AllowUserToDeleteRows = false;
            this.datagridconsumers.AutoGenerateColumns = false;
            this.datagridconsumers.BackgroundColor = System.Drawing.SystemColors.Window;
            this.datagridconsumers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagridconsumers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cons_id,
            this.first_name,
            this.last_name,
            this.city});
            this.datagridconsumers.DataSource = this.consTableBindingSource;
            this.datagridconsumers.Location = new System.Drawing.Point(473, 13);
            this.datagridconsumers.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.datagridconsumers.Name = "datagridconsumers";
            this.datagridconsumers.ReadOnly = true;
            this.datagridconsumers.RowHeadersWidth = 62;
            this.datagridconsumers.RowTemplate.Height = 28;
            this.datagridconsumers.Size = new System.Drawing.Size(734, 446);
            this.datagridconsumers.TabIndex = 3;
            this.datagridconsumers.DoubleClick += new System.EventHandler(this.datagridconsumers_DoubleClick);
            // 
            // consTableBindingSource
            // 
            this.consTableBindingSource.DataMember = "ConsTable";
            this.consTableBindingSource.DataSource = this.myconsumersDataSet;
            // 
            // myconsumersDataSet
            // 
            this.myconsumersDataSet.DataSetName = "MyconsumersDataSet";
            this.myconsumersDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 81);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 21);
            this.label2.TabIndex = 0;
            this.label2.Text = "Last Name";
            // 
            // txtLastname
            // 
            this.txtLastname.Location = new System.Drawing.Point(140, 74);
            this.txtLastname.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtLastname.Name = "txtLastname";
            this.txtLastname.Size = new System.Drawing.Size(248, 29);
            this.txtLastname.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 139);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 21);
            this.label3.TabIndex = 0;
            this.label3.Text = "City";
            // 
            // txtCity
            // 
            this.txtCity.Location = new System.Drawing.Point(140, 139);
            this.txtCity.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(248, 29);
            this.txtCity.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 189);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 21);
            this.label4.TabIndex = 0;
            this.label4.Text = "Address";
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(140, 189);
            this.txtAddress.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(248, 72);
            this.txtAddress.TabIndex = 1;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(194, 344);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(110, 57);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "DELETE";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(310, 344);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(142, 57);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "CANCEL/RESET";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // consTableTableAdapter
            // 
            this.consTableTableAdapter.ClearBeforeFill = true;
            // 
            // cons_id
            // 
            this.cons_id.DataPropertyName = "cons_id";
            this.cons_id.HeaderText = "cons_id";
            this.cons_id.MinimumWidth = 8;
            this.cons_id.Name = "cons_id";
            this.cons_id.ReadOnly = true;
            this.cons_id.Visible = false;
            this.cons_id.Width = 150;
            // 
            // first_name
            // 
            this.first_name.DataPropertyName = "first_name";
            this.first_name.HeaderText = "first_name";
            this.first_name.MinimumWidth = 8;
            this.first_name.Name = "first_name";
            this.first_name.ReadOnly = true;
            this.first_name.Width = 150;
            // 
            // last_name
            // 
            this.last_name.DataPropertyName = "last_name";
            this.last_name.HeaderText = "last_name";
            this.last_name.MinimumWidth = 8;
            this.last_name.Name = "last_name";
            this.last_name.ReadOnly = true;
            this.last_name.Width = 150;
            // 
            // city
            // 
            this.city.DataPropertyName = "city";
            this.city.HeaderText = "city";
            this.city.MinimumWidth = 8;
            this.city.Name = "city";
            this.city.ReadOnly = true;
            this.city.Width = 150;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(1237, 473);
            this.Controls.Add(this.datagridconsumers);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtLastname);
            this.Controls.Add(this.txtCity);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtFirstname);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI Historic", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "Form1";
            this.Text = "EntityFramework1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.datagridconsumers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.consTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.myconsumersDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtFirstname;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.DataGridView datagridconsumers;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtLastname;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnCancel;
        private MyconsumersDataSet myconsumersDataSet;
        private System.Windows.Forms.BindingSource consTableBindingSource;
        private MyconsumersDataSetTableAdapters.ConsTableTableAdapter consTableTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn cons_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn first_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn last_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn city;
    }
}

