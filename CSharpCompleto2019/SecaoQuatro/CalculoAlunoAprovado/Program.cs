using System;
using System.Globalization;

namespace CalculoAlunoAprovado
{
    class Program
    {
        static void Main(string[] args)
        {
            Aluno a = new Aluno();

            Console.Write("Nome do Aluno: ");
            Aluno.Nome = Console.ReadLine();

            Notas.ValidacaoDeNotas();

            Console.Clear();

            Notas.NotaFinal();
        }
    }
}
