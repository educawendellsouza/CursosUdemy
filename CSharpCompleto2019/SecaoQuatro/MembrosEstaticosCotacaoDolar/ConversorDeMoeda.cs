using System;
using System.Globalization;
using System.Collections.Generic;
using System.Text;

namespace MembrosEstaticosCotacaoDolar
{
    class ConversorDeMoeda
    {
        public static double CotacaoDoDolar;
        public static double ValorEmDolarQueSeraComprado;
        public static double ValorQueSeraPagoEmReais;

        public static double CalculoDoIof()
        {
            Console.Write("Qual a cotação do dolar? R$ ");
            CotacaoDoDolar = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("");
            Console.Write("Quantos Dolares você vai Comprar: U$ ");
            ValorEmDolarQueSeraComprado = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("");

            double iof = ValorEmDolarQueSeraComprado * 0.06 + ValorEmDolarQueSeraComprado;
            return ValorQueSeraPagoEmReais = CotacaoDoDolar * iof;            
        }
    }
}
