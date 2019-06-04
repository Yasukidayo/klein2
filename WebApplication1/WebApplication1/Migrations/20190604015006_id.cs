using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApplication1.Migrations
{
    public partial class id : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ThanksCards_Users_FromId",
                table: "ThanksCards");

            migrationBuilder.DropForeignKey(
                name: "FK_ThanksCards_Users_ToId",
                table: "ThanksCards");

            migrationBuilder.DropForeignKey(
                name: "FK_Users_Departments_DepartmentId",
                table: "Users");

            migrationBuilder.DropForeignKey(
                name: "FK_Users_Roots_RootId",
                table: "Users");

            migrationBuilder.DropIndex(
                name: "IX_Users_RootId",
                table: "Users");

            migrationBuilder.AlterColumn<long>(
                name: "RootId",
                table: "Users",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<long>(
                name: "DepartmentId",
                table: "Users",
                nullable: false,
                oldClrType: typeof(long),
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "RootId1",
                table: "Users",
                nullable: true);

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

            migrationBuilder.CreateIndex(
                name: "IX_Users_RootId1",
                table: "Users",
                column: "RootId1");

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

            migrationBuilder.AddForeignKey(
                name: "FK_Users_Departments_DepartmentId",
                table: "Users",
                column: "DepartmentId",
                principalTable: "Departments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Users_Roots_RootId1",
                table: "Users",
                column: "RootId1",
                principalTable: "Roots",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ThanksCards_Users_FromId",
                table: "ThanksCards");

            migrationBuilder.DropForeignKey(
                name: "FK_ThanksCards_Users_ToId",
                table: "ThanksCards");

            migrationBuilder.DropForeignKey(
                name: "FK_Users_Departments_DepartmentId",
                table: "Users");

            migrationBuilder.DropForeignKey(
                name: "FK_Users_Roots_RootId1",
                table: "Users");

            migrationBuilder.DropIndex(
                name: "IX_Users_RootId1",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "RootId1",
                table: "Users");

            migrationBuilder.AlterColumn<int>(
                name: "RootId",
                table: "Users",
                nullable: true,
                oldClrType: typeof(long));

            migrationBuilder.AlterColumn<long>(
                name: "DepartmentId",
                table: "Users",
                nullable: true,
                oldClrType: typeof(long));

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

            migrationBuilder.CreateIndex(
                name: "IX_Users_RootId",
                table: "Users",
                column: "RootId");

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

            migrationBuilder.AddForeignKey(
                name: "FK_Users_Departments_DepartmentId",
                table: "Users",
                column: "DepartmentId",
                principalTable: "Departments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Users_Roots_RootId",
                table: "Users",
                column: "RootId",
                principalTable: "Roots",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
