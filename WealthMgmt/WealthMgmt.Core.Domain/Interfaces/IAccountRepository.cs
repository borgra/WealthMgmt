using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WealthMgmt.Core.Domain.Entities;

namespace WealthMgmt.Core.Domain.Interfaces
{
    public interface IAccountRepository
    {
        public Task<Account> GetAccountById(int id);
    }
}
