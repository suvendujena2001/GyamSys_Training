namespace EntityFramework
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            lblResult = new Label();
            label2 = new Label();
            txtMinBudget = new TextBox();
            btnSearchCustomers = new Button();
            lblMinBudgetCust = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(185, 162);
            label1.Name = "label1";
            label1.Size = new Size(0, 15);
            label1.TabIndex = 0;
            // 
            // lblResult
            // 
            lblResult.AutoSize = true;
            lblResult.Location = new Point(197, 119);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(0, 15);
            lblResult.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(129, 44);
            label2.Name = "label2";
            label2.Size = new Size(140, 15);
            label2.TabIndex = 2;
            label2.Text = "Enter a Minimum Budget";
            label2.Click += label2_Click;
            // 
            // txtMinBudget
            // 
            txtMinBudget.Location = new Point(296, 36);
            txtMinBudget.Name = "txtMinBudget";
            txtMinBudget.Size = new Size(197, 23);
            txtMinBudget.TabIndex = 3;
            // 
            // btnSearchCustomers
            // 
            btnSearchCustomers.Location = new Point(547, 36);
            btnSearchCustomers.Name = "btnSearchCustomers";
            btnSearchCustomers.Size = new Size(75, 23);
            btnSearchCustomers.TabIndex = 4;
            btnSearchCustomers.Text = "Search";
            btnSearchCustomers.UseVisualStyleBackColor = true;
            // 
            // lblMinBudgetCust
            // 
            lblMinBudgetCust.AutoSize = true;
            lblMinBudgetCust.Location = new Point(135, 80);
            lblMinBudgetCust.Name = "lblMinBudgetCust";
            lblMinBudgetCust.Size = new Size(38, 15);
            lblMinBudgetCust.TabIndex = 5;
            lblMinBudgetCust.Text = "label3";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblMinBudgetCust);
            Controls.Add(btnSearchCustomers);
            Controls.Add(txtMinBudget);
            Controls.Add(label2);
            Controls.Add(lblResult);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label lblResult;
        private Label label2;
        private TextBox txtMinBudget;
        private Button btnSearchCustomers;
        private Label lblMinBudgetCust;
    }
}
