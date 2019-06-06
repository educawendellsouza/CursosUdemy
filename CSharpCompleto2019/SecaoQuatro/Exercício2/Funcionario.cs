using System;
using System.Globalization;

namespace Exercício2
{
    class Funcionario
    {
        public string Nome;
        public double SalarioBruto;
        public double Imposto;
        public double Aumento;

        public double SalarioLiquido()
        {
            return SalarioBruto -= Imposto;
        }

        public void AumentarSalarioEmPorcentagem(double porcentagem)
        {
            double i = SalarioBruto / 100 * porcentagem;
            SalarioBruto += i;
        }

        public double NovoSalario (double porcentos)
        {
            double i = SalarioBruto / 100;
            double diferenca = SalarioBruto - porcentos;
            if(diferenca < 0)
            {
                diferenca *= -1;
                return Aumento = diferenca / i;
            }
            else
            {
                return Aumento = diferenca / i;
            }
        }

        public override string ToString()
        {
            return String.Format("Nome do Funcionário: {0} \r\n" +
                                 "Salario bruto: {1} \r\n" +
                                 "Imposto: {2}",
                                  Nome,
                                  SalarioBruto.ToString("F2", CultureInfo.InvariantCulture),
                                  Imposto.ToString("F2", CultureInfo.InvariantCulture),
                                  Aumento.ToString("F2", CultureInfo.InvariantCulture));            
        }
    }
}
