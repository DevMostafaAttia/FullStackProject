using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Client.Data.Migrations
{
    public partial class _123 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Branches",
                columns: table => new
                {
                    BranchId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    BranchName = table.Column<string>(nullable: true),
                    Location = table.Column<string>(nullable: true),
                    ManagerName = table.Column<string>(nullable: true),
                    Budget = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Branches", x => x.BranchId);
                });

            migrationBuilder.InsertData(
                table: "Branches",
                columns: new[] { "BranchId", "BranchName", "Budget", "Location", "ManagerName" },
                values: new object[,]
                {
                    { 1, "New Cairo", 120000000.0, "Elnarges 4, Villa 212", "Ali" },
                    { 2, "Naser City", 90000.0, "Elnozha st, 1 Suadi buildings", "Haitham" },
                    { 3, "Zayed", 6000000.0, "District 12", "Ramy" },
                    { 4, "October", 30000000.0, "Elnarges 4, Villa 212", "Samy" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Branches");
        }
    }
}
