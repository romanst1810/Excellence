using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Excellence.Core.Domain;

namespace Excellence.Core.Repository
{
    public interface IBankAccountRepository
    {
        Task CreateAsync(BankAccountInfo item);

        Task<IReadOnlyCollection<BankAccountInfo>> FetchAsync();
    }
}
