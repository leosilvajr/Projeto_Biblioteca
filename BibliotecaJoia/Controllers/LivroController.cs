using Microsoft.AspNetCore.Mvc;

namespace BibliotecaJoia.Controllers
{
    public class LivroController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
