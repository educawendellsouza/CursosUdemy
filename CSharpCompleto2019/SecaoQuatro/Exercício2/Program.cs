using System;
using System.Globalization;

namespace Exercício2
{
    class Program
    {
        static void Main(string[] args)
        {
            Funcionario f = new Funcionario();

            Console.Write("Digite o nome do Funcionário(a): ");
            f.Nome = Console.ReadLine();

            Console.WriteLine();

            Console.Write("Digite o seu salário bruto: R$ ");
            f.SalarioBruto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture); //Digitando com ponto ou virgula para dividir as casas decimais

            Console.WriteLine(); ;

            Console.Write("Digite o valor do imposto que é cobrado: R$ ");
            f.Imposto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture); //Digitando com ponto ou virgula para dividir as casas decimais

            f.SalarioLiquido();
            Console.Clear();

            Console.WriteLine(f);
            Console.ReadKey();
            Console.Clear();

            Console.WriteLine("Escolha a opção que você deseja: ");
            Console.WriteLine("Opção A: Previsão de quanto o funcionário deverá ter de aumento");
            Console.WriteLine("Opção B: Aumentar o salário do Funcionário");
            Console.WriteLine("Opção C: Mostrar na tela a atual situação do Funcionário(a)");

            Console.Write("Digite quanto que o funcionário deverá ganhar: R$ ");
            f.NovoSalario(double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture));
            Console.WriteLine(f.Aumento + " %");

            Console.ReadKey();
            Console.Clear();

            Console.Write("Digite a porcentagem para aumentar o salario: ");
            f.AumentarSalarioEmPorcentagem(double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture));

            Console.Clear();

            Console.WriteLine(f);
            Console.ReadKey();

        }
    }
}
