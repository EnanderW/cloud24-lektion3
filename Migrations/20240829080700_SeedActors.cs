using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace lektion3.Migrations
{
    /// <inheritdoc />
    public partial class SeedActors : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Actors",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("79154997-c03c-45c2-bb6c-a75bff65bdd1"), "Dwayne Johnson" },
                    { new Guid("d0453149-ccc2-4689-8a0c-e0be47acad46"), "Robert Downey Jr." }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Actors",
                keyColumn: "Id",
                keyValue: new Guid("79154997-c03c-45c2-bb6c-a75bff65bdd1"));

            migrationBuilder.DeleteData(
                table: "Actors",
                keyColumn: "Id",
                keyValue: new Guid("d0453149-ccc2-4689-8a0c-e0be47acad46"));
        }
    }
}
