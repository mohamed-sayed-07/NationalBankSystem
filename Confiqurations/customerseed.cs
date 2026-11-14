using global::NationalBankSystem.Models;
using Microsoft.EntityFrameworkCore;

namespace NationalBankSystem.Confiqurations
{
    namespace NationalBankSystem.SeedData
    {
        internal class CustomerSeed
        {
            public static void Seed(ModelBuilder modelBuilder)
            {
                modelBuilder.Entity<Customers>().HasData(
                    new Customers
                    {
                        CustomersId = 1,
                        FullName = "Mohamed Sayed",
                        NationalId = "12345678901234"
                    },
                    new Customers
                    {
                        CustomersId = 2,
                        FullName = "Ahmed Ali",
                        NationalId = "98765432109876"
                    }
                );
            }
        }
    }
}
