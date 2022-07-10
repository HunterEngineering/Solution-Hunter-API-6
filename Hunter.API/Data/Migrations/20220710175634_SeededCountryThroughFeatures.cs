using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Hunter.API.Data.Migrations
{
    public partial class SeededCountryThroughFeatures : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "IdentityRole",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IdentityRole", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Companys",
                columns: new[] { "Id", "Account", "Address", "Billing", "Method", "Name", "NextChargeOccurs", "Region", "StartChargeableSvcs" },
                values: new object[] { 1, "DebitCard goes here", "Accounting Office", "Patch", "Auto Monthly Debit", "Solution Hunter Engineering", new DateTime(2022, 8, 9, 13, 56, 34, 802, DateTimeKind.Local).AddTicks(9685), "NewEngland", new DateTime(2022, 7, 10, 13, 56, 34, 802, DateTimeKind.Local).AddTicks(9655) });

            migrationBuilder.InsertData(
                table: "IdentityRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "350d32bd-2bef-4c1f-b1cb-d47fea4fd043", "daab32f7-ebe2-43a2-98ba-bd2c8bc2f886", "Visitor", "VISITOR" },
                    { "36fb76f4-efa8-4776-be78-f89f4679fe78", "d40a6b52-3966-4e99-8f88-488e36a21dc8", "Administrator", "ADMINISTRATOR" },
                    { "4b16ca6f-fcd0-4703-86f4-080ae56b1323", "7fb37a9f-7ca7-4137-9eda-e81d2519d208", "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "Projects",
                columns: new[] { "Id", "CompanyId", "Description", "Designer", "Runner", "Title" },
                values: new object[] { 1, 1, null, "Chuck Duncan", "Buttons Duncan", "Sample Project" });

            migrationBuilder.InsertData(
                table: "Populations",
                columns: new[] { "Id", "Era", "Evolution", "ProjectId", "initialEra", "isActive" },
                values: new object[] { 1, 0, 0, 1, "", true });

            migrationBuilder.InsertData(
                table: "Individuals",
                columns: new[] { "Id", "Fitness", "Generations", "PopulationId", "PopulationPosition" },
                values: new object[] { 1, 0.0, 0, 1, 0 });

            migrationBuilder.InsertData(
                table: "Features",
                columns: new[] { "Id", "Description", "IndividualId", "Title" },
                values: new object[] { 1, null, 1, null });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "IdentityRole");

            migrationBuilder.DeleteData(
                table: "Features",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Individuals",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Populations",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Companys",
                keyColumn: "Id",
                keyValue: 1);
        }
    }
}
