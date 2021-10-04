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
        public Category Get(int categoryId)
        {
            return _categoryService.GetAll().FirstOrDefault(x => x.CategoryId == categoryId);
        }

        [HttpPost]
        public Category Post([FromBody] Category category)
        {
            _categoryService.Add(category);
            return category;
        }

        [HttpPut("{categoryId}")]
        public Category Put(int categoryId, [FromBody] Category category)
        {
            _categoryService.Update(category);
            return category;
        }

        [HttpDelete("{categoryId}")]
        public void Delete(int categoryId)
        {
            _categoryService.DeleteWithProduct(categoryId);
        }
        [HttpGet("GetSearchCategory/{searchString}")]
        public IEnumerable<Category> GetSearchCategory(string searchString)
        {
            return _categoryService.Search(searchString);
        }
    }
}
