using Core_Proje.Areas.Writer.Models;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace Core_Proje.Areas.Writer.Controllers
{
    [Area("Writer")]
    public class RegisterController : Controller
    {
        //private readonly UserManager<WriterUser> _userManager;
        //public RegisterController(UserManager<WriterUser> userManager)
        //{
        //    _userManager = userManager;
        //}

        [HttpGet]
        public IActionResult Index()
        {
            return View(new UserRegisterViewModel());
        }
        [HttpPost]
        public async Task<IActionResult> Index(UserRegisterViewModel userRegisterViewModel)
        {
            //if (ModelState.IsValid)
            //{
            //    WriterUser writerUser = new WriterUser()
            //    {
            //        Name = userRegisterViewModel.Name,
            //        Surname = userRegisterViewModel.Surname,
            //        Email = userRegisterViewModel.Mail,
            //        UserName = userRegisterViewModel.UserName,
            //        ImageUrl = userRegisterViewModel.ImageUrl
            //    };

            //    var result = await _userManager.CreateAsync(writerUser, userRegisterViewModel.Password);

            //    if (result.Succeeded)
            //    {
            //        return RedirectToAction("Index", "Login");
            //    }
            //    else
            //    {
            //        foreach (var item in result.Errors)
            //        {
            //            ModelState.AddModelError("", item.Description);
            //        }
            //    }
            //}

            return View();
        }
    }
}
