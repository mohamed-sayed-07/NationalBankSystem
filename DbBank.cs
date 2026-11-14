using Microsoft.EntityFrameworkCore;
using NationalBankSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NationalBankSystem
{
    public class DbBank : DbContext
    {
        override protected void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.;Database=NationalBankSystem;Trusted_Connection=True;TrustServerCertificate=True;");
        }
        DbSet<Customers> Customers { get; set; }
        DbSet<branch> branch { get; set; }
        DbSet<Transactions> Transactions { get; set; }
        DbSet<Manager> Manager { get; set; }
        DbSet<Account> Account{ get; set; }
        DbSet<Accountcustomers> Accountcustomers { get; set; }
        
        override protected void OnModelCreating(ModelBuilder modelBuilder)
        {

          
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(DbBank).Assembly);
        }
    }
}
