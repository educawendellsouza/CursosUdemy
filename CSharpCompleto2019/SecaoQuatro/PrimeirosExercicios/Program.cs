using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace PrimeirosExercicios
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Estrutura de exercicios da Seção 4");
            Console.WriteLine();

            Console.WriteLine("Aperte 'Enter' para iniciar");
            Console.ReadLine();
            Console.Clear();

            Console.WriteLine("Digite a opção que desejar para entrar no programa correspondente:");
            Console.WriteLine();

            Console.WriteLine("Programa 'A' - Qual a maior idade");
            Console.WriteLine("Programa 'B' - Qual a média dos salarios");
            //Console.WriteLine("Programa 'C' - Qual a media? WHILE");
            //Console.WriteLine("Programa 'D' - Qual a media? FOR");
            //Console.WriteLine("Programa 'E' - Dividindo dois números");
            //Console.WriteLine("Programa 'F' - Fatorial!");
            //Console.WriteLine("Programa 'G' - Quais são so divisiveis?");
            //Console.WriteLine("Programa 'H' - Imprimindo 'N' linhas");

            Console.WriteLine();
            Console.Write("Programa: ");
            char opcao = char.Parse(Console.ReadLine());

            while (opcao != 0)
            {
                if (opcao == 'A' || opcao == 'a')
                {
                    Console.Clear();
                    Console.WriteLine("Programa para ler os dados de duas pessoas, depois mostrar o nome da pessoa mais velha.");
                    Console.WriteLine();
                    Console.WriteLine("Pressiona qualquer tecla para iniciar o programa");
                    Console.ReadKey();
                    Console.Clear();

                    Pessoa pessoaA, pessoaB;

                    pessoaA = new Pessoa();

                    Console.WriteLine("Informe o nome da primeira pessoa e o sexo, sendo (M)asculino e (F)eminino");
                    Console.Write("Nome: ");
                    pessoaA.Nome = Console.ReadLine();
                    Console.Write("Sexo: ");
                    pessoaA.Genero = char.Parse(Console.ReadLine());

                    while (pessoaA.Genero != 'M' && pessoaA.Genero != 'F')
                    {
                        Console.Clear();
                        Console.WriteLine("Sexo divergente do programado.");
                        Console.WriteLine();
                        Console.WriteLine($"Nome: {pessoaA.Nome}");
                        Console.WriteLine("Selecione 'F' para Feminino e 'M' para Maculino");
                        Console.Write("Sexo: ");
                        pessoaA.Genero = char.Parse(Console.ReadLine());
                    }

                    Console.Clear();
                    Console.WriteLine("Informe a idade da primeira pessoa e o sexo, sendo (M)asculino e (F)eminino");
                    Console.Write("Idade: ");
                    pessoaA.Idade = int.Parse(Console.ReadLine());

                    Console.Clear();

                    pessoaB = new Pessoa();

                    Console.WriteLine("Informe o nome da segunda pessoa");
                    Console.Write("Nome: ");
                    pessoaB.Nome = Console.ReadLine();
                    Console.Write("Sexo: ");
                    pessoaB.Genero = char.Parse(Console.ReadLine());

                    while (pessoaB.Genero != 'M' && pessoaB.Genero != 'F')
                    {
                        Console.Clear();
                        Console.WriteLine("Sexo divergente do programado.");
                        Console.WriteLine();
                        Console.WriteLine($"Nome: {pessoaB.Nome}");
                        Console.WriteLine("Selecione 'F' para Feminino e 'M' para Maculino");
                        Console.Write("Sexo: ");
                        pessoaB.Genero = char.Parse(Console.ReadLine());
                    }

                    Console.Clear();
                    Console.WriteLine("Informe a idade da segunda pessoa"); ;
                    Console.Write("Idade: ");
                    pessoaB.Idade = int.Parse(Console.ReadLine());

                    Console.Clear();

                    Console.WriteLine("Na próxima tela, apresentaremos a pessoa de maior idade.");

                    Console.Clear();

                    if (pessoaA.Idade == pessoaB.Idade)
                    {
                        Console.WriteLine($"{pessoaA.Nome} tem a mesma idade que {pessoaB.Nome}. {pessoaA.Idade} anos.");
                    }
                    else if (pessoaA.Idade > pessoaB.Idade && pessoaA.Genero == 'M')
                    {
                        Console.WriteLine($"O {pessoaA.Nome} é o mais velho. Com {pessoaA.Idade} anos.");
                    }
                    else if (pessoaA.Idade > pessoaB.Idade && pessoaA.Genero == 'F')
                    {
                        Console.WriteLine($"O {pessoaA.Nome} é a mais velha. Com {pessoaA.Idade} anos.");
                    }
                    else if (pessoaA.Idade < pessoaB.Idade && pessoaB.Genero == 'M')
                    {
                        Console.WriteLine($"O {pessoaB.Nome} é o mais velho. Com {pessoaB.Idade} anos.");
                    }
                    else
                    {
                        Console.WriteLine($"O {pessoaB.Nome} é a mais velha. Com {pessoaB.Idade} anos.");
                    }
                    Console.ReadKey();
                    Console.Clear();
                    Console.WriteLine("Aperte qualquer tecla para sair do programa.");
                    Console.ReadKey();
                }

                else if (opcao == 'B' || opcao == 'b')
                {
                    Console.Clear();
                    Console.WriteLine("Programa que define a média entre os salarios de dois Funcionários pessoas");
                    Console.WriteLine();
                    Console.WriteLine("Pressiona qualquer tecla para iniciar o programa");
                    Console.ReadKey();
                    Console.Clear();

                    Pessoa pessoaA, pessoaB;

                    pessoaA = new Pessoa();
                    Console.WriteLine("Dados do Primeiro Funcionário");
                    Console.Write("Nome: ");
                    pessoaA.Nome = Console.ReadLine();
                    Console.Write("Salario: ");
                    pessoaA.Salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    Console.WriteLine();

                    pessoaB = new Pessoa();
                    Console.WriteLine("Dados do Segundo Funcionário");
                    Console.Write("Nome: ");
                    pessoaB.Nome = Console.ReadLine();
                    Console.Write("Salario: ");
                    pessoaB.Salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    double salario = (pessoaA.Salario + pessoaB.Salario) / 2;

                    Console.Clear();

                    Console.WriteLine($"O Salario médio é {salario.ToString("F2", CultureInfo.InvariantCulture)}");
                    Console.ReadKey();
                }
            }
        }
    }
}
