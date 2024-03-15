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

        private void button1_Click(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(textBox1.Text);
            double b = Convert.ToDouble(textBox2.Text);
            double c = Convert.ToDouble(textBox3.Text);

            double delta = Math.Pow(b, 2) - (4 * a * c);
            if (delta < 0)
            {
                MessageBox.Show("Não possui solução real!", "Delta < 0");
            }
            else if (delta == 0)
            {
                double res = (-1 * (b)) / (2 * a);
                MessageBox.Show("A solução é " + res, "Delta == 0");
            }
            else if (delta > 0)
            {
                double res1 = (-1 * (b) + Math.Sqrt(delta)) / (2 * a);
                double res2 = (-1 * (b) - Math.Sqrt(delta)) / (2 * a);
                MessageBox.Show("A solução 1 é " + res1.ToString() + "\nA solução 2 é " + res2.ToString(), "Delta > 0");
            }
        }

        private void Form5_Load(object sender, EventArgs e)
        {

        }
    }
}
