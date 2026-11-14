using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace NationalBankSystem.Migrations
{
    /// <inheritdoc />
    public partial class seed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "branch",
                columns: new[] { "Code", "Address", "Name", "PhoneNumber" },
                values: new object[,]
                {
                    { 1, "Cairo - Tahrir St", "Main Branch", "01000000001" },
                    { 2, "Alex - Corniche St", "Cairo Branch", "01000000002" },
                    { 3, "Alex - madinat St", "sharqia Branch", "01000000002" },
                    { 4, "teba - 30e St", "Luxor Branch", "01000000002" },
                    { 5, "cairo - 312 St", "maadi Branch", "01000000002" }
                });

            migrationBuilder.InsertData(
                table: "Managers",
                columns: new[] { "Id", "Email", "FullName", "Hiredate", "PhoneNumber", "branchId" },
                values: new object[,]
                {
                    { 1, "ahmed.manager@bank.com", "Ahmed Ali", new DateTime(2022, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "01011111111", 1 },
                    { 2, "mahmoud.manager@bank.com", "Mahmoud Khaled", new DateTime(2023, 6, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "01022222222", 2 },
                    { 3, "ali.manager@bank.com", "ahmed ali", new DateTime(2023, 6, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "0103328229209", 3 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Managers",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Managers",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Managers",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "branch",
                keyColumn: "Code",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "branch",
                keyColumn: "Code",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "branch",
                keyColumn: "Code",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "branch",
                keyColumn: "Code",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "branch",
                keyColumn: "Code",
                keyValue: 3);
        }
    }
}
