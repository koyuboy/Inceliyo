using Inceliyo.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inceliyo.Domain.Entities
{
    public class CommentAction : BaseEntity
    {
        public Guid CommentId { get; set; }
        public bool IsLike { get; set; }
        public Guid ActorId { get; set; }

        public Comment Comment { get; set; }
    }
}
