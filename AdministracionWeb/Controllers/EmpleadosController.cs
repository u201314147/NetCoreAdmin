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

        [Route("")]
        public IActionResult Empleados()
        {
            ViewBag.empleados = db.Empleados.ToList();
            return View();
        }

        [HttpGet]
        [Route("Agregar")]
        public IActionResult Agregar()
        {
            return View("Agregar", new Empleados());
        }

        [HttpPost]
        [Route("Agregar")]
        public IActionResult Agregar(Empleados empleado)
        {
            db.Empleados.Add(empleado);
            db.SaveChanges();
            return RedirectToAction("Empleados");
        }

        [HttpGet]
        [Route("Borrar/{id}")]
        public IActionResult Borrar(int id)
        {
            db.Remove(db.Empleados.Find(id));
            db.SaveChanges();
            return RedirectToAction("Empleados");
        }


        [HttpGet]
        [Route("Editar/{id}")]
        public IActionResult Editar(int id)
        {
            return View("Editar", db.Empleados.Find(id));
        }


        [HttpPost]
        [Route("Editar/{id?}")]
        public IActionResult Editar(int id, Empleados empleado)
        {
            db.Entry(empleado).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            db.SaveChanges();
            return RedirectToAction("Empleados");
        }
    }
}