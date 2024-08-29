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
            this.agendaTableAdapter.InsertQuery(textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text);
            MessageBox.Show("Inserção feita com sucesso");
            this.Dispose();
        }
    }
}
