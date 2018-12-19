using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AdministracionWeb.Models;
using Microsoft.AspNetCore.Mvc;

namespace AdministracionWeb.Controllers
{

    [Route("Empleados")]
    public class EmpleadosController : Controller
    {
        private DataContext db = new DataContext();

       // [Route("")]
       // [Route("~/")]

        public IActionResult Empleados()
        {
            ViewBag.empleados = db.Empleados.ToList();
            return View();
        }
    }
}