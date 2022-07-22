using BusinessLayer.Concrete;
using DataAccessLayer.EntityFrameworkCore;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace Core_Proje.Controllers
{
	public class FeatureController : Controller
	{
		FeatureManager featureManager = new FeatureManager(new EfFeatureDal());
        [HttpGet]
		public IActionResult EditFeature()
		{
			ViewBag.value1 = "Düzenleme";
			ViewBag.value2 = "Öne Çıkanlar";
			ViewBag.value3 = "Öne Çıkan Sayfası";
			var featureValue = featureManager.TGetById(1);
			return View(featureValue);
		}
		[HttpPost]
		public IActionResult EditFeature(Feature feature)
		{
			featureManager.TUpdate(feature);
			return RedirectToAction("Index","Default");
		}
	}
}
