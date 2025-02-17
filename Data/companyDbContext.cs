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


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<Employee>().HasKey("EmpId");
            //modelBuilder.Entity<Employee>().HasKey(nameof(Employee.EmpId));
            //modelBuilder.Entity<Employee>().HasKey(E=>E.EmpId);

            //modelBuilder.Entity<Employee>()
            //    .Property(e=>e.Name)
            //    .IsRequired()
            //    .HasColumnType("varchar")
            //    .HasMaxLength(50)
            //    .HasColumnName("empName");

            //modelBuilder.Entity<Employee>()
            //    .Property(e => e.Age)
            //    .IsRequired(false);


            //modelBuilder.Entity<Employee>()
            //    .Property(e => e.Salary)
            //    .HasColumnType("money");

            //modelBuilder.Entity<Employee>()
            //    .Property(e => e.DateCreation)
            //    //.HasDefaultValue(DateTime.Now)
            //    .HasDefaultValueSql("Getdate()");


            modelBuilder.Entity<Employee>(e =>
            {

                e.HasKey(E => E.EmpId);

              e
                    .Property(e => e.Name)
                    .IsRequired()
                    .HasColumnType("varchar")
                    .HasMaxLength(50)
                    .HasColumnName("empName");

               e
                    .Property(e => e.Age)
                    .IsRequired(false);


            e
                    .Property(e => e.Salary)
                    .HasColumnType("money");

                modelBuilder.Entity<Employee>()
                    .Property(e => e.DateCreation)
                    //.HasDefaultValue(DateTime.Now)
                    .HasDefaultValueSql("Getdate()");





            });
        }
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
        //public DbSet<Department> Departments { get; set; }
        public DbSet<product> products { get; set; }
        //public DbSet<Project> projects { get; set; }

    }
}
