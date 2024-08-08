using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtividadeAtleta
{
    public class Atleta : IAtleta
    {
        private string nome = "Wesley";

        private int idade = 22;

        public string Nome { get => nome; set => nome = value; }
        public int Idade { get => idade; set => idade = value; }

        public virtual string VerHabilidades()
        {
            return ($"O atleta {Nome} possui as seguintes habilidades:");
        }
    }
}
