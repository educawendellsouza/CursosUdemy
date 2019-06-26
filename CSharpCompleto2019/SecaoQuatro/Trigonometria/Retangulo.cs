using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;


namespace Trigonometria
{
    class Retangulo
    {
        public double Base;
        public double Altura;

        public double Area()
        {
            return Base * Altura;
        }

        public double Perimetro()
        {
            return 2 * (Base + Altura);
        }

        public double Diagonal()
        {
            double TeoremaDePitagoras = Math.Pow(Base, 2) + Math.Pow(Altura, 2);
            return Math.Sqrt(TeoremaDePitagoras);
        }
    }
}
