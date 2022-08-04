using Microsoft.AspNetCore.Mvc;

namespace Core_Proje.ViewComponents.Dashboard
{
    public class AdminNavbarMessageList:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
