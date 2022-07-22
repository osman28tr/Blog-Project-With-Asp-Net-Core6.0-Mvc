using BusinessLayer.Concrete;
using DataAccessLayer.EntityFrameworkCore;
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
    }
}
