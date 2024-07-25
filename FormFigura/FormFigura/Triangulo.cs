using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormFigura
{
    internal class Triangulo : Figura
    {
        private double baseT;
        private double altura;

        public double BaseT { get => baseT; set => baseT = value; }
        public double Altura { get => altura; set => altura = value; }

        //supondo que é equilatero

        public override string calcPerimetro()
        {
            double perimetro = this.baseT * 3;
            return "O perimetro é :" + perimetro;
        }
        public override string calcArea()
        {
            double area = (this.baseT * this.altura) / 2;
            return "A area é: " + area;
        }
    }
}
