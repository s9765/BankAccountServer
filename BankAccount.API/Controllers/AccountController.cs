using BankAccount.Common.DTOs;
using BankAccount.Services.Intefaces;
using Microsoft.AspNetCore.Mvc;

namespace BankAccount.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AcccountTypeController : Controller
    {
        private readonly IAccountTypeService _accountTypeServise;

        public AcccountTypeController(IAccountTypeService accountTypeServise)
        {
            _accountTypeServise = accountTypeServise;
        }
        [HttpGet]
        public async Task<List<AccountTypeDTO>> Get()
        {
            return await _accountTypeServise.GetAllAsync();
        }


        [HttpPost]
        public async Task<AccountTypeDTO> Add([FromBody] AccountTypeDTO accountTypeDTO)
        {
            //accountTypeDTO p = new accountTypeDTO() { Tz = "", DateOfBirth = accountType.DateOfBirth, FirstName = person.FirstName, LastName = person.LastName, HMO = person.HMO, Gender = person.Gender, Tz = person.Tz };
            return await _accountTypeServise.AddAsync(accountTypeDTO);
        }


    }
}