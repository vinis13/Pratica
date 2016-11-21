using MVCLinqXML.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCLinqXML.Controllers
{
    public class ProdutosController : Controller
    {
        // GET: Produtos
        public ActionResult Index()
        {
            List<Produto> ListaProdutos = new ProdutoModelo();
            return View(ListaProdutos);
        }
    }
}