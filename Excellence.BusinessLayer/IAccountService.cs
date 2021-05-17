using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Excellence.Core.Domain;

namespace Excellence.BL
{
    public interface IAccountService
    {
        Task CreateAsync(BankAccountInfo item);
    }
}
