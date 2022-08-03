using BusinessLayer.Concrete;
using DataAccessLayer.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;

namespace Core_Proje.Controllers
{
    public class ContactController : Controller
    {
        MessageManager messageManager = new MessageManager(new EfMessageDal());
        public IActionResult Index()
        {
            var values = messageManager.TGetList();
            return View(values);
        }
        public IActionResult DeleteContact(int id)
        {
            var values = messageManager.TGetById(id);
            messageManager.TDelete(values);
            return RedirectToAction("Index");
        }
        public IActionResult ContactDetails(int id)
        {
            var values = messageManager.TGetById(id);
            return View(values);
        }
    }
}
