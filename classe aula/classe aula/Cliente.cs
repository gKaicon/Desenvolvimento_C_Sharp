using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classe_aula
{
    public class Cliente : Pessoa
    {
        public String[] produto = { "Sal", "Feijão", "Açúcar", "Arroz", "Frango", "Leite", "Biscoito" };
        public double[] preco = { 1.50, 5.90, 8.90, 15.90, 19.90, 1.99, 1.99 };

        public Cliente(string nome, string cpf, int idade) : base(nome, cpf, idade)
        {

        }
        public Cliente():base() { }

        public String compra(int idProduto, int qnt)
        {
            double x = preco[idProduto] * qnt;
            String s = "Comprando:"+ (produto[idProduto]) + "\nQTD: " + qnt + "\nR$ " + x.ToString("N2") + "\n";
            return s;
        }
        public string listaProduto()
        {
            string text = "ID - Nome - Preço\n";
            for (int i = 0; i < 7; i++)
            {
                text += " " + (i+1) + " - " + produto[i] + " - R$ " + Math.Round(preco[i], 2) + "\n";
            }
            return text;
        }
        
    }
}
