using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCLinqXML.Models
{
    public class Produto
    {
        public Produto(int id, string prod, string cat, string arq)
        {
            Id = id;
            Nome = prod;
            Categoria = cat;
            Foto = arq;
        }

        public int Id { get; set; }
        public string Nome { get; set; }
        public string Categoria { get; set; }
        public string Foto { get; set; }
    }
}