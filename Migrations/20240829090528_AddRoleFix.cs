using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace lektion3.Migrations
{
    /// <inheritdoc />
    public partial class AddRoleFix : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e122c10a-685b-41e9-9839-cac97bf8b910");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "a2f72b31-779f-4afb-915e-72f90e98de11", null, "ADMIN", null });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a2f72b31-779f-4afb-915e-72f90e98de11");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "e122c10a-685b-41e9-9839-cac97bf8b910", null, "admin", null });
        }
    }
}
