using Core_Proje.Areas.Writer.Models;
using Microsoft.AspNetCore.Mvc;

namespace Core_Proje.Areas.Writer.Controllers
{
    [Area("Writer")]
    public class RegisterController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(UserRegisterViewModel userRegisterViewModel)
        {
            if (ModelState.IsValid)
            {

            }
            return View();
        }
    }
}
