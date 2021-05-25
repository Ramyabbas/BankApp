using BankAppMvc.Data;
using BankAppMvc.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using BankAppMvc.Service;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;

namespace BankAppMvc.Controllers
{
    public class CustomerController : Controller
    {
        private readonly ILogger<CustomerController> _logger;
        public double totalRowCount { get; private set; }

        private readonly ICustomersRepository _customers;
        private readonly IAccountsRepository _accounts;
        private readonly IDispositionsRepository _dispositions;


        public CustomerController(ILogger<CustomerController> logger, ICustomersRepository customers, IAccountsRepository account, IDispositionsRepository dispositions)
        {
            _logger = logger;
            _customers = customers;
            _accounts = account;
            _dispositions = dispositions;
        }

        public IActionResult Index(string q, string sortField, string sortOrder, int page = 1)
        {
            var viewModel = new CustomerIndexViewModel();


            var query = _customers.GetAllCustomers()
               .Where(r => q == null || r.Givenname.Contains(q) || r.City.Contains(q));

            int totalCount = query.Count();

            if (string.IsNullOrEmpty(sortField))
                sortField = "CustomerId";


            if (string.IsNullOrEmpty(sortOrder))
                sortOrder = "asc";

            if (sortField == "Title")
            {
                if (sortOrder == "asc")
                    query = query.OrderBy(y => y.Givenname);
                else
                    query = query.OrderByDescending(y => y.Givenname);
            }
            if (sortField == "CustomerId")
            {
                if (sortOrder == "asc")
                    query = query.OrderBy(y => y.CustomerId);
                else
                    query = query.OrderByDescending(y => y.CustomerId);
            }
            if (sortField == "Surename")
            {
                if (sortOrder == "asc")
                    query = query.OrderBy(y => y.Surname);
                else
                    query = query.OrderByDescending(y => y.Surname);
            }

            if (sortField == "StreetAdress")
            {
                if (sortOrder == "asc")
                    query = query.OrderBy(y => y.Streetaddress);
                else
                    query = query.OrderByDescending(y => y.Streetaddress);
            }
            if (sortField == "City")
            {
                if (sortOrder == "asc")
                    query = query.OrderBy(y => y.City);
                else
                    query = query.OrderByDescending(y => y.City);
            }
            if (sortField == "Country")
            {
                if (sortOrder == "asc")
                    query = query.OrderBy(y => y.Country);
                else
                    query = query.OrderByDescending(y => y.Country);
            }

            int pageSize = 50;

            var pageCount = (double)totalRowCount / pageSize;
            viewModel.TotalPages = (int)Math.Ceiling(pageCount);

            int howManyRecordsToSkip = (page - 1) * pageSize;//1 => 0
            query = query.Skip(howManyRecordsToSkip).Take(pageSize);


            viewModel.customers = query

            .Select(a => new CustomerIndexViewModel.CustomersViewModel
            {
                CustomerId = a.CustomerId,
                Givenname = a.Givenname,
                Surename = a.Surname,
                StreetAdress = a.Streetaddress,
                City = a.City,
                Country = a.Country
            }).ToList();
            viewModel.q = q;
            viewModel.sortOrder = sortOrder;
            viewModel.sortField = sortField;
            viewModel.Page = page;
            viewModel.OppositeSortOrder = sortOrder == "asc" ? "desc" : "asc";


            return View(viewModel);
        }

        public IActionResult CustomerDetails(int Id)
        {
            var viewModel = new CustomerDetailsViewModel();
            var qurey = (from c in _customers.GetAllCustomers()
                         join d in _dispositions.GetAllDispositions() on c.CustomerId equals d.CustomerId
                         join a in _accounts.GetAllAccounts() on d.AccountId equals a.AccountId
                         where c.CustomerId == Id
                         select new
                         {
                             c.CustomerId,
                             c.Givenname,
                             c.Surname,
                             c.Streetaddress,
                             c.City,
                             c.Country,
                             a.AccountId,
                             a.Balance
                         });

            foreach (var q in qurey)
            {
                viewModel.CustomerId = q.CustomerId;
                viewModel.Givenname = q.Givenname;
                viewModel.Surename = q.Surname;
                viewModel.StreetAdress = q.Streetaddress;
                viewModel.City = q.City;
                viewModel.Country = q.Country;
            }
            viewModel.Accounts = qurey.Select(r => new CustomerDetailsViewModel.AcccountDetails
            {
                AccountId = r.AccountId,
                Balance = r.Balance
            }).ToList();

            return View(viewModel);
        }

        [Authorize(Roles = "Admin , Cashier")]
        [HttpGet]
        public IActionResult New()
        {
            var viewModel = new NewCustomerViewModel();
            return View(viewModel);
        }

        [Authorize(Roles = "Admin , Cashier")]
        [HttpGet]
        public IActionResult Edit()
        {
            var viewModel = new EditCustomerViewModel();
            return View(viewModel);
        }

        [Authorize(Roles = "Admin , Cashier")]
        [HttpGet]
        public IActionResult Delete()
        {
            var viewModel = new DeleteCustomerViewModel();
            return View(viewModel);
        }

    }
}
