using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Xml.Linq;

namespace Core_Proje.Areas.Writer.Controllers
{
    [Area("Writer")]
    [Authorize(Roles = "Admin")]
    [Authorize(Roles = "Writer")]
    public class DashboardController : Controller
    {
        private readonly UserManager<WriterUser> _userManager;
        StatisticManager statisticManager = new StatisticManager();
        public DashboardController(UserManager<WriterUser> userManager)
        {
            _userManager = userManager;
        }
        public async Task<IActionResult> Index()
        {
            var values = await _userManager.FindByNameAsync(User.Identity.Name);
            ViewBag.value = values.Name + " " + values.Surname;

            
            //weather api

            string api = "14ad2aba611dbef9c504b82a127794c5";
            string connection = "http://api.openweathermap.org/data/2.5/weather?q=istanbul&mode=xml&lang=tr&units=metric&appid=" + api;
            XDocument document = XDocument.Load(connection);
            ViewBag.value6 = document.Descendants("temperature").ElementAt(0).Attribute("value").Value;

            //statistics
            Context context = new Context();
            ViewBag.value1 = context.WriterMessages.Where(x => x.Receiver == values.Email).Count();           
            ViewBag.value2 = statisticManager.DuyuruSayisi();
            ViewBag.value3 = context.Users.Count();
            ViewBag.value4 = statisticManager.ToplamYetenekSayisi();

            return View();
        }
    }
}
