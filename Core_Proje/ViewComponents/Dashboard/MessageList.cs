using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;

namespace Core_Proje.ViewComponents.Dashboard
{
    public class MessageList:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();  
        }
    }
}
