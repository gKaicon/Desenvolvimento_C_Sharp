using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mainEmpregado
{
    internal class Empregado
    {
        string nome;
        string endereco;
        double salario;

        public Empregado()
        {

        }

        public Empregado(string nome, string endereco)
        {
            Nome = nome;
            Endereco = endereco;
        }

        public string Nome { get => nome; set => nome = value; }
        public string Endereco { get => endereco; set => endereco = value; }
        public double Salario { get => salario; set => salario = value; }

        public virtual double calSalario()
        {
            return salario;
        }
        
        public virtual String Informações() {
            return "\nINFORMAÇÕES EMPREGADO\n\tNome: " + this.nome + "\n\tEndereço: " + this.endereco + "\n\tSalario: R$" + this.salario + "\n\tTipo Empregado: ";
        }
    }
}