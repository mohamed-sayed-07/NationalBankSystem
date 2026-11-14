using NationalBankSystem.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NationalBankSystem.Models
{
    internal class Customers
    {
        public int CustomersId { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string Address { get; set; }
        public string NationalId { get; set; }
        public DateTime DateOfBirth { get; set; }
        public CustomerType CustomerType { get; set; }
        public List<Accountcustomers> AccountCustomers { get; set; }

    }
}
