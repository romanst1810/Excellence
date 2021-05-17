using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Excellence.Core.Domain;
using Excellence.Core.Repository;
using Excellence.Data;

namespace Excellence.BL
{
    public interface IBankService
    {
        Task<IReadOnlyCollection<BankInfo>> GetBanksAsync();

        Task<IReadOnlyCollection<BankBranchesInfo>> GetBranchesAsync(int bankCode);
    }
}
