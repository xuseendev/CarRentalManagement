using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CarRentalManagement.Server.Data.Migrations
{
    public partial class SeededDefaultCarData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Colours",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2022, 8, 21, 10, 40, 6, 299, DateTimeKind.Local).AddTicks(5689), new DateTime(2022, 8, 21, 10, 40, 6, 299, DateTimeKind.Local).AddTicks(5711), "Black", "System" },
                    { 2, "System", new DateTime(2022, 8, 21, 10, 40, 6, 299, DateTimeKind.Local).AddTicks(5718), new DateTime(2022, 8, 21, 10, 40, 6, 299, DateTimeKind.Local).AddTicks(5719), "Blue", "System" }
                });

            migrationBuilder.InsertData(
                table: "Makes",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2022, 8, 21, 10, 40, 6, 299, DateTimeKind.Local).AddTicks(6163), new DateTime(2022, 8, 21, 10, 40, 6, 299, DateTimeKind.Local).AddTicks(6164), "Toyota", "System" },
                    { 2, "System", new DateTime(2022, 8, 21, 10, 40, 6, 299, DateTimeKind.Local).AddTicks(6169), new DateTime(2022, 8, 21, 10, 40, 6, 299, DateTimeKind.Local).AddTicks(6170), "Haize", "System" }
                });

            migrationBuilder.InsertData(
                table: "Models",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2022, 8, 21, 10, 40, 6, 299, DateTimeKind.Local).AddTicks(6309), new DateTime(2022, 8, 21, 10, 40, 6, 299, DateTimeKind.Local).AddTicks(6310), "Vits", "System" },
                    { 2, "System", new DateTime(2022, 8, 21, 10, 40, 6, 299, DateTimeKind.Local).AddTicks(6316), new DateTime(2022, 8, 21, 10, 40, 6, 299, DateTimeKind.Local).AddTicks(6316), "3 Series", "System" },
                    { 3, "System", new DateTime(2022, 8, 21, 10, 40, 6, 299, DateTimeKind.Local).AddTicks(6318), new DateTime(2022, 8, 21, 10, 40, 6, 299, DateTimeKind.Local).AddTicks(6319), "X5", "System" }
                });
        }

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
        }
    }
}
