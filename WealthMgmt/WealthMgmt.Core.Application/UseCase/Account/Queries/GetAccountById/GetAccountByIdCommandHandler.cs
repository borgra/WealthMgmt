using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WealthMgmt.Core.Domain.Interfaces;

namespace WealthMgmt.Core.Application.UseCase.Account.Queries.GetAccountById
{
    public class GetAccountByIdCommandHandler(IAccountRepository accountRepository) : IRequestHandler<GetAccountByIdCommand, Core.Domain.Entities.Account>
    {
        public Task<Domain.Entities.Account> Handle(GetAccountByIdCommand request, CancellationToken cancellationToken)
        {
            return accountRepository.GetAccountById(request.Id);
        }
    }
}
