using BusinessLayer.Concrete;
using DataAccessLayer.EntityFrameworkCore;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace Core_Proje.Controllers
{
    public class AboutController : Controller
    {
		AboutManager aboutManager = new AboutManager(new EfAboutDal());
		[HttpGet]
		public IActionResult EditAbout()
		{
			ViewBag.value1 = "Düzenleme";
			ViewBag.value2 = "Hakkımda";
			ViewBag.value3 = "Hakkımda Sayfası";
			var aboutValue = aboutManager.TGetById(2);
			return View(aboutValue);
		}
		[HttpPost]
		public IActionResult EditAbout(About about)
		{
			aboutManager.TUpdate(about);
			return RedirectToAction("Index", "Default");
		}
	}
}
