using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class ShoppingListAdd : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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
                    { "7897e2bd-a306-4ec2-abb4-3de5d8127f5d", null, "admin", "ADMIN" },
                    { "f66fd072-c1d6-4811-8147-3e950c888c4b", null, "user", "USER" }
                });

            migrationBuilder.InsertData(
                table: "IdentityUser",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "1bd85e4e-6950-4443-ae6b-dc24cf829c9e", 0, "723ddd1b-f5d4-40a6-a847-d23c19ad3bc9", "user@gmail.com", true, false, null, null, "USER", "user123", null, false, "2b89aed1-81df-410c-871b-2530c07d277f", false, "user" },
                    { "8ef6174b-cf32-4263-b72b-2808a4649d28", 0, "c0d48dd0-0b01-44fa-aa24-c89f9586fef7", "admin@gmail.com", true, false, null, null, "ADMIN", "admin123", null, false, "9c60f2e7-f35c-4a33-a723-9288f33c4b81", false, "admin" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7897e2bd-a306-4ec2-abb4-3de5d8127f5d");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f66fd072-c1d6-4811-8147-3e950c888c4b");

            migrationBuilder.DeleteData(
                table: "IdentityUser",
                keyColumn: "Id",
                keyValue: "1bd85e4e-6950-4443-ae6b-dc24cf829c9e");

            migrationBuilder.DeleteData(
                table: "IdentityUser",
                keyColumn: "Id",
                keyValue: "8ef6174b-cf32-4263-b72b-2808a4649d28");

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
    }
}
