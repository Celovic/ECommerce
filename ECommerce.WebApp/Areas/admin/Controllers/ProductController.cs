using ECommerce.Business.Abstract;
using ECommerce.Entities.Context;
using ECommerce.Entities.Entities.Concrete;
using ECommerce.Repository.EnityFramework.Abstract;
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
        public async Task<IActionResult> Index()
        {
            return View(await _productService.GetAll());
        }
        public async Task<IActionResult> Add()
        {
            var model = new ViewModel()
            {
                Product = new Product(),
                Categories = await _categoryService.GetAll()
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
        public async Task<IActionResult> Update(ViewModel model, int id)
        {
            model = new ViewModel
            {
                Product = await _productService.GetById(id),
                Categories =await _categoryService.GetAll(),
                Products =(await _productService.GetAll()).Where(x => x.ProductId == id)
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
