using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount.Common.DTOs
{
    public class AccountOfUserDTO
    {
        [ForeignKey("MyUser")]
        public string UserId { get; set; }
        public UserDTO MyUser { get; set; }


        [ForeignKey("MyAccount")]
        public int AccountId { get; set; }
        public AccountDTO MyAccount { get; set; }
    }
}
