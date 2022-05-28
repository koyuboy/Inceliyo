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
    internal class CommentActionConfiguration : IEntityTypeConfiguration<CommentAction>
    {
        public void Configure(EntityTypeBuilder<CommentAction> builder)
        {
            builder.HasOne<User>().WithMany().HasForeignKey(c => c.ActorId);

        }
    }
}
