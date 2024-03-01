using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrganizarCod
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string resultado = "";
            int x = 3;
            while (x > 0)
            {
                if (x > 2)
                {
                    resultado = resultado + "a";
                }
                if (x == 1)
                {
                    resultado = resultado + "d";
                    x = x - 1;
                }
                if (x == 2)
                {
                    resultado = resultado + "b-c";
                }
                resultado = resultado + "-";
                x = x - 1;
            }
            Console.WriteLine(resultado);
        }
    }
}
