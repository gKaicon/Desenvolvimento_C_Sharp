using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtividadeAtleta
{
    public class Nadador : Atleta, INadador
    {
        public void Nadar()
        {
            MessageBox.Show($"{Nome} está nadando.");
        }

        public override string VerHabilidades()
        {
            return base.VerHabilidades() + "\nExcelente técnica de nado.";
        }
    }
}
