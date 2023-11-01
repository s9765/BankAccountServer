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
    public class AccountOfUserRepository: IAccountOfUserRepository
    {

        private readonly IContext _context;

        public AccountOfUserRepository(IContext context)
        {
            _context = context;
        }

        public async Task<List<AccountOfUser>> GetAllAsync()
        {
            return await _context.AccountsOfUser.ToListAsync();
        }


        public async Task<AccountOfUser> AddAsync(AccountOfUser AccountOfUser)
        {
            var u = _context.AccountsOfUser.Add(AccountOfUser);
            await _context.SaveChangesAsync();
            return u.Entity;
        }

       
    }
}
