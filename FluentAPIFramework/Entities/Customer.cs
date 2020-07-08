using FluentAPIFramework.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FluentAPIFramework
{
    public class Customer : BaseEntity
    {
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }
        public string FullName
        {
            get
            {
                return $"{Surname} {Firstname} {Lastname}";
            }
        }

        public int AddressInfoId { get; set; }

        public bool Deleted { get; set; }

        #region Navigation Properties

        public virtual AddressInfo AddressInfo { get; set; }
        public virtual ICollection<Order> Orders { get; set; }
        #endregion

    }
}
