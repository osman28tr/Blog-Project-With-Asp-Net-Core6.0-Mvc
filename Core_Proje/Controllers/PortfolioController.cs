using BusinessLayer.Concrete;
using DataAccessLayer.EntityFrameworkCore;
using EntityLayer.Concrete;
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
        [HttpGet]
        public IActionResult AddPortfolio()
        {
            ViewBag.value1 = "Proje listesi";
            ViewBag.value2 = "Projelerim";
            ViewBag.value3 = "Proje ekleme";
            return View();
        }
        [HttpPost]
        public IActionResult AddPortfolio(Portfolio portfolio)
        {      
            portfolioManager.TAdd(portfolio);
            return RedirectToAction("Index");
        }
    }
}
