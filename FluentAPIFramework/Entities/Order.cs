using FluentAPIFramework.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FluentAPIFramework
{
    public class Order : BaseEntity
    {
        #region Properties
        public string Name { get; set; }
        public decimal Amount { get; set; }
        public int Piece { get; set; }
        #endregion

        #region Relationships
        public int CategoryId { get; set; }
        public virtual Category Category { get; set; }
        #endregion
    }
}
