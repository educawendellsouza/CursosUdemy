using System;
using System.Globalization;

namespace Funcionario
{
    class Program
    {
        static void Main(string[] args)
        {
            FuncionarioPessoa f = new FuncionarioPessoa();

            Console.Write("Nome: ");
            f.Nome = Console.ReadLine();
            Console.WriteLine("");
            Console.Write("Salário bruto: ");
            f.SalarioBruto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("");
            Console.Write("Imposto: ");
            f.Imposto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Clear();

            Console.WriteLine("Funcionário: {0}, R$ {1}", f.Nome, f.SalarioLiquido().ToString(("F2"), CultureInfo.InvariantCulture));

            Console.ReadKey();
            Console.Clear();

            Console.Write("Digite a porcentagem para aumentar o salário: ");
            f.AumentarSalario(double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture));

            Console.WriteLine("Dados Atualizados: {0}, R$ {1}", f.Nome, f.SalarioBruto.ToString(("F2"), CultureInfo.InvariantCulture));
        }
    }
}
