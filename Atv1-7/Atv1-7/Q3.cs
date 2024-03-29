﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atv1_7
{
    internal class Q3
    {
        public double tabela(string nome, int uni, double preco)
        {
            double total = (double)uni * preco;
            Console.WriteLine(nome + ": \n\tPreço Unitário: " + preco + "\n\tUnidade: " + uni + "\n\tTotal: " + total);
            return total;
        }

        public void executar()
        {
            int cont = 1;
            double soma = 0;
            do
            {
                string nome;
                int uni;
                double preco;
                Console.WriteLine("Digite o nome do produto: ");
                nome = Console.ReadLine();

                Console.WriteLine("Digite o preço do produto: ");
                preco = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Digite  a quantidade do produto em L ou KG: ");
                uni = Convert.ToInt32(Console.ReadLine());

                soma += tabela(nome, uni, preco);
                Console.WriteLine("Deseja adicionar mais produtos na compra? Digite qualquer tecla para continuar ou digite -1 para não");
                cont = Convert.ToInt32(Console.ReadLine());
            } while (cont != -1);
            Console.WriteLine("O total da compra no mercado é " + soma);
        }

    }
}