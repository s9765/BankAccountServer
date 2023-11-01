using BankAccount.Repository.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount.Repository.Interfecaes
{
    public interface IUserRepository
    {
        Task<List<User>> GetAllAsync();

        Task<User> AddAsync(User user);

    }
}
