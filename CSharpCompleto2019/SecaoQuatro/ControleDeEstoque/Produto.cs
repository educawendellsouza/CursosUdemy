using System;
using System.Globalization;

namespace ControleDeEstoque
{
    class Produto
    {
        #region Atributos da Classe
        public string Nome;
        public double Preco;
        public int QuantidadeEmEstoque;
        #endregion
        
        #region Métodos da Classe
        public double ValorTotalEmEstoque()
        {
            return Preco * QuantidadeEmEstoque;
        }

        public void AdicionarProdutos(int quantidade)
        {
            QuantidadeEmEstoque += quantidade;
        }

        public void RemoverProduto (int quantidade)
        {
            QuantidadeEmEstoque -= quantidade;
        }        
        #endregion

        #region ToString
        public override string ToString() // Sobreposição com 'override'
        {
            return string.Format("Produto: {1} {0}{0}Preço: {2} {0}{0}Quantidade em Estoque: R$ {3}",
                                  System.Environment.NewLine, 
                                  Nome, 
                                  Preco.ToString("F2", CultureInfo.InvariantCulture), 
                                  ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture));
        }
        #endregion
    }
}
