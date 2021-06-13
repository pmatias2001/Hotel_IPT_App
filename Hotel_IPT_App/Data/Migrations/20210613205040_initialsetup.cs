using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Hotel_IPT_App.Data.Migrations
{
    public partial class initialsetup : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Quartos",
                columns: table => new
                {
                    IdQuarto = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Piso = table.Column<int>(type: "int", nullable: false),
                    Descricao = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Lotacao = table.Column<int>(type: "int", nullable: false),
                    Preco = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Quartos", x => x.IdQuarto);
                });

            migrationBuilder.CreateTable(
                name: "Utilizadores",
                columns: table => new
                {
                    IdUser = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DataNasc = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Contacto = table.Column<string>(type: "nvarchar(14)", maxLength: 14, nullable: true),
                    NIF = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Utilizadores", x => x.IdUser);
                });

            migrationBuilder.CreateTable(
                name: "Fotos",
                columns: table => new
                {
                    IdFoto = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Legenda = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    Data = table.Column<DateTime>(type: "datetime2", nullable: false),
                    QuartoFK = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Fotos", x => x.IdFoto);
                    table.ForeignKey(
                        name: "FK_Fotos_Quartos_QuartoFK",
                        column: x => x.QuartoFK,
                        principalTable: "Quartos",
                        principalColumn: "IdQuarto",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Reservas",
                columns: table => new
                {
                    IdReserva = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DataInicial = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DataFim = table.Column<DateTime>(type: "datetime2", nullable: false),
                    NPessoas = table.Column<int>(type: "int", nullable: false),
                    Estado = table.Column<bool>(type: "bit", nullable: false),
                    UserFK = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reservas", x => x.IdReserva);
                    table.ForeignKey(
                        name: "FK_Reservas_Utilizadores_UserFK",
                        column: x => x.UserFK,
                        principalTable: "Utilizadores",
                        principalColumn: "IdUser",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "QuartosReservas",
                columns: table => new
                {
                    ListaQuartosIdQuarto = table.Column<int>(type: "int", nullable: false),
                    ListaReservasIdReserva = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_QuartosReservas", x => new { x.ListaQuartosIdQuarto, x.ListaReservasIdReserva });
                    table.ForeignKey(
                        name: "FK_QuartosReservas_Quartos_ListaQuartosIdQuarto",
                        column: x => x.ListaQuartosIdQuarto,
                        principalTable: "Quartos",
                        principalColumn: "IdQuarto",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_QuartosReservas_Reservas_ListaReservasIdReserva",
                        column: x => x.ListaReservasIdReserva,
                        principalTable: "Reservas",
                        principalColumn: "IdReserva",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Fotos_QuartoFK",
                table: "Fotos",
                column: "QuartoFK");

            migrationBuilder.CreateIndex(
                name: "IX_QuartosReservas_ListaReservasIdReserva",
                table: "QuartosReservas",
                column: "ListaReservasIdReserva");

            migrationBuilder.CreateIndex(
                name: "IX_Reservas_UserFK",
                table: "Reservas",
                column: "UserFK");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Fotos");

            migrationBuilder.DropTable(
                name: "QuartosReservas");

            migrationBuilder.DropTable(
                name: "Quartos");

            migrationBuilder.DropTable(
                name: "Reservas");

            migrationBuilder.DropTable(
                name: "Utilizadores");
        }
    }
}
