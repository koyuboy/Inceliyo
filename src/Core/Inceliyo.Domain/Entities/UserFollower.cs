using Inceliyo.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inceliyo.Domain.Entities
{
    public class UserFollower : BaseEntity
    {
        public Guid SourceId { get; set; }
        public Guid TargetId { get; set; }
        public DateTime CreatedAt { get; set; }

        //public virtual User User { get; set; }
    }
}
