using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccessLayer.Migrations
{
    public partial class mig_todolist_add : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UserMessages_Users_UserId",
                table: "UserMessages");

            migrationBuilder.DropPrimaryKey(
                name: "PK_UserMessages",
                table: "UserMessages");

            migrationBuilder.RenameTable(
                name: "UserMessages",
                newName: "UserMessage");

            migrationBuilder.RenameIndex(
                name: "IX_UserMessages_UserId",
                table: "UserMessage",
                newName: "IX_UserMessage_UserId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_UserMessage",
                table: "UserMessage",
                column: "MessageId");

            migrationBuilder.AddForeignKey(
                name: "FK_UserMessage_Users_UserId",
                table: "UserMessage",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UserMessage_Users_UserId",
                table: "UserMessage");

            migrationBuilder.DropPrimaryKey(
                name: "PK_UserMessage",
                table: "UserMessage");

            migrationBuilder.RenameTable(
                name: "UserMessage",
                newName: "UserMessages");

            migrationBuilder.RenameIndex(
                name: "IX_UserMessage_UserId",
                table: "UserMessages",
                newName: "IX_UserMessages_UserId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_UserMessages",
                table: "UserMessages",
                column: "MessageId");

            migrationBuilder.AddForeignKey(
                name: "FK_UserMessages_Users_UserId",
                table: "UserMessages",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
