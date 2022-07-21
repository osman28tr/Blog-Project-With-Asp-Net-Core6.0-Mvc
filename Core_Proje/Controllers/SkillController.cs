﻿using BusinessLayer.Concrete;
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
	}
}
