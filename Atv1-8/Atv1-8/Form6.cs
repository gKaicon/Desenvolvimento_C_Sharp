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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private double Maior_de_3(double a, double b, double c)
        {
            if (a > b && a > c)
            {
                return a;
            }
            else if (b > a && b > c)
            {
                return b;
            }
            else if (c > a && c > b)
            {
                return c;
            }
            return -1;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            double v1 = Convert.ToDouble(textBox1.Text);
            double v2 = Convert.ToDouble(textBox2.Text);
            double v3 = Convert.ToDouble(textBox3.Text);

            MessageBox.Show("O maior entre " + v1 + ", " + v2 + ", " + v3 + " é " + Maior_de_3(v1,v2,v3), "Maior entre 3");
        }
    }
}
