using ECommerce.Business.Abstract;
using ECommerce.WebApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewComponents;
using System;


namespace ECommerce.WebApp.ViewComponents
{
    public class CategoryViewComponent: ViewComponent
    {
        private ICategoryService _categoryService;
        public CategoryViewComponent(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }
        public ViewViewComponentResult Invoke()
        {
            var model = new ViewModel
            {
                Categories = _categoryService.GetAll(),
                //Hangi kategoriye tıklarsak belirginleştirmek için
            };
            return View(model);
        }
    }
}
