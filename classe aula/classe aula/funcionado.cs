using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classe_aula
{
    public class Funcionado : Pessoa
    {
        public Funcionado(string nome, string cpf, int idade) : base(nome, cpf, idade)
        {
        }

        public Funcionado():base() { }

        public override string viajar()
        {
            return base.viajar() + "\nFuncinario em ferias";
        }
    }
}
