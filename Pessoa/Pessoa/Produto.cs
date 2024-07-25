using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pessoa
{
    internal class Produto
    {
        private int idProd;
        private double valor;
        private string nome;
        private int qtd;

        public Produto()
        {
        }

        public Produto(double valor, string nome, int idProd, int qtd)
        {
            this.idProd = idProd;
            this.valor = valor;
            this.nome = nome;
            this.qtd = qtd;
        }

        public double Valor { get => valor; set => valor = value; }
        public string Nome { get => nome; set => nome = value; }
        public int IdProd { get => idProd; set => idProd = value; }
        public int Qtd { get => qtd; set => qtd = value; }

        public override string ToString()
        {
            String pessoaCad = "";
            pessoaCad += ("\nId: " + this.idProd + "\nNome: " + this.nome + "\nValor: R$ " + this.valor + "\nQtd:" + this.qtd + "\n\n");
            return pessoaCad;
        }

        public string listaProdutos(List<Produto> produtos)
        {
            if (produtos == null)
            {
                return "Nenhum produto encontrado.";
            }

            StringBuilder lista = new StringBuilder();
            lista.Append("Lista de Produtos:\n");

            foreach (Produto produto in produtos)
            {
                lista.Append(produto.ToString());
            }

            return lista.ToString();
        }
    }
}
