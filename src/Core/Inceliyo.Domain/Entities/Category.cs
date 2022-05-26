using Inceliyo.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inceliyo.Domain.Entities
{
    public class Category : BaseEntity
    {
        public string Name { get; set; }
        public Guid ParentId { get; set; }

        public virtual ICollection<Review> Reviews { get; set; }
    }
}
