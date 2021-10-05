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

        public ProductController(IProductService productService)
        {
            _productService = productService;
        }
        [HttpGet]
        public async Task<IEnumerable<Product>> Get()
        {
            return await _productService.GetAll();
        }

        [HttpGet("{productId}")]
        public async Task<Product> Get(int id)
        {
            return (await _productService.GetAll().ConfigureAwait(false)).FirstOrDefault(x => x.ProductId == id);
        }

        [HttpPost]
        public Product Post([FromBody] Product product)
        {
            _productService.Add(product);
            return product;
        }

        [HttpPut("{productId}")]
        public Product Put(int productId, [FromBody] Product product)
        {
            _productService.Update(product);
            return product;
        }

        [HttpDelete("{productId}")]
        public void Delete(int productId)
        {
            _productService.Remove(new Product { ProductId = productId });
        }
        [HttpGet("GetSearchProduct/{searchString}")]
        public IEnumerable<Product> GetSearchProduct(string searchString)
        {
            return _productService.Search(searchString);
        }
    }
}
