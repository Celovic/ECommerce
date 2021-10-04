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
            var query = cart.CartLines.FirstOrDefault(c => c.Product.ProductId == productId);
            if (query.Quantity > 0)
            {
                var remainingQuantity1 = cart.CartLines.Where(x => x.Product.ProductId == productId).Select(y => { y.Quantity -= 1; return y; });
            }
            else
            {
                cart.CartLines.Remove(cart.CartLines.FirstOrDefault(c => c.Product.ProductId == productId));

            }
        }
    }
}
