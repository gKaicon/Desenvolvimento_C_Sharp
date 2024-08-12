namespace Abstrata
{
    public partial class Form1 : Form
    {
        private Computador comp = new Computador();
        private Cliente ultimoCliente; // Armazena o �ltimo cliente cadastrado
        private Fornecedor ultimoFornecedor; // Armazena o �ltimo fornecedor cadastrado
        public Form1()
        {
            InitializeComponent();
            this.CenterToScreen();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Verifica se o TextBox est� preenchido
            if (string.IsNullOrWhiteSpace(textBox1.Text))
            {
                MessageBox.Show("Por favor, preencha o nome do fornecedor.", "Erro");
                return; // Interrompe a execu��o se o TextBox estiver vazio
            }

            // Cria uma inst�ncia da classe Fornecedor e configura o nome
            Fornecedor fornecedor = new Fornecedor
            {
                nome = textBox1.Text
            };

            // Armazena o fornecedor cadastrado
            ultimoFornecedor = fornecedor;

            // Chama o m�todo CadastrarFornecedor passando o fornecedor criado
            comp.CadastrarFornecedor(fornecedor);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Verifica se o TextBox est� preenchido
            if (string.IsNullOrWhiteSpace(textBox1.Text))
            {
                MessageBox.Show("Por favor, preencha o nome do cliente.", "Erro");
                return; // Interrompe a execu��o se o TextBox estiver vazio
            }

            // Cria uma inst�ncia da classe Cliente e configura o nome
            Cliente cliente = new Cliente
            {
                nome = textBox1.Text
            };

            // Armazena o cliente cadastrado
            ultimoCliente = cliente;

            // Chama o m�todo CadastrarCliente passando o cliente criado
            comp.CadastrarCliente(cliente);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Exibe uma mensagem com o �ltimo nome cadastrado
            if (ultimoCliente != null)
            {
                MessageBox.Show($"�ltimo cliente cadastrado: {ultimoCliente.nome}", "Resposta");
            }
            else if (ultimoFornecedor != null)
            {
                MessageBox.Show($"�ltimo fornecedor cadastrado: {ultimoFornecedor.nome}", "Resposta");
            }
            else
            {
                MessageBox.Show("Nenhum item foi cadastrado.", "Erro");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            // Chama o m�todo RegistrarVenda passando o �ltimo cliente cadastrado
            if (ultimoCliente != null)
            {
                comp.RegistrarVenda(ultimoCliente);
            }
            else
            {
                MessageBox.Show("Nenhum cliente foi cadastrado para realizar a venda.", "Erro");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
