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
    internal class ReviewMarketLinkConfiguration : IEntityTypeConfiguration<ReviewMarketLink>
    {
        public void Configure(EntityTypeBuilder<ReviewMarketLink> builder)
        {
            builder.Property(rml => rml.Link).IsRequired();
        }
    }
}
