using ECommerce.Entities.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ECommerce.WebApp.Models
{
    public class ViewModel
    {
        public IEnumerable<Product> Products { get; set; }
        public IEnumerable<Category> Categories { get; set; }
        public Product Product { get; set; }
        public Category Category { get; set; }
        public Cart Cart { get; set; }
        public CartLine CartLine { get; set; }
        public ShoppingDetails ShoppingDetails{ get; set; }
       
    }
}
