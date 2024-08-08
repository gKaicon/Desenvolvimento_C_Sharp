using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasseAnimais
{
    public class Gato : Mamifero
    {
        public Gato(string nome) : base(nome)
        {
        }

        public override void acao()
        {
            MessageBox.Show("Gato pulando em cima do sofá...");
        }

        public override void falar()
        {
            MessageBox.Show("Miau !");
        }
    }
}
