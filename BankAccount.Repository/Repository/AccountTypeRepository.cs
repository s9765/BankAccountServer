using BankAccount.Repository.Entities;
using BankAccount.Repository.Interfecaes;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount.Repository.Repository
{
    public class AccountTypeRepository: IAccountTypeRepository
    {

        private readonly IContext _context;

        public AccountTypeRepository(IContext context)
        {
            _context = context;
        }

        public async Task<List<AccountType>> GetAllAsync()
        {
            return await _context.AccountTypes.ToListAsync();
        }


        public async Task<AccountType> AddAsync(AccountType accountType)
        {
            var u = _context.AccountTypes.Add(accountType);
            await _context.SaveChangesAsync();
            return u.Entity;
        }

       
    }
}
