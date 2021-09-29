using ECommerce.Entities.Entities.Concrete;
using System.Collections.Generic;

namespace ECommerce.WebApp.CartServices.Concrete
{
    public interface ICartService
    {
        void AddToCart(Cart cart, Product product);
        void RemoveFromCart(Cart cart, int productId);
        List<CartLine> List(Cart cart);
    }
}
