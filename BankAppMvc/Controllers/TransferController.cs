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
using System.IO;

namespace BankAppMvc.Controllers
{
    public class TransferController : Controller
    {
        private readonly ITransactionRepository _transactions;
        private readonly IAccountsRepository _accounts;

        public TransferController(ITransactionRepository transaction, IAccountsRepository accounts)
        {
            _accounts = accounts;
            _transactions = transaction;
        }

        public IActionResult Index()
        {
            return View();
        }

        [Authorize(Roles = "Admin , Cashier")]
        public IActionResult NewTransfer()
        {
            var viewModel = new NewTransferViewModel();
            return View(viewModel);
        }

        [HttpPost]
        public IActionResult NewTransfer(NewTransferViewModel newTransfer)
        {
            var account = _accounts.GetAllAccounts().FirstOrDefault(r => r.AccountId == newTransfer.AccountId);
            var accountMot = _accounts.GetAllAccounts().FirstOrDefault(r => r.AccountId == newTransfer.AccountReceiversId);
            if (account == null)
            {
                ModelState.AddModelError("AccountId", "Kontot hittades inte i vår system!");
            }
            else if (accountMot == null)
            {
                ModelState.AddModelError("AccountReceiversId", "Kontot hittades inte i vår system!");

            }
            else if(account.Balance < newTransfer.Amount)
            {
                ModelState.AddModelError("Amount", "Det finns inte tillräckligt mycket pengar på kontot!");
            }
            else if (newTransfer.Amount <= 0)
            {
                ModelState.AddModelError("Amount", "Belopp måste vara positivt summa!");
            }

            if (ModelState.IsValid)
            {
                var dbTransfer = new Transactions();
                var viewModel = new NewTransferViewModel();
                _transactions.AddTransaction(dbTransfer);
                dbTransfer.AccountId = newTransfer.AccountId;
                dbTransfer.Date = DateTime.Now;
                dbTransfer.Amount = newTransfer.Amount;
                dbTransfer.Type = "Credit";
                dbTransfer.Operation = "Credit in cash";

                var send = _accounts.GetAllAccounts().First(s => s.AccountId == newTransfer.AccountId);
                send.Balance = send.Balance - newTransfer.Amount;

                var reception = _accounts.GetAllAccounts().First(r => r.AccountId == newTransfer.AccountReceiversId);
                reception.Balance = reception.Balance + newTransfer.Amount;
                dbTransfer.Balance = send.Balance;

                _transactions.Save();

                return RedirectToAction("ThankYou");
            }
            return View(newTransfer);
        }

        public IActionResult ThankYou()
        {
            return View();
        }

        public IActionResult Show(int id)
        {
            var viewModel = new NewTransferViewModel();
            var db = _accounts.GetAllAccounts().First(r=>r.AccountId == id); 
            if (db == null)
            {
                throw new InvalidDataException("aswraasdf");
            }
            return View(viewModel);
        }
    }
}
