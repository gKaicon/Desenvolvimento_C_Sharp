using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace Atividades1_4
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ulong n = Convert.ToUInt64(textBox1.Text);
            ulong i = 1, contDiv = 0;
            while (i <= n)
            {
                if (n % i == 0)
                {
                    contDiv++;
                    if (i < n && cont == 3)
                    {
                        MessageBox.Show("Não é primo.");
                        break;
                    }
                    else
                    {
                        
                    }
                    
                }
                if (i == n && cont == 2) {
                    MessageBox.Show("É primo.");
                }
            }
        }
    }
}
