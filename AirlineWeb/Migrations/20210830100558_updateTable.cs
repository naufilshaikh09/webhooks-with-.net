using Microsoft.EntityFrameworkCore.Migrations;

namespace AirlineWeb.Migrations
{
    public partial class updateTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_webhookSubscription",
                table: "webhookSubscription");

            migrationBuilder.RenameTable(
                name: "webhookSubscription",
                newName: "webhookSubscriptions");

            migrationBuilder.AddPrimaryKey(
                name: "PK_webhookSubscriptions",
                table: "webhookSubscriptions",
                column: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_webhookSubscriptions",
                table: "webhookSubscriptions");

            migrationBuilder.RenameTable(
                name: "webhookSubscriptions",
                newName: "webhookSubscription");

            migrationBuilder.AddPrimaryKey(
                name: "PK_webhookSubscription",
                table: "webhookSubscription",
                column: "Id");
        }
    }
}
