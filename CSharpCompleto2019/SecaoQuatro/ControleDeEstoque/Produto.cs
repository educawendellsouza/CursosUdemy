using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleDeEstoque
{
    class Produto
    {
        public string Nome;
        public double Preco;
        public int QuantidadeEmEstoque;

        public double ValorTotalEmEstoque()
        {
            return Preco * QuantidadeEmEstoque;
        }
    }
}
