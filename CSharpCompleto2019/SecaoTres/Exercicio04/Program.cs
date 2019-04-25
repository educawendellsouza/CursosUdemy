using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Exercicio04
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Exercícios sobre Estrutura Repetitiva FOR");
            Console.WriteLine();

            Console.WriteLine("Opções de exercicios corrigidos");
            Console.WriteLine("Aperte 'Enter' para iniciar");
            Console.ReadLine();
            Console.Clear();

            Console.WriteLine("Digite a opção que desejar para entrar no programa correspondente:");
            Console.WriteLine();

            Console.WriteLine("Programa 'A' - Mostre os numeros ímpares");
            Console.WriteLine("Programa 'B' - Descubra os pertencentes do intervalo");
            Console.WriteLine("Programa 'C' - Qual a media? WHILE");
            Console.WriteLine("Programa 'D' - Qual a media? FOR");
            Console.WriteLine("Programa 'E' - Dividindo dois números");
            Console.WriteLine("Programa 'F' - Fatorial!");
            Console.WriteLine("Programa 'G' - Quais são so divisiveis?");
            Console.WriteLine("Programa 'H' - Imprimindo 'N' linhas");

            Console.WriteLine();
            Console.Write("Programa: ");
            char opcao = char.Parse(Console.ReadLine());
            Console.Clear();

            while (opcao != 0)
            {
                if (opcao == 'A' || opcao == 'a')
                {
                    Console.WriteLine("Leia um valor inteiro X (1 <= X <= 1000). Em seguida mostre os ímpares de" +
                                      " 1 até X, um valor por linha, inclusive o X, se for o caso.");
                    Console.WriteLine();
                    Console.Write("X = ");

                    int x = int.Parse(Console.ReadLine());
                    int y = 0;
                    int impar = 0;


                    Console.WriteLine($"Os numeros ímpares de {y} até {x} são os: ");
                    Console.WriteLine();

                    while (x >= y)
                    {
                        impar = y % 2;
                        if (impar != 0)
                        {
                            Console.WriteLine(y);
                        }
                        y++;
                    }
                    Console.ReadKey();
                    Console.Clear();
                }

                else if (opcao == 'B' || opcao == 'b')
                {
                    int numeroMaior = 0;
                    int numeroMenor = 0;

                    Console.WriteLine("Leia um valor inteiro N. Este valor será a quantidade de valores inteiros X " +
                                      "que serão lidos em seguida. Mostre quantos destes valores X estão dentro do " +
                                      "intervalo[10, 20] e quantos estão fora do intervalo, mostrando essas informações " +
                                      "conforme exemplo (use a palavra 'in' para dentro do intervalo, e 'out' para fora " +
                                      "do intervalo).");

                    Console.WriteLine();

                    Console.WriteLine("Informe a quantidade de numeros inteiros que você vai querer verificar se estão " +
                                      "ou não no intervalo especificado");
                    Console.Write("N = ");
                    int n = int.Parse(Console.ReadLine());
                    Console.Clear();

                    Console.Write("Informe o primeiro número do intervalo: ");
                    int primeiroNumeroDoIntervalo = int.Parse(Console.ReadLine());
                    Console.Clear();

                    Console.Write("Informe o segundo número do intervalo: ");
                    int segundoNumeroDoIntervalo = int.Parse(Console.ReadLine());
                    Console.Clear();

                    if (primeiroNumeroDoIntervalo > segundoNumeroDoIntervalo)
                    {
                        numeroMaior = primeiroNumeroDoIntervalo;
                        numeroMenor = segundoNumeroDoIntervalo;
                    }
                    else
                    {
                        numeroMaior = segundoNumeroDoIntervalo;
                        numeroMenor = primeiroNumeroDoIntervalo;
                    }

                    int limiteDeN = 1;
                    int dentro = 0;
                    int fora = 0;

                    while (n >= limiteDeN)
                    {
                        Console.Clear();
                        Console.WriteLine($"informe o número para ser analisado. {limiteDeN} de {n}.");
                        Console.WriteLine();
                        Console.Write("Digite o numero " + limiteDeN + " para ser analizado :");
                        int entrada = int.Parse(Console.ReadLine());

                        if (entrada <= numeroMaior && entrada >= numeroMenor)
                        {
                            dentro++;
                        }
                        else
                        {
                            fora++;
                        }
                        limiteDeN++;
                    }
                    Console.Clear();
                    Console.WriteLine($"{dentro} in.");
                    Console.WriteLine($"{fora} out.");
                    Console.ReadKey();
                }

                else if (opcao == 'C' || opcao == 'c')
                {
                    Console.WriteLine("Leia 1 valor inteiro N, que representa o número de casos de teste que vem " +
                                      "a seguir. Cada caso de teste consiste de 3 valores reais, cada um deles " +
                                      "com uma casa decimal. Apresente a média ponderada para cada um destes conjuntos " +
                                      "de 3 valores, sendo que o primeiro valor tem peso 2, o segundo valor tem peso " +
                                      "3 e o terceiro valor tem peso 5.");

                    Console.WriteLine();

                    Console.WriteLine("Informe a quantidade de números que você vai querer tirar a média.");

                    Console.Write("Quantos números vao ter a média ponderada? = ");
                    int n = int.Parse(Console.ReadLine());
                    Console.Clear();

                    int limiteDeN = 1;
                    double soma = 0;
                    double media = 0;

                    while (n >= limiteDeN)
                    {
                        Console.Clear();
                        Console.WriteLine($"informe o número para ser analisado. {limiteDeN} de {n}.");
                        Console.WriteLine();
                        Console.Write("Digite o numero " + limiteDeN + " para ser analizado: ");
                        double entrada = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                        soma += entrada;

                        limiteDeN++;
                    }
                    Console.Clear();
                    media = soma / n;
                    Console.WriteLine($"A média ponderada dos valores digitados são: {media.ToString("F1", CultureInfo.InvariantCulture)} ");
                    Console.ReadKey();

                }

                else if (opcao == 'D' || opcao == 'd')
                {
                    Console.WriteLine("Leia 1 valor inteiro N, que representa o número de casos de teste que vem " +
                                      "a seguir. Cada caso de teste consiste de N valores reais, cada um deles " +
                                      "com uma casa decimal. Apresente a média ponderada para cada um destes conjuntos " +
                                      "de N valores, sendo que o primeiro valor tem peso Peso1, o segundo valor tem Peso2 " +
                                      "e o terceiro valor tem peso3.");

                    Console.WriteLine();

                    Console.WriteLine("Informe a quantidade de números que você vai querer tirar a média.");

                    Console.Write("Quantos números vao ter a média ponderada? ");
                    int n = int.Parse(Console.ReadLine());
                    Console.Clear();

                    double soma = 0;
                    double media = 0;
                    double somaDaMedia = 0;

                    for (int i = 1; n >= i; i++)
                    {
                        double x = 0;
                        Console.Clear();
                        Console.WriteLine($"informe o primeiro valor para ser analisado. Valor {i} de {n}.");
                        Console.WriteLine();
                        Console.Write("Digite o valor " + i + " para ser analizado: ");
                        double entrada = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                        Console.Clear();

                        Console.WriteLine($"informe o que esse valor tem. Peso {i} de {n}.");
                        Console.WriteLine();
                        Console.WriteLine("Nota: Peso 0 implica em 'Zerar' o valor.");
                        Console.WriteLine();
                        Console.Write("Informe o valor do peso: ");
                        int peso = int.Parse(Console.ReadLine());
                        Console.Clear();

                        while (peso == 0)
                        {
                            Console.WriteLine("Peso 0 não é aceitado.");
                            Console.WriteLine();
                            Console.Write("Informe o valor do peso: ");
                            peso = int.Parse(Console.ReadLine());
                            Console.Clear();
                        }

                        x = entrada * peso;
                        soma += x;
                        somaDaMedia += peso;
                    }
                    Console.Clear();
                    media = soma / somaDaMedia;
                    Console.WriteLine($"A média ponderada dos valores digitados são: {media.ToString("F1", CultureInfo.InvariantCulture)} ");
                    Console.ReadKey();
                }

                else if (opcao == 'E' || opcao == 'e')

                {
                    Console.WriteLine("Digite o numero de divisões que você vai efetuar");
                    Console.WriteLine();
                    int n = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    for (int x = 1; n >= x; x++)
                    {
                        Console.Clear();
                        Console.WriteLine("Digite um número seguido do outro para fazer a divisão");
                        Console.WriteLine();
                        Console.WriteLine("Exemplos: 10/-2 ");
                        Console.WriteLine();
                        Console.WriteLine($"Divisão {x} de {n}");
                        Console.WriteLine();
                        Console.Write("Divisão: ");
                        string[] numerosDaDivisao = Console.ReadLine().Split('/');
                        double dividendo = double.Parse(numerosDaDivisao[0], CultureInfo.InvariantCulture);
                        double divisor = double.Parse(numerosDaDivisao[1], CultureInfo.InvariantCulture);

                        double resultado = dividendo / divisor;
                        double resto = dividendo % divisor;

                        if (divisor == 0)
                        {
                            Console.WriteLine("Divisão Impossivel");
                            Console.ReadKey();
                        }
                        else if (resto != 0)
                        {
                            Console.Clear();
                            Console.WriteLine("Divisão não exata");
                            Console.WriteLine();
                            Console.WriteLine($"{dividendo.ToString("F2", CultureInfo.InvariantCulture)} dividido por " +
                                              $"{divisor.ToString("F2", CultureInfo.InvariantCulture)} " +
                                              $"é igual à: {resultado.ToString("F2", CultureInfo.InvariantCulture)}");
                            Console.ReadKey();
                        }
                        else
                        {
                            Console.Clear();
                            Console.WriteLine($"{dividendo.ToString("F2", CultureInfo.InvariantCulture)} dividido por " +
                                              $"{divisor.ToString("F2", CultureInfo.InvariantCulture)} " +
                                              $"é igual à: {resultado.ToString("F2", CultureInfo.InvariantCulture)}");
                            Console.ReadKey();
                        }
                    }
                }

                else if (opcao == 'F' || opcao == 'f')
                {
                    Console.WriteLine("Digite um número inteiro para descobrir o seu fatorial");
                    Console.WriteLine();
                    int n = int.Parse(Console.ReadLine());

                    int fatorial = 1; // Não pode ser 0 pois o fatorial não multiplica por 0

                    if (n == 1)
                    {
                        Console.WriteLine($"{n}! = 1");
                    }

                    else
                    {
                        for (int x = 1; x <= n; x++)
                        {
                            Console.Clear();
                            fatorial *= x;
                        }
                        Console.WriteLine($"{n}! = {fatorial}");
                        Console.ReadKey();
                    }

                }

                else if (opcao == 'G' || opcao == 'g')
                {
                    Console.WriteLine("Informe um número para o programa retonar os divisiveis por ele");
                    Console.WriteLine();
                    Console.Write("Número: ");
                    int n = int.Parse(Console.ReadLine());
                    Console.Clear();

                    Console.WriteLine("Os divisiveis são: ");
                    for (int i = 1; n >= i; i++)
                    {
                        double divisor = n % i;
                        if (divisor != 0) { }
                        else
                        {
                            Console.WriteLine(i);
                        }
                    }
                    Console.ReadKey();
                }

                else if (opcao == 'H' || opcao == 'h')
                {
                    Console.WriteLine("Programa para ler um número inteiro positivo N. " +
                                      "O programa deve então mostrar na tela N linhas, começando de 1 até N. " +
                                      "Para cada linha, mostrar o número da linha, depois o quadrado e o cubo do valor, " +
                                      "conforme exemplo");
                    Console.WriteLine();
                    Console.Write("Informe o numero Inteiro Positivo: ");
                    int n = int.Parse(Console.ReadLine());
                    Console.Clear();

                    while (n < 0)
                    {
                        Console.Write("Informe o numero Inteiro Positivo: ");
                        n = int.Parse(Console.ReadLine());
                        Console.Clear();
                    }

                    Console.WriteLine("Saída: ");
                    for (int i = 1; n >= i; i++)
                    {
                        Console.Write(i + " ");
                        int quadrado = i * i;
                        Console.Write(quadrado + " ");
                        int cubo = i * i * i;
                        Console.Write(cubo);
                        Console.WriteLine();
                    }
                    Console.ReadKey();
                }

                else
                {
                    Console.WriteLine("Entrada invalida");
                    Console.Clear();
                }

                Console.Clear();
                Console.WriteLine("Digite a opção que desejar para entrar no programa correspondente:");
                Console.WriteLine();

                Console.WriteLine("Programa 'A' - Mostre os numeros ímpares");
                Console.WriteLine("Programa 'B' - Descubra os pertencentes do intervalo");
                Console.WriteLine("Programa 'C' - Qual a media?");
                Console.WriteLine("Programa 'D' - Qual a media? FOR");
                Console.WriteLine("Programa 'E' - Dividindo dois números");
                Console.WriteLine("Programa 'F' - Fatorial!");
                Console.WriteLine("Programa 'G' - Quais são so divisiveis?");
                Console.WriteLine("Programa 'H' - Imprimindo 'N' linhas");

                Console.WriteLine();
                Console.Write("Programa: ");
                opcao = char.Parse(Console.ReadLine());
                Console.Clear();
            }
        }
    }
}
