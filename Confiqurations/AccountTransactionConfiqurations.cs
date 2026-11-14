using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NationalBankSystem.Enums;
using NationalBankSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NationalBankSystem.Configurations
{

    internal class AccountTransactionConfigurations : IEntityTypeConfiguration<Account>
    {

        public void Configure(EntityTypeBuilder<Account> builder)
        {

            builder.HasKey(a => a.AccountNumber);

            builder.HasMany(a => a.transactions)
                   .WithOne(t => t.Account)
                   .HasForeignKey(t => t.AccountNumber)
                   .OnDelete(DeleteBehavior.Restrict);
            builder.HasData(
               new Account
               {
                   AccountNumber = 1001,
                   currentBalance = 5000,
                   openingDate = new DateTime(2026, 1, 1),
                   accountType = AccountType.savings,
                   BranchCode = 1
               },
               new Account
               {
                   AccountNumber = 1002,
                   currentBalance = 10000,
                   openingDate = new DateTime(2026, 1, 2),
                   accountType = AccountType.current,
                   BranchCode = 1
               }
               );
        }
    }
}
               




