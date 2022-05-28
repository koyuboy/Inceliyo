using Microsoft.EntityFrameworkCore.Migrations;

namespace Inceliyo.Persistence.Migrations
{
    public partial class commentActionFix : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_CommentActions_ActorId",
                table: "CommentActions",
                column: "ActorId");

            migrationBuilder.AddForeignKey(
                name: "FK_CommentActions_Users_ActorId",
                table: "CommentActions",
                column: "ActorId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CommentActions_Users_ActorId",
                table: "CommentActions");

            migrationBuilder.DropIndex(
                name: "IX_CommentActions_ActorId",
                table: "CommentActions");
        }
    }
}
