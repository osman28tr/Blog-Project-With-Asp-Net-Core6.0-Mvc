using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccessLayer.Migrations
{
    public partial class mig_relation_user_message : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UserMessages_UserMessages_UserMessageMessageId",
                table: "UserMessages");

            migrationBuilder.DropIndex(
                name: "IX_UserMessages_UserMessageMessageId",
                table: "UserMessages");

            migrationBuilder.DropColumn(
                name: "UserMessageMessageId",
                table: "UserMessages");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "UserMessageMessageId",
                table: "UserMessages",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_UserMessages_UserMessageMessageId",
                table: "UserMessages",
                column: "UserMessageMessageId");

            migrationBuilder.AddForeignKey(
                name: "FK_UserMessages_UserMessages_UserMessageMessageId",
                table: "UserMessages",
                column: "UserMessageMessageId",
                principalTable: "UserMessages",
                principalColumn: "MessageId");
        }
    }
}
