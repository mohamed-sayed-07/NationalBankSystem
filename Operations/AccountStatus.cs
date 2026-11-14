using NationalBankSystem.Enums;
using NationalBankSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NationalBankSystem.Operations
{
    public class AccountStatus
    {
        public static void UpdateAccountStatus(DbBank db)
        {
            Console.WriteLine("Enter Account number???");
            int accountNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Customer ID???");
            int customerid = Convert.ToInt32(Console.ReadLine());

            var customerAccount = db.Set<Accountcustomers>()
               .FirstOrDefault(ca =>
                                   ca.AccountId == accountNumber &&
                                      ca.Customerid == customerid);
            if (customerAccount == null)
            {
                Console.WriteLine("Account or Customer relationship not found!");
                return;
            }
            else
            {
             if(customerAccount.accountstatus== Accountstatus.Active)
                {
                    customerAccount.accountstatus = Accountstatus.Inactive;
                }
                else
                {
                    customerAccount.accountstatus = Accountstatus.Active;
                }
                db.SaveChanges();

                Console.WriteLine("Account Status Updated Successfully!");
            }
        }
        
    }
}
