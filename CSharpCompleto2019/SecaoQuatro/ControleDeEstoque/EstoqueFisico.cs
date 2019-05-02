using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;


namespace ControleDeEstoque
{
    class EstoqueFisico
    {
        public List<Produto> Estoque { get; set; }
        private string caminhoJSON = "c:\\Users\\Wendell S\\source\repos\\educawendellsouza\\CursosUdemy\\CSharpCompleto2019\\SecaoQuatro\\ControleDeEstoque";

        public void Salvar()
        {            
            System.IO.File.WriteAllText(caminhoJSON, new JavaScriptSerializer().Serialize(Estoque));
        }

        public void Carregar()
        {
            Estoque = new JavaScriptSerializer().Deserialize<List<Produto>>(System.IO.File.ReadAllText(caminhoJSON));
        }
    }
}
