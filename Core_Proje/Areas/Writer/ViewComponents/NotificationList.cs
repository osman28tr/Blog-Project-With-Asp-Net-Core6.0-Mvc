using Microsoft.AspNetCore.Mvc;

namespace Core_Proje.Areas.Writer.ViewComponents
{
    public class NotificationList:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
