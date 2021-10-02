﻿using ECommerce.Business.Abstract;
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
        public IActionResult AddToCart(Product product)
        {
            var productToBeAdded = _productService.GetById(product.ProductId);
            var cart = _cartSessionService.GetCart();
            _cartService.AddToCart(cart, productToBeAdded);
            _cartSessionService.SetCart(cart);
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
            return RedirectToAction("List");
        }
    }
}
