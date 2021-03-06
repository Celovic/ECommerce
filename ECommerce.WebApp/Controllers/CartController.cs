using ECommerce.Business.Abstract;
using ECommerce.Entities.Context;
using ECommerce.Entities.Entities.Concrete;
using ECommerce.WebApp.CartServices.Abstract;
using ECommerce.WebApp.CartServices.Concrete;
using ECommerce.WebApp.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ECommerce.WebApp.Controllers
{
    public class CartController : Controller
    {
        readonly ICartSessionService _cartSessionService;
        readonly ICartService _cartService;
        readonly IProductService _productService;
        public CartController(ICartSessionService cartSessionService, ICartService cartService, IProductService productService)
        {
            _cartSessionService = cartSessionService;
            _cartService = cartService;
            _productService = productService;
        }
        public async Task<IActionResult> AddToCart(Product product)
        {
            var productToBeAdded = _productService.GetById(product.ProductId);
            var cart = _cartSessionService.GetCart();
            _cartService.AddToCart(cart, await productToBeAdded);
            _cartSessionService.SetCart(cart);
            TempData.Add("message", "{0} The product has been added to your cart");
            return RedirectToAction("Index", "Home");
        }
        public IActionResult CartList()
        {
            var cart = _cartSessionService.GetCart();
            ViewModel model = new ViewModel()
            {
                Cart = cart
            };
            return View(model);
        }
        public IActionResult RemoveToCart(int productId)
        {
            var cart = _cartSessionService.GetCart();
            _cartService.RemoveFromCart(cart, productId);
            _cartSessionService.SetCart(cart);
            return RedirectToAction("CartList");
        }

        public IActionResult CompleteShopping()
        {
            var shopping = new ViewModel
            {
                ShoppingDetails = new ShoppingDetails()
            };
            return View(shopping);
        }
        [HttpPost]
        public IActionResult CompleteShopping(ShoppingDetails shopping)
        {
            if (ModelState.IsValid)
            {
                var cart = _cartSessionService.GetCart();
                foreach (var item in cart.CartLines)
                {
                    var remainingStock = item.Product.StockQuantity - item.Quantity;
                    Product product = new Product
                    {
                        ProductId = item.Product.ProductId,
                        Category = item.Product.Category,
                        CategoryId = item.Product.CategoryId,
                        ProductTitle = item.Product.ProductTitle,
                        ProductDescription = item.Product.ProductDescription,
                        StockQuantity = remainingStock
                    };
                    if (product.StockQuantity<0)
                    {
                        TempData.Add("message", "this product is out of stock {0}");
                        return RedirectToAction("CartList","Cart");
                    }
                    _productService.Update(product);
                    TempData.Add("message", "your information has been received");
                }
                cart.CartLines.Clear();
                _cartSessionService.SetCart(cart);
                return RedirectToAction("Index", "Home");
            }
            TempData.Add("message", "your information hasn't been received");
            return View();
        }
    }
}
