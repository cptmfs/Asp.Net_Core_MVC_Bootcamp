using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class AddAppUserNameSurname : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0cba5d55-947d-4e0b-99ab-9c989e112722");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "920de3be-014a-4855-b0d4-2027541a0953");

            migrationBuilder.DeleteData(
                table: "IdentityUser",
                keyColumn: "Id",
                keyValue: "835513f9-638e-407f-a986-bf7bb6dfef2b");

            migrationBuilder.DeleteData(
                table: "IdentityUser",
                keyColumn: "Id",
                keyValue: "dede6485-632e-402e-be03-47594f87a3ad");

            migrationBuilder.RenameColumn(
                name: "FullName",
                table: "AspNetUsers",
                newName: "Surname");

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "7374bd7e-5941-4853-8ae5-23d87dcfee69", null, "user", "USER" },
                    { "8624b4a6-d38f-43e9-b6f0-87b524df082a", null, "admin", "ADMIN" }
                });

            migrationBuilder.InsertData(
                table: "IdentityUser",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "96ebff0e-7e17-496a-ab03-9d71646b1ac7", 0, "27e6d6ea-6f61-48af-92c7-db14256f10d6", "user@gmail.com", true, false, null, null, "USER", "user123", null, false, "ec50c71c-faf9-4907-b5e1-d820c964a1f4", false, "user" },
                    { "ee91a8ff-af47-4885-82db-8c580891c581", 0, "2fe2be67-9e53-45b4-9d64-32365c6366db", "admin@gmail.com", true, false, null, null, "ADMIN", "admin123", null, false, "733e82de-bfa1-4d3a-abcc-a74e49187bcd", false, "admin" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7374bd7e-5941-4853-8ae5-23d87dcfee69");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8624b4a6-d38f-43e9-b6f0-87b524df082a");

            migrationBuilder.DeleteData(
                table: "IdentityUser",
                keyColumn: "Id",
                keyValue: "96ebff0e-7e17-496a-ab03-9d71646b1ac7");

            migrationBuilder.DeleteData(
                table: "IdentityUser",
                keyColumn: "Id",
                keyValue: "ee91a8ff-af47-4885-82db-8c580891c581");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "AspNetUsers");

            migrationBuilder.RenameColumn(
                name: "Surname",
                table: "AspNetUsers",
                newName: "FullName");

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
    }
}
