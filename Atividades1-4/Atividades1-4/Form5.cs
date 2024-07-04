using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Atividades1_4
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ulong numero = Convert.ToUInt64(textBox1.Text);
            if (numero <= 1) MessageBox.Show("Não é primo");
            if (numero <= 3) MessageBox.Show("É primo");
            if (numero % 2 == 0 || numero % 3 == 0) MessageBox.Show("Não é primo");
            ulong i = 5;
            while (i * i <= numero)
            {
                if (numero % i == 0 || numero % (i + 2) == 0) MessageBox.Show("Não é primo");
                i += 6;
            }
            MessageBox.Show("É primo");
        }
    }
}
