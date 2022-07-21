using BusinessLayer.Concrete;
using DataAccessLayer.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;

namespace Core_Proje.Controllers
{
	public class ExperienceController : Controller
	{
		ExperienceManager experienceManager = new ExperienceManager(new EfExperienceDal()); 
		public IActionResult Index()
		{
			ViewBag.value1 = "Deneyim listesi";
			ViewBag.value2 = "Deneyimler";
			ViewBag.value3 = "Deneyim listesi";
			var values = experienceManager.TGetList();
			return View(values);
		}
	}
}
