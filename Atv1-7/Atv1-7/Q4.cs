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
            double pesoIdeal = 0;
            if(sx == "m" || sx == "M")
                pesoIdeal = 72.7 * h - 58;
            if(sx == "f" || sx == "F")
                pesoIdeal = 62.1 * h - 44.7;
            return pesoIdeal;
        }
    }
}