using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace WebApplication1.Migrations
{
    public partial class idp : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Users_Roots_RootId1",
                table: "Users");

            migrationBuilder.DropIndex(
                name: "IX_Users_RootId1",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "RootId1",
                table: "Users");

            migrationBuilder.AlterColumn<long>(
                name: "Id",
                table: "Roots",
                nullable: false,
                oldClrType: typeof(int))
                .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn)
                .OldAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn);

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Users_Roots_RootId",
                table: "Users");

            migrationBuilder.DropIndex(
                name: "IX_Users_RootId",
                table: "Users");

            migrationBuilder.AddColumn<int>(
                name: "RootId1",
                table: "Users",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "Roots",
                nullable: false,
                oldClrType: typeof(long))
                .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn)
                .OldAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn);

            migrationBuilder.CreateIndex(
                name: "IX_Users_RootId1",
                table: "Users",
                column: "RootId1");

            migrationBuilder.AddForeignKey(
                name: "FK_Users_Roots_RootId1",
                table: "Users",
                column: "RootId1",
                principalTable: "Roots",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
