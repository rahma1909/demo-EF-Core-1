using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using demo.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace demo.Data
{
    internal class companyDbContext : DbContext
    {
        public companyDbContext() : base()
        {

        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //optionsBuilder.UseSqlServer("Data Source=.; Initial Catalog= Company; Integrated Security=True;");
            //optionsBuilder.UseSqlServer("Server=.; Database= Company; Trusted_Connection=True; Encrypt=True;TrustServerCertificate-True;");
            optionsBuilder.UseSqlServer("Server=.;Database=Company;Integrated Security=True;Encrypt=True;TrustServerCertificate=True;");
        }

        public DbSet<Employee> Employees { get; set; }
        public DbSet<Department> Departments { get; set; }

    }
}
