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

        // Sobrescreve o método acao da classe base
        public override void acao()
        {
            // Aqui você define a mensagem específica para Galinha
            MessageBox.Show("Ciscando o chão...");
        }

        // Se necessário, você pode também sobrescrever o método falar
        public override void falar()
        {
            // Defina o som específico da galinha, se desejado
            MessageBox.Show("Cócóricó !");
        }
    }
}
