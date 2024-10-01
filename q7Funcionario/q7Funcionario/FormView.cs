using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace q7Funcionario
{
    public partial class FormView : Form
    {
        public FormView()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void funcionarioBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.funcionarioBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dB_FuncDataSet);
        }

        private void FormView_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'dB_FuncDataSet.Funcionario'. Você pode movê-la ou removê-la conforme necessário.
            this.funcionarioTableAdapter.Fill(this.dB_FuncDataSet.Funcionario);

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            this.funcionarioTableAdapter.FillByNome(this.dB_FuncDataSet.Funcionario, "%" + textBoxNome.Text + "%");
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            this.funcionarioTableAdapter.DeleteQuery(cPFTextBox.Text);
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            this.funcionarioTableAdapter.UpdateQuery(nomeTextBox.Text, telefoneTextBox.Text, Convert.ToDecimal(salarioTextBox.Text), cPFTextBox.Text);
        }
    }
}
