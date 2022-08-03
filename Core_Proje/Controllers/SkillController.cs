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
			var values = skillManager.TGetList();
			return View(values);
		}
        [HttpGet]
		public IActionResult AddSkill()
        {
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
