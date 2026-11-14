using NationalBankSystem.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NationalBankSystem.Models
{
    internal class Accountcustomers
    {

        public DateTime OwnerShipCreateDate { get; set; }
        public Accountstatus accountstatus { get; set; }
        public Ownershiptype ownershiptype { get; set; }


        public int AccountId { get; set; }
        public Account Account { get; set; } 

        public int Customerid { get; set; }
        public Customers Customer { get; set; }
    }
}
