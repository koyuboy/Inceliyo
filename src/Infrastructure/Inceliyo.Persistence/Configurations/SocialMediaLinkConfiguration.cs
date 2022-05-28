using Inceliyo.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inceliyo.Persistence.Configurations
{
    internal class SocialMediaLinkConfiguration : IEntityTypeConfiguration<SocialMediaLink>
    {
        public void Configure(EntityTypeBuilder<SocialMediaLink> builder)
        {
            builder.Property(sml => sml.Link).IsRequired();
        }
    }
}
