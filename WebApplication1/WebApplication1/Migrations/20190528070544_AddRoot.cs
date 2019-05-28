using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace WebApplication1.Migrations
{
    public partial class AddRoot : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Courses");

            migrationBuilder.RenameColumn(
                name: "部課CD",
                table: "Departments",
                newName: "CD");

            migrationBuilder.AddColumn<long>(
                name: "CD",
                table: "Users",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddColumn<long>(
                name: "Date",
                table: "ThanksCards",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddColumn<bool>(
                name: "Flag1",
                table: "ThanksCards",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Flag2",
                table: "ThanksCards",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<long>(
                name: "ThanksCardCD",
                table: "ThanksCards",
                nullable: false,
                defaultValue: 0L);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CD",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "Date",
                table: "ThanksCards");

            migrationBuilder.DropColumn(
                name: "Flag1",
                table: "ThanksCards");

            migrationBuilder.DropColumn(
                name: "Flag2",
                table: "ThanksCards");

            migrationBuilder.DropColumn(
                name: "ThanksCardCD",
                table: "ThanksCards");

            migrationBuilder.RenameColumn(
                name: "CD",
                table: "Departments",
                newName: "部課CD");

            migrationBuilder.CreateTable(
                name: "Courses",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    Name = table.Column<string>(nullable: true),
                    Type = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Courses", x => x.Id);
                });
        }
    }
}
