using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NationalBankSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NationalBankSystem.Configurations
{
    internal class BranchManagerConfiguration : IEntityTypeConfiguration<Manager>
    {
        public void Configure(EntityTypeBuilder<Manager> builder)
        {
            builder.ToTable("Managers");
            builder.HasKey(m => m.Id);

            
            builder.HasOne(m => m.branch)
                   .WithOne(b => b.manager)
                   .HasForeignKey<Manager>(m => m.branchId)
                   .OnDelete(DeleteBehavior.Restrict);
            builder.HasData(
               new Manager
               {
                   Id = 1,
                   FullName = "Ahmed Ali",
                   Email = "ahmed.manager@bank.com",
                   PhoneNumber = "01011111111",
                   Hiredate = new DateTime(2022, 1, 10),
                   branchId = 1 
               },
                new Manager
                {
                    Id = 2,
                    FullName = "Mahmoud Khaled",
                    Email = "mahmoud.manager@bank.com",
                    PhoneNumber = "01022222222",
                    Hiredate = new DateTime(2023, 6, 15),
                    branchId = 2
                },
                 new Manager
                 {
                     Id = 3,
                     FullName = "ahmed ali",
                     Email = "ali.manager@bank.com",
                     PhoneNumber = "0103328229209",
                     Hiredate = new DateTime(2023, 6, 15),
                     branchId = 3
                 }
                );
        }
    }
}