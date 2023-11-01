using BankAccount.Common.DTOs;
using BankAccount.Services.Intefaces;
using Microsoft.AspNetCore.Mvc;

namespace BankAccount.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserController : Controller
    {
        private readonly IUserService _userServise;

        public UserController(IUserService userServise)
        {
            _userServise = userServise;
        }
        [HttpGet]
        public async Task<List<UserDTO>> Get()
        {
            return await _userServise.GetAllAsync();
        }


        [HttpPost]
        public async Task<UserDTO> Add([FromBody] UserDTO user)
        {
            //UserDTO p = new UserDTO() { Tz = "", DateOfBirth = user.DateOfBirth, FirstName = person.FirstName, LastName = person.LastName, HMO = person.HMO, Gender = person.Gender, Tz = person.Tz };
            return await _userServise.AddAsync(user);
        }


    }
}