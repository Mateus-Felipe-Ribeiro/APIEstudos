using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace API.Migrations
{
    /// <inheritdoc />
    public partial class PasswordsUpdate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "58c53995-7da1-43c3-a921-94ff74a73d5b");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "84f7e469-ad94-41a5-bb58-cac684bc609e");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "50e18065-1738-4d65-963f-ef4f52f6c6a8", null, "Viewer", "VIEWER" },
                    { "b18775bf-c635-4e3d-87ef-7678038e46a5", null, "Administrator", "ADMINISTRATOR" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "50e18065-1738-4d65-963f-ef4f52f6c6a8");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b18775bf-c635-4e3d-87ef-7678038e46a5");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "58c53995-7da1-43c3-a921-94ff74a73d5b", null, "Viewer", "VIEWER" },
                    { "84f7e469-ad94-41a5-bb58-cac684bc609e", null, "Administrator", "ADMINISTRATOR" }
                });
        }
    }
}
