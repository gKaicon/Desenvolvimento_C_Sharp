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
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double k0 = Convert.ToDouble(textBox1.Text);
            double kf = Convert.ToDouble(textBox2.Text);
            double deltakm = kf-k0;
            double custo = deltakm * 0.85;
            label3.Text = "O custo é: " + custo.ToString() + "\ne os km's percorridos são " + deltakm;
            MessageBox.Show("O custo é: " + custo.ToString() + "\ne os km's percorridos são " + deltakm);
        }
    }
}