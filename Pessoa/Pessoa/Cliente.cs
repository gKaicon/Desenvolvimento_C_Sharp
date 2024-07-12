using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pessoa
{
    internal class Cliente : Pessoa
    {

        public Cliente() {
        }

        public Cliente(string nome, string cpf, int idade) : base(nome, cpf, idade)
        {
        }

        private List<Produto> produtosComprados = new List<Produto>();

        public List<Produto> ProdutosComprados
        {
            get { return produtosComprados; }
        }

        public void AdicionarProduto(Produto produto)
        {
            produtosComprados.Add(produto);
        }
    }
}
