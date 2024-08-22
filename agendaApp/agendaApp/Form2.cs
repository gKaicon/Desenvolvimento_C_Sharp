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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void agendaBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.agendaBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dbAgendaDataSet);

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'dbAgendaDataSet.Agenda'. Você pode movê-la ou removê-la conforme necessário.
            this.agendaTableAdapter.Fill(this.dbAgendaDataSet.Agenda);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.agendaTableAdapter.UpdateQuery(nomeTextBox.Text, cpfTextBox.Text, emailTextBox.Text, telefoneTextBox.Text, Convert.ToInt32(idTextBox.Text));
            MessageBox.Show("Atualização Realizada com Sucesso");
            this.Dispose();
            Form3 f3 = new Form3();
            f3.ShowDialog();
        }
    }
}
