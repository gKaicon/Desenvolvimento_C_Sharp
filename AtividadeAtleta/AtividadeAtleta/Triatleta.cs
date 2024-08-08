using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtividadeAtleta
{
    public class Triatleta : Atleta, IAtleta, ICiclista, ICorredor, INadador
    {
        public override string VerHabilidades()
        {
            return base.VerHabilidades() + "\nResistência" + "\n" + "Tem muita velocidade" + "\n" + "Excelente técnica de nado.";
        }
        public void Pedalar()
        {
            MessageBox.Show($"{Nome} está pedalando.");
        }

        public void Correr()
        {
            MessageBox.Show($"{Nome} está correndo.");
        }

        public void Nadar()
        {
            MessageBox.Show($"{Nome} está nadando.");
        }

        public void Triatlo()
        {
            MessageBox.Show($"O triatleta {Nome} está iniciando o triatlo!");
            Pedalar();
            Nadar();
            Correr();
            MessageBox.Show($"O triatleta {Nome} completou o triatlo!");
        }


    }
}
