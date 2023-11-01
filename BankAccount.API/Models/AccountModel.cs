using BankAccount.Common.DTOs;
using System.ComponentModel.DataAnnotations.Schema;

namespace BankAccount.API.Models
{
    public class AccountModel
    {

        public int Id { get; set; }
        public string AccountName { get; set; }

        public int AccountTypeId { get; set; }

        public int CurrencyTypeId { get; set; }

        public int SumToPass { get; set; }

    }
}
