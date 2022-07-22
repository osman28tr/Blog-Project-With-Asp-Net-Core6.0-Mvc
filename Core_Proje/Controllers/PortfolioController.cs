using BusinessLayer.Concrete;
using BusinessLayer.ValidationRules;
using DataAccessLayer.EntityFrameworkCore;
using EntityLayer.Concrete;
using FluentValidation.Results;
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
            PortfolioValidator validations = new PortfolioValidator();
            ValidationResult results = validations.Validate(portfolio);
            
            if (results.IsValid)
            {
                portfolioManager.TAdd(portfolio);
                return RedirectToAction("Index");
            }
            else
            {
                foreach (var item in results.Errors)
                {
                    ModelState.AddModelError(item.PropertyName,item.ErrorMessage.ToString());
                }
            }
            return View();
        }
        public IActionResult DeletePortfolio(int id)
        {
            var portfolioValue = portfolioManager.TGetById(id);
            portfolioManager.TDelete(portfolioValue);
            return RedirectToAction("Index");
        }
    }
}
