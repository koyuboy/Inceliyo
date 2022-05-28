﻿// <auto-generated />
using System;
using Inceliyo.Persistence.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Inceliyo.Persistence.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20220528173919_userFollowerFix")]
    partial class userFollowerFix
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.17");

            modelBuilder.Entity("Inceliyo.Domain.Entities.Category", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.Property<Guid>("ParentId")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("Inceliyo.Domain.Entities.Comment", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<string>("Content")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("TEXT");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("INTEGER");

                    b.Property<Guid>("ReviewId")
                        .HasColumnType("TEXT");

                    b.Property<Guid>("UserId")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("ReviewId");

                    b.HasIndex("UserId");

                    b.ToTable("Comments");
                });

            modelBuilder.Entity("Inceliyo.Domain.Entities.CommentAction", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<Guid>("ActorId")
                        .HasColumnType("TEXT");

                    b.Property<Guid>("CommentId")
                        .HasColumnType("TEXT");

                    b.Property<bool>("IsLike")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("CommentId");

                    b.ToTable("CommentActions");
                });

            modelBuilder.Entity("Inceliyo.Domain.Entities.Market", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<string>("IconPath")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Markets");
                });

            modelBuilder.Entity("Inceliyo.Domain.Entities.Review", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<Guid>("CategoryId")
                        .HasColumnType("TEXT");

                    b.Property<string>("Content")
                        .HasColumnType("TEXT");

                    b.Property<string>("CoverImagePath")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("TEXT");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("IsDraft")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Title")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("TEXT");

                    b.Property<Guid>("UserId")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.HasIndex("UserId");

                    b.ToTable("Reviews");
                });

            modelBuilder.Entity("Inceliyo.Domain.Entities.ReviewAction", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<Guid>("ActorId")
                        .HasColumnType("TEXT");

                    b.Property<bool>("IsLike")
                        .HasColumnType("INTEGER");

                    b.Property<Guid>("ReviewId")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("ReviewId");

                    b.ToTable("ReviewActions");
                });

            modelBuilder.Entity("Inceliyo.Domain.Entities.ReviewMarketLink", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<string>("Link")
                        .HasColumnType("TEXT");

                    b.Property<Guid>("MarketId")
                        .HasColumnType("TEXT");

                    b.Property<Guid>("ReviewId")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("MarketId");

                    b.HasIndex("ReviewId");

                    b.ToTable("ReviewMarketLinks");
                });

            modelBuilder.Entity("Inceliyo.Domain.Entities.ReviewMedia", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<int>("MediaLocation")
                        .HasColumnType("INTEGER");

                    b.Property<byte>("MediaType")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Path")
                        .HasColumnType("TEXT");

                    b.Property<Guid>("ReviewId")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("UploadAt")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("ReviewId");

                    b.ToTable("ReviewMedias");
                });

            modelBuilder.Entity("Inceliyo.Domain.Entities.SavedReview", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("TEXT");

                    b.Property<Guid>("ReviewId")
                        .HasColumnType("TEXT");

                    b.Property<Guid>("UserId")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("ReviewId");

                    b.HasIndex("UserId");

                    b.ToTable("SavedReviews");
                });

            modelBuilder.Entity("Inceliyo.Domain.Entities.SocialMedia", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<string>("IconPath")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("SocialMedias");
                });

            modelBuilder.Entity("Inceliyo.Domain.Entities.SocialMediaLink", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<string>("Link")
                        .HasColumnType("TEXT");

                    b.Property<Guid>("SocialMediaId")
                        .HasColumnType("TEXT");

                    b.Property<Guid>("UserProfileId")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("SocialMediaId");

                    b.HasIndex("UserProfileId");

                    b.ToTable("SocialMediaLinks");
                });

            modelBuilder.Entity("Inceliyo.Domain.Entities.User", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<string>("Email")
                        .HasColumnType("TEXT");

                    b.Property<string>("FullName")
                        .HasColumnType("TEXT");

                    b.Property<bool>("IsApproved")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("LastLogin")
                        .HasColumnType("TEXT");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("RegisteredAt")
                        .HasColumnType("TEXT");

                    b.Property<string>("Salt")
                        .HasColumnType("TEXT");

                    b.Property<string>("UserName")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("Inceliyo.Domain.Entities.UserFollower", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("TEXT");

                    b.Property<Guid>("SourceId")
                        .HasColumnType("TEXT");

                    b.Property<Guid>("TargetId")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("SourceId");

                    b.HasIndex("TargetId");

                    b.ToTable("UserFollowers");
                });

            modelBuilder.Entity("Inceliyo.Domain.Entities.UserProfile", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<string>("Bio")
                        .HasColumnType("TEXT");

                    b.Property<string>("CoverImagePath")
                        .HasColumnType("TEXT");

                    b.Property<bool>("IsEmailNotification")
                        .HasColumnType("INTEGER");

                    b.Property<byte>("NotifiacationStateType")
                        .HasColumnType("INTEGER");

                    b.Property<string>("ProfileImagePath")
                        .HasColumnType("TEXT");

                    b.Property<Guid>("UserId")
                        .HasColumnType("TEXT");

                    b.Property<byte>("WhoSendComment")
                        .HasColumnType("INTEGER");

                    b.Property<byte>("WhoSendMessage")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("UserId")
                        .IsUnique();

                    b.ToTable("UserProfiles");
                });

            modelBuilder.Entity("Inceliyo.Domain.Entities.Comment", b =>
                {
                    b.HasOne("Inceliyo.Domain.Entities.Review", "Review")
                        .WithMany("Comments")
                        .HasForeignKey("ReviewId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Inceliyo.Domain.Entities.User", "User")
                        .WithMany("Comments")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Review");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Inceliyo.Domain.Entities.CommentAction", b =>
                {
                    b.HasOne("Inceliyo.Domain.Entities.Comment", "Comment")
                        .WithMany("CommentActions")
                        .HasForeignKey("CommentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Comment");
                });

            modelBuilder.Entity("Inceliyo.Domain.Entities.Review", b =>
                {
                    b.HasOne("Inceliyo.Domain.Entities.Category", "Category")
                        .WithMany("Reviews")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Inceliyo.Domain.Entities.User", "User")
                        .WithMany("Reviews")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Inceliyo.Domain.Entities.ReviewAction", b =>
                {
                    b.HasOne("Inceliyo.Domain.Entities.Review", "Review")
                        .WithMany("ReviewActions")
                        .HasForeignKey("ReviewId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Review");
                });

            modelBuilder.Entity("Inceliyo.Domain.Entities.ReviewMarketLink", b =>
                {
                    b.HasOne("Inceliyo.Domain.Entities.Market", "Market")
                        .WithMany("ReviewMarketLinks")
                        .HasForeignKey("MarketId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Inceliyo.Domain.Entities.Review", "Review")
                        .WithMany("ReviewMarketLinks")
                        .HasForeignKey("ReviewId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Market");

                    b.Navigation("Review");
                });

            modelBuilder.Entity("Inceliyo.Domain.Entities.ReviewMedia", b =>
                {
                    b.HasOne("Inceliyo.Domain.Entities.Review", "Review")
                        .WithMany("ReviewMedias")
                        .HasForeignKey("ReviewId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Review");
                });

            modelBuilder.Entity("Inceliyo.Domain.Entities.SavedReview", b =>
                {
                    b.HasOne("Inceliyo.Domain.Entities.Review", "Review")
                        .WithMany("SavedReviews")
                        .HasForeignKey("ReviewId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Inceliyo.Domain.Entities.User", "User")
                        .WithMany("SavedReviews")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Review");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Inceliyo.Domain.Entities.SocialMediaLink", b =>
                {
                    b.HasOne("Inceliyo.Domain.Entities.SocialMedia", "SocialMedia")
                        .WithMany("SocialMediaLinks")
                        .HasForeignKey("SocialMediaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Inceliyo.Domain.Entities.UserProfile", "UserProfile")
                        .WithMany("SocialMediaLinks")
                        .HasForeignKey("UserProfileId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("SocialMedia");

                    b.Navigation("UserProfile");
                });

            modelBuilder.Entity("Inceliyo.Domain.Entities.UserFollower", b =>
                {
                    b.HasOne("Inceliyo.Domain.Entities.User", null)
                        .WithMany()
                        .HasForeignKey("SourceId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Inceliyo.Domain.Entities.User", null)
                        .WithMany()
                        .HasForeignKey("TargetId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Inceliyo.Domain.Entities.UserProfile", b =>
                {
                    b.HasOne("Inceliyo.Domain.Entities.User", "User")
                        .WithOne("UserProfile")
                        .HasForeignKey("Inceliyo.Domain.Entities.UserProfile", "UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("Inceliyo.Domain.Entities.Category", b =>
                {
                    b.Navigation("Reviews");
                });

            modelBuilder.Entity("Inceliyo.Domain.Entities.Comment", b =>
                {
                    b.Navigation("CommentActions");
                });

            modelBuilder.Entity("Inceliyo.Domain.Entities.Market", b =>
                {
                    b.Navigation("ReviewMarketLinks");
                });

            modelBuilder.Entity("Inceliyo.Domain.Entities.Review", b =>
                {
                    b.Navigation("Comments");

                    b.Navigation("ReviewActions");

                    b.Navigation("ReviewMarketLinks");

                    b.Navigation("ReviewMedias");

                    b.Navigation("SavedReviews");
                });

            modelBuilder.Entity("Inceliyo.Domain.Entities.SocialMedia", b =>
                {
                    b.Navigation("SocialMediaLinks");
                });

            modelBuilder.Entity("Inceliyo.Domain.Entities.User", b =>
                {
                    b.Navigation("Comments");

                    b.Navigation("Reviews");

                    b.Navigation("SavedReviews");

                    b.Navigation("UserProfile");
                });

            modelBuilder.Entity("Inceliyo.Domain.Entities.UserProfile", b =>
                {
                    b.Navigation("SocialMediaLinks");
                });
#pragma warning restore 612, 618
        }
    }
}
