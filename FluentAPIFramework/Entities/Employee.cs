using FluentAPIFramework.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace FluentAPIFramework
{
    public class Employee : BaseEntity
    {


        #region Properties
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }
        public decimal MonthlySalary { get; set; }
        public string Fullname { get { return $"{Surname} {Firstname} {Lastname}"; } }
      
        #endregion

        #region Navigation Properties
 
        public virtual ICollection<Course> Courses { get; set; }
        #endregion
    }
}
