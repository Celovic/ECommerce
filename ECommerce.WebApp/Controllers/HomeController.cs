using ECommerce.Business.Abstract;
using ECommerce.Entities.Context;
using ECommerce.Entities.Entities.Concrete;
using ECommerce.WebApp.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ECommerce.WebApp.Controllers
{
    public class HomeController : Controller
    {
        readonly IProductService _productService;
        public HomeController(IProductService productService)
        {
            _productService = productService;
        }
        public IActionResult Index(string searchString, int page = 1, int category = 0)
        {
            int pageSize = 10;
            var products = _productService.GetByCategory(category);
            var searching = _productService.Search(searchString);
            if (searchString != null)
            {
                ViewModel modelSearching = new ViewModel
                {
                    Products = searching.Skip((page - 1) * pageSize).Take(pageSize).ToList(),
                    PageCount = (int)Math.Ceiling(products.Count() / (double)pageSize),
                    PageSize = pageSize,
                    CurrentCategory = category,
                    CurrentPage = page
                };
                return View(modelSearching);
            }
            ViewModel model = new ViewModel
            {
                Products = products.Skip((page - 1) * pageSize).Take(pageSize).ToList(),
                PageCount = (int)Math.Ceiling(products.Count() / (double)pageSize),
                PageSize = pageSize,
                CurrentCategory = category,
                CurrentPage = page
            };
            return View(model);


        }
    }
}
