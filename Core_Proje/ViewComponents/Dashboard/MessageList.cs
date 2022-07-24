using BusinessLayer.Concrete;
using DataAccessLayer.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;

namespace Core_Proje.ViewComponents.Dashboard
{
    public class MessageList:ViewComponent
    {
        MessageManager messageManager = new MessageManager(new EfMessageDal());
        public IViewComponentResult Invoke()
        {
            return View();  
        }
    }
}
