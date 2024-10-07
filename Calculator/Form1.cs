namespace Calculator
{
    public partial class Form1 : Form
    {
        bool AfterDot = false;
        bool OnOperator = false;
        bool ResultShowing = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text += "1";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text += "2";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text += "3";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text += "4";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox1.Text += "5";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            textBox1.Text += "6";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            textBox1.Text += "7";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            textBox1.Text += "8";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            textBox1.Text += "9";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            textBox1.Text += "0";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Calculate the Textbox String
            ResultShowing = true;
        }
        // Devide
        private void button3_Click(object sender, EventArgs e)
        {
            if (OnOperator)
            {
                textBox1.Text = textBox1.Text.Substring(0, textBox1.Text.Count() - 1);
            }
            OnOperator = true;
            textBox1.Text += "÷";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (OnOperator)
            {
                textBox1.Text = textBox1.Text.Substring(0, textBox1.Text.Count() - 1);
            }
            OnOperator = true;
            textBox1.Text += "×";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (OnOperator)
            {
                textBox1.Text = textBox1.Text.Substring(0, textBox1.Text.Count() - 1);
            }
            OnOperator = true;
            textBox1.Text += "-";
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (OnOperator)
            {
                textBox1.Text = textBox1.Text.Substring(0, textBox1.Text.Count() - 1);
            }
            OnOperator = true;
            textBox1.Text += "+";
        }

    }
}
