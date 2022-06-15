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

            //TestCategoryAsync(context);
            //TestUserAsync(context);
            //TestUserProfileAsync(context);
            //TestReview(context);
            //TestReviewMediaAsync(context);
            //TestCommentAsync(context);
            //TestCommentActionAsync(context);
            //TestMarketAsync(context);
            //TestReviewMarketLinkAsync(context);
            //TestReviewActionAsync(context);
            //TestSocialMediaAsync(context);
            //TestSocialMediaLinkAsync(context);
            //TestSavedReviewAsync(context);
            //TestUserFollowerAsync(context);




            Console.ReadLine();
        }
        //xunit test

        private static async Task TestUserFollowerAsync(AppDbContext context, bool create = false)
        {
            Console.WriteLine("++++++++++User Follower++++++++++");

            if (create)
            {
                await context.UserFollowers.AddAsync(new UserFollower()
                {
                    CreatedAt = DateTime.Now,
                    SourceId = Guid.Parse("37821BC5-980D-402B-9DC2-83C51360982C"),
                    TargetId = Guid.Parse("37821BC5-980D-402B-9DC2-83C51360982C")

                });

                await context.SaveChangesAsync();
            }

            var userFollowers = await context.UserFollowers.ToListAsync();

            foreach (var item in userFollowers)
            {
                Console.WriteLine(item.CreatedAt);
                Console.WriteLine(item.SourceId);
                Console.WriteLine(item.TargetId);
            }
        }
        private static async Task TestSavedReviewAsync(AppDbContext context, bool create = false)
        {
            Console.WriteLine("++++++++++Saved Review++++++++++");

            if (create)
            {
                await context.SavedReviews.AddAsync(new SavedReview()
                {
                    CreatedAt = DateTime.Now,
                    ReviewId = Guid.Parse("C16DF633-B3F9-4270-9FF5-B4A9125CEF2D"),
                    UserId = Guid.Parse("37821BC5-980D-402B-9DC2-83C51360982C"),
                });

                await context.SaveChangesAsync();
            }

            var savedReviews = await context.SavedReviews.ToListAsync();

            foreach (var item in savedReviews)
            {
                Console.WriteLine(item.CreatedAt);
                Console.WriteLine(item.ReviewId);
                Console.WriteLine(item.UserId);
            }
        }
        private static async Task TestUserProfileAsync(AppDbContext context, bool create = false)
        {
            Console.WriteLine("++++++++++User Profile++++++++++");

            if (create)
            {
                await context.UserProfiles.AddAsync(new UserProfile()
                {
                    UserId = Guid.Parse("37821BC5-980D-402B-9DC2-83C51360982C"),
                    IsEmailNotification = true,
                    NotifiacationStateType = NotificationState.NewFollowers,
                    WhoSendComment = PrivacyState.Everybody,
                    WhoSendMessage = PrivacyState.OnlyFollowers,
                });

                await context.SaveChangesAsync();
            }

            var userProfiles = await context.UserProfiles.ToListAsync();

            foreach (var item in userProfiles)
            {
                Console.WriteLine(item.UserId);
                Console.WriteLine(item.IsEmailNotification);
                Console.WriteLine(item.NotifiacationStateType);
                Console.WriteLine(item.WhoSendComment);
                Console.WriteLine(item.WhoSendMessage);
            }
        }
        private static async Task TestSocialMediaLinkAsync(AppDbContext context, bool create = false)
        {
            Console.WriteLine("++++++++++Social Media Link++++++++++");

            if (create)
            {
                await context.SocialMediaLinks.AddAsync(new SocialMediaLink()
                {
                    Link = "markedName/userName",
                    SocialMediaId = Guid.Parse("1A539EAF-8F41-4364-B4EB-BA6BCFC65690"),
                    UserProfileId = Guid.Parse("5C803ACF-4A3F-474E-8BFA-98BC34A4B25D")
                });

                await context.SaveChangesAsync();
            }

            var socialMediaLinks = await context.SocialMediaLinks.ToListAsync();

            foreach (var item in socialMediaLinks)
            {
                Console.WriteLine(item.Link);
                Console.WriteLine(item.SocialMediaId);
                Console.WriteLine(item.UserProfileId);
            }
        }
        private static async Task TestSocialMediaAsync(AppDbContext context, bool create = false)
        {
            Console.WriteLine("++++++++++Social Media++++++++++");

            if (create)
            {
                await context.SocialMedias.AddAsync(new SocialMedia()
                {
                    IconPath = "image path",
                    Name = "Social media name",
                });

                await context.SaveChangesAsync();
            }

            var socialMedias = await context.SocialMedias.ToListAsync();

            foreach (var item in socialMedias)
            {
                Console.WriteLine(item.IconPath);
                Console.WriteLine(item.Name);
            }
        }
        private static async Task TestReviewActionAsync(AppDbContext context, bool create = false)
        {
            Console.WriteLine("++++++++++Review Action++++++++++");

            if (create)
            {
                await context.ReviewActions.AddAsync(new ReviewAction()
                {
                    ActorId = Guid.Parse("37821BC5-980D-402B-9DC2-83C51360982C"),
                    IsLike = true,
                    ReviewId = Guid.Parse("C16DF633-B3F9-4270-9FF5-B4A9125CEF2D")
                });

                await context.SaveChangesAsync();
            }

            var reviewActions = await context.ReviewActions.ToListAsync();

            foreach (var item in reviewActions)
            {
                Console.WriteLine(item.ActorId);
                Console.WriteLine(item.IsLike);
                Console.WriteLine(item.ReviewId);
            }
        }
        private static async Task TestReviewMarketLinkAsync(AppDbContext context, bool create = false)
        {
            Console.WriteLine("++++++++++Review Market Link++++++++++");

            if (create)
            {
                await context.ReviewMarketLinks.AddAsync(new ReviewMarketLink()
                {
                    Link = "https://www.google.com",
                    MarketId = Guid.Parse("C45E628D-20C7-446A-9DB0-097D9C1EBD91"),
                    ReviewId = Guid.Parse("C16DF633-B3F9-4270-9FF5-B4A9125CEF2D")
                }); 

                await context.SaveChangesAsync();
            }

            var reviewMarketLinks = await context.ReviewMarketLinks.ToListAsync();

            foreach (var item in reviewMarketLinks)
            {
                Console.WriteLine(item.Link);
                Console.WriteLine(item.MarketId);
                Console.WriteLine(item.ReviewId);
            }
        }
        private static async Task TestMarketAsync(AppDbContext context, bool create = false)
        {
            Console.WriteLine("++++++++++Market++++++++++");

            if (create)
            {
                await context.Markets.AddAsync(new Market()
                {
                    Name = "Market1",
                    IconPath = "IconPath1"
                });

                await context.SaveChangesAsync();
            }

            var markets = await context.Markets.ToListAsync();

            foreach (var item in markets)
            {
                Console.WriteLine(item.Name);
                Console.WriteLine(item.IconPath);
            }
        }
        private static async Task TestCommentActionAsync(AppDbContext context, bool create = false)
        {
            Console.WriteLine("++++++++++Comment Action++++++++++");

            if (create)
            {
                await context.CommentActions.AddAsync(new CommentAction()
                {
                    ActorId = Guid.Parse("37821BC5-980D-402B-9DC2-83C51360982C"),
                    CommentId = Guid.Parse("9C2C01C2-21E5-4F6F-8A17-E0999C9B7274"),
                    IsLike = true
                });

                await context.SaveChangesAsync();
            }

            var commentActions = await context.CommentActions.ToListAsync();

            foreach (var item in commentActions)
            {
                Console.WriteLine(item.ActorId);
                Console.WriteLine(item.CommentId);
                Console.WriteLine(item.IsLike);
            }
        }
        private static async Task TestCommentAsync(AppDbContext context, bool create = false)
        {
            Console.WriteLine("++++++++++Comment++++++++++");

            if (create)
            {
                await context.Comments.AddAsync(new Comment()
                {
                    Content = "Comment 1",
                    CreatedAt = DateTime.Now,
                    IsDeleted = false,
                    ReviewId = Guid.Parse("C16DF633-B3F9-4270-9FF5-B4A9125CEF2D"),
                    UserId = Guid.Parse("37821BC5-980D-402B-9DC2-83C51360982C")
                });

                await context.SaveChangesAsync();
            }

            var comments = await context.Comments.ToListAsync();

            foreach (var item in comments)
            {
                Console.WriteLine(item.Content);
                Console.WriteLine(item.CreatedAt);
                Console.WriteLine(item.IsDeleted);
                Console.WriteLine(item.ReviewId);
                Console.WriteLine(item.UserId);
            }
        }
        private static async Task TestReview(AppDbContext context, bool create = false)
        {
            Console.WriteLine("++++++++++Review++++++++++");

            if (create)
            {
                await context.Reviews.AddAsync(new Review()
                {
                    CategoryId = Guid.Parse("4B59D4A0-CAD5-4CC5-BF5F-39BBD2341D2F"),
                    Content = "This is a test review",
                    CreatedAt = DateTime.Now,
                    IsDeleted = false,
                    IsDraft = false,
                    Title = "Test Review",
                    UpdatedAt = DateTime.Now,
                    UserId = Guid.Parse("37821BC5-980D-402B-9DC2-83C51360982C")
                });

                await context.SaveChangesAsync();
            }

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

        private static async Task TestReviewMediaAsync(AppDbContext context, bool create = false)
        {
            Console.WriteLine("++++++++++ReviewMedia++++++++++");

            if (create)
            {
                await context.ReviewMedias.AddAsync(new ReviewMedia()
                {
                    MediaLocation = 1,
                    MediaType = MediaType.image,
                    Path = "path",
                    ReviewId = Guid.Parse("C16DF633-B3F9-4270-9FF5-B4A9125CEF2D"),
                    UploadAt = DateTime.Now
                });

                await context.SaveChangesAsync();
            }

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

        private static async Task TestUserAsync(AppDbContext context, bool create = false)
        {
            Console.WriteLine("++++++++++User++++++++++");

            if (create)
            {
                await context.Users.AddAsync(new User()
                {
                    Email = "ahmet@gmail.com",
                    FullName = "Ahmet Demir",
                    IsApproved = true,
                    LastLogin = DateTime.Now,
                    PasswordHash = "hash",
                    Salt = "salt",
                    RegisteredAt = DateTime.Now,
                    UserName = "ahmet"
                });

                await context.SaveChangesAsync();
            }

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

        private static async Task TestCategoryAsync(AppDbContext context, bool create = false)
        {
            Console.WriteLine("++++++++++Category++++++++++");

            if (create)
            {
                await context.Categories.AddAsync(new Category()
                {
                    Name = "Category " + DateTime.Now.ToString("dd/HH:mm"),
                    ParentId = Guid.NewGuid()
                });

                await context.SaveChangesAsync();
            }

            var categories = await context.Categories.ToListAsync();

            foreach (var item in categories)
            {
                Console.WriteLine(item.Id);
                Console.WriteLine(item.Name);
                Console.WriteLine(item.ParentId);
            }
        }
    }
}
