using AutoMapper;
using BankAccount.Common.DTOs;
using BankAccount.Repository.Entities;
using BankAccount.Repository.Interfecaes;
using BankAccount.Services.Intefaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount.Services.Services
{
    public class AccountTypeService:IAccountTypeService
    {

        private readonly IAccountTypeRepository _accountTypeRepository;
        private readonly IMapper _mapper;
        public AccountTypeService(IAccountTypeRepository AccountTypeRepository, IMapper mapper)
        {
            _mapper = mapper;
            _accountTypeRepository = AccountTypeRepository;
        }


        public async Task<List<AccountTypeDTO>> GetAllAsync()
        {
            return _mapper.Map<List<AccountTypeDTO>>(await _accountTypeRepository.GetAllAsync());
        }
        public async Task<AccountTypeDTO> AddAsync(AccountTypeDTO accountType)
        {
            return _mapper.Map<AccountTypeDTO>(await _accountTypeRepository.AddAsync(_mapper.Map<AccountType>(accountType)));
        }


    }
}
