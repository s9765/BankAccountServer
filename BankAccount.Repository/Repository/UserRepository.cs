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
    public class UserRepository:IUserRepository
    {

        private readonly IContext _context;

        public UserRepository(IContext context)
        {
            _context = context;
        }

        public async Task<List<User>> GetAllAsync()
        {
            return await _context.Users.ToListAsync();
        }


        public async Task<User> AddAsync(User user)
        {
            var u = _context.Users.Add(user);
            await _context.SaveChangesAsync();
            return u.Entity;
        }
    }
}
