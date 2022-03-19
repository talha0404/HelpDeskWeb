using Microsoft.EntityFrameworkCore.Migrations;

namespace HelpDeskWeb.EFCore.Migrations
{
    public partial class _190320221030 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Statuss",
                table: "Statuss");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Customers",
                table: "Customers");

            migrationBuilder.RenameTable(
                name: "Statuss",
                newName: "Statuses");

            migrationBuilder.RenameTable(
                name: "Customers",
                newName: "AutoNumbers");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Statuses",
                table: "Statuses",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AutoNumbers",
                table: "AutoNumbers",
                column: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Statuses",
                table: "Statuses");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AutoNumbers",
                table: "AutoNumbers");

            migrationBuilder.RenameTable(
                name: "Statuses",
                newName: "Statuss");

            migrationBuilder.RenameTable(
                name: "AutoNumbers",
                newName: "Customers");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Statuss",
                table: "Statuss",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Customers",
                table: "Customers",
                column: "Id");
        }
    }
}
