using Microsoft.AspNetCore.Mvc;

namespace WealthMgmt.API.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
