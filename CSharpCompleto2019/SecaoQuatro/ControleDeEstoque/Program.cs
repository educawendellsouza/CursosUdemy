using System;
using System.Globalization;

namespace ControleDeEstoque
{
    class Program
    {      
        static void Main(string[] args)
        {
            char opcao;
            EstoqueFisico estoque = new EstoqueFisico();
            estoque.Carregar();

            Console.WriteLine("Controle de Estoque - (" + estoque.Estoque.Count + ")");
            Console.Write("");
            Console.WriteLine("Digite a opção que deseja");
            Console.WriteLine();
            Console.WriteLine("Opção A - Cadastrar Produto em Estoque");
            Console.WriteLine("Opção B - Adicionar Produto em Estoque");
            Console.WriteLine("Opção C - Remover Produto em Estoque");
            Console.WriteLine("Opção D - Verificar Produtos em Estoque");
            Console.WriteLine("Opção E - Verificar Valor total em produtos no Estoque");
            Console.Write("Opção: ");
            opcao = char.Parse(Console.ReadLine());

            while(opcao != 0)
            {
                Produto p = new Produto();
                Console.Clear();
                if(opcao == 'A' || opcao == 'a')
                {
                    Console.Clear();

                    Console.WriteLine("Entre com os dados do produto a ser inserido no Estoque");
                    Console.WriteLine();
                    Console.Write("Nome do Produto: ");
                    p.Nome = Console.ReadLine();
                    Console.WriteLine();
                    Console.Write("Preço: ");
                    p.Preco = double.Parse(Console.ReadLine());
                    Console.WriteLine();
                    Console.Write("Quantidade em Estoque: ");
                    p.QuantidadeEmEstoque = int.Parse(Console.ReadLine());
                    Console.WriteLine();

                    estoque.Salvar();

                    // estoque.Estoque.RemoveAt()

                    Console.WriteLine("Dados do produto Inserido: ");
                    Console.WriteLine();
                    Console.WriteLine(p);
                    Console.ReadKey();
                }

                else if(opcao == 'B' || opcao == 'b')
                {
                    Console.Clear();

                    Console.WriteLine("Adicionar Produto em Estoque");
                    Console.WriteLine();
                    Console.Write("Quantos produtos devem ser Adicionados? ");
                    int i = int.Parse(Console.ReadLine());
                    p.AdicionarProdutos(i);
                }

                else if(opcao == 'C' || opcao == 'c')
                {
                    Console.Clear();

                    if(p.Nome != null)
                    {
                        Console.WriteLine("Remover Produto em Estoque");
                        Console.WriteLine();
                        Console.Write("Quantos produtos devem ser removido? ");
                        int i = int.Parse(Console.ReadLine());
                        p.RemoverProduto(i);
                    }
                    else
                    {
                        Console.WriteLine("Não existe produto para ser removido no estoque.");
                    }
                }

                else if(opcao == 'D' || opcao == 'd')
                {
                    Console.Clear();

                    Console.WriteLine("Produtos em estoque");
                    Console.WriteLine();
                    Console.WriteLine(p);
                }

                else if(opcao == 'E' || opcao == 'e')
                {
                    Console.WriteLine($"O valor em estoque é de: {p.ValorTotalEmEstoque().ToString("F2")}");
                }
            }
        }
    }
}
