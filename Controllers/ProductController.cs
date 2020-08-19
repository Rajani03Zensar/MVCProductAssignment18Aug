using MVCAssignment.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCAssignment.Controllers
{
    public class ProductController : Controller
    {
        // GET: Product
        public ActionResult Index()
        {
            var products = GetProducts();
            return View(products);
        }
        private IEnumerable<Product> GetProducts() { 
            return new List<Product>
           {
                new Product{ProductId=101,ProductName="AC",Rate=45000},
                new Product{ProductId=102,ProductName="Mobile",Rate=38000},
                new Product{ProductId=103,ProductName="Bike",Rate=94000}
           };

           
        }
        public ActionResult Details(int id)
        {
            var product = GetProducts().SingleOrDefault(c => c.ProductId == id);
            if (product == null)
            {
                return HttpNotFound();
            }
            else
            {
                return View(product);
            }
        }
    }
}