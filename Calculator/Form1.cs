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
        private void button6_Click(object sender, EventArgs e)
        {
            if (ResultShowing)
            {
                ResultShowing = false;
                textBox1.Text = "";
            }
            textBox1.Text += "1";
            OnOperator = false;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (ResultShowing)
            {
                ResultShowing = false;
                textBox1.Text = "";
            }
            textBox1.Text += "2";
            OnOperator = false;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (ResultShowing)
            {
                ResultShowing = false;
                textBox1.Text = "";
            }
            textBox1.Text += "3";
            OnOperator = false;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (ResultShowing)
            {
                ResultShowing = false;
                textBox1.Text = "";
            }
            textBox1.Text += "4";
            OnOperator = false;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (ResultShowing)
            {
                ResultShowing = false;
                textBox1.Text = "";
            }
            textBox1.Text += "5";
            OnOperator = false;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (ResultShowing)
            {
                ResultShowing = false;
                textBox1.Text = "";
            }
            textBox1.Text += "6";
            OnOperator = false;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (ResultShowing)
            {
                ResultShowing = false;
                textBox1.Text = "";
            }
            textBox1.Text += "7";
            OnOperator = false;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (ResultShowing)
            {
                ResultShowing = false;
                textBox1.Text = "";
            }
            textBox1.Text += "8";
            OnOperator = false;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            if (ResultShowing)
            {
                ResultShowing = false;
                textBox1.Text = "";
            }
            textBox1.Text += "9";
            OnOperator = false;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            if (ResultShowing)
            {
                ResultShowing = false;
                textBox1.Text = "";
            }
            textBox1.Text += "0";
            OnOperator = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Calculate the Textbox String
            if (!ResultShowing)
            {
                ResultShowing = true;
                OnOperator = false;
                AfterDot = false;

                textBox1.Text = "Result";
            }
        }
        // Devide
        private void button3_Click(object sender, EventArgs e)
        {
            if (OnOperator)
            {
                textBox1.Text = textBox1.Text.Substring(0, textBox1.Text.Count() - 1);
            }
            if (textBox1.Text.Count() > 0 && !ResultShowing)
            {
                OnOperator = true;
                AfterDot = false;
                textBox1.Text += "÷";
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (OnOperator)
            {
                textBox1.Text = textBox1.Text.Substring(0, textBox1.Text.Count() - 1);
            }
            if (textBox1.Text.Count() > 0 && !ResultShowing)
            {
                OnOperator = true;
                AfterDot = false;
                textBox1.Text += "×";
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (OnOperator)
            {
                textBox1.Text = textBox1.Text.Substring(0, textBox1.Text.Count() - 1);
            }
            if (textBox1.Text.Count() > 0 && !ResultShowing)
            {
                OnOperator = true;
                AfterDot = false;
                textBox1.Text += "-";
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (OnOperator)
            {
                textBox1.Text = textBox1.Text.Substring(0, textBox1.Text.Count() - 1);
            }
            if (textBox1.Text.Count() > 0 && !ResultShowing)
            {
                OnOperator = true;
                AfterDot = false;
                textBox1.Text += "+";
            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            if (!AfterDot)
            {
                AfterDot = true;
                textBox1.Text += ".";
            }
        }
    }
}
