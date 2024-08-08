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
    public partial class FormMamifero : Form
    {
        public FormMamifero()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            // Verifica se há um item selecionado no ComboBox
            if (comboBox1.SelectedItem != null)
            {
                // Obtém o valor selecionado do ComboBox
                string selecionado = comboBox1.SelectedItem.ToString();

                // Verifica se o item selecionado é "Cachorro" ou "Gato" e abre o formulário correspondente
                if (selecionado == "Cachorro")
                {
                    // Cria e mostra o formulário FormCachorro
                    FormCachorro formCachorro = new FormCachorro();
                    formCachorro.ShowDialog();
                }
                else if (selecionado == "Gato")
                {
                    // Cria e mostra o formulário FormGato
                    FormGato formGato = new FormGato();
                    formGato.ShowDialog();
                }
                else
                {
                    // Exibe uma mensagem se a seleção não for válida
                    MessageBox.Show("Selecione um tipo de mamífero válido.");
                }
            }
            else
            {
                // Exibe uma mensagem se nenhum item estiver selecionado
                MessageBox.Show("Nenhum tipo de mamífero selecionado.");
            }
        }
    }
}
