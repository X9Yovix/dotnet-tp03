using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TP03.Models;

namespace TP03.Controllers
{
    public class ProduitController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Message = "Hello to the home page of TP3";
            return View();
        }

        public ActionResult DisplayOneProduct()
        {
            Produit produit = new Produit
            {
                Id = 1,
                Name = "Test",
                Price = 10
            };
            return View(produit);
        }

        public ActionResult DisplayManyProducts()
        {
            List<Produit> produits = new List<Produit>
            {
                new Produit { Id = 1, Name = "Produit 1", Price = 10 },
                new Produit { Id = 2, Name = "Produit 2", Price = 20 },
                new Produit { Id = 3, Name = "Produit 3", Price = 30 }
            };

            ViewData["produits"] = produits;
            return View();
        }
    }
}