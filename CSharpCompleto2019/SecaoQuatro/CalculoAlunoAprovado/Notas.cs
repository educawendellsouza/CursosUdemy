using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace CalculoAlunoAprovado
{
    class Notas
    {
        public static double PrimeiroTrimestre;
        public static double SegundoTrimestre;
        public static double TerceiroTrimestre;
        public static double SomaDasNotas;

        public static void ValidacaoDeNotas()
        {
            Console.Write("Digite a nota do Primeiro Trimestre: ");
            Notas.PrimeiroTrimestre = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Digite a nota do Segundo Trimestre: ");
            Notas.SegundoTrimestre = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Digite a nota do Terceiro Trimestre: ");
            Notas.TerceiroTrimestre = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Clear();

            while (Notas.PrimeiroTrimestre > 30)
            {
                Console.WriteLine("ATENÇÃO");
                Console.WriteLine($"Nota do Primeiro Trismestre invalida. Nota digitada anteriormente: " + PrimeiroTrimestre);
                Console.WriteLine("");
                Console.WriteLine("Digite a nota do Primeiro Trimestre, novamente.");
                Console.WriteLine("Lembrando: Nota não pode ser maior do que 30.");
                Console.Write("Nota :");
                Notas.PrimeiroTrimestre = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                Console.Clear();
            }

            while (Notas.SegundoTrimestre > 35)
            {
                Console.WriteLine("ATENÇÃO");
                Console.WriteLine($"Nota do Segundo Trismestre invalida. Nota digitada anteriormente: " + SegundoTrimestre); Console.WriteLine("");
                Console.WriteLine("Digite a nota do Segundo Trimestre, novamente.");
                Console.WriteLine("Lembrando: Nota não pode ser maior do que 35.");
                Console.Write("Nota :");
                Notas.SegundoTrimestre = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                Console.Clear();
            }

            while (Notas.TerceiroTrimestre > 35)
            {
                Console.WriteLine("ATENÇÃO");
                Console.WriteLine($"Nota do Terceiro Trismestre invalida. Nota digitada anteriormente: " + TerceiroTrimestre); Console.WriteLine("");
                Console.WriteLine("Digite a nota do TerceiroTrimestre, novamente.");
                Console.WriteLine("Lembrando: Nota não pode ser maior do que 35.");
                Console.Write("Nota :");
                Notas.TerceiroTrimestre = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                Console.Clear();
            }

            /*

            if (Notas.PrimeiroTrimestre <= 30 && Notas.SegundoTrimestre <= 35 && Notas.TerceiroTrimestre <= 35)
            {
                Notas.Nota();
            }
            else if (Notas.PrimeiroTrimestre > 30 && Notas.SegundoTrimestre <= 35 && Notas.TerceiroTrimestre <= 35)
            {
                Console.WriteLine("Nota do Primeiro Trismestre invalida.");
                Console.WriteLine("");
                Console.WriteLine("Digite a nota do Primeiro Trimestre, novamente.");
                Console.Write("Nota :");
                Notas.PrimeiroTrimestre = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            }
            else if (Notas.PrimeiroTrimestre <= 30 && Notas.SegundoTrimestre > 35 && Notas.TerceiroTrimestre <= 35)
            {
                Console.WriteLine("Nota do Segundo Trismestre invalida.");
                Console.WriteLine("");
                Console.WriteLine("Digite a nota do Segundo Trimestre, novamente.");
                Console.Write("Nota :");
                Notas.SegundoTrimestre = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            }
            else if (Notas.PrimeiroTrimestre <= 30 && Notas.SegundoTrimestre <= 35 && Notas.TerceiroTrimestre > 35)
            {
                Console.WriteLine("Nota do Terceiro Trismestre invalida.");
                Console.WriteLine("");
                Console.WriteLine("Digite a nota do TerceiroTrimestre, novamente.");
                Console.Write("Nota :");
                Notas.TerceiroTrimestre = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            }

            */

        }


        public static double Nota()
        {
            return PrimeiroTrimestre + SegundoTrimestre + TerceiroTrimestre;
        }

        public static void NotaFinal()
        {

            double x = Notas.Nota();
            double falta = x - 60;

            if (x <= 59)
            {
                Console.WriteLine($"Aluno: {Aluno.Nome}");
                Console.WriteLine($"NOTA FINAL = {x.ToString("F2", CultureInfo.InvariantCulture)}");
                Console.WriteLine($"REPROVADO");
                Console.WriteLine($"Faltaram {falta} PONTOS");
            }
            else
            {
                Console.WriteLine($"Aluno: {Aluno.Nome}");
                Console.WriteLine($"NOTA FINAL = {x.ToString("F2", CultureInfo.InvariantCulture)}");
                Console.WriteLine($"APROVADO");
            }
        }
    }
}
