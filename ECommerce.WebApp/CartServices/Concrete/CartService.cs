using ECommerce.Entities.Entities.Concrete;
using System.Collections.Generic;
using System.Linq;

namespace ECommerce.WebApp.CartServices.Concrete
{
    public class CartService : ICartService
    {
        public void AddToCart(Cart cart, Product product)
        {
            CartLine cartLine = cart.CartLines.FirstOrDefault(c => c.Product.ProductId == product.ProductId);
            if (cartLine != null)
            {
                cartLine.Quantity++;
                return;
            }
            cart.CartLines.Add(new CartLine { Product = product, Quantity = 1 });
        }

        public List<CartLine> List(Cart cart)
        {
            return cart.CartLines;
        }

        public void RemoveFromCart(Cart cart, int productId)
        {
            var query = cart.CartLines.FirstOrDefault(x => x.Product.ProductId == productId);
            if (query.Quantity > 1)
            {
                query.Quantity -= 1;
                return;
            }
            else
            {
                cart.CartLines.Remove(cart.CartLines.FirstOrDefault(c => c.Product.ProductId == productId));
            }

        }
    }
}
