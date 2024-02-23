using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Primeira_Atividade
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o primeiro valor: ");
            double x1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Digite o segundo valor: ");
            double x2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("O que deseja fazer com ambos os valores?\n 1 - Somar\n2 - Subtrair\n3 - Multiplicar\n4 - Dividir");
            int op = Convert.ToInt32(Console.ReadLine());
            switch (op)
            {
                case 1:
                    Console.WriteLine("Soma: {0}",  (x1 + x2));
                    break;
                case 2:
                    Console.WriteLine("Subtração do primeiro pelo segundo: {0}", (x1 - x2));
                    Console.WriteLine("Subtração do segundo pelo primeiro: {0}", (x2 - x1));
                    break;
                case 3:
                    Console.WriteLine("Multiplicação: {0}", (x1 * x2));
                    break;
                case 4:
                    if (x1 != 0 && x2 != 0)
                    {
                        double div = x1 / x2;
                        double div2 = x2 / x1;
                        Console.WriteLine("Divisão do primeiro pelo segundo: {0}", div);
                        Console.WriteLine("Divisão do segundo pelo primeiro: {0}", div2);
                    }
                    else Console.WriteLine("Aqui não é possível realizar divisão por zero.");
                    break;
            }

            double soma = 0;
            double []notas = new double [3];
            
            for (int i = 0; i < 3; i++)
            {
                Console.Write("Digite a {0}° nota: ", (i+1));
                notas[i] = Convert.ToDouble(Console.ReadLine());
                soma += notas[i];
            }
            soma /= 3;
            Console.WriteLine("A média desse aluno é {0}", soma);
        }
    }
}
