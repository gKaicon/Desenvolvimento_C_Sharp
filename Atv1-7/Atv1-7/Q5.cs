using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atv1_7
{
    internal class Q5
    {
        public double calculaN(double n){
            double a = n;
            if (n < 0){
                n = n * (-1);
                Console.WriteLine("Você digitou um valor negativo para n, consideraremos o valor positivo n = " + n);
            }
            if(n==0){
                Console.WriteLine("Você digitou n = 0, consideraremos N = 1");
                n = 1;
            }
            double i = 1, d = i+1;
            while(d<=n){
                a += ((n-i))/d;
                i++;
                d++;
            }
            return a;
        }
    }
}