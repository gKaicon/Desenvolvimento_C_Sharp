using System.Windows.Forms;

namespace Aula2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String nome = "Jos�"; //declara��o da vari�vel tipo String
            int x = 3; //declara��o da vari�vel x do tipo inteiro
            x *= 17; //atribui��o a x do valor de x multiplicado por 17
            double d = Math.PI / 2; //declara��o da vari�vel d, recebendo o valor de PI dividido por 2
            MessageBox.Show("nome � " + nome + "\nX � " + x + "\nD � " + d);
            //exibi��o de todas as vari�veis em uma tela de mensagem
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int x = 5;
            if (x == 10)
            {
                MessageBox.Show("X � igual a 10");
            }
            else
            {
                MessageBox.Show(" X � diferente de 10");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int resultado = 0;
            int x = 6;
            while (x > 3)
            {
                resultado = resultado + x;
                x = x - 1;
            }
            for (int z = 1; z < 3; z = z + 1)
            {
                resultado = resultado + z;
            }
            MessageBox.Show("O resultado �: " + resultado);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int contador = 0;
            while (contador < 10)
            {
                contador = contador + 1;
            }
            for (int i = 0; i < 5; i++)
            {
                contador = contador - 1;
            }
            MessageBox.Show("O Resultado �: " +
            contador);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            
            int p = 2;
            for (int q = 2; q < 32; q = q * 2)
            {
                Console.WriteLine("Entrei no for, valor de � p = " + p + ", valor de q = " + q);    
                while (p < q)
                {
                    Console.WriteLine("Entrei no while e o valor de p = " + p);
                    p = p * 2;
                    Console.Write(" e depois da opera��o o valor de p = " + p);
                }
                q = p - q;
            }
        }
    }
}
