using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount.Repository.Entities
{
    public class Account
    {
        public int Id { get; set; }
        public string AccountName { get; set; }

        [ForeignKey("MyAccountType")]
        public int AccountTypeId { get; set; }
        public AccountType MyAccountType { get; set; }

        [ForeignKey("MyCurrencyType")]
        public int CurrencyTypeId { get; set; }
        public CurrencyType MyCurrencytType { get; set; }


    }
}
