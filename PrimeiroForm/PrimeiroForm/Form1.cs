using System.Security.Permissions;

namespace PrimeiroForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double soma = Convert.ToDouble(textBox1.Text) + Convert.ToDouble(textBox2.Text) + Convert.ToDouble(textBox3.Text);
            double media = (soma /= 3);
            MessageBox.Show("A média é " + media.ToString("N2"), "Resultado");
            label5.Text = "A média é " + media.ToString("N2");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            label5.Text = " ";
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
