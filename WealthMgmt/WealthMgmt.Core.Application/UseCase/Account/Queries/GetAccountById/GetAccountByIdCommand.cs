using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WealthMgmt.Core.Application.UseCase.Account.Queries.GetAccountById
{
    public class GetAccountByIdCommand : IRequest<Core.Domain.Entities.Account>
    {
        public int Id { get; set; }

        public GetAccountByIdCommand(int Id) {
            this.Id = Id;
        }
    }
}
