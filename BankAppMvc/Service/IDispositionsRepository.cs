using BankAppMvc.Data;
using BankAppMvc.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BankAppMvc.Service
{
    public interface IDispositionsRepository
    {
        IQueryable<Dispositions> GetAllDispositions();
        public void Save();

    }

    public class DispositionsRepository : IDispositionsRepository
    {
        protected readonly ApplicationDbContext _dbContext;
        public DispositionsRepository(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IQueryable<Dispositions> GetAllDispositions()
        {
            return _dbContext.Dispositions;
        }
        public void Save()
        {
            _dbContext.SaveChanges();
        }
    }
}
