using ECommerce.Business.Abstract;
using ECommerce.Entities.Entities.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace ECommerce.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        readonly IProductService _productService;
        readonly ICategoryService _categoryService;
        public CategoryController(IProductService productService, ICategoryService categoryService)
        {
            _productService = productService;
            _categoryService = categoryService;
        }
        [HttpGet]
        public IEnumerable<Category> Get()
        {
            return _categoryService.GetAll();
        }

        [HttpGet("{categoryId}")]
        public Category Get(int id)
        {
            return _categoryService.GetAll().FirstOrDefault(x=>x.CategoryId==id);
        }

        [HttpPost]
        public Category Post([FromBody] Category category)
        {
            _categoryService.Add(category);
            return category;
        }

        [HttpPut("{categoryId}")]
        public Category Put(int id, [FromBody] Category category)
        {
            _categoryService.Update(category);
            return category;
        }

        [HttpDelete("{categoryId}")]
        public void Delete(int id)
        {
            var query = _productService.GetAll().Where(x => x.CategoryId == id);
            foreach (var item in query)
            {
                _productService.Remove(new Product { ProductId = item.ProductId });
            }
            _categoryService.Remove(new Category { CategoryId = id });
        }
    }
}
