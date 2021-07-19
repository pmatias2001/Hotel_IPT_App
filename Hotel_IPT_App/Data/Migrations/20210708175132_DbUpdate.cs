using Microsoft.EntityFrameworkCore.Migrations;

namespace Hotel_IPT_App.Data.Migrations
{
    public partial class DbUpdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c",
                column: "ConcurrencyStamp",
                value: "84b84616-0183-4786-b11e-42e330e18f99");

            migrationBuilder.UpdateData(
                table: "Quartos",
                keyColumn: "IdQuarto",
                keyValue: 1,
                columns: new[] { "Descricao", "Piso", "Preco" },
                values: new object[] { "Quarto 101", 1, 200.0 });

            migrationBuilder.UpdateData(
                table: "Quartos",
                keyColumn: "IdQuarto",
                keyValue: 2,
                columns: new[] { "Descricao", "Piso", "Preco" },
                values: new object[] { "Quarto 102", 1, 400.0 });

            migrationBuilder.UpdateData(
                table: "Quartos",
                keyColumn: "IdQuarto",
                keyValue: 3,
                columns: new[] { "Descricao", "Piso", "Preco" },
                values: new object[] { "Quarto 201", 2, 350.0 });

            migrationBuilder.UpdateData(
                table: "Quartos",
                keyColumn: "IdQuarto",
                keyValue: 4,
                columns: new[] { "Descricao", "Piso", "Preco" },
                values: new object[] { "Quarto 202", 2, 250.0 });

            migrationBuilder.UpdateData(
                table: "Quartos",
                keyColumn: "IdQuarto",
                keyValue: 5,
                columns: new[] { "Descricao", "Preco" },
                values: new object[] { "Quarto 301", 500.0 });

            migrationBuilder.UpdateData(
                table: "Quartos",
                keyColumn: "IdQuarto",
                keyValue: 6,
                columns: new[] { "Descricao", "Preco" },
                values: new object[] { "Quarto 302", 400.0 });

            migrationBuilder.UpdateData(
                table: "Quartos",
                keyColumn: "IdQuarto",
                keyValue: 7,
                columns: new[] { "Descricao", "Piso", "Preco" },
                values: new object[] { "Quarto 401", 4, 200.0 });

            migrationBuilder.UpdateData(
                table: "Quartos",
                keyColumn: "IdQuarto",
                keyValue: 8,
                columns: new[] { "Descricao", "Piso", "Preco" },
                values: new object[] { "Quarto 402", 4, 350.0 });

            migrationBuilder.UpdateData(
                table: "Reservas",
                keyColumn: "IdReserva",
                keyValue: 1,
                column: "NPessoas",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Reservas",
                keyColumn: "IdReserva",
                keyValue: 2,
                column: "NPessoas",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Reservas",
                keyColumn: "IdReserva",
                keyValue: 3,
                column: "NPessoas",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Reservas",
                keyColumn: "IdReserva",
                keyValue: 4,
                column: "NPessoas",
                value: 6);

            migrationBuilder.UpdateData(
                table: "Reservas",
                keyColumn: "IdReserva",
                keyValue: 5,
                column: "NPessoas",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Reservas",
                keyColumn: "IdReserva",
                keyValue: 6,
                column: "NPessoas",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Reservas",
                keyColumn: "IdReserva",
                keyValue: 7,
                column: "NPessoas",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Reservas",
                keyColumn: "IdReserva",
                keyValue: 8,
                column: "NPessoas",
                value: 6);

            migrationBuilder.UpdateData(
                table: "Reservas",
                keyColumn: "IdReserva",
                keyValue: 9,
                column: "NPessoas",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Reservas",
                keyColumn: "IdReserva",
                keyValue: 10,
                column: "NPessoas",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Reservas",
                keyColumn: "IdReserva",
                keyValue: 11,
                column: "NPessoas",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Utilizadores",
                keyColumn: "Id",
                keyValue: 2,
                column: "NIF",
                value: "348716334");

            migrationBuilder.UpdateData(
                table: "Utilizadores",
                keyColumn: "Id",
                keyValue: 4,
                column: "NIF",
                value: "346487134");

            migrationBuilder.UpdateData(
                table: "Utilizadores",
                keyColumn: "Id",
                keyValue: 5,
                column: "NIF",
                value: "346873324");

            migrationBuilder.UpdateData(
                table: "Utilizadores",
                keyColumn: "Id",
                keyValue: 6,
                column: "NIF",
                value: "468711334");

            migrationBuilder.UpdateData(
                table: "Utilizadores",
                keyColumn: "Id",
                keyValue: 7,
                column: "NIF",
                value: "368714334");

            migrationBuilder.UpdateData(
                table: "Utilizadores",
                keyColumn: "Id",
                keyValue: 8,
                column: "NIF",
                value: "346681334");

            migrationBuilder.UpdateData(
                table: "Utilizadores",
                keyColumn: "Id",
                keyValue: 9,
                column: "NIF",
                value: "346713334");

            migrationBuilder.UpdateData(
                table: "Utilizadores",
                keyColumn: "Id",
                keyValue: 10,
                column: "NIF",
                value: "934671334");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c",
                column: "ConcurrencyStamp",
                value: "cc9789e8-7ba0-48a8-8223-0df8ca8d7b40");

            migrationBuilder.UpdateData(
                table: "Quartos",
                keyColumn: "IdQuarto",
                keyValue: 1,
                columns: new[] { "Descricao", "Piso", "Preco" },
                values: new object[] { "Retriever do Labrador", 3, 20.300000000000001 });

            migrationBuilder.UpdateData(
                table: "Quartos",
                keyColumn: "IdQuarto",
                keyValue: 2,
                columns: new[] { "Descricao", "Piso", "Preco" },
                values: new object[] { "Serra da Estrela", 3, 20.300000000000001 });

            migrationBuilder.UpdateData(
                table: "Quartos",
                keyColumn: "IdQuarto",
                keyValue: 3,
                columns: new[] { "Descricao", "Piso", "Preco" },
                values: new object[] { "Pastor Alemão", 3, 20.300000000000001 });

            migrationBuilder.UpdateData(
                table: "Quartos",
                keyColumn: "IdQuarto",
                keyValue: 4,
                columns: new[] { "Descricao", "Piso", "Preco" },
                values: new object[] { "Dogue Alemão", 3, 20.300000000000001 });

            migrationBuilder.UpdateData(
                table: "Quartos",
                keyColumn: "IdQuarto",
                keyValue: 5,
                columns: new[] { "Descricao", "Preco" },
                values: new object[] { "S. Bernardo", 20.300000000000001 });

            migrationBuilder.UpdateData(
                table: "Quartos",
                keyColumn: "IdQuarto",
                keyValue: 6,
                columns: new[] { "Descricao", "Preco" },
                values: new object[] { "Rafeiro do Alentejo", 20.300000000000001 });

            migrationBuilder.UpdateData(
                table: "Quartos",
                keyColumn: "IdQuarto",
                keyValue: 7,
                columns: new[] { "Descricao", "Piso", "Preco" },
                values: new object[] { "Golden Retriever", 3, 20.300000000000001 });

            migrationBuilder.UpdateData(
                table: "Quartos",
                keyColumn: "IdQuarto",
                keyValue: 8,
                columns: new[] { "Descricao", "Piso", "Preco" },
                values: new object[] { "Border Collie", 3, 20.300000000000001 });

            migrationBuilder.UpdateData(
                table: "Reservas",
                keyColumn: "IdReserva",
                keyValue: 1,
                column: "NPessoas",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Reservas",
                keyColumn: "IdReserva",
                keyValue: 2,
                column: "NPessoas",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Reservas",
                keyColumn: "IdReserva",
                keyValue: 3,
                column: "NPessoas",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Reservas",
                keyColumn: "IdReserva",
                keyValue: 4,
                column: "NPessoas",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Reservas",
                keyColumn: "IdReserva",
                keyValue: 5,
                column: "NPessoas",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Reservas",
                keyColumn: "IdReserva",
                keyValue: 6,
                column: "NPessoas",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Reservas",
                keyColumn: "IdReserva",
                keyValue: 7,
                column: "NPessoas",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Reservas",
                keyColumn: "IdReserva",
                keyValue: 8,
                column: "NPessoas",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Reservas",
                keyColumn: "IdReserva",
                keyValue: 9,
                column: "NPessoas",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Reservas",
                keyColumn: "IdReserva",
                keyValue: 10,
                column: "NPessoas",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Reservas",
                keyColumn: "IdReserva",
                keyValue: 11,
                column: "NPessoas",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Utilizadores",
                keyColumn: "Id",
                keyValue: 2,
                column: "NIF",
                value: "346871334");

            migrationBuilder.UpdateData(
                table: "Utilizadores",
                keyColumn: "Id",
                keyValue: 4,
                column: "NIF",
                value: "346871334");

            migrationBuilder.UpdateData(
                table: "Utilizadores",
                keyColumn: "Id",
                keyValue: 5,
                column: "NIF",
                value: "346871334");

            migrationBuilder.UpdateData(
                table: "Utilizadores",
                keyColumn: "Id",
                keyValue: 6,
                column: "NIF",
                value: "346871334");

            migrationBuilder.UpdateData(
                table: "Utilizadores",
                keyColumn: "Id",
                keyValue: 7,
                column: "NIF",
                value: "346871334");

            migrationBuilder.UpdateData(
                table: "Utilizadores",
                keyColumn: "Id",
                keyValue: 8,
                column: "NIF",
                value: "346871334");

            migrationBuilder.UpdateData(
                table: "Utilizadores",
                keyColumn: "Id",
                keyValue: 9,
                column: "NIF",
                value: "346871334");

            migrationBuilder.UpdateData(
                table: "Utilizadores",
                keyColumn: "Id",
                keyValue: 10,
                column: "NIF",
                value: "346871334");
        }
    }
}
