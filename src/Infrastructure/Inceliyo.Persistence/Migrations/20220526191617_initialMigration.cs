using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Inceliyo.Persistence.Migrations
{
    public partial class initialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    Name = table.Column<string>(type: "TEXT", nullable: true),
                    ParentId = table.Column<Guid>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Market",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    Name = table.Column<string>(type: "TEXT", nullable: true),
                    IconPath = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Market", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SocialMedia",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    Name = table.Column<string>(type: "TEXT", nullable: true),
                    IconPath = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SocialMedia", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    UserName = table.Column<string>(type: "TEXT", nullable: true),
                    FullName = table.Column<string>(type: "TEXT", nullable: true),
                    Email = table.Column<string>(type: "TEXT", nullable: true),
                    IsApproved = table.Column<bool>(type: "INTEGER", nullable: false),
                    PasswordHash = table.Column<string>(type: "TEXT", nullable: true),
                    Salt = table.Column<string>(type: "TEXT", nullable: true),
                    RegisteredAt = table.Column<DateTime>(type: "TEXT", nullable: false),
                    LastLogin = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Review",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    UserId = table.Column<Guid>(type: "TEXT", nullable: false),
                    CategoryId = table.Column<Guid>(type: "TEXT", nullable: false),
                    Title = table.Column<string>(type: "TEXT", nullable: true),
                    CoverImagePath = table.Column<string>(type: "TEXT", nullable: true),
                    Content = table.Column<string>(type: "TEXT", nullable: true),
                    IsDraft = table.Column<bool>(type: "INTEGER", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "TEXT", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "TEXT", nullable: false),
                    IsDeleted = table.Column<bool>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Review", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Review_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Review_User_UserId",
                        column: x => x.UserId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserFollower",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    SourceId = table.Column<Guid>(type: "TEXT", nullable: false),
                    TargetId = table.Column<Guid>(type: "TEXT", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "TEXT", nullable: false),
                    UserId = table.Column<Guid>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserFollower", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserFollower_User_UserId",
                        column: x => x.UserId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "UserProfile",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    UserId = table.Column<Guid>(type: "TEXT", nullable: false),
                    ProfileImagePath = table.Column<string>(type: "TEXT", nullable: true),
                    CoverImagePath = table.Column<string>(type: "TEXT", nullable: true),
                    Bio = table.Column<string>(type: "TEXT", nullable: true),
                    IsEmailNotification = table.Column<bool>(type: "INTEGER", nullable: false),
                    NotifiacationStateType = table.Column<byte>(type: "INTEGER", nullable: false),
                    WhoSendMessage = table.Column<byte>(type: "INTEGER", nullable: false),
                    WhoSendComment = table.Column<byte>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserProfile", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserProfile_User_UserId",
                        column: x => x.UserId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Comment",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    UserId = table.Column<Guid>(type: "TEXT", nullable: false),
                    ReviewId = table.Column<Guid>(type: "TEXT", nullable: false),
                    Content = table.Column<string>(type: "TEXT", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "TEXT", nullable: false),
                    IsDeleted = table.Column<bool>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Comment", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Comment_Review_ReviewId",
                        column: x => x.ReviewId,
                        principalTable: "Review",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Comment_User_UserId",
                        column: x => x.UserId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ReviewAction",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    ReviewId = table.Column<Guid>(type: "TEXT", nullable: false),
                    IsLike = table.Column<bool>(type: "INTEGER", nullable: false),
                    ActorId = table.Column<Guid>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ReviewAction", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ReviewAction_Review_ReviewId",
                        column: x => x.ReviewId,
                        principalTable: "Review",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ReviewMarketLink",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    ReviewId = table.Column<Guid>(type: "TEXT", nullable: false),
                    MarketId = table.Column<Guid>(type: "TEXT", nullable: false),
                    Link = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ReviewMarketLink", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ReviewMarketLink_Market_MarketId",
                        column: x => x.MarketId,
                        principalTable: "Market",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ReviewMarketLink_Review_ReviewId",
                        column: x => x.ReviewId,
                        principalTable: "Review",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ReviewMedia",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    MediaType = table.Column<byte>(type: "INTEGER", nullable: false),
                    ReviewId = table.Column<Guid>(type: "TEXT", nullable: false),
                    MediaLocation = table.Column<int>(type: "INTEGER", nullable: false),
                    Path = table.Column<string>(type: "TEXT", nullable: true),
                    UploadAt = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ReviewMedia", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ReviewMedia_Review_ReviewId",
                        column: x => x.ReviewId,
                        principalTable: "Review",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SavedReview",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    UserId = table.Column<Guid>(type: "TEXT", nullable: false),
                    ReviewId = table.Column<Guid>(type: "TEXT", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SavedReview", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SavedReview_Review_ReviewId",
                        column: x => x.ReviewId,
                        principalTable: "Review",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SavedReview_User_UserId",
                        column: x => x.UserId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SocialMediaLink",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    UserProfileId = table.Column<Guid>(type: "TEXT", nullable: false),
                    SocialMediaId = table.Column<Guid>(type: "TEXT", nullable: false),
                    Link = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SocialMediaLink", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SocialMediaLink_SocialMedia_SocialMediaId",
                        column: x => x.SocialMediaId,
                        principalTable: "SocialMedia",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SocialMediaLink_UserProfile_UserProfileId",
                        column: x => x.UserProfileId,
                        principalTable: "UserProfile",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CommentAction",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    CommentId = table.Column<Guid>(type: "TEXT", nullable: false),
                    IsLike = table.Column<bool>(type: "INTEGER", nullable: false),
                    ActorId = table.Column<Guid>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CommentAction", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CommentAction_Comment_CommentId",
                        column: x => x.CommentId,
                        principalTable: "Comment",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Comment_ReviewId",
                table: "Comment",
                column: "ReviewId");

            migrationBuilder.CreateIndex(
                name: "IX_Comment_UserId",
                table: "Comment",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_CommentAction_CommentId",
                table: "CommentAction",
                column: "CommentId");

            migrationBuilder.CreateIndex(
                name: "IX_Review_CategoryId",
                table: "Review",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Review_UserId",
                table: "Review",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_ReviewAction_ReviewId",
                table: "ReviewAction",
                column: "ReviewId");

            migrationBuilder.CreateIndex(
                name: "IX_ReviewMarketLink_MarketId",
                table: "ReviewMarketLink",
                column: "MarketId");

            migrationBuilder.CreateIndex(
                name: "IX_ReviewMarketLink_ReviewId",
                table: "ReviewMarketLink",
                column: "ReviewId");

            migrationBuilder.CreateIndex(
                name: "IX_ReviewMedia_ReviewId",
                table: "ReviewMedia",
                column: "ReviewId");

            migrationBuilder.CreateIndex(
                name: "IX_SavedReview_ReviewId",
                table: "SavedReview",
                column: "ReviewId");

            migrationBuilder.CreateIndex(
                name: "IX_SavedReview_UserId",
                table: "SavedReview",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_SocialMediaLink_SocialMediaId",
                table: "SocialMediaLink",
                column: "SocialMediaId");

            migrationBuilder.CreateIndex(
                name: "IX_SocialMediaLink_UserProfileId",
                table: "SocialMediaLink",
                column: "UserProfileId");

            migrationBuilder.CreateIndex(
                name: "IX_UserFollower_UserId",
                table: "UserFollower",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_UserProfile_UserId",
                table: "UserProfile",
                column: "UserId",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CommentAction");

            migrationBuilder.DropTable(
                name: "ReviewAction");

            migrationBuilder.DropTable(
                name: "ReviewMarketLink");

            migrationBuilder.DropTable(
                name: "ReviewMedia");

            migrationBuilder.DropTable(
                name: "SavedReview");

            migrationBuilder.DropTable(
                name: "SocialMediaLink");

            migrationBuilder.DropTable(
                name: "UserFollower");

            migrationBuilder.DropTable(
                name: "Comment");

            migrationBuilder.DropTable(
                name: "Market");

            migrationBuilder.DropTable(
                name: "SocialMedia");

            migrationBuilder.DropTable(
                name: "UserProfile");

            migrationBuilder.DropTable(
                name: "Review");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "User");
        }
    }
}
