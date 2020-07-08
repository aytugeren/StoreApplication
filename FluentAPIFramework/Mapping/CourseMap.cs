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
   public class CourseMap : EntityTypeConfiguration<Course>
    {
        #region ctor

        public CourseMap()
        {
            this.ToTable("Courses");
            this.Property(m => m.Name)
                .IsRequired()
                .HasMaxLength(150);

            //Many-to-Many Navigation Property
            this.HasMany<Employee>(s => s.Employees)
                .WithMany(c => c.Courses)
                .Map(cs =>
                {
                    cs.MapLeftKey("EmployeeRefId");
                    cs.MapRightKey("CourseRefId");
                    cs.ToTable("EmployeeCourse");
                });
        }

        #endregion
    }
}
