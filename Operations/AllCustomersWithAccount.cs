using Microsoft.EntityFrameworkCore;
using NationalBankSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NationalBankSystem.Operations
{
    internal class AllCustomersWithAccount
    {
        public static void displayAllCustomersWithAccount(DbBank db)
        {
            var customerwithAccount= db.Set<Customers>()
          .Include(c=>c.AccountCustomers)
        .ThenInclude(ca => ca.Account)
            .ToList();

            foreach (var customer in customerwithAccount)
            {
                Console.WriteLine($"Customer ID: {customer.CustomersId}, Name: {customer.FullName}, Email: {customer.Email}");
                foreach (var accountCustomer in customer.AccountCustomers)
                {
                   
                    Console.WriteLine($"\tAccount ID: {accountCustomer.Account.AccountNumber}, Account Number: {accountCustomer.Account.AccountNumber}, Balance: {accountCustomer.Account.currentBalance}");
                }
            }
        }
    }
}
