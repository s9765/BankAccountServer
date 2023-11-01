using AutoMapper;
using BankAccount.Common.DTOs;
using BankAccount.Repository.Entities;
using BankAccount.Repository.Interfecaes;
using BankAccount.Repository.Repository;
using BankAccount.Services.Intefaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount.Services.Services
{
    public class AccountOfUserService:IAccountOfUserService
    {

        private readonly IAccountOfUserRepository _AccountOfUserRepository;
        private readonly IMapper _mapper;
        public AccountOfUserService(IAccountOfUserRepository accountOfUserRepository, IMapper mapper)
        {
            _mapper = mapper;
            _AccountOfUserRepository = accountOfUserRepository;
        }


        public async Task<List<AccountOfUserDTO>> GetAllAsync()
        {
            return _mapper.Map<List<AccountOfUserDTO>>(await _AccountOfUserRepository.GetAllAsync());
        }
        public async Task<AccountOfUserDTO> AddAsync(AccountOfUserDTO AccountOfUser)
        {
            return _mapper.Map<AccountOfUserDTO>(await _AccountOfUserRepository.AddAsync(_mapper.Map<AccountOfUser>(AccountOfUser)));
        }


    }
}
