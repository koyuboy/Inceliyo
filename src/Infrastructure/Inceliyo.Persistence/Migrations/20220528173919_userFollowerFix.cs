using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Inceliyo.Persistence.Migrations
{
    public partial class userFollowerFix : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UserFollowers_Users_UserId",
                table: "UserFollowers");

            migrationBuilder.DropIndex(
                name: "IX_UserFollowers_UserId",
                table: "UserFollowers");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "UserFollowers");

            migrationBuilder.CreateIndex(
                name: "IX_UserFollowers_SourceId",
                table: "UserFollowers",
                column: "SourceId");

            migrationBuilder.CreateIndex(
                name: "IX_UserFollowers_TargetId",
                table: "UserFollowers",
                column: "TargetId");

            migrationBuilder.AddForeignKey(
                name: "FK_UserFollowers_Users_SourceId",
                table: "UserFollowers",
                column: "SourceId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UserFollowers_Users_TargetId",
                table: "UserFollowers",
                column: "TargetId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UserFollowers_Users_SourceId",
                table: "UserFollowers");

            migrationBuilder.DropForeignKey(
                name: "FK_UserFollowers_Users_TargetId",
                table: "UserFollowers");

            migrationBuilder.DropIndex(
                name: "IX_UserFollowers_SourceId",
                table: "UserFollowers");

            migrationBuilder.DropIndex(
                name: "IX_UserFollowers_TargetId",
                table: "UserFollowers");

            migrationBuilder.AddColumn<Guid>(
                name: "UserId",
                table: "UserFollowers",
                type: "TEXT",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_UserFollowers_UserId",
                table: "UserFollowers",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_UserFollowers_Users_UserId",
                table: "UserFollowers",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
