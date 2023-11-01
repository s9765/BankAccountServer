using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount.Common.DTOs
{
    public class AccountDTO
    {
        public int Id { get; set; }
        public string AccountName { get; set; }

        [ForeignKey("MyAccountType")]
        public int AccountTypeId { get; set; }
        public AccountTypeDTO MyAccountType { get; set; }

        [ForeignKey("MyCurrencyType")]
        public int CurrencyTypeId { get; set; }
        public CurrencyTypeDTO MyCurrencytType { get; set; }
    }
}
