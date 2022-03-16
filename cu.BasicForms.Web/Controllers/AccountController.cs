using cu.BasicForms.Web.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace cu.BasicForms.Web.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Login()
        {
            AccountLoginViewModel accountLoginViewModel = new AccountLoginViewModel();
            accountLoginViewModel.RememberMe = true;
            return View(accountLoginViewModel);
        }

        [HttpPost]
        public IActionResult Login(AccountLoginViewModel
            accountLoginViewModel)
        {
            //validate user
            //if ok => send to admin page
            
            return RedirectToAction("AdminHome");
        }

        [HttpGet]
        public IActionResult AdminHome()
        {
            return View();
        }
    }
}
