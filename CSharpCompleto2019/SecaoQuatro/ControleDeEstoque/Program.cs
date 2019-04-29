using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            p.Preco = int.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.Write("Quantidade em Estoque: ");
            p.QuantidadeEmEstoque = int.Parse(Console.ReadLine());

            Console.WriteLine($"Dados do produto: ");
        }
    }
}
