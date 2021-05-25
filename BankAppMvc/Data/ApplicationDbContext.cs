using BankAppMvc.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace BankAppMvc.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=LAPTOP-6LJEETE9\\MASTER;Database=BankAppData;Trusted_Connection=True;MultipleActiveResultSets=true");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Dispositions>()
                .HasKey(e => new { e.DispositionId, e.CustomerId, e.AccountId });
        }

        public virtual DbSet<Accounts> Accounts { get; set; }
        public virtual DbSet<Customers> Customers { get; set; }
        public virtual DbSet<Dispositions> Dispositions { get; set; }
        public virtual DbSet<Cards> Cards { get; set; }
        public virtual DbSet<Loans> Loans { get; set; }
        public virtual DbSet<PermenentOrder> PermenentOrders { get; set; }
        public virtual DbSet<Transactions> Transactions { get; set; }
        public virtual DbSet<User> Users { get; set; }

    }
}
