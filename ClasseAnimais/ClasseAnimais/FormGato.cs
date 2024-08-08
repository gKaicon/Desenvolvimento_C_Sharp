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
    public partial class FormGato : Form
    {
        private Gato meuGato; // Variável para armazenar a instância do Gato
        public FormGato()
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
                MessageBox.Show("Por favor, insira um nome para o gato.");
            }
            else
            {
                meuGato = new Gato(nome); // Instancia Gato
                MessageBox.Show("Gato " + nome + " cadastrado com sucesso!");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (meuGato != null)
            {
                meuGato.acao(); // Chama o método acao do Gato
            }
            else
            {
                MessageBox.Show("Primeiro, cadastre um gato.");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (meuGato != null)
            {
                meuGato.falar(); // Chama o método falar do Gato
            }
            else
            {
                MessageBox.Show("Primeiro, cadastre um gato.");
            }
        }
    }
}
