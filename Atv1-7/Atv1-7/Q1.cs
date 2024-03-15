using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atv1_7
{
    internal class Q1
    {
        //area e perimetro
        public double area(double b, double h)
        {
            double areaR = (b * h) < 0 ? (b * h) * -1 : (b * h);
            return areaR;
        }
        public double perimetro(double b, double h)
        {
            double perimetro = (2 * (b + h)) < 0 ? (2 * (b + h)) * -1 : (2 * (b + h));
            return perimetro;
        }
    }
}
