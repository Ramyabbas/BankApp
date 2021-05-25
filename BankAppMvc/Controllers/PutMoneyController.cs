using BankAppMvc.Data;
using BankAppMvc.Models;
using BankAppMvc.ViewModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using BankAppMvc.Service;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;

namespace BankAppMvc.Controllers
{
    public class PutMoneyController : Controller
    {
        private readonly ILogger<PutMoneyController> _logger;
        private readonly ITransactionRepository _transactions;
        private readonly IAccountsRepository _accounts;

        public PutMoneyController(ILogger<PutMoneyController> logger, ITransactionRepository transaction, IAccountsRepository accounts)
        {
            _logger = logger;
            _accounts = accounts;
            _transactions = transaction;
        }

        public IActionResult Index()
        {
            return View();
        }

        [Authorize(Roles = "Admin , Cashier")]
        public IActionResult PutMoney()
        {
            var viewModel = new PutMoneyInViewModel();
            return View(viewModel);
        }

        [HttpPost]
        public IActionResult PutMoney(PutMoneyInViewModel putMoneyIn)
        {
            var account = _accounts.GetAllAccounts().FirstOrDefault(r => r.AccountId == putMoneyIn.AccountId);

            if (account == null)
            {
                ModelState.AddModelError("AccountId", "Kontot hittades inte i vår system!");
            }
            if (putMoneyIn.Amount <= 0)
            {
                ModelState.AddModelError("Amount", "Belopp måste vara positivt summa!");
            }


            if (ModelState.IsValid)
            {
                var dbTake = new Transactions();
                var viewModel = new TakeOutMoneyViewModel();
                _transactions.AddTransaction(dbTake);
                dbTake.AccountId = putMoneyIn.AccountId;
                dbTake.Date = DateTime.Now;
                dbTake.Amount = putMoneyIn.Amount;
                dbTake.Type = "Credit";
                dbTake.Operation = "Credit in Cash";
                var put = _accounts.GetAllAccounts().First(s => s.AccountId == putMoneyIn.AccountId);
                put.Balance = put.Balance + putMoneyIn.Amount;

                dbTake.Balance = put.Balance;
                _transactions.Save();

                return RedirectToAction("Thanku" , "PutMoney");

            }
             
            return View(putMoneyIn);
        }

        public IActionResult Thanku()
        {
            return View();
        }
    }
}
