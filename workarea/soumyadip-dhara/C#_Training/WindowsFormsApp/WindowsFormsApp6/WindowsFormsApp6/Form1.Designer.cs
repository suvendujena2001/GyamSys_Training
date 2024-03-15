namespace WindowsFormsApp6
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSalary = new System.Windows.Forms.TextBox();
            this.txtBonus = new System.Windows.Forms.TextBox();
            this.txtDeptId = new System.Windows.Forms.TextBox();
            this.txtManagerId = new System.Windows.Forms.TextBox();
            this.txtJob = new System.Windows.Forms.TextBox();
            this.txtEmpName = new System.Windows.Forms.TextBox();
            this.txtEmpId = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt17 = new System.Windows.Forms.Label();
            this.txt16 = new System.Windows.Forms.Label();
            this.txt15 = new System.Windows.Forms.Label();
            this.txt14 = new System.Windows.Forms.Label();
            this.txt13 = new System.Windows.Forms.Label();
            this.txt12 = new System.Windows.Forms.Label();
            this.txt11 = new System.Windows.Forms.Label();
            this.txt10 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.YellowGreen;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 66);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(1253, 272);
            this.dataGridView1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Blue;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(368, 25);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(97, 35);
            this.button1.TabIndex = 1;
            this.button1.Text = "Display";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Red;
            this.button2.Location = new System.Drawing.Point(1153, 364);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(109, 47);
            this.button2.TabIndex = 2;
            this.button2.Text = "Clear";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.Green;
            this.btnSave.Location = new System.Drawing.Point(1006, 656);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(130, 47);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "SaveOrAdd";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.Red;
            this.btnClear.Location = new System.Drawing.Point(1006, 725);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(130, 43);
            this.btnClear.TabIndex = 4;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.Yellow;
            this.textBox1.Location = new System.Drawing.Point(1016, 373);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(131, 26);
            this.textBox1.TabIndex = 7;
            this.textBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyDown);
            // 
            // dataGridView2
            // 
            this.dataGridView2.BackgroundColor = System.Drawing.Color.SkyBlue;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(12, 440);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 62;
            this.dataGridView2.RowTemplate.Height = 28;
            this.dataGridView2.Size = new System.Drawing.Size(1267, 108);
            this.dataGridView2.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(839, 377);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = "Enter the Employee Id:";
            // 
            // txtSalary
            // 
            this.txtSalary.BackColor = System.Drawing.Color.Yellow;
            this.txtSalary.Location = new System.Drawing.Point(688, 662);
            this.txtSalary.Name = "txtSalary";
            this.txtSalary.Size = new System.Drawing.Size(131, 26);
            this.txtSalary.TabIndex = 10;
            // 
            // txtBonus
            // 
            this.txtBonus.BackColor = System.Drawing.Color.Yellow;
            this.txtBonus.Location = new System.Drawing.Point(688, 722);
            this.txtBonus.Name = "txtBonus";
            this.txtBonus.Size = new System.Drawing.Size(131, 26);
            this.txtBonus.TabIndex = 12;
            // 
            // txtDeptId
            // 
            this.txtDeptId.BackColor = System.Drawing.Color.Yellow;
            this.txtDeptId.Location = new System.Drawing.Point(688, 773);
            this.txtDeptId.Name = "txtDeptId";
            this.txtDeptId.Size = new System.Drawing.Size(131, 26);
            this.txtDeptId.TabIndex = 13;
            // 
            // txtManagerId
            // 
            this.txtManagerId.BackColor = System.Drawing.Color.Yellow;
            this.txtManagerId.Location = new System.Drawing.Point(258, 773);
            this.txtManagerId.Name = "txtManagerId";
            this.txtManagerId.Size = new System.Drawing.Size(131, 26);
            this.txtManagerId.TabIndex = 14;
            // 
            // txtJob
            // 
            this.txtJob.BackColor = System.Drawing.Color.Yellow;
            this.txtJob.Location = new System.Drawing.Point(258, 718);
            this.txtJob.Name = "txtJob";
            this.txtJob.Size = new System.Drawing.Size(131, 26);
            this.txtJob.TabIndex = 15;
            // 
            // txtEmpName
            // 
            this.txtEmpName.BackColor = System.Drawing.Color.Yellow;
            this.txtEmpName.Location = new System.Drawing.Point(258, 662);
            this.txtEmpName.Name = "txtEmpName";
            this.txtEmpName.Size = new System.Drawing.Size(131, 26);
            this.txtEmpName.TabIndex = 16;
            // 
            // txtEmpId
            // 
            this.txtEmpId.BackColor = System.Drawing.Color.Yellow;
            this.txtEmpId.Location = new System.Drawing.Point(258, 620);
            this.txtEmpId.Name = "txtEmpId";
            this.txtEmpId.Size = new System.Drawing.Size(131, 26);
            this.txtEmpId.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(347, 573);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(204, 20);
            this.label2.TabIndex = 18;
            this.label2.Text = "Add New Employee Details:";
            // 
            // txt17
            // 
            this.txt17.AutoSize = true;
            this.txt17.ForeColor = System.Drawing.Color.Black;
            this.txt17.Location = new System.Drawing.Point(543, 776);
            this.txt17.Name = "txt17";
            this.txt17.Size = new System.Drawing.Size(116, 20);
            this.txt17.TabIndex = 19;
            this.txt17.Text = "Department Id:";
            // 
            // txt16
            // 
            this.txt16.AutoSize = true;
            this.txt16.ForeColor = System.Drawing.Color.Black;
            this.txt16.Location = new System.Drawing.Point(571, 727);
            this.txt16.Name = "txt16";
            this.txt16.Size = new System.Drawing.Size(59, 20);
            this.txt16.TabIndex = 20;
            this.txt16.Text = "Bonus:";
            // 
            // txt15
            // 
            this.txt15.AutoSize = true;
            this.txt15.ForeColor = System.Drawing.Color.Black;
            this.txt15.Location = new System.Drawing.Point(575, 665);
            this.txt15.Name = "txt15";
            this.txt15.Size = new System.Drawing.Size(57, 20);
            this.txt15.TabIndex = 21;
            this.txt15.Text = "Salary:";
            // 
            // txt14
            // 
            this.txt14.AutoSize = true;
            this.txt14.ForeColor = System.Drawing.Color.Black;
            this.txt14.Location = new System.Drawing.Point(543, 623);
            this.txt14.Name = "txt14";
            this.txt14.Size = new System.Drawing.Size(102, 20);
            this.txt14.TabIndex = 22;
            this.txt14.Text = "Joining Date:";
            // 
            // txt13
            // 
            this.txt13.AutoSize = true;
            this.txt13.ForeColor = System.Drawing.Color.Black;
            this.txt13.Location = new System.Drawing.Point(122, 776);
            this.txt13.Name = "txt13";
            this.txt13.Size = new System.Drawing.Size(94, 20);
            this.txt13.TabIndex = 23;
            this.txt13.Text = "Manager Id:";
            // 
            // txt12
            // 
            this.txt12.AutoSize = true;
            this.txt12.ForeColor = System.Drawing.Color.Black;
            this.txt12.Location = new System.Drawing.Point(133, 722);
            this.txt12.Name = "txt12";
            this.txt12.Size = new System.Drawing.Size(76, 20);
            this.txt12.TabIndex = 24;
            this.txt12.Text = "Job Role:";
            // 
            // txt11
            // 
            this.txt11.AutoSize = true;
            this.txt11.ForeColor = System.Drawing.Color.Black;
            this.txt11.Location = new System.Drawing.Point(112, 668);
            this.txt11.Name = "txt11";
            this.txt11.Size = new System.Drawing.Size(129, 20);
            this.txt11.TabIndex = 25;
            this.txt11.Text = "Employee Name:";
            // 
            // txt10
            // 
            this.txt10.AutoSize = true;
            this.txt10.ForeColor = System.Drawing.Color.Black;
            this.txt10.Location = new System.Drawing.Point(145, 623);
            this.txt10.Name = "txt10";
            this.txt10.Size = new System.Drawing.Size(101, 20);
            this.txt10.TabIndex = 26;
            this.txt10.Text = "Employee Id:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(661, 618);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 26);
            this.dateTimePicker1.TabIndex = 27;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(85, 390);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(305, 20);
            this.label3.TabIndex = 28;
            this.label3.Text = "Search Employee Details By Employee Id:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(33, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(243, 20);
            this.label4.TabIndex = 29;
            this.label4.Text = "Display All The Employee Details:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1322, 986);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.txt10);
            this.Controls.Add(this.txt11);
            this.Controls.Add(this.txt12);
            this.Controls.Add(this.txt13);
            this.Controls.Add(this.txt14);
            this.Controls.Add(this.txt15);
            this.Controls.Add(this.txt16);
            this.Controls.Add(this.txt17);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtEmpId);
            this.Controls.Add(this.txtEmpName);
            this.Controls.Add(this.txtJob);
            this.Controls.Add(this.txtManagerId);
            this.Controls.Add(this.txtDeptId);
            this.Controls.Add(this.txtBonus);
            this.Controls.Add(this.txtSalary);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSalary;
        private System.Windows.Forms.TextBox txtBonus;
        private System.Windows.Forms.TextBox txtDeptId;
        private System.Windows.Forms.TextBox txtManagerId;
        private System.Windows.Forms.TextBox txtJob;
        private System.Windows.Forms.TextBox txtEmpName;
        private System.Windows.Forms.TextBox txtEmpId;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label txt17;
        private System.Windows.Forms.Label txt16;
        private System.Windows.Forms.Label txt15;
        private System.Windows.Forms.Label txt14;
        private System.Windows.Forms.Label txt13;
        private System.Windows.Forms.Label txt12;
        private System.Windows.Forms.Label txt11;
        private System.Windows.Forms.Label txt10;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

