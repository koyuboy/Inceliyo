using Inceliyo.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inceliyo.Domain.Entities
{
    public class SavedReview : BaseEntity
    {
        public Guid UserId { get; set; }
        public Guid ReviewId { get; set; }
        public DateTime CreatedAt { get; set; }

        public User User { get; set; }
        public Review Review { get; set; }
    }
}
