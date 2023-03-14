using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace QrCodeGenerator.DAL.Migrations
{
    public partial class InitialDBTablesCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tasks_Users_UserId",
                table: "Tasks");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Tasks",
                table: "Tasks");

            migrationBuilder.RenameTable(
                name: "Tasks",
                newName: "QrCodes");

            migrationBuilder.RenameIndex(
                name: "IX_Tasks_UserId",
                table: "QrCodes",
                newName: "IX_QrCodes_UserId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_QrCodes",
                table: "QrCodes",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_QrCodes_Users_UserId",
                table: "QrCodes",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_QrCodes_Users_UserId",
                table: "QrCodes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_QrCodes",
                table: "QrCodes");

            migrationBuilder.RenameTable(
                name: "QrCodes",
                newName: "Tasks");

            migrationBuilder.RenameIndex(
                name: "IX_QrCodes_UserId",
                table: "Tasks",
                newName: "IX_Tasks_UserId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Tasks",
                table: "Tasks",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Tasks_Users_UserId",
                table: "Tasks",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
