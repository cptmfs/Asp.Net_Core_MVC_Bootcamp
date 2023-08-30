using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class UserAndUserRolesSeedDataNormalizedName : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3ebe1d2b-3f7a-4273-8727-e7cbf928ef94");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3ec00960-5148-449b-a471-be68653a8ca2");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a7bdd1ef-7a82-4a27-827c-e0e46a1fb649");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c8f680b1-6103-44c7-a568-485330acffad");

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "3ebe1d2b-3f7a-4273-8727-e7cbf928ef94", null, "admin", "ADMIN" },
                    { "3ec00960-5148-449b-a471-be68653a8ca2", null, "user", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "a7bdd1ef-7a82-4a27-827c-e0e46a1fb649", 0, "2b1791ec-f26c-4413-a95c-c8159cba1a49", "user@gmail.com", true, false, null, null, null, "user123", null, false, "78ea7e80-fcd1-4c31-b9a2-e348594f00ab", false, "user" },
                    { "c8f680b1-6103-44c7-a568-485330acffad", 0, "b01cd9bf-5d7f-499a-8337-55aec916239e", "admin@gmail.com", true, false, null, null, null, "admin123", null, false, "7e40af6a-05f9-42e8-8897-c74ad236af22", false, "admin" }
                });
        }
    }
}
