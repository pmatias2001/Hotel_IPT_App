using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Hotel_IPT_App.Data.Migrations
{
    public partial class UpdatePhotos : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.UpdateData(
                table: "Fotos",
                keyColumn: "IdFoto",
                keyValue: 1,
                column: "Fotografia",
                value: "hotel.jpg");

            migrationBuilder.UpdateData(
                table: "Fotos",
                keyColumn: "IdFoto",
                keyValue: 2,
                columns: new[] { "Data", "Fotografia", "QuartoFK" },
                values: new object[] { new DateTime(2019, 11, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "single_duplo.jpg", 2 });

            migrationBuilder.UpdateData(
                table: "Fotos",
                keyColumn: "IdFoto",
                keyValue: 3,
                columns: new[] { "Data", "Fotografia", "QuartoFK" },
                values: new object[] { new DateTime(2021, 1, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "kingsize_chill.jpg", 3 });

            migrationBuilder.UpdateData(
                table: "Fotos",
                keyColumn: "IdFoto",
                keyValue: 4,
                columns: new[] { "Data", "Fotografia", "QuartoFK" },
                values: new object[] { new DateTime(2019, 3, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "kingsize_vista.jpg", 4 });

            migrationBuilder.UpdateData(
                table: "Fotos",
                keyColumn: "IdFoto",
                keyValue: 5,
                columns: new[] { "Data", "Fotografia", "QuartoFK" },
                values: new object[] { new DateTime(2013, 10, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "single.jpg", 5 });

            migrationBuilder.UpdateData(
                table: "Fotos",
                keyColumn: "IdFoto",
                keyValue: 6,
                columns: new[] { "Data", "Fotografia", "QuartoFK" },
                values: new object[] { new DateTime(2020, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "kingsize_huge.jpg", 6 });

            migrationBuilder.UpdateData(
                table: "Fotos",
                keyColumn: "IdFoto",
                keyValue: 7,
                columns: new[] { "Data", "Fotografia", "QuartoFK" },
                values: new object[] { new DateTime(2011, 1, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "kingsize_duplo.jpg", 7 });

            migrationBuilder.UpdateData(
                table: "Fotos",
                keyColumn: "IdFoto",
                keyValue: 8,
                columns: new[] { "Data", "Fotografia", "QuartoFK" },
                values: new object[] { new DateTime(2018, 12, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "kingsize_love.jpg", 8 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Fotos",
                keyColumn: "IdFoto",
                keyValue: 1,
                column: "Fotografia",
                value: "Retriever_do_labrador.jpg");

            migrationBuilder.UpdateData(
                table: "Fotos",
                keyColumn: "IdFoto",
                keyValue: 2,
                columns: new[] { "Data", "Fotografia", "QuartoFK" },
                values: new object[] { new DateTime(2019, 5, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Retriever_do_labrador_2.jpg", 1 });

            migrationBuilder.UpdateData(
                table: "Fotos",
                keyColumn: "IdFoto",
                keyValue: 3,
                columns: new[] { "Data", "Fotografia", "QuartoFK" },
                values: new object[] { new DateTime(2019, 11, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "Retriever_do_labrador_3.jpg", 2 });

            migrationBuilder.UpdateData(
                table: "Fotos",
                keyColumn: "IdFoto",
                keyValue: 4,
                columns: new[] { "Data", "Fotografia", "QuartoFK" },
                values: new object[] { new DateTime(2021, 1, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "s.bernardo.jpg", 3 });

            migrationBuilder.UpdateData(
                table: "Fotos",
                keyColumn: "IdFoto",
                keyValue: 5,
                columns: new[] { "Data", "Fotografia", "QuartoFK" },
                values: new object[] { new DateTime(2019, 3, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "s.bernardo_2.jpg", 4 });

            migrationBuilder.UpdateData(
                table: "Fotos",
                keyColumn: "IdFoto",
                keyValue: 6,
                columns: new[] { "Data", "Fotografia", "QuartoFK" },
                values: new object[] { new DateTime(2013, 10, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "serra_da_estrela.jpg", 5 });

            migrationBuilder.UpdateData(
                table: "Fotos",
                keyColumn: "IdFoto",
                keyValue: 7,
                columns: new[] { "Data", "Fotografia", "QuartoFK" },
                values: new object[] { new DateTime(2012, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "serra_da_estrela_2.jpg", 5 });

            migrationBuilder.UpdateData(
                table: "Fotos",
                keyColumn: "IdFoto",
                keyValue: 8,
                columns: new[] { "Data", "Fotografia", "QuartoFK" },
                values: new object[] { new DateTime(2020, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Rafeiro_do_Alentejo.jpg", 6 });

            migrationBuilder.InsertData(
                table: "Fotos",
                columns: new[] { "IdFoto", "Data", "Fotografia", "QuartoFK" },
                values: new object[,]
                {
                    { 9, new DateTime(2011, 1, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "pastor_alemao_2.jpg", 7 },
                    { 10, new DateTime(2020, 12, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "pastor_alemao.jpg", 7 },
                    { 11, new DateTime(2018, 12, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "golden-retriever_2.jpg", 8 },
                    { 12, new DateTime(2017, 1, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "golden-retriever.jpg", 8 },
                    { 13, new DateTime(2020, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Golden-Retriever-1.jpg", 5 },
                    { 14, new DateTime(2021, 4, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dogue_Alemao.jpg", 7 },
                    { 15, new DateTime(2021, 2, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "border_collie.jpg", 2 }
                });
        }
    }
}
