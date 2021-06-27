using Microsoft.EntityFrameworkCore.Migrations;

namespace Hotel_IPT_App.Data.Migrations
{
    public partial class test : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<double>(
                name: "Preco",
                table: "Quartos",
                type: "float",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.UpdateData(
                table: "Quartos",
                keyColumn: "IdQuarto",
                keyValue: 1,
                column: "Preco",
                value: 20.300000000000001);

            migrationBuilder.UpdateData(
                table: "Quartos",
                keyColumn: "IdQuarto",
                keyValue: 2,
                column: "Preco",
                value: 20.300000000000001);

            migrationBuilder.UpdateData(
                table: "Quartos",
                keyColumn: "IdQuarto",
                keyValue: 3,
                column: "Preco",
                value: 20.300000000000001);

            migrationBuilder.UpdateData(
                table: "Quartos",
                keyColumn: "IdQuarto",
                keyValue: 4,
                column: "Preco",
                value: 20.300000000000001);

            migrationBuilder.UpdateData(
                table: "Quartos",
                keyColumn: "IdQuarto",
                keyValue: 5,
                column: "Preco",
                value: 20.300000000000001);

            migrationBuilder.UpdateData(
                table: "Quartos",
                keyColumn: "IdQuarto",
                keyValue: 6,
                column: "Preco",
                value: 20.300000000000001);

            migrationBuilder.UpdateData(
                table: "Quartos",
                keyColumn: "IdQuarto",
                keyValue: 7,
                column: "Preco",
                value: 20.300000000000001);

            migrationBuilder.UpdateData(
                table: "Quartos",
                keyColumn: "IdQuarto",
                keyValue: 8,
                column: "Preco",
                value: 20.300000000000001);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<decimal>(
                name: "Preco",
                table: "Quartos",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(double),
                oldType: "float");

            migrationBuilder.UpdateData(
                table: "Quartos",
                keyColumn: "IdQuarto",
                keyValue: 1,
                column: "Preco",
                value: 20.3m);

            migrationBuilder.UpdateData(
                table: "Quartos",
                keyColumn: "IdQuarto",
                keyValue: 2,
                column: "Preco",
                value: 20.3m);

            migrationBuilder.UpdateData(
                table: "Quartos",
                keyColumn: "IdQuarto",
                keyValue: 3,
                column: "Preco",
                value: 20.3m);

            migrationBuilder.UpdateData(
                table: "Quartos",
                keyColumn: "IdQuarto",
                keyValue: 4,
                column: "Preco",
                value: 20.3m);

            migrationBuilder.UpdateData(
                table: "Quartos",
                keyColumn: "IdQuarto",
                keyValue: 5,
                column: "Preco",
                value: 20.3m);

            migrationBuilder.UpdateData(
                table: "Quartos",
                keyColumn: "IdQuarto",
                keyValue: 6,
                column: "Preco",
                value: 20.3m);

            migrationBuilder.UpdateData(
                table: "Quartos",
                keyColumn: "IdQuarto",
                keyValue: 7,
                column: "Preco",
                value: 20.3m);

            migrationBuilder.UpdateData(
                table: "Quartos",
                keyColumn: "IdQuarto",
                keyValue: 8,
                column: "Preco",
                value: 20.3m);
        }
    }
}
