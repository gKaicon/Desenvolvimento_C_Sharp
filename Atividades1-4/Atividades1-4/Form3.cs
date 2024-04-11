using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Atividades1_4
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String palavra = textBox1.Text;
            palavra = Regex.Replace(palavra, @"\s", "");
            string palavraInversa = "";
            //forma "ineficiente"
            for (int i = palavra.Length - 1; i >= 0; i--)
                palavraInversa += palavra[i];
            if (palavra == palavraInversa)
                MessageBox.Show("A palavra " + palavra + " é um palíndromo, pois seu invevrso é " + palavraInversa);
            else
                MessageBox.Show("A palavra " + palavra + " não é um palíndromo, pois seu invevrso é " + palavraInversa);
            /*//forma eficiente
            bool isPalindromo = false;
            for (int i = 0; i < (palavra.Length) /2; i++)
            {
                if(palavra[i] == palavra[palavra.Length - 1])
                {
                    isPalindromo = true;
                }
                else
                {
                    isPalindromo = false;
                    break;
                }
            }
            if (!isPalindromo)
                MessageBox.Show("A palavra " + palavra + " não é um palíndromo, pois seu invevrso é " + palavraInversa);
            if (isPalindromo) 
                MessageBox.Show("A palavra " + palavra + " é um palíndromo, pois seu invevrso é " + palavraInversa);
            */
        }
    }
}
