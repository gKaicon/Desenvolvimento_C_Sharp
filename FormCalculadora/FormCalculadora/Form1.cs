namespace FormCalculadora
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double v1 = Convert.ToDouble(textBox1.Text);
            double v2 = Convert.ToDouble(textBox2.Text);
            MessageBox.Show("A multiplicação de " + v1 + " e " + v2 + " é " + (v1 * v2));
            textBox1.Clear();
            textBox2.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double v1 = Convert.ToDouble(textBox1.Text);
            double v2 = Convert.ToDouble(textBox2.Text);
            MessageBox.Show("A soma de " + v1 + " e " + v2 + " é " + (v1 + v2));
        }

        private void button3_Click(object sender, EventArgs e)
        {
            double v1 = Convert.ToDouble(textBox1.Text);
            double v2 = Convert.ToDouble(textBox2.Text);
            MessageBox.Show("A subtração de " + v1 + " e " + v2 + " é " + (v1 - v2));
            textBox1.Clear();
            textBox2.Clear();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            double v1 = Convert.ToDouble(textBox1.Text);
            double v2 = Convert.ToDouble(textBox2.Text);
            if (v1 != 0 && v2 != 0)
            {
                MessageBox.Show("A Divisão de " + v1 + " e " + v2 + " é " + (v1 / v2) + "\nA Divisão de " + v2 + " e " + v1 + " é " + (v2 / v1));
                textBox1.Clear();
                textBox2.Clear();
            }
            else
            {
                MessageBox.Show("Digite valores não nulos");
                textBox1.Text = v1.ToString();
                textBox2.Text = v2.ToString();
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox2.Text != "" && textBox1.Text != "")
            {
                button1.Enabled = true;
                button2.Enabled = true;
                button3.Enabled = true;
                button4.Enabled = true;
            }
            else
            {
                button1.Enabled = false;
                button2.Enabled = false;
                button3.Enabled = false;
                button4.Enabled = false;
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (textBox2.Text != ""  && textBox1.Text != "")
            {
                button1.Enabled = true;
                button2.Enabled = true;
                button3.Enabled = true;
                button4.Enabled = true;
            }
            else
            {
                button1.Enabled = false;
                button2.Enabled = false;
                button3.Enabled = false;
                button4.Enabled = false;
            }
        }
    }
}
