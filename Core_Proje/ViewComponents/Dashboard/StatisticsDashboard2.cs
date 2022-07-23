using DataAccessLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace Core_Proje.ViewComponents.Dashboard
{
    public class StatisticsDashboard2:ViewComponent
    {
        Context context = new Context();
        public IViewComponentResult Invoke()
        {
            ViewBag.value1 = context.Portfolios.Where(x => x.Value == 100).Count();
            ViewBag.value2 = context.Messages.Count();
            ViewBag.value3 = context.Services.Count();

            return View();
        }
    }
}
