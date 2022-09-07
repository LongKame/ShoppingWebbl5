﻿using Microsoft.AspNetCore.Http;
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
            var cate = shoppingWebbl5Context.Categories.ToList();
            return Json(new { data = cate });
        }

        public IActionResult PopupEdit(int id)
        {
            ShoppingWebbl5Context shoppingWebbl5Context = new ShoppingWebbl5Context();
            Product product = shoppingWebbl5Context.Products.FirstOrDefault(x => x.Id == id);
            Edit edit = null;
            if (product != null)
            {
                Brand brand = shoppingWebbl5Context.Brands.FirstOrDefault(x => x.Id == product.IdBrand);
                Category category = shoppingWebbl5Context.Categories.FirstOrDefault(x => x.Id == product.IdCategory);
                edit = new Edit(product.Id, product.ProductName, product.Image, product.Quantity, product.Price, category.CategoryName, brand.BrandName, product.Original, product.Description);
                ViewBag.Product = edit;
            }
            return Json(new { data = edit });
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

        public IActionResult Cart(Product cart)
        {
            string? username = HttpContext.Session.GetString("username");
            if (username == null)
            {
                return RedirectToAction("Login");
            }

            List<Product> list = new List<Product>();
            ShoppingWebbl5Context shoppingWebbl5Context = new ShoppingWebbl5Context();
            Product pro = new Product();
            Product product = shoppingWebbl5Context.Products.FirstOrDefault(x => x.Id == cart.Id);
            string? json = HttpContext.Session.GetString("addCart");
            bool check = true;
            if (json != null)
            {
                list = JsonConvert.DeserializeObject<List<Product>>(json);
            }
            else
            {
                list = new List<Product>();
            }

            if (list.Count == 0)
            {
                pro.Id = cart.Id;
                pro.ProductName = product.ProductName;
                pro.Image = product.Image;
                pro.Price = product.Price;
                pro.Quantity = cart.Quantity;
                list.Add(pro);
            }
            else
            {
                foreach (var i in list.ToList())
                {
                    if (i.Id == cart.Id)
                    {
                        i.Id = cart.Id;
                        i.ProductName = product.ProductName;
                        i.Image = product.Image;
                        i.Price = product.Price;
                        i.Quantity += cart.Quantity;
                        check = false;
                    }
                }
                if (check == true)
                {
                    pro.Id = cart.Id;
                    pro.ProductName = product.ProductName;
                    pro.Image = product.Image;
                    pro.Price = product.Price;
                    pro.Quantity = cart.Quantity;
                    list.Add(pro);
                }
            }
            json = JsonConvert.SerializeObject(list);
            HttpContext.Session.SetString("addCart", json);
            HttpContext.Session.SetString("count", list.Count().ToString());
            return RedirectToAction("ViewCart");
        }

        public IActionResult ViewCart()
        {
            List<Product> list = new List<Product>();
            string? json = HttpContext.Session.GetString("addCart");
            double total = 0;
            if (json != null)
            {
                list = JsonConvert.DeserializeObject<List<Product>>(json);
                foreach (var i in list)
                {
                    total += (double)i.Price * i.Quantity;
                }
                ViewBag.Total = total;
            }
            else
            {
                list = new List<Product>();
            }

            return View(list);
        }

        public IActionResult RemoveCart(int? id)
        {
            List<Product> list = new List<Product>();
            string? json = HttpContext.Session.GetString("addCart");
            if (json != null)
            {
                list = JsonConvert.DeserializeObject<List<Product>>(json);
            }
            else
            {
                list = new List<Product>();
            }

            var item = list.SingleOrDefault(x => x.Id == id);

            if (item == null)
            {
                ViewBag.Data = "Can not delete";
            }
            else
            {
                list.Remove(item);
                json = JsonConvert.SerializeObject(list);
                HttpContext.Session.SetString("addCart", json);
            }
            return RedirectToAction("ViewCart");
        }

        public IActionResult Login()
        {
            return View();
        }

        public IActionResult DoLogin(Account acc)
        {
            ShoppingWebbl5Context shoppingWebbl5Context = new ShoppingWebbl5Context();
            Account account = shoppingWebbl5Context.Accounts.FirstOrDefault(x => x.Email.Equals(acc.Email) && x.Password.Equals(acc.Password));
            if (account != null)
            {
                HttpContext.Session.SetString("role", JsonConvert.SerializeObject(account.IdRole));
                HttpContext.Session.SetString("username", JsonConvert.SerializeObject(account.Username));
                HttpContext.Session.SetString("account", JsonConvert.SerializeObject(account));
            }
            return RedirectToAction("Index");
        }

        public IActionResult SignOut()
        {
            HttpContext.Session.Remove("role");
            HttpContext.Session.Remove("username");
            HttpContext.Session.Remove("account");
            return RedirectToAction("Index");
        }

        public IActionResult CheckOut(CheckOut checkOut)
        {
            List<Product> list = new List<Product>();
            Account account = new Account();
            string? json = HttpContext.Session.GetString("addCart");
            if (json != null)
            {
                list = JsonConvert.DeserializeObject<List<Product>>(json);
            }
            else
            {
                list = new List<Product>();
            }

            string? acc = HttpContext.Session.GetString("account");
            if (acc != null)
            {
                account = JsonConvert.DeserializeObject<Account>(acc);
            }

            ShoppingWebbl5Context shoppingWebbl5Context = new ShoppingWebbl5Context();

            foreach (var i in list)
            {
                CheckOut check = new CheckOut();
                check.IdProduct = i.Id;
                check.IdAccount = account.Id;
                check.Quantity = i.Quantity;
                check.Require = checkOut.Require;
                check.Date = DateTime.Now;
                check.Checked = false;
                shoppingWebbl5Context.CheckOuts.Add(check);
                shoppingWebbl5Context.SaveChanges();
            }
            HttpContext.Session.Remove("addCart");
            return RedirectToAction("ViewCart");
        }



        public IActionResult Chart()
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
