using Inceliyo.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inceliyo.Domain.Entities
{
    public class User : BaseEntity
    {
        public String UserName { get; set; }
        public String FullName { get; set; }
        public String Email { get; set; }
        public bool IsApproved { get; set; }
        public String PasswordHash { get; set; }
        public String Salt { get; set; }
        public DateTime RegisteredAt { get; set; }
        public DateTime LastLogin { get; set; }

        public virtual ICollection<Review> Reviews { get; set; }
        public virtual ICollection<Comment> Comments { get; set; }
        public virtual ICollection<SavedReview> SavedReviews { get; set; }
        public virtual ICollection<UserFollower> UserFollowers { get; set; }
        public virtual UserProfile UserProfile { get; set; }
        

    }
}
