using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF1_Demo.Data.Models
{
    internal class CompanyDbContext : DbContext
    {
        //CompanyDbContext() : base() { }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server = DESKTOP-K2FJ8AV; Database = CompanyG03; Trusted_Connection = true; trustservercertificate = true");
        }
        public DbSet<Employee> Employees { get; set; }
    }
}
