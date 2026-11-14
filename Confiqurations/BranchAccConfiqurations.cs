using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NationalBankSystem.Models;
using System.Reflection.Emit;

namespace NationalBankSystem.Configurations
{
    internal class BranchAccConfiguration
        : IEntityTypeConfiguration<branch>
    {
        public void Configure(EntityTypeBuilder<branch> builder)
        {
            builder.HasKey(b => b.Code);

            builder.HasMany(b => b.account)
                   .WithOne(a => a.Branch)
                   .HasForeignKey(a => a.BranchCode)
                   .IsRequired();
            builder.HasData(
              new branch { Code = 1, Name = "Main Branch", Address = "Cairo - Tahrir St", PhoneNumber = "01000000001" },
               new branch { Code = 2, Name = "Cairo Branch", Address = "Alex - Corniche St", PhoneNumber = "01000000002" },
               new branch { Code = 3, Name = "sharqia Branch", Address = "Alex - madinat St", PhoneNumber = "01000000002" },
               new branch { Code = 4, Name = "Luxor Branch", Address = "teba - 30e St", PhoneNumber = "01000000002" },
               new branch { Code = 5, Name = "maadi Branch", Address = "cairo - 312 St", PhoneNumber = "01000000002" }
              );
                
        }
    }
}