using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount.Repository.Entities
{
    public class AccountOfUser
    {
        public int Id { get; set; }

        [ForeignKey("MyUser")]
        public string UserId { get; set; }
        public User MyUser { get; set; }


        [ForeignKey("MyAccount")]
        public int AccountId { get; set; }
        public Account MyAccount { get; set; }

    }
}
