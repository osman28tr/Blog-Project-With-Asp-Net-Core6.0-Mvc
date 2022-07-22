using BusinessLayer.Concrete;
using DataAccessLayer.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;

namespace Core_Proje.Controllers
{
    public class PortfolioController : Controller
    {
        PortfolioManager portfolioManager = new PortfolioManager(new EfPortfolioDal());
        public IActionResult Index()
        {
            ViewBag.value1 = "Proje listesi";
            ViewBag.value2 = "Projelerim";
            ViewBag.value3 = "Proje listesi";
            var values = portfolioManager.TGetList();
            return View(values);
        }
    }
}
