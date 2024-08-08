using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasseAnimais
{
    public class Oviparo : Animais
    {
        public Oviparo(string nome) : base(nome)
        {
        }

        public override void acao()
        {
            
            MessageBox.Show("Ação do ovíparo");
        }

    
        public override void falar()
        {
           
            MessageBox.Show("Fala do ovíparo");
        }
    }
}
