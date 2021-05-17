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
    public class BankAccountController : ControllerBase
    {
        private IAccountService _accountService;

        public BankAccountController(IAccountService accountService)
        {
            this._accountService = accountService;
        }
        // POST api/<BankAccountController>
        [HttpPost]
        public void Post([FromBody] BankAccountInfo requestBankAccountInfo)
        {
            _accountService.CreateAsync(requestBankAccountInfo);
        }
    }
}
