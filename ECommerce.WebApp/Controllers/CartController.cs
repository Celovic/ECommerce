using ECommerce.WebApp.CartServices.Abstract;
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
        public CartController(ICartSessionService cartSessionService)
        {
            _cartSessionService = cartSessionService;
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
