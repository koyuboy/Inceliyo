using Inceliyo.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inceliyo.Domain.Entities
{
    public class Review : BaseEntity
    {
        public Guid UserId { get; set; }
        public Guid CategoryId { get; set; }
        public String Title { get; set; }
        public String CoverImagePath { get; set; }
        public String Content { get; set; }
        public bool IsDraft { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public bool IsDeleted { get; set; }

        public virtual ICollection<ReviewAction> ReviewActions { get; set; }
        public virtual ICollection<ReviewMedia> ReviewMedias { get; set; }
        public virtual ICollection<Comment> Comments { get; set; }
        public virtual ICollection<ReviewMarketLink> ReviewMarketLinks { get; set; }
        public virtual ICollection<SavedReview> SavedReviews { get; set; }
        public virtual User User { get; set; }
        public virtual Category Category { get; set; }



    }
}
