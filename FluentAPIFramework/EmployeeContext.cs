using FluentAPIFramework.Entities;
using FluentAPIFramework.Mapping;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.Entity;
using System.Text;

namespace FluentAPIFramework
{
    public class EmployeeContext : DbContext
    {

        #region ctor
        public EmployeeContext() : base("Employee")
        {
            Database.SetInitializer(new DropCreateDatabaseAlways<EmployeeContext>());

            base.Configuration.LazyLoadingEnabled = false;
        }
        #endregion

        #region modelCreating
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            #region IncludetheMappingFunctions
            modelBuilder.Configurations.Add(new EmployeeMap());
            modelBuilder.Configurations.Add(new AddressInfoMap());
            modelBuilder.Configurations.Add(new CustomerMap());
            modelBuilder.Configurations.Add(new OrderMap());
            modelBuilder.Configurations.Add(new CategoryMap());
            #endregion
        }
        #endregion

        #region DatabaseSet
        public virtual DbSet<Employee> Employees { get; set; }
        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<Order> Orders { get; set; }
        public virtual DbSet<AddressInfo> AddressInfos { get; set; }
        public virtual DbSet<Category> Categories { get; set; }
        #endregion
    }
}
