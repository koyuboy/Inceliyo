using Inceliyo.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inceliyo.Domain.Entities
{
    public class ReviewMarketLink : BaseEntity
    {
        public Guid ReviewId { get; set; }
        public Guid MarketId { get; set; }
        public String Link { get; set; }

        public Review Review { get; set; }
        public Market Market { get; set; }
    }
}
