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
    }
}
