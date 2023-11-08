using Microsoft.AspNetCore.Mvc;

namespace EjT6_HelloWorld.Controllers
{
    public class ProductosController1 : Controller
    {
        public IActionResult ListadoProductos()
        {
            return View();
        }
    }
}
