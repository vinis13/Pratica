using MVCLinq.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCLinq.Controllers
{
    public class ProdutosController : Controller
    {
        static IList<Produto> ListaProdutos = new List<Produto>()
        {
            new Produto {Id=1, Categoria="Cat 1", Nome="Prod 1" },
            new Produto {Id=2, Categoria="Cat 2", Nome="Prod 2" }
        };
        // GET: Produtos
        public ActionResult Index()
        {
            return View(ListaProdutos);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Produto prod)
        {
            prod.Id = ListaProdutos.Select(p => p.Id).Max() + 1;
            ListaProdutos.Add(prod);
            return RedirectToAction("Index");
        }

        public ActionResult Edit(long id)
        {
            return View(ListaProdutos.Where(p => p.Id == id).First());
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Produto prod)
        {
            ListaProdutos.Remove(ListaProdutos.Where(p => p.Id == prod.Id).First());
            ListaProdutos.Add(prod);
            return RedirectToAction("Index");
        }

        public ActionResult Details(long id)
        {
            return View(ListaProdutos.Where(p => p.Id == id).First());
        }

        public ActionResult Delete(long id)
        {
            return View(ListaProdutos.Where(p => p.Id == id).First());
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(Produto prod)
        {
            ListaProdutos.Remove(ListaProdutos.Where(p => p.Id == prod.Id).First());
           // ListaProdutos.Add(prod);
            return RedirectToAction("Index");
        }
    }
}