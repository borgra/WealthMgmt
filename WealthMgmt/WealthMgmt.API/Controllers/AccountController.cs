using Microsoft.AspNetCore.Mvc;
using WealthMgmt.Core.Application.DTO;

namespace WealthMgmt.API.Controllers
{
    //[Route("[controller]/v1")]
    public class AccountController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        //[Route("/Account/{id}")]
        //public async Task<ActionResult<AccountDTO>> GetAccountAsync(int id)
        //{
        //    return null;
        //}

    }
}
