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
        //public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        //{
        //}


        public string DbPath { get;}
        public AppDbContext()
        {
            string startupPath = Environment.CurrentDirectory;
            var listStrLineElements = startupPath.Split('\\').ToList();
            string path = "";
            foreach (var item in listStrLineElements)
            {
                path = path + item + "/";
                if (item == "src")
                {
                    break;
                }
            }
            path = path + "Infrastructure/Inceliyo.Persistence/DB/InceliyoSQLite.db";
            DbPath = path;

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
            optionsBuilder.UseSqlite($"Data Source={DbPath}");
            //if (!optionsBuilder.IsConfigured)
            //{
            //    //optionsBuilder.UseSqlite($"Data Source=Inceliyo.db");
            //    optionsBuilder.UseSqlite($"Data Source=C:/Users/HUZEYFE/Desktop/Inceliyo/src/Infrastructure/Inceliyo.Persistence/InceliyoSQLite.db");

            //    //optionsBuilder.UseSqlite("DataSource=./src/Infrastructure/Inceliyo.Persistence/DB/Inceliyo.db");
            //}
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly()); //apply configurations which implemented  from IEntityTypeConfiguration interface.
            
            base.OnModelCreating(modelBuilder);
        }
    }
}
