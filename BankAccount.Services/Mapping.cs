using AutoMapper;
using BankAccount.Common.DTOs;
using BankAccount.Repository.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace MyProject.Services
{
    public class Mapping:Profile
    {
        public Mapping()
        {
            CreateMap<User, UserDTO>().ReverseMap();
            CreateMap<User, UserDTO>()
                .ForMember(dest => dest.Gender, opt => opt.MapFrom(src => src.Gender.ToString()));

            CreateMap<Account, AccountDTO>().ReverseMap();
            CreateMap<AccountType, AccountTypeDTO>().ReverseMap();
            CreateMap<CurrencyType, CurrencyTypeDTO>().ReverseMap();
            CreateMap<AccountOfUser, AccountOfUserDTO>().ReverseMap();
        }
    }

    
}
