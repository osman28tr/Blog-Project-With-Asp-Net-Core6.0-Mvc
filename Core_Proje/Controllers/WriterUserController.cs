using Microsoft.AspNetCore.Mvc;

namespace Core_Proje.Controllers
{
    public class WriterUserController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
