using Excellence.BL;
using Excellence.Core.Domain;
using Exellence.MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Exellence.MVC.Helpers
{
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

        public async Task<List<BankAccountInfo>> GetAllAccountsAsync()
        {
            var items = await _accountService.GetAllAsync();
            return items.ToList();
        }

        public void CreateAccount(BankAccountViewModel  requestBankAccountInfo)
        {
            BankAccountInfo model = new BankAccountInfo
            {
                CityCode = requestBankAccountInfo.CityCode,
                BranchNumber = Int32.Parse(requestBankAccountInfo.BranchNumber),
                AccountNumber = Int32.Parse(requestBankAccountInfo.AccountNumber),
                BankCode = Int32.Parse(requestBankAccountInfo.BankCode),
                BirthDay = requestBankAccountInfo.BirthDay,
                NameEnglish = requestBankAccountInfo.NameEnglish,
                NameLocal = requestBankAccountInfo.NameLocal,
                SocialId = requestBankAccountInfo.SocialId
            };
           _accountService.CreateAsync(model);
        }

        public async Task<BankAccountViewModel> GetIndexResponce()
        {
            var responce = new BankAccountViewModel();
            
            var cities = await GetCitiesAsync();
            foreach (var c in cities)
            {
                responce.Cities.Add(
                    new SelectListItem { Value = c.Code.ToString(), Text = c.Description });
            }

            var banks = await GetBanksAsync();
            foreach (var bank in banks)
            {
                responce.Banks.Add(
                    new SelectListItem{Value = bank.Code.ToString(),Text = bank.Description});
            }

            var branches = await GetAllBranchesAsync();
            foreach (var branch in branches)
            {
                responce.BankBranches.Add(
                    new SelectListItem{Value = branch.BranchNumber.ToString(),Text = branch.BranchName});
            }
            return responce;
        }
    } 
}
