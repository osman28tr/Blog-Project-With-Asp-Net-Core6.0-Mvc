using BusinessLayer.Concrete;
using DataAccessLayer.EntityFrameworkCore;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Core_Proje.Controllers
{
	[Authorize(Roles = "Admin")]
	public class FeatureController : Controller
	{
		FeatureManager featureManager = new FeatureManager(new EfFeatureDal());
        [HttpGet]
		public IActionResult EditFeature()
		{
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
