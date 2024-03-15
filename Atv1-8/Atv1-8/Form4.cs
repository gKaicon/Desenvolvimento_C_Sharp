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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double b = Convert.ToDouble(textBox1.Text);
            double h = Convert.ToDouble(textBox2.Text);
            MessageBox.Show("Base: " + b + "\nAltura: " + h + "\nArea do retangulo: " + (b * h), "Area do retangulo");
        }
    }
}
