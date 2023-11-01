using BankAccount.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount.Common.DTOs
{
    public class UserAccountRequest
    {
        public List<UserDTO> Users { get; set; }
        public List<AccountModel> Accounts { get; set; }
    }



}
