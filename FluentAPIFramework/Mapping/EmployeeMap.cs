using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Text;

namespace FluentAPIFramework
{
    public class EmployeeMap : EntityTypeConfiguration<Employee>
    {
        public EmployeeMap()
        {
            this.ToTable("Employee");
            //Surname properties are assigned


            this.Property(m => m.Surname)
                .IsRequired()
                .HasMaxLength(50);
            //Firstname properties are assigned
            this.Property(m => m.Firstname)
                .IsRequired()
                .HasMaxLength(50);
            //Lastname properties are assigned
            this.Property(m => m.Lastname)
                .IsOptional()
                .HasMaxLength(50);
            //Age property is assigned
            this.Property(m => m.Age)
                .IsRequired();
            //MonthlySalary properties are assigned
            this.Property(m => m.MonthlySalary)
                .IsRequired()
                .HasColumnType("decimal")
                .HasPrecision(14, 5);
            //We will use this porperties in the code wide we will not use this property in the database side. Therefore, we ignored it.
            this.Ignore(m => m.Fullname);
            //Relationships
          
            //To Table is providing us to create a table whose name is Employee
            




        }
    }
}
