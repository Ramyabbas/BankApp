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
    public class TakeOutMoneyController : Controller
    {
        private readonly ITransactionRepository _transactions;
        private readonly IAccountsRepository _accounts;

        public TakeOutMoneyController(ITransactionRepository transaction, IAccountsRepository accounts)
        {
            _accounts = accounts;
            _transactions = transaction;
        }

        public IActionResult Index()
        {
            return View();
        }

        [Authorize(Roles = "Admin , Cashier")]
        public IActionResult TakeOutMoney()
        {
            var viewModel = new TakeOutMoneyViewModel();
            return View(viewModel);
        }

        [HttpPost]
        public IActionResult TakeOutMoney(TakeOutMoneyViewModel takeOutMoney)
        {
            var account = _accounts.GetAllAccounts().FirstOrDefault(r => r.AccountId == takeOutMoney.AccountId);

            if( account == null)
            {
                ModelState.AddModelError("AccountId", "Kontot hittades inte i vår system!");
            }
            else if(takeOutMoney.Amount <= 0)
            {
                ModelState.AddModelError("Amount", "Belopp måste vara positivt summa!");
            }

            else if (account.Balance < takeOutMoney.Amount)
            {
                ModelState.AddModelError("Amount", "Det finns tillräckligt mycket pengar på kontot!");
            }

            if(ModelState.IsValid)
            {
                var dbTake = new Transactions();
                var viewModel = new TakeOutMoneyViewModel();
                _transactions.AddTransaction(dbTake);
                dbTake.AccountId = takeOutMoney.AccountId;
                dbTake.Date = DateTime.Now;
                dbTake.Amount = takeOutMoney.Amount;
                dbTake.Type = "Credit";
                dbTake.Operation = "Credit in Cash";
                var put = _accounts.GetAllAccounts().First(s => s.AccountId == takeOutMoney.AccountId);
                put.Balance = put.Balance - takeOutMoney.Amount;

                dbTake.Balance = put.Balance;
                _transactions.Save();
                return RedirectToAction("Thanks", "TakeOutMoney");
            }
            return View(takeOutMoney);
        }

        public IActionResult Thanks()
        {
            return View();
        }
    }
}
