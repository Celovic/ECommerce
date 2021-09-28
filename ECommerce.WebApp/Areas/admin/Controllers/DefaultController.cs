using ECommerce.Business.Abstract;
using ECommerce.Entities.Context;
using ECommerce.Entities.Entities.Concrete;
using ECommerce.WebApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ECommerce.WebApp.Areas.admin.Controllers
{
    [Area("admin")]
    public class DefaultController : Controller
    {
        readonly IProductService _productService;
        readonly ICategoryService _categoryService;
        readonly ECommerceDbContext _context;
        public DefaultController(IProductService productService, ICategoryService categoryService, ECommerceDbContext context)
        {
            _productService = productService;
            _categoryService = categoryService;
            _context = context;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Add()
        {
            var model = new ViewModel()
            {
                Product = new Product(),
                Categories = _categoryService.GetAll()
            };

            return View(model);
        }
        [HttpPost]
        public IActionResult Add(Product product)
        {
            if (ModelState.IsValid)
            {
                _productService.Add(product);
                _context.SaveChanges();
                return RedirectToAction("Index", "Default");

            }
            return View("Add");
        }
        public IActionResult Update()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Update(Product product)
        {
            return View();
        }
        public IActionResult Delete()
        {
            return View();
        }
    }
}
