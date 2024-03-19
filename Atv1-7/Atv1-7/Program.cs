using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atv1_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int op;
            do {
                Console.WriteLine("\n1 - Perimetro area" +
                    "\n2 - Celsius para Fahrenheit" +
                    "\n3 - Mercearia" +
                    "\n4 - Peso Ideal" +
                    "\n5 - Calcula n" +
                    "\n6 - Calcula PI" +
                    "\n7 - Somatorio tabuleiro de xadrez" +
                    "\nEscolha uma das opções acima, ou digite um valor negativo para sair: ");
                op = Convert.ToInt32(Console.ReadLine());
                switch (op) {
                    case 1:
                        Q1 q1 = new Q1();
                        double b, h0;
                        Console.WriteLine("Digite a altura do retangulo: ");
                        Console.WriteLine("Digite a base do retangulo: ");
                        b = Convert.ToDouble(Console.ReadLine());
                        h0 = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine(q1.area(b, h0) + "\n" + q1.perimetro(b, h0));
                        break;
                    case 2:
                        Q2 q2 = new Q2();
                        Console.WriteLine("Digite uma temperatura em Celsius e ela será convertida para Fahrenheit: ");
                        double celsius = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Fahrenheit: " + q2.Celsius_Fahrenheit(celsius));
                        break;
                    case 3:
                        Q3 q3 = new Q3();
                        Console.WriteLine("__Mercearia__");
                        q3.executar();
                        break;
                    case 4:
                        Q4 q4 = new Q4();
                        Console.WriteLine("Digite a altura em metros(ex:1.75):");
                        double h = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Digite o sexo em forma singular(m para masculino ou f para feminino)");
                        string sx;
                        do {
                            sx = Console.ReadLine();
                            if (sx != "m" && sx != "M" && sx != "f" && sx != "F")
                                Console.WriteLine("Entrada de sexo inválida, digite m ou f:");
                        } while (sx == "m" || sx == "M" || sx == "f" || sx == "F");
                        Console.WriteLine("O seu peso ideal: " + q4.pesoIdeal(h, sx));
                        break;
                    case 5:
                        Q5 q5 = new Q5();
                        Console.WriteLine("Digite um valor positivo para n: ");
                        int n = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("" + q5.calculaN(n));
                        break;
                    case 6:
                        Q6 q6 = new Q6();
                        Console.WriteLine("Calculo de PI: " + q6.calculaPI());
                        break;
                    case 7:
                        Q7 q7 = new Q7();
                        Console.WriteLine("Somatorio de casas do Xadrez: " + q7.somatorio());
                        break;
                    default:
                        Console.WriteLine("Entrada inválida.");
                        break;
                }
            }while(op < 0);
        }
    }
}
