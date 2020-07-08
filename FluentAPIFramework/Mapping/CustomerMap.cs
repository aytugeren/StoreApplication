using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FluentAPIFramework.Mapping
{
    public class CustomerMap:EntityTypeConfiguration<Customer>
    {
        #region ctor
        public CustomerMap()
        {
            this.ToTable("Customers");
            this.Property(m => m.Firstname)
                .IsRequired()
                .HasMaxLength(70);
            
            this.Property(m => m.Lastname)
                .HasMaxLength(70);

            this.Property(m => m.Age)
                .IsRequired();

            this.HasRequired(s => s.AddressInfo)
                .WithRequiredPrincipal(ad => ad.Customer);


        }
        #endregion
    }
}
