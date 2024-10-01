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
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void buttonInsert_Click(object sender, EventArgs e)
        {
            FormInsercao fi = new FormInsercao();
            fi.ShowDialog();
        }

        private void buttonView_Click(object sender, EventArgs e)
        {
            FormView view = new FormView(); 
            view.ShowDialog();
        }
    }
}
