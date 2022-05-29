using Inceliyo.Domain.Common;
using Inceliyo.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inceliyo.Domain.Entities
{
    public class UserProfile : BaseEntity
    {
        public Guid UserId { get; set; }
        public String ProfileImagePath { get; set; }
        public String CoverImagePath { get; set; }
        public String Bio { get; set; }
        public bool IsEmailNotification { get; set; }
        public NotificationState NotifiacationStateType { get; set; }
        public PrivacyState WhoSendMessage { get; set; }
        public PrivacyState WhoSendComment { get; set; }

        public User User { get; set; }
        public ICollection<SocialMediaLink> SocialMediaLinks { get; set; }


    }
}
