using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasseAnimais
{
    public class Cachorro : Mamifero
    {
        public Cachorro(string nome) : base(nome)
        {
        }

        public override void acao()
        {
            MessageBox.Show("Cachorro correndo no parque ...");
        }

        public override void falar()
        {
            MessageBox.Show("Au Au !");
        }
    }
}
