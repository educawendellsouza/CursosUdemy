using System;
using System.Globalization;

namespace MembrosEstaticosCotacaoDolar
{
    class Program
    {
        static void Main(string[] args)
        {
            ConversorDeMoeda.CalculoDoIof();
            Console.WriteLine($"Valor a ser pago em reais: R$ {ConversorDeMoeda.ValorQueSeraPagoEmReais.ToString("F2", CultureInfo.InvariantCulture)}");
        }
    }
}
