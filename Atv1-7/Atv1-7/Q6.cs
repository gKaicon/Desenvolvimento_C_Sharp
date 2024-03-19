using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atv1_7
{
    internal class Q6
    {
        private double raiz_Cubica(double n){
            return Math.Pow(n, (1.0/3.0));
        }

        public double calculaPI(){
            double s = 0, val = 0, pi;
            int i = 1, cont = 1, lim = 15;
            while (cont < (lim + 1))
            {
                val += (1 / (Math.Pow(i, 3)));

                if (cont % 2 == 0)
                    val *= (-1);
                else
                    val *= 1;
                Console.WriteLine("Valor de val " + val + ", na contagem "+ cont);
                s += (val);
                i += 2;
                cont++;
                val = 0;
            }
            pi = raiz_Cubica(32 * s);
            return pi;
        }
    }
}