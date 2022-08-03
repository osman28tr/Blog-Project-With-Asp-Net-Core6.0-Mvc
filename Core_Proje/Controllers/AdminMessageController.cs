using BusinessLayer.Concrete;
using DataAccessLayer.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;

namespace Core_Proje.Controllers
{
    public class AdminMessageController : Controller
    {
        WriterMessageManager writerMessageManager = new WriterMessageManager(new EfWriterMessageDal());
        public IActionResult ReceiverMessageList()
        {
            string mail = "admin@gmail.com";
            var values = writerMessageManager.GetReceiverMessageList(mail);
            return View(values);
        }
        public IActionResult SenderMessageList()
        {
            string mail = "admin@gmail.com";
            var values = writerMessageManager.GetSenderMessageList(mail);
            return View(values);
        }
        public IActionResult AdminMessageDetails(int id)
        {
            var values = writerMessageManager.TGetById(id);
            return View(values);
        }
        public IActionResult AdminMessageDelete(int id)
        {
            var values = writerMessageManager.TGetById(id);
            writerMessageManager.TDelete(values);
            return RedirectToAction("SenderMessageList");
        }
    }
}
