using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NationalBankSystem.Models;

namespace NationalBankSystem.Configurations
{
    internal class AccountCustomersConfiguration
        : IEntityTypeConfiguration<Accountcustomers>
    {
        public void Configure(EntityTypeBuilder<Accountcustomers> builder)
        {
            builder.HasKey(ac => new { ac.Customerid, ac.AccountId });

            
            builder.HasOne(ac => ac.Account)
                   .WithMany(a => a.AccountCustomers)
                   .HasForeignKey(ac => ac.AccountId);

           
            builder.HasOne(ac => ac.Customer)
                   .WithMany(c => c.AccountCustomers)
                   .HasForeignKey(ac => ac.Customerid);
        }
    }
}