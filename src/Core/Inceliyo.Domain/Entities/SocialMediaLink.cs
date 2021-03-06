using Inceliyo.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inceliyo.Domain.Entities
{
    public class SocialMediaLink : BaseEntity
    {
        public Guid UserProfileId { get; set; }
        public Guid SocialMediaId { get; set; }
        public string Link { get; set; }

        public UserProfile UserProfile { get; set; }
        public SocialMedia SocialMedia { get; set; }
    }
}
