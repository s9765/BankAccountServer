using BankAccount.Common.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount.Services.Intefaces
{
    public interface IAccountService
    {

        Task<List<AccountDTO>> GetAllAsync();
        Task<AccountDTO> AddAsync(AccountDTO account);
    }
}
