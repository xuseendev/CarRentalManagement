using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CarRentalManagement.Server.Data.Migrations
{
    public partial class SeededDefaultUserRole : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "023e1470-35c4-4ee6-af84-4d963521e8b9", "bd03ed26-627b-40a0-a29e-65913b8c5d39", "Administrator", "ADMINISTRATOR" },
                    { "17f29565-37e6-41fb-bfde-4a96c7af0ab9", "1daf881d-8032-447c-84c1-aad99da8c120", "User", "User" }
                });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 8, 21, 10, 51, 23, 848, DateTimeKind.Local).AddTicks(6605), new DateTime(2022, 8, 21, 10, 51, 23, 848, DateTimeKind.Local).AddTicks(6622) });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 8, 21, 10, 51, 23, 848, DateTimeKind.Local).AddTicks(6627), new DateTime(2022, 8, 21, 10, 51, 23, 848, DateTimeKind.Local).AddTicks(6628) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 8, 21, 10, 51, 23, 848, DateTimeKind.Local).AddTicks(6987), new DateTime(2022, 8, 21, 10, 51, 23, 848, DateTimeKind.Local).AddTicks(6988) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 8, 21, 10, 51, 23, 848, DateTimeKind.Local).AddTicks(6991), new DateTime(2022, 8, 21, 10, 51, 23, 848, DateTimeKind.Local).AddTicks(6992) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 8, 21, 10, 51, 23, 848, DateTimeKind.Local).AddTicks(7125), new DateTime(2022, 8, 21, 10, 51, 23, 848, DateTimeKind.Local).AddTicks(7126) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 8, 21, 10, 51, 23, 848, DateTimeKind.Local).AddTicks(7128), new DateTime(2022, 8, 21, 10, 51, 23, 848, DateTimeKind.Local).AddTicks(7129) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 8, 21, 10, 51, 23, 848, DateTimeKind.Local).AddTicks(7131), new DateTime(2022, 8, 21, 10, 51, 23, 848, DateTimeKind.Local).AddTicks(7132) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "023e1470-35c4-4ee6-af84-4d963521e8b9");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "17f29565-37e6-41fb-bfde-4a96c7af0ab9");

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 8, 21, 10, 40, 6, 299, DateTimeKind.Local).AddTicks(5689), new DateTime(2022, 8, 21, 10, 40, 6, 299, DateTimeKind.Local).AddTicks(5711) });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 8, 21, 10, 40, 6, 299, DateTimeKind.Local).AddTicks(5718), new DateTime(2022, 8, 21, 10, 40, 6, 299, DateTimeKind.Local).AddTicks(5719) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 8, 21, 10, 40, 6, 299, DateTimeKind.Local).AddTicks(6163), new DateTime(2022, 8, 21, 10, 40, 6, 299, DateTimeKind.Local).AddTicks(6164) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 8, 21, 10, 40, 6, 299, DateTimeKind.Local).AddTicks(6169), new DateTime(2022, 8, 21, 10, 40, 6, 299, DateTimeKind.Local).AddTicks(6170) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 8, 21, 10, 40, 6, 299, DateTimeKind.Local).AddTicks(6309), new DateTime(2022, 8, 21, 10, 40, 6, 299, DateTimeKind.Local).AddTicks(6310) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 8, 21, 10, 40, 6, 299, DateTimeKind.Local).AddTicks(6316), new DateTime(2022, 8, 21, 10, 40, 6, 299, DateTimeKind.Local).AddTicks(6316) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 8, 21, 10, 40, 6, 299, DateTimeKind.Local).AddTicks(6318), new DateTime(2022, 8, 21, 10, 40, 6, 299, DateTimeKind.Local).AddTicks(6319) });
        }
    }
}
