using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CarRentalManagement.Server.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddedDefaultDataAndUser : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Colours",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2024, 1, 9, 17, 38, 38, 392, DateTimeKind.Local).AddTicks(3284), new DateTime(2024, 1, 9, 17, 38, 38, 392, DateTimeKind.Local).AddTicks(3298), "Black", "System" },
                    { 2, "System", new DateTime(2024, 1, 9, 17, 38, 38, 392, DateTimeKind.Local).AddTicks(3302), new DateTime(2024, 1, 9, 17, 38, 38, 392, DateTimeKind.Local).AddTicks(3303), "Blue", "System" }
                });

            migrationBuilder.InsertData(
                table: "Makes",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2024, 1, 9, 17, 38, 38, 392, DateTimeKind.Local).AddTicks(3976), new DateTime(2024, 1, 9, 17, 38, 38, 392, DateTimeKind.Local).AddTicks(3978), "BMW", "System" },
                    { 2, "System", new DateTime(2024, 1, 9, 17, 38, 38, 392, DateTimeKind.Local).AddTicks(3980), new DateTime(2024, 1, 9, 17, 38, 38, 392, DateTimeKind.Local).AddTicks(3981), "Toyota", "System" }
                });

            migrationBuilder.InsertData(
                table: "Models",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2024, 1, 9, 17, 38, 38, 392, DateTimeKind.Local).AddTicks(4314), new DateTime(2024, 1, 9, 17, 38, 38, 392, DateTimeKind.Local).AddTicks(4315), "3 Series", "System" },
                    { 2, "System", new DateTime(2024, 1, 9, 17, 38, 38, 392, DateTimeKind.Local).AddTicks(4317), new DateTime(2024, 1, 9, 17, 38, 38, 392, DateTimeKind.Local).AddTicks(4318), "X5", "System" },
                    { 3, "System", new DateTime(2024, 1, 9, 17, 38, 38, 392, DateTimeKind.Local).AddTicks(4320), new DateTime(2024, 1, 9, 17, 38, 38, 392, DateTimeKind.Local).AddTicks(4321), "Prius", "System" },
                    { 4, "System", new DateTime(2024, 1, 9, 17, 38, 38, 392, DateTimeKind.Local).AddTicks(4323), new DateTime(2024, 1, 9, 17, 38, 38, 392, DateTimeKind.Local).AddTicks(4324), "Rav4", "System" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 4);
        }
    }
}
