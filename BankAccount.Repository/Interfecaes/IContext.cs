using BankAccount.Repository.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount.Repository.Interfecaes
{
    public interface IContext
    {

        DbSet<User> Users { get; set; }
        DbSet<Account> Accounts { get; set; }
        DbSet<AccountType> AccountTypes { get; set; }
        DbSet<CurrencyType> CurrencyTypes { get; set; }
        DbSet<AccountOfUser> AccountsOfUser { get; set; }

        Task<int> SaveChangesAsync(CancellationToken cancellation = default);
    }
}
