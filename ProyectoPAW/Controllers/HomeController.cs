using Microsoft.AspNetCore.Mvc;
using ProyectoPAW.Models;
using System.Diagnostics;

namespace ProyectoPAW.Controllers
{
    [ResponseCache(NoStore = true, Duration = 0)]
    public class HomeController : Controller
    {
        public HomeController()
        {

        }

        public IActionResult Inicio()
        {
            return View();
        }

        public IActionResult Ingresar()
        {
            
            return View();
            HttpContext.Session.Clear();

        }

        public IActionResult Registrar()
        {
            
            return View();
            HttpContext.Session.Clear();
        }

    }
}
