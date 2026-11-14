using NationalBankSystem.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NationalBankSystem.Models
{
    internal class Transactions
    {
        public int TransactionNumber { get; set; }
        public string Note { get; set; }
        public DateTime transactionDate { get; set; }
        public decimal transactionAmount { get; set; }
        public TransactionType transactionType { get; set; }
        public int AccountNumber { get; set; }
        public Account Account { get; set; }
    }
}
