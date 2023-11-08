using Microsoft.AspNetCore.Mvc;

namespace EjT6_HelloWorld.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        
        public String Apellidos()
        {
            return "Mati";
        }

        public IActionResult Saludo()
        {
      
            return View();
        }

    }
}

