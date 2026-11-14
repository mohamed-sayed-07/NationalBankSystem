using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace NationalBankSystem.Migrations
{
    /// <inheritdoc />
    public partial class caseeding : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Account",
                columns: new[] { "AccountNumber", "BranchCode", "accountType", "currentBalance", "openingDate" },
                values: new object[,]
                {
                    { 1001, 1, 0, 5000m, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1002, 1, 1, 10000m, new DateTime(2026, 1, 2, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Account",
                keyColumn: "AccountNumber",
                keyValue: 1001);

            migrationBuilder.DeleteData(
                table: "Account",
                keyColumn: "AccountNumber",
                keyValue: 1002);
        }
    }
}
