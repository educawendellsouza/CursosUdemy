using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Exercicio03
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Exercícios sobre Estrutura Repetitiva WHILE");
            Console.WriteLine();
            Console.WriteLine("Opções de exercicios corrigidos");
            Console.WriteLine("Aperte 'Enter' para iniciar");
            Console.ReadLine();
            Console.Clear();

            Console.WriteLine("Digite a opção que desejar para entrar no programa correspondente:");

            Console.WriteLine("Programa 'A' - Repetição com senha");
            Console.WriteLine("Programa 'B' - Descubra o quadrante de um plano cartesiano");
            Console.WriteLine("Programa 'C' - Qual combustivel é o seu preferido?");
            //Console.WriteLine("Programa 'D' - ");
            //Console.WriteLine("Programa 'E' - ");
            //Console.WriteLine("Programa 'F' - ");            

            Console.Write("Programa: ");
            char opcao = char.Parse(Console.ReadLine());
            Console.Clear();

            while (opcao != 0)
            {
                if (opcao == 'A' || opcao == 'a')
                {
                    Console.WriteLine("Escreva um programa que repita a leitura de uma senha até que ela " +
                                      "seja válida. Para cada leitura de senha incorreta informada, escrever " +
                                      "a mensagem 'Senha Invalida'.Quando a senha for informada corretamente " +
                                      "deve ser impressa a mensagem 'Acesso Permitido' e o algoritmo encerrado." +
                                      "Considere que a senha correta é o valor 2002.");

                    Console.ReadKey();
                    Console.Clear();

                    Console.WriteLine("Digite a senha para descobrir a mensagem");
                    Console.WriteLine();
                    Console.Write("Senha: ");
                    int senha = int.Parse(Console.ReadLine());
                    int senhaValida = 2002;

                    while (senha != senhaValida)
                    {
                        Console.Clear();
                        Console.WriteLine("Senha Incorreta");
                        Console.ReadKey();
                        Console.Clear();
                        Console.WriteLine("Digite outra senha para descobrir a mensagem");
                        Console.WriteLine();
                        Console.Write("Senha: ");
                        senha = int.Parse(Console.ReadLine());
                    }

                    Console.WriteLine("Senha correta");
                    Console.Clear();
                    Console.WriteLine("Mensagem:");
                    Console.WriteLine();
                    Console.WriteLine("Em todo tempo: Louve.");

                    Console.ReadKey();
                    Console.Clear();
                }

                else if (opcao == 'B' || opcao == 'b')
                {
                    Console.WriteLine("Escreva um programa para ler as coordenadas (X,Y) de uma quantidade " +
                                      "indeterminada de pontos no sistema cartesiano.Para cada ponto escrever " +
                                      "o quadrante a que ele pertence.O algoritmo será encerrado quando pelo " +
                                      "menos uma de duas coordenadas for NULA (nesta situação sem escrever " +
                                      "mensagem alguma).");
                    Console.ReadKey();
                    Console.Clear();

                    Console.WriteLine("Escreva as coordenadas separadas por ','");
                    Console.Write("Coordenadas: ");

                    string[] num = Console.ReadLine().Split(',');
                    int x = int.Parse(num[0]);
                    int y = int.Parse(num[1]);

                    while (x != 0 && y != 0)
                    {
                        if (x > 0 && y > 0)
                        {
                            Console.WriteLine();
                            Console.WriteLine($"A coordenada X é {x}");
                            Console.WriteLine($"A coordenada Y é {y}");
                            Console.WriteLine();
                            Console.WriteLine("Sendo assim, a combinação pertence ao quadrante: Q1");
                        }
                        else if (x < 0 && y > 0)
                        {
                            Console.WriteLine();
                            Console.WriteLine($"A coordenada X é {x.ToString("F2")}");
                            Console.WriteLine($"A coordenada Y é {y}");
                            Console.WriteLine();
                            Console.WriteLine("Sendo assim, a combinação pertence ao quadrante: Q2");
                        }
                        else if (x < 0 && y < 0)
                        {
                            Console.WriteLine();
                            Console.WriteLine($"A coordenada X é {x}");
                            Console.WriteLine($"A coordenada Y é {y}");
                            Console.WriteLine();
                            Console.WriteLine("Sendo assim, a combinação pertence ao quadrante: Q3");
                        }
                        else
                        {
                            Console.WriteLine();
                            Console.WriteLine($"A coordenada X é {x}");
                            Console.WriteLine($"A coordenada Y é {y}");
                            Console.WriteLine();
                            Console.WriteLine("Sendo assim, a combinação pertence ao quadrante: Q4");
                        }

                        Console.WriteLine();
                        Console.WriteLine("Aperte alguma tecla para continuar...");

                        Console.ReadKey();
                        Console.Clear();

                        Console.WriteLine("Escreva as coordenadas separadas por ','");
                        Console.Write("Coordenadas: ");
                        string[] num2 = Console.ReadLine().Split(',');
                        x = int.Parse(num2[0]);
                        y = int.Parse(num2[1]);
                    }
                    Console.Clear();

                }

                else if (opcao == 'C' || opcao == 'c')
                {
                    Console.WriteLine("Um Posto de combustíveis deseja determinar qual de seus produtos tem " +
                                      "a preferência de seus clientes. Escreva um algoritmo para ler o tipo " +
                                      "de combustível abastecido (codificado da seguinte forma: " +
                                      "1.Álcool 2.Gasolina 3.Diesel 4.Fim). Caso o usuário informe um código inválido " +
                                      "(fora da faixa de 1 a 4) deve ser solicitado um novo código (até que seja válido). " +
                                      "O programa será encerrado quando o código informado for o número 4. " +
                                      "Deve ser escrito a mensagem: ''MUITO OBRIGADO'' e a quantidade de clientes " +
                                      "que abasteceram cada tipo de combustível, conforme exemplo.");
                    Console.ReadKey();
                    Console.Clear();

                    Console.WriteLine("Pesquisa para saber qual é o melhor combustivel");
                    Console.WriteLine();
                    Console.WriteLine("Digite o numero que corresponde ao seu combustivel predileto.");
                    Console.WriteLine();
                    Console.WriteLine("1 - Álcool");
                    Console.WriteLine("2 - Gasolina");
                    Console.WriteLine("3 - Diesel");
                    Console.WriteLine("4 - Não participar da pesquisa");

                    int alcool = 0;
                    int gasolina = 0;
                    int diesel = 0;

                    Console.WriteLine();
                    Console.Write("Opção: ");
                    int combustivel = int.Parse(Console.ReadLine());

                    while (combustivel <= 4 && combustivel > 0)
                    {
                        if (combustivel == 1)
                        {
                            Console.Clear();
                            alcool++;

                            Console.WriteLine("Voto computado para o Álcool");
                            Console.WriteLine();
                            Console.WriteLine("Parciais: ");
                            Console.WriteLine();
                            Console.WriteLine(alcool + " pessoas preferem Álcool");
                            Console.WriteLine(gasolina + " pessoas preferem Gasolina");
                            Console.WriteLine(diesel + " pessoas preferem Diesel");
                            Console.ReadKey();
                        }

                        else if (combustivel == 2)
                        {
                            Console.Clear();
                            gasolina++;

                            Console.WriteLine("Voto computado para o Gasolina");
                            Console.WriteLine();
                            Console.WriteLine("Parciais: ");
                            Console.WriteLine();
                            Console.WriteLine(alcool + " pessoas preferem Álcool");
                            Console.WriteLine(gasolina + " pessoas preferem Gasolina");
                            Console.WriteLine(diesel + " pessoas preferem Diesel");
                            Console.ReadKey();
                        }

                        else if (combustivel == 3)
                        {
                            Console.Clear();
                            diesel++;

                            Console.WriteLine("Voto computado para o Diesel");
                            Console.WriteLine();
                            Console.WriteLine("Parciais: ");
                            Console.WriteLine();
                            Console.WriteLine(alcool + " pessoas preferem Álcool");
                            Console.WriteLine(gasolina + " pessoas preferem Gasolina");
                            Console.WriteLine(diesel + " pessoas preferem Diesel");
                            Console.ReadKey();
                        }

                        else
                        {
                            Console.WriteLine("Muito Obrigado");
                            Console.ReadKey();
                        }

                        Console.Clear();

                        Console.WriteLine("Pesquisa para saber qual é o melhor combustivel");
                        Console.WriteLine();
                        Console.WriteLine("Digite o numero que corresponde ao seu combustivel predileto.");
                        Console.WriteLine();
                        Console.WriteLine("1 - Álcool");
                        Console.WriteLine("2 - Gasolina");
                        Console.WriteLine("3 - Diesel");
                        Console.WriteLine("4 - Não participar da pesquisa");
                        Console.WriteLine("Qualquer outro numero - Sair da pesquisa");

                        Console.Write("Opção: ");
                        combustivel = int.Parse(Console.ReadLine());
                    }
                }

                else
                {
                    Console.WriteLine("Opçao inválida");
                    Console.ReadKey();
                }

                Console.Clear();

                Console.WriteLine("Digite a opção que desejar para entrar no programa correspondente:");

                Console.WriteLine("Programa 'A' - Repetição com senha");
                Console.WriteLine("Programa 'B' - Descubra o quadrante de um plano cartesiano");
                Console.WriteLine("Programa 'C' - Qual combustivel é o seu preferido?");

                Console.Write("Programa: ");
                opcao = char.Parse(Console.ReadLine());
                Console.Clear();
            }
        }
    }
}
