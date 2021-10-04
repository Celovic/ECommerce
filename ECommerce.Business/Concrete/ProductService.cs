using ECommerce.Business.Abstract;
using ECommerce.Entities.Context;
using ECommerce.Entities.Entities.Concrete;
using ECommerce.Repository.EnityFramework.Concrete;
using System;
using System.Threading.Tasks;

using System.Linq;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace ECommerce.Business.Concrete
{
    public class ProductService : GenericRepository<Product, ECommerceDbContext>, IProductService
    {
        readonly ECommerceDbContext _context;
        public ProductService(ECommerceDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Product> Search(string searchString)
        {
            var x = _context.TBLCategory.Include("Product");

            var search = _context.TBLProduct.Include("Category");
            if (!String.IsNullOrEmpty(searchString))
            {
                search = search.Where(x => x.ProductTitle.Contains(searchString) ||
                x.ProductDescription.Contains(searchString) ||
                x.Category.CategoryName.Contains(searchString));
            }
            return search.ToList();
        }
        public IEnumerable<Product> GetProductsWithCategory(string p)
        {
            return _context.TBLProduct.Include("Category");
        }

        public List<Product> GetByCategory(int categoryId)
        {
            return _context.TBLProduct.Where(p => p.CategoryId == categoryId || categoryId == 0).ToList();
        }
    }
}
