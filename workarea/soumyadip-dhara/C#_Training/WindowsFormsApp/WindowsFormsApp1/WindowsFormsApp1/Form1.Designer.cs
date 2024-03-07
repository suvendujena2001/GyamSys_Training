namespace WindowsFormsApp1
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
            this.btnbutton1 = new System.Windows.Forms.Button();
            this.lblinput1 = new System.Windows.Forms.Label();
            this.txtbox1 = new System.Windows.Forms.TextBox();
            this.lblinput2 = new System.Windows.Forms.Label();
            this.txtBox2 = new System.Windows.Forms.TextBox();
            this.lblresult = new System.Windows.Forms.Label();
            this.lblsum = new System.Windows.Forms.Label();
            this.btnmult = new System.Windows.Forms.Button();
            this.lblmult = new System.Windows.Forms.Label();
            this.lblmultcomment = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnbutton1
            // 
            this.btnbutton1.Location = new System.Drawing.Point(381, 189);
            this.btnbutton1.Name = "btnbutton1";
            this.btnbutton1.Size = new System.Drawing.Size(75, 30);
            this.btnbutton1.TabIndex = 0;
            this.btnbutton1.Text = "sum";
            this.btnbutton1.UseVisualStyleBackColor = true;
            this.btnbutton1.Click += new System.EventHandler(this.btnbutton1_Click_1);
            // 
            // lblinput1
            // 
            this.lblinput1.AutoSize = true;
            this.lblinput1.Location = new System.Drawing.Point(330, 98);
            this.lblinput1.Name = "lblinput1";
            this.lblinput1.Size = new System.Drawing.Size(53, 20);
            this.lblinput1.TabIndex = 1;
            this.lblinput1.Text = "input1";
            // 
            // txtbox1
            // 
            this.txtbox1.Location = new System.Drawing.Point(420, 98);
            this.txtbox1.Name = "txtbox1";
            this.txtbox1.Size = new System.Drawing.Size(100, 26);
            this.txtbox1.TabIndex = 2;
            this.txtbox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtbox1_KeyDown);
            // 
            // lblinput2
            // 
            this.lblinput2.AutoSize = true;
            this.lblinput2.Location = new System.Drawing.Point(330, 140);
            this.lblinput2.Name = "lblinput2";
            this.lblinput2.Size = new System.Drawing.Size(53, 20);
            this.lblinput2.TabIndex = 3;
            this.lblinput2.Text = "input2";
            // 
            // txtBox2
            // 
            this.txtBox2.Location = new System.Drawing.Point(420, 140);
            this.txtBox2.Name = "txtBox2";
            this.txtBox2.Size = new System.Drawing.Size(100, 26);
            this.txtBox2.TabIndex = 4;
            this.txtBox2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtBox2_KeyDown);
            // 
            // lblresult
            // 
            this.lblresult.AutoSize = true;
            this.lblresult.Location = new System.Drawing.Point(489, 235);
            this.lblresult.Name = "lblresult";
            this.lblresult.Size = new System.Drawing.Size(0, 20);
            this.lblresult.TabIndex = 5;
            // 
            // lblsum
            // 
            this.lblsum.AutoSize = true;
            this.lblsum.Location = new System.Drawing.Point(441, 235);
            this.lblsum.Name = "lblsum";
            this.lblsum.Size = new System.Drawing.Size(0, 20);
            this.lblsum.TabIndex = 6;
            // 
            // btnmult
            // 
            this.btnmult.Location = new System.Drawing.Point(330, 258);
            this.btnmult.Name = "btnmult";
            this.btnmult.Size = new System.Drawing.Size(126, 37);
            this.btnmult.TabIndex = 7;
            this.btnmult.Text = "multiplication";
            this.btnmult.UseVisualStyleBackColor = true;
            this.btnmult.Click += new System.EventHandler(this.btnmult_Click);
            // 
            // lblmult
            // 
            this.lblmult.AutoSize = true;
            this.lblmult.Location = new System.Drawing.Point(492, 312);
            this.lblmult.Name = "lblmult";
            this.lblmult.Size = new System.Drawing.Size(42, 20);
            this.lblmult.TabIndex = 8;
            
            // 
            // lblmultcomment
            // 
            this.lblmultcomment.AutoSize = true;
            this.lblmultcomment.Location = new System.Drawing.Point(330, 312);
            this.lblmultcomment.Name = "lblmultcomment";
            this.lblmultcomment.Size = new System.Drawing.Size(152, 20);
            this.lblmultcomment.TabIndex = 9;
            
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1064, 450);
            this.Controls.Add(this.lblmultcomment);
            this.Controls.Add(this.lblmult);
            this.Controls.Add(this.btnmult);
            this.Controls.Add(this.lblsum);
            this.Controls.Add(this.lblresult);
            this.Controls.Add(this.txtBox2);
            this.Controls.Add(this.lblinput2);
            this.Controls.Add(this.txtbox1);
            this.Controls.Add(this.lblinput1);
            this.Controls.Add(this.btnbutton1);
            this.Name = "Form1";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "App1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnbutton1;
        private System.Windows.Forms.Label lblinput1;
        private System.Windows.Forms.TextBox txtbox1;
        private System.Windows.Forms.Label lblinput2;
        private System.Windows.Forms.TextBox txtBox2;
        private System.Windows.Forms.Label lblresult;
        private System.Windows.Forms.Label lblsum;
        private System.Windows.Forms.Button btnmult;
        private System.Windows.Forms.Label lblmult;
        private System.Windows.Forms.Label lblmultcomment;
    }
}

