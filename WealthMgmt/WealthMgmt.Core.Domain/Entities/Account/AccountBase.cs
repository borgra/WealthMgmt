using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WealthMgmt.Core.Domain.Entities.Account
{
    public abstract class AccountBase
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public decimal Balance { get; set; }

    }
}
