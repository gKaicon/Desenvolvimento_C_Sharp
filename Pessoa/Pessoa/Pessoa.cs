using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pessoa
{
    internal class Pessoa//mudar para partial se der merda
    {
        private string nome;
        private string cpf;
        private int idade;

        public Pessoa()
        {
        }

        public Pessoa(string nome, string cpf, int idade)
        {
            this.nome = nome;
            this.cpf = cpf;
            this.idade = idade;
        }

        public string Nome { get => nome; set => nome = value; }
        public string CPF1 { get => cpf; set => cpf = value; }
        public int Idade { get => idade; set => idade = value; }

        public override string ToString()
        {
            String pessoaCad = "";
            pessoaCad += ("\nNome: " + this.nome + "\nCPF: " + this.cpf + "\nIdade: " + this.idade);
            return pessoaCad;
        }
    }
}
