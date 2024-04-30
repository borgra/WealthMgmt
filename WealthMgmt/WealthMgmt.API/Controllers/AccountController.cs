using Microsoft.AspNetCore.Mvc;

namespace WealthMgmt.API.Controllers
{
    //[Route("[controller]/v1")]
    public class AccountController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
