using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFrameworkCore;
using EntityLayer.Concrete;
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
        [HttpGet]
        public IActionResult AdminMessageAdd()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AdminMessageAdd(WriterMessage writerMessage)
        {
            writerMessage.Sender = "admin@gmail.com";
            writerMessage.SenderName = "Admin";
            writerMessage.Date = DateTime.Parse(DateTime.Now.ToShortDateString());
            Context context = new Context();
            var userNameSurname = context.Users.Where(x => x.Email == writerMessage.Receiver).Select(y => y.Name + " " + y.Surname).FirstOrDefault();
            writerMessage.ReceiverName = userNameSurname;
            writerMessageManager.TAdd(writerMessage);
            return RedirectToAction("SenderMessageList");
        }
        public IActionResult AdminMessageDelete(int id)
        {
            var values = writerMessageManager.TGetById(id);
            writerMessageManager.TDelete(values);
            return RedirectToAction("SenderMessageList");
        }
    }
}
