using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormFigura
{
    internal class Retangulo : Figura
    {
        private double baseR; 
        private double altura;

        public double BaseR { get => baseR; set => baseR = value; }
        public double Altura { get => altura; set => altura = value; }

        public override string calcPerimetro()
        {
            double perimetro = Math.Round(2 * (this.baseR + this.altura), 2);
            return "O perimetro do Retângulo é: " + perimetro;
        }
        public override string calcArea()
        {
            double area = Math.Round(this.baseR * this.altura, 2);
            return "A area do Retângulo é: " + area;
        }
    }
}
