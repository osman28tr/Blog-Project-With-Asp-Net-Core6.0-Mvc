using BusinessLayer.Concrete;
using DataAccessLayer.EntityFrameworkCore;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace Core_Proje.Controllers
{
    public class ServiceController : Controller
    {
        ServiceManager serviceManager = new ServiceManager(new EfServiceDal());
        public IActionResult Index()
        {
            ViewBag.value1 = "Hizmet listesi";
            ViewBag.value2 = "Hizmetler";
            ViewBag.value3 = "Hizmet listesi";
            var values = serviceManager.TGetList();
            return View(values);
        }
		[HttpGet]
		public IActionResult AddService()
		{
			ViewBag.value1 = "Hizmet listesi";
			ViewBag.value2 = "Hizmetler";
			ViewBag.value3 = "Hizmet ekleme";
			return View();
		}
		[HttpPost]
		public IActionResult AddService(Service service)
		{
			serviceManager.TAdd(service);
			return RedirectToAction("Index");
		}
		public IActionResult DeleteService(int id)
		{
			var serviceValue = serviceManager.TGetById(id);
			serviceManager.TDelete(serviceValue);
			return RedirectToAction("Index");
		}
		[HttpGet]
		public IActionResult EditService(int id)
		{
			ViewBag.value1 = "Hizmet listesi";
			ViewBag.value2 = "Hizmetler";
			ViewBag.value3 = "Hizmet düzenleme";
			var serviceValue = serviceManager.TGetById(id);
			return View(serviceValue);
		}
		[HttpPost]
		public IActionResult EditService(Service service)
		{
			serviceManager.TUpdate(service);
			return RedirectToAction("Index");
		}
	}
}
