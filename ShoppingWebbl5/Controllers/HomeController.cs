using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ShoppingWebbl5.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace ShoppingWebbl5.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            ShoppingWebbl5Context shoppingWebbl5Context = new ShoppingWebbl5Context();
            var list = shoppingWebbl5Context.Categories.ToList();
            return View(list);

        }

        public IActionResult List(int? id, int? page)
        {

            ShoppingWebbl5Context shoppingWebbl5Context = new ShoppingWebbl5Context();
            var list = (from product in shoppingWebbl5Context.Products
                        where product.IdCategory == id
                        select product).ToList();
            if (page > 0)
            {
                page = page;
            }
            else
            {
                page = 1;
            }
            int limit = 2;
            int start = (int)(page - 1) * limit;
            int totalProduct = list.Count();
            ViewBag.totalProduct = totalProduct;
            ViewBag.pageCurrent = page;
            float numberPage = (totalProduct / limit);
            ViewBag.numberPage = (int)Math.Ceiling(numberPage) + 1;
            var dataPro = list.OrderBy(s => s.Id).Skip(start).Take(limit);
            return View(dataPro.ToList());
        }


        public IActionResult Detail(int? id)
        {
            ShoppingWebbl5Context shoppingWebbl5Context = new ShoppingWebbl5Context();
            Product product = shoppingWebbl5Context.Products.FirstOrDefault(x => x.Id == id);
            ViewBag.Product = product;
            return View(product);
        }

        public IActionResult Cart(int? id)
        {

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
