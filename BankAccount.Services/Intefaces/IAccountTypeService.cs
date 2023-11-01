using BankAccount.Common.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount.Services.Intefaces
{
    public interface IAccountTypeService
    {

        Task<List<AccountTypeDTO>> GetAllAsync();
        Task<AccountTypeDTO> AddAsync(AccountTypeDTO accountType);
    }
}
