using ECommerce.Business.Abstract;
using ECommerce.Entities.Context;
using ECommerce.Entities.Entities.Concrete;
using ECommerce.WebApp.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ECommerce.WebApp.Areas.admin.Controllers
{
    [Area("admin")]
    [Authorize(Roles = "Admin")]
    public class ProductController : Controller
    {
        readonly IProductService _productService;
        readonly ICategoryService _categoryService;
        public ProductController(IProductService productService, ICategoryService categoryService)
        {
            _productService = productService;
            _categoryService = categoryService;
        }
        public IActionResult Index()
        {
            return View(_productService.GetAll());
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
                return RedirectToAction("Index", "Default");

            }
            return View("Add");
        }
        public IActionResult Update(ViewModel model, int id)
        {
            model = new ViewModel
            {
                Product = _productService.GetById(id),
                Categories = _categoryService.GetAll(),
                Products = _productService.GetAll().Where(x => x.ProductId == id)
            };
            return View(model);
        }
        [HttpPost]
        public IActionResult Update(Product product)
        {
            if (ModelState.IsValid)
            {
                _productService.Update(product);
                return RedirectToAction("Index","Default");
            }
            return View();
        }
        public IActionResult Delete(int id)
        {
            _productService.Remove(new Product { ProductId = id });
            return RedirectToAction("Index", "Default");
        }

    }
}
