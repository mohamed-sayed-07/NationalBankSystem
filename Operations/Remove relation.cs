using NationalBankSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NationalBankSystem.Operations
{
    internal class Remove_relation
    {

        
        public static void remove(DbBank db)
        {
            Console.WriteLine("enter account number");
            int accountNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter customer Id");
            int customerId = Convert.ToInt32(Console.ReadLine());

            var customerAccount = db.Set<Accountcustomers>()
        .FirstOrDefault(ca =>
            ca.AccountId == accountNumber &&
            ca.Customerid == customerId);
            if (customerAccount == null)
            {
                Console.WriteLine("Relationship Not Found!");
                return;
            }
            else
            {

                db.Set<Accountcustomers>().Remove(customerAccount);

                db.SaveChanges();

                Console.WriteLine("Account Removed From Customer Successfully!");
            }
        }
    }
}
