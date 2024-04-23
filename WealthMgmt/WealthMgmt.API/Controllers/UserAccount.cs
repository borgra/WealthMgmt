using Microsoft.AspNetCore.Mvc;

namespace WealthMgmt.API.Controllers
{
    public class UserAccount : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
