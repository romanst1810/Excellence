using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Excellence.Core.Domain;
using Excellence.Core.Repository;
using Excellence.Data;

namespace Excellence.BL
{
    public class AccountService : IAccountService
    {
        private readonly IBankAccountRepository _bankRepository;
        public AccountService(IBankAccountRepository bankRepository)
        {
            this._bankRepository = bankRepository;
        }

        public async Task CreateAsync(BankAccountInfo item)
        {
            await _bankRepository.CreateAsync(item);
        }
    }
}
