using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
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
        Fusca global;
        int velocidade = 0;
        int marcha = 0;
        bool lig = false;

        private void button1_Click(object sender, EventArgs e)
        {
            global = new Fusca(textPlaca.Text, Convert.ToInt32(textAro.Text), textCor.Text, textcorP.Text, textVidro.Text);
            Ligar.Enabled = true;
            lig = true;
            labelFusca.Text = "Descrição do Fusca: \n\t\tNum de marchas: 4\n\t\tVelocidade Max: 100km/h\n\t\tPlaca:"+ textPlaca.Text + "\n\t\tAro: "+ textAro.Text + "\n\t\tCor: "+ textCor.Text + "\n\t\tCor Parachoque: " + textcorP.Text +"\n\t\tTipo do Vidro:" + textVidro.Text;
        }

        private void Ligar_Click(object sender, EventArgs e)
        {
            maisMarcha.Enabled = true;
            menosMarcha.Enabled = true;
            maisVel.Enabled = true;
            menosVel.Enabled = true;
            if (lig)
            {
                estado.Text = "Ligado";   
            }
            gear.Text = "N";
            vel.Text = velocidade.ToString();
        }

        private void maisVel_Click(object sender, EventArgs e)
        {
            //tentar implementar uma verificação de marcha
            if (marcha != 0)
            {
                velocidade = global.acelarar(velocidade);
                vel.Text = Convert.ToString(velocidade);
            }
            else
            {
                MessageBox.Show("Vamos desenvolver o carro e engatar uma 1ª");
            }
            
        }

        private void menosVel_Click(object sender, EventArgs e)
        {
            velocidade = global.freiar(velocidade);
            vel.Text = Convert.ToString(velocidade);
        }

        private void maisMarcha_Click(object sender, EventArgs e)
        {
            marcha = global.subirMarcha(marcha);
            if (marcha == 0)
            {
                gear.Text = "N";
            }
            else
            {
               gear.Text = Convert.ToString(marcha);
            }
        }

        private void menosMarcha_Click(object sender, EventArgs e)
        {
            
            marcha = global.descerMarcha(marcha);
            if (marcha == -1)
            {
                gear.Text = "R";
            }
            else if (marcha == 0)
            {
                gear.Text = "N";
            }
            else
            {
                gear.Text = Convert.ToString(marcha);
            }
            
        }
    }
}
