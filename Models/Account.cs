using NationalBankSystem.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NationalBankSystem.Models
{
    internal class Account
    {
        public int AccountNumber { get; set; }
        public decimal currentBalance { get; set; }
        public DateTime openingDate { get; set; }
       public AccountType accountType { get; set; }
        public int BranchCode { get; set; }
        public branch Branch { get; set; }

        public List<Transactions> transactions { get; set; }
        public List<Accountcustomers> AccountCustomers { get; set; }
    }
}
