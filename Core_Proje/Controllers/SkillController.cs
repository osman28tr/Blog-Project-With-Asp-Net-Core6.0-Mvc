using BusinessLayer.Concrete;
using DataAccessLayer.EntityFrameworkCore;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace Core_Proje.Controllers
{
	public class SkillController : Controller
	{
		SkillManager skillManager = new SkillManager(new EfSkillDal());

		public IActionResult Index()
		{
			ViewBag.value1 = "Yetenek listesi";
			ViewBag.value2 = "Yetenekler";
			ViewBag.value3 = "Yetenek listesi";
			var values = skillManager.TGetList();
			return View(values);
		}
        [HttpGet]
		public IActionResult AddSkill()
        {
			ViewBag.value1 = "Yetenek ekleme";
			ViewBag.value2 = "Yetenekler";
			ViewBag.value3 = "Yetenek ekleme";
			return View();
        }
        [HttpPost]
		public IActionResult AddSkill(Skill skill)
        {
			skillManager.TAdd(skill);
			return RedirectToAction("Index");
        }
		public IActionResult DeleteSkill(int id)
		{
			var skillValue = skillManager.TGetById(id);
			skillManager.TDelete(skillValue);
			return RedirectToAction("Index");
		}
		[HttpGet]
		public IActionResult EditSkill(int id)
		{
			ViewBag.value1 = "Düzenleme";
			ViewBag.value2 = "Yetenekler";
			ViewBag.value3 = "Yetenek güncelleme";
			var skillValue = skillManager.TGetById(id);
			return View(skillValue);
		}
		[HttpPost]
		public IActionResult EditSkill(Skill skill)
		{
			skillManager.TUpdate(skill);
			return RedirectToAction("Index");
		}
	}
}
