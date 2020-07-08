using FluentAPIFramework.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FluentAPIFramework
{

    public class Category : BaseEntity
    {

        public Category()
        {
            this.Orders = new List<Order>();
        }

        #region Properties
        public string Name { get; set; }
        #endregion

        #region Navigation Properties
        public virtual ICollection<Order> Orders { get; set; }
        #endregion
    }
}
