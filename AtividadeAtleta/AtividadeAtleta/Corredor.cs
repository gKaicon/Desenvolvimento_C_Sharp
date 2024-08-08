using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtividadeAtleta
{
    public class Corredor : Atleta, ICorredor
    {
        public void Correr()
        {
            MessageBox.Show($"{Nome} está correndo.");
        }

        public override string VerHabilidades()
        {
            return base.VerHabilidades() + "\nTem muita velocidade.";
        }
    }
}
