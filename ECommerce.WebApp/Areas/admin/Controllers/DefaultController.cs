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
        public IActionResult Index(ViewModel model, int id)
        {
            model = new ViewModel
            {
                Categories = _categoryService.GetAll(),
                Products = _productService.GetAll()
            };

            //Products.Where(x=>x.CategoryId==item.CategoryId).Select(y=>y.ProductTitle)
            return View(model);
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
                return RedirectToAction("Index");
            }
            return View();
        }
        public IActionResult Delete(int id)
        {
            _productService.Remove(new Product { ProductId = id });
            return RedirectToAction("Index", "Default");
        }

        public IActionResult AddCategory()
        {
            var model = new ViewModel()
            {
                Category = new Category(),
            };

            return View(model);
        }
        [HttpPost]
        public IActionResult AddCategory(Category category)
        {
            if (ModelState.IsValid)
            {
                _categoryService.Add(category);
                return RedirectToAction("Index", "Default");
            }
            return View("Add");
        }

        public IActionResult UpdateCategory(ViewModel model, int id)
        {
            model = new ViewModel
            {
                Category = _categoryService.GetById(id),
                Categories = _categoryService.GetAll().Where(x => x.CategoryId == id)
            };
            return View(model);
        }
        [HttpPost]
        public IActionResult UpdateCategory(Category category)
        {
            if (ModelState.IsValid)
            {
                _categoryService.Update(category);
                return RedirectToAction("Index");
            }
            return View();
        }

        public IActionResult DeleteCategory(int id, Product product, Category category)
        {
            /* _productService.GetAll().Where(x=>x.CategoryId==id).Select(y=>y.ProductId);
             _productService.Remove(new Product { CategoryId = id });*/
            //_categoryService.Remove(new Category{ CategoryId= id,});
            //_categoryService.DeleteWithProduct(id);
            var q = _context.TBLProduct.Where(x => x.CategoryId == id);
            foreach (var item in q)
            {
                _productService.Remove(new Product { ProductId = item.ProductId });
            }
            _categoryService.Remove(new Category { CategoryId = id });
            _context.SaveChanges();
            //_categoryService.DeleteWithProduct( new Category { Products == _productService.GetAll().Where(x => x.CategoryId == id) });
            return RedirectToAction("Index", "Default");
        }
    }
}
