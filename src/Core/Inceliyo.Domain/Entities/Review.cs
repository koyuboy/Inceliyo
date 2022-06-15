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
        public String? CoverImagePath { get; set; }
        public String Content { get; set; }
        public bool IsDraft { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public bool IsDeleted { get; set; }

        public ICollection<ReviewAction> ReviewActions { get; set; }
        public ICollection<ReviewMedia> ReviewMedias { get; set; }
        public ICollection<Comment> Comments { get; set; }
        public ICollection<ReviewMarketLink> ReviewMarketLinks { get; set; }
        public ICollection<SavedReview> SavedReviews { get; set; }
        public User User { get; set; }
        public Category Category { get; set; }



    }
}
