namespace WinFormsApp
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
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            textBox3 = new TextBox();
            sum = new Label();
            btnclk = new Button();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(334, 104);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(150, 31);
            textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(334, 192);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(150, 31);
            textBox2.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(236, 110);
            label1.Name = "label1";
            label1.Size = new Size(92, 25);
            label1.TabIndex = 2;
            label1.Text = "Number 1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(236, 198);
            label2.Name = "label2";
            label2.Size = new Size(92, 25);
            label2.TabIndex = 3;
            label2.Text = "Number 2";
            label2.Click += label2_Click;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(334, 283);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(150, 31);
            textBox3.TabIndex = 4;
            // 
            // sum
            // 
            sum.AutoSize = true;
            sum.Location = new Point(236, 289);
            sum.Name = "sum";
            sum.Size = new Size(46, 25);
            sum.TabIndex = 5;
            sum.Text = "sum";
            sum.Click += label3_Click;
            // 
            // btnclk
            // 
            btnclk.Location = new Point(387, 342);
            btnclk.Name = "btnclk";
            btnclk.Size = new Size(112, 34);
            btnclk.TabIndex = 6;
            btnclk.Text = "sum";
            btnclk.UseVisualStyleBackColor = true;
            btnclk.Click += btnclk_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources._11821937;
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(800, 450);
            Controls.Add(btnclk);
            Controls.Add(sum);
            Controls.Add(textBox3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private TextBox textBox2;
        private Label label1;
        private Label label2;
        private TextBox textBox3;
        private Label sum;
        private Button btnclk;
    }
}
