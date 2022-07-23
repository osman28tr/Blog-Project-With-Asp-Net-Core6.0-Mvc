using DataAccessLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace Core_Proje.ViewComponents.Dashboard
{
    public class FeatureStatistics:ViewComponent
    {
        Context context = new Context();
        public IViewComponentResult Invoke()
        {
            ViewBag.static1 = context.Skills.Count();
            ViewBag.static2 = context.Messages.Where(x => x.Status == false).Count();
            ViewBag.static3 = context.Messages.Where(x => x.Status == true).Count();
            ViewBag.static4 = context.Experiences.Count();

            return View();
        }
    }
}
