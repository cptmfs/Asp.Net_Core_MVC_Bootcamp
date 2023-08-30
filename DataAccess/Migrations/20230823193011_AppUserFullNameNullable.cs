using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class AppUserFullNameNullable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "07d66367-b506-4494-a967-c24ecde81e46");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "df78923d-cf88-4436-9a93-f22603ed4c24");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "726f7468-c6d6-4ab1-bdff-c1b17558c3d7");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ddc463d4-7b9e-46fe-8d59-2f94147a5f45");

            migrationBuilder.AddColumn<string>(
                name: "FullName",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "IdentityUser",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IdentityUser", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "0cba5d55-947d-4e0b-99ab-9c989e112722", null, "admin", "ADMIN" },
                    { "920de3be-014a-4855-b0d4-2027541a0953", null, "user", "USER" }
                });

            migrationBuilder.InsertData(
                table: "IdentityUser",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "835513f9-638e-407f-a986-bf7bb6dfef2b", 0, "ca2d11ad-fc5e-4087-a18f-1890f9d1aadf", "admin@gmail.com", true, false, null, null, "ADMIN", "admin123", null, false, "191d0d4f-fd51-495a-b8fc-2f6076c7a068", false, "admin" },
                    { "dede6485-632e-402e-be03-47594f87a3ad", 0, "37966fef-e3f5-458d-b947-850c38e33346", "user@gmail.com", true, false, null, null, "USER", "user123", null, false, "cdc8c70e-e02b-4e94-84d3-3134034484e0", false, "user" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "IdentityUser");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0cba5d55-947d-4e0b-99ab-9c989e112722");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "920de3be-014a-4855-b0d4-2027541a0953");

            migrationBuilder.DropColumn(
                name: "FullName",
                table: "AspNetUsers");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "07d66367-b506-4494-a967-c24ecde81e46", null, "admin", "ADMIN" },
                    { "df78923d-cf88-4436-9a93-f22603ed4c24", null, "user", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "726f7468-c6d6-4ab1-bdff-c1b17558c3d7", 0, "dee1979e-66ab-4ab2-8c8c-3e8b311d0ee4", "admin@gmail.com", true, false, null, null, "ADMIN", "admin123", null, false, "afd1fdfa-a5eb-43e8-88dd-50d2a073b8b3", false, "admin" },
                    { "ddc463d4-7b9e-46fe-8d59-2f94147a5f45", 0, "e83f1397-6fb5-44da-b63a-d28b78f5cbf9", "user@gmail.com", true, false, null, null, "USER", "user123", null, false, "1d102ea8-b4b1-4f73-a9c0-50419318f6af", false, "user" }
                });
        }
    }
}
