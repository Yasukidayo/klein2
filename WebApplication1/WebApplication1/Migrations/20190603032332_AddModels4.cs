using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApplication1.Migrations
{
    public partial class AddModels4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ThanksCards_Users_FromId",
                table: "ThanksCards");

            migrationBuilder.DropForeignKey(
                name: "FK_ThanksCards_Users_ToId",
                table: "ThanksCards");

            migrationBuilder.AlterColumn<long>(
                name: "ToId",
                table: "ThanksCards",
                nullable: false,
                oldClrType: typeof(long),
                oldNullable: true);

            migrationBuilder.AlterColumn<long>(
                name: "FromId",
                table: "ThanksCards",
                nullable: false,
                oldClrType: typeof(long),
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_ThanksCards_Users_FromId",
                table: "ThanksCards",
                column: "FromId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ThanksCards_Users_ToId",
                table: "ThanksCards",
                column: "ToId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ThanksCards_Users_FromId",
                table: "ThanksCards");

            migrationBuilder.DropForeignKey(
                name: "FK_ThanksCards_Users_ToId",
                table: "ThanksCards");

            migrationBuilder.AlterColumn<long>(
                name: "ToId",
                table: "ThanksCards",
                nullable: true,
                oldClrType: typeof(long));

            migrationBuilder.AlterColumn<long>(
                name: "FromId",
                table: "ThanksCards",
                nullable: true,
                oldClrType: typeof(long));

            migrationBuilder.AddForeignKey(
                name: "FK_ThanksCards_Users_FromId",
                table: "ThanksCards",
                column: "FromId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ThanksCards_Users_ToId",
                table: "ThanksCards",
                column: "ToId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
