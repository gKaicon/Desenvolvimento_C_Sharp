using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atv1_7
{
    internal class Q4
    {
        public double pesoIdeal(double h, string sx){
            double pesoIdeal;
            if(sx == "m" || sx == "M"){
                pesoIdeal = 72.7*h -58;
                return pesoIdeal;
            }
            if(sx == "f" || sx == "F"){
                pesoIdeal = 62.1*h-44.7
                return pesoIdeal;
            }
            else{
                Console.WriteLine("Entrada de sexo inválida");
                return -1;
            }
        }

    }
}