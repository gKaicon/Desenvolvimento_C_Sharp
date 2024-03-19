using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atv1_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Q1 q1 = new Q1();
            Console.WriteLine(q1.area(2, 4) + "\n" + q1.perimetro(2, 4));

            Q2 q2 = new Q2();
            Console.WriteLine(""+q2.Celsius_Fahrenheit(32));

            Q3 q3 = new Q3();
            q3.executar();

            Q4 q4 = new Q4();
            Console.WriteLine(""+pesoIdeal(1.8, "m"));

            Q5 q5 = new Q5();
            Console.WriteLine(""+calculaN(5));

            Q6 q6 = new Q6();
            Console.WriteLine(""+q6.calculaPI());

            Q7 q7 = new Q7();
            Console.WriteLine(""+q7.somatorio());
        }
    }
}
