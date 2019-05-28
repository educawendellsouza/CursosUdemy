using System;
using System.Globalization;

namespace ControleDeEstoque
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto p = new Produto();

            Console.WriteLine("Entre com os dados do produto: ");
            Console.WriteLine();
            Console.Write("Nome: ");
            p.Nome = Console.ReadLine();
            Console.WriteLine();
            Console.Write("Preço: ");
            p.Preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine();
            Console.Write("Quantidade em Estoque: ");
            p.Quantidade = int.Parse(Console.ReadLine());

            Console.Clear();

            Console.WriteLine($"Dados do produto: " + p);
            Console.ReadKey();
        }
    }
}
