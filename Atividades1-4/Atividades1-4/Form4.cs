﻿using System;
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
            ulong numero = Convert.ToUInt64(textBox1.Text);
            if (numero <= 1) MessageBox.Show("Não é primo");
            for (ulong i = 2; i <= numero / 2; i++){
                if (numero % i == 0) MessageBox.Show("Não é primo");
            }
            MessageBox.Show("É primo");
        }
    }
}
