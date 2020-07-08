using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FluentAPIFramework.Entities
{
    public class Course : BaseEntity
    {
        public Course()
        {
            this.Employees = new List<Employee>();
        }
        public string Name { get; set; }

        #region Navigation Properties
        public virtual ICollection<Employee> Employees { get; set; }
        #endregion
    }
}
