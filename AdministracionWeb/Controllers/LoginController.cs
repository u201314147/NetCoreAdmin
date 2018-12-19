using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using AdministracionWeb.Models;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace AdministracionWeb.Controllers
{
    [Route("Login")]
    public class LoginController : Controller
    {
        [HttpGet]
        public IActionResult Login()
        {
            return View("Login", new Credenciales());
        }

        [HttpPost]
        public async Task<IActionResult> Login(Credenciales credenciales)
        {
            if (ModelState.IsValid)
            {
                var isValid = (credenciales.usuario == "username" && credenciales.clave == "password");
                if (!isValid)
                {
                    ModelState.AddModelError("", "usuario o contaseña no validos");
                    return View();
                }
                var identity = new ClaimsIdentity(CookieAuthenticationDefaults.AuthenticationScheme, ClaimTypes.Name, ClaimTypes.Role);
                identity.AddClaim(new Claim(ClaimTypes.NameIdentifier, credenciales.usuario));
                identity.AddClaim(new Claim(ClaimTypes.Name, credenciales.clave));
                var principal = new ClaimsPrincipal(identity);
                await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, principal, new AuthenticationProperties { IsPersistent = credenciales.RememberMe });
                return RedirectToPage("Empleados");
            }
            else
            {
                ModelState.AddModelError("", "usuario o contraseña en blanco");
                return View();
            }
        }

    }
}