using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Xml.Linq;

namespace MVCLinqXML.Models
{
    public class ProdutoModelo:List<Produto>
    {
        public ProdutoModelo()
        {
            string dirOrigem = HttpContext.Current.Server.MapPath("~/Dados/");

            XDocument Dados = XDocument.Load(dirOrigem + @"/ListaProdutos.xml");

            List<Produto> ListaProdutos = (from p in Dados.Descendants("Produto")
                                           select new Produto(Convert.ToInt32(p.Element("Id").Value),
                                                              p.Element("Nome").Value,
                                                              p.Element("Categoria").Value,
                                                              p.Element("Foto").Value
                                                              )
                                           ).ToList();
            this.AddRange(ListaProdutos);
        }
    }
}