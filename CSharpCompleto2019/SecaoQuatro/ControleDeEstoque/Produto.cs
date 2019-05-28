using System.Globalization;

namespace ControleDeEstoque
{
    class Produto
    {
        public string Nome;
        public double Preco;
        public int Quantidade;

        public double ValorTotalEmEstoque()
        {
            return Preco * Quantidade;
        }

        public void AdicionarProdutos()
        {

        }

        public void RemoverProdutos()
        {

        }

        public override string ToString()
        {
            return Nome 
                   + ", $ " 
                   + Preco.ToString("F2", CultureInfo.InvariantCulture)
                   + ", "
                   + Quantidade
                   + " unidade, Total no Estoque: R$ "
                   + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
