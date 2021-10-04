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
    public class ProductController : ControllerBase
    {
        readonly IProductService _productService;
        readonly ICategoryService _categoryService;

        public ProductController(IProductService productService, ICategoryService categoryService)
        {
            _productService = productService;
            _categoryService = categoryService;
        }
        [HttpGet]
        public IEnumerable<Product> Get()
        {
            return _productService.GetAll();
        }

        [HttpGet("{productId}")]
        public Product Get(int id)
        {
            return _productService.GetAll().FirstOrDefault(x=>x.ProductId==id);
        }

        [HttpPost]
        public Product Post([FromBody] Product product)
        {
            _productService.Add(product);
            return product;
        }

        [HttpPut("{productId}")]
        public Product Put(int id, [FromBody] Product product)
        {
            _productService.Update(product);
            return product;
        }

        [HttpDelete("{productId}")]
        public void Delete(int id)
        {
            _productService.Remove(new Product { ProductId = id});
        }
        [HttpGet("{searchString}")]
        public IEnumerable<Product> GetSearch(string searchString)
        {
            var searching = _productService.Search(searchString);
            return searching;
        }
    }
}
