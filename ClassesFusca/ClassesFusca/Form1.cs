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

namespace ClassesFusca
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Ligar.Enabled = false;
            maisMarcha.Enabled = false; ;
            menosMarcha.Enabled = false; ;
            maisVel.Enabled = false; ;
            menosVel.Enabled = false;
        }

        int velocidade = 0;
        int marcha = 0;
        bool lig = false;

        private void button1_Click(object sender, EventArgs e)
        {
            Fusca f = new Fusca(textPlaca.Text, Convert.ToInt32(textAro.Text), textCor.Text, textcorP.Text);
            Ligar.Enabled = true;
            
        }

        private void Ligar_Click(object sender, EventArgs e)
        {
            maisMarcha.Enabled = true;
            menosMarcha.Enabled = true;
            maisVel.Enabled = true;
            menosVel.Enabled = true;
            if (lig)
            {
                Estado.Text = "Ligado";   
            }
        //E: \Usuários\0048609\source\repos\ClassesFusca\ClassesFusca\Form1.cs
        }
    }
}
