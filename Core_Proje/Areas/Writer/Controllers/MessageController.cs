using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFrameworkCore;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace Core_Proje.Areas.Writer.Controllers
{
    [Area("Writer")]
    public class MessageController : Controller
    {
        WriterMessageManager writerMessageManager = new WriterMessageManager(new EfWriterMessageDal());
        private readonly UserManager<WriterUser> _userManager;
        public MessageController(UserManager<WriterUser> userManager)
        {
            _userManager = userManager;
        }
        public async Task<IActionResult> ReceiverMessage(string writerMail)
        {
            var values = await _userManager.FindByNameAsync(User.Identity.Name);
            writerMail = values.Email;
            var messageList = writerMessageManager.GetReceiverMessageList(writerMail);
            return View(messageList);
        }
        public async Task<IActionResult> SenderMessage(string writerMail)
        {
            var values = await _userManager.FindByNameAsync(User.Identity.Name);
            writerMail = values.Email;
            var messageList = writerMessageManager.GetSenderMessageList(writerMail);
            return View(messageList);
        }
        public IActionResult MessageDetails(int id)
        {
            var values = writerMessageManager.TGetById(id);
            return View(values);
        }
        public IActionResult ReceiverMessageDetails(int id)
        {
            var values = writerMessageManager.TGetById(id);
            return View(values);
        }
        [HttpGet]
        public IActionResult SendMessage()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> SendMessage(WriterMessage writerMessage)
        {
            var values = await _userManager.FindByNameAsync(User.Identity.Name);
            string mail = values.Email;
            string name = values.Name + " " + values.Surname;
            writerMessage.Sender = mail;
            writerMessage.Date = Convert.ToDateTime(DateTime.Now.ToShortDateString());
            writerMessage.SenderName = name;
            Context context = new Context();
            var userNameSurname = context.Users.Where(x => x.Email == writerMessage.Receiver).Select(y => y.Name + " " + y.Surname).FirstOrDefault();
            writerMessage.ReceiverName = userNameSurname;
            writerMessageManager.TAdd(writerMessage);
            return RedirectToAction("SenderMessage", "Message");
        }
    }
}
