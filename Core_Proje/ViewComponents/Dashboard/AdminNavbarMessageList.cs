using BusinessLayer.Concrete;
using DataAccessLayer.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;

namespace Core_Proje.ViewComponents.Dashboard
{
    public class AdminNavbarMessageList : ViewComponent
    {
        WriterMessageManager writerMessageManager = new WriterMessageManager(new EfWriterMessageDal());
        public IViewComponentResult Invoke()
        {
            string mail = "admin@gmail.com";
            var values = writerMessageManager.GetReceiverMessageList(mail).OrderByDescending(x => x.WriterMessageId).Take(3).ToList();
            return View(values);
        }
    }
}
