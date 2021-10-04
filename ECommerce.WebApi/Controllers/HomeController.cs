using ECommerce.Business.Abstract;
using ECommerce.Entities.Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ECommerce.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HomeController : ControllerBase
    {
        readonly IProductService _productService;
        readonly ICategoryService _categoryService;

        public HomeController(IProductService productService, ICategoryService categoryService)
        {
            _productService = productService;
            _categoryService = categoryService;
        }

        [HttpGet]
        public IEnumerable<Product> Get()
        {

            return _productService.GetProductsWithCategory("Category");
        }

        [HttpGet("GetByProduct/{productId}")]
        public Product GetByProduct(int productId)
        {
            return _productService.GetAll().FirstOrDefault(x=>x.ProductId == productId);
        }
        [HttpGet("GetByCategory/{categoryId}")]
        public Category GetByCategory(int categoryId)
        {
            return _categoryService.GetAll().FirstOrDefault(x=>x.CategoryId == categoryId);
        }

    }
}
