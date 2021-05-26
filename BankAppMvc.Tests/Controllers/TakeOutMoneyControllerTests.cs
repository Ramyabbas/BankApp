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
    public class TakeOutMoneyControllerTests 
    {
        private TakeOutMoneyController sut;
        private IMock<ITransactionRepository> transRepoMock;
        private IMock<IAccountsRepository> accRepoMock;
        private ApplicationDbContext ctx;

        public TakeOutMoneyControllerTests()
        {
            transRepoMock = new Mock<ITransactionRepository>();
            accRepoMock = new Mock<IAccountsRepository>();

            var options = new DbContextOptionsBuilder<ApplicationDbContext>()
                .UseInMemoryDatabase(Guid.NewGuid().ToString())
                .EnableSensitiveDataLogging()
                .Options;
            ctx = new ApplicationDbContext(options);
            sut = new TakeOutMoneyController(transRepoMock.Object, accRepoMock.Object);
           
        }

        [TestMethod]
        public void WhenAmountToTakeOutIsBiggerThanBalance()
        {
            var account = new Accounts 
            {
                AccountId = 1,
                Balance = 20, 
                Created = DateTime.Now, 
                Frequency="Hej" 
            };
            accRepoMock.Object.AddAccount(account);
            accRepoMock.Object.Save();
            TakeOutMoneyViewModel tom = new TakeOutMoneyViewModel
            {
                AccountId = 1,
                Amount = 40
            };
            sut.TakeOutMoney(tom);
            Assert.IsFalse(sut.ViewData.ModelState.IsValid);
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
            accRepoMock.Object.AddAccount(account);
            accRepoMock.Object.Save();
            var viewModel = new TakeOutMoneyViewModel
            {
                AccountId = 1,
                Amount = -20
            };
            sut.TakeOutMoney(viewModel);
            Assert.IsFalse(sut.ViewData.ModelState.IsValid);
        }
        [TestMethod]
        public void WhenAccountIsNotFound()
        {
            var a = new Accounts
            {
                AccountId = 8,
                Balance = 2200,
                Created = DateTime.Now,
                Frequency = "TaCk"
            };
            accRepoMock.Object.AddAccount(a);
            accRepoMock.Object.Save();
            var viewModel = new TakeOutMoneyViewModel
            {
                AccountId = 10,
                Amount = 100
            };

            sut.TakeOutMoney(viewModel);
            Assert.IsFalse(sut.ViewData.ModelState.IsValid);
        }

        [TestMethod]
        public void WhenTakeOutCorrect()
        {
            var account = new Accounts
            {
                AccountId = 9,
                Balance = 1000,
                Created = DateTime.Now,
                Frequency = "Now"
            };

            accRepoMock.Object.AddAccount(account);
            accRepoMock.Object.Save();
            var viewModel = new TakeOutMoneyViewModel
            {
                AccountId = 9,
                Amount = 500
            };

            var result = sut.TakeOutMoney(viewModel);
            var resultAction = result as ActionResult;
            Assert.IsInstanceOfType(resultAction, typeof(ViewResult));
        }


    }
}
