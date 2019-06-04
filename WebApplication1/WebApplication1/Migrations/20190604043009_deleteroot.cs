using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApplication1.Migrations
{
    public partial class deleteroot : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Users_Roots_RootId",
                table: "Users");

            migrationBuilder.DropIndex(
                name: "IX_Users_RootId",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "RootId",
                table: "Users");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<long>(
                name: "RootId",
                table: "Users",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.CreateIndex(
                name: "IX_Users_RootId",
                table: "Users",
                column: "RootId");

            migrationBuilder.AddForeignKey(
                name: "FK_Users_Roots_RootId",
                table: "Users",
                column: "RootId",
                principalTable: "Roots",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
