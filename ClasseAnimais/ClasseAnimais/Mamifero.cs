using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasseAnimais
{
    public class Mamifero : Animais
    {
        public Mamifero(string nome) : base(nome)
        {
        }

        public override void acao()
        {

            MessageBox.Show("Ação do mamífero");
        }


        public override void falar()
        {

            MessageBox.Show("Fala do mamífero");
        }
    }
}
