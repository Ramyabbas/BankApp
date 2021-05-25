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

    public class BaseTest
    {
        protected AutoFixture.Fixture fixture = new AutoFixture.Fixture();
        private ApplicationDbContext ctx;

    }
    [TestClass]
    public class TransferControllerTests : BaseTest
    {
        private TransferController transfer;
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
            transfer = new TransferController(transRepoMock.Object, accRepoMock.Object);


        }

        [TestMethod]
        public void AccountIdNotFound()
        {
            var viewModel = fixture.Create<NewTransferViewModel>();
            viewModel.AccountId = 63336631;
            Assert.ThrowsException<InvalidDataException>(() => transfer.Show(viewModel.AccountId));
        }

    }
}
