using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Excellence.Core.Domain;

namespace Excellence.Core.Repository
{
    public interface IBankRepository
    {
        Task<IReadOnlyCollection<BankInfo>> GetBanksAsync();

        Task<IReadOnlyCollection<BankBranchesInfo>> GetBranchesAsync(int bankCode);
    }
}
