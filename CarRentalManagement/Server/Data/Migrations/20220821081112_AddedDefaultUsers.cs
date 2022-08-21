using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CarRentalManagement.Server.Data.Migrations
{
    public partial class AddedDefaultUsers : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LastName",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "023e1470-35c4-4ee6-af84-4d963521e8b9",
                column: "ConcurrencyStamp",
                value: "c118cc5f-1457-44a0-ad58-ef907aeac798");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "17f29565-37e6-41fb-bfde-4a96c7af0ab9",
                column: "ConcurrencyStamp",
                value: "28535fef-69a2-4336-b7a1-9b6cf2f53574");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "025869cc-4581-442e-bc43-16d1999d7d01", 0, "0d29bda2-c461-40f7-9a97-7951f7fd0f9b", "user@localhost.com", false, "System", "User", false, null, "user@LOCALHOST.COM", "USER@LOCALHOST.COM", "AQAAAAEAACcQAAAAENlI8HNv8+U3nk5lTVjjMZHzHL/VcjOEmISuMlXRhsi3ntGZOZ9M1jCzzPT7AuzTog==", null, false, "f7af0b7d-4779-4425-8735-89f3738abf40", false, "user@localhost.com" },
                    { "11aeffd0-539c-4ceb-8841-9f7f1e374d35", 0, "c84c0adb-fd3c-4141-8127-84a91d371cd7", "admin@localhost.com", false, "System", "Admin", false, null, "ADMIN@LOCALHOST.COM", "ADMIN@LOCALHOST.COM", "AQAAAAEAACcQAAAAENBrks10fk/++pBterRuOamOyJXjb7/aPFqhgD+98SL5tjZrOla2YN/pcSGIYdv6uA==", null, false, "a20b0abf-84d4-4414-8ab1-6e34369b6eff", false, "admin@localhost.com" }
                });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 8, 21, 11, 11, 11, 39, DateTimeKind.Local).AddTicks(1718), new DateTime(2022, 8, 21, 11, 11, 11, 39, DateTimeKind.Local).AddTicks(1742) });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 8, 21, 11, 11, 11, 39, DateTimeKind.Local).AddTicks(1747), new DateTime(2022, 8, 21, 11, 11, 11, 39, DateTimeKind.Local).AddTicks(1748) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 8, 21, 11, 11, 11, 39, DateTimeKind.Local).AddTicks(2198), new DateTime(2022, 8, 21, 11, 11, 11, 39, DateTimeKind.Local).AddTicks(2201) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 8, 21, 11, 11, 11, 39, DateTimeKind.Local).AddTicks(2205), new DateTime(2022, 8, 21, 11, 11, 11, 39, DateTimeKind.Local).AddTicks(2206) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 8, 21, 11, 11, 11, 39, DateTimeKind.Local).AddTicks(2371), new DateTime(2022, 8, 21, 11, 11, 11, 39, DateTimeKind.Local).AddTicks(2372) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 8, 21, 11, 11, 11, 39, DateTimeKind.Local).AddTicks(2374), new DateTime(2022, 8, 21, 11, 11, 11, 39, DateTimeKind.Local).AddTicks(2375) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 8, 21, 11, 11, 11, 39, DateTimeKind.Local).AddTicks(2377), new DateTime(2022, 8, 21, 11, 11, 11, 39, DateTimeKind.Local).AddTicks(2378) });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "17f29565-37e6-41fb-bfde-4a96c7af0ab9", "025869cc-4581-442e-bc43-16d1999d7d01" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "023e1470-35c4-4ee6-af84-4d963521e8b9", "11aeffd0-539c-4ceb-8841-9f7f1e374d35" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "17f29565-37e6-41fb-bfde-4a96c7af0ab9", "025869cc-4581-442e-bc43-16d1999d7d01" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "023e1470-35c4-4ee6-af84-4d963521e8b9", "11aeffd0-539c-4ceb-8841-9f7f1e374d35" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "025869cc-4581-442e-bc43-16d1999d7d01");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "11aeffd0-539c-4ceb-8841-9f7f1e374d35");

            migrationBuilder.DropColumn(
                name: "FirstName",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "LastName",
                table: "AspNetUsers");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "023e1470-35c4-4ee6-af84-4d963521e8b9",
                column: "ConcurrencyStamp",
                value: "bd03ed26-627b-40a0-a29e-65913b8c5d39");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "17f29565-37e6-41fb-bfde-4a96c7af0ab9",
                column: "ConcurrencyStamp",
                value: "1daf881d-8032-447c-84c1-aad99da8c120");

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
    }
}
