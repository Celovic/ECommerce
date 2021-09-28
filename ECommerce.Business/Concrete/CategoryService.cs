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
        public IEnumerable<Category> Included(string p)
        {
            var joinProduct= _context.TBLCategory.Include("TBLProduct").ToList();
            return joinProduct;
        }
    }
}
