using System;
using System.Globalization;


namespace Trigonometria
{
    class Program
    {
        static void Main(string[] args)
        {
            Retangulo a = new Retangulo();

            Console.WriteLine("Entre com a Base e a Altura do Retângulo");
            Console.WriteLine("");
            Console.Write("Base: ");
            a.Base = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine(""); ;
            Console.Write("Altura: ");
            a.Altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double area = a.Area();
            double perimetro = a.Perimetro();
            double diagonal = a.Diagonal();

            Console.Clear();

            Console.WriteLine("Area: " + area);
            Console.WriteLine();
            Console.WriteLine("Perimetro: " + perimetro);
            Console.WriteLine();
            Console.WriteLine("Diagonal: " + diagonal);



        }
    }
}
