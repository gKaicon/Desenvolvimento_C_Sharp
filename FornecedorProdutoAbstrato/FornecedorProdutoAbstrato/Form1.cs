namespace Abstrata
{
    public partial class Form1 : Form
    {
        private Computador comp = new Computador();
        private Cliente ultimoCliente; // Armazena o último cliente cadastrado
        private Fornecedor ultimoFornecedor; // Armazena o último fornecedor cadastrado
        public Form1()
        {
            InitializeComponent();
            this.CenterToScreen();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Verifica se o TextBox está preenchido
            if (string.IsNullOrWhiteSpace(textBox1.Text))
            {
                MessageBox.Show("Por favor, preencha o nome do fornecedor.", "Erro");
                return; // Interrompe a execução se o TextBox estiver vazio
            }

            // Cria uma instância da classe Fornecedor e configura o nome
            Fornecedor fornecedor = new Fornecedor
            {
                nome = textBox1.Text
            };

            // Armazena o fornecedor cadastrado
            ultimoFornecedor = fornecedor;

            // Chama o método CadastrarFornecedor passando o fornecedor criado
            comp.CadastrarFornecedor(fornecedor);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Verifica se o TextBox está preenchido
            if (string.IsNullOrWhiteSpace(textBox1.Text))
            {
                MessageBox.Show("Por favor, preencha o nome do cliente.", "Erro");
                return; // Interrompe a execução se o TextBox estiver vazio
            }

            // Cria uma instância da classe Cliente e configura o nome
            Cliente cliente = new Cliente
            {
                nome = textBox1.Text
            };

            // Armazena o cliente cadastrado
            ultimoCliente = cliente;

            // Chama o método CadastrarCliente passando o cliente criado
            comp.CadastrarCliente(cliente);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Exibe uma mensagem com o último nome cadastrado
            if (ultimoCliente != null)
            {
                MessageBox.Show($"Último cliente cadastrado: {ultimoCliente.nome}", "Resposta");
            }
            else if (ultimoFornecedor != null)
            {
                MessageBox.Show($"Último fornecedor cadastrado: {ultimoFornecedor.nome}", "Resposta");
            }
            else
            {
                MessageBox.Show("Nenhum item foi cadastrado.", "Erro");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            // Chama o método RegistrarVenda passando o último cliente cadastrado
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
