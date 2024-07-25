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
            double perimetro = 2 * (this.baseR + this.altura);
            return "O perimetro é : " + perimetro;
        }
        public override string calcArea()
        {
            double area = this.baseR * this.altura;
            return "A area é: " + area;
        }
    }
}
