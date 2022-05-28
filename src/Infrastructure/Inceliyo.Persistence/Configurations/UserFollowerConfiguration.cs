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
    internal class UserFollowerConfiguration : IEntityTypeConfiguration<UserFollower>
    {
        public void Configure(EntityTypeBuilder<UserFollower> builder)
        {
            builder.HasOne<User>().WithMany().HasForeignKey(uf => uf.SourceId);
            builder.HasOne<User>().WithMany().HasForeignKey(uf => uf.TargetId);

            //builder.HasOne(uf => uf.User).WithMany(u => u.UserFollowers).HasForeignKey(uf => uf.SourceId);
            //builder.HasOne(uf => uf.User).WithMany(u => u.UserFollowers).HasForeignKey(uf => uf.TargetId);
        }
    }
}
