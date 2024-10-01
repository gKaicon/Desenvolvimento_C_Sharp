using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace mainEmpregado
{
    internal class Horista : Empregado
    {
        double horas;
        public Horista()
        {
        }
        public Horista(double horas)
        {
            this.Horas = horas;
        }

        public double Horas { get => horas; set => horas = value; }

        public override double calSalario()
        {
            return this.Salario = this.Horas * 50;
        }
        public override string Informações()
        {
            return base.Informações() + "Horista\n\tHoras: " + this.horas;
        }

    }
}