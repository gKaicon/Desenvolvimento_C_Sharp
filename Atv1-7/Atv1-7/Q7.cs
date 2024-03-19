using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atv1_7
{
    internal class Q7
    {
        public double somatorio(){
            int i = 0;
            double soma = 0;
            while(i < 64){
                soma += Math.Pow(2, i);
            }
            return soma;
        }
    }
}