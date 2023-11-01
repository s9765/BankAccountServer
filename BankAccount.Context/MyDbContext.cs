using BankAccount.Repository.Entities;
using BankAccount.Repository.Interfecaes;
using Microsoft.EntityFrameworkCore;

namespace BankAccount.Context
{
    public class MyDbContext : DbContext, IContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Account> Accounts { get; set; }
        public DbSet<AccountType> AccountTypes { get; set; }
        public DbSet<CurrencyType> CurrencyTypes { get; set; }
        public DbSet<AccountOfUser> AccountsOfUser { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=BankAccountFix;Trusted_connection=True");
        }
    }
}