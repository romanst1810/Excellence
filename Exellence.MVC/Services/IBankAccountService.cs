using Excellence.Core.Domain;
using Exellence.MVC.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Exellence.MVC.Helpers
{
    public interface IBankAccountService
    {
        Task<List<BankInfo>> GetBanksAsync();
        Task<List<BankBranchesInfo>> GetAllBranchesAsync();
        Task<List<BankBranchesInfo>> GetBranchesAsync(int id);
        void CreateAccount(BankAccountViewModel requestBankAccountInfo);
        Task<BankAccountViewModel> GetIndexResponce();
    }
}
