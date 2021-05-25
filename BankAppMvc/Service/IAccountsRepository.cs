using BankAppMvc.Data;
using BankAppMvc.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BankAppMvc.Service
{
    public interface IAccountsRepository
    {
        IQueryable<Accounts> GetAllAccounts();
        IQueryable<Transactions> GetAllTransactions();
        public void AddAccount(Accounts account);
        public void DeleteAccount(Accounts deleteAccount);

        public void Save();
    }
    public class AccountsRepository : IAccountsRepository
    {
        protected readonly ApplicationDbContext _dbContext;
        public AccountsRepository(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IQueryable<Accounts> GetAllAccounts()
        {
            return _dbContext.Accounts;
        }

        public IQueryable<Transactions> GetAllTransactions()
        {
            return _dbContext.Transactions;
        }
        public void AddAccount(Accounts account)
        {
            _dbContext.Accounts.Add(account);
        }

        public void DeleteAccount(Accounts deleteAccount)
        {
            _dbContext.Accounts.Remove(deleteAccount);
        }

        public Accounts GetAccount(int viewModelAccount)
        {
            var cheack =_dbContext.Accounts.Where(a => a.AccountId == viewModelAccount).FirstOrDefault();
            if(cheack != null)
            {
                return cheack;
            }

            return null;
        }

        public void Save()
        {
            _dbContext.SaveChanges();
        }

    }
}
