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

namespace BankAppMvc.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ICustomersRepository _customers;
        private readonly IAccountsRepository _accounts;
        private readonly SignInManager<IdentityUser> _signInManager;

        public HomeController(ILogger<HomeController> logger, ICustomersRepository customers,IAccountsRepository accounts, SignInManager<IdentityUser> signInManager)
        {
            _logger = logger;
            _customers = customers;
            _accounts = accounts;
            _signInManager = signInManager;
        }

        [ResponseCache(Duration = 30)]
        public IActionResult Index()
        {
            var model = new StartPageViewModel();
            model.Customers = _customers.GetAllCustomers().Count();
            model.Accounts = _accounts.GetAllAccounts().Count();
            model.Amount = _accounts.GetAllAccounts().Sum(r => r.Balance);
            return View(model);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Logout()
        {
            _signInManager.SignOutAsync().Wait();
            return RedirectToAction("Index");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
