using NationalBankSystem.Enums;
using NationalBankSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NationalBankSystem.Operations
{
    internal class OpenAcc
    {
        public static void OpenAccount()
        {
            using (DbBank db = new DbBank())
            {
                Console.Write("Enter Account Number: ");
                if (!int.TryParse(Console.ReadLine(), out int accountNumber))
                {
                    Console.WriteLine("Invalid Account Number.");
                    return;
                }

                Console.WriteLine("Enter Account Type:");
                Console.WriteLine("1. Savings");
                Console.WriteLine("2. Current");
                Console.WriteLine("3. Fixed Deposit");
                Console.WriteLine("4. Recurring Deposit");

                if (!int.TryParse(Console.ReadLine(), out int typeChoice))
                {
                    Console.WriteLine("Invalid Account Type.");
                    return;
                }

                AccountType accountType;

                switch (typeChoice)
                {
                    case 1:
                        accountType = AccountType.savings;
                        break;
                    case 2:
                        accountType = AccountType.current;
                        break;
                    case 3:
                        accountType = AccountType.fixedDeposit;
                        break;
                    case 4:
                        accountType = AccountType.recurringDeposit;
                        break;
                    default:
                        Console.WriteLine("Invalid Account Type.");
                        return;
                }

                Console.Write("Enter Branch Code: ");
                if (!int.TryParse(Console.ReadLine(), out int branchCode))
                {
                    Console.WriteLine("Invalid Branch Code.");
                    return;
                }

                Console.Write("Enter Customer ID: ");
                if (!int.TryParse(Console.ReadLine(), out int customerId))
                {
                    Console.WriteLine("Invalid Customer ID.");
                    return;
                }

                Console.WriteLine("Enter Ownership Role:");
                Console.WriteLine("1. Primary");
                Console.WriteLine("2. CoHolder");

                if (!int.TryParse(Console.ReadLine(), out int roleChoice))
                {
                    Console.WriteLine("Invalid Ownership Role.");
                    return;
                }

                Ownershiptype ownershipRole;

                switch (roleChoice)
                {
                    case 1:
                        ownershipRole = Ownershiptype.Sole;
                        break;
                    case 2:
                        ownershipRole = Ownershiptype.Joint;
                        break;
                    default:
                        Console.WriteLine("Invalid Ownership Role.");
                        return;
                }

                var branch = db.Set<branch>()
                    .FirstOrDefault(b => b.Code == branchCode);

                var customer = db.Set<Customers>()
                    .FirstOrDefault(c => c.CustomersId == customerId);

                if (branch == null)
                {
                    Console.WriteLine("Branch not found.");
                    return;
                }

                if (customer == null)
                {
                    Console.WriteLine("Customer not found.");
                    return;
                }

                Account account = new Account
                {
                    AccountNumber = accountNumber,
                    accountType = accountType,
                    BranchCode = branchCode,
                    currentBalance = 0,
                    openingDate = DateTime.Now
                };

                Accountcustomers accountCustomer = new Accountcustomers
                {
                    AccountId = accountNumber,
                    Customerid = customerId,
                    ownershiptype = ownershipRole
                };

                db.Set<Account>().Add(account);
                db.Set<Accountcustomers>().Add(accountCustomer);

                db.SaveChanges();

                Console.WriteLine("Account Opened Successfully!");
            }
        }


    }
    }


