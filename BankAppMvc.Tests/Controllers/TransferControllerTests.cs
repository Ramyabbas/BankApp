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
using System.Collections.Generic;

namespace BankAppMvc.Tests
{  
    [TestClass]
    public class TransferControllerTests
    {
        private TransferController sut;
        private IMock<ITransactionRepository> transRepoMock;
        private IMock<IAccountsRepository> accRepoMock;
        private ApplicationDbContext ctx;

        public TransferControllerTests()
        {
            transRepoMock = new Mock<ITransactionRepository>();
            accRepoMock = new Mock<IAccountsRepository>();

            var options = new DbContextOptionsBuilder<ApplicationDbContext>()
                .UseInMemoryDatabase(Guid.NewGuid().ToString())
                .EnableSensitiveDataLogging()
                .Options;
            ctx = new ApplicationDbContext(options);
            sut = new TransferController(transRepoMock.Object, accRepoMock.Object);
        }

        [TestMethod]
        public void WhenTransferMoreMoneyThanIsInTheAccount()
        {
            var account = new Accounts
            {
                AccountId = 1,
                Balance = 10,
                Created = DateTime.Now,
                Frequency = "Hej"
            };
            var account2 = new Accounts
            {
                AccountId = 4,
                Balance = 100,
                Created = DateTime.Now,
                Frequency = "Då"
            };

            ctx.Accounts.Add(account);
            ctx.Accounts.Add(account2);
            ctx.SaveChanges();

            var newTransfer = new NewTransferViewModel
            {
                AccountId = 1,
                AccountReceiversId = 4,
                Amount = 50
            };

            sut.NewTransfer(newTransfer);

            Assert.IsFalse(sut.ViewData.ModelState.IsValid);
        }
        [TestMethod]
        public void WhenAccountIdNotFound()
        {
            var a = new Accounts
            {
                AccountId = 4,
                Balance = 1000,
                Created = DateTime.Now,
                Frequency = "Nu"
            };
            var a2 = new Accounts
            {
                AccountId = 7,
                Balance = 5000,
                Created = DateTime.Now,
                Frequency = "Sen"
            };

            ctx.Accounts.Add(a);
            ctx.Accounts.Add(a2);
            ctx.SaveChanges();

            var newTransfer = new NewTransferViewModel
            {
                AccountId = 3,
                AccountReceiversId = 7,
                Amount = 500
            };

            sut.NewTransfer(newTransfer);

            Assert.IsFalse(sut.ViewData.ModelState.IsValid);
        }
    }
}
