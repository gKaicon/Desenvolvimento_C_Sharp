using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace classe_aula
{
    public class Pessoa
    {
        //atributos
        private String nome;
        private String cpf;
        private int idade;

        //propriedades
        public String Nome { get => nome; set => nome = value; }
        public String Cpf { get => cpf; set => cpf = value; }
        public int Idade { get => idade; set => idade = value; }


        //contrutor
        public Pessoa() {
            nome = "";
            cpf = "";
            idade = 0;
            MessageBox.Show("Construtor da classe pessoa: " + this.nome);

        }
        //sobrecarga
        public Pessoa(String nome, String cpf, int idade)
        {   

            this.Nome = nome;
            this.Cpf = cpf;
            this.Idade = idade;
            MessageBox.Show("Construtor da classe pessoa: " + this.Nome);
        }
        
       public void cadastrar(String nome, String cpf , int idade)
        {
            this.Nome = nome;
            this.Cpf = cpf;
            this.Idade = idade;
        }

        public string Dados()
        {
            String s = "";
            s += "nome : " + nome + "\ncpf: " + cpf + " \niadade :" + idade + "\n";
            return s;
        }

        public virtual String  viajar()
        {
            String result = ("Sr." + nome + " está viajando");
            return result;
        }


    }
}
