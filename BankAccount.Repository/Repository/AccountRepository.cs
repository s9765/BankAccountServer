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
    public class AccountRepository: IAccountRepository
    {

        private readonly IContext _context;

        public AccountRepository(IContext context)
        {
            _context = context;
        }

        public async Task<List<Account>> GetAllAsync()
        {
            return await _context.Accounts.ToListAsync();
        }


        public async Task<Account> AddAsync(Account account)
        {
            var u = _context.Accounts.Add(account);
            await _context.SaveChangesAsync();
            return u.Entity;
        }
       
    }
}
