using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Hotel_IPT_App.Data.Migrations
{
    public partial class login : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Reservas_Utilizadores_UserFK",
                table: "Reservas");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Utilizadores",
                table: "Utilizadores");

            migrationBuilder.DeleteData(
                table: "Utilizadores",
                keyColumn: "IdUser",
                keyColumnType: "int",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Utilizadores",
                keyColumn: "IdUser",
                keyColumnType: "int",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Utilizadores",
                keyColumn: "IdUser",
                keyColumnType: "int",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Utilizadores",
                keyColumn: "IdUser",
                keyColumnType: "int",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Utilizadores",
                keyColumn: "IdUser",
                keyColumnType: "int",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Utilizadores",
                keyColumn: "IdUser",
                keyColumnType: "int",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Utilizadores",
                keyColumn: "IdUser",
                keyColumnType: "int",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Utilizadores",
                keyColumn: "IdUser",
                keyColumnType: "int",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Utilizadores",
                keyColumn: "IdUser",
                keyColumnType: "int",
                keyValue: 10);

            migrationBuilder.DropColumn(
                name: "IdUser",
                table: "Utilizadores");

            migrationBuilder.DropColumn(
                name: "AccessFailedCount",
                table: "Utilizadores");

            migrationBuilder.DropColumn(
                name: "ConcurrencyStamp",
                table: "Utilizadores");

            migrationBuilder.DropColumn(
                name: "EmailConfirmed",
                table: "Utilizadores");

            migrationBuilder.DropColumn(
                name: "LockoutEnabled",
                table: "Utilizadores");

            migrationBuilder.DropColumn(
                name: "LockoutEnd",
                table: "Utilizadores");

            migrationBuilder.DropColumn(
                name: "NormalizedEmail",
                table: "Utilizadores");

            migrationBuilder.DropColumn(
                name: "NormalizedUserName",
                table: "Utilizadores");

            migrationBuilder.DropColumn(
                name: "PasswordHash",
                table: "Utilizadores");

            migrationBuilder.DropColumn(
                name: "PhoneNumber",
                table: "Utilizadores");

            migrationBuilder.DropColumn(
                name: "PhoneNumberConfirmed",
                table: "Utilizadores");

            migrationBuilder.DropColumn(
                name: "SecurityStamp",
                table: "Utilizadores");

            migrationBuilder.DropColumn(
                name: "TwoFactorEnabled",
                table: "Utilizadores");

            //migrationBuilder.AlterColumn<int>(
            //    name: "Id",
            //    table: "Utilizadores",
            //    type: "int",
            //    nullable: false,
            //    defaultValue: 0,
            //    oldClrType: typeof(string),
            //    oldType: "nvarchar(max)",
            //    oldNullable: true)
            //    .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AlterColumn<int>(
                name: "id",
                table: "utilizadores",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true)
                .Annotation("sqlserver:identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Utilizadores",
                table: "Utilizadores",
                column: "Id");

            migrationBuilder.InsertData(
                table: "Utilizadores",
                columns: new[] { "Id", "Contacto", "DataNasc", "Email", "NIF", "Nome", "UserName" },
                values: new object[,]
                {
                    { 1, "967197885", new DateTime(2019, 4, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Marisa.Freitas@ipt.pt", "346871334", "Marisa Vieira", null },
                    { 2, "963737476", new DateTime(2019, 4, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Fátima.Machado@ipt.pt", "346871334", "Fátima Ribeiro", null },
                    { 4, "967517256", new DateTime(2019, 4, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Paula.Lopes@ipt.pt", "346871334", "Paula Silva", null },
                    { 5, "967212144", new DateTime(2019, 4, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Mariline.Martins@ipt.pt", "346871334", "Mariline Marques", null },
                    { 6, "962125638", new DateTime(2019, 4, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Marcos.Rocha@ipt.pt", "346871334", "Marcos Rocha", null },
                    { 7, "961493756", new DateTime(2019, 4, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Alexandre.Dias@ipt.pt", "346871334", "Alexandre Vieira", null },
                    { 8, "961937768", new DateTime(2019, 4, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Paula.Vieira@ipt.pt", "346871334", "Paula Soares", null },
                    { 9, "964106478", new DateTime(2019, 4, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Mariline.Ribeiro@ipt.pt", "346871334", "Mariline Santos", null },
                    { 10, "964685937", new DateTime(2019, 4, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Roberto.Vieira@ipt.pt", "346871334", "Roberto Pinto", null }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_Reservas_Utilizadores_UserFK",
                table: "Reservas",
                column: "UserFK",
                principalTable: "Utilizadores",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Reservas_Utilizadores_UserFK",
                table: "Reservas");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Utilizadores",
                table: "Utilizadores");

            migrationBuilder.DeleteData(
                table: "Utilizadores",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Utilizadores",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Utilizadores",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Utilizadores",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Utilizadores",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Utilizadores",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Utilizadores",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Utilizadores",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Utilizadores",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.AlterColumn<string>(
                name: "Id",
                table: "Utilizadores",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<int>(
                name: "IdUser",
                table: "Utilizadores",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<int>(
                name: "AccessFailedCount",
                table: "Utilizadores",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "ConcurrencyStamp",
                table: "Utilizadores",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "EmailConfirmed",
                table: "Utilizadores",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "LockoutEnabled",
                table: "Utilizadores",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTimeOffset>(
                name: "LockoutEnd",
                table: "Utilizadores",
                type: "datetimeoffset",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "NormalizedEmail",
                table: "Utilizadores",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "NormalizedUserName",
                table: "Utilizadores",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PasswordHash",
                table: "Utilizadores",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PhoneNumber",
                table: "Utilizadores",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "PhoneNumberConfirmed",
                table: "Utilizadores",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "SecurityStamp",
                table: "Utilizadores",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "TwoFactorEnabled",
                table: "Utilizadores",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Utilizadores",
                table: "Utilizadores",
                column: "IdUser");

            migrationBuilder.InsertData(
                table: "Utilizadores",
                columns: new[] { "IdUser", "AccessFailedCount", "ConcurrencyStamp", "Contacto", "DataNasc", "Email", "EmailConfirmed", "Id", "LockoutEnabled", "LockoutEnd", "NIF", "Nome", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { 1, 0, "fb45e4e6-0919-4367-a449-7fea4125d048", "967197885", new DateTime(2019, 4, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Marisa.Freitas@iol.pt", false, "3457bb89-cc89-4987-9098-95bb0cbbae0a", false, null, "346871334", "Marisa Vieira", null, null, null, null, false, "eb8c0a35-2f8b-4685-b378-7c55356b76c3", false, null },
                    { 2, 0, "0d98aab3-3481-4af8-b0f3-4423315a8616", "963737476", new DateTime(2019, 4, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Fátima.Machado@gmail.com", false, "ed121f2c-dde0-486b-8dec-fb2fcb88fabe", false, null, "346871334", "Fátima Ribeiro", null, null, null, null, false, "2afb0840-4a32-408c-9fbb-16f8543087f7", false, null },
                    { 4, 0, "a427e9ce-ffd2-4337-8e53-5012aa3a3c7a", "967517256", new DateTime(2019, 4, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Paula.Lopes@iol.pt", false, "48ac6f00-dfab-4c65-97e7-4f57bbdb9fd3", false, null, "346871334", "Paula Silva", null, null, null, null, false, "51c94dd7-e6cf-4224-b3e8-cb4712c1515f", false, null },
                    { 5, 0, "e11aa619-3a1f-4a80-b48f-9804ad56e90b", "967212144", new DateTime(2019, 4, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Mariline.Martins@sapo.pt", false, "b2427c6b-c376-4949-82f0-a3fcad7a4a97", false, null, "346871334", "Mariline Marques", null, null, null, null, false, "dea6e9de-ae9c-4762-9790-52390e7e014d", false, null },
                    { 6, 0, "f471d35c-9ca3-4834-b478-78e35134a0d4", "962125638", new DateTime(2019, 4, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Marcos.Rocha@sapo.pt", false, "4e60ba24-c269-4a10-9c2c-abdef40b2479", false, null, "346871334", "Marcos Rocha", null, null, null, null, false, "37f3f3c6-040c-47e4-8627-bec3121d7031", false, null },
                    { 7, 0, "93bf7630-ebf1-4ab8-a531-c6b74d0edc13", "961493756", new DateTime(2019, 4, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Alexandre.Dias@hotmail.com", false, "ae9e0552-32cc-4749-806d-9fff9ce52f40", false, null, "346871334", "Alexandre Vieira", null, null, null, null, false, "56c02c89-ec50-44ba-ae58-1eb9fa1d559c", false, null },
                    { 8, 0, "ecb7b0ec-a3de-4ab0-9f20-deb0a50ebce2", "961937768", new DateTime(2019, 4, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Paula.Vieira@clix.pt", false, "badce9ae-a93a-44b7-8b0d-0b6512288fd2", false, null, "346871334", "Paula Soares", null, null, null, null, false, "d2abc043-5019-405b-94c0-11e18450afc1", false, null },
                    { 9, 0, "baee3e3a-8c21-4372-9383-9d01424463fd", "964106478", new DateTime(2019, 4, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Mariline.Ribeiro@iol.pt", false, "728a6931-f8d3-47bf-ae95-f6cd95df7fea", false, null, "346871334", "Mariline Santos", null, null, null, null, false, "48d5365e-2025-469d-99d3-484ffb7ca09f", false, null },
                    { 10, 0, "2d6cea47-09d6-43d8-b5b8-9d410a3e4af3", "964685937", new DateTime(2019, 4, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Roberto.Vieira@sapo.pt", false, "54ed9e45-1e0e-4748-9098-dec674300ceb", false, null, "346871334", "Roberto Pinto", null, null, null, null, false, "42d74b4c-b3b1-486a-9d84-007566070aa7", false, null }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_Reservas_Utilizadores_UserFK",
                table: "Reservas",
                column: "UserFK",
                principalTable: "Utilizadores",
                principalColumn: "IdUser",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
