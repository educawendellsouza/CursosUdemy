using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace ProgramaDoTriangulo
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Orientação a objetos | Exercicio 5 - Triangulo.
            Triangulo x, y;

            x = new Triangulo();
            y = new Triangulo();

            Console.WriteLine("Entre com as três medidas do Triangulo X: ");
            Console.WriteLine();
            Console.Write("Medida do Lado A: ");
            x.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Medida do Lado B: ");
            x.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Medida do Lado C: ");
            x.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Clear();
            Console.WriteLine("Entre com as três medidas do Triangulo Y: ");
            Console.WriteLine();
            Console.Write("Medida do Lado A: ");
            y.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Medida do Lado B: ");
            y.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Medida do Lado C: ");
            y.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double p = (x.A + x.B + x.C) / 2.0;
            double areaX = Math.Sqrt(p * (p - x.A) * (p - x.B) * (p - x.C));

            p = (y.A + y.B + y.C) / 2.0;
            double areaY = Math.Sqrt(p * (p - y.A) * (p - y.B) * (p - y.C));

            Console.Clear();

            Console.WriteLine($"A Area do triangulo X é de {areaX.ToString("F4", CultureInfo.InvariantCulture)}cm².");
            Console.WriteLine();
            Console.WriteLine($"A Area do triangulo Y é de {areaY.ToString("F4", CultureInfo.InvariantCulture)}cm².");

            Console.ReadKey();


            if (areaX == areaY)
            {
                Console.WriteLine();
                Console.WriteLine("As areas dos triangulos são iguais.");
            }

            else if (areaX > areaY)
            {
                Console.WriteLine();
                Console.WriteLine("A Area do maior triangulo é area do triangulo X, com " + areaX.ToString("F4", CultureInfo.InvariantCulture) + "cm².");
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine("A Area do maior triangulo é area do triangulo Y, com " + areaY.ToString("F4", CultureInfo.InvariantCulture) + "cm².");
            }

            #endregion
        }
    }
}
