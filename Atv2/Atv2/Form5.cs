using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Atv2
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(textBox1.Text);
            double b = Convert.ToDouble(textBox1.Text);
            double c = Convert.ToDouble(textBox1.Text);

            double delta = Math.Sqrt((b*b) - (4 * a * c));

            if(delta < 0)
            {
                MessageBox.Show("Não possui solução real!");
            }
            else if(delta == 0)
            {
                double res = (-b) / 2 * a;
                MessageBox.Show("A solução é " + res);
            }
            else
            {
                double res1 = (-b + delta) / (2 * a);
                double res2 = (-b - delta) / (2 * a);
                MessageBox.Show("A solução 1 é " + res1 + "\nA solução 2 é " + res2);
            }
        }
    }
}
