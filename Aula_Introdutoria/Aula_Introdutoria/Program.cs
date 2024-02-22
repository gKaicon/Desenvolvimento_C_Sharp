using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Qual o seu nome: ");
            //writeLine - escrever na linha e induzir quebra de linha automática
            String s = Console.ReadLine();
            Console.Write("Qual o seu sobrenome: ");
            //writeLine - escrever na linha sem induzir quebra de linha automática
            String s2 = Console.ReadLine();
            Console.WriteLine("Seja bem-vindo {0} {1}", s, s2);
            //realine - ler string
            Console.WriteLine("Seja bem-vindo " + s + " " + s2);

            // ----- Tudo em C# é lido como inteiro -----  //
            Console.Write("Qual é sua idade: ");
            String input = Console.ReadLine();
            int x = Convert.ToInt32(input);
            int x1 = Int32.Parse(input);
            Console.Write("Qual é sua altura em cm: ");
            int x2 = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Idade: {0}", x);
            Console.WriteLine("Idade: {0}", x1);
            Console.WriteLine("Altura: {0}", x2);

            Console.ReadKey();
        }
    }
}
