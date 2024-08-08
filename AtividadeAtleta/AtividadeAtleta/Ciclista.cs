using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtividadeAtleta
{
    public class Ciclista : Atleta, ICiclista
    {
    
        public void Pedalar()
        {
            MessageBox.Show($"{Nome} está pedalando.");
        }

        public override string VerHabilidades()
        {
            return base.VerHabilidades() + "\nResistência.";          
        }
    }
}
