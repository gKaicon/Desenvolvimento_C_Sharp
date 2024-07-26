using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormFigura
{
    internal class Circulo : Figura
    {
        private double r;

        public double R { get => r; set => r = value; }

        public override string calcPerimetro()
        {
            double perimetro = Math.Round(2 * Math.PI * r, 2);
            return "O perimetro é: " + perimetro;
        }
        public override string calcArea()
        {
            double area = Math.Round(Math.PI * Math.Pow(r, 2), 2);
            return "A area é: " + area;
        }

    }
}
