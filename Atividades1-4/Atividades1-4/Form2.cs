using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Atividades1_4
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private string fibonacci(ulong num)
        {
            ulong i1 = 0, i2 = 1, aux, i = 0;
            string vet = "";
            while (i < num)
            {
                i++;
                vet = vet + (i1.ToString() + ", ");
                aux = i1;
                i1 = i1 + i2;
                i2 = aux;
            }
            return vet;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            ulong num = Convert.ToUInt64(textBoxValor.Text);
            MessageBox.Show("Sequencia dos " + num + "elementos: " + fibonacci(num));
        }
    }
}
