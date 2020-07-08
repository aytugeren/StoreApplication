using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FluentAPIFramework.Entities
{
    public class AddressInfo : BaseEntity
    {
        #region Properties
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string ZipCode { get; set; }
        #endregion

        #region Navigation Properties
        public virtual Customer Customer { get; set; }
        #endregion
    }
}
