using BusinessLayer.Concrete;
using DataAccessLayer.EntityFrameworkCore;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Core_Proje.Controllers
{
	[Authorize(Roles = "Admin")]
	public class AboutController : Controller
    {
		AboutManager aboutManager = new AboutManager(new EfAboutDal());
		[HttpGet]
		public IActionResult EditAbout()
		{
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
