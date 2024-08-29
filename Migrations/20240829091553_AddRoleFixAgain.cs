using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace lektion3.Migrations
{
    /// <inheritdoc />
    public partial class AddRoleFixAgain : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a2f72b31-779f-4afb-915e-72f90e98de11");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "bc453514-63af-4a2f-9366-d70fe0c2d9ea", null, "test", "TEST" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bc453514-63af-4a2f-9366-d70fe0c2d9ea");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "a2f72b31-779f-4afb-915e-72f90e98de11", null, "ADMIN", null });
        }
    }
}
