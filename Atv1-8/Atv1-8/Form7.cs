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
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double r = Convert.ToDouble(textBox1.Text);
            double area;
            area = Math.PI * r * r;
            MessageBox.Show("A area da circunferencia é " + area + " U.A.", "Area da circunferência");
        }
    }
}
