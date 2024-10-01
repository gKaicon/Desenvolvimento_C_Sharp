using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace q7Funcionario
{
    public partial class FormInsercao : Form
    {
        public FormInsercao()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void buttonInserir_Click(object sender, EventArgs e)
        {
            if (textBoxCPF.Text == "" && textBoxNome.Text == "" && textBoxSalario.Text == "" && textBoxTelefone.Text == "")
            {
                MessageBox.Show("Não é possível fazer a inserção, verifique os campos");
            }
            else
            {
                this.funcionarioTableAdapter.InsertQuery(textBoxCPF.Text, textBoxNome.Text, textBoxTelefone.Text, Convert.ToDecimal(textBoxSalario.Text));
                this.Dispose();
                FormView fv = new FormView();
                fv.ShowDialog();
            }
        }

        private void funcionarioBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.funcionarioBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dB_FuncDataSet);

        }

        private void FormInsercao_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'dB_FuncDataSet.Funcionario'. Você pode movê-la ou removê-la conforme necessário.
            this.funcionarioTableAdapter.Fill(this.dB_FuncDataSet.Funcionario);

        }
    }
}
