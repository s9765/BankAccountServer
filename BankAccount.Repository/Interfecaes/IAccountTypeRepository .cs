using BankAccount.Repository.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount.Repository.Interfecaes
{
    public interface IAccountTypeRepository
    {
        Task<List<AccountType>> GetAllAsync();

        Task<AccountType> AddAsync(AccountType accountType);

    }
}
