using Microsoft.EntityFrameworkCore.Migrations;

namespace Hotel_IPT_App.Data.Migrations
{
    public partial class IdentityRole : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "c", "cc9789e8-7ba0-48a8-8223-0df8ca8d7b40", "Criador", "CRIADOR" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c");
        }
    }
}
