using Excellence.BL;
using Excellence.Core.Domain;
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
        private IAccountService _accountService;
        private IBankService _bankService;

        public BankController(IAccountService accountService, IBankService bankService)
        {
            this._accountService = accountService;
            this._bankService = bankService;
        }
        //// POST api/<BankAccountController>
        //[HttpPost]
        //public void Post([FromBody] BankAccountInfo requestBankAccountInfo)
        //{
        //    _accountService.CreateAsync(requestBankAccountInfo);
        //}

        //[HttpGet]
        //public async Task<List<BankInfo>> GetBanksAsync()
        //{
        //    var model = await _bankService.GetBanksAsync();
        //    return model.ToList();
        //}

        //[HttpGet("{id}")]
        //public async Task<List<BankBranchesInfo>> GetBranchesAsync(int id)
        //{
        //    var branches = await _bankService.GetBranchesAsync(id);
        //    return branches.ToList();
        //}

        //// GET: BankController
        public ActionResult Index()
        {
            return View();
        }

        // GET: BankController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: BankController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: BankController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(BankAccountInfo requestBankAccountInfo)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: BankController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: BankController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: BankController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: BankController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
