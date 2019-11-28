using Microsoft.EntityFrameworkCore.Migrations;

namespace Client.Data.Migrations
{
    public partial class _112 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Client",
                columns: new[] { "ClientId", "Address", "ClientEmail", "ClientName", "Mobile", "WebSite" },
                values: new object[] { 1, "5 - 17 paradaise - October Gardens - Giza", "mattia@eggate.com", "Mostafa Attia", "+201008346362", "N.A" });

            migrationBuilder.InsertData(
                table: "Client",
                columns: new[] { "ClientId", "Address", "ClientEmail", "ClientName", "Mobile", "WebSite" },
                values: new object[] { 2, "Maadi", "mnagy@eggate.com", "Mahmoud Nagy", "+201119849089", "N.A" });

            migrationBuilder.InsertData(
                table: "Client",
                columns: new[] { "ClientId", "Address", "ClientEmail", "ClientName", "Mobile", "WebSite" },
                values: new object[] { 3, "6th of October City", "aelkady@eggate.com", "Ahmed Elkady", "+201017413234", "N.A" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Client",
                keyColumn: "ClientId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Client",
                keyColumn: "ClientId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Client",
                keyColumn: "ClientId",
                keyValue: 3);
        }
    }
}
