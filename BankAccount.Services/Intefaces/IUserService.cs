using BankAccount.Common.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount.Services.Intefaces
{
    public interface IUserService
    {

        Task<List<UserDTO>> GetAllAsync();
        Task<UserDTO> AddAsync(UserDTO user);
    }
}
