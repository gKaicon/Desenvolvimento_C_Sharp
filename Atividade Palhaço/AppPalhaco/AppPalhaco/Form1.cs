namespace AppPalhaco
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
        private bool verificaCampos()
        {
            if(textBox1.Text == "" &&
            textBox2.Text == "" &&
            textBox3.Text == "" &&
            textBox4.Text == "" &&
            textBox5.Text == "" &&
            textBox6.Text == "" &&
            textBox7.Text == "")
            {
                return false;
            }
            return true;
        }

        private bool validaCampos()
        {
            if (textBox1.Text.Length < 2 || textBox3.Text.Length < 2)
            {
                MessageBox.Show("Endereço ou nome nulos");
                return false;
            }
            double h = Convert.ToDouble(textBox2.Text);
            if (h > 1 || h > 3)
            {
                MessageBox.Show("Altura Inválida");
                return false;
            }
            return true;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (verificaCampos() && validaCampos())
            {
                Palhaco palhaco1 = new Palhaco();
                palhaco1.Nome = textBox1.Text;
                palhaco1.Altura = Convert.ToDouble(textBox2.Text);
                palhaco1.Endereco = textBox3.Text;
                palhaco1.Telefone = textBox4.Text;
                palhaco1.Email = textBox5.Text;
                palhaco1.Cpf = textBox6.Text;
                palhaco1.Identidade = textBox7.Text;
                palhaco1.FalarSobreVoce();
            }
            else
            {
                MessageBox.Show("Preencha todos os campos adequadamente");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            textBox7.Text = "";
        }
    }
}