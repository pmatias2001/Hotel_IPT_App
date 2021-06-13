using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Hotel_IPT_App.Data.Migrations
{
    public partial class Db : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Legenda",
                table: "Fotos",
                type: "nvarchar(30)",
                maxLength: 30,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(20)",
                oldMaxLength: 20,
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "Quartos",
                columns: new[] { "IdQuarto", "Descricao", "Lotacao", "Piso", "Preco" },
                values: new object[,]
                {
                    { 1, "Retriever do Labrador", 3, 3, 20.3m },
                    { 2, "Serra da Estrela", 3, 3, 20.3m },
                    { 3, "Pastor Alemão", 3, 3, 20.3m },
                    { 4, "Dogue Alemão", 3, 3, 20.3m },
                    { 5, "S. Bernardo", 3, 3, 20.3m },
                    { 6, "Rafeiro do Alentejo", 3, 3, 20.3m },
                    { 7, "Golden Retriever", 3, 3, 20.3m },
                    { 8, "Border Collie", 3, 3, 20.3m }
                });

            migrationBuilder.InsertData(
                table: "Utilizadores",
                columns: new[] { "IdUser", "Contacto", "DataNasc", "Email", "NIF", "Nome" },
                values: new object[,]
                {
                    { 8, "961937768", new DateTime(2019, 4, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Paula.Vieira@clix.pt", "346871334", "Paula Soares" },
                    { 7, "961493756", new DateTime(2019, 4, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Alexandre.Dias@hotmail.com", "346871334", "Alexandre Vieira" },
                    { 6, "962125638", new DateTime(2019, 4, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Marcos.Rocha@sapo.pt", "346871334", "Marcos Rocha" },
                    { 1, "967197885", new DateTime(2019, 4, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Marisa.Freitas@iol.pt", "346871334", "Marisa Vieira" },
                    { 4, "967517256", new DateTime(2019, 4, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Paula.Lopes@iol.pt", "346871334", "Paula Silva" },
                    { 2, "963737476", new DateTime(2019, 4, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Fátima.Machado@gmail.com", "346871334", "Fátima Ribeiro" },
                    { 9, "964106478", new DateTime(2019, 4, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Mariline.Ribeiro@iol.pt", "346871334", "Mariline Santos" },
                    { 5, "967212144", new DateTime(2019, 4, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Mariline.Martins@sapo.pt", "346871334", "Mariline Marques" },
                    { 10, "964685937", new DateTime(2019, 4, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Roberto.Vieira@sapo.pt", "346871334", "Roberto Pinto" }
                });

            migrationBuilder.InsertData(
                table: "Fotos",
                columns: new[] { "IdFoto", "Data", "Legenda", "QuartoFK" },
                values: new object[,]
                {
                    { 1, new DateTime(2019, 5, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Retriever_do_labrador.jpg", 1 },
                    { 12, new DateTime(2017, 1, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "golden-retriever.jpg", 8 },
                    { 11, new DateTime(2018, 12, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "golden-retriever_2.jpg", 8 },
                    { 10, new DateTime(2020, 12, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "pastor_alemao.jpg", 7 },
                    { 9, new DateTime(2011, 1, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "pastor_alemao_2.jpg", 7 },
                    { 8, new DateTime(2020, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Rafeiro_do_Alentejo.jpg", 6 },
                    { 13, new DateTime(2020, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Golden-Retriever-1.jpg", 5 },
                    { 14, new DateTime(2021, 4, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dogue_Alemao.jpg", 7 },
                    { 6, new DateTime(2013, 10, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "serra_da_estrela.jpg", 5 },
                    { 5, new DateTime(2019, 3, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "s.bernardo_2.jpg", 4 },
                    { 4, new DateTime(2021, 1, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "s.bernardo.jpg", 3 },
                    { 15, new DateTime(2021, 2, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "border_collie.jpg", 2 },
                    { 3, new DateTime(2019, 11, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "Retriever_do_labrador_3.jpg", 2 },
                    { 2, new DateTime(2019, 5, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Retriever_do_labrador_2.jpg", 1 },
                    { 7, new DateTime(2012, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "serra_da_estrela_2.jpg", 5 }
                });

            migrationBuilder.InsertData(
                table: "Reservas",
                columns: new[] { "IdReserva", "DataFim", "DataInicial", "Estado", "NPessoas", "UserFK" },
                values: new object[,]
                {
                    { 8, new DateTime(2019, 4, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2013, 4, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 3, 7 },
                    { 7, new DateTime(2019, 4, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2010, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 3, 6 },
                    { 6, new DateTime(2019, 4, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2010, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 3, 6 },
                    { 4, new DateTime(2019, 4, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2008, 6, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 3, 5 },
                    { 2, new DateTime(2019, 4, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2019, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 3, 1 },
                    { 10, new DateTime(2019, 4, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2017, 3, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 3, 4 },
                    { 5, new DateTime(2019, 4, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2012, 8, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 3, 2 },
                    { 1, new DateTime(2019, 4, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2019, 4, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 3, 1 },
                    { 9, new DateTime(2019, 4, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2011, 5, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 3, 7 },
                    { 3, new DateTime(2019, 4, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2011, 3, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 3, 5 },
                    { 11, new DateTime(2019, 4, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2018, 1, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 3, 8 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Fotos",
                keyColumn: "IdFoto",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Fotos",
                keyColumn: "IdFoto",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Fotos",
                keyColumn: "IdFoto",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Fotos",
                keyColumn: "IdFoto",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Fotos",
                keyColumn: "IdFoto",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Fotos",
                keyColumn: "IdFoto",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Fotos",
                keyColumn: "IdFoto",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Fotos",
                keyColumn: "IdFoto",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Fotos",
                keyColumn: "IdFoto",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Fotos",
                keyColumn: "IdFoto",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Fotos",
                keyColumn: "IdFoto",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Fotos",
                keyColumn: "IdFoto",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Fotos",
                keyColumn: "IdFoto",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Fotos",
                keyColumn: "IdFoto",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Fotos",
                keyColumn: "IdFoto",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Reservas",
                keyColumn: "IdReserva",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Reservas",
                keyColumn: "IdReserva",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Reservas",
                keyColumn: "IdReserva",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Reservas",
                keyColumn: "IdReserva",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Reservas",
                keyColumn: "IdReserva",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Reservas",
                keyColumn: "IdReserva",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Reservas",
                keyColumn: "IdReserva",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Reservas",
                keyColumn: "IdReserva",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Reservas",
                keyColumn: "IdReserva",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Reservas",
                keyColumn: "IdReserva",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Reservas",
                keyColumn: "IdReserva",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Utilizadores",
                keyColumn: "IdUser",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Utilizadores",
                keyColumn: "IdUser",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Quartos",
                keyColumn: "IdQuarto",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Quartos",
                keyColumn: "IdQuarto",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Quartos",
                keyColumn: "IdQuarto",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Quartos",
                keyColumn: "IdQuarto",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Quartos",
                keyColumn: "IdQuarto",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Quartos",
                keyColumn: "IdQuarto",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Quartos",
                keyColumn: "IdQuarto",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Quartos",
                keyColumn: "IdQuarto",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Utilizadores",
                keyColumn: "IdUser",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Utilizadores",
                keyColumn: "IdUser",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Utilizadores",
                keyColumn: "IdUser",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Utilizadores",
                keyColumn: "IdUser",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Utilizadores",
                keyColumn: "IdUser",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Utilizadores",
                keyColumn: "IdUser",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Utilizadores",
                keyColumn: "IdUser",
                keyValue: 8);

            migrationBuilder.AlterColumn<string>(
                name: "Legenda",
                table: "Fotos",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(30)",
                oldMaxLength: 30,
                oldNullable: true);
        }
    }
}
