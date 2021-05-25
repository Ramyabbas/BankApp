using BankAppMvc.Service;
using BankAppMvc.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BankAppMvc.Controllers
{
    public class AccountController : Controller
    {
        private readonly IAccountsRepository _accounts;

        public AccountController(IAccountsRepository accounts)
        {
            _accounts = accounts;
        }
        public IActionResult Index()
        {
            return View();
        }
        [Authorize(Roles = "Admin , Cashier")]
        [HttpGet]
        public IActionResult New()
        {
            var viewModel = new NewAccountViewModel();
            return View(viewModel);
        }

        [Authorize(Roles = "Admin , Cashier")]
        [HttpGet]
        public IActionResult Edit()
        {
            var viewModel = new EditAccountViewModel();
            return View(viewModel);
        }

        [Authorize(Roles = "Admin , Cashier")]
        [HttpGet]
        public IActionResult Delete()
        {
            var viewModel = new DeleteAccountViewModel();
            return View(viewModel);
        }

    }
}
