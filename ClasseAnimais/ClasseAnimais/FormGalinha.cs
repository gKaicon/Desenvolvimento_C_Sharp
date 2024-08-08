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
    public partial class FormGalinha : Form
    {
        private Galinha minhaGalinha; // Variável para armazenar a instância da Galinha
        public FormGalinha()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Cria uma nova instância da Galinha com o nome fornecido no TextBox
            string nome = textBox1.Text.Trim();

            if (string.IsNullOrEmpty(nome))
            {
                MessageBox.Show("Por favor, insira um nome para a galinha.");
            }
            else
            {
                minhaGalinha = new Galinha(nome); // Instancia Galinha
                MessageBox.Show("Galinha " + nome + " cadastrada com sucesso!");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Verifica se a instância de Galinha foi criada
            if (minhaGalinha != null)
            {
                minhaGalinha.acao(); // Chama o método acao da Galinha
            }
            else
            {
                MessageBox.Show("Primeiro, cadastre uma galinha.");
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Verifica se a instância de Galinha foi criada
            if (minhaGalinha != null)
            {
                minhaGalinha.falar(); // Chama o método falar da Galinha
            }
            else
            {
                MessageBox.Show("Primeiro, cadastre uma galinha.");
            }
        }
    }
}
