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
            
        }
    }
}
