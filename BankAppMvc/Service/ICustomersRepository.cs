using BankAppMvc.Data;
using BankAppMvc.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BankAppMvc.Service
{
    public interface ICustomersRepository
    {
        IQueryable<Customers> GetAllCustomers();
        public void AddCustomer(Customers addCustomer);
        public void DeleteCustomer(Customers deleteCustomer);
        public void Save();

    }

    public class CustomersRepository : ICustomersRepository
    {
        protected readonly ApplicationDbContext _dbContext;
        public CustomersRepository(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IQueryable<Customers> GetAllCustomers()
        {
            return _dbContext.Customers;
        }

        public void AddCustomer(Customers addCustomer)
        {
            _dbContext.Customers.Add(addCustomer);
        }

        public void DeleteCustomer(Customers deleteCustomer)
        {
            _dbContext.Customers.Remove(deleteCustomer);
        }
        public void Save()
        {
            _dbContext.SaveChanges();
        }
    }
}
