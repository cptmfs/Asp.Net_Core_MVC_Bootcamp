using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class ProductImageAdd : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AddColumn<string>(
                name: "ProductImage",
                table: "Products",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "006a698c-baac-44fe-9f12-c8d889aee895", null, "user", "USER" },
                    { "4bd332e6-17d2-47f7-a621-88361e2834d5", null, "admin", "ADMIN" }
                });

            migrationBuilder.InsertData(
                table: "IdentityUser",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "0409bab4-d52b-4224-98f2-b42ce9cd5075", 0, "a29181a4-7613-4a53-bbb3-286622e05685", "admin@gmail.com", true, false, null, null, "ADMIN", "admin123", null, false, "9301b55d-b944-4ec7-aa8e-ee0c006e34d8", false, "admin" },
                    { "a998ea22-4bb9-4abb-bab5-f7ee3fc2b395", 0, "4c238d55-014a-471b-aa0a-ffb3bdbe5055", "user@gmail.com", true, false, null, null, "USER", "user123", null, false, "351fb5ff-2143-4800-8e0c-2769cd258e2b", false, "user" }
                });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "ProductImage",
                value: null);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "ProductImage",
                value: null);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "ProductImage",
                value: null);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                column: "ProductImage",
                value: null);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                column: "ProductImage",
                value: null);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                column: "ProductImage",
                value: null);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                column: "ProductImage",
                value: null);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                column: "ProductImage",
                value: null);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                column: "ProductImage",
                value: null);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10,
                column: "ProductImage",
                value: null);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11,
                column: "ProductImage",
                value: null);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12,
                column: "ProductImage",
                value: null);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 13,
                column: "ProductImage",
                value: null);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 14,
                column: "ProductImage",
                value: null);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 15,
                column: "ProductImage",
                value: null);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 16,
                column: "ProductImage",
                value: null);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 17,
                column: "ProductImage",
                value: null);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 18,
                column: "ProductImage",
                value: null);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 19,
                column: "ProductImage",
                value: null);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 20,
                column: "ProductImage",
                value: null);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "006a698c-baac-44fe-9f12-c8d889aee895");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4bd332e6-17d2-47f7-a621-88361e2834d5");

            migrationBuilder.DeleteData(
                table: "IdentityUser",
                keyColumn: "Id",
                keyValue: "0409bab4-d52b-4224-98f2-b42ce9cd5075");

            migrationBuilder.DeleteData(
                table: "IdentityUser",
                keyColumn: "Id",
                keyValue: "a998ea22-4bb9-4abb-bab5-f7ee3fc2b395");

            migrationBuilder.DropColumn(
                name: "ProductImage",
                table: "Products");

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
    }
}
