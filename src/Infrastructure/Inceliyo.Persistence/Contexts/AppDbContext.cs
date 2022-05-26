using Inceliyo.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Inceliyo.Persistence.Contexts
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public AppDbContext()
        {
        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<CommentAction> CommentActions { get; set; }
        public DbSet<Market> Markets { get; set; }
        public DbSet<Review> Reviews { get; set; }
        public DbSet<ReviewAction> ReviewActions { get; set; }
        public DbSet<ReviewMarketLink> ReviewMarketLinks { get; set; }
        public DbSet<ReviewMedia> ReviewMedias { get; set; }
        public DbSet<SavedReview> SavedReviews { get; set; }
        public DbSet<SocialMedia> SocialMedias { get; set; }
        public DbSet<SocialMediaLink> SocialMediaLinks { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<UserFollower> UserFollowers { get; set; }
        public DbSet<UserProfile> UserProfiles { get; set; }



protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlite("Data Source=Inceliyo.db");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly()); //apply configurations which implemented  from IEntityTypeConfiguration interface.
            
            base.OnModelCreating(modelBuilder);
        }
    }
}
