using Microsoft.EntityFrameworkCore;
using NationalBankSystem.Models;
using NationalBankSystem.Operations;

namespace NationalBankSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
         using   DbBank dbBank = new DbBank();
            bool isRunning = true;

            while (isRunning)
            {
                Console.WriteLine("========== National Bank System ==========");
                Console.WriteLine("1. add a New Customer");
                Console.WriteLine("2. open a New Account For Customer");
                Console.WriteLine("3. update Account status");
                Console.WriteLine("4. Remove an Account From a Customer");
                Console.WriteLine("5. List All customers");
                Console.WriteLine("0. Exit");
                Console.WriteLine("---------------------------------------------");
                Console.WriteLine("Choose an option: ");
                string Option = Console.ReadLine();


                switch (Option)
                {
                    case "1":
                        customer.AddCustomer(dbBank);
                        break;

                    case "2":
                        OpenAcc.OpenAccount();
                        break;

                    case "3":
                        AccountStatus.UpdateAccountStatus(dbBank);
                        break;

                    case "4":
                        Remove_relation.remove(dbBank);
                        break;

                    case "5":
                        AllCustomersWithAccount.displayAllCustomersWithAccount(dbBank);
                        break;
                    case "0":
                        isRunning = false;
                        Console.WriteLine("Thank you for using National Bank System!");
                        break;

                    default:
                        Console.WriteLine("Invalid choice! Please choose from 0 to 5.");
                        break;
                }
                if (isRunning)
                {
                    Console.WriteLine("\nPress any key to return to the menu...");
                    Console.ReadKey();
                }
            }
        }
    }
}
             
       

