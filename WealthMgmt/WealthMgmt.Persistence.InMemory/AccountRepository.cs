using WealthMgmt.Core.Domain.Entities;
using WealthMgmt.Core.Domain.Interfaces;

namespace WealthMgmt.Persistence.InMemory
{
    public class AccountRepository : IAccountRepository
    {
        Task<Account> IAccountRepository.GetAccountById(int id)
        {
            return Task.FromResult(new Account()
            {
                Id = id,
                AccountType = "Retirement",
                Balance = 25000,
                Name = "Robinhood"
            });
        }
    }
}
