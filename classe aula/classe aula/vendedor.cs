using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace classe_aula
{
    public class Vendedor : Pessoa
    {
        public Vendedor(string nome, string cpf, int idade) : base(nome, cpf, idade)
        {
        }

        public Vendedor():base()
        { 
        }
        public override string viajar()
        {
            return "Realizando vendas ";
        }

        public String vendas() {
            String s = " Vendendo ou dormindo \n discubra";
            return s;
        }
    }
}
