using FluentAPIFramework.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FluentAPIFramework.Mapping
{
    public class AddressInfoMap : EntityTypeConfiguration<AddressInfo>
    {
        #region ctor
        public AddressInfoMap()
        {
            this.ToTable("Address");
            this.Property(m => m.Address1)
                .IsOptional();
            this.Property(m => m.Address2)
                .IsOptional();
            this.Property(m => m.ZipCode)
                .IsOptional();
        }
        #endregion
    }
}
