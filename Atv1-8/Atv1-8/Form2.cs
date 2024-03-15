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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double v1 = Convert.ToDouble(textBox1.Text);
            double v2 = Convert.ToDouble(textBox2.Text);
            double v3 = Convert.ToDouble(textBox4.Text);
            double res = (v1 + v2) * v3;
            textBox3.Text = res.ToString();
        }
    }
}
