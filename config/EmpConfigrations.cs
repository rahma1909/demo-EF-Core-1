using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using demo.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace demo.config
{
    internal class EmpConfigrations : IEntityTypeConfiguration<Employee>
    {
        public void Configure(EntityTypeBuilder<Employee> e)
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

                e
                    .Property(e => e.DateCreation)
                    //.HasDefaultValue(DateTime.Now)
                    .HasDefaultValueSql("Getdate()");





            } 
        }
   
}
