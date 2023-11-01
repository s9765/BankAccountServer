using BankAccount.API.Models;
using BankAccount.Common.DTOs;
using BankAccount.Repository.Entities;
using BankAccount.Services.Intefaces;
using Microsoft.AspNetCore.Mvc;

namespace BankAccount.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class GeneralController : Controller
    {
        private readonly IAccountService _accountServise;
        private readonly IAccountOfUserService _accountOfUserServise;
        private readonly IUserService _userServise;


        public GeneralController(IAccountService accountServise, IUserService userTypeServise, IAccountOfUserService accountOfUserServise)
        {
            _accountServise = accountServise;
            _userServise = userTypeServise;
            _accountOfUserServise = accountOfUserServise;
        }



        [HttpPost]
        public async Task<IActionResult> Add([FromBody] UserAccountRequest request)
        {
            bool flag = false;

            foreach (var user in request.Users)
            {
               
                try
                {
                    UserDTO newUser = await _userServise.AddAsync(user);
                }
                catch (Exception ex)
                {
                    flag = true;
                }
   
                    AccountModel account1 = request.Accounts.FirstOrDefault(a => a.Id == user.AccountId);
                    AccountDTO a = new AccountDTO() { Id = account1.Id, AccountName = account1.AccountName, AccountTypeId = account1.AccountTypeId, CurrencyTypeId = account1.CurrencyTypeId };
                    if (account1 != null)
                    {
                        AccountDTO result = await _accountServise.AddAsync(a);
                        await _accountOfUserServise.AddAsync(new AccountOfUserDTO() { AccountId = result.Id, UserId = user.Tz });
                    }
                
           
            }
            if (flag)
            {
                    return BadRequest("Invalid request data");

            }
            return Ok();
        }


    }
}