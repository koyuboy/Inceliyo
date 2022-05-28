using Inceliyo.Domain.Entities;
using Inceliyo.Domain.Enums;
using Inceliyo.Persistence.Contexts;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AppDbContext context = new AppDbContext();

            TestCategoryAsync(context);
            TestUserAsync(context);
            TestReview(context);
            TestReviewMediaAsync(context);

            Console.ReadLine();
        }

        private static async Task TestReview(AppDbContext context)
        {
            Console.WriteLine("++++++++++Review++++++++++");
            
            //await context.Reviews.AddAsync(new Review()
            //{
            //    CategoryId = Guid.Parse("4B59D4A0-CAD5-4CC5-BF5F-39BBD2341D2F"),
            //    Content = "This is a test review",
            //    CreatedAt = DateTime.Now,
            //    IsDeleted = false,
            //    IsDraft = false,
            //    Title = "Test Review",
            //    UpdatedAt = DateTime.Now,
            //    UserId = Guid.Parse("37821BC5-980D-402B-9DC2-83C51360982C")
            //});

            //await context.SaveChangesAsync();

            var reviews = await context.Reviews.ToListAsync();

            foreach (var item in reviews)
            {
                Console.WriteLine(item.CategoryId);
                Console.WriteLine(item.Content);
                Console.WriteLine(item.CreatedAt);
                Console.WriteLine(item.IsDeleted);
                Console.WriteLine(item.IsDraft);
                Console.WriteLine(item.Title);
                Console.WriteLine(item.UpdatedAt);
                Console.WriteLine(item.UserId);

                Console.WriteLine("=====================================");

            }
        }

        private static async Task TestReviewMediaAsync(AppDbContext context)
        {
            Console.WriteLine("++++++++++ReviewMedia++++++++++");
            
            //await context.ReviewMedias.AddAsync(new ReviewMedia()
            //{
            //    MediaLocation = 1,
            //    MediaType = MediaType.image,
            //    Path = "path",
            //    ReviewId = Guid.Parse("C16DF633-B3F9-4270-9FF5-B4A9125CEF2D"),
            //    UploadAt = DateTime.Now
            //});

            //await context.SaveChangesAsync();

            var reviewMedias = await context.ReviewMedias.ToListAsync();

            foreach (var item in reviewMedias)
            {
                Console.WriteLine(item.MediaLocation);
                Console.WriteLine(item.MediaType);
                Console.WriteLine(item.Path);
                Console.WriteLine(item.ReviewId);
                Console.WriteLine(item.UploadAt);
                Console.WriteLine("=====================================");

            }
        }

        private static async Task TestUserAsync(AppDbContext context)
        {
            Console.WriteLine("++++++++++User++++++++++");
            
            //await context.Users.AddAsync(new User()
            //{
            //    Email = "ahmet@gmail.com",
            //    FullName = "Ahmet Demir",
            //    IsApproved = true,
            //    LastLogin = DateTime.Now,
            //    PasswordHash = "hash",
            //    Salt = "salt",
            //    RegisteredAt = DateTime.Now,
            //    UserName = "ahmet"
            //});

            //await context.SaveChangesAsync();

            var users = await context.Users.ToListAsync();

            foreach (var item in users)
            {
                Console.WriteLine(item.Email);
                Console.WriteLine(item.FullName);
                Console.WriteLine(item.IsApproved);
                Console.WriteLine(item.LastLogin);
                Console.WriteLine(item.PasswordHash);
                Console.WriteLine(item.Salt);
                Console.WriteLine(item.RegisteredAt);
                Console.WriteLine(item.UserName);

                Console.WriteLine("=====================================");

            }
        }

        private static async Task TestCategoryAsync(AppDbContext context)
        {
            Console.WriteLine("++++++++++Category++++++++++");
            
            //await context.Categories.AddAsync(new Category()
            //{
            //    Name = "Category " + DateTime.Now.ToString("dd/HH:mm"),
            //    ParentId = Guid.NewGuid()
            //});

            //await context.SaveChangesAsync();

            var categories = await context.Categories.ToListAsync();

            foreach (var category in categories)
            {
                Console.WriteLine(category.Id);
                Console.WriteLine(category.Name);
                Console.WriteLine(category.ParentId);
            }
        }
    }
}
