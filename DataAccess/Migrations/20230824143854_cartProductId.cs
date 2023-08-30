using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class cartProductId : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4908cded-7961-458f-8084-f6911bf7b245");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9a3a0fe0-2aa7-4da2-87bb-6f984ff93828");

            migrationBuilder.DeleteData(
                table: "IdentityUser",
                keyColumn: "Id",
                keyValue: "4fbfb56d-3797-41d8-824f-01fa880bb76d");

            migrationBuilder.DeleteData(
                table: "IdentityUser",
                keyColumn: "Id",
                keyValue: "da55d02a-b918-4c9f-99c3-28ae26d31c0a");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "d3ee274c-562d-4030-8491-1a6bac80b8a3", null, "user", "USER" },
                    { "e8e8aeda-3113-44e8-9a73-0611bbf7b04b", null, "admin", "ADMIN" }
                });

            migrationBuilder.InsertData(
                table: "IdentityUser",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "00021a8c-5907-43bf-a86f-77857deb0962", 0, "7dda1e49-4a7c-45c9-a7a1-c0efb16bb196", "user@gmail.com", true, false, null, null, "USER", "user123", null, false, "bbecdab6-6bb0-4ee9-8502-56ffa893c5f6", false, "user" },
                    { "ca1e8b13-01df-4012-a55d-2a9bdeaf956f", 0, "1712cf38-4f8b-4819-b2b5-f5a015b9ab5a", "admin@gmail.com", true, false, null, null, "ADMIN", "admin123", null, false, "62f5ff9c-15df-496e-bda2-5b10fd2ae583", false, "admin" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d3ee274c-562d-4030-8491-1a6bac80b8a3");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e8e8aeda-3113-44e8-9a73-0611bbf7b04b");

            migrationBuilder.DeleteData(
                table: "IdentityUser",
                keyColumn: "Id",
                keyValue: "00021a8c-5907-43bf-a86f-77857deb0962");

            migrationBuilder.DeleteData(
                table: "IdentityUser",
                keyColumn: "Id",
                keyValue: "ca1e8b13-01df-4012-a55d-2a9bdeaf956f");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "4908cded-7961-458f-8084-f6911bf7b245", null, "admin", "ADMIN" },
                    { "9a3a0fe0-2aa7-4da2-87bb-6f984ff93828", null, "user", "USER" }
                });

            migrationBuilder.InsertData(
                table: "IdentityUser",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "4fbfb56d-3797-41d8-824f-01fa880bb76d", 0, "ba86f07d-a68e-4558-8376-8b52fedcfcd5", "user@gmail.com", true, false, null, null, "USER", "user123", null, false, "493b8ecc-767c-4dbd-b3ec-22a2ea316d61", false, "user" },
                    { "da55d02a-b918-4c9f-99c3-28ae26d31c0a", 0, "8c1e697a-ccc5-4582-b35a-7a817f40eddd", "admin@gmail.com", true, false, null, null, "ADMIN", "admin123", null, false, "d1f7b392-7659-4c89-b5e0-d7c3c10f9c1c", false, "admin" }
                });
        }
    }
}
