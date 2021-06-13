using Microsoft.EntityFrameworkCore.Migrations;

namespace Hotel_IPT_App.Data.Migrations
{
    public partial class Fotos : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Legenda",
                table: "Fotos");

            migrationBuilder.AddColumn<string>(
                name: "Fotografia",
                table: "Fotos",
                type: "nvarchar(max)",
                nullable: true);

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
                column: "Fotografia",
                value: "Retriever_do_labrador_2.jpg");

            migrationBuilder.UpdateData(
                table: "Fotos",
                keyColumn: "IdFoto",
                keyValue: 3,
                column: "Fotografia",
                value: "Retriever_do_labrador_3.jpg");

            migrationBuilder.UpdateData(
                table: "Fotos",
                keyColumn: "IdFoto",
                keyValue: 4,
                column: "Fotografia",
                value: "s.bernardo.jpg");

            migrationBuilder.UpdateData(
                table: "Fotos",
                keyColumn: "IdFoto",
                keyValue: 5,
                column: "Fotografia",
                value: "s.bernardo_2.jpg");

            migrationBuilder.UpdateData(
                table: "Fotos",
                keyColumn: "IdFoto",
                keyValue: 6,
                column: "Fotografia",
                value: "serra_da_estrela.jpg");

            migrationBuilder.UpdateData(
                table: "Fotos",
                keyColumn: "IdFoto",
                keyValue: 7,
                column: "Fotografia",
                value: "serra_da_estrela_2.jpg");

            migrationBuilder.UpdateData(
                table: "Fotos",
                keyColumn: "IdFoto",
                keyValue: 8,
                column: "Fotografia",
                value: "Rafeiro_do_Alentejo.jpg");

            migrationBuilder.UpdateData(
                table: "Fotos",
                keyColumn: "IdFoto",
                keyValue: 9,
                column: "Fotografia",
                value: "pastor_alemao_2.jpg");

            migrationBuilder.UpdateData(
                table: "Fotos",
                keyColumn: "IdFoto",
                keyValue: 10,
                column: "Fotografia",
                value: "pastor_alemao.jpg");

            migrationBuilder.UpdateData(
                table: "Fotos",
                keyColumn: "IdFoto",
                keyValue: 11,
                column: "Fotografia",
                value: "golden-retriever_2.jpg");

            migrationBuilder.UpdateData(
                table: "Fotos",
                keyColumn: "IdFoto",
                keyValue: 12,
                column: "Fotografia",
                value: "golden-retriever.jpg");

            migrationBuilder.UpdateData(
                table: "Fotos",
                keyColumn: "IdFoto",
                keyValue: 13,
                column: "Fotografia",
                value: "Golden-Retriever-1.jpg");

            migrationBuilder.UpdateData(
                table: "Fotos",
                keyColumn: "IdFoto",
                keyValue: 14,
                column: "Fotografia",
                value: "Dogue_Alemao.jpg");

            migrationBuilder.UpdateData(
                table: "Fotos",
                keyColumn: "IdFoto",
                keyValue: 15,
                column: "Fotografia",
                value: "border_collie.jpg");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Fotografia",
                table: "Fotos");

            migrationBuilder.AddColumn<string>(
                name: "Legenda",
                table: "Fotos",
                type: "nvarchar(30)",
                maxLength: 30,
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Fotos",
                keyColumn: "IdFoto",
                keyValue: 1,
                column: "Legenda",
                value: "Retriever_do_labrador.jpg");

            migrationBuilder.UpdateData(
                table: "Fotos",
                keyColumn: "IdFoto",
                keyValue: 2,
                column: "Legenda",
                value: "Retriever_do_labrador_2.jpg");

            migrationBuilder.UpdateData(
                table: "Fotos",
                keyColumn: "IdFoto",
                keyValue: 3,
                column: "Legenda",
                value: "Retriever_do_labrador_3.jpg");

            migrationBuilder.UpdateData(
                table: "Fotos",
                keyColumn: "IdFoto",
                keyValue: 4,
                column: "Legenda",
                value: "s.bernardo.jpg");

            migrationBuilder.UpdateData(
                table: "Fotos",
                keyColumn: "IdFoto",
                keyValue: 5,
                column: "Legenda",
                value: "s.bernardo_2.jpg");

            migrationBuilder.UpdateData(
                table: "Fotos",
                keyColumn: "IdFoto",
                keyValue: 6,
                column: "Legenda",
                value: "serra_da_estrela.jpg");

            migrationBuilder.UpdateData(
                table: "Fotos",
                keyColumn: "IdFoto",
                keyValue: 7,
                column: "Legenda",
                value: "serra_da_estrela_2.jpg");

            migrationBuilder.UpdateData(
                table: "Fotos",
                keyColumn: "IdFoto",
                keyValue: 8,
                column: "Legenda",
                value: "Rafeiro_do_Alentejo.jpg");

            migrationBuilder.UpdateData(
                table: "Fotos",
                keyColumn: "IdFoto",
                keyValue: 9,
                column: "Legenda",
                value: "pastor_alemao_2.jpg");

            migrationBuilder.UpdateData(
                table: "Fotos",
                keyColumn: "IdFoto",
                keyValue: 10,
                column: "Legenda",
                value: "pastor_alemao.jpg");

            migrationBuilder.UpdateData(
                table: "Fotos",
                keyColumn: "IdFoto",
                keyValue: 11,
                column: "Legenda",
                value: "golden-retriever_2.jpg");

            migrationBuilder.UpdateData(
                table: "Fotos",
                keyColumn: "IdFoto",
                keyValue: 12,
                column: "Legenda",
                value: "golden-retriever.jpg");

            migrationBuilder.UpdateData(
                table: "Fotos",
                keyColumn: "IdFoto",
                keyValue: 13,
                column: "Legenda",
                value: "Golden-Retriever-1.jpg");

            migrationBuilder.UpdateData(
                table: "Fotos",
                keyColumn: "IdFoto",
                keyValue: 14,
                column: "Legenda",
                value: "Dogue_Alemao.jpg");

            migrationBuilder.UpdateData(
                table: "Fotos",
                keyColumn: "IdFoto",
                keyValue: 15,
                column: "Legenda",
                value: "border_collie.jpg");
        }
    }
}
