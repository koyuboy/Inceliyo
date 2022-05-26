using Inceliyo.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inceliyo.Domain.Entities
{
    public class Market : BaseEntity
    {
        public String Name { get; set; }
        public String IconPath { get; set; }

        public virtual ICollection<ReviewMarketLink> ReviewMarketLinks { get; set; }
    }
}
