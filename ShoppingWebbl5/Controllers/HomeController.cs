using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
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

            var cate = (from category in shoppingWebbl5Context.Categories
                        select category).ToList();
            var brand = (from bra in shoppingWebbl5Context.Brands
                         select bra).ToList();

            ViewBag.Categories = cate;
            ViewBag.Brands = brand;

            if (page > 0)
            {
                page = page;
            }
            else
            {
                page = 1;
            }
            int limit = 1;
            int start = (int)(page - 1) * limit;
            int totalProduct = list.Count();
            ViewBag.totalProduct = totalProduct;
            ViewBag.pageCurrent = page;
            float numberPage = (totalProduct / limit);
            ViewBag.numberPage = (int)Math.Ceiling(numberPage) + 1;
            var dataPro = list.OrderBy(s => s.Id).Skip(start).Take(limit);
            return View(dataPro.ToList());
        }


        public IActionResult Administrators(int? page)
        {
            ShoppingWebbl5Context shoppingWebbl5Context = new ShoppingWebbl5Context();
            var listProduct = shoppingWebbl5Context.Products.ToList();

            if (page > 0)
            {
                page = page;
            }
            else
            {
                page = 1;
            }
            int limit = 1;
            int start = (int)(page - 1) * limit;
            int totalProduct = listProduct.Count();
            ViewBag.totalProduct = totalProduct;
            ViewBag.pageCurrent = page;
            float numberPage = (totalProduct / limit);
            ViewBag.numberPage = (int)Math.Ceiling(numberPage) + 1;
            var dataPro = listProduct.OrderBy(s => s.Id).Skip(start).Take(limit);
            ViewBag.ListProduct = dataPro.ToList();
            return View();

        }

        public IActionResult PopupAdd()
        {
            ShoppingWebbl5Context shoppingWebbl5Context = new ShoppingWebbl5Context();
            TwoLists lists = null;
            lists.Brands = shoppingWebbl5Context.Brands.ToList();
            lists.Categories = shoppingWebbl5Context.Categories.ToList();
            return Json(new { lists });
        }

        public IActionResult PopupEdit(int id)
        {
            ShoppingWebbl5Context shoppingWebbl5Context = new ShoppingWebbl5Context();
            Product product = shoppingWebbl5Context.Products.FirstOrDefault(x => x.Id == id);
            if (product != null)
            {
                ViewBag.Product = product;
            }
            return Json(new { data = product });
        }

        public IActionResult PopupView(int? id)
        {
            ShoppingWebbl5Context shoppingWebbl5Context = new ShoppingWebbl5Context();
            var product = (from pro in shoppingWebbl5Context.Products
                           join bra in shoppingWebbl5Context.Brands on pro.IdBrand equals bra.Id
                           join cate in shoppingWebbl5Context.Categories on pro.IdCategory equals cate.Id
                           where pro.Id == id
                           select new
                           {
                               id = pro.Id,
                               productName = pro.ProductName,
                               image = pro.Image,
                               quantity = pro.Quantity,
                               price = pro.Price,
                               category = cate.CategoryName,
                               brand = bra.BrandName,
                               original = pro.Original,
                               description = pro.Description
                           });
            return Json(new { data = product });
        }

        public IActionResult PopupDelete(int? id)
        {
            ShoppingWebbl5Context shoppingWebbl5Context = new ShoppingWebbl5Context();
            Product product = shoppingWebbl5Context.Products.FirstOrDefault(x => x.Id == id);
            if (product != null)
            {
                ViewBag.Product = product;
            }
            return Json(new { data = product });
        }

        public JsonResult Add(Product product)
        {
            ShoppingWebbl5Context shoppingWebbl5Context = new ShoppingWebbl5Context();
            if (product != null)
            {
                shoppingWebbl5Context.Products.Add(product);
                shoppingWebbl5Context.SaveChanges();
            }
            return Json(new { Message = true });
        }

        public JsonResult UpdateProductById(Product product)
        {
            Product pro = null;
            ShoppingWebbl5Context shoppingWebbl5Context = new ShoppingWebbl5Context();
            if (product != null)
            {
                pro = shoppingWebbl5Context.Products.FirstOrDefault(x => x.Id == product.Id);
            }
            if (pro != null)
            {
                pro.ProductName = product.ProductName;
                pro.Image = product.Image;
                pro.Quantity = product.Quantity;
                pro.Price = product.Price;
                pro.Original = product.Original;
                pro.IdBrand = product.IdBrand;
                pro.IdCategory = product.IdCategory;
                shoppingWebbl5Context.SaveChanges();
            }
            return Json(new { Message = true });
        }

        public JsonResult DeleteProductById(int id)
        {
            Product pro = null;
            ShoppingWebbl5Context shoppingWebbl5Context = new ShoppingWebbl5Context();
            pro = shoppingWebbl5Context.Products.FirstOrDefault(x => x.Id == id);
            if (pro != null)
            {
                shoppingWebbl5Context.Products.Remove(pro);
                shoppingWebbl5Context.SaveChanges();
            }
            return Json(new { Message = true });
        }

        public IActionResult Detail(int? id)
        {
            ShoppingWebbl5Context shoppingWebbl5Context = new ShoppingWebbl5Context();
            Product product = shoppingWebbl5Context.Products.FirstOrDefault(x => x.Id == id);
            if (product != null)
            {
                ViewBag.Product = product;
            }
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
