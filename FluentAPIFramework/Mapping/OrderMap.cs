using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FluentAPIFramework
{
    public class OrderMap : EntityTypeConfiguration<Order>
    {
        #region Ctor
        public OrderMap()
        {
            this.ToTable("Orders");
            this.Property(m => m.Name)
                .IsRequired()
                .HasMaxLength(250);

            this.Property(m => m.Piece)
                .IsRequired();

            this.Property(m => m.Amount)
                .IsRequired()
                .HasPrecision(14, 2);

            this.HasRequired(s => s.Category)
                .WithMany(ad => ad.Orders)
                .HasForeignKey<int>(s => s.CategoryId);
        }
        #endregion
        
    }
}
