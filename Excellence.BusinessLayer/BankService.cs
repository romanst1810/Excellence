using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Excellence.Core.Domain;
using Excellence.Core.Repository;

namespace Excellence.BL
{
    public class BankService :IBankService
    {
        private readonly IBankRepository _bankRepository;

        public BankService(IBankRepository bankRepository)
        {
            this._bankRepository = bankRepository;
        }
        
        public async Task<IReadOnlyCollection<BankInfo>> GetBanksAsync()
        {
            return await _bankRepository.GetBanksAsync();
        }

        public async Task<IReadOnlyCollection<BankBranchesInfo>> GetBranchesAsync(int bankCode)
        {
            return await _bankRepository.GetBranchesAsync(bankCode);
        }
    }
}
