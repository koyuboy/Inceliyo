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
    internal class ReviewMediaConfiguration : IEntityTypeConfiguration<ReviewMedia>
    {
        public void Configure(EntityTypeBuilder<ReviewMedia> builder)
        {
            builder.Property(rm => rm.Path).IsRequired();
        }
    }
}
