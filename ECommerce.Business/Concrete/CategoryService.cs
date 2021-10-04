using ECommerce.Business.Abstract;
using ECommerce.Entities.Context;
using ECommerce.Entities.Entities.Concrete;
using ECommerce.Repository.EnityFramework.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace ECommerce.Business.Concrete
{
    public class CategoryService : GenericRepository<Category,ECommerceDbContext>,ICategoryService
    {
        readonly ECommerceDbContext _context;
        public CategoryService(ECommerceDbContext context)
        {
            _context = context;
        }

        public void DeleteWithProduct(int id)
        {
            var q = _context.TBLProduct.Where(x => x.CategoryId == id);
            foreach (var item in q)
            {
                _context.TBLProduct.Remove(new Product { ProductId = item.ProductId });
            }
            _context.TBLCategory.Remove(new Category { CategoryId = id });
            _context.SaveChanges();
        }
        public IEnumerable<Category> Included()
        {
            var joinProduct= _context.TBLCategory.Include("Product").ToList();
            return joinProduct;
        }
        public IEnumerable<Category> Search(string searchString)
        {
            var search = _context.TBLCategory.ToList();
            if (!String.IsNullOrEmpty(searchString))
            {
                search = search.Where(x => x.CategoryName == searchString).ToList();
            }
            return search.ToList();
        }
    }
}
