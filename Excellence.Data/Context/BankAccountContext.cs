using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Text;
using Excellence.Core.Domain;
using Microsoft.EntityFrameworkCore;

namespace Excellence.Data.Context
{
    public class BankAccountContext : DbContext
    {
        private const string DefaultConnectionString =
            "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=BankAccount;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

        private readonly string _connectionString;


        public BankAccountContext(string connectionString = default)
        {
            this._connectionString = connectionString ?? DefaultConnectionString;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(_connectionString);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
        }

        public DbSet<BankAccountInfo> BankAccounts { get; set; }
    }
}
