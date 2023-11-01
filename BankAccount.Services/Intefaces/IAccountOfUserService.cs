using BankAccount.Common.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount.Services.Intefaces
{
    public interface IAccountOfUserService
    {

        Task<List<AccountOfUserDTO>> GetAllAsync();
        Task<AccountOfUserDTO> AddAsync(AccountOfUserDTO AccountOfUser);
    }
}
