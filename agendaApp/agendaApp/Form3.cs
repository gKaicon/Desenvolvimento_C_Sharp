using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace agendaApp
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            idTextBox.Text = "";
            nomeTextBox.Text = ""; ;
            cpfTextBox.Text = ""; ;
            emailTextBox.Text = ""; ;
            telefoneTextBox.Text = ""; ;
        }

        private void agendaBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.agendaBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dbAgendaDataSet);

        }

        private void Form3_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'dbAgendaDataSet.Agenda'. Você pode movê-la ou removê-la conforme necessário.
            this.agendaTableAdapter.Fill(this.dbAgendaDataSet.Agenda);

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            this.agendaTableAdapter.FillByNome(this.dbAgendaDataSet.Agenda, "%" + textBox1.Text + "%");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.agendaTableAdapter.UpdateQuery(nomeTextBox.Text, cpfTextBox.Text, emailTextBox.Text, telefoneTextBox.Text, Convert.ToInt32(idTextBox.Text));
            MessageBox.Show("Atualização Realizada com Sucesso");
            agendaDataGridView.Refresh();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Tem certeza que deseja excluir este registro?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                this.agendaTableAdapter.DeleteQuery(Convert.ToInt32(idTextBox.Text));
                agendaDataGridView.Refresh();
            }
        }

        private void agendaDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
