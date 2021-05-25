using BankAppMvc.Controllers;
using BankAppMvc.Service;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using AutoFixture;
using BankAppMvc.ViewModels;
using BankAppMvc.Models;
using BankAppMvc.Data;
using Microsoft.EntityFrameworkCore;
using System;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.IO;

namespace BankAppMvc.Tests
{  
    [TestClass]
    public class PutMoneyControllerTests 
    {
        private PutMoneyController sut;
        private IMock<ITransactionRepository> transRepoMock;
        private IMock<IAccountsRepository> accRepoMock;
        private ApplicationDbContext ctx;

        public PutMoneyControllerTests()
        {
            transRepoMock = new Mock<ITransactionRepository>();
            accRepoMock = new Mock<IAccountsRepository>();

            var options = new DbContextOptionsBuilder<ApplicationDbContext>()
                .UseInMemoryDatabase(Guid.NewGuid().ToString())
                .EnableSensitiveDataLogging()
                .Options;
            ctx = new ApplicationDbContext(options);
            sut = new PutMoneyController(transRepoMock.Object, accRepoMock.Object);
           
        }

        [TestMethod]
        public void WhenAmountIsNegative()
        {
            var account = new Accounts
            {
                AccountId = 1,
                Balance = 100,
                Created = DateTime.Now,
                Frequency = "Hopp"
            };
            ctx.Accounts.Add(account);

            var viewModel = new PutMoneyInViewModel
            {
                AccountId = 1,
                Amount = -10
            };

            sut.PutMoney(viewModel);
            Assert.IsFalse(sut.ViewData.ModelState.IsValid);
        }
        [TestMethod]
        public void WhenAccountIsNotCorrect()
        {
            var account = new Accounts
            {
                AccountId = 5,
                Balance = 200,
                Created = DateTime.Now,
                Frequency = "hah"
            };
            ctx.Accounts.Add(account);
            ctx.SaveChanges();
            var viewModel = new PutMoneyInViewModel
            {
                AccountId = 10,
                Amount = 10
            };

            sut.PutMoney(viewModel);
            Assert.IsFalse(sut.ViewData.ModelState.IsValid);
        }
        
    }
}
