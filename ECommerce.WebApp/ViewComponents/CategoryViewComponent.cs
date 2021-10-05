using ECommerce.Business.Abstract;
using ECommerce.WebApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewComponents;
using System;
using System.Threading.Tasks;

namespace ECommerce.WebApp.ViewComponents
{
    public class CategoryViewComponent: ViewComponent
    {
        private ICategoryService _categoryService;
        public CategoryViewComponent(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }
        public async Task<ViewViewComponentResult> InvokeAsync()
        {
            var model = new ViewModel
            {
                Categories = await _categoryService.GetAll(),
            };
            return View(model);
        }
    }
}
