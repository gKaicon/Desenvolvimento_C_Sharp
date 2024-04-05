using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Questão1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int opS;
            do
            {
                Console.WriteLine("1.Calcular PA\n2.Situação Aluno\n3.Volume da lata de óleo\n4.Verificação do número triangular\n5.Pedidos\nDigite uma opção:");
                opS = Convert.ToInt32(Console.ReadLine());
                switch(opS){
                    case 1:
                        //Questão 1
                        Console.WriteLine("Digite o valor de a1: ");
                        double a1 = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Digite o valor de an: ");
                        double an = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Digite a quantidade de termos: ");
                        int n_termos = Convert.ToInt32(Console.ReadLine());
                        double soma = ((a1 + an) * ((double)(n_termos))) / 2;
                        Console.WriteLine("Soma PA: " + soma);
                    break;

                    case 2:
                        //Questão 2
                        Console.WriteLine("Digite a nota do aluno: ");
                        double nota = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Digite a frequencia (%) desse aluno: ");
                        double frequencia = Convert.ToDouble(Console.ReadLine());

                        if (nota >= 60 && frequencia >= 75)
                            Console.WriteLine("Aluno aprovado");
                        else
                        {
                            Console.WriteLine("Aluno reprovado pelo(s) seguinte(s) motivo(s): ");
                            if (nota < 60)
                                Console.WriteLine("Nota");
                            if (frequencia < 75)
                                Console.WriteLine("Frequencia");
                        }
                    break; 
                    
                    case 3:  
                        //Questão 3
                        Console.WriteLine("Digite o raio da lata de óleo: ");
                        double r = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Digite a altura da lata de óleo: ");
                        double h = Convert.ToDouble(Console.ReadLine());
                        double v = 3.1415169 * (Math.Pow(r, 2)) * h;
                        Console.WriteLine("O volume é " + v + " U.V.");
                    break; 
                    
                    case 4:
                        //Questão 4
                        Console.WriteLine("Digite um valor: ");
                        int n = Convert.ToInt32(Console.ReadLine());
                        int a = 1;
                        while (a * (a + 1) * (a + 2) <= n)
                        {
                            a++;
                        }
                        int verificacao = (a * (a + 1) * (a + 2));
                        if ((verificacao == n) == true)
                        {//triangular
                            Console.WriteLine("O número " + n + " é triangular");
                            break;
                        }
                        else
                        {
                            Console.WriteLine("O número " + n + " não é triangular");
                            break;
                        }
                        
                    break;
                    case 5:
                        //Questão 5
                        Console.WriteLine("_____PEDIDOS_____");
                        double somaPedidos = 0, preco, precoFinal;
                        int op = 1;
                        int dia, ano, mes, qtd, numPedi;
                        while (op != 0)
                        {
                            Console.WriteLine("Digite o número do pedido");
                            numPedi = Convert.ToInt32(Console.ReadLine());

                            do {
                                Console.WriteLine("Digite o dia em que o pedido está sendo feito:");
                                dia = Convert.ToInt32(Console.ReadLine());
                            } while (dia <= 0 || dia >= 32);
                            do {
                                Console.WriteLine("Digite o mês em que o pedido está sendo feito:");
                                mes = Convert.ToInt32(Console.ReadLine());
                                //tratamentos dos dias certinhos
                                if(mes == 2 && (dia == 30 || dia == 31)){ //se fevereiro mudar dia pra 28
                                    dia = 28;
                                    Console.WriteLine("Mês Fevereiro, dia alterado para 28");
                                }
                                else if(mes % 2 != 0 || mes == 8 && dia == 30) { //se o mês for impar, ou agosto, mudar pra 31
                                    dia = 31;
                                    Console.WriteLine("Mês(janeiro, março, maio, julho, agosto, outubro, dezembro), dia alterado para 31");
                                }
                                else if(dia == 31 && mes % 2 == 0 && mes != 2 && mes != 8) // se o mês for par
                                {
                                    dia = 30;
                                    Console.WriteLine("Mês(abril, junho, setembro, novembro), dia alterado para 30");
                                }
                            } while (mes <= 0 || mes >= 13) ;   

                            Console.WriteLine("Digite o ano em que o pedido está sendo feito:");
                            ano = Convert.ToInt32(Console.ReadLine());

                            Console.WriteLine("Data: " + dia + "/" + mes + "/" + ano);

                            Console.Write("Digite o preço unitário do pedido: R$ ");
                            preco = Convert.ToDouble(Console.ReadLine());

                            Console.WriteLine("Digite a quantidade: ");
                            qtd = (Convert.ToInt32(Console.ReadLine()));
                            qtd = qtd < 0 ? qtd * (-1) : qtd;

                            somaPedidos += (preco * (double)qtd);
                            Console.WriteLine("Deseja continuar inserindo pedidos? Digite 0 para não, e qualquer outra tecla para sim");
                            op = Convert.ToInt32(Console.ReadLine());
                        }
                        Console.WriteLine("O Valor total da compra é : R$ " + Math.Round(somaPedidos), 2);
                    break;

                    default:
                        Console.WriteLine("Fim da Execução.");
                    break;
                }
                opS = 0;
            } while (opS <= (-1) || opS > 5);
        }
    }
}
