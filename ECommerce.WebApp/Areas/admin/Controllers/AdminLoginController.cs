using ECommerce.WebApp.Areas.admin.Data;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace ECommerce.WebApp.Areas.admin.Controllers
{
    [Area("admin")]
    public class AdminLoginController : Controller
    {
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Login(AdminLoginModel model)
        {
            model = new AdminLoginModel
            {
                AdminName = Request.Form["AdminName"],
                Password = Request.Form["Password"]
            };

            if (model.AdminName == "Celal" & model.Password == "Domates123.")
            {
                var adminclaims = new List<Claim>
                {
                    new Claim("AdminName",model.AdminName),
                    new Claim(ClaimTypes.Role,"Admin"),

                };
                var adminidentity = new ClaimsIdentity(adminclaims, CookieAuthenticationDefaults.AuthenticationScheme);
                await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme,
                    new ClaimsPrincipal(adminidentity));
                return RedirectToAction("Index", "Default");
            }
            return View();
        }
    }
}
