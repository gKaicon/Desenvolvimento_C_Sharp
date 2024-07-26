using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classe_aula
{
    public class Diretor : Pessoa
    {
        public Diretor(string nome, string cpf, int idade) : base(nome, cpf, idade)
        {

        }
        public Diretor():base() 
        {

        }

        public override string viajar()
        {
            return base.viajar()+ "\nDiretor em parseria";
        }
    }
}
