using BankAppMvc.Models;
using BankAppMvc.Service;
using BankAppMvc.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Transactions;

namespace BankAppMvc.Controllers
{
    public class TransactionController : Controller
    {

        private readonly ITransactionRepository _transaction;
        private readonly IAccountsRepository _accounts;


        public TransactionController(ITransactionRepository transaction,IAccountsRepository accounts)
        {
            _transaction = transaction;
            _accounts = accounts;
        }
        public IActionResult Index()
        {
            var viewModel = new CustomerTransactionsViewModel();
            viewModel.Transactions = _transaction.GetList(0,20).OrderByDescending(r => r.Date).Select(r => new TransactionsRowViewModel
            {
                TransactionId = r.TransactionId,
                 AccountId = r.AccountId,
                Date = r.Date,
                Type = r.Type,
                Operation = r.Operation,
                Amount = r.Amount,
                Balance = r.Balance,
                Bank = r.Bank,
                Account = r.Account
            }).ToList();


            return View(viewModel);
        }

        public IActionResult GetTransactionsFrom(int skip)
        {
            var viewModel = new TransactionsGetFromViewModel();
            viewModel.Transactions = _transaction.GetList(skip, 20).OrderByDescending(r => r.Date).Select(r => new TransactionsRowViewModel
            {
                TransactionId = r.TransactionId,
                AccountId = r.AccountId,
                Date = r.Date,
                Type = r.Type,
                Operation = r.Operation,
                Amount = r.Amount,
                Balance = r.Balance,
                Bank = r.Bank,
                Account = r.Account
            }).ToList();

            return View(viewModel);
        }

    }
}
