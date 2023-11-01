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
    public class AccountService:IAccountService
    {

        private readonly IAccountRepository _accountRepository;
        private readonly IMapper _mapper;
        public AccountService(IAccountRepository AccountRepository, IMapper mapper)
        {
            _mapper = mapper;
            _accountRepository = AccountRepository;
        }


        public async Task<List<AccountDTO>> GetAllAsync()
        {
            return _mapper.Map<List<AccountDTO>>(await _accountRepository.GetAllAsync());
        }
        public async Task<AccountDTO> AddAsync(AccountDTO account)
        {
            return _mapper.Map<AccountDTO>(await _accountRepository.AddAsync(_mapper.Map<Account>(account)));
        }


    }
}
