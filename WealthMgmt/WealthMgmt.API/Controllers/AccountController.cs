using MediatR;
using Microsoft.AspNetCore.Mvc;
using WealthMgmt.Core.Application.UseCase.Account.Queries.GetAccountById;

namespace WealthMgmt.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AccountController(IMediator mediator) : ControllerBase
    {
        [HttpGet(Name = "GetAccountById")]
        public async Task<Core.Domain.Entities.Account> GetAccountById(int id)
        {
            return await mediator.Send(new GetAccountByIdCommand(id));
        }
    }
}
