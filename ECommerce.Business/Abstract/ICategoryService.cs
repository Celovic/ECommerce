using ECommerce.Entities.Entities.Concrete;
using ECommerce.Repository.EnityFramework.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Business.Abstract
{
    public interface ICategoryService : IGenericRepository<Category>
    {
        IEnumerable<Category> Included();
        void DeleteWithProduct(int id);
        IEnumerable<Category> Search(string searchString);
    }
}
