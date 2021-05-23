using Excellence.BL;
using Excellence.Core.Domain;
using Exellence.MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exellence.MVC.Helpers
{
    public interface IBankAccountService
    {
        Task<List<BankInfo>> GetBanksAsync();
        Task<List<BankBranchesInfo>> GetBranchesAsync(int id);
        void CreateAccount(BankAccountInfo requestBankAccountInfo);
    }

    public class BankAccountService : IBankAccountService
    {
        private IAccountService _accountService;
        private IBankService _bankService;

        public BankAccountService(IAccountService accountService, IBankService bankService)
        {
            this._accountService = accountService;
            this._bankService = bankService;
        }

        public async Task<List<BankInfo>> GetBanksAsync()
        {
            var model = await _bankService.GetBanksAsync();
            return model.ToList();
        }

        public async Task<List<CitiesInfo>> GetCitiesAsync()
        {
            var model = await _bankService.GetCitiesAsync();
            return model.ToList();
        }

        public async Task<List<BankBranchesInfo>> GetAllBranchesAsync()
        {
            var branches = await _bankService.GetAllBranchesAsync();
            return branches.ToList();
        }

        public async Task<List<BankBranchesInfo>> GetBranchesAsync(int id)
        {
            var branches = await _bankService.GetBranchesAsync(id);
            return branches.ToList();
        }

        public void CreateAccount(BankAccountInfo requestBankAccountInfo)
        {
            _accountService.CreateAsync(requestBankAccountInfo);
        }

        public async Task<BankAccountViewModel> GetIndexResponce()
        {
            var responce = new BankAccountViewModel();
            responce.Cities = await GetCitiesAsync();
            responce.Banks = await GetBanksAsync();
            responce.Branches = await GetAllBranchesAsync();
            return new BankAccountViewModel();
        }
    } 
}
