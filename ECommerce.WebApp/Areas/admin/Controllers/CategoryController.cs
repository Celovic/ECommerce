﻿using ECommerce.Business.Abstract;
using ECommerce.Entities.Context;
using ECommerce.Entities.Entities.Concrete;
using ECommerce.WebApp.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ECommerce.WebApp.Areas.admin.Controllers
{
    [Area("admin")]
    public class CategoryController : Controller
    {
        readonly IProductService _productService;
        readonly ICategoryService _categoryService;
        readonly ECommerceDbContext _context;
        public CategoryController(IProductService productService, ICategoryService categoryService, ECommerceDbContext context)
        {
            _productService = productService;
            _categoryService = categoryService;
            _context = context;
        }
        public IActionResult Index()
        {
            return View(_categoryService.GetAll());
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
            var q = _context.TBLProduct.Where(x => x.CategoryId == id);
            foreach (var item in q)
            {
                _productService.Remove(new Product { ProductId = item.ProductId });
            }
            _categoryService.Remove(new Category { CategoryId = id });
            //_context.SaveChanges();
            return RedirectToAction("Index", "Default");
        }
    }
}