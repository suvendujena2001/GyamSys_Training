namespace MY_CALCULATOR
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "")
            {
                int num1 = int.Parse(textBox1.Text);
                int num2 = int.Parse(textBox2.Text);
                int result = num1+num2;
                //MessageBox.Show(result.ToString());
                label4.Text ="ADDITION RESULT IS" + result.ToString();
                label4.Visible = true;
            }
            else
            {
                MessageBox.Show("Please Enter Number");
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "")
            {
                int num1 = int.Parse(textBox1.Text);
                int num2 = int.Parse(textBox2.Text);
                int result = num1-num2;
                //MessageBox.Show(result.ToString());
                label4.Text ="SUBTRACTION RESULT IS" + result.ToString();
                label4.Visible = true;
            }
            else
            {
                MessageBox.Show("Please Enter Number");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "")
            {
                int num1 = int.Parse(textBox1.Text);
                int num2 = int.Parse(textBox2.Text);
                int result = num1*num2;
                //MessageBox.Show(result.ToString());
                label4.Text ="MULTIPLICATION RESULT IS" + result.ToString();
                label4.Visible = true;
            }
            else
            {
                MessageBox.Show("Please Enter Number");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "")
            {
                int num1 = int.Parse(textBox1.Text);
                int num2 = int.Parse(textBox2.Text);
                int result = num1/num2;
                //MessageBox.Show(result.ToString());
                label4.Text ="DIVISION RESULT IS" + result.ToString();
                label4.Visible = true;
            }
            else
            {
                MessageBox.Show("Please Enter Number");
            }
        }
    }
}
