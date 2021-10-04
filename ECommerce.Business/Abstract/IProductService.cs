using ECommerce.Entities.Entities.Concrete;
using ECommerce.Repository.EnityFramework.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Business.Abstract
{
    public interface IProductService : IGenericRepository<Product>
    {
        public IEnumerable<Product> Search(string searchString);
        public IEnumerable<Product> GetProductsWithCatgory(string p);
        List<Product> GetByCategory(int categoryId);

    }
}
