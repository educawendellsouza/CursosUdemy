using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Exercicio01
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
            Console.WriteLine("Programa 'A' - [EXERCICIO 01]Soma de entradas definidas no exercicio.");
            Console.WriteLine("Programa 'B' - Programa para calcular a SOMA entre dois valores.");
            Console.WriteLine("Programa 'C' - [EXERCICIO 02]Valor do Raio de um Circulo com valores definidos no exercicio.");
            Console.WriteLine("Programa 'D' - Programa para ver o valor do Raio de um Circulo.");
            Console.WriteLine("Programa 'E' - [EXERCICIO 03]Diferença de produtos");
            Console.WriteLine("Programa 'F' - Programa para calcular a diferenca do produto de quatro numeros.");
            Console.WriteLine("Programa 'G' - Leitura e impressão de dados dos funcionários da empresa");
            Console.WriteLine("Programa 'H' - Leitura e impressão de dados dos produtos de uma empresa.");
            Console.WriteLine("Programa 'I' - Valores com ponto flutuante de dupla precisão.");


            char opcao = char.Parse(Console.ReadLine());
            Console.Clear();

            if (opcao == 'A' || opcao == 'a')
            {
                Console.WriteLine("Opção 'A' Selecionada - Soma de entradas definidas no exercicio.");
                Console.WriteLine("");
                Console.WriteLine("O Programa irá ler dois valores inteiros, e depois mostrar na " +
                                  "tela a soma desses números com uma mensagem explicativa.");
                Console.WriteLine("");
                Console.WriteLine("Aperte 'Enter' para iniciar a apresentação do programa.");

                Console.ReadLine();
                Console.Clear();

                Console.WriteLine("Exemplo 1 de 3");
                Console.WriteLine("Exemplo 1");
                int valorAExemplo1 = 10;
                int valorBExemplo1 = 30;
                int totalExemplo1 = valorAExemplo1 + valorBExemplo1;
                Console.WriteLine($"O valor do 1º número inteiro é {valorAExemplo1}. " +
                                  $"O valor do 2º número inteiro é {valorBExemplo1}. " +
                                  $"A soma dos dois valores é igual à {totalExemplo1}.");

                Console.ReadLine();
                Console.Clear();
                Console.WriteLine("Aperte 'Enter' para iniciar a apresentação do Exemplo 2");
                Console.ReadLine();
                Console.Clear();

                Console.WriteLine("Exemplo 2 de 3");
                Console.WriteLine("Exemplo 2");
                int valorAExemplo2 = -30;
                int valorBExemplo2 = 10;
                int totalExemplo2 = valorAExemplo2 + valorBExemplo2;
                Console.WriteLine($"O valor do 1º número inteiro é {valorAExemplo2}. " +
                                  $"O valor do 2º número inteiro é {valorBExemplo2}. " +
                                  $"A soma dos dois valores é igual à {totalExemplo2}. ");

                Console.ReadLine();
                Console.Clear();
                Console.WriteLine("Aperte 'Enter' para iniciar a apresentação do Exemplo 3");
                Console.ReadLine();
                Console.Clear();

                Console.WriteLine("Exemplo 3 de 3");
                Console.WriteLine("Exemplo 3");
                int valorAExemplo3 = 0;
                int valorBExemplo3 = 0;
                int totalExemplo3 = valorAExemplo3 + valorBExemplo3;
                Console.WriteLine($"O valor do 1º número inteiro é {valorAExemplo3}. " +
                                  $"O valor do 2º número inteiro é {valorBExemplo3}. " +
                                  $"A soma dos dois valores é igual à {totalExemplo3}. ");
            }

            else if (opcao == 'B' || opcao == 'b')
            {
                Console.WriteLine("Opção 'B' Selecionada - Programa para calcular a SOMA entre dois valores.");
                Console.WriteLine("");
                Console.WriteLine("Programa para ler dois valores inteiros, e depois mostrar na " +
                                  "tela a soma desses números com uma mensagem explicativa.");
                Console.WriteLine("");
                Console.WriteLine("Aperte 'Enter' para iniciar o programa");
                Console.ReadLine();
                Console.Clear();

                Console.WriteLine("Digite o Primeiro Valor e aperte 'Enter'");
                long x = long.Parse(Console.ReadLine());
                Console.Clear();

                Console.WriteLine("Digite o Segundo Valor e aperte 'Enter' para obter o resultado");
                long y = long.Parse(Console.ReadLine());
                Console.Clear();

                long soma = x + y;

                Console.WriteLine("A soma dos dois valores é " + soma);
            }

            else if (opcao == 'C' || opcao == 'c')
            {
                Console.WriteLine("Opção 'C' Selecionada - Valor do Raio de um Circulo com valores definidos no exercicio.");
                Console.WriteLine("");
                Console.WriteLine("Programa para ler o valor do raio de um círculo," +
                                  " e depois mostrar o valor da área deste círculo com quatro " +
                                  "casas decimais.");
                Console.WriteLine("");
                Console.WriteLine("Aperte 'Enter' para iniciar a apresentação do programa");

                double π = 3.14159;

                Console.ReadLine();
                Console.Clear();

                Console.WriteLine("Exemplo 1 de 3");
                Console.WriteLine("Exemplo 1");
                double raioExemplo1 = 2.00;
                double areaExemplo1 = π * (raioExemplo1 * raioExemplo1);
                Console.WriteLine($"O valor do Raio é {raioExemplo1.ToString("F2")}. " +
                                  $"O valor da Área é {areaExemplo1.ToString("F4")}. ");

                Console.ReadLine();
                Console.Clear();
                Console.WriteLine("Aperte 'Enter' para iniciar a apresentação do Exemplo 2");
                Console.ReadLine();
                Console.Clear();

                Console.WriteLine("Exemplo 2 de 3");
                Console.WriteLine("Exemplo 2");
                double raioExemplo2 = 100.64;
                double areaExemplo2 = π * (raioExemplo2 * raioExemplo2);
                Console.WriteLine($"O valor do Raio é {raioExemplo2.ToString("F2")}. " +
                                  $"O valor da Área é {areaExemplo2.ToString("F4")}. ");

                Console.ReadLine();
                Console.Clear();
                Console.WriteLine("Aperte 'Enter' para iniciar a apresentação do Exemplo 3");
                Console.ReadLine();
                Console.Clear();

                Console.WriteLine("Exemplo 3 de 3");
                Console.WriteLine("Exemplo 3");
                double raioExemplo3 = 150.00;
                double areaExemplo3 = π * (raioExemplo3 * raioExemplo3);
                Console.WriteLine($"O valor do Raio é {raioExemplo3.ToString("F2")}. " +
                                  $"O valor da Área é {areaExemplo3.ToString("F4")}. ");
            }

            else if (opcao == 'D' || opcao == 'd')
            {
                Console.WriteLine("Opção 'D' Selecionada - Programa para ver o valor do Raio de um Circulo.");
                Console.WriteLine("");
                Console.WriteLine("O programa lê o valor do raio de um círculo," +
                                  " e depois mostrar o valor da área deste círculo " +
                                  "com quatro casas decimais.");
                Console.WriteLine("");
                Console.WriteLine("Aperte 'Enter' para iniciar o programa.");
                Console.ReadLine();
                Console.Clear();

                double π = Math.PI;

                Console.WriteLine("Entre com o valor do DIAMETRO (em Centimetros) do circulo e aperte 'Enter'.");
                double diametro = double.Parse(Console.ReadLine());

                double raio = diametro / 2;

                double area = (raio * raio) * π / 100;

                Console.Clear();

                Console.WriteLine($"O valor do raio inserido foi {raio.ToString("F2")} cm. " +
                                  $"Sendo assim, o valor da ÁREA é {area.ToString("F4")} m². ");
            }

            else if (opcao == 'E' || opcao == 'e')
            {
                Console.WriteLine("Opção 'E' Selecionada - Programa para exibir a Diferença de produtos definidos no exercicio.");
                Console.WriteLine("");
                Console.WriteLine("O programa lê quatro valores inteiros A, B, C e D. " +
                                  "A seguir, calcula e mostre a diferença do produto de " +
                                  "A e B pelo produto de C e D segundo a fórmula: " +
                                  "DIFERENCA = (A * B - C * D). ");
                Console.WriteLine("");
                Console.WriteLine("Aperte 'Enter' para iniciar o programa.");
                Console.ReadLine();
                Console.Clear();

                Console.WriteLine("Exemplo 1 de 2");
                Console.ReadLine();
                Console.Clear();

                Console.WriteLine("Exemplo 1");

                int a = 5, b = 6, c = 7, d = 8;
                int diferencaExemplo1 = (a * b - c * d);

                Console.WriteLine($"O primeiro valor é {a.ToString("F0")}. " +
                                  $"O segundo valor é {b.ToString("F0")}. " +
                                  $"O terceiro valor é {c.ToString("F0")}. " +
                                  $"O quarto valor é {d.ToString("F0")}. ");

                Console.ReadLine();
                Console.Clear();

                Console.WriteLine($"O valor da diferença entre os produtos é {diferencaExemplo1.ToString("F0")}.");

                Console.ReadLine();
                Console.Clear();

                Console.WriteLine("Exemplo 2 de 2");
                Console.ReadLine();
                Console.Clear();

                Console.WriteLine("Exemplo 2");

                int e = 5, f = 6, g = -7, h = 8;
                int diferencaExemplo2 = (e * f - g * h);

                Console.WriteLine($"O valor de E é {e.ToString("F0")}. " +
                                  $"O valor de F é {f.ToString("F0")}. " +
                                  $"O valor de G é {g.ToString("F0")}. " +
                                  $"O valor de H é {h.ToString("F0")}. ");

                Console.ReadLine();
                Console.Clear();

                Console.WriteLine($"O valor da diferença entre os produtos é {diferencaExemplo2.ToString("F0")}.");

                Console.ReadLine();
                Console.Clear();

            }

            else if (opcao == 'F' || opcao == 'f')
            {
                int a = 0, b = 0, c = 0, d = 0, diferenca = 0;
                char pronto;

                Console.WriteLine("Opção 'F' Selecionada - Programa para calcular a diferenca do produto de quatro numeros.");
                Console.WriteLine("");
                Console.WriteLine("O programa lê quatro valores inteiros A, B, C e D. " +
                                  "A seguir, calcula e mostre a diferença do produto de " +
                                  "A e B pelo produto de C e D segundo a fórmula: " +
                                  "DIFERENCA = (A * B - C * D). ");
                Console.WriteLine("");
                Console.WriteLine("Aperte 'Enter' para iniciar o programa.");
                Console.ReadLine();
                Console.Clear();

                Console.WriteLine("Digite os quatro números, para preencher os campos das variáveis abaixo:");
                Console.WriteLine("(A x B) - (C x D)");
                Console.ReadLine();

                Console.WriteLine("Defina, na ordem, as letras de A à D.");
                Console.ReadLine();
                Console.Clear();

                Console.WriteLine("Vamos definir o valor da letra A.");
                Console.WriteLine("(A x B) - (C x D)");
                Console.WriteLine("");
                Console.Write("A = "); a = int.Parse(Console.ReadLine());
                Console.Clear();
                Console.WriteLine("Novo valor de definido para: A.");
                Console.WriteLine($"({a} x B) - (C x D)");
                Console.ReadLine();
                Console.Clear();

                Console.WriteLine("Vamos definir o valor da letra B.");
                Console.WriteLine($"({a} x B) - (C x D)");
                Console.WriteLine("");
                Console.Write("B = "); b = int.Parse(Console.ReadLine());
                Console.Clear();
                Console.WriteLine("Novo valor de definido para: B.");
                Console.WriteLine($"({a} x {b}) - (C x D)");
                Console.ReadLine();
                Console.Clear();


                Console.WriteLine("Vamos definir o valor da letra C.");
                Console.WriteLine($"({a} x {b}) - (C x D)");
                Console.WriteLine("");
                Console.Write("C = "); c = int.Parse(Console.ReadLine());
                Console.Clear();
                Console.WriteLine("Novo valor de definido para: C.");
                Console.WriteLine($"({a} x {b}) - ({c} x D)");
                Console.ReadLine();
                Console.Clear();


                Console.WriteLine("Vamos definir o valor da letra D.");
                Console.WriteLine($"({a} x {b}) - ({c} x D)");
                Console.WriteLine("");
                Console.Write("D = "); d = int.Parse(Console.ReadLine());
                Console.Clear();
                Console.WriteLine("Novo valor de definido para: D.");
                Console.WriteLine($"({a} x {b}) - ({c} x {d})");
                Console.ReadLine();
                Console.Clear();

                Console.WriteLine("Valores definidos. Você esta pronto para ver a diferença entre os produtos?");
                Console.WriteLine("S/ Sim | N/ Não");

                pronto = char.Parse(Console.ReadLine());

                if (pronto == 's' || pronto == 'S')
                {
                    Console.WriteLine("Tem certeza que você esta pronto?");
                    pronto = char.Parse(Console.ReadLine());

                    if (pronto == 's' || pronto == 'S')
                    {
                        Console.Clear();
                        diferenca = (a * b - c * d);
                        Console.WriteLine($"({a} x {b}) - ({c} x {d})");
                        Console.WriteLine();
                        Console.WriteLine($"A diferença entre os produtos é de: {diferenca}");
                    }
                    else
                    {
                        return;
                    }
                }

                else
                {
                    return;
                }

            }

            else if (opcao == 'G' || opcao == 'g')
            {
                Console.WriteLine("Opção 'G' Selecionada - Leitura e impressão de dados dos funcionários da empresa.");
                Console.WriteLine("");
                Console.WriteLine("O programa lê o número de um funcionário, " +
                                  "seu número de horas trabalhadas, o valor que recebe por hora e calcula o salário desse funcionário. " +
                                  "A seguir, mostre o número e o salário do funcionário, com duas casas decimais.");
                Console.WriteLine("");
                Console.WriteLine("Aperte 'Enter' para iniciar o programa.");
                Console.ReadLine();
                Console.Clear();

                Console.WriteLine("Digite o codigo do funcionário.");
                Console.WriteLine("");
                Console.WriteLine("Ex.: 25");
                Console.Write("Código: ");
                int codigoDoFuncionario = int.Parse(Console.ReadLine());
                Console.Clear();

                Console.WriteLine("Digite o número de horas trabalhadas");
                Console.WriteLine("");
                Console.WriteLine("Ex.: 100.00");
                Console.Write("Número de horas trabalhadas: ");
                double numeroDeHorasTrabalhadas = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                Console.WriteLine("Digite o valor que esse funcionario recebe por hora");
                Console.WriteLine("");
                Console.WriteLine("Ex.: R$300.00");
                Console.Write("Valor recebido por hora: R$");
                double valorRecebidoPorHoraTrabalhada = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Clear();

                double salario = numeroDeHorasTrabalhadas * valorRecebidoPorHoraTrabalhada;

                Console.WriteLine($"O valor que o funcionário {codigoDoFuncionario} " +
                                  $"deve receber no mês é: R${salario.ToString("F2")}.");

                Console.ReadLine();
                Console.Clear();
            }

            else if (opcao == 'H' || opcao == 'h')
            {
                Console.WriteLine("Opção 'H' Selecionada - Leitura e impressão de dados dos produtos de uma empresa.");
                Console.WriteLine("");
                Console.WriteLine("O programa deverá ler o código de uma peça 1, " +
                                  "o número de peças 1, o valor unitário de cada peça 1, " +
                                  "o código de uma peça 2, o número de peças 2 e o valor unitário de cada peça 2. " +
                                  "Calcule e mostre o valor a ser pago.");
                Console.WriteLine("");
                Console.WriteLine("Aperte 'Enter' para iniciar o programa.");
                Console.ReadLine();
                Console.Clear();

                Console.WriteLine("Entre com o codigo da peça, " +
                                  "o número de peças, " +
                                  "o valor unitário de cada peça. ");
                string[] primeiraPeca = Console.ReadLine().Split(' ');
                string codigoDaPeca = primeiraPeca[0];
                int numeroDePecas = int.Parse(primeiraPeca[1]);
                double valorUnitariodeCadaPeca = double.Parse(primeiraPeca[2], CultureInfo.InvariantCulture);

                string[] segundaPeca = Console.ReadLine().Split(' ');
                string codigoDaSegundaPeca = segundaPeca[0];
                int numeroDePecasDaSegunda = int.Parse(segundaPeca[1]);
                double valorUnitariDaSegundaPeca = double.Parse(segundaPeca[2], CultureInfo.InvariantCulture);

                Console.Clear();

                double valorTotalASerPago = (numeroDePecas * valorUnitariodeCadaPeca)
                                          + (numeroDePecasDaSegunda * valorUnitariDaSegundaPeca);
                Console.WriteLine("O Valor a ser pago é R$" + valorTotalASerPago.ToString("F2") + ".");
            }

            else if (opcao == 'I' || opcao == 'i')
            {
                Console.WriteLine("Opção 'I' Selecionada - Valores com ponto flutuante de dupla precisão.");
                Console.WriteLine("");
                Console.WriteLine("O programa deverá ler três valores com ponto flutuante de dupla precisão: A, B e C. " +
                                  "Em seguida, deverá calcular e mostrar: ");
                Console.WriteLine("a) a área do triângulo retângulo que tem A por base e C por altura.");
                Console.WriteLine("b) a área do círculo de raio C. (pi = 3.14159)");
                Console.WriteLine("c) a área do trapézio que tem A e B por bases e C por altura.");
                Console.WriteLine("d) a área do quadrado que tem lado B.");
                Console.WriteLine("e) a área do retângulo que tem lados A e B.");

                Console.WriteLine("");
                Console.WriteLine("Aperte 'Enter' para iniciar o programa.");
                Console.ReadLine();
                Console.Clear();

                Console.WriteLine("Entre com os valores de dupla precisão.");
                string[] valores = Console.ReadLine().Split(' ');
                double a = double.Parse(valores[0], CultureInfo.InvariantCulture);
                double b = double.Parse(valores[1], CultureInfo.InvariantCulture);
                double c = double.Parse(valores[2], CultureInfo.InvariantCulture);

                double triangulo = a * c / 2;
                double circulo = Math.PI * (c * c);
                double trapezio = (a + b) * c / 2;
                double quadrado = b * b;
                double retangulo = a * b;

                Console.Clear();

                Console.WriteLine($"TRIANGULO = {triangulo.ToString("F3")} ");
                Console.WriteLine($"CIRCULO = {circulo.ToString("F3")} ");
                Console.WriteLine($"TRAPEZIO = {trapezio.ToString("F3")} ");
                Console.WriteLine($"QUADRADO = {quadrado.ToString("F3")} ");
                Console.WriteLine($"RETANGULO = {retangulo.ToString("F3")} ");

            }

            else
            {
                Console.WriteLine("Entrada invalida, pressione 'Enter' para sair.");
                Console.ReadLine();
            }
        }
    }
}
