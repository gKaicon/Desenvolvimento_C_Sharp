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
            String nome = "José"; //declaração da variável tipo String
            int x = 3; //declaração da variável x do tipo inteiro
            x *= 17; //atribuição a x do valor de x multiplicado por 17
            double d = Math.PI / 2; //declaração da variável d, recebendo o valor de PI dividido por 2
            MessageBox.Show("nome é " + nome + "\nX é " + x + "\nD é " + d);
            //exibição de todas as variáveis em uma tela de mensagem
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int x = 5;
            if (x == 10)
            {
                MessageBox.Show("X é igual a 10");
            }
            else
            {
                MessageBox.Show(" X é diferente de 10");
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
            MessageBox.Show("O resultado é: " + resultado);
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
            MessageBox.Show("O Resultado é: " +
            contador);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            
            int p = 2;
            for (int q = 2; q < 32; q = q * 2)
            {
                Console.WriteLine("Entrei no for, valor de é p = " + p + ", valor de q = " + q);    
                while (p < q)
                {
                    Console.WriteLine("Entrei no while e o valor de p = " + p);
                    p = p * 2;
                    Console.Write(" e depois da operação o valor de p = " + p);
                }
                q = p - q;
            }
        }
    }
}
