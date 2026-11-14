using NationalBankSystem.Enums;
using NationalBankSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NationalBankSystem.Operations
{
    internal class customer
    {
        public static void AddCustomer(DbBank dbBank)
        {
            string nationalId;
            string name;
            string email;
            string phone;
            string address;
            DateTime dateOfBirth;
            do
            {
                Console.Write("Enter Full Name: ");
                name = Console.ReadLine();
            } while (string.IsNullOrWhiteSpace(name));


            do {
                Console.Write("Enter National ID: ");
                nationalId = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(nationalId))
                {
                    Console.WriteLine("National ID cannot be empty. Please enter a valid National ID.");
                    return;
                }
            } while (string.IsNullOrWhiteSpace(nationalId) || nationalId.Length != 14);




            do {
                Console.Write("Enter Date Of Birth: ");
                dateOfBirth = DateTime.Parse(Console.ReadLine());
            } while (dateOfBirth > DateTime.Now);

            do {
                Console.Write("Enter Email: ");
                email = Console.ReadLine();
            } while (email == null);
            do {
                Console.Write("Enter Phone: ");
                phone = Console.ReadLine();
            } while (phone != null);
            do {
                Console.Write("Enter Address: ");
                address = Console.ReadLine();
            } while (address != null);

            Console.WriteLine("1. Individual");
            Console.WriteLine("2. Business");

            Console.Write("Choose Customer Type: ");
            int typeChoice = int.Parse(Console.ReadLine());
            CustomerType customertype;
            if (typeChoice == 1)
            {
                customertype = CustomerType.individual;
            }
            else if (typeChoice == 2)
            {
                customertype = CustomerType.business;
            }
            else
            {
                Console.WriteLine("Invalid choice. Defaulting to Individual.");
                customertype = CustomerType.individual;
            }
            dbBank.Set<Customers>().Add(
            new Customers
            {
                NationalId = nationalId,
                FullName = name,
                Email = email,
                PhoneNumber = phone,
                Address = address,
                CustomerType = customertype,
                DateOfBirth = dateOfBirth
            });
            dbBank.SaveChanges();

            Console.WriteLine("Customer Added Successfully!");


        } 
    }
}