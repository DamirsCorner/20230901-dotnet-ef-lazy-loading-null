using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EfCoreLazyLoadingNullError.Migrations
{
    /// <inheritdoc />
    public partial class SeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "CustomerId", "FirstName", "LastName", "MiddleName" },
                values: new object[] { 1, "John", "Doe", null });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "UserId", "CustomerId", "PasswordHash", "Username" },
                values: new object[] { 1, 1, "password", "johndoe" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 1);
        }
    }
}
