﻿using System;

namespace ProgramaDoTriangulo
{
    class Triangulo
    {
        # region Atributos da Classe
        public double A;
        public double B;
        public double C;
        #endregion

        #region Métodos da Classe
        public double Area()
        {
            double p = (A + B + C) / 2.0;
            return Math.Sqrt(p * (p - A) * (p - B) * (p - C));            
        }
        #endregion
    }
}
