using Excellence.BL;
using Excellence.Core.Domain;
using Exellence.MVC.Helpers;
using Exellence.MVC.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exellence.MVC.Controllers
{
    public class BankController : Controller
    {
        private IBankAccountService _bankAccountService;
        
        public BankController(IBankAccountService bankAccountService)
        {
            this._bankAccountService = bankAccountService;
        }

        public async Task<IActionResult> Index()
        {
            BankAccountViewModel baModel = await _bankAccountService.GetIndexResponce();
            return View(baModel);
        }

        [HttpPost]
        public ActionResult Create(BankAccountViewModel requestBankAccountInfo)
        {
            _bankAccountService.CreateAccount(requestBankAccountInfo);
            return View("Create","Bank");
        }  
    }
}
