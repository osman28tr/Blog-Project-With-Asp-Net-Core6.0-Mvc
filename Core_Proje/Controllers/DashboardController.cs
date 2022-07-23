using Microsoft.AspNetCore.Mvc;

namespace Core_Proje.Controllers
{
    public class DashboardController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.value1 = "Dashboard";
            ViewBag.value2 = "İstatistikler";
            ViewBag.value3 = "İstatistik sayfası";
            return View();
        }
    }
}
