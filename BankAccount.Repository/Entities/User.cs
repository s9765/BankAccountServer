using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount.Repository.Entities
{
    public class User
    {
        public enum EnumGender
        {
            Male = 0,
            Female = 1,
        }

       
            //public int Id { get; set; }
            [Key]
            public string Tz { get; set; }

            public string FirstName { get; set; }
            public string LastName { get; set; }
            public DateTime DateOfBirth { get; set; }
            public EnumGender Gender { get; set; }
            //public List<Account> Accounts { get; set; }

        
    }
}
