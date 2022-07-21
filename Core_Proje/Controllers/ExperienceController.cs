using BusinessLayer.Concrete;
using DataAccessLayer.EntityFrameworkCore;
using EntityLayer.Concrete;
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
		[HttpGet]
		public IActionResult AddExperience()
		{
			ViewBag.value1 = "Deneyim listesi";
			ViewBag.value2 = "Deneyimler";
			ViewBag.value3 = "Deneyim listesi";
			return View();
		}
		[HttpPost]
		public IActionResult AddExperience(Experience experience)
		{
			experienceManager.TAdd(experience);
			return RedirectToAction("Index");
		}
		public IActionResult DeleteExperience(int id)
		{
			var experienceValue = experienceManager.TGetById(id);
			experienceManager.TDelete(experienceValue);
			return RedirectToAction("Index");
		}
		[HttpGet]
		public IActionResult EditExperience(int id)
		{
			ViewBag.value1 = "Düzenleme";
			ViewBag.value2 = "Deneyimler";
			ViewBag.value3 = "Deneyim güncelleme";
			var experienceValue = experienceManager.TGetById(id);
			return View(experienceValue);
		}
		[HttpPost]
		public IActionResult EditExperience(Experience experience)
		{
			experienceManager.TUpdate(experience);
			return RedirectToAction("Index");
		}
	}
}
