using BankAppMvc.Data;
using BankAppMvc.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BankAppMvc.Service
{
    public interface ITransactionRepository
    {
        IQueryable<Transactions> GetAllTransactions();
        List<Transactions> GetList(int skip, int antal);
        public void AddTransaction(Transactions transactions);
        public void Save();
    }

    public class TransactionRepository : ITransactionRepository
    {
        protected readonly ApplicationDbContext _dbContext;
        public TransactionRepository(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IQueryable<Transactions> GetAllTransactions()
        {
            return _dbContext.Transactions;
        }

        public List<Transactions> GetList(int skip, int antal)
        {
            return _dbContext.Transactions.Skip(skip).Take(antal).ToList();
        }

        public void AddTransaction(Transactions transactions)
        {
            _dbContext.Transactions.Add(transactions);
        }

        public void Save()
        {
            _dbContext.SaveChanges();
        }

    }
}
