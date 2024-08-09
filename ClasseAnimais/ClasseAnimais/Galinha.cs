using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasseAnimais
{
    public class Galinha : Oviparo
    {
        public Galinha(string nome) : base(nome)
        {
        }

        public override void acao()
        {
            MessageBox.Show("Ciscando o chão...");
        }

        public override void falar()
        {
            MessageBox.Show("Cócóricó !");
        }
    }
}
