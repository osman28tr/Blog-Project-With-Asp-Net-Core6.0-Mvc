using BusinessLayer.Concrete;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace Core_Proje.Areas.Writer.Controllers
{
    [Area("Writer")]
    public class DashboardController : Controller
    {
        private readonly UserManager<WriterUser> _userManager;
        StatisticManager statisticManager = new StatisticManager();
        public DashboardController(UserManager<WriterUser> userManager)
        {
            _userManager = userManager;
        }
        public async Task<IActionResult> Index()
        {
            var values = await _userManager.FindByNameAsync(User.Identity.Name);
            ViewBag.value = values.Name + " " + values.Surname;

            //statistics
            ViewBag.value1 = statisticManager.GelenMesajSayisi();
            ViewBag.value2 = statisticManager.DuyuruSayisi();
            ViewBag.value3 = statisticManager.ToplamKullaniciSayisi();
            ViewBag.value4 = statisticManager.ToplamYetenekSayisi();

            return View();
        }
    }
}
