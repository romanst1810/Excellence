using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Excellence.BL;
using Excellence.Core.Domain;

namespace Exellence.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BankController : ControllerBase
    {
        private IBankService _bankService;

        public BankController(IBankService bankService)
        {
            this._bankService = bankService;
        }
        
        [HttpGet]
        public async Task<List<BankInfo>> GetBanksAsync()
        {
            var model = await _bankService.GetBanksAsync();
            return model.ToList();
        }
        
        [HttpGet("{id}")]
        public async Task<List<BankBranchesInfo>> GetBranchesAsync(int id)
        {
            var branches = await _bankService.GetBranchesAsync(id);
            return branches.ToList();
        }
    }
}
