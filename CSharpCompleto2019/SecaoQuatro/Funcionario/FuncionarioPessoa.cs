using System;
using System.Collections.Generic;
using System.Text;

namespace Funcionario
{
    class FuncionarioPessoa
    {
        public string Nome;
        public double SalarioBruto;
        public double Imposto;

        public double SalarioLiquido()
        {
            return SalarioBruto - Imposto;
        }

        public void AumentarSalario(double porcentagem)
        {
            SalarioBruto += porcentagem / 100 * SalarioBruto;
        }
    }
}
