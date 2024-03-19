using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atv1_7
{
    internal class Q7
    {
        public long somatorio(){
            int i = 0;
            long soma = 0;
            while(i < 64){
                soma += Math.pow(2, i);
            }
            return soma;
        }
    }
}