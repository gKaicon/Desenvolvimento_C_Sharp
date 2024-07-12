using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pessoa
{
    internal class Produto
    {
        private double valor;
        private string nome;

        public Produto()
        {
        }

        public Produto(double valor, string nome)
        {
            this.valor = valor;
            this.nome = nome;
        }

        public double Valor { get => valor; set => valor = value; }
        public string Nome { get => nome; set => nome = value; }

        public override string ToString()
        {
            String pessoaCad = "";
            pessoaCad += ("\nNome: " + this.nome + "\nValor: R$ " + this.valor);
            return pessoaCad;
        }
    }
}
