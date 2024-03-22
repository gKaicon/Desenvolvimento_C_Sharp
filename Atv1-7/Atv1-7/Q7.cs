using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atv1_7
{
    internal class Q7
    {
        public ulong somatorio(){
            ulong soma = 0;
            int i = 0;
            while (i < 64)
            {
                soma += (ulong)(Math.Pow(2, i));
                i++;
            }
            return soma;
        }
    }
}