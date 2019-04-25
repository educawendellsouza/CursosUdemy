using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Exercicio02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Opções de exercicios corrigidos");
            Console.WriteLine("Aperte 'Enter' para iniciar");
            Console.ReadLine();
            Console.Clear();

            Console.WriteLine("Digite a opção que desejar para entrar no programa correspondente:");
            Console.WriteLine("Programa 'A' - Determinar se um número inteiro é positivo ou negativo.");
            Console.WriteLine("Programa 'B' - Determinar se um número inteiro é par ou ímpar.");
            Console.WriteLine("Programa 'C' - Indicar se dois números inteiros são multiplos ou não.");
            Console.WriteLine("Programa 'D' - Programa para ver a duração de um jogo em horas.");
            Console.WriteLine("Programa 'E' - Calcule a quantidade de um produto e o valor que vai ser pago.");
            Console.WriteLine("Programa 'F' - Em qual intervalo está?");
            Console.WriteLine("Programa 'G' - Quadrantes de um plano cartesiano");
            Console.WriteLine("Programa 'H' - Calculo do valor do imposto de renda mjediante salário");
            // Console.WriteLine("Programa 'I' - Valores com ponto flutuante de dupla precisão.");

            Console.Write("Programa: ");

            char opcao = char.Parse(Console.ReadLine());
            Console.Clear();

            if (opcao == 'A' || opcao == 'a')
            {
                Console.WriteLine("Opção 'A' Selecionada - Determinar se um número é positivo ou negativo.");
                Console.WriteLine("");
                Console.WriteLine("O programa deverá ler um número inteiro, " +
                                  "e depois dizer se este número é negativo ou não");
                Console.WriteLine("");
                Console.WriteLine("Aperte 'Enter' para iniciar o programa.");
                Console.ReadLine();
                Console.Clear();

                Console.WriteLine("Digite um número inteiro");

                int numero = int.Parse(Console.ReadLine());

                if (numero > 0)
                {
                    Console.WriteLine("NÃO NEGATIVO");
                }
                else
                {
                    Console.WriteLine("NEGATIVO");
                }
            }

            else if (opcao == 'B' || opcao == 'b')
            {
                Console.WriteLine("Opção 'B' Selecionada - Determinar se um número é par ou ímpar.");
                Console.WriteLine("");
                Console.WriteLine("O programa deverá ler um número inteiro, " +
                                  "e depois dizer se este número par ou ímpar");
                Console.WriteLine("");
                Console.WriteLine("Aperte 'Enter' para iniciar o programa.");
                Console.ReadLine();
                Console.Clear();

                Console.WriteLine("Digite um número inteiro");

                int numero = int.Parse(Console.ReadLine());

                if (numero % 2 == 0)
                {
                    Console.WriteLine("PAR");
                }
                else
                {
                    Console.WriteLine("ÍMPAR");
                }
            }

            else if (opcao == 'C' || opcao == 'c')
            {
                Console.WriteLine("Opção 'C' Selecionada - Indicar se dois números inteiros são multiplos ou não.");
                Console.WriteLine("");
                Console.WriteLine("O programa deverá ler dois valores inteiros (A e B). " +
                                  "Após, o programa deve mostrar uma mensagem se são multiplos ou não, " +
                                  "indicando se os valores lidos são múltiplos entre si.");
                Console.WriteLine("");
                Console.WriteLine("Aperte 'Enter' para iniciar o programa.");
                Console.ReadLine();
                Console.Clear();

                Console.WriteLine("Insira os dois numeros inteiros, " +
                                  "um seguido do outro, " +
                                  "separados por 'ESPAÇO', " +
                                  "conforme o exemplo.");
                Console.WriteLine("");
                Console.WriteLine("Exemplo: 15 1");

                Console.Write("Números: ");

                string[] num = Console.ReadLine().Split(' ');
                int a = int.Parse(num[0]);
                int b = int.Parse(num[1]);

                if (a % b == 0 || b % a == 0)
                {
                    Console.WriteLine("São Multiplos");
                }

                else
                {
                    Console.WriteLine("Não são Multiplos");
                }
            }

            else if (opcao == 'D' || opcao == 'd')
            {
                Console.WriteLine("Opção 'D' Selecionada - Programa para ver a duração de um jogo em horas.");
                Console.WriteLine("");
                Console.WriteLine("O programa deverá ler a hora inicial e a hora final de um jogo. " +
                                  "A seguir calcule a duração do jogo, " +
                                  "sabendo que o mesmo pode começar em um dia e terminar em outro, " +
                                  "tendo uma duração mínima de 1 hora e máxima de 24 horas.");
                Console.WriteLine("");
                Console.WriteLine("Aperte 'Enter' para iniciar o programa.");
                Console.ReadLine();
                Console.Clear();

                Console.WriteLine("Insira os dois numeros inteiros, " +
                                  "um seguido do outro, " +
                                  "separados por 'ESPAÇO', " +
                                  "conforme o exemplo.");
                Console.WriteLine("");
                Console.WriteLine("Exemplo: 15 1");

                Console.Write("Números: ");

                int duracao;

                string[] hora = Console.ReadLine().Split(' ');
                int horaInicial = int.Parse(hora[0]);
                int horaFinal = int.Parse(hora[1]);

                if (horaInicial < horaFinal)
                {
                    duracao = horaFinal - horaInicial;
                }

                else
                {
                    duracao = 24 - horaInicial + horaFinal;
                }

                Console.WriteLine($"O JOGO DUROU {duracao} HORA(S).");
            }

            else if (opcao == 'E' || opcao == 'e')
            {
                Console.WriteLine("Opção 'E' Selecionada - Calcule a quantidade de um produto e o valor que vai ser pago.");
                Console.WriteLine("");
                Console.WriteLine(" O programa deve ler o código de um item e a quantidade deste item. " +
                                  "A seguir, calcule e mostre o valor da conta a pagar.");
                Console.WriteLine("");
                Console.WriteLine("Aperte 'Enter' para iniciar o programa.");
                Console.ReadLine();
                Console.Clear();

                Console.WriteLine("Insira os dois numeros inteiros, " +
                                  "um seguido do outro, " +
                                  "separados por 'ESPAÇO', " +
                                  "conforme o exemplo.");
                Console.WriteLine("");
                Console.WriteLine("Exemplo: 15 1");

                Console.Write("Números: ");

                string[] num = Console.ReadLine().Split(' ');
                int codigo = int.Parse(num[0]);
                double quantidade = double.Parse(num[1]);

                if (codigo == 1)
                {
                    string produto = "Cachorro Quente";
                    double total = quantidade * 4;
                    Console.WriteLine($"O valor total a ser pago pelo {produto} é de R${total.ToString("F2")}");
                }

                else if (codigo == 2)
                {
                    string produto = "X-Salada";
                    double total = quantidade * 4.5;
                    Console.WriteLine($"O valor total a ser pago pelo {produto} é de R${total.ToString("F2")}");
                }

                else if (codigo == 3)
                {
                    string produto = "X-Bacon";
                    double total = quantidade * 5;
                    Console.WriteLine($"O valor total a ser pago pelo {produto} é de R${total.ToString("F2")}");
                }

                else if (codigo == 4)
                {
                    string produto = "Torrada simples";
                    double total = quantidade * 2;
                    Console.WriteLine($"O valor total a ser pago pelo {produto} é de R${total.ToString("F2")}");
                }

                else if (codigo == 5)
                {
                    string produto = "Torrada simples";
                    double total = quantidade * 1.5;
                    Console.WriteLine($"O valor total a ser pago pelo {produto} é de R${total.ToString("F2")}");
                }

                else
                {
                    Console.WriteLine("Código inválido");
                }
            }

            else if (opcao == 'F' || opcao == 'f')
            {
                Console.WriteLine("Opção 'F' Selecionada - Em qual intervalo está?");
                Console.WriteLine("");
                Console.WriteLine(" O programa deve ler um valor qualquer e informar em qual intervalo" +
                                  " se encontra o valor digitado.");
                Console.WriteLine("");
                Console.WriteLine("Aperte 'Enter' para iniciar o programa.");
                Console.ReadLine();
                Console.Clear();

                Console.WriteLine("Insira o número. Sendo esse número 'double' " +
                                  "separe com o '.' (ponto final)");
                Console.WriteLine("");
                Console.WriteLine("Exemplo: 15.53");

                Console.Write("Número: ");

                double num = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                if (num >= 0 && num <= 25)
                {
                    Console.Clear();
                    Console.WriteLine($"Você digitou {num.ToString("F2")}. " +
                                      $"Que esta dentro do intervalo de [0 à 25]");
                }

                else if (num >= 25.01 && num <= 50)
                {
                    Console.Clear();
                    Console.WriteLine($"Você digitou {num.ToString("F2")}. " +
                                      $"Que esta dentro do intervalo de [25.01 à 50]");
                }

                else if (num >= 50.01 && num <= 75)
                {
                    Console.Clear();
                    Console.WriteLine($"Você digitou {num.ToString("F2")}. " +
                                      $"Que esta dentro do intervalo de [50.01 à 75]");
                }

                else if (num >= 75.01 && num <= 100)
                {
                    Console.Clear();
                    Console.WriteLine($"Você digitou {num.ToString("F2")}. " +
                                      $"Que esta dentro do intervalo de [75.01 à 100]");
                }

                else
                {
                    Console.Clear();
                    Console.WriteLine($"Você digitou {num.ToString("F2")}. " +
                                      $"Esse número esta fora do intervalo.");
                }

            }

            else if (opcao == 'G' || opcao == 'g')
            {
                Console.WriteLine("Opção 'G' Selecionada - Quadrantes de um plano cartesiano");
                Console.WriteLine("");
                Console.WriteLine(" O programa deve ler dois valores qualquer e informar em qual quadrante" +
                                  " de um plano cartesiano eles se encontram.");
                Console.WriteLine("");
                Console.WriteLine("Aperte 'Enter' para iniciar o programa.");
                Console.ReadLine();
                Console.Clear();

                Console.WriteLine("Insira os dois números, sendo o primeiro representando o 'X' e" +
                                  " o segundo representando o 'Y', do plano cartesiano.");
                Console.WriteLine("");
                Console.WriteLine("O Programa vai informar em qual quadrante pertence " +
                                  "as ''coordenadas'' informadas");
                Console.WriteLine("");
                Console.WriteLine("Exemplo: 15.5 -5.3");

                Console.Write("Números: ");

                string[] coordenadas = Console.ReadLine().Split(' ');
                double x = double.Parse(coordenadas[0], CultureInfo.InvariantCulture);
                double y = double.Parse(coordenadas[1], CultureInfo.InvariantCulture);

                Console.Clear();

                if (x > 0 && y > 0)
                {
                    Console.WriteLine($"A coordenada X é {x}");
                    Console.WriteLine();
                    Console.WriteLine($"A coordenada Y é {y}");
                    Console.WriteLine();
                    Console.WriteLine("Sendo assim, a combinação pertence ao quadrante: Q1");
                }
                else if (x < 0 && y > 0)
                {
                    Console.WriteLine($"A coordenada X é {x.ToString("F2")}");
                    Console.WriteLine();
                    Console.WriteLine($"A coordenada Y é {y}");
                    Console.WriteLine();
                    Console.WriteLine("Sendo assim, a combinação pertence ao quadrante: Q2");
                }
                else if (x < 0 && y < 0)
                {
                    Console.WriteLine($"A coordenada X é {x}");
                    Console.WriteLine();
                    Console.WriteLine($"A coordenada Y é {y}");
                    Console.WriteLine();
                    Console.WriteLine("Sendo assim, a combinação pertence ao quadrante: Q3");
                }
                else if (x > 0 && y < 0)
                {
                    Console.WriteLine($"A coordenada X é {x}");
                    Console.WriteLine();
                    Console.WriteLine($"A coordenada Y é {y}");
                    Console.WriteLine();
                    Console.WriteLine("Sendo assim, a combinação pertence ao quadrante: Q4");
                }
                else
                {
                    Console.WriteLine($"A coordenada X é {x}");
                    Console.WriteLine();
                    Console.WriteLine($"A coordenada Y é {y}");
                    Console.WriteLine();
                    Console.WriteLine("Sendo assim, a combinação pertence ao quadrante de Origem");
                }
            }

            else if (opcao == 'H' || opcao == 'h')
            {
                double salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                if (salario <= 2000)
                {
                    Console.WriteLine("Isento");
                }

                else if (salario > 2000 && salario <= 3000)
                {
                    double imposto = (salario / 100) * 8;
                    Console.WriteLine(imposto.ToString("F2"));
                }

                else if (salario > 3000 && salario <= 4500)
                {
                    double a = (salario - 3000) * 18 / 100;
                    double imposto = 80 + a;
                    Console.WriteLine(imposto.ToString("F2"));
                }

                else if (salario > 4500)
                {
                    double a = (salario - 4500) * 28 / 100;
                    double imposto = 80 + 270 + a;
                    Console.WriteLine(imposto.ToString("F2"));
                }

                else
                {

                }
            }

            else
            {
                Console.WriteLine("Entrada invalida, pressione 'Enter' para sair.");
                Console.ReadLine();
            }
        }
    }
}
