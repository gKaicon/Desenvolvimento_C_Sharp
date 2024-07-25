using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pessoa
{
    public partial class Form1 : Form
    {

        List<Produto> listProd;
        Pessoa p = new Pessoa();
        public Form1()
        {
            InitializeComponent();
            textNome.Enabled = false;
            textIdade.Enabled = false;
            textCPF.Enabled = false;
            btnSalvar.Enabled = false;
            listProd = CriarProdutosIniciais();
        }
        private List<Produto> CriarProdutosIniciais()
        {
            List<Produto> produtos = new List<Produto>();
            produtos.Add(new Produto(2.50, "Água mineral 500ml", 101, 100));
            produtos.Add(new Produto(3.00, "Refrigerante lata 350ml", 102, 50));
            produtos.Add(new Produto(4.50, "Cerveja lata 350ml", 103, 30));
            produtos.Add(new Produto(5.00, "Salgadinho pacote 40g", 104, 75));
            produtos.Add(new Produto(1.00, "Pão de forma", 105, 20));
            produtos.Add(new Produto(0.50, "Ovo unidade", 106, 100));
            produtos.Add(new Produto(2.00, "Macarrão pacote 500g", 107, 25));
            produtos.Add(new Produto(3.50, "Arroz pacote 1kg", 108, 15));
            produtos.Add(new Produto(4.00, "Feijão pacote 1kg", 109, 10));
            produtos.Add(new Produto(3.00, "Café pacote 250g", 113, 15));
            return produtos;
        }
        private void btnCadastro_Click(object sender, EventArgs e)
        {
            textNome.Enabled = true;
            textIdade.Enabled = true;
            textCPF.Enabled = true;
            btnSalvar.Enabled = true;
            Produto pr = new Produto();
            label4.Text = pr.listaProdutos(listProd);
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            
            p.Nome = textNome.Text;
            p.Idade = Convert.ToInt32(textIdade.Text);
            p.CPF1 = textCPF.Text;
            MessageBox.Show("Dados do cadastrado\n" + p.ToString());
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            p.viajar();
        }
    }
}
