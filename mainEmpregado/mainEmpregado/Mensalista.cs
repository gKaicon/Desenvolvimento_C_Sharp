using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mainEmpregado
{
    internal class Mensalista : Empregado
    {
        String cargo;
        public Mensalista() { }
       
        public Mensalista(string cargo)
        {
            this.cargo = cargo;
        }

        public string Cargo { get => cargo; set => cargo = value; }

        public override double calSalario()
        {
            if (this.cargo.Equals("Junior"))
            {
                this.Salario = 5000;
            }
            else if (this.cargo.Equals("Pleno"))
            {
                this.Salario = 7000;
            }
            else if (this.cargo.Equals("Sênior"))
            {
                this.Salario = 9000;
            }
            else
            {
                Console.WriteLine("Você não informou o cargo");
                this.Salario = -1;
            }

            return this.Salario;
        }
        public override string Informações()
        {
            return base.Informações() + "Mensalista\n\tCargo: " + this.Cargo;
        }
    }
}