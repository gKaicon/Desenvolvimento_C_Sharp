using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClasseAnimais
{

    public partial class FormCachorro : Form
    {
        private Cachorro meuCachorro; // Variável para armazenar a instância do Cachorro
        public FormCachorro()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Obtém o nome do TextBox
            string nome = textBox1.Text.Trim();

            // Verifica se o nome não está vazio
            if (string.IsNullOrEmpty(nome))
            {
                MessageBox.Show("Por favor, insira um nome para o cachorro.");
            }
            else
            {
                meuCachorro = new Cachorro(nome); // Instancia Cachorro
                MessageBox.Show("Cachorro " + nome + " cadastrado com sucesso!");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (meuCachorro != null)
            {
                meuCachorro.acao(); // Chama o método acao do Cachorro
            }
            else
            {
                MessageBox.Show("Primeiro, cadastre um cachorro.");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (meuCachorro != null)
            {
                meuCachorro.falar(); // Chama o método falar do Cachorro
            }
            else
            {
                MessageBox.Show("Primeiro, cadastre um cachorro.");
            }
        }
    }
}
