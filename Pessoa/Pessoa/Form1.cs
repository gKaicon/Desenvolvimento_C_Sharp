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
        public Form1()
        {
            InitializeComponent();
            textNome.Enabled = false;
            textIdade.Enabled = false;
            textCPF.Enabled = false;
            btnSalvar.Enabled = false;
        }

        private void btnCadastro_Click(object sender, EventArgs e)
        {
            textNome.Enabled = true;
            textIdade.Enabled = true;
            textCPF.Enabled = true;
            btnSalvar.Enabled = true;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Pessoa p = new Pessoa();
            p.Nome = textNome.Text;
            p.Idade = Convert.ToInt32(textIdade.Text);
            p.CPF1 = textCPF.Text;
            MessageBox.Show("Dados do cadastrado\n" + p.ToString());
        }
    }
}
