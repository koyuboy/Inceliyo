using Inceliyo.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inceliyo.Domain.Entities
{
    public class Comment : BaseEntity
    {
        public Guid UserId { get; set; }
        public Guid ReviewId { get; set; }
        public String Content { get; set; }
        public DateTime CreatedAt { get; set; }
        public bool IsDeleted { get; set; }

        public virtual ICollection<CommentAction> CommentActions { get; set; }
        public virtual User User { get; set; }
        public virtual Review Review { get; set; }
    }
}
