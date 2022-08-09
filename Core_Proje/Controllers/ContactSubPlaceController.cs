using BusinessLayer.Concrete;
using DataAccessLayer.EntityFrameworkCore;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Core_Proje.Controllers
{
	[Authorize(Roles = "Admin")]
	public class ContactSubPlaceController : Controller
    {
		ContactManager contactManager = new ContactManager(new EfContactDal());
		[HttpGet]
		public IActionResult Index()
		{
			var contactValue = contactManager.TGetById(1);
			return View(contactValue);
		}
		[HttpPost]
		public IActionResult Index(Contact contact)
		{
			contactManager.TUpdate(contact);
			return RedirectToAction("Index", "Default");
		}
	}
}
